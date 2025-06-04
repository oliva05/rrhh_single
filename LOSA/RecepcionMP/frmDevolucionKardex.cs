﻿using ACS.Classes;
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


namespace LOSA.RecepcionMP
{
    public partial class frmDevolucionKardex : Form
    {
        opcionAbrirVentanaTarima windowTarimaOption = new opcionAbrirVentanaTarima();
        DataOperations dp = new DataOperations();
        private int idTarima;
        private decimal factorPresentacion;
        UserLogin usuarioLogueado = new UserLogin();
        public frmDevolucionKardex(UserLogin pUsuarioLogueado)
        {
            InitializeComponent();
            usuarioLogueado = pUsuarioLogueado;
        }

        public void GET_InventoryEntregado()
        {
            try
            {
                string Query = @"sp_set_cantidad_devolucion_inventario";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tarima", idTarima);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsDevoluciones.mp.Clear();
                da.Fill(dsDevoluciones.mp);
                
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void CmdSelectTarima_Click(object sender, EventArgs e)
        {}

        void datosTarimaPorCodBarra(SqlConnection connection)
        {
            Tarima InfoTarima = new Tarima();
            try
            {
                using (connection)
                {
                    string SQL = "exec sp_getTarimas_without_filters @codigo_barra";
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cmd.Connection = connection;
                    cmd.CommandText = SQL;

                    cmd.Parameters.AddWithValue("@codigo_barra", beTarima.Text.Replace("H", ""));

                    connection.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            idTarima = dr.GetInt32(0);

                            if (InfoTarima.RecuperarRegistro(idTarima, ""))
                            {
                                factorPresentacion = InfoTarima.Factor;
                            }
                           
                            gcTarima.DataSource = CreateDataTarima(dr.GetInt32(0), dr.GetString(2), dr.GetString(1), dr.GetString(5), dr.GetString(6));
                            //gvTarima.InitNewRow += GridView1_InitNewRow;
                            gvTarima.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("TARIMA NO ENCONTRADA");
                        gcTarima.DataSource = null;
                        beTarima.Text = "";
                    }

                    cn.Close();

                    GET_InventoryEntregado();
                }
            }
            catch (Exception error)
            {
                CajaDialogo.Error(error.Message);
            }
        }

        private DataTable CreateDataTarima(int idTarima, string pProveedor, string pNombreTarima, string pLote, string pPpresentacion)
        {
            DataTable dt = new DataTable();

            try
            {
                dt.Columns.Add("Detalle", typeof(string));
                dt.Columns.Add("Valor", typeof(string));


                dt.Rows.Add("TARIMA", idTarima);
                dt.Rows.Add("PROVEEDOR", pProveedor);
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

        private void TxtCantidadT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPeso.Text = Math.Round(factorPresentacion * Convert.ToDecimal(txtCantidadT.Text), 2).ToString();
            }
        }

        private void TxtCantidadT_Leave(object sender, EventArgs e)
        {
            txtPeso.Text = Math.Round((factorPresentacion * Convert.ToDecimal(txtCantidadT.Text)), 2).ToString();
        }

        private void TxtCantidadT_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool Guardado = false;
            int validacion_bloqueo;
            //int vid_tarima = 0;

            if (gvTarima.RowCount <= 0)
            {
                CajaDialogo.Error("Debe seleccionar una tarima");
                beTarima.Focus();
                return;
            }

            if (Convert.ToDecimal(txtPeso.Text) <= 0)
            {
                CajaDialogo.Error("Debe ingresar una cantidad mayor que cero (0)");
                return;
            }

            bool Selected = false;
            foreach (dsDevoluciones.mpRow row in dsDevoluciones.mp.Rows)
            {
                if (row.selected)
                {
                    Selected = true;
                }
            }
            if (!Selected)//Validar las requisas actualizadas.
            {
                CajaDialogo.Error("Debe seleccionar al menos una requisa que se desee devolver el inventario.");
                return;
            }

            foreach (dsDevoluciones.mpRow item in dsDevoluciones.mp.Rows)
            {
                if (item.selected)
                {
                    if (item.consumido)
                    {
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, "No se puede devolver este Registro de Entrega por que ya fue Consumido!");
                        if (frm.ShowDialog() == DialogResult.Cancel)
                        {
                            beTarima.Text = "";
                            gcTarima.DataSource = null;
                            //dsDevoluciones.mp.Clear();
                           
                            txtCantidadT.EditValue = 0;
                            txtPeso.EditValue = 0;
                            beTarima.Focus();
                            return;
                        }
                    }
                }
            }

