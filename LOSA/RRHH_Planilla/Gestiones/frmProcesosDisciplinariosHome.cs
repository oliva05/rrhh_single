using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.RRHH_Planilla.Capacitacion;
using LOSA.RRHH_Planilla.Gestiones;
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
    public partial class frmProcesosDisciplinariosHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLog;
        public frmProcesosDisciplinariosHome(UserLogin user)
        {
            InitializeComponent();
            usuarioLog = user;
            CargarDatos(DateTime.Now.Year);
            CargarVistaResumen(DateTime.Now.Year);
            CargarComboAnio();
            lueAnio.EditValue = DateTime.Now.Year;
        }

        public void CargarDatos(int anio)
        {
            try
            {
                DataOperations dp = new DataOperations();              

                dsGestiones1.procesos_disciplinarios.Clear();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("dbo.uspGetProcesosDisciplinarios_home", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@anio", anio);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
     
                    da.Fill(dsGestiones1.procesos_disciplinarios);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarComboAnio()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);


                dsGestiones1.anios_procesos.Clear();

                cnx.Open();
                SqlDataAdapter da = new SqlDataAdapter("dbo.uspCargarComboAniosProcesosDisciplinarios", cnx);
                da.Fill(dsGestiones1.anios_procesos);
                cnx.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarVistaResumen(int anio)
        {
            try
            {
                DataOperations dp = new DataOperations();


                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {

                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("dbo.uspGet_procesos_disciplinarios_resumen", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@anio", anio);
                    dsGestiones1.procesos_disciplinarios_resumen.Clear();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsGestiones1.procesos_disciplinarios_resumen);
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
                frmProcesosDisciplinariosCRUD frm = new frmProcesosDisciplinariosCRUD(frmProcesosDisciplinariosCRUD.TipoTransaccion.Nuevo, usuarioLog);

                if (frm.ShowDialog()== DialogResult.OK)
                {
                    CargarDatos(Convert.ToInt32(lueAnio.EditValue));
                    CargarComboAnio();
                    CargarVistaResumen(Convert.ToInt32(lueAnio.EditValue));

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
                var row = (dsGestiones.procesos_disciplinariosRow)gvProcesos.GetFocusedDataRow();

                if (row != null)
                {
                    frmProcesosDisciplinariosCRUD frm = new frmProcesosDisciplinariosCRUD(frmProcesosDisciplinariosCRUD.TipoTransaccion.Editar,row.id,usuarioLog);

                    if (frm.ShowDialog()== DialogResult.OK)
                    {
                        CargarDatos(Convert.ToInt32(lueAnio.EditValue));
                        CargarComboAnio();
                        CargarVistaResumen(Convert.ToInt32(lueAnio.EditValue));

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
            CargarDatos(Convert.ToInt32(lueAnio.EditValue));
            CargarVistaResumen(Convert.ToInt32(lueAnio.EditValue));
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsGestiones.procesos_disciplinariosRow)gvProcesos.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                   var respuesta= CajaDialogo.Pregunta("¿Desea eliminar el registro?");

                if (respuesta== DialogResult.Yes)
                {

                using (SqlCommand cmd = new SqlCommand("dbo.uspDisableProcesoDisciplinario", cnx))
                {
                    cnx.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                }

                    CajaDialogo.Information("Datos deshabilitados!");
                    CargarDatos(Convert.ToInt32(lueAnio.EditValue));
                    CargarComboAnio();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void lueAnio_EditValueChanged(object sender, EventArgs e)
        {
            if (lueAnio.EditValue!=null)
            {

            CargarDatos(Convert.ToInt32(lueAnio.EditValue));
            CargarVistaResumen(Convert.ToInt32(lueAnio.EditValue));
            }
            else
            {
                CajaDialogo.Error("DEBE DE SELECCIONAR UN AÑO");
                return;
            }
        }
    }
}