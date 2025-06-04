using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases.Planilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    public partial class frmExpedienteCRUD : DevExpress.XtraEditors.XtraForm
    {
       public EmpleadoExpediente expediente= new EmpleadoExpediente();
        string file_name;
        string path;
        bool archivo_seleccionado=false;
        public frmExpedienteCRUD()
        {
            InitializeComponent();
            CargarTipo();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:/";

            // Establecer el filtro para solo permitir imágenes
            //openFileDialog1.Filter = "Archivos de imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //file_name_employee = openFileDialog1.SafeFileName;
                lblArchivo.Text= openFileDialog1.SafeFileName;
                file_name= openFileDialog1.SafeFileName;
                path = openFileDialog1.FileName;
                archivo_seleccionado = true;

                //Image image = Image.FromFile(path_employee_file);
                //pbPhoto.Image = image;
            }
        }

        public void CargarTipo()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMaestroEmpleados1.TipoExpediente.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetTipoExpediente", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMaestroEmpleados1.TipoExpediente);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                expediente = new EmpleadoExpediente();

                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    CajaDialogo.Error("Debe ingresar una descripción");
                    return;
                }

                if (slueTipo.EditValue== null)
                {
                    CajaDialogo.Error("Debe seleccionar un tipo");
                    return;
                }

                if (archivo_seleccionado== false)
                {
                    CajaDialogo.Error("Debe seleccionar un documento");
                    return;
                }

                expediente.Descripcion = txtDescripcion.Text;
                expediente.TipoId=Convert.ToInt32 (slueTipo.EditValue.ToString());
                expediente.Tipo=slueTipo.Text;
                expediente.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") +Path.GetExtension(file_name); 
                expediente.Path = path;
                expediente.FileNameOriginal = file_name;
 

                this.DialogResult= DialogResult.OK;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close ();
        }
    }
}