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

namespace LOSA.MigracionACS.SAP
{
    public partial class frmDetalleAsiento : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;

        DataOperations dp = new DataOperations();
        public frmDetalleAsiento(UserLogin userLogin)
        {
            InitializeComponent();
            UsuarioLogueado = userLogin;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = @"[sp_transaction_move_line_lps_confidencial]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPlanilla",137);
                cmd.Parameters.AddWithValue("@idHeaderMove",1);
                cmd.Parameters.AddWithValue("@payroll_type_id",1);
                cmd.Parameters.AddWithValue("@userId", UsuarioLogueado.Id);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsDataSetSAP1.DetalleAsiento.Clear();
                adat.Fill(dsDataSetSAP1.DetalleAsiento);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}