            try
            {

                //int CantBack = 0;
                foreach (dsDevoluciones.mpRow item in dsDevoluciones.mp.Rows)
                {
                    if (item.selected)
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                        con.Open();

                        //SqlCommand cmd = new SqlCommand("sp_set_devolucion_of_requisa", con);
                        //cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@id_tarima", this.idTarima);
                        //cmd.Parameters.AddWithValue("@id_entrega", item.id);
                        //cmd.Parameters.AddWithValue("@CantUd", item.cantidad_unidades);
                        //cmd.Parameters.AddWithValue("@CantKg", item.cantidad_entregada);
                        //CantBack = Convert.ToInt32(cmd.ExecuteScalar());

                        //if (CantBack != 1)
                        //{
                        //    CajaDialogo.Error("No se puede devolver las unidades de la requisa " + item.barcode + " por que ya fueron consumidas.");

                        //}
                        //else
                        //{
                        SqlCommand cmd = new SqlCommand("sp_insert_kardex_from_devoluciones_formv2", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_tarima", this.idTarima);
                        cmd.Parameters.AddWithValue("@id_entrega", item.id);
                        cmd.Parameters.AddWithValue("@tipo_transaccion", 1);
                        cmd.Parameters.AddWithValue("@cantidad", Convert.ToDecimal(item.cantidad_unidades));
                        cmd.Parameters.AddWithValue("@id_usuario", usuarioLogueado.Id);
                        //cmd.Parameters.AddWithValue("@peso", Convert.ToDecimal(txtPeso.Text));
                        cmd.Parameters.AddWithValue("@peso", Convert.ToDecimal(item.cantidad_entregada));
                        validacion_bloqueo = Convert.ToInt32(cmd.ExecuteScalar());

                        switch (validacion_bloqueo)
                        {
                            case 1:

                                Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, "No se puede devolver la tarima por que la requisa " + item.barcode + " esta Cerrada! ");
                                if (frm.ShowDialog() == DialogResult.Cancel)
                                {
                                    beTarima.Text = "";
                                    gcTarima.DataSource = null;
                                    //dsDevoluciones.mp.Clear();
                                    txtCantidadT.EditValue = 0;
                                    txtPeso.EditValue = 0;
                                    beTarima.Focus();
                                }

                                break;

                            case 2:
                                Guardado = true;
                                break;

                            case 3:

                                Utileria.frmMensajeCalidad frm1 = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, "No existe Inventario en B018 del lote " + item.lote_materia_prima + ", para realizar esta devolucion.");
                                if (frm1.ShowDialog() == DialogResult.Cancel)
                                {
                                    beTarima.Text = "";
                                    gcTarima.DataSource = null;
                                    //dsDevoluciones.mp.Clear();
                                    txtCantidadT.EditValue = 0;
                                    txtPeso.EditValue = 0;
                                    beTarima.Focus();
                                }
                                break;

                            default:
                                break;
                        }


                        if (validacion_bloqueo == 1)
                        {
                            CajaDialogo.Error("No se puede devolver la tarima por que la requisa " + item.barcode + " esta Cerrada!");
                            beTarima.Text = "";
                            gcTarima.DataSource = null;
                            grd_requisa.DataSource = null;
                            txtCantidadT.EditValue = 0;
                            txtPeso.EditValue = 0;

                            beTarima.Focus();
                        }
                        if (validacion_bloqueo == 3)
                        {
                            CajaDialogo.Error("No existe Inventario en B018 del lote " + item.lote_materia_prima + ", para realizar esta devolucion.");
                            beTarima.Text = "";
                            gcTarima.DataSource = null;
                            grd_requisa.DataSource = null;
                            txtCantidadT.EditValue = 0;
                            txtPeso.EditValue = 0;

                            beTarima.Focus();
                        }
                        else
                        {
                            Guardado = true;
                        }
                        //}


                        con.Close();
                    }

                }





                //CajaDialogo.InformationAuto();
            }
            catch (Exception ec)
            {
                Guardado = false;
                CajaDialogo.Error(ec.Message);
            }


            if (Guardado == true)
            {
                CajaDialogo.Information("Datos guardados exitosamente!");
                this.Close();
            }
        }

        private void BeTarima_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            beTarima.Text = "";
            gcTarima.DataSource = null;
        }

        private void BeTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                datosTarimaPorCodBarra(cn);
            }
        }

        private void frmDevolucionKardex_Activated(object sender, EventArgs e)
        {
            beTarima.Focus();
        }

        private void frmDevolucionKardex_Load(object sender, EventArgs e)
        {
            beTarima.Focus();
        }

        private void grdv_requisa_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_requisa.FocusedView;
                var row = (dsDevoluciones.mpRow)gridView.GetFocusedDataRow();
                //if (row.consumido)
                //{
                //    CajaDialogo.Error("MP Consumida: No se puede realizar la Devolucion!");
                //}
                //else
                //{
                //    row.selected = Convert.ToBoolean(e.Value);
                //    row.AcceptChanges();
                //}

                if (e.Column.FieldName == "selected")
                {
                    row.selected = Convert.ToBoolean(e.Value);
                    row.AcceptChanges();
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void grdv_requisa_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_requisa.FocusedView;
                var row = (dsDevoluciones.mpRow)gridView.GetDataRow(e.RowHandle);
              
                if (e.RowHandle >= 0)
                {

                    if (row.selected == true)
                    {
                        e.Appearance.BackColor = Color.FromArgb(148, 213, 181);

                    }
                    else
                    {
                        e.Appearance.BackColor = Color.White;
                    }


                    double Unidades;
                    double Kilogramos;


                    Unidades = 0;
                    Kilogramos = 0;
                    foreach (dsDevoluciones.mpRow rows in dsDevoluciones.mp.Rows)
                    {
                        if (rows.selected)
                        {
                            Unidades = Unidades + rows.cantidad_unidades;
                            Kilogramos = Kilogramos + rows.cantidad_entregada;
                        }
                    }
                    txtPeso.Text = Kilogramos.ToString();
                    txtCantidadT.Text = Unidades.ToString();
                }
                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}
