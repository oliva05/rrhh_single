﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using System.Net;
using System.IO;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;

namespace LOSA.MigracionACS.Tickets.EndUser
{
    public partial class frmTicketSeguimientoCRUD : DevExpress.XtraEditors.XtraForm
    {
        int id_ticket;
        UserLogin usuarioLogueado;
        int usuario_asignado;
        int usuario_creador;

        public frmTicketSeguimientoCRUD(int pId_ticket, int pusuario_asignado, int pusuario_creador,UserLogin pUserLogin)
        {
            InitializeComponent();

            id_ticket = pId_ticket;
            usuarioLogueado = pUserLogin;
            usuario_asignado = pusuario_asignado;
            usuario_creador = pusuario_creador;
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCopia_Click(object sender, EventArgs e)
        {
            frmCopiarCorreo frm = new frmCopiarCorreo(dsTickets.end_user);
            int Encontrado = 0;
            if (frm.ShowDialog() == DialogResult.OK)
            {

                //borrar los encontrados
                for (int p = 0; p < grdv_info.RowCount; p++)
                {
                    var row = (dsTickets.end_userRow)grdv_info.GetDataRow(p);
                    var copiaCorreo = frm.list.Find(x => x.ID == row.id);
                    frm.list.Remove(copiaCorreo);
                }


                foreach (var item in frm.list)
                {

                    DataRow dr = dsTickets.end_user.NewRow();
                    dr[0] = item.Correo;
                    dr[1] = item.CC;
                    dr[2] = item.ID;
                    dsTickets.end_user.Rows.Add(dr);
                    dsTickets.end_user.AcceptChanges();
                }
            }
        }

        private bool Upload(string pathFile, string fileName)
        {

            try
            {

                if (string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(fileName))
                {
                    CajaDialogo.Error("No se cargó la imagen");
                    return false;
                }
                else
                {
                    DataOperations dp = new DataOperations();

                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(dp.FTP_Tickets_ACS + fileName);
                    //request.Credentials = new NetworkCredential(dp.User_FTP_Server, dp.Password_UserFTPServer);
                    request.Credentials = new NetworkCredential(usuarioLogueado.AD_User, usuarioLogueado.Password);
                    request.Method = WebRequestMethods.Ftp.UploadFile;

                    using (Stream fileStream = File.OpenRead(pathFile))
                    using (Stream ftpStream = request.GetRequestStream())
                    {
                        fileStream.CopyTo(ftpStream);
                    }
                    return true;

                }
            }

            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        SqlTransaction transaction;
        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                if (string.IsNullOrEmpty(txtComentario.Text))
                {
                    CajaDialogo.Error("DEBE DE INGRESAR UN COMENTARIO");
                    return;
                }

                string query = @"sp_TK_insert_seguimiento";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                transaction = cn.BeginTransaction("SampleTransaction");

                SqlCommand cmd = new SqlCommand(query, transaction.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = transaction;

                cmd.Parameters.AddWithValue("@comentario", txtComentario.Text);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@id_ticket", id_ticket);
                cmd.Parameters.AddWithValue("@usuario_creador", usuario_creador);
                cmd.Parameters.AddWithValue("@usuario_asignado", usuario_asignado);

               int id_seguimiento= Convert.ToInt32( cmd.ExecuteScalar());





                string query2 = @"sp_TK_insert_mensaje";
                SqlCommand cmd2 = new SqlCommand(query2, transaction.Connection);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Transaction = transaction;

                cmd2.Parameters.AddWithValue("@user", usuarioLogueado.UserId);
                cmd2.Parameters.AddWithValue("@comentario", txtComentario.Text);

                    cmd2.Parameters.AddWithValue("@tittle", "Seguimiento de ticket");

                cmd2.Parameters.AddWithValue("@id_ticket", id_ticket);
                cmd2.Parameters.AddWithValue("@id_tipo", 2 /*Tipo Mantenimiento*/);
                int id_mensaje = Convert.ToInt32(cmd2.ExecuteScalar());


                //Guardar Detalle copia correo
                var gv = (GridView)grd_info.FocusedView;

                for (int i = 0; i < gv.RowCount; i++)
                {
                    var row = (dsTickets.end_userRow)grdv_info.GetDataRow(i);

                    SqlCommand cmd3 = new SqlCommand("sp_tk_insert_mensaje_destino", transaction.Connection);
                    cmd3.Transaction = transaction;
                    cmd3.CommandType = CommandType.StoredProcedure;

                    cmd3.Parameters.AddWithValue("@id_destino", SqlDbType.Int).Value = row.id;
                    cmd3.Parameters.AddWithValue("@copia", SqlDbType.Bit).Value = row.CC;
                    cmd3.Parameters.AddWithValue("@bit_copia", SqlDbType.Bit).Value = row.CC;
                    cmd3.Parameters.AddWithValue("@correo", SqlDbType.VarChar).Value = row.corro;
                    cmd3.Parameters.AddWithValue("@id_mensaje", SqlDbType.Int).Value = id_mensaje;
                    cmd3.Parameters.AddWithValue("@id_tipo", SqlDbType.Int).Value = 2 /*Tipo Mantenimiento*/;

                    cmd3.ExecuteNonQuery();
                }


                //Insertar archivos
                var gvArchivos = (GridView)grd_data.FocusedView;

                for (int i = 0; i < gvArchivos.RowCount; i++)
                {
                    var row = (dsTickets.archivosRow)gvArchivos.GetDataRow(i);

                    SqlCommand cmd4 = new SqlCommand("dbo.[sp_tk_insert_seguimiento_archivo_adjunto]", transaction.Connection);
                    cmd4.Transaction = transaction;
                    cmd4.CommandType = CommandType.StoredProcedure;

                    cmd4.Parameters.Add("@path", SqlDbType.VarChar).Value = dp.FTP_Tickets_ACS + row.FileNameFTP;
                    cmd4.Parameters.Add("@file_name", SqlDbType.VarChar).Value = row.FileName;
                    cmd4.Parameters.Add("@ticket_id", SqlDbType.Int).Value = id_ticket;
                    cmd4.Parameters.Add("@id_seguimiento", SqlDbType.Int).Value = id_seguimiento;

                    cmd4.ExecuteNonQuery();

                }



                //Subir los archivos luego de pasar el commit
                foreach (var item in dsTickets.archivos)
                {
                    Upload(item.Path, item.FileNameFTP);
                }
               
                transaction.Commit();
                cn.Close();

                CajaDialogo.Information("SEGUIMIENTO CREADO");
                this.DialogResult = DialogResult.OK;



            }
            catch (Exception EX)
            {
                CajaDialogo.Error(EX.Message);
                transaction.Rollback();
            }


        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            Dialog.InitialDirectory = "C:/";

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                //path = Dialog.SafeFileName;
                DataRow row = dsTickets.archivos.NewRow();
                row["path"] =  Dialog.FileName;
                row["FileName"] = Dialog.SafeFileName;
                row["FileNameFTP"] = DateTime.Now.Day.ToString().PadLeft(2, '0') + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Year.ToString().PadLeft(2, '0') + DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0') + DateTime.Now.Second.ToString().PadLeft(2, '0') + "_" + Dialog.SafeFileName;

                dsTickets.archivos.Rows.Add(row);
            }
        }

        private void btn_delete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            grdv_info.DeleteRow(grdv_info.FocusedRowHandle);
        }

        private void btneliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            grdv_data.DeleteRow(grdv_data.FocusedRowHandle);
        }

        private void frmTicketSeguimientoCRUD_Load(object sender, EventArgs e)
        {

        }
    }
    }