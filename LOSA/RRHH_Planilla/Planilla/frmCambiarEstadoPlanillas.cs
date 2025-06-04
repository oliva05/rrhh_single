using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Accesos.AccesosUsuarios;
using LOSA.Clases;
using LOSA.MigracionACS.Tickets.Clases;
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

namespace LOSA.RRHH_Planilla.Planilla
{
    public partial class frmCambiarEstadoPlanillas : DevExpress.XtraEditors.XtraForm
    {
        public int IdEstadoActual;
        public int IdEstadoNew;
        public string EstadoNameNew;
        int IdPayslipRun;
        UserLogin UsuarioLogeado;
        DataOperations dp;
        public frmCambiarEstadoPlanillas(UserLogin pUser, int pIdEstado, int pIdPayslipRun)
        {
            InitializeComponent();
            dp = new DataOperations();
            IdEstadoNew = 0;
            EstadoNameNew = string.Empty;
            IdEstadoActual = pIdEstado;
            UsuarioLogeado = pUser;
            IdPayslipRun = pIdPayslipRun;
            LoadDatos();
        }

        private void LoadDatos()
        {
            //get_estados_disponibles_planillaH_list
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
                cnx.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[get_estados_disponibles_planillaH_list]", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_estado_actual", IdEstadoActual);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPlanillasCalculo1.planillas_status.Clear();
                adat.Fill(dsPlanillasCalculo1.planillas_status);
                cnx.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "seleccionado")
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsPlanillasCalculo.planillas_statusRow)gridView.GetFocusedDataRow();
                if (Convert.ToBoolean(e.Value))
                {
                    IdEstadoNew = row.id;
                    EstadoNameNew = row.descripcion;
                    row.seleccionado = true;
                }

                foreach (dsPlanillasCalculo.planillas_statusRow row1 in dsPlanillasCalculo1.planillas_status)
                {
                    if (row1.id != IdEstadoNew)
                        row1.seleccionado = false;
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Confirme que esta seguro de cambiar el estado de esta planilla?");
            
            if(r != DialogResult.Yes)
                return;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
                cnx.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[UpdateStatePayslipRun]", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_paysliprun", IdPayslipRun);
                cmd.Parameters.AddWithValue("@id_estado_old", IdEstadoActual);
                cmd.Parameters.AddWithValue("@id_estado", IdEstadoNew);
                cmd.ExecuteNonQuery();
                cnx.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
        }
    }
}