using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
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
    public partial class frmPlanillaCategoriaHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLog;
        public frmPlanillaCategoriaHome(UserLogin user)
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

                dsMantenimientoPlanilla.Categoria.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadSalaryRuleCategoryV2", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType= CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla.Categoria);
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
                frmPlanillaCategoria frm = new frmPlanillaCategoria( TipoTransaccionPlanilla.Nuevo, usuarioLog);

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
                var row = (dsMantenimientoPlanilla.CategoriaRow)gvCaegoria.GetFocusedDataRow();

                if (row != null)
                {
                    frmPlanillaCategoria frm = new frmPlanillaCategoria(TipoTransaccionPlanilla.Editar,row.id);

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

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnDelete_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsMantenimientoPlanilla.CategoriaRow)gvCaegoria.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                var respuesta = CajaDialogo.Pregunta("¿Desea deshabilitar el registro?");

                if (respuesta == DialogResult.Yes)
                {

                    using (SqlCommand cmd = new SqlCommand("dbo.uspDisableSalaryRuleCategory", cnx))
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