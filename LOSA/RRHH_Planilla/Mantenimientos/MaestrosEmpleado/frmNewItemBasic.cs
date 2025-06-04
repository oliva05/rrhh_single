using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Layout.Engine;
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

namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    public partial class frmNewItemBasic : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public int IdEscuelaUniversidad;
        public frmNewItemBasic(UserLogin pUsuarioLogeado, string pTituloVentana)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            this.Text = pTituloVentana;
            txtDescripcion.Focus();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDescripcion.Text)) 
            {
                CajaDialogo.Error("Es necesario escribir un nombre o descripción válida!");
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_insert_new_school_or_college", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", txtDescripcion.Text);

                if (dp.ValidateStringIsNullOrEmpty(txtDescripcionCorta.Text))
                    cmd.Parameters.AddWithValue("@short_name", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@short_name", txtDescripcionCorta.Text);

                IdEscuelaUniversidad = dp.ValidateNumberInt32(cmd.ExecuteScalar());
                con.Close();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtDescripcionCorta.Focus();
            }
        }
    }
}