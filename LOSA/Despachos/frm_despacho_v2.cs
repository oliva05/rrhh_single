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
using LOSA.Clases;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Despachos
{
    public partial class frm_despacho_v2 : DevExpress.XtraEditors.XtraForm
    {
        public int id_despacho;
        public int N_Documento;
        string Error = "";
        DataOperations dp = new DataOperations();
        private int idTarima;
        private decimal factorPresentacion;
        UserLogin usuarioLogueado = new UserLogin();
        Tarima tarimaEncontrada;

        public frm_despacho_v2()
        {
            InitializeComponent();

            load_data();
        }
        public void load_datar()
        {
            string query = @"sp_load_info_despacho_to_entregar";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_despacho", id_despacho);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.info_despacho.Clear();
                da.Fill(ds_despachos.info_despacho);
                cn.Close();
                txtDocumento.Text = N_Documento.ToString();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_data()
        {
            string query = @"sp_load_info_operador_pt_despachos";
            SqlConnection CN = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand(query, CN);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.op_despachos.Clear();
                da.Fill(ds_despachos.op_despachos);
                CN.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_activas()
        {
            string query = @"sp_load_info_operador_pt_despachos_todos";
            SqlConnection CN = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand(query, CN);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.op_despachos.Clear();
                da.Fill(ds_despachos.op_despachos);
                CN.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_data.FocusedView;
                var row = (ds_despachos.op_despachosRow)gridView.GetFocusedDataRow();
                 id_despacho=  row.id;
                N_Documento = row.DespachoN;
                load_datar();
                load_filas();
                Frame_Despasho.SelectedPageIndex =  2;
                beTarima.Focus();



            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_filas()
        {
            string query = @"sp_load_tarimas_to_orden_despacho";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_h", id_despacho);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.producto_carga.Clear();
                da.Fill(ds_despachos.producto_carga);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void timerLimpiarMensaje_Tick(object sender, EventArgs e)
        {
            load_activas();
            load_data();
            load_filas();
            timerLimpiarMensaje.Stop();
            timerLimpiarMensaje.Enabled = false;
            panelNotificacion.BackColor = Color.White;
            txtCantidadT.Text = txtPeso.Text = "0";
            beTarima.Text = "";
            gcTarima.DataSource = null;
            lblMensaje.Text = "";
            beTarima.Focus();
        }

        private DataTable CreateDataTarima(int idTarima, string pProveedor, string pNombreTarima, string pLote, string pPpresentacion)
        {
            DataTable dt = new DataTable();

            try
            {
                dt.Columns.Add("Detalle", typeof(string));
                dt.Columns.Add("Valor", typeof(string));


                dt.Rows.Add("TARIMA", idTarima);
                dt.Rows.Add("Cliente", pProveedor);
                dt.Rows.Add("LOTE", pLote);
                dt.Rows.Add("PRESENTACION", pPpresentacion);

                return dt;
            }
            catch (Exception error)
            {
                CajaDialogo.Information(error.Message);
                return dt;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Frame_Despasho.SelectedPageIndex = 0;
        }

        void datosTarimaPorCodBarra(SqlConnection connection)
        {
            Tarima InfoTarima = new Tarima();
            try
            {
                using (connection)
                {
                    string SQL = "exec sp_getTarimas_without_filters_PT @codigo_barra";
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cmd.Connection = connection;
                    cmd.CommandText = SQL;

                    cmd.Parameters.AddWithValue("@codigo_barra", beTarima.Text);

                    connection.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            idTarima = dr.GetInt32(0);

                            if (InfoTarima.RecuperarRegistropt(idTarima, ""))
                            {
                                factorPresentacion = InfoTarima.Factor;
                                tarimaEncontrada = InfoTarima;
                            }

                            gcTarima.DataSource = CreateDataTarima(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3).ToString(), dr.GetString(4).ToString());
                            //gvTarima.InitNewRow += GridView1_InitNewRow;
                            gvTarima.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("TARIMA NO ENCONTRADA");
                        tarimaEncontrada = null;
                        gcTarima.DataSource = null;
                        beTarima.Text = "";
                    }

                    cn.Close();

                }
            }
            catch (Exception error)
            {
                CajaDialogo.Error(error.Message);
            }
        }

        public void EntregarTarima()
        {
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            datosTarimaPorCodBarra(cn);

            //Entrega de tarima
            bool Guardo = false;
            bool error = false;
            bool disponible = false;
            string mensaje = "";
            if (tarimaEncontrada != null)
            {
                if (tarimaEncontrada.Recuperado)
                {
                    if (!tarimaEncontrada.Enable)
                    {
                        error = true;
                        mensaje = "La tarima no esta activa!";
                    }

                    if (tarimaEncontrada.Id_estadoCalidad > 1)
                    {
                        error = true;
                        mensaje = "La tarima no esta Disponible por parte de Calidad!";
                    }

                    if (!error)
                    {
                        txtCantidadT.Text = string.Format("{0:###,##0.00}", tarimaEncontrada.Cantidad);
                        txtPeso.Text = string.Format("{0:###,##0.00}", tarimaEncontrada.Peso);

                        try
                        {
                            DataOperations dp = new DataOperations();
                            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                            con.Open();
                            int result = 0;
                            SqlCommand cmd = new SqlCommand("sp_verifica_diponibilidad_tarima_entrega_pt", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id", tarimaEncontrada.Id);
                            cmd.Parameters.AddWithValue("@id_despacho", id_despacho);
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                result = Convert.ToInt32(dr.GetValue(0));
                                Error = dr.GetString(1);
                            }
                            //disponible = Convert.ToBoolean(cmd.ExecuteScalar());
                            if (result == 1)
                            {
                                disponible = true;
                            }
                            else
                            {
                                disponible = false;
                            }
                            dr.Close();
                            con.Close();
                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error(ec.Message);
                        }


                        if (!disponible)
                        {
                            error = true;
                            mensaje = Error;
                        }

                        //if (!error)//Si error sigue en false evaluaremos la ubicacion.
                        //{
                        //    Ubicacion_Tarima ub1 = new Ubicacion_Tarima();
                        //    if (ub1.RecuperarRegistro(tarimaEncontrada.Id, ""))
                        //    {
                        //        if (ub1.IdBodega != 10)
                        //        {
                        //            error = true;
                        //            mensaje = "La tarima no esta en la bodega de Producto Terminado, no se puede entregar!";
                        //        }
                        //    }
                        //    else
                        //    {
                        //        error = true;
                        //        mensaje = "La tarima no tiene una ubicacion valida, aun esta en proceso de colocacion!";
                        //    }
                        //}
                    }
                }
                else
                {
                    error = true;
                    mensaje = "El codigo de barra leido no es correcto!";
                }

                if (error)
                {
                    lblMensaje.Text = mensaje;
                    panelNotificacion.BackColor = Color.Red;
                    timerLimpiarMensaje.Enabled = true;
                    timerLimpiarMensaje.Start();
                    return;
                }
                frm_seleccionUD frm = new frm_seleccionUD(Convert.ToDecimal(txtCantidadT.Text));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                        con.Open();

                        SqlCommand cmd = new SqlCommand("sp_set_insert_salida_tarima_pt_v3", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idtarima", tarimaEncontrada.Id);
                        cmd.Parameters.AddWithValue("@id_usuario", usuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@unidades", frm.Ud);
                        cmd.Parameters.AddWithValue("@id_despacho_h", id_despacho);
                        Guardo = Convert.ToBoolean(cmd.ExecuteScalar());
                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        //CajaDialogo.Error(ec.Message);
                        lblMensaje.Text = ec.Message;
                        panelNotificacion.BackColor = Color.Red;
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                    }

                    if (Guardo)
                    {
                        //Mensaje de transaccion exitosa
                        lblMensaje.Text = "Transacción Exitosa!";
                        panelNotificacion.BackColor = Color.MediumSeaGreen;
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                    }
                }

            }
            else
            {
                lblMensaje.Text = "No se encontro el registro de la tarima!";
                panelNotificacion.BackColor = Color.Red;
                timerLimpiarMensaje.Enabled = true;
                timerLimpiarMensaje.Start();
            }

        }
        private void beTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EntregarTarima();
            }
        }
    }
}