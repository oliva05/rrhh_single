using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.Clases.Planilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.Mantenimientos
{
    public partial class  frmPlanillaConf_ISR : DevExpress.XtraEditors.XtraForm
    {
        PlanillaConfiguracionISR isr = new PlanillaConfiguracionISR();
        DataOperations dp;
        decimal GastosMedicos;
        public enum TipoTransaccionPlanilla
        {
            Nuevo=1,
            Editar=2
        }

        TipoTransaccionPlanilla transaccion_tipo;

        UserLogin usuario = new UserLogin();
        int isr_id;
        public frmPlanillaConf_ISR(TipoTransaccionPlanilla transact,UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo= transact;
            usuario=user_p;
            dp = new DataOperations();
        }

        public frmPlanillaConf_ISR(TipoTransaccionPlanilla transact, int id_ISR, UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo = transact;
            isr_id = id_ISR;
            usuario = user_p;
            dp = new DataOperations();
        }

        SqlTransaction transaccion;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnio.Text))
            {
                CajaDialogo.Error("Debe de ingresar un año");
                return;
            }
            else
            {
                if (Convert.ToInt32(txtAnio.EditValue) <= 1999)
                {
                    CajaDialogo.Error("Es necesario ingresar un año reconocido!");
                    return;
                }
            }

            if (txtSalarioMinimo.EditValue == null)
            {
                CajaDialogo.Error("Debe de ingresar un salario mínimo");
                return;
            }
            else
            {
                if (Convert.ToDecimal(txtSalarioMinimo.EditValue)<= 0)
                {
                    CajaDialogo.Error("Es necesario ingresar el valor de Salario Mínimo reconocidos!");
                    return;
                }
            }

            if (transaccion_tipo==TipoTransaccionPlanilla.Nuevo)
            {
                if (ValidarAnio())
                {
                    CajaDialogo.Error("Este año ya existe");
                    return;
                }

            }

            if (string.IsNullOrEmpty(txtGastosMedicosAnuales.Text))
            {
                CajaDialogo.Error("Es necesario ingresar el valor de Gastos Medicos reconocidos!");
                return;
            }
            else
            {
                GastosMedicos = dp.ValidateNumberDecimal(txtGastosMedicosAnuales.EditValue);
                if (GastosMedicos < 0)
                {
                    CajaDialogo.Error("Es necesario ingresar el valor de Gastos Medicos reconocidos!");
                    return;
                }
            }
            

            if (gvISR.RowCount==0)
            {
                CajaDialogo.Error("Debe de ingresar la configuración del ISR");
                return;
            }


            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
                cnx.Open();
                transaccion = cnx.BeginTransaction();
                bool valida_proceso=false;
                int id_siguiente;

                // Crear una tabla en memoria que coincida con la definición del UDTT
                DataTable udttTable = new DataTable();
                udttTable.Columns.Add("id", typeof(int));
                udttTable.Columns.Add("id_conf_isr_h", typeof(int));
                udttTable.Columns.Add("descripcion", typeof(string));
                udttTable.Columns.Add("rango_inicial", typeof(decimal));
                udttTable.Columns.Add("rango_final", typeof(decimal));
                udttTable.Columns.Add("valor", typeof(decimal));
                udttTable.Columns.Add("create_uid", typeof(int));
                udttTable.Columns.Add("write_uid", typeof(int));
                udttTable.Columns.Add("limite_rango_final", typeof(bool));


                switch (transaccion_tipo)
                {
                    case TipoTransaccionPlanilla.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("dbo.[uspInsertConf_ISR_H]", transaccion.Connection))
                        {
                            cmd.CommandType= CommandType.StoredProcedure;
                            cmd.Transaction = transaccion;

                            cmd.Parameters.Add("@salario_minimo", SqlDbType.Decimal).Value=txtSalarioMinimo.EditValue;
                            cmd.Parameters.Add("@anio", SqlDbType.Int).Value=txtAnio.Text;
                            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value=txtDescripcion.Text;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.AddWithValue("@gastos_medicos", GastosMedicos);

                            id_siguiente = (int)cmd.ExecuteScalar();
                        }

                        foreach (var item in dsMantenimientoPlanilla1.Conf_ISR_detalle)
                        {
                            using (SqlCommand cmd2 = new SqlCommand("dbo.[uspInsert_conf_isr_detalle]", transaccion.Connection))
                            {
                                valida_proceso = false;
                                cmd2.CommandType = CommandType.StoredProcedure;
                                cmd2.Transaction = transaccion;

                                cmd2.Parameters.Add("@id_conf_isr_h", SqlDbType.Int).Value = id_siguiente;
                                cmd2.Parameters.Add("@rango_inicial", SqlDbType.Decimal).Value = item.rango_inicial;
                                cmd2.Parameters.Add("@rango_final", SqlDbType.Decimal).Value = item.rango_final;
                                cmd2.Parameters.Add("@valor", SqlDbType.Decimal).Value = item.valor;
                                cmd2.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = item.descripcion;
                                cmd2.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                                cmd2.Parameters.AddWithValue("@limite_rango_final", item.limite_rango_final);
                                cmd2.ExecuteNonQuery();
                                valida_proceso = true;
                            }
                        }


                        if (valida_proceso)
                        {
                            transaccion.Commit();
                            CajaDialogo.Information("Datos Guardados");
                            cnx.Close();
                        this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            transaccion.Rollback();
                            cnx.Close();
                            CajaDialogo.Error("Se produjo un error");
                        this.DialogResult = DialogResult.Cancel;
                        }
                        break;
                    case TipoTransaccionPlanilla.Editar:
                       
                        bool proceso_terminado=false;

                        using (SqlCommand cmd = new SqlCommand("dbo.uspUpdate_Conf_ISR_H", cnx))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Transaction = transaccion;
                            cmd.Parameters.Add("@salario_minimo", SqlDbType.Decimal).Value = txtSalarioMinimo.EditValue;
                            //cmd.Parameters.Add("@anio", SqlDbType.Int).Value = txtAnio.Text;
                            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@isr_id", SqlDbType.Int).Value = isr_id;
                            cmd.Parameters.AddWithValue("@gastos_medicos", GastosMedicos);
                            cmd.ExecuteNonQuery();
                                                      
                        }

                        foreach (var item in dsMantenimientoPlanilla1.Conf_ISR_detalle)
                        {
                            udttTable.Rows.Add(item.id,
                                               isr_id,
                                               item.descripcion,
                                               item.rango_inicial,
                                               item.rango_final,
                                               item.valor,
                                               usuario.Id, 
                                               usuario.Id,
                                               item.limite_rango_final);
                        }

                        using (SqlCommand command = new SqlCommand("uspUpdate_conf_isr_d", cnx))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Transaction = transaccion;

                            // Crear el parámetro con el UDTT
                            SqlParameter parameter = command.Parameters.AddWithValue("@ConfIsrData", udttTable);
                            parameter.SqlDbType = SqlDbType.Structured;
                            parameter.TypeName = "dbo.udtt_conf_isr_d";

                            // Ejecutar el comando
                            command.ExecuteNonQuery();
                            proceso_terminado = true;
                        }
                         

                        if (proceso_terminado)
                        {
                            transaccion.Commit();
                            CajaDialogo.Information("Datos Actualizados");
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            transaccion.Rollback();
                            CajaDialogo.Information("Se Produjo un error");
                            this.DialogResult = DialogResult.Cancel;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaccion.Rollback();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPlanillaCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                isr=new PlanillaConfiguracionISR();

                isr.RecuperaRegistro(isr_id);
                
                if (TipoTransaccionPlanilla.Editar==transaccion_tipo)
                {
                    txtAnio.Text= isr.Anio.ToString();
                    txtSalarioMinimo.Text= isr.SalarioMinimo.ToString();
                    txtDescripcion.Text= isr.Descripcion;
                    txtGastosMedicosAnuales.Text= string.Format("{0:###,##0.00}", isr.GastosMedicos);
                    CargarDetalleISR(isr_id);
                    txtAnio.Enabled=false;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

         
        public void CargarDetalleISR(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla1.Conf_ISR_detalle.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetConf_ISR_D_ByID", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@id",SqlDbType.Int).Value= id;

                    da.Fill(dsMantenimientoPlanilla1.Conf_ISR_detalle);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDelete_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsMantenimientoPlanilla.Conf_ISR_detalleRow)gvISR.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);


                if (row != null)
                {
                    if (row.id == 0) //es un registro nuevo
                    {
                        gvISR.DeleteRow(gvISR.FocusedRowHandle);
                    }
                    else
                    {

                        var respuesta = CajaDialogo.Pregunta("¿Desea eliminar el registro?");

                        if (respuesta == DialogResult.Yes)
                        {

                            using (SqlCommand cmd = new SqlCommand("dbo.uspDisable_conf_isr_d", cnx))
                            {
                                cnx.Open();
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                                cmd.ExecuteNonQuery();
                                cnx.Close();
                            }

                            CajaDialogo.Information("Datos deshabilitados!");
                            CargarDetalleISR(isr_id);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public bool ValidarAnio()
        {
            DataOperations dp = new DataOperations();
            SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
            bool existeISR=false;
            using (SqlCommand cmd = new SqlCommand("dbo.[uspValidateAnioISR]", cnx))
            {
                cnx.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@anio", SqlDbType.Int).Value = txtAnio.EditValue;


                 existeISR = (bool)cmd.ExecuteScalar();

                cnx.Close();


                //if (existe)
                //{
                //    CajaDialogo.Error("Este año ya existe");
                //    txtAnio.Focus();
                //    return;
                //}
            }

            return existeISR;
        }

        private void txtAnio_Leave(object sender, EventArgs e)
        {
            //if (txtAnio.EditValue!=null)
            //{
            //    ValidarAnio();

            //}
        }

        private void gvISR_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            switch(e.Column.FieldName) 
            {
                case "limite_rango_final":
                    bool TieneLimiteMaximo = Convert.ToBoolean(e.Value);
                    if (!TieneLimiteMaximo)
                    {
                        var gridView = (GridView)gcISR.FocusedView;
                        var row = (dsMantenimientoPlanilla.Conf_ISR_detalleRow)gridView.GetFocusedDataRow();
                        row.rango_final = 0;// DBNull.Value;
                    }
                    break;
                    default:
                    break;
            }
        }
    }
}