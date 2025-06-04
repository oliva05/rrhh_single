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
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Micro;
using LOSA.MicroIngredientes.Models;
using LOSA.Reportes;
using DevExpress.XtraReports.UI;
using LOSA.Utileria;
using static LOSA.MicroIngredientes.xfrmPesajeIndividual;
using LOSA.Clases;

namespace LOSA.MicroIngredientes
{
    public partial class xfrmDetalleOrdenesMicrosPesaje : DevExpress.XtraEditors.XtraForm
    {
        int id = 0;
        string codigoOrden;
        int id_orden = 0;
        Int64 id_order_apms = 0;
        string pt_name;
        string ItemCode;
        int LotePT;
        int TotalBatchOrden;

        public xfrmDetalleOrdenesMicrosPesaje(int _ID, string _CodigoOrden)
        {
            InitializeComponent();
            id = _ID;
            codigoOrden = _CodigoOrden;
            LoadData();
            LoadDataIndividual();
        }

        public xfrmDetalleOrdenesMicrosPesaje()
        {
            InitializeComponent();
            LoadHeader();
            LoadData();
            LoadDataIndividual();
            load_turno();
            Load_reprint();
            Load_reprint_individual();
        }

        private void Load_reprint_individual()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.detalle_pesajes_individuales_reprint.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("sp_get_detalle_orden_pesaje_micros_reprint_indiv", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //da.SelectCommand.Parameters.AddWithValue("@orden_id", id_order_apms);
                    da.Fill(dsMicros.detalle_pesajes_individuales_reprint);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadHeader()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.Micros.Clear();
                    SqlCommand cmd = new SqlCommand("sp_get_ordenes_pesaje_manual_interface_V6", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@vertodas", toggleSwitch1.IsOn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        id = dr.GetInt32(0);
                        id_order_apms = dr.GetInt64(1);
                        lblNumOrden.Text = id_order_apms.ToString();
                        codigoOrden = lblCodOrden.Text = dr.GetString(2);
                        LotePT = dr.GetInt32(4);
                        lbl_Lote.Text = LotePT.ToString();
                        TotalBatchOrden = dr.GetInt32(5);
                        lblTotalBatchOrden.Text = TotalBatchOrden.ToString();
                        lblPT.Text = dr.GetString(9);
                        ItemCode = lblItemCode.Text = dr.GetString(10);
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_turno()
        {
            try
            {
                string Query = @"sp_load_turnos";
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsMicros.turno.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMicros.turno);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.plan_microsh.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("[sp_get_detalle_orden_pesaje_micros_interfacev5]", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@orden_id", SqlDbType.Int).Value = id;
                    da.Fill(dsMicros.plan_microsh);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void Load_reprint()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.plan_microsh_report.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("[sp_get_detalle_orden_pesaje_micros_interfacev2_to_reprint]", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@orden_id", SqlDbType.Int).Value = id;
                    da.Fill(dsMicros.plan_microsh_report);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadDataIndividual()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.DetalleOrdenesPesajeIndividual.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("[sp_get_detalle_orden_pesaje_micros_interface_indiv_v2]", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@orden_id", id_order_apms);
                    da.Fill(dsMicros.DetalleOrdenesPesajeIndividual);
                    cnx.Close();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void xfrmDetalleOrdenesMicros_Load(object sender, EventArgs e)
        {
            //lblNumOrden.Text = "Código Orden: " + codigoOrden;
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadDataIndividual();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
        }

        private void repositoryItemSpinEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            //xfrmSpinBatchPlan frm = new xfrmSpinBatchPlan();

            //if (frm.ShowDialog()== DialogResult.OK)
            //{
            //    LoadData();
            //}

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDetalle_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        int ami_id = 0;
        private void gvDetalle_RowClick(object sender, RowClickEventArgs e)
        {
            CargarDetalleMezcla();
        }

        private void CargarDetalleMezcla()
        {
            //Cargar el detalle
            var gridView = (GridView)gcDetalle.FocusedView;
            var row = (dsMicros.plan_microshRow)gridView.GetFocusedDataRow();

            ami_id = row.AMI_ID;

            if (row != null)
            {
                id_orden = row.id_orden_encabezado;
            }

            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.plan_microsd.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("sp_get_detalle_ami_id_V2", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@ami_id", SqlDbType.Int).Value = row.AMI_ID;
                    da.Fill(dsMicros.plan_microsd);
                    cnx.Close();

                    cnx.Open();
                    bool Finalizado = true;
                    foreach (dsMicros.plan_microsdRow rowi in dsMicros.plan_microsd)
                    {
                        Finalizado = true;

                        if (rowi.batch_real == 0)
                        {
                            Finalizado = false;
                        }
                        else
                        //if (rowi.total > rowi.batch_real)
                        {
                            decimal val = 100 - ((rowi.batch_real / rowi.total) * 100);
                            if (Math.Abs(val) > 3)
                                Finalizado = false;
                        }

                        if (Finalizado)
                        {
                            //Update Row
                            SqlCommand cmd = new SqlCommand("sp_get_update_complete_pesaje_mezcla_micro_ingredientes", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ami_id",rowi.AMI_ID);
                            cmd.Parameters.AddWithValue("@id_orden_encabezado", rowi.id_orden_encabezado);
                            cmd.Parameters.AddWithValue("@id_rm", rowi.id_rm);
                            cmd.ExecuteNonQuery();
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdPesar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Pesaje de Micros

        }

        private void cmdPesar1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            //SqlTransaction transaction = null;
            try
            {
                var gridView = (GridView)gridControl2.FocusedView;
                var row = (dsMicros.plan_microsdRow)gridView.GetFocusedDataRow();

                if (row.batch_real >= row.total)
                {
                    CajaDialogo.Error("YA SE PESÓ ESTA MATERIA PRIMA");
                    return;
                }

                PesajeManualInfo pesajeManualInfo = new PesajeManualInfo();

                pesajeManualInfo.MateriaPrimaID = row.id_rm;
                pesajeManualInfo.Total = row.total;
                pesajeManualInfo.OrdenID = id_orden;
                pesajeManualInfo.CantBatch = row.cant_batch;
                pesajeManualInfo.DetallePesajeManualPlanID = row.id_orden_pesaje_manual_plan;
                pesajeManualInfo.BatchPlan = row.cant_batch;
                pesajeManualInfo.AMI_ID = ami_id;
                pesajeManualInfo.PesoPorBatch = row.set_point;
                
                PesajeBasculaInfo pesaje = new PesajeBasculaInfo();

                pesaje.Batch_Plan = row.cant_batch;
                pesaje.CantBatchMaximo = Convert.ToInt32((row.total - row.batch_real));
                pesaje.id_orden_pesaje_header = row.id_orden_encabezado;
                pesaje.MateriaPrimaID = row.id_rm;
                pesaje.MateriaPrima = row.namerm;
                pesaje.Total = row.total;
                pesaje.PesoPorBatch = row.set_point;
                pesaje.AMI_ID = ami_id;
                pesaje.CantBatch = row.cant_batch;

                //xfrmPesajeIndividual frm = new xfrmPesajeIndividual(pesaje, (int)TipoPesaje.PesajeNucleo);

                //if (frm.ShowDialog() == DialogResult.OK)
                //{
                //    LoadDataIndividual();
                //    CargarDetalleMezcla();
                //}
                xfrmPesajeNucleoV2 frm = new xfrmPesajeNucleoV2(row.batch_real, row.total, row.namerm, pesaje);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //LoadDataIndividual();
                    //CargarDetalleMezcla();

                    //Guardar el detalle de pesajes
                    List<PesajeIndividualCompletados> pesajesCompletados = new List<PesajeIndividualCompletados>();

                    DataOperations dp = new DataOperations();
                    SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS);
                    cnx.Open();

                    SqlConnection cnxLOSA = new SqlConnection(dp.ConnectionStringLOSA);
                    cnxLOSA.Open();

                    foreach (ItemPesajeManualNucleo item in frm.ListaPesajes)
                    {
                        TarimaMicroingrediente TarimaMicro = new TarimaMicroingrediente();
                        TarimaMicro.RecuperarRegistroTarimaMicros(item.Id_tarima_micro, "");

                        SqlCommand cmd = new SqlCommand("sp_insert_OP_Orden_pesaje_manual_transaccionV2", cnx);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id_orden_encabezado", SqlDbType.Int).Value = pesaje.id_orden_pesaje_header;
                        cmd.Parameters.Add("@batch_plan", SqlDbType.Int).Value = pesaje.Total;
                        cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = dp.Now();
                        cmd.Parameters.Add("@batch_real", SqlDbType.Decimal).Value = item.Peso;
                        cmd.Parameters.Add("@id_mp", SqlDbType.Int).Value = item.Id_mp;// IdMP;
                        cmd.Parameters.Add("@bascula", SqlDbType.VarChar).Value = DBNull.Value;// bascula[frm2.BasculaId - 1];
                        cmd.Parameters.Add("@id_tipo_pesaje", SqlDbType.Int).Value = 1;
                        cmd.Parameters.Add("@lote", SqlDbType.VarChar).Value = item.Lote; //??
                        cmd.Parameters.Add("@id_tarima", SqlDbType.VarChar).Value = item.Id_tarima_micro; //??
                        cmd.Parameters.Add("@cant_batch", SqlDbType.Int).Value = 1;
                        cmd.Parameters.Add("@id_pesaje_manual_plan", SqlDbType.Int).Value = pesajeManualInfo.DetallePesajeManualPlanID;
                        cmd.Parameters.Add("@cant_sacos", SqlDbType.Decimal).Value = DBNull.Value;//??
                        cmd.Parameters.Add("@ami_id", SqlDbType.Int).Value = pesaje.AMI_ID;
                        cmd.Parameters.Add("@fecha_vence", SqlDbType.Date).Value = TarimaMicro.FechaVencimiento;
                        cmd.Parameters.Add("@numero_transaccion", SqlDbType.Int).Value = TarimaMicro.NumeroTransaccion;

                        int id_orden_pesaje_manual_transaccion = (int)cmd.ExecuteScalar();

                        SqlCommand cmd2 = new SqlCommand("[dbo].[sp_LOSA_insert_detallePesajeBascula_Microsv2]", cnxLOSA);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.Add("@id_orden_h", SqlDbType.Int).Value = id_orden_pesaje_manual_transaccion;
                        cmd2.Parameters.Add("@id_tarima_micros", SqlDbType.Int).Value = item.Id_tarima_micro;
                        cmd2.Parameters.Add("@id_tarima_origen", SqlDbType.Int).Value = item.Id_tarima_origen;
                        cmd2.Parameters.Add("@id_mp", SqlDbType.Int).Value = item.Id_mp;
                        cmd2.Parameters.Add("@lote", SqlDbType.VarChar).Value = item.Lote;
                        cmd2.Parameters.Add("@peso", SqlDbType.Decimal).Value = item.Peso;
                        cmd2.Parameters.AddWithValue("@itemcode", ItemCode);
                        cmd2.Parameters.AddWithValue("@lotept", LotePT);
                        cmd2.Parameters.AddWithValue("@id_oden", id_order_apms);
                        cmd2.ExecuteNonQuery();
                    }
                    cnx.Close();
                    cnxLOSA.Close();
                    CargarDetalleMezcla();
                }//End If ShoDialog()
            }

            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void gridView2_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string total_= View.GetRowCellDisplayText(e.RowHandle, View.Columns["total"]);
                string batch_real = View.GetRowCellDisplayText(e.RowHandle, View.Columns["batch_real"]);

                decimal tota_plan = Convert.ToDecimal(total_);
                decimal pesado_real = Convert.ToDecimal(batch_real);
                if (pesado_real >= tota_plan)
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.DarkGreen);
                    //e.Appearance.BackColor2 = Color.White;
                }
            }
        }

        private void cmdPesarInd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                var row = (dsMicros.DetalleOrdenesPesajeIndividualRow)gvPesajeIndividual.GetDataRow(gvPesajeIndividual.FocusedRowHandle);
                //PesajeIndividualInfo pesajeIndividual = new PesajeIndividualInfo();
                PesajeBasculaInfo pesaje = new PesajeBasculaInfo();


                if (row != null)
                {

                    if (row.Batch_Completados >= row.Batch_Plan)
                    {
                        CajaDialogo.Error("YA HA COMPLETADO ESTE PLAN");
                        return;
                    }


                    pesaje.Batch_Plan = row.Batch_Plan;
                    pesaje.CantBatchMaximo = (row.Batch_Plan - row.Batch_Completados);
                    pesaje.id_orden_pesaje_header = row.id_orden_encabezado;
                    pesaje.MateriaPrimaID = row.id_rm;
                    pesaje.MateriaPrima = row.Material;
                    pesaje.Total = row.Total;
                    pesaje.PesoPorBatch = row.Peso_por_Batch;
                    //pesajeIndividual.AMI_ID = ami_id;

                    //int batch_realizados = row.Batch_Completados;
                    id_orden = Convert.ToInt32(lblNumOrden.Text);
                    xfrmPesajeIndividual frm = new xfrmPesajeIndividual(pesaje, (int)TipoPesaje.PesajeIndividual, id_orden, LotePT);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadDataIndividual();
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void gvPesajeIndividual_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string CantBatch_Plan = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Batch Plan"]);
                string batch_completados = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Batch Completados"]);

                if (CantBatch_Plan == batch_completados)
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.DarkGreen);
                    //e.Appearance.BackColor2 = Color.White;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)gcDetalle.FocusedView;
                var row = (dsMicros.plan_microshRow)gridView.GetFocusedDataRow();
                int Selected = row.id_orden_encabezado;
                //decimal Totalreq = row.total_kg;
                //decimal Selecionado = 0;
                
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();
                    dsMicros.plan_microsd.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("sp_get_detalle_ami_id_V2", cnx);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@ami_id", SqlDbType.Int).Value = row.AMI_ID;
                    da.Fill(dsMicros.plan_microsd);
                    cnx.Close();

                }

                //foreach (dsMicros.plan_microsdRow detalle in dsMicros.plan_microsd.Rows)
                //{
                //    if (detalle.AMI_ID == row.AMI_ID)
                //    {
                //        Selecionado = Selecionado + detalle.pesaje;
                //    }
                ////}
                //if (row.cant_batch> row.batch_real)
                //{
                //    frmMensajeCalidad frm = new frmMensajeCalidad(frmMensajeCalidad.TipoMsj.error, "Debe de pesar todas las materias primas.");
                //    if (frm.ShowDialog() == DialogResult.Cancel )
                //    {
                //        return;
                //    }
                   
                //}

                #region Turno
                //if (Convert.ToString(row.id_turno) == " ")
                //{
                //    frmMensajeCalidad frm = new frmMensajeCalidad(frmMensajeCalidad.TipoMsj.error, "Debe seleccionar el turno para imprimir el reporte.");
                //    if (frm.ShowDialog() == DialogResult.Cancel)
                //    {
                //        return;
                //    }
                //}
                //if (row.id_turno == 0)
                //{
                //    frmMensajeCalidad frm = new frmMensajeCalidad(frmMensajeCalidad.TipoMsj.error, "Debe seleccionar el turno para imprimir el reporte.");
                //    if (frm.ShowDialog() == DialogResult.Cancel)
                //    {
                //        return;
                //    }
                //}

                //string query1 = @"sp_update_plan_asignar_turnos";
                //SqlConnection conn = new SqlConnection(dp.ConnectionStringAPMS);
                //conn.Open();
                //SqlCommand cmd1 = new SqlCommand(query1, conn);
                //cmd1.CommandType = CommandType.StoredProcedure;
                //cmd1.Parameters.AddWithValue("@id_turno", row.id_turno);
                //cmd1.Parameters.AddWithValue("@AMI", row.AMI_ID);
                //cmd1.ExecuteNonQuery();
                //conn.Close();
                #endregion


                xrptAlimentacionMicros rpt = new xrptAlimentacionMicros(row.AMI_ID, row.id_orden_encabezado);
                rpt.ShowPrintMarginsWarning = false;
                rpt.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                rpt.Print();
                //rpt.ShowPreviewDialog();


                string query = @"sp_update_close_pesaje";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringAPMS);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_orden_encabezado", row.id_orden_encabezado);
                cmd.Parameters.AddWithValue("@AMI", row.AMI_ID);
                //cmd.ExecuteNonQuery();
                cn.Close();

                //LoadData();



            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void PrintingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //Indica el numero de copias de la boleta que seran impresas
            e.PrintDocument.PrinterSettings.Copies = 1;
        }

        private void gvDetalle_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var gridView = (GridView)gcDetalle.FocusedView;
                var row = (dsMicros.plan_microshRow)gridView.GetFocusedDataRow();
                foreach (dsMicros.plan_microshRow item in dsMicros.plan_microsh.Rows)
                {
                    if (row.AMI_ID == item.AMI_ID)
                    {
                        row.id_turno = Convert.ToInt32(e.Value);
                        row.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void grd_data_Click(object sender, EventArgs e)
        {

        }

        private void btn_reprint_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsMicros.plan_microsh_reportRow)gridView.GetFocusedDataRow();
                xrptAlimentacionMicros rpt = new xrptAlimentacionMicros(row.AMI_ID, row.id_orden_encabezado);
                rpt.ShowPrintMarginsWarning = false;
                rpt.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                rpt.Print();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSpin_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                //var gv = (GridView)gvDetalle.FocusedView;
                var row = (dsMicros.plan_microshRow)gvDetalle.GetFocusedDataRow();

                //if (row._Cod__Estado != 70)
                //{
                //    CajaDialogo.Error("Debe Activar la orden para planificar Batch(es)!");
                //    return;
                //}



                xfrmSpinBatchPlan frm = new xfrmSpinBatchPlan(row.id_orden_encabezado, row.order_code);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int batchDisponibles = 0;

                    batchDisponibles = row.cant_batch - row.batch_real;


                    if (frm.cantBatch <= batchDisponibles)
                    {
                        DataOperations dp = new DataOperations();

                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                        {
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("sp_acumulador_batch_real", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = row.id_orden_encabezado;
                            cmd.Parameters.AddWithValue("@batch_acumulado", SqlDbType.Int).Value = frm.cantBatch;

                            cmd.ExecuteNonQuery();
                            cnx.Close();

                            LoadData();
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("DEDE DE PESAR UNA CANTIDAD MENOR O IGUAL A LA CANTIDAD DE BATCH DISPONIBLE");
                    }


                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            try
            {
                var row = (dsMicros.plan_microshRow)gvDetalle.GetFocusedDataRow();
                DataOperations dp = new DataOperations();
                OrdenH_Info orderH = new OrdenH_Info();
                //int idPesajeOrden = row.id_orden_encabezado;
                //Boolean existeOrdenPesaje = false;
                Boolean ExisteConfPesajeManual;

                //if (orderH.RecuperaRegistro(idPesajeOrden))
                //{
                //    //existeOrdenPesaje = true;
                //}

                if (row==null)
                {
                    CajaDialogo.Error("DEBE SELECCIONAR LA ORDEN ACTIVA");
                    return;
                }

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("dbo.sp_validate_OP_Conf_PesajeIndividual", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_orden", SqlDbType.Int).Value = row.id_orden_encabezado;

                    ExisteConfPesajeManual = Convert.ToBoolean(cmd.ExecuteScalar());

                    cnx.Close();
                }


                if (ExisteConfPesajeManual == false)
                {

                    xfrmAsistentePesajeV2 frm = new xfrmAsistentePesajeV2(row.order_id, row.id_orden_encabezado, row.cant_batch);

                    frm.Show();
                }
                else
                {
                    CajaDialogo.Error("YA EXISTE UNA CONFIGURACION PARA ESTA ORDEN");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnBatch_Click(object sender, EventArgs e)
        {
            try
            {

                //var row = (dsMicros.plan_microshRow)gvDetalle.GetFocusedDataRow();

                //if (row != null)
                if (id > 0)
                {


                    //xfrmSpinBatchPlan frm = new xfrmSpinBatchPlan(row.id_orden_encabezado, row.order_code);
                    xfrmSpinBatchPlan frm = new xfrmSpinBatchPlan(id, codigoOrden);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        int batchDisponibles = 0;
                        DataOperations dp = new DataOperations();
                        int BatchPlaneados = 0;
                        foreach (dsMicros.plan_microshRow rowh in dsMicros.plan_microsh)
                        {
                            BatchPlaneados += dp.ValidateNumberInt32(rowh.cant_batch);
                        }
                        batchDisponibles = TotalBatchOrden - BatchPlaneados;


                        if (frm.cantBatch <= batchDisponibles)
                        {


                            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                            {
                                cnx.Open();
                                SqlCommand cmd = new SqlCommand("sp_acumulador_batch_real", cnx);
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;// row.id_orden_encabezado;
                                cmd.Parameters.AddWithValue("@batch_acumulado", SqlDbType.Int).Value = frm.cantBatch;

                                cmd.ExecuteNonQuery();
                                cnx.Close();

                                LoadData();
                            }
                        }
                        else
                        {
                            CajaDialogo.Error("DEDE DE PESAR UNA CANTIDAD MENOR O IGUAL A LA CANTIDAD DE BATCH DISPONIBLE");
                        }


                    }
                }
                else
                {
                    CajaDialogo.Error("NO HAY ORDEN ACTIVA");
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdVistaPreviaPesaje_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsMicros.plan_microsh_reportRow)gridView.GetFocusedDataRow();
                xrptAlimentacionMicros rpt = new xrptAlimentacionMicros(row.AMI_ID, row.id_orden_encabezado);
                rpt.ShowPrintMarginsWarning = false;
                rpt.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                rpt.ShowPreview();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void repostPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                string pesaje = " ";
                var gridView = (GridView)gcPesajeIndividual.FocusedView;
                var row = (dsMicros.DetalleOrdenesPesajeIndividualRow)gridView.GetFocusedDataRow();
                xrptAlimentacionMicros rpt = new xrptAlimentacionMicros(row.id_orden_encabezado, row.id_rm, row.Batch_Completados);
                rpt.ShowPrintMarginsWarning = false;
                rpt.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                //rpt.ShowPreview();
                rpt.Print();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void repost_reprint_direct_individual_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grdPesajeIndAll.FocusedView;
            var row = (dsMicros.detalle_pesajes_individuales_reprintRow)gridView.GetFocusedDataRow();

            if (row.batch_completados >= row.batch_plan)
            {
                try
                {
                    string pesaje = " ";

                    xrptAlimentacionMicros rpt = new xrptAlimentacionMicros(row.id_orden_encabezado, row.id_rm, row.batch_completados);
                    rpt.ShowPrintMarginsWarning = false;
                    rpt.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                    //rpt.ShowPreview();
                    rpt.Print();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            else
            {
                CajaDialogo.Error("No se puede imprimir por que no se ha completado el pesaje de Batch");
                return;
            }

           
        }

        private void repost_reprint_vista_previa_individual_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grdPesajeIndAll.FocusedView;
            var row = (dsMicros.detalle_pesajes_individuales_reprintRow)gridView.GetFocusedDataRow();

            if (row.batch_completados >= row.batch_plan)
            {
                try
                {
                    string pesaje = " ";
                    xrptAlimentacionMicros rpt = new xrptAlimentacionMicros(row.id_orden_encabezado, row.id_rm, row.batch_completados);
                    rpt.ShowPrintMarginsWarning = false;
                    rpt.PrintingSystem.StartPrint += new DevExpress.XtraPrinting.PrintDocumentEventHandler(PrintingSystem_StartPrint);
                    rpt.ShowPreview();
                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }
            }
            else
            {
                CajaDialogo.Error("No se puede imprimir por que no se ha completado el pesaje de Batch");
                return;
            }
        }
    }
}