using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    public partial class frm_hr_employee_asignacion_crud : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoTransaccionPlanilla
        {
            Nuevo = 1,
            Editar = 2
        }

        TipoTransaccionPlanilla transaccion_tipo;
        EmpleadoAsignacion asignacion = new EmpleadoAsignacion();

        UserLogin usuario = new UserLogin();
        int employee_id =0;

        public frm_hr_employee_asignacion_crud(TipoTransaccionPlanilla type_transaction,UserLogin usuario_class,int empleado_id)
        {
            InitializeComponent();
            CargarDatosTipoAsignacion();
            transaccion_tipo=type_transaction;
            usuario = usuario_class;
            employee_id=empleado_id;
            deFecha.EditValue = DateTime.Now;
        }

        public frm_hr_employee_asignacion_crud(TipoTransaccionPlanilla type_transaction, int id_asignacion)
        {
            InitializeComponent();
            CargarDatosTipoAsignacion();
            transaccion_tipo = type_transaction;
            asignacion.RecuperaRegistro(id_asignacion);
            searchLookUpEdit1.EditValue = asignacion.TipoAsignacionId;
            txtTalla.Text = asignacion.Talla;
            txtCantidad.EditValue=asignacion.Cantidad;
            deFecha.EditValue = DateTime.Now;

        }

        public void CargarDatosTipoAsignacion()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla1.hr_employee_asignacion_type.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadAsignacionTipo", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla1.hr_employee_asignacion_type);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (searchLookUpEdit1.EditValue==null)
            {
                CajaDialogo.Error("Debe de seleccionar un tipo");
                return;
            }

            if (txtCantidad.EditValue == null)
            {
                CajaDialogo.Error("Debe de ingresar una cantidad");
                return;
            }
            else
            {
                if (Convert.ToInt32(txtCantidad.Text)<=0)
                {
                    CajaDialogo.Error("la cantidad debe ser mayor que 0");
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtTalla.Text))
            {
                CajaDialogo.Error("Debe de ingresar una talla");
                return;
            }


            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                switch (transaccion_tipo)
                {
                    case TipoTransaccionPlanilla.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("dbo.[uspInsert_hr_employee_asignacion]", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@id_asignacion_tipo",searchLookUpEdit1.EditValue);
                            cmd.Parameters.AddWithValue("@user_id",usuario.Id);
                            cmd.Parameters.AddWithValue("@cantidad",txtCantidad.Text);
                            cmd.Parameters.AddWithValue("@talla", txtTalla.Text);
                            cmd.Parameters.AddWithValue("@employee_id", employee_id);
                            cmd.Parameters.AddWithValue("@fecha", deFecha.EditValue);

                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccionPlanilla.Editar:

                        using (SqlCommand cmd = new SqlCommand("dbo.uspUpdateAsignacionEmpleado", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            //cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = banco.ID;
                            cmd.Parameters.AddWithValue("@id_asignacion_tipo", searchLookUpEdit1.EditValue);
                            cmd.Parameters.AddWithValue("@id", asignacion.Id);
                            cmd.Parameters.AddWithValue("@cantidad", txtCantidad.Text);
                            cmd.Parameters.AddWithValue("@talla", txtTalla.Text);
                            cmd.Parameters.AddWithValue("@fecha", deFecha.EditValue);


                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Actualizados");
                        this.DialogResult = DialogResult.OK;
                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}