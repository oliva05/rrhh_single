using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Accesos.AccesosUsuarios;
using LOSA.Clases;
using LOSA.RRHH_Planilla.Depreciacion;
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
using static LOSA.RRHH_Planilla.Depreciacion.dsDepreciacion;

namespace LOSA.RRHH_Planilla.Planilla
{
    public partial class frmCambiarEstadoPlanilla : DevExpress.XtraEditors.XtraForm
    {
        int IdEstadoActual;
        int IdPlanillaDepreciacion;
        UserLogin UsuarioLogeado;
        public int IdEstadoNew;
        public string EstadoNameNew;

        public frmCambiarEstadoPlanilla(UserLogin pUserLog, int pIdEstado, int pIdPlanillaDepre)
        {
            InitializeComponent();
            IdEstadoActual = pIdEstado;
            IdPlanillaDepreciacion = pIdPlanillaDepre;
            UsuarioLogeado = pUserLog;
            LoadDatos();
        }
        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
                cnx.Open();
                SqlCommand cmd = new SqlCommand("[sp_depreciacion_get_planilla_estados_not_in_id]", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_estado_actual", IdEstadoActual);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsDepreciacion1.cambiar_estado_planilla.Clear();
                adat.Fill(dsDepreciacion1.cambiar_estado_planilla);
                cnx.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            bool Contiunar = false;
            int IdEstadoNew = 0;
            foreach (dsDepreciacion.cambiar_estado_planillaRow item in dsDepreciacion1.cambiar_estado_planilla)
            {
                if (item.seleccionado == true)
                {
                    IdEstadoNew = item.id;
                    Contiunar = true;
                }
            }

            if (Contiunar)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("sp_depreciacion_cambiar_estado_planilla", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_estado_actual", IdEstadoNew);
                    cmd.Parameters.AddWithValue("@idPlanilla", IdPlanillaDepreciacion);
                    cmd.Parameters.AddWithValue("@UserId", UsuarioLogeado.Id);
                    cmd.ExecuteNonQuery();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex) 
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            else
            {
                CajaDialogo.Error("Debe seleccionar un Estado!");
                return;
            }
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "seleccionado")
            {
                var gridView = (GridView)gridControl1.FocusedView;
                var row = (dsDepreciacion.cambiar_estado_planillaRow)gridView.GetFocusedDataRow();
                if (Convert.ToBoolean(e.Value))
                {
                    IdEstadoNew = row.id;
                    EstadoNameNew = row.descripcion;
                    row.seleccionado = true;
                }

                foreach (dsDepreciacion.cambiar_estado_planillaRow row1 in dsDepreciacion1.cambiar_estado_planilla)
                {
                    if (row1.id != IdEstadoNew)
                        row1.seleccionado = false;
                }
            }
        }
    }
}