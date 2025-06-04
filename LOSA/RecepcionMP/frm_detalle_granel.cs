﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;
using LOSA.Reportes;
using DevExpress.XtraReports.UI;

namespace LOSA.RecepcionMP
{
    public partial class frm_detalle_granel : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int id_numero_referencia;
        public frm_detalle_granel(int Pid)
        {
            InitializeComponent();
            id_numero_referencia = Pid;
            load_data();
        }

        public void load_data() 
        {
            string Query = @"sp_load_resumen_ingreso_granel";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_ingreso", id_numero_referencia);
                dsingresos.ingreso.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsingresos.ingreso);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimirLote_Click(object sender, EventArgs e)
        {
            try
            {
                rpt_cartilla report = new rpt_cartilla(id_numero_referencia, true);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                printReport.ShowPreview();
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
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
             
                rptLoteRotulo report = new rptLoteRotulo(id_numero_referencia, true);
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(report);
                printReport.ShowPreview();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
    }
}