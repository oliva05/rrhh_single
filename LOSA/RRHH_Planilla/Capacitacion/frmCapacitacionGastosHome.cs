using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.RRHH_Planilla.Capacitacion;
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
using static LOSA.RRHH_Planilla.Mantenimientos.frmPlanillaCategoria;

namespace LOSA.RRHH_Planilla.Mantenimientos
{
    public partial class frmCapacitacionGastosHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLog;
        public frmCapacitacionGastosHome(UserLogin user)
        {
            InitializeComponent();
            usuarioLog = user;
            CargarDatos();
        }

        public void CargarDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsCapacitacion1.Gasto_Mantenimiento.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGet_tipo_gastos_home", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType= CommandType.StoredProcedure;

                    da.Fill(dsCapacitacion1.Gasto_Mantenimiento);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                frmCapacitacionGastosCRUD frm = new frmCapacitacionGastosCRUD(frmCapacitacionGastosCRUD.TipoTransaccionPlanilla.Nuevo, usuarioLog);

                if (frm.ShowDialog()== DialogResult.OK)
                {
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsCapacitacion.Gasto_MantenimientoRow)gvGastos.GetFocusedDataRow();

                if (row != null)
                {
                    frmCapacitacionGastosCRUD frm = new frmCapacitacionGastosCRUD(frmCapacitacionGastosCRUD.TipoTransaccionPlanilla.Editar,row.id,row.descripcion,usuarioLog);

                    if (frm.ShowDialog()== DialogResult.OK)
                    {
                        CargarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsCapacitacion.Gasto_MantenimientoRow)gvGastos.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                   var respuesta= CajaDialogo.Pregunta("¿Desea eliminar el registro?");

                if (respuesta== DialogResult.Yes)
                {

                using (SqlCommand cmd = new SqlCommand("dbo.uspDisable_Gasto_Capacitacion", cnx))
                {
                    cnx.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                }

                    CajaDialogo.Information("Datos deshabilitados!");
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}