﻿using ACS.Classes;
using Core.Clases.Herramientas;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using LOSA.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RecepcionMP
{
    public partial class frmImprimirHojaIngreso : Form
    {
        int IdSerie;
        int NumBoleta;
        int IdMP;
        string ItemCode;
        UserLogin UsuarioLogeado;
        public frmImprimirHojaIngreso(UserLogin pUser)
        {
            InitializeComponent();
            DataOperations dp = new DataOperations();
            dtFechaDesde.EditValue = dp.dNow();
            dtFechaHasta.EditValue = dp.dNow().AddDays(1);
            //dtFechaVencimiento.Properties.MinValue = dtFechaIngreso.Properties.MinValue = dp.Now();
            UsuarioLogeado = pUser;
            //LoadPresentaciones();
            LoadData();
        }

        private void LoadData()
        {
            if (dtFechaDesde.EditValue != null && dtFechaHasta.EditValue != null)
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();
                    SqlCommand cmm2 = new SqlCommand("sp_get_tarimas_ingresadas_resumen", con);
                    cmm2.CommandType = CommandType.StoredProcedure;
                    cmm2.Parameters.AddWithValue("@fdesde", dtFechaDesde.EditValue);
                    cmm2.Parameters.AddWithValue("@fhasta", dtFechaHasta.EditValue);

                    dsRecepcionMPx1.lista_tarimas.Clear();
                    SqlDataAdapter adat = new SqlDataAdapter(cmm2);
                    adat.Fill(dsRecepcionMPx1.lista_tarimas);
                    con.Close();
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                }
            }
        }

        private void LoadPresentaciones(){ }
        private void simpleButton1_Click(object sender, EventArgs e)  { }
        private void LoadDatosBoleta() {  }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmImprimirHojaIngreso_Activated(object sender, EventArgs e)  {  }
        private void txtDescripcionCorta_KeyDown(object sender, KeyEventArgs e)  { }
        private void textEdit2_EditValueChanged(object sender, EventArgs e){}
        private void txtIdBoleta_Enter(object sender, EventArgs e)    {}
        private void txtProveedorName_Click(object sender, EventArgs e) {}
        private void frmImprimirHojaIngreso_Click(object sender, EventArgs e){}

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            Teclado.cerrarTeclado();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmImprimirHojaIngreso_Load(object sender, EventArgs e){ }
        private void cmdGuardar_Click(object sender, EventArgs e) {}
        private void txtCantidadT_Enter(object sender, EventArgs e){}
        private void txtNumIngreso_Enter(object sender, EventArgs e){}
        private void txtLote_Enter(object sender, EventArgs e){}
        private void txtCantidadT_KeyPress(object sender, KeyPressEventArgs e){}

        private void btnPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //imprimir
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();

            bool Error = false;
            string mensaje = " ";
            switch (row.id_estado_tarima)
            {
                case 1://Recepcionado
                    Error = false;
                    break;
                case 2://En Bodega
                    Error = false;
                    //mensaje = "Calidad tiene En Observación ésta tarima.!";
                    break;
                case 3://Retenido
                    Error = false;
                    break;
                case 4://Comprometido
                    Error = true;
                    mensaje = "Esta tarima ya esta comprometida!";
                    break;
                case 5://En Produccion
                    Error = true;
                    mensaje = "Esta tarima no se puede imprimir por que ya fue entregada a Produccion";
                    break;
                case 6://Consumido
                    Error = true;
                    mensaje = "Esta tarima no se puede imprimir por que ya fue entregada y consumida por producción!";
                    break;
                //case 7://
                //    error = true;
                //    mensaje = "Calidad tiene Retenida ésta tarima.!";
                //    break;
                case 8://Parcialmente Entregado
                    Error = false;
                    //mensaje = "Calidad ha Rechazado ésta tarima.!";
                    break;
                case 9://Rechazado
                    Error = true;
                    mensaje = "Esta tarima fue Rechazada!";
                    break;
                case 10://Ajuste de Inventario
                    Error = true;
                    mensaje = "Esta tarima no se puede imprimir por que ya se le dio salida por ajuste de inventario!";
                    break;
            }

            if (Error)
            {
                CajaDialogo.Error(mensaje);
                return;
            }

            rptReporteIngresoTarima report = new rptReporteIngresoTarima(row.id);
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.Print();
        }

        private void dtFechaDesde_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtFechaHasta_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cmdDuplicar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ////Duplicar la tarima
            //frmInputBox frm = new frmInputBox();
            //frm.Text = "Duplicar Tarima";
            //frm.lblInstrucciones.Text = "Ingrese la cantidad de tarimas a duplicar:";
            //frm.txtValue.Text = "1";
            //frm.ValidInteger = true;

            //if(frm.ShowDialog()== DialogResult.OK)
            //{
            //    int cant = 0;
            //    try
            //    {
            //        cant = Convert.ToInt32(frm.txtValue.Text);
            //    }
            //    catch{}

            //    if (cant <= 0)
            //    {
            //        CajaDialogo.Error("No se puede duplicar la Tarima! El valor debe ser mayor a cero.");
            //        return;
            //    }

            //    var gridView = (GridView)gridControl1.FocusedView;
            //    var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();

            //    ArrayList List1 = new ArrayList();

            //    Tarima tar1 = new Tarima();
            //    if (tar1.RecuperarRegistro(row.id))
            //    {

            //        for (int i = 1; i <= cant; i++)
            //        {
            //            try
            //            {
            //                DataOperations dp = new DataOperations();
            //                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
            //                con.Open();

            //                SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id", con);
            //                cmm.CommandType = CommandType.StoredProcedure;
            //                cmm.Parameters.AddWithValue("@id", 1);
            //                string barcode = cmm.ExecuteScalar().ToString();

            //                string vItemCodeMP = "";
            //                MateriaPrima mpx = new MateriaPrima();
            //                if (mpx.RecuperarRegistroFromID_RM(row.id_materia_prima))
            //                {
            //                    vItemCodeMP = mpx.CodeMP_SAP;
            //                }
                            

            //                SqlCommand cmd = new SqlCommand("sp_insert_new_tarima_lote", con);
            //                cmd.CommandType = CommandType.StoredProcedure;
            //                cmd.Parameters.AddWithValue("@itemcode", vItemCodeMP);
            //                cmd.Parameters.AddWithValue("@id_proveedor", tar1.IdProveedor);
            //                cmd.Parameters.AddWithValue("@fecha_ingreso", tar1.FechaIngreso);
            //                cmd.Parameters.AddWithValue("@numero_transaccion", tar1.NumeroTransaccion);
            //                cmd.Parameters.AddWithValue("@fecha_vencimiento", tar1.FechaVencimiento);
            //                cmd.Parameters.AddWithValue("@fecha_produccion_materia_prima", tar1.FechaProduccion);
            //                cmd.Parameters.AddWithValue("@lote_materia_prima", tar1.LoteMP);
            //                cmd.Parameters.AddWithValue("@id_presentacion", tar1.IdPresentacion);
            //                cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
            //                cmd.Parameters.AddWithValue("@id_boleta", tar1.IdBoleta);
            //                cmd.Parameters.AddWithValue("@codigo_barra", barcode);
            //                cmd.Parameters.AddWithValue("@cant", tar1.Cantidad);
            //                cmd.Parameters.AddWithValue("@peso", tar1.Peso);
            //                cmd.Parameters.AddWithValue("@idlotes", tar1.Id_ingreso);
            //                int vid_tarima = Convert.ToInt32(cmd.ExecuteScalar());

            //                List1.Add(vid_tarima);

            //                con.Close();
            //                //this.Close();
            //            }
            //            catch (Exception ec)
            //            {
            //                CajaDialogo.Error(ec.Message);
            //            }
            //        }//end for 

            //        if (List1.Count > 0)
            //        {
            //            DialogResult r = CajaDialogo.Pregunta("Desea Imprimir la(s) Hoja(s) de Ingreso?");
            //            if (r == DialogResult.Yes)
            //            {
            //                foreach (int i in List1)
            //                {
            //                    int id_tarimax =i;
            //                    rptReporteIngresoTarima report = new rptReporteIngresoTarima(id_tarimax);
            //                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            //                    ReportPrintTool printReport = new ReportPrintTool(report);
            //                    printReport.ShowPreview();
            //                }
            //            }
            //            LoadData();
            //        }
            //        List1.Clear();
            //    }//end if recuperar registro
            //}//end dialog result == ok
        }//end void function

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //var gridView = (GridView)gridControl1.FocusedView;
            //var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();

            //frmEditTarima frm = new frmEditTarima(row.id, this.UsuarioLogeado);
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void cmdVistaPreliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //imprimir
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsRecepcionMPx.lista_tarimasRow)gridView.GetFocusedDataRow();

            bool Error = false;
            string mensaje = " ";
            switch (row.id_estado_tarima)
            {
                case 1://Recepcionado
                    Error = false;
                    break;
                case 2://En Bodega
                    Error = false;
                    //mensaje = "Calidad tiene En Observación ésta tarima.!";
                    break;
                case 3://Retenido
                    Error = false;
                    break;
                case 4://Comprometido
                    Error = true;
                    mensaje = "Esta tarima ya esta comprometida!";
                    break;
                case 5://En Produccion
                    Error = true;
                    mensaje = "Esta tarima no se puede imprimir por que ya fue entregada a Produccion";
                    break;
                case 6://Consumido
                    Error = true;
                    mensaje = "Esta tarima no se puede imprimir por que ya fue entregada y consumida por producción!";
                    break;
                //case 7://
                //    error = true;
                //    mensaje = "Calidad tiene Retenida ésta tarima.!";
                //    break;
                case 8://Parcialmente Entregado
                    Error = false;
                    //mensaje = "Calidad ha Rechazado ésta tarima.!";
                    break;
                case 9://Rechazado
                    Error = true;
                    mensaje = "Esta tarima fue Rechazada!";
                    break;
                case 10://Ajuste de Inventario
                    Error = true;
                    mensaje = "Esta tarima no se puede imprimir por que ya se le dio salida por ajuste de inventario!";
                    break;
            }

            if (Error)
            {
                CajaDialogo.Error(mensaje);
                return;
            }

            rptReporteIngresoTarima report = new rptReporteIngresoTarima(row.id);
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(report);
            printReport.ShowPreview();
        }
    }
}
