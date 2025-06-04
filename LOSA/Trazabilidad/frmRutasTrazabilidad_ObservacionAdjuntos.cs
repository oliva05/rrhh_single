using ACS.Classes;
using DevExpress.Charts.Native;
using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.MigracionACS.Produccion.BannerTV;
using LOSA.RecepcionMP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Trazabilidad
{
    public partial class frmRutasTrazabilidad_ObservacionAdjuntos : DevExpress.XtraEditors.XtraForm
    {
        int LotePT;
        string ItemCodeMP;
        int IdMp;
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        FTP_Class FTP_Class = new FTP_Class();
        public frmRutasTrazabilidad_ObservacionAdjuntos(int lotePT, string itemCodeMP, UserLogin userLogin)
        {
            InitializeComponent();
            UsuarioLogueado = userLogin;
            LotePT = lotePT;
            txtLotePT.Text = lotePT.ToString();

            ItemCodeMP = itemCodeMP;
            MateriaPrima materiaPrima = new MateriaPrima();
            materiaPrima.RecuperarRegistroFromCode(ItemCodeMP);
            IdMp = materiaPrima.IdMP_ACS;
            txtMP.Text = ItemCodeMP + " - " + materiaPrima.Name; 

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = @"sp_rutas_trazabilidad_load_adjuntos";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LotePT",LotePT);
                cmd.Parameters.AddWithValue("@ItemCodeMP",ItemCodeMP);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMantoTrazabilidad1.rutas_adjuntos.Clear();
                adat.Fill(dsMantoTrazabilidad1.rutas_adjuntos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow dr = dsMantoTrazabilidad1.rutas_adjuntos.NewRow();
            dr[0] = 0;
            dr[1] = LotePT;
            dr[2] = IdMp;
            dr[3] = "";
            dr[4] = UsuarioLogueado.IdGrupo;
            dr[5] = UsuarioLogueado.Id;
            dr[6] = UsuarioLogueado.NombreUser;
            dr[7] = dp.Now();
            dr[8] = "";//path
            dr[9] = "";//file name
            dr[10] = "";

            dsMantoTrazabilidad1.rutas_adjuntos.Rows.Add(dr);
            dsMantoTrazabilidad1.rutas_adjuntos.AcceptChanges();

            //frmRutasTrazabilidad_ObservacionAdjuntosCRUD frm = new frmRutasTrazabilidad_ObservacionAdjuntosCRUD(UsuarioLogueado, LotePT, ItemCodeMP);
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    LoadData();
            //}

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reposOpenFile_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsMantoTrazabilidad.rutas_adjuntosRow)gridview.GetFocusedDataRow();

            if (string.IsNullOrWhiteSpace(row.path)) 
            {
                CajaDialogo.Error("No existe archivo cargado!");
                return;
            }
            else
            {
                if (row.guardado)
                {
                    //Buscar en FTP
                    string dir = @"C:\alosy_temp";
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }

                    DataOperations dp = new DataOperations();
                    string pathCompleto = dp.FTP_ALOSY_RutasTrazabilidad + row.path;

                    FTP_Class.OpenFile(pathCompleto, Path.GetFileName(pathCompleto),UsuarioLogueado);
                }
                else
                {
                    //Obtener del PathLocal
                    if (System.IO.File.Exists(row.path))
                    {
                        Process.Start(row.path);  
                    }
                }
            }
        }

        private void reposCargar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsMantoTrazabilidad.rutas_adjuntosRow)gridview.GetFocusedDataRow();

            try
            {
                xtraOpenFileDialog.InitialDirectory = "C:/";
                if (xtraOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    row.file_name = xtraOpenFileDialog.SafeFileName;
                    row.path = xtraOpenFileDialog.FileName;
                    row.guardado = false;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void reposDeleteObs_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsMantoTrazabilidad.rutas_adjuntosRow)gridview.GetFocusedDataRow();


            try
            {
                if (row.id == 0)
                {
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);
                    dsMantoTrazabilidad1.AcceptChanges();
                }
                else
                {
                    DialogResult r = CajaDialogo.Pregunta("Desea Eliminar esta Observacion?");
                    if (r == DialogResult.Yes) 
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sp_delete_obs_rutas_trazabilidad", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        gridView1.DeleteRow(gridView1.FocusedRowHandle);
                        dsMantoTrazabilidad1.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //Validacion
            foreach (dsMantoTrazabilidad.rutas_adjuntosRow row in dsMantoTrazabilidad1.rutas_adjuntos.Rows)
            {
                if (string.IsNullOrWhiteSpace(row.observacion))
                {
                    CajaDialogo.Error("Debe colocar una Observacion!");
                    return;
                }
            }

            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            bool Guardar = false;

            foreach (dsMantoTrazabilidad.rutas_adjuntosRow item in dsMantoTrazabilidad1.rutas_adjuntos.Rows)
            {
                try
                {
                   if (item.id == 0)
                    {
                        string Path_ = dp.FTP_ALOSY_RutasTrazabilidad+ string.Format("{0:MM_dd_yyyy_HH_mm_ss}", DateTime.Now) + "_" + item.file_name; 

                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "sp_rutas_trazabilidad_adjuntos_insert";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@lote_pt", item.lote_pt);
                        cmd.Parameters.AddWithValue("@id_mp", IdMp);
                        cmd.Parameters.AddWithValue("@observacion", item.observacion);
                        cmd.Parameters.AddWithValue("@grupo_losa", item.grupo_losa);
                        cmd.Parameters.AddWithValue("@path", Path_);
                        cmd.Parameters.AddWithValue("@file_name", item.file_name);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogueado.Id);
                        cmd.ExecuteNonQuery();

                        transaction.Commit();
                        Guardar = true;

                    }


                }
                catch (Exception ec)
                {
                    transaction.Rollback();
                    CajaDialogo.Error(ec.Message);
                    Guardar = false;
                }
            }

            if (Guardar)
            {
                LoadData();
            }
        }
    }
}