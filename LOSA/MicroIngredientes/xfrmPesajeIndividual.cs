﻿using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.MicroIngredientes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MicroIngredientes
{
    public partial class xfrmPesajeIndividual : DevExpress.XtraEditors.XtraForm
    {
        //int batchMaximo;
        //int id_orden_pesaje_h;
        int BasculaSelected = 0;
        int tipoPesaje = 0;
        int batch_realizados;
        string[] bascula = { "B1", "B2", "Ambas" };
        int id_orden, LotePT;

       public enum TipoPesaje
        {
            PesajeNucleo=1,
            PesajeIndividual=2
        }

        //PesajeIndividualInfo pesajeIndividual = new PesajeIndividualInfo();
        //PesajeManualInfo pesajeManual = new PesajeManualInfo();
        PesajeBasculaInfo pesaje = new PesajeBasculaInfo();
        

        public xfrmPesajeIndividual(PesajeBasculaInfo ppesaje, int pTipoPesaje, int pid_orden, int pLotePT)
        {
            InitializeComponent();
            pesaje = ppesaje;
            seBatch.Properties.MaxValue = pesaje.CantBatchMaximo;
            LoadBasculas();
            tipoPesaje = pTipoPesaje;
            id_orden = pid_orden;
            LotePT = pLotePT;
            //batch_realizados = pbatch_realizados;
        }


        //public xfrmPesajeIndividual(PesajeManualInfo ppesajeManual, int pTipoPesaje)
        //{
        //    InitializeComponent();
        //    pesajeManual = ppesajeManual;
        //    //seBatch.Properties.MaxValue = ppesajeIndividual.CantBatchMaximo;
        //    LoadBasculas();
        //    tipoPesaje = pTipoPesaje;
        //}

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadBasculas()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx= new SqlConnection(dp.ConnectionStringAPMS))
                {
                    cnx.Open();

                    dsMicros.Pesaje_Bascula.Clear();
                    SqlDataAdapter da = new SqlDataAdapter("sp_get_OP_Orden_pesaje_real", cnx);
                    da.Fill(dsMicros.Pesaje_Bascula);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdUp_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(seBatch.EditValue);
            if (val < seBatch.Properties.MaxValue)
            {
                seBatch.EditValue = val + 1;
                lblMensaje.Visible = false;
            }
            else
            {
                lblMensaje.Visible = true;
            }
        }

        private void cmdDown_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(seBatch.EditValue);
            if (val > 1)
            {
                seBatch.EditValue = val - 1;
                lblMensaje.Visible = false;
            }
        }

        private void cmdSum10_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(seBatch.EditValue);
            if (n == 1)
            {
                if (10>pesaje.CantBatchMaximo)
                {
                    seBatch.EditValue = pesaje.CantBatchMaximo;
                    lblMensaje.Visible = true;
                    lblMensaje.Text = "Cantidad maxima a pesar: " + seBatch.Properties.MaxValue;
                }
                else
                {
                seBatch.EditValue = 10;
                    lblMensaje.Visible = false;
                }
            }
            else
            {
                if ((Convert.ToInt32(seBatch.EditValue) + 10)<=seBatch.Properties.MaxValue)
                {

                seBatch.EditValue = Convert.ToInt32(seBatch.EditValue) + 10;
                }
                else
                {
                    lblMensaje.Visible = true;
                    lblMensaje.Text = "Cantidad maxima a pesar: " + seBatch.Properties.MaxValue;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(seBatch.EditValue) - 10;
            if (n < 1)
            {
                seBatch.EditValue = 1;
            }
            else
            {
                seBatch.EditValue = n;
            }

            lblMensaje.Visible = false;
        }

        SqlTransaction transaction;

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {

                //if (BasculaSelected == 0)
                //{
                //    CajaDialogo.Error("DEBE SELECCIONAR UNA BASCULA");
                //    return;
                //}
                //pesajeIndividual.BasculaID = BasculaSelected;

                List<PesajeIndividualCompletados> pesajesCompletados = new List<PesajeIndividualCompletados>();


                DataOperations dp = new DataOperations();

                ///******Por Validar**********
                switch (tipoPesaje)
                {
                    #region Pesaje Nucleo
                    //case (int)TipoPesaje.PesajeNucleo:

                    //    for (int i = 1; i <= pesaje.CantBatch; i++)
                    //    {
                    //        string batch_completados2 = i + " de " + pesaje.CantBatch;
                    //        xfrmPesajeIndividualBatchV3 frm2 = new xfrmPesajeIndividualBatchV3(batch_completados2, "Báscula: " + lueBascula.Text, pesaje);
                    //        int id_orden_pesaje_manual_transaccion;

                    //        if (frm2.ShowDialog() == DialogResult.OK)
                    //        {
                    //            TarimaMicroingrediente tmmicro = new TarimaMicroingrediente();
                    //            tmmicro.RecuperarRegistroTarimaMicros(frm2.id_tarima_micros, " ");

                    //            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringAPMS))
                    //            {
                    //                cnx.Open();

                    //                //transaction = cnx.BeginTransaction("SampleTransaction");

                    //                SqlCommand cmd = new SqlCommand("sp_insert_OP_Orden_pesaje_manual_transaccionV2", cnx);
                    //                cmd.CommandType = CommandType.StoredProcedure;
                    //                //cmd.Transaction = transaction;

                    //                cmd.Parameters.Add("@id_orden_encabezado", SqlDbType.Int).Value = pesaje.id_orden_pesaje_header;
                    //                cmd.Parameters.Add("@batch_plan", SqlDbType.Int).Value = pesaje.Total;
                    //                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = dp.Now();
                    //                cmd.Parameters.Add("@batch_real", SqlDbType.Decimal).Value = frm2.peso_bascula_finish;
                    //                cmd.Parameters.Add("@id_rm", SqlDbType.Int).Value = pesaje.MateriaPrimaID;// IdMP;
                    //                cmd.Parameters.Add("@bascula", SqlDbType.VarChar).Value = bascula[frm2.BasculaId-1];
                    //                cmd.Parameters.Add("@id_tipo_pesaje", SqlDbType.Int).Value =  1;
                    //                cmd.Parameters.Add("@lote", SqlDbType.VarChar).Value = tmmicro.LoteMP; //??
                    //                cmd.Parameters.Add("@id_tarima", SqlDbType.VarChar).Value = frm2.id_tarima_micros; //??
                    //                cmd.Parameters.Add("@cant_batch", SqlDbType.Int).Value = pesaje.CantBatch;
                    //                cmd.Parameters.Add("@id_pesaje_manual_plan", SqlDbType.Int).Value = DBNull.Value;//??
                    //                cmd.Parameters.Add("@cant_sacos", SqlDbType.Decimal).Value = DBNull.Value;//??
                    //                cmd.Parameters.Add("@ami_id", SqlDbType.Int).Value = pesaje.AMI_ID;
                    //                cmd.Parameters.Add("@fecha_vence", SqlDbType.Date).Value = tmmicro.FechaVencimiento;
                    //                cmd.Parameters.Add("@numero_transaccion", SqlDbType.Int).Value = tmmicro.NumeroTransaccion;

                    //                id_orden_pesaje_manual_transaccion = (int)cmd.ExecuteScalar();


                    //                foreach (var item in frm2.PesajeAcumulado)
                    //                {
                    //                    using (SqlConnection cnx2 = new SqlConnection(dp.ConnectionStringLOSA))
                    //                    {
                    //                        cnx2.Open();
                    //                        SqlCommand cmd2 = new SqlCommand("[dbo].[sp_LOSA_insert_detallePesajeBascula_Micros]", cnx2);
                    //                        cmd2.CommandType = CommandType.StoredProcedure;
                    //                        //cmd2.Transaction = transaction;

                    //                        cmd2.Parameters.Add("@id_orden_h", SqlDbType.Int).Value = id_orden_pesaje_manual_transaccion;
                    //                        cmd2.Parameters.Add("@id_tarima_micros", SqlDbType.Int).Value = item.TarimaMicroId;
                    //                        cmd2.Parameters.Add("@id_tarima_origen", SqlDbType.Int).Value = item.TarimaOrigeId;
                    //                        cmd2.Parameters.Add("@id_mp", SqlDbType.Int).Value = item.MateriaPrimaId;
                    //                        cmd2.Parameters.Add("@lote", SqlDbType.VarChar).Value = item.Lote;
                    //                        cmd2.Parameters.Add("@peso", SqlDbType.Decimal).Value = item.Peso;

                    //                        cmd2.ExecuteNonQuery();
                    //                        cnx2.Close();
                    //                    }

                    //                }

                    //                //transaction.Commit();


                    //                cnx.Close();

                    //            }
                    //        }
                    //        else
                    //        {
                    //            return;
                    //        }
                    //            this.DialogResult = DialogResult.OK;

                    //    }

                    //    break;
                    #endregion

                    case (int)TipoPesaje.PesajeIndividual:
                        for (int i = 1; i <= Convert.ToInt32(seBatch.EditValue); i++)
                        {
                            string batch_completados = i + " de " + Convert.ToInt32(seBatch.EditValue);
                            xfrmPesajeIndividualBatchV3 frm = new xfrmPesajeIndividualBatchV3(batch_completados, "Báscula: " + lueBascula.Text, pesaje);

                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                TarimaMicroingrediente tmmicro = new TarimaMicroingrediente();
                                tmmicro.RecuperarRegistroTarimaMicros(frm.id_tarima_micros, " ");

                                string barcode = null;

                                DataOperations dp2 = new DataOperations();
                                SqlConnection cnx3 = new SqlConnection(dp2.ConnectionStringAPMS);
                                cnx3.Open();

                                //transaction = cnx2.BeginTransaction("SampleTransaction");

                                SqlCommand cmd3 = new SqlCommand("sp_insert_OP_Orden_pesaje_manual_batch_log", cnx3);
                                cmd3.CommandType = CommandType.StoredProcedure;
                                //cmd.Transaction = transaction;


                                cmd3.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dp.Now();
                                cmd3.Parameters.Add("@id_orden_pesaje_h", SqlDbType.Int).Value = pesaje.id_orden_pesaje_header;
                                cmd3.Parameters.Add("@id_code", SqlDbType.Int).Value = DBNull.Value;

                                cmd3.ExecuteNonQuery();
                                
                                //Vamos a sacar el codigo de barra
                                SqlCommand cmdBar = new SqlCommand("sp_get_contar_cant_batch_pesaje_individual", cnx3);
                                cmdBar.CommandType = CommandType.StoredProcedure;
                                cmdBar.Parameters.AddWithValue("@id_orden_encabezado", pesaje.id_orden_pesaje_header);
                                cmdBar.Parameters.AddWithValue("@id_rm", pesaje.MateriaPrimaID); //pesaje.MateriaPrimeID = id.MD_RawMaterial
                                int contador = Convert.ToInt32(cmdBar.ExecuteScalar());

                                if (contador == 0)
                                {
                                    //Crear codigo de barra para pesaje individual 
                                    SqlCommand cmdBar1 = new SqlCommand("sp_generar_codigo_from_tables_id_pesaje_individual", cnx3);
                                    cmdBar1.CommandType = CommandType.StoredProcedure;
                                    barcode = cmdBar1.ExecuteScalar().ToString();
                                }


                                SqlCommand cmd4 = new SqlCommand("[sp_insert_OP_Orden_pesaje_manual_transaccionV3]", cnx3);
                                cmd4.CommandType = CommandType.StoredProcedure;
                                //cmd3.Transaction = transaction;

                                cmd4.Parameters.Add("@id_orden_encabezado", SqlDbType.Int).Value = pesaje.id_orden_pesaje_header;
                                cmd4.Parameters.Add("@batch_plan", SqlDbType.Int).Value = pesaje.Batch_Plan;
                                cmd4.Parameters.Add("@date", SqlDbType.DateTime).Value = dp.Now();
                                cmd4.Parameters.Add("@batch_real", SqlDbType.Decimal).Value =frm.peso_bascula_finish;//?
                                cmd4.Parameters.Add("@id_rm", SqlDbType.Int).Value = pesaje.MateriaPrimaID;// ID_RM;
                                cmd4.Parameters.Add("@bascula", SqlDbType.VarChar).Value = bascula[frm.BasculaId-1];
                                cmd4.Parameters.Add("@id_tipo_pesaje", SqlDbType.Int).Value = 2;
                                cmd4.Parameters.Add("@lote", SqlDbType.VarChar).Value = tmmicro.LoteMP;//Dejar este parametro con espacios
                                cmd4.Parameters.Add("@id_tarima", SqlDbType.VarChar).Value = frm.id_tarima_micros; //??
                                cmd4.Parameters.Add("@cant_batch", SqlDbType.Int).Value = pesaje.CantBatch;
                                cmd4.Parameters.Add("@cant_sacos", SqlDbType.Int).Value = DBNull.Value;
                                cmd4.Parameters.Add("@ami_id", SqlDbType.Int).Value = pesaje.AMI_ID;
                                cmd4.Parameters.Add("@id_pesaje_manual_plan", SqlDbType.Int).Value = DBNull.Value;
                                cmd4.Parameters.Add("@fecha_vence", SqlDbType.Date).Value = tmmicro.FechaVencimiento;
                                cmd4.Parameters.Add("@numero_transaccion", SqlDbType.Int).Value = tmmicro.NumeroTransaccion;
                                cmd4.Parameters.AddWithValue("@contador", contador);
                                if (barcode == null)
                                    cmd4.Parameters.AddWithValue("@codigo_barra", " ");
                                else
                                    cmd4.Parameters.AddWithValue("@codigo_barra", barcode);

                                int id_orden_pesaje_manual_transaccion2= (int)cmd4.ExecuteScalar();


                                foreach (var item in frm.PesajeAcumulado)
                                {
                                    if (item.Lote != null && LotePT != 0 && LotePT != null)
                                    {
                                        using (SqlConnection cnx4 = new SqlConnection(dp.ConnectionStringLOSA))
                                        {
                                            if (cnx4.State == ConnectionState.Closed)
                                                cnx4.Open();

                                            SqlCommand cmd5 = new SqlCommand("[dbo].[sp_LOSA_insert_detallePesajeBascula_Micros]", cnx4);
                                            cmd5.CommandType = CommandType.StoredProcedure;
                                            //cmd5.Transaction = transaction;

                                            cmd5.Parameters.Add("@id_orden_h", SqlDbType.Int).Value = id_orden_pesaje_manual_transaccion2;
                                            cmd5.Parameters.Add("@id_tarima_micros", SqlDbType.Int).Value = item.TarimaMicroId;
                                            cmd5.Parameters.Add("@id_tarima_origen", SqlDbType.Int).Value = item.TarimaOrigeId;
                                            cmd5.Parameters.Add("@id_mp", SqlDbType.Int).Value = item.MateriaPrimaId;
                                            cmd5.Parameters.Add("@lote", SqlDbType.VarChar).Value = item.Lote;
                                            cmd5.Parameters.Add("@peso", SqlDbType.Decimal).Value = item.Peso;
                                            //cmd5.Parameters.AddWithValue("@itemcode")
                                            cmd5.Parameters.AddWithValue("@id_oden", id_orden);
                                            cmd5.Parameters.AddWithValue("@lotept", LotePT);
                                            cmd5.ExecuteNonQuery();
                                        }
                                    }
                                }

                                
                                //transaction.Commit();
                                cnx3.Close();
                            }
                            else
                                return;

                        }
                                this.DialogResult = DialogResult.OK;

                        break;
                }

                //this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                //transaction.Rollback();
                CajaDialogo.Error(ex.Message);                                      
            }
        }

        private void xfrmPesajeIndividual_Load(object sender, EventArgs e)
        {
            if (tipoPesaje==(int)TipoPesaje.PesajeNucleo)
            {
                labelControl1.Visible = false;
                cmdUp.Visible = false;
                cmdDown.Visible = false;
                seBatch.Visible = false;
                simpleButton1.Visible = false;
                cmdSum10.Visible = false;
            }
        }

        private void Bascula1_Click(object sender, EventArgs e)
        {
            BasculaSelected = 1;
            Bascula1.Appearance.BackColor = Color.FromArgb(51, 196, 129);
            Bascula2.Appearance.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void Bascula2_Click(object sender, EventArgs e)
        {
            BasculaSelected = 2;
            Bascula2.Appearance.BackColor = Color.FromArgb(51, 196, 129);
            Bascula1.Appearance.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}