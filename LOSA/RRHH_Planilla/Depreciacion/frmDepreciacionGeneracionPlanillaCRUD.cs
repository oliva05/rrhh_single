using ACS.Classes;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.RRHH_Planilla.Planilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.Depreciacion
{
    public partial class frmDepreciacionGeneracionPlanillaCRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoOperacion
        { 
            Nuevo = 1,
            Editar = 2
        }

        TipoOperacion TipoOp;
        DataOperations dp = new DataOperations();
        Funciones func = new Funciones();
        UserLogin UsuarioLogeado;
        int IdHeader = 0;

        public frmDepreciacionGeneracionPlanillaCRUD(frmDepreciacionGeneracionPlanillaCRUD.TipoOperacion ptipoOperacion, UserLogin pUserLogin, int pIdPlanillaDepreciacion)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;
            TipoOp = ptipoOperacion;

            IdHeader = pIdPlanillaDepreciacion;
            LoadaDataEstados();

            switch (TipoOp)
            {
                case TipoOperacion.Nuevo:
                    dtFecha.DateTime = dp.Now();
                    grdMes.EditValue = dp.Now().Month;
                    gleEstado.EditValue = 1; //Borrador
                    txtTasaDeCambio.EditValue = 1.00;
                    txtDescripcionPaySlipRun.Text = "Planilla Depreciacion Vehicular: "+func.GetMonthNameForInt(dp.Now().Month) ;
                    LoadDataIni();
                    
                    break;
                case TipoOperacion.Editar:
                    PlanillaDepreciacion dep = new PlanillaDepreciacion();
                    dep.RecuperarPlanillaHeader(IdHeader);
                    txtDescripcionPaySlipRun.Text = dep.NamePlanilla;
                    gleEstado.EditValue = dep.IdEstado;
                    dtFecha.DateTime = dep.FechaCreacion;
                    grdMes.EditValue = dep.Mes;
                    txtTasaDeCambio.EditValue = dep.TasaCambio;
                    txtComentarios.Text = dep.Comentario;
                    txtMontoTotal.EditValue = dep.MontoTotal;
                    LoadDataIni();
                    break;
                default:
                    break;
            }

        }

        private void LoadDataIni()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_depreciacion_listados_header", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdHeader", IdHeader);
                dsDepreciacion1.lista_deprecicacion_d.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsDepreciacion1.lista_deprecicacion_d);
                con.Close();

                if  (IdHeader == 0)
                {
                    int UltimoRow = 0;
                    foreach (dsDepreciacion.lista_deprecicacion_dRow item in dsDepreciacion1.lista_deprecicacion_d)
                    {
                        if(item.row_num == 0)
                            item.row_num = UltimoRow + 1;
                        else
                            UltimoRow = item.row_num;
                    }
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadaDataEstados()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_depreciacion_get_planilla_estados", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@company_id", pIdCompany);
                dsDepreciacion1.estados.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsDepreciacion1.estados);

                SqlCommand cmdMes = new SqlCommand("sp_depreciacion_get_meses", con);
                cmdMes.CommandType = CommandType.StoredProcedure;
                dsDepreciacion1.meses.Clear();
                SqlDataAdapter adatMes = new SqlDataAdapter(cmdMes);
                adatMes.Fill(dsDepreciacion1.meses);

                con.Close();



            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcionPaySlipRun.Text))
            {
                CajaDialogo.Error("Debe agregar una Descripcion!");
                return;
            }

            if (Convert.ToDecimal(txtTasaDeCambio.EditValue) <= 0)
            {
                CajaDialogo.Error("Debe agregar una Tasa de Cambio Valida!");
                return;
            }

            foreach (dsDepreciacion.lista_deprecicacion_dRow item in dsDepreciacion1.lista_deprecicacion_d)
            {
                if (item.distancia <= 0)
                {
                    CajaDialogo.Error("Debe agregar la Distancia para el Calculo de Mantenimiento!");
                    return;
                }

                if (string.IsNullOrEmpty(item.distancia.ToString()))
                {
                    CajaDialogo.Error("Debe agregar la Distancia para el Calculo de Mantenimiento!");
                    return;
                }
            }

            bool Guardar = false;
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);

            switch (TipoOp)
            {
                case TipoOperacion.Nuevo:

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "sp_depreciacion_planilla_insert_h";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@descripcion",txtDescripcionPaySlipRun.Text);
                        cmd.Parameters.AddWithValue("@id_estado",gleEstado.EditValue);
                        cmd.Parameters.AddWithValue("@user_creacion",UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@tasa_cambio",txtTasaDeCambio.EditValue);
                        cmd.Parameters.AddWithValue("@mes", grdMes.EditValue);
                        cmd.Parameters.AddWithValue("@anio", dtFecha.DateTime.Year);
                        cmd.Parameters.AddWithValue("@monto_total", txtMontoTotal.EditValue);
                        cmd.Parameters.AddWithValue("@comentario", txtComentarios.Text);

                        int id_header = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsDepreciacion.lista_deprecicacion_dRow row in dsDepreciacion1.lista_deprecicacion_d.Rows)
                        {
                            if (row.seleccionado)
                            {
                                cmd.Parameters.Clear();
                                cmd.CommandText = "sp_depreciacion_generacion_detalle_saldos";
                                cmd.Connection = conn;
                                cmd.Transaction = transaction;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_h", id_header);
                                cmd.Parameters.AddWithValue("@nombre", row.nombre);
                                cmd.Parameters.AddWithValue("@id_empleado", row.id_empleado);
                                cmd.Parameters.AddWithValue("@user_creador", UsuarioLogeado.Id);
                                cmd.Parameters.AddWithValue("@id_prestamo", row.id_prestamo);
                                cmd.Parameters.AddWithValue("@tasa_cambio", txtTasaDeCambio.EditValue);
                                cmd.Parameters.AddWithValue("@distancia", row.distancia);
                                cmd.Parameters.AddWithValue("@num_pago", row.num_pago);
                                cmd.Parameters.AddWithValue("@reflejar_pago", row.reflejar_pago);
                                //cmd.Parameters.AddWithValue("",);
                                cmd.ExecuteNonQuery();
                            }
                        }


                        transaction.Commit();
                        Guardar = true;

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception ec)
                    {
                        try
                        {
                            transaction.Rollback();
                            CajaDialogo.Error(" Error 1: " + ec.Message);
                            Guardar = false;
                        }
                        catch (Exception ex2)
                        {
                            CajaDialogo.Error(ex2.Message + " Error 1: " + ec.Message);
                            Guardar = false;
                        }

                       
                    }

                    break;
                case TipoOperacion.Editar:

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "sp_depreciacion_planilla_update_h";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcionPaySlipRun.Text);
                        cmd.Parameters.AddWithValue("@id_estado", gleEstado.EditValue);
                        cmd.Parameters.AddWithValue("@user_creacion", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@tasa_cambio", Convert.ToDecimal(txtTasaDeCambio.EditValue));
                        cmd.Parameters.AddWithValue("@mes", grdMes.EditValue);
                        cmd.Parameters.AddWithValue("@anio", dtFecha.DateTime.Year);
                        cmd.Parameters.AddWithValue("@monto_total", txtMontoTotal.EditValue);
                        cmd.Parameters.AddWithValue("@comentario", txtComentarios.Text);
                        cmd.Parameters.AddWithValue("@id", IdHeader);
                        cmd.ExecuteNonQuery();
                        //int id_header = Convert.ToInt32(cmd.ExecuteScalar());

                        //foreach (dsDepreciacion.lista_deprecicacion_dRow row in dsDepreciacion1.lista_deprecicacion_d.Rows)
                        //{
                        //    cmd.Parameters.Clear();
                        //    cmd.CommandText = "";
                        //    cmd.Connection = conn;
                        //    cmd.Transaction = transaction;
                        //    cmd.CommandType = CommandType.StoredProcedure;
                        //    cmd.Parameters.AddWithValue("",);
                        //    cmd.Parameters.AddWithValue("",);
                        //    cmd.Parameters.AddWithValue("",);
                        //    cmd.Parameters.AddWithValue("",);
                        //    cmd.Parameters.AddWithValue("",);
                        //    cmd.Parameters.AddWithValue("",);
                        //    cmd.ExecuteNonQuery();
                        //}


                        transaction.Commit();
                        Guardar = true;

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }

                    break;
                default:
                    break;
            }
        }

        private void chkSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            foreach (dsDepreciacion.lista_deprecicacion_dRow row in dsDepreciacion1.lista_deprecicacion_d)
            {
                row.seleccionado = chkSeleccionarTodos.Checked;
            }
        }

        private void grdMes_EditValueChanged(object sender, EventArgs e)
        {
            int Mes = Convert.ToInt32(grdMes.EditValue);
            if (Mes > 0)
            {
                //txtDescripcionPaySlipRun =
                txtDescripcionPaySlipRun.Text = "Planilla Depreciacion Vehicular: " + func.GetMonthNameForInt(Mes);
            }
        }
    }
}