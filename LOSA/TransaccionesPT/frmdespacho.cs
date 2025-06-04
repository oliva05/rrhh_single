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
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Despachos;
using DevExpress.XtraReports.UI;
using LOSA.Reportes;

namespace LOSA.TransaccionesPT
{
    public partial class frmdespacho : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frmdespacho(UserLogin Puser)
        {
            InitializeComponent();
            switch (Puser.Idnivel)
            {
                case 1://Basic View
                    cmdAddOrdeCargaManual.Visible = false;
                    break;
                case 2://Basic No Autorization
                    cmdAddOrdeCargaManual.Visible = false;
                    break;
                case 3://Medium Autorization

                    break;
                case 4://Depth With Delta
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }
            UsuarioLogeado = Puser;
            load_desicion();
        }

        public void load_despachos_terminados() 
        {
            string Query = @"sp_load_informacion_despachos_only_open";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(Query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            dsPT.Load_despachos.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsPT.Load_despachos);
            cn.Close();
        }
        public void load_despachos()
        {
            string Query = @"sp_load_informacion_despachos_v2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            cn.Open();
            SqlCommand cmd = new SqlCommand(Query,cn);
            cmd.CommandType = CommandType.StoredProcedure;
            dsPT.Load_despachos.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsPT.Load_despachos);
            cn.Close();
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();

            int Unidades_Escaneadas = 0;

            try
            {
                string query = @"sp_get_entregado_por_id_despacho_h";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", row.id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Unidades_Escaneadas = dr.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            if (Unidades_Escaneadas < row.U_plan)
            {
                CajaDialogo.Pregunta("Desea marcar como finalizado este despacho? No se han escaneado los "+row.U_plan+" planificado para este despacho!");
            }

            try
            {       
                string query = @"sp_finalizar_despacho_con_log";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", row.id);
                cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                cmd.ExecuteNonQuery();
                CajaDialogo.Error("Se finalizo correctamente este despacho.");
                cn.Close();
                load_desicion();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();

            int contaBoleta = 1;
            try
            {

                string query = @"sp_get_validar_si_boleta_salio";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringBascula);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@boleta", row.Boleta);
                //cmd.ExecuteNonQuery();
                contaBoleta =Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            if (contaBoleta == 0) //Si es 0! ya existe un registro de salida de este vehiculo y furgon.
            {
                CajaDialogo.Error("No puede eliminar el despacho por que ya existe un Registro de Salida del Vehículo!");
                return;
            }

            Validar_Entrega(row.NumID);    

            if (row.bit_abierto == false)
            {
                CajaDialogo.Error("No puede eliminar una Despacho Cerrado! Contacte a su Administrador!");
                return;
            }

            if (MessageBox.Show("Desea eliminar este despacho? No podra hacer ninguna otra transaccion de el y las tarimas recibidas volveran al inventario.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                try
                {
                   
                    string query = @"sp_eliminar_despacho_con_log";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", row.id);
                    cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                    cmd.ExecuteNonQuery();
                    CajaDialogo.Error("Se elimino correctamente este despacho.");
                    cn.Close();
                    load_desicion();

                }
                catch (Exception ex)
                {

                    CajaDialogo.Error(ex.Message);
                }

            }
        }

        private void Validar_Entrega(int NumID)
        {
            bool Permitir = false; 
            try
            {
                string sql = @"sp_validacion_entrega_eliminar_despacho";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num_id", NumID);
                Permitir = Convert.ToBoolean(cmd.ExecuteScalar());
                conn.Close();

                if (Permitir == false)
                {
                    CajaDialogo.Error("No se puede Eliminar este Despacho existe Tarimas Escaneadas!\n Elimine las tarimas del Despacho.");
                    return;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();
                frm_generar_despacho frm = new frm_generar_despacho(row.id, this.UsuarioLogeado);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_desicion();
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();
            frm_view_entrega_despacho frm = new frm_view_entrega_despacho(row.id, this.UsuarioLogeado);
            frm.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
           
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();

            //frmdespacho_tipo_detalle_carga frm1 = new frmdespacho_tipo_detalle_carga(row.id);
            //frm1.Show();


            decimal sacos_totales = 0;
            int estiba_id = 0;
            int id_presentacion = 0;
            int destino_id = 0;

            try
            {


                //Vamos a Sacar la Informacion del Despacho, si es que tiene.
                string query = @"sp_load_info_despacho_boleta_config";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_despacho", row.id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    sacos_totales = dr.IsDBNull(8) ? 0 : dr.GetDecimal(8);
                    estiba_id = dr.IsDBNull(9) ? 0 : dr.GetInt32(9);
                    id_presentacion = dr.IsDBNull(10) ? 0 : dr.GetInt32(10);
                    destino_id = dr.IsDBNull(11) ? 0 : dr.GetInt32(11);
                }
                dr.Close();
                conn.Close();

                if (id_presentacion == 0 || estiba_id == 0 || destino_id == 0)
                {
                    //CajaDialogo.Pregunta("No se a Configurado las Filas para Este Despachos, Desea Imprimir el Despacho sin Configuracion?");
                    //if (DialogResult.OK == DialogResult.Yes)
                    //{
                    //    rpt_despacho frm = new rpt_despacho(row.id);
                    //    frm.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    //    ReportPrintTool printReport = new ReportPrintTool(frm);
                    //    printReport.ShowPreview();
                    //}
                    CajaDialogo.Error("No se a configurado las filas para este Despachos, debe editar el despacho y Configurar las Filas");


                }
                else
                {
                    //Reporte con Filas
                    LOSA.Despachos.Reportes.frm_despacho_con_filas rpt =
                        //new LOSA.Despachos.Reportes.frm_despacho_con_filas(id_despacho, estiba, Convert.ToInt32(grdDestinos.EditValue), Convert.ToInt32(grdPresentacion.EditValue));
                        new LOSA.Despachos.Reportes.frm_despacho_con_filas(row.id, estiba_id, destino_id, id_presentacion);
                    rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool printReport = new ReportPrintTool(rpt);
                    printReport.ShowPreview();
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            frm_nueva_orden frm = new frm_nueva_orden(UsuarioLogeado);
            frm.Show();
        }

        private void btn_ligar_oc_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();

                frm_Unir frm = new frm_Unir(row.id);
                frm.Show();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_desicion()
        {
            if (tggOpen.IsOn)
            {
                load_despachos();
            }
            else
            {
                load_despachos_terminados();
            }

        }
        private void tggOpen_Toggled(object sender, EventArgs e)
        {
            load_desicion();
        }

        private void grdv_data_RowStyle(object sender, RowStyleEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsPT.Load_despachosRow)gridView.GetDataRow(e.RowHandle);
            if (e.RowHandle >= 0)
            {

                if (row.bit_abierto)
                {
                    e.Appearance.BackColor = Color.FromArgb(172, 172, 172);

                }
                else
                {
                    e.Appearance.BackColor = Color.FromArgb(77, 201, 176);
                }
            }
        }

        private void cmdImprimirPlanDespachoPreliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsPT.Load_despachosRow)gridView.GetFocusedDataRow();
            Despachos.Reportes.frm_plan cp = new Despachos.Reportes.frm_plan(row.NumID, this.UsuarioLogeado);

            cp.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(cp);
            printReport.ShowPreview();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_data.ExportToXlsx(dialog.FileName);
            }
        }
    }
}