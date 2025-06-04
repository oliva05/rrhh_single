﻿using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace LOSA.Calidad.CertificadoCalidad
{
    public partial class frmCrearCertificado : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLog;
        public frmCrearCertificado(UserLogin pUsuarioLog)
        {
            InitializeComponent();
            load_data();
            usuarioLog = pUsuarioLog;

        }

        public void load_data()
        {
            string query = @"dbo.uspGetLotesFromCertificado";
            DataOperations dp = new DataOperations();

            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCertificado.Lotes.Clear();
                da.Fill(dsCertificado.Lotes);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }


        public void load_informacion_certificado(int lote)
        {
            string query = @"dbo.sp_get_lote_informacion_certificado_calidad";
            DataOperations dp = new DataOperations();

            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LotNumber",lote);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCertificado.Certificado_Preview.Clear();
                da.Fill(dsCertificado.Certificado_Preview);
                cn.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }


        public void load_informacion_certificadoDetalle(int lote)
        {
            string query = @"dbo.sp_get__parametro_promedio_certificado_calidad_PT ";
            DataOperations dp = new DataOperations();

            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LotNumber", lote);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsCertificado.Certificado_PT_D.Clear();
                da.Fill(dsCertificado.Certificado_PT_D);
                cn.Close();

                

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }

        SqlTransaction transaction;
        private void btnCertificar_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();

                if (ValidarCertificadoExistente((int)lueLote.EditValue))
                {
                    CajaDialogo.Error("YA EXISTE UN CERTIFICADO PARA ESTE LOTE");
                    return;
                }

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                cnx.Open();
                transaction = cnx.BeginTransaction();

                DataTable dtCertificado = TransposeDataTable(dsCertificado.Certificado_Preview);
                int id_inserted = 0;


                using (SqlCommand cmd = new SqlCommand("uspInsertCertificadoPT_H", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaction;

                    cmd.Parameters.AddWithValue("@fecha_analisis", dtCertificado.Rows[0][0].ToString());
                    cmd.Parameters.AddWithValue("@alimento", dtCertificado.Rows[0][1].ToString());
                    cmd.Parameters.AddWithValue("@FFIF", dtCertificado.Rows[0][2].ToString());
                    cmd.Parameters.AddWithValue("@lote_pt", dtCertificado.Rows[0][4].ToString());
                    cmd.Parameters.AddWithValue("@fecha_produccion", dtCertificado.Rows[0][5].ToString());
                    cmd.Parameters.AddWithValue("@fecha_vencimiento", dtCertificado.Rows[0][6].ToString());
                    cmd.Parameters.AddWithValue("@id_pt", lote_pt.id_pt);
                    cmd.Parameters.AddWithValue("@itemcode", lote_pt.CodigoProducto);
                    cmd.Parameters.AddWithValue("@usuario_creador", usuarioLog.UserId);
                    cmd.Parameters.AddWithValue("@estatus_gmo", dtCertificado.Rows[0][7].ToString());

                    id_inserted = (int)cmd.ExecuteScalar();
                }



                foreach (var item in dsCertificado.Certificado_PT_D)
                {
                    SqlCommand cmd2 = new SqlCommand("uspInsertCertificadoPT_d", cnx);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Transaction = transaction;

                    cmd2.Parameters.AddWithValue("@id_h", id_inserted);
                    cmd2.Parameters.AddWithValue("@id_parametro", item.id_parametro);
                    cmd2.Parameters.AddWithValue("@parametro", item.parametro);
                    cmd2.Parameters.AddWithValue("@min_plan", item.min_plan);
                    cmd2.Parameters.AddWithValue("@max_plan", item.max_plan);
                    cmd2.Parameters.AddWithValue("@resultado", item.resultaod);
                    cmd2.Parameters.AddWithValue("@especificaciones", item.especificaciones);

                    cmd2.ExecuteNonQuery();
                }

                transaction.Commit();
                cnx.Close();

                
                CajaDialogo.Information("DATOS GUARDADOS");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaction.Rollback();
                //transaction.Connection.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        LotePT lote_pt = new LotePT();
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();

            lote_pt.RecuperarRegistro((int)lueLote.EditValue);
            load_informacion_certificado(Convert.ToInt32( lueLote.Text));
            load_informacion_certificadoDetalle(Convert.ToInt32(lueLote.Text));

            if (gridView2.RowCount == 0)
            {
                CajaDialogo.Error("No existen registros de monitoreo!");
                return;
            }
        }

        static DataTable TransposeDataTable(DataTable originalTable)
        {
            DataTable transposedTable = new DataTable("TransposedTable");

            // Add columns to transposedTable based on rows of originalTable
            foreach (DataRow row in originalTable.Rows)
            {
                transposedTable.Columns.Add(row[0].ToString(), row[1].GetType());
            }

            // Add rows to transposedTable based on columns of originalTable
            for (int i = 1; i < originalTable.Columns.Count; i++)
            {
               
                    DataRow newRow = transposedTable.NewRow();
                    newRow[0] = originalTable.Columns[i].ColumnName;

                    for (int j = 0; j < originalTable.Rows.Count; j++)
                    {
                        newRow[j] = originalTable.Rows[j][i];
                    }

                    transposedTable.Rows.Add(newRow);
            }

            return transposedTable;
        }

        public bool ValidarCertificadoExistente(int lote)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                cnx.Open();
                SqlCommand cmd = new SqlCommand("uspValidarCertificadoExistente", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@lote",lote);

                bool validador = (bool)cmd.ExecuteScalar();

                cnx.Close();
                return validador;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = (GridView)gridControl2.FocusedView;
            var row = (dsCertificado.Certificado_PT_DRow)gridView.GetFocusedDataRow();

            switch (e.Column.FieldName)
            {
                case "resultaod":
                    if (row.resultaod < row.min_plan)
                    {
                        CajaDialogo.Error("Parametro: " + row.parametro + " debe estar entre "+ row.min_plan +" y "+row.max_plan);
                        row.resultaod = row.min_plan;
                    }

                    if (row.resultaod > row.max_plan)
                    {
                        CajaDialogo.Error("Parametro: " + row.parametro + " debe estar entre " + row.min_plan + " y " + row.max_plan);
                        row.resultaod = row.max_plan;
                    }

                    break;

                default:
                    break;
            }
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsCertificado.Certificado_PreviewRow)gridView.GetFocusedDataRow();

            if (row.Dato != "Estatus de GMO:")
            {
                e.Cancel = true;
            }
        }
    }
}