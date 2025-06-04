﻿using ACS.Classes;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using LOSA.MigracionACS.RRHH.Liquidaciones;
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

namespace LOSA.TransaccionesMP
{
    public partial class frmRequisiciones : Form
    {
        UserLogin UsuarioLogeado; DataOperations dp = new DataOperations();
        public frmRequisiciones(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            LoadDatos();

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
            gvTarimas.OptionsMenu.EnableColumnMenu = false;//Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc
            gvTarimas.Columns["cerrar_requisiciones"].Visible = false; //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el dataset
            switch (idNivel)
            {
                case 1://Basic View
                    break;
                case 2://Basic No Autorization
                    break;
                case 3://Medium Autorization
                case 4://Depth With Delta
                    accesoprevio = true;
                    gvTarimas.OptionsMenu.EnableColumnMenu = true;//Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc
                    gvTarimas.Columns["cerrar_requisiciones"].Visible = true; //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el dataset

                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(117))
                {
                    gvTarimas.OptionsMenu.EnableColumnMenu = true;//Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc
                    gvTarimas.Columns["cerrar_requisiciones"].Visible = true; //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el dataset
                }
                else
                {
                    gvTarimas.OptionsMenu.EnableColumnMenu = false;//Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna, para elegir columnas, ordenar, etc
                    gvTarimas.Columns["cerrar_requisiciones"].Visible = false; //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el dataset
                }
            }

            
        }

        private void LoadDatos()
        {
            try
            {
                
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_requisiciones_pendientes_h", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                dsTransaccionesMP1.requisiciones_h.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP1.requisiciones_h);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadDatos_Finalizadas()
        {
            try
            {

                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_requisiciones_pendientes_h_show_finalizadas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                dsTransaccionesMP1.requisiciones_h.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP1.requisiciones_h);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnVerD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Boton ver
            var gridView = (GridView)grRequisicoinesMP.FocusedView;
            var row = (dsTransaccionesMP.requisiciones_hRow)gridView.GetFocusedDataRow();

            frmRequisicionesDetalle frm = new frmRequisicionesDetalle(UsuarioLogeado, row.id, row.Lote, row.id_estado, row.nombre_comercial);
            frm.WindowState = FormWindowState.Maximized;
            if(frm.ShowDialog()== DialogResult.OK)
            {
                LoadDatos();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)grRequisicoinesMP.FocusedView;
            var row = (dsTransaccionesMP.requisiciones_hRow)gridView.GetFocusedDataRow();

            Requisiciones.Reportes.lblNumeroReq report = new Requisiciones.Reportes.lblNumeroReq(row.id, row.Lote);
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            report.ShowPrintMarginsWarning = false;
            //report.ShowPreview();
            report.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
            //report.Print();
            report.ShowPreviewDialog();

        }
        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //Indica el numero de copias de la boleta que seran impresas
            e.PrintDocument.PrinterSettings.Copies = 1;
        }

        private void btnend_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grRequisicoinesMP.FocusedView;
                var row = (dsTransaccionesMP.requisiciones_hRow)gridView.GetFocusedDataRow();

                switch (row.id_estado)
                {
                    case 1://Habilitada
                    case 2://Seleccion de Lotes
                    case 3://En Proceso
                        break;
                    case 4://Cerrada
                        Utileria.frmMensajeCalidad frm1 = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error,
                                                     "Esta requisición ya se encuentra en estado: Cerrada!");
                        if (frm1.ShowDialog() == DialogResult.Cancel)
                        {
                            return;
                        }
                        break;
                    case 5://Nueva
                        Utileria.frmMensajeCalidad frm2 = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error,
                                                     "No se puede finalizar una requisición en estado: Nuevo!");
                        if (frm2.ShowDialog() == DialogResult.Cancel)
                        {
                            return;
                        }
                        break;
                    default:
                        break;
                }


                #region codigo anterior
                //if (row.finalizado)
                //{
                //    if (MessageBox.Show("Desea Abrir de nuevo la requisa en cuestion?","Pregunta" , MessageBoxButtons.OKCancel, MessageBoxIcon.Question ) == DialogResult.OK)
                //    {
                //        string query = "sp_reactivar_requisa";
                //        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                //        cn.Open();
                //        SqlCommand cmd = new SqlCommand(query, cn);
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.Parameters.AddWithValue("@req", row.id);
                //        cmd.ExecuteNonQuery();
                //        cn.Close();


                //        if (tggView.IsOn)
                //        {
                //            LoadDatos();
                //        }
                //        else
                //        {
                //            LoadDatos_Finalizadas();
                //        }
                //    }

                //}
                //else
                //{
                //    if (MessageBox.Show("Desea finalizar la requisa? No podra seguir enviando materia prima despues de esta accion", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //    {

                //        string query = "sp_finalizar_requisa_v2";
                //        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                //        cn.Open();
                //        SqlCommand cmd = new SqlCommand(query, cn);
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.Parameters.AddWithValue("@req", row.id);
                //        cmd.Parameters.AddWithValue("@user_end", UsuarioLogeado.Id);
                //        cmd.ExecuteNonQuery();
                //        cn.Close();


                //        if (tggView.IsOn)
                //        {
                //            LoadDatos();
                //        }
                //        else
                //        {
                //            LoadDatos_Finalizadas();
                //        }
                //    }
                //}
                #endregion

                RequisicionesValidaciones val1 = new RequisicionesValidaciones();
                if (val1.PermitirCerrarRequisicionMP(row.id))
                {
                    if (CajaDialogo.Pregunta("Confirme si desea Cerrar la Requisición?") == DialogResult.Yes)
                    {
                        string query = "sp_finalizar_requisa_v2";
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@req", row.id);
                        cmd.Parameters.AddWithValue("@user_end", UsuarioLogeado.Id);
                        cmd.ExecuteNonQuery();
                        cn.Close();

                        if (tggView.IsOn)
                            LoadDatos();
                        else
                            LoadDatos_Finalizadas();
                    }
                }
                else
                {
                    //Hay materia prima pendiente de entregar.
                    //No se permite cerrar una requisicion si hay materia prima pendiente de entregar
                    Utileria.frmMensajeCalidad frm2 = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error,
                                                     "No se puede finalizar esta requisición, no se han entregado completamente!\n" +
                                                     "Ejemplo: ItemName: " + val1.NameMP+
                                                     "\nCantidad Pendiente en Kg: " + string.Format("{0:###,##0.00}", val1.CantidadPendiente));
                    if (frm2.ShowDialog() == DialogResult.Cancel)
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }

        private void tggView_Toggled(object sender, EventArgs e)
        {
            if (tggView.IsOn)                 // vista Activas
            {
                LoadDatos();
            }
            else
            {
                LoadDatos_Finalizadas();
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            if (tggView.IsOn)                 // vista Activas
            {
                LoadDatos();
            }
            else
            {
                LoadDatos_Finalizadas();
            }
        }

        private void cmdCierreReq_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Esta seguro de cerrar de manera forzada esta requisición?");
            if (r != DialogResult.Yes)
            {
                return;
            }

            //Cierre de requisas admin
            var gridView = (GridView)grRequisicoinesMP.FocusedView;
            var row = (dsTransaccionesMP.requisiciones_hRow)gridView.GetFocusedDataRow();
            try
            {

                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_set_update_requisicion_forzar_cerrado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_req_h", row.id);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadDatos();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}
