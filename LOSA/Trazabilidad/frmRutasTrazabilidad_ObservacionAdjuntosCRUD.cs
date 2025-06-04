using ACS.Classes;
using DevExpress.Utils.CommonDialogs;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.PrintLayoutEngine;
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

namespace LOSA.Trazabilidad
{
    public partial class frmRutasTrazabilidad_ObservacionAdjuntosCRUD : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLoegueado;
        int IdMp;
        string ItemCodeMP;
        string path;
        string file_name;

        public frmRutasTrazabilidad_ObservacionAdjuntosCRUD(UserLogin userLogin, int plotept, string pItemCodeMP)
        {
            InitializeComponent();
            UsuarioLoegueado = userLogin;
            ItemCodeMP = pItemCodeMP;
            txtPT.Text = plotept.ToString();
            MateriaPrima mp = new MateriaPrima();
            mp.RecuperarRegistroFromCode(ItemCodeMP);
            IdMp = mp.IdMP_ACS;
            txtMP.Text = mp.NameComercial;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtObs.Text))
            {
                CajaDialogo.Error("Debe agregar la observacion!");
                return;
            }


            SqlTransaction transaction = null;

            SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            bool Guardar = false;

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction("Transaction Order");

                FTP_Class fTP_Class = new FTP_Class();
                if (fTP_Class.GuardarArchviosRutasTrazabilidadObsevaciones(UsuarioLoegueado, file_name, path))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "sp_rutas_trazabilidad_adjuntos_insert";
                    cmd.Connection = conn;
                    cmd.Transaction = transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@lote_pt", txtPT.Text.ToString());
                    cmd.Parameters.AddWithValue("@id_mp", IdMp);
                    cmd.Parameters.AddWithValue("@observacion", txtObs.Text);
                    cmd.Parameters.AddWithValue("@path", path);
                    cmd.Parameters.AddWithValue("@file_name", file_name);
                    cmd.Parameters.AddWithValue("@user_id", UsuarioLoegueado.Id);

                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    Guardar = true;
                }
               
               
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ec)
            {
                transaction.Rollback();
                CajaDialogo.Error(ec.Message);
                Guardar = false;
            }

        }

        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Files|*.jpg;*.jpeg;*.png;*.pdf;*.xlsx";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file_name = openFileDialog1.SafeFileName;
                    path =  dp.FTP_ALOSY_RutasTrazabilidad + string.Format("{0:MM_dd_yyyy_HH_mm_ss}",DateTime.Now) + "_" + file_name;
                    //pbPhoto.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}