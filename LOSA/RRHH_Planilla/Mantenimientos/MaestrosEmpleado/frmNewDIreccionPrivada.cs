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

namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    public partial class frmNewDIreccionPrivada : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        string Codigo;
        string Nombre;
        public int idDireccion;
        bool PermiteGuardar;
        public frmNewDIreccionPrivada(UserLogin pUser, string pCodigo, string pNombre)
        {
            InitializeComponent();
            PermiteGuardar = false;
            UsuarioLogeado = pUser;
            lblCodigo.Text = Codigo = pCodigo;
            lblNombreEmpleado.Text = Nombre = pNombre;
        }

        private void txtDireccionName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                txtStreet.Focus();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (!PermiteGuardar)
            {
                CajaDialogo.Error("Es necesario ingresar datos validos para poder guardar una nueva dirección!");
                return;
            }

            if (string.IsNullOrEmpty(txtDireccionName.Text))
            {
                CajaDialogo.Error("Es necesario ingresar datos para poder guardar una dirección valida!");
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.set_insert_new_direccion_privada", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@direccion", txtDireccionName.Text);
                
                if(dp.ValidateStringIsNullOrEmpty(txtStreet.Text))
                    cmd.Parameters.AddWithValue("@street", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@street", txtStreet.Text);

                if (dp.ValidateStringIsNullOrEmpty(txtStreet2.Text))
                    cmd.Parameters.AddWithValue("@street2", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@street2", txtStreet2.Text);

                idDireccion = dp.ValidateNumberInt32(cmd.ExecuteScalar());  
                con.Close();

                this.DialogResult = DialogResult.OK;    
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void txtStreet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtStreet2.Focus();
        }

        private void txtStreet2_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtDireccionName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDireccionName.Text.Length >= 255)
            {
                dxErrorProvider1.SetError(txtDireccionName, "El maximo de caracteres permitido es de 255 caracteres");
                PermiteGuardar = false;
            }
            else
            {
                dxErrorProvider1.ClearErrors();
                PermiteGuardar = true;
            }
        }

        private void txtStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtStreet.Text.Length >= 255)
            {
                dxErrorProvider1.SetError(txtStreet, "El maximo de caracteres permitido es de 255 caracteres");
                PermiteGuardar = false;
            }
            else
            {
                dxErrorProvider1.ClearErrors();
                PermiteGuardar = true;
            }
        }

        private void txtStreet2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtStreet2.Text.Length >= 255)
            {
                dxErrorProvider1.SetError(txtStreet2, "El maximo de caracteres permitido es de 255 caracteres");
                PermiteGuardar = false;
            }
            else
            {
                dxErrorProvider1.ClearErrors();
                PermiteGuardar = true;
            }
        }

        private void frmNewDIreccionPrivada_Activated(object sender, EventArgs e)
        {
            txtDireccionName.Focus();
        }
    }
}