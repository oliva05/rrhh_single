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
using LOSA.TransaccionesMP.Liquidos;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.TransaccionesMP.VentanasMensajes;
using LOSA.MicroIngredientes;
using LOSA.Micro;
using LOSA.MicroIngredientes.Reportes;
using DevExpress.XtraReports.UI;

namespace LOSA.TransaccionesMP
{
    public partial class frmEntregaTarimaMicros : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        private int idTarima;
        private decimal factorPresentacion;
        private int IsMicro = 0;
        UserLogin usuarioLogueado = new UserLogin();
        Tarima tarimaEncontrada;
        Requisicion RequisicionActual = new Requisicion();
        DataTable DT_Tarima;
        public frmEntregaTarimaMicros(UserLogin Puser)
        {
            InitializeComponent();
            usuarioLogueado = Puser;
            //load_tarimas_scan();
            //load_bines_disponibles();
            LoadDataMicros();
            LoadTarimas();
            txtTarima.Focus();
        }

        private void LoadDataMicros()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_lotes_micro_ingredientes_V3", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsMicro1.informacionPRD_micro.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMicro1.informacionPRD_micro);

                //cmd = new SqlCommand("sp_get_lotes_micro_ingredientes_V4", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                ////cmd.Parameters.AddWithValue("@idbodega", idBodega);
                //dsMicro1.informacionPRD_micro_tentative.Clear();
                //adat = new SqlDataAdapter(cmd);
                //adat.Fill(dsMicro1.informacionPRD_micro_tentative);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void load_bines_disponibles()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_bines_disponibles_liquidos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsTransaccionesMP.bines_disponibles.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTransaccionesMP.bines_disponibles);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void load_bines_disponiblesByReq(int pIdRequisicion)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_bines_con_disponible_produccion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_requisicion", pIdRequisicion);
                dsTransaccionesMP.bines_dispo_prd.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTransaccionesMP.bines_dispo_prd);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public void load_tarimas_scan()
        {
            string query = @"sp_load_tarimas_escaneadas";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            SqlCommand cmd = new SqlCommand(query,cn);
            cmd.CommandType = CommandType.StoredProcedure;
            dsTransaccionesMP.viewTarimas.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsTransaccionesMP.viewTarimas);
            cn.Close();

            
        }
        public void load_tarimas_scan_v2()
        {
            string query = @"sp_load_tarimas_escaneadas_v2";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_requisa", RequisicionActual.IdRequisicion);
            dsTransaccionesMP.viewTarimas.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsTransaccionesMP.viewTarimas);
            cn.Close();

        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerLimpiarMensaje_Tick(object sender, EventArgs e)
        {
            timerLimpiarMensaje.Stop();
            timerLimpiarMensaje.Enabled = false;
            panelNotificacion.BackColor = Color.White;
            //txtCantidadT.Text = txtPeso.Text = "0";
            txtTarima.Text = "";
            lblMensaje.Text = "";
            txtTarima.Focus();
            //pictureBoxIndicadorOk.Visible = false;
            //txtentrega.Text = string.Format("{0:###,##0.00}", 0);
            //txtpesoendregadas.Text = string.Format("{0:###,##0.00}", 0);
            //txtsolicitada.Text = string.Format("{0:###,##0.00}", 0);
            //txtdevueltas.Text = string.Format("{0:###,##0.00}", 0);
            //txtrequeridas.Text = string.Format("{0:###,##0.00}", 0);

            //txtacumualdo.Text = string.Format("{0:###,##0.00}", 0);
        }

        private void txtRequisicion_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtTarima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                datosTarimaPorCodBarra(cn);

                //Entrega de tarima
                bool Guardo = false;
                bool error = false;
                string mensaje = "";
                decimal ExistenciaTM = 0;
                decimal Pentregado = 0;
                decimal factor = 0;
                if (tarimaEncontrada != null)
                {
                    //Validar si la tarima escaneada es valida
                    if (tarimaEncontrada.Recuperado)
                    {
                        //Validar Estaso de Tarima
                        switch (tarimaEncontrada.Id_estado_tarima)
                        {
                            case 1://Recepcionado
                                error = true;//No tien ubicacion
                                mensaje = "Esta tarima aun no ha sido ingresada a bodega! Solo se genero el rotulo, es necesario activar y ubicar!.";
                                break;
                            case 2://En Bodega
                                error = true;
                                mensaje = "La tarima aun se encuentra en Bodega de MP!";
                                break;
                            case 3://Retenido
                                error = true;
                                mensaje = "Esta Tarima esta Retenida!";
                                break;
                            case 4://Comprometido
                                error = true;
                                mensaje = "Esta tarima ya esta comprometida!";
                                break;
                            case 5://En Produccion
                                error = false;//esta habilitada
                                              //mensaje = "Esta tarima ya fue entrega a Producción";
                                break;
                            case 6://Consumido
                                error = true;
                                mensaje = "Esta Tarima ya fue entregada y consumida por producción!";
                                break;
                            //case 7://
                            //    error = true;
                            //    mensaje = "Calidad tiene Retenida ésta tarima.!";
                            //    break;
                            case 8://Parcialmente Entregado
                                error = false;
                                //mensaje = "Calidad ha Rechazado ésta tarima.!";
                                break;
                            case 9://Rechazado
                                error = true;
                                mensaje = "Esta tarima fue Rechazada!";
                                break;
                            case 10://Ajuste de Inventario
                                error = true;
                                mensaje = "Esta tarima tuvo salida por ajuste de Inventario!";
                                break;
                        }

                        if (error)
                        {
                            lblMensaje.Text = mensaje;
                            Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                            frm.ShowDialog();
                            panelNotificacion.BackColor = Color.Red;
                            timerLimpiarMensaje.Enabled = true;
                            timerLimpiarMensaje.Start();
                            return;
                        }
                        //Validacion Estados de Calidad
                        switch (tarimaEncontrada.Id_estadoCalidad)
                        {
                            case 1://Habilitado
                                error = false;//esta habilitada
                                break;
                            case 2://En Observacion
                                error = true;
                                mensaje = "Calidad tiene En Observación ésta tarima.!";
                                break;
                            case 3://Retenido
                                error = true;
                                mensaje = "Calidad tiene Retenida ésta tarima.!";
                                break;
                            case 4://Rechazado
                                error = true;
                                mensaje = "Calidad ha Rechazado ésta tarima.!";
                                break;
                            default:
                                error = true;//esta habilitada
                                mensaje = "Esta tarima un no ha sido inspeccionada por Calidad!";
                                break;
                        }

                        if (error)
                        {
                            lblMensaje.Text = mensaje;
                            Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                            frm.ShowDialog();
                            panelNotificacion.BackColor = Color.Red;
                            timerLimpiarMensaje.Enabled = true;
                            timerLimpiarMensaje.Start();
                            return;
                        }


                        //Si no se ha generado ninguna validacion previa de bloqueo el programa permitira seguir ejecutando.
                        if (!error)
                        {
                            DataOperations dp = new DataOperations();
                            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                            con.Open();
                            frm_entrega_tarima_micros frmx = new frm_entrega_tarima_micros(tarimaEncontrada.Id, tarimaEncontrada.CodigoBarra, tarimaEncontrada.IdPresentacion);

                            //Validar la disponibilidad de la tarima para poder efectuar la entrega
                            //SqlCommand cmd = new SqlCommand("[sp_get_lotes_micro_ingredientes_V5]", con);
                            //cmd.CommandType = CommandType.StoredProcedure;
                            //cmd.Parameters.AddWithValue("@id_tarima", tarimaEncontrada.Id);
                            //cmd.Parameters.AddWithValue("@bar_code", tarimaEncontrada.CodigoBarra);
                            //SqlDataAdapter adat = new SqlDataAdapter(cmd);
                            //dsMicro2.informacionPRD_micro.Clear();
                            //adat.Fill(dsMicro2.informacionPRD_micro);

                            //frmResumenToEntregar frms = new frmResumenToEntregar(ExistenciaTM
                            //                                                    , Pentregado
                            //                                                    , 0//Psolicitado
                            //                                                    , DT_Tarima
                            //                                                    , idTarima
                            //                                                    , factor);
                            //if (frms.ShowDialog() == DialogResult.OK)
                            Guardo = false;
                            if (frmx.ShowDialog() == DialogResult.OK)
                            {
                                try
                                {

                                    SqlCommand cmd = new SqlCommand("sp_insert_tarima_micro_ing", con);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@id_tarima", tarimaEncontrada.Id);
                                    cmd.Parameters.AddWithValue("@id_usuario", usuarioLogueado.Id);
                                    cmd.Parameters.AddWithValue("@cantidad_unidades", frmx.UdEnviar);
                                    cmd.Parameters.AddWithValue("@cantidadkg", frmx.KgEnviar);

                                    //cmd.Parameters.AddWithValue("@id_req", RequisicionActual.IdRequisicion);
                                    SqlDataReader dr = cmd.ExecuteReader();
                                    if (dr.Read())
                                    {
                                        Guardo = dr.GetInt32(0) == 1 ? true : false;
                                    }
                                    dr.Close();
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

                            }
                            else
                            {
                                txtTarima.Text = "";
                                txtTarima.Focus();
                            }
                            if (Guardo)
                            {
                                //Mensaje de transaccion exitosa
                                lblMensaje.Text = "Transacción Exitosa!";
                                panelNotificacion.BackColor = Color.MediumSeaGreen;
                                timerLimpiarMensaje.Enabled = true;
                                timerLimpiarMensaje.Start();
                                LoadDataMicros();
                            }

                        }
                        else
                        {
                            lblMensaje.Text = mensaje;
                            Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                            if (frm.ShowDialog() == DialogResult.Cancel)
                            {

                            }
                            panelNotificacion.BackColor = Color.Red;
                            timerLimpiarMensaje.Enabled = true;
                            timerLimpiarMensaje.Start();
                            return;
                        }
                    }
                    else
                    {
                        error = true;
                        mensaje = "El codigo de barra leido no es correcto!";
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                        if (frm.ShowDialog() == DialogResult.Cancel)
                        {

                        }
                        panelNotificacion.BackColor = Color.Red;
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                        return;
                    }



                    //TarimasParaMicros();
                    //LoadDataMicros();
                }
            }
        }

        private void TarimasParaMicros()
        {
            //sp_get_lotes_micro_ingredientes_V5
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_lotes_micro_ingredientes_V3]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_tarima", idBodega);
                //cmd.Parameters.AddWithValue("@bar_code", idBodega);
                dsMicro1.informacionPRD_micro.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMicro1.informacionPRD_micro);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        //private DataTable CreateDataTarima(int idTarima, string pProveedor, string pNombreTarima, string pLote, string pPpresentacion, string codigoSAP, string MP)
        //{
        //    DataTable dt = new DataTable();

        //    try
        //    {
        //        dt.Columns.Add("Detalle", typeof(string));
        //        dt.Columns.Add("Valor", typeof(string));


        //        dt.Rows.Add("TARIMA", idTarima);
        //        dt.Rows.Add("PROVEEDOR", pProveedor);
        //        dt.Rows.Add("LOTE", pLote);
        //        dt.Rows.Add("PRESENTACION", pPpresentacion);

        //        dt.Rows.Add("Codigo", codigoSAP);
        //        dt.Rows.Add("Materia Prima", MP);

        //        return dt;
        //    }
        //    catch (Exception error)
        //    {
        //        CajaDialogo.Information(error.Message);
        //        return dt;
        //    }
        //}

        private DataTable CreateDataTarima(Tarima pTarima)
        {
            DataTable dt = new DataTable();

            try
            {
                dt.Columns.Add("Detalle", typeof(string));
                dt.Columns.Add("Valor", typeof(string));


                dt.Rows.Add("TARIMA", pTarima.Id);
                dt.Rows.Add("PROVEEDOR", pTarima.Proveedor);
                dt.Rows.Add("LOTE", pTarima.LoteMP);
                dt.Rows.Add("PRESENTACION", pTarima.Descripcionpresentacion);

                dt.Rows.Add("Codigo", pTarima.ItemCode);
                dt.Rows.Add("Materia Prima", pTarima.MateriaPrima);

                return dt;
            }
            catch (Exception error)
            {
                CajaDialogo.Information(error.Message);
                return dt;
            }
        }
        void datosTarimaPorCodBarra(SqlConnection connection)
        {
            Tarima InfoTarima = new Tarima();
            try
            {
                using (connection)
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    string LocalBarcode = txtTarima.Text;


                    //Get id Estado Tarima
                    SqlCommand cmd = new SqlCommand("sp_getTarimas_without_filters_v4", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo_barra", txtTarima.Text);
                    cmd.Parameters.AddWithValue("@tipo_query", 1);
                    SqlDataReader dr = cmd.ExecuteReader();
                    int idEstadoTarima = 0;
                    if (dr.Read())
                    {
                        idEstadoTarima = dp.ValidateNumberInt32(dr.GetValue(0));
                    }
                    dr.Close();

                    bool Error = false;
                    string mensaje = " ";
                    switch (idEstadoTarima)
                    {
                        case 0:
                        default:
                            mensaje = "TARIMA NO ENCONTRADA";
                            Error = true;
                            break;
                        case 1://Recepcionado
                            mensaje = "Esta tarima aun no ha sido ingresada a bodega! Solo se genero el rotulo, es necesario activar y ubicar!.";
                            Error = true;
                            break;
                        case 2://En Bodega
                            break;
                        case 3://Retenido
                            mensaje = "Esta Tarima esta Retenida!";
                            Error = true;
                            break;
                        case 4://Comprometido
                            mensaje = "Esta tarima ya esta comprometida!";
                            Error = true;
                            break;
                        case 5://En Produccion
                            //mensaje = "Esta tarima ya fue entrega a Producción";
                            Error = false;
                            break;
                        case 6://Consumido
                            mensaje = "Esta Tarima ya fue entregada y consumida por producción!";
                            Error = true;
                            break;
                        case 8://Parcialmente Entregado
                            break;
                        case 9://Rechazado
                            mensaje = "Esta tarima fue Rechazada!";
                            Error = true;
                            break;
                        case 10://Ajuste de Inventario
                            mensaje = "Esta tarima tuvo salida por ajuste de Inventario!";
                            Error = true;
                            break;
                    }

                    if (Error)
                    {
                        lblMensaje.Text = mensaje;
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                        frm.ShowDialog();
                        panelNotificacion.BackColor = Color.FromArgb(255,102,102);
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                        tarimaEncontrada = new Tarima();
                        tarimaEncontrada.RecuperarRegistro_v3(0, LocalBarcode);
                        return;
                    }


                    cmd = new SqlCommand("sp_getTarimas_without_filters_v4", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo_barra", txtTarima.Text);
                    cmd.Parameters.AddWithValue("@tipo_query", 2);//Get Data de la tarima
                    DT_Tarima = new DataTable();
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    adat.Fill(DT_Tarima);
                    //Sacamos el id de la tarima
                    foreach (DataRow row in DT_Tarima.Rows)
                    {
                        idTarima = dp.ValidateNumberInt32(row[0]);
                        break;
                    }

                    tarimaEncontrada = new Tarima();
                    tarimaEncontrada.RecuperarRegistro_v3(idTarima, "");

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
            //bool disponible = false;
            string mensaje = "";
            decimal ExistenciaKgTarima = 0;
            decimal ExistenciaUnidades = 0;
            decimal Pentregado = 0;
            //decimal Psolicitado = 0;
            decimal factor = 0;
            //tarimaEncontrada = new Tarima();
            //tarimaEncontrada.RecuperarRegistro(0, txtTarima.Text);
            if (tarimaEncontrada != null)
            {
               

                //Validar si la tarima escaneada es valida
                if (tarimaEncontrada.Recuperado)
                {
                    //Validar Estaso de Tarima
                    switch (tarimaEncontrada.Id_estado_tarima)
                    {
                        case 1://Recepcionado
                            error = true;//No tien ubicacion
                            mensaje = "Esta tarima aun no ha sido ingresada a bodega! Solo se genero el rotulo, es necesario activar y ubicar!.";
                            break;
                        case 2://En Bodega
                            error = true;
                            mensaje = "La tarima aun se encuentra en Bodega de MP!";
                            break;
                        case 3://Retenido
                            error = true;
                            mensaje = "Esta Tarima esta Retenida!";
                            break;
                        case 4://Comprometido
                            error = true;
                            mensaje = "Esta tarima ya esta comprometida!";
                            break;
                        case 5://En Produccion
                            error = false;//esta habilitada
                            //mensaje = "Esta tarima ya fue entrega a Producción";
                            break;
                        case 6://Consumido
                            error = true;
                            mensaje = "Esta Tarima ya fue entregada y consumida por producción!";
                            break;
                        //case 7://
                        //    error = true;
                        //    mensaje = "Calidad tiene Retenida ésta tarima.!";
                        //    break;
                        case 8://Parcialmente Entregado
                            error = false;
                            //mensaje = "Calidad ha Rechazado ésta tarima.!";
                            break;
                        case 9://Rechazado
                            error = true;
                            mensaje = "Esta tarima fue Rechazada!";
                            break;
                        case 10://Ajuste de Inventario
                            error = true;
                            mensaje = "Esta tarima tuvo salida por ajuste de Inventario!";
                            break;
                    }

                    if (error)
                    {
                        lblMensaje.Text = mensaje;
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                        frm.ShowDialog();
                        panelNotificacion.BackColor = Color.Red;
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                        return;
                    }
                    //Validacion Estados de Calidad
                    switch (tarimaEncontrada.Id_estadoCalidad)
                    {
                        case 1://Habilitado
                            error = false;//esta habilitada
                            break;
                        case 2://En Observacion
                            error = true;
                            mensaje = "Calidad tiene En Observación ésta tarima.!";
                            break;
                        case 3://Retenido
                            error = true;
                            mensaje = "Calidad tiene Retenida ésta tarima.!";
                            break;
                        case 4://Rechazado
                            error = true;
                            mensaje = "Calidad ha Rechazado ésta tarima.!";
                            break;
                        default:
                            error = true;//esta habilitada
                            mensaje = "Esta tarima un no ha sido inspeccionada por Calidad!";
                            break;
                    }

                    if(error)
                    {
                        lblMensaje.Text = mensaje;
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                        frm.ShowDialog();
                        panelNotificacion.BackColor = Color.Red;
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                        return;
                    }


                    //Si no se ha generado ninguna validacion previa de bloqueo el programa permitira seguir ejecutando.
                    if (!error)
                    {
                        //Validar la disponibilidad de la tarima para poder efectuar la entrega
                        try
                        {
                            DataOperations dp = new DataOperations();
                            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                            con.Open();

                            SqlCommand cmd = new SqlCommand("[dbo].[sp_verifica_diponibilidad_tarima_entrega_v8_micros]", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id", tarimaEncontrada.Id);
                            //cmd.Parameters.AddWithValue("@id_req", RequisicionActual.IdRequisicion);
                            SqlDataReader dr = cmd.ExecuteReader();

                            if (dr.Read())
                            {
                                //disponible = dr.GetBoolean(0);
                                ExistenciaUnidades = dr.GetDecimal(2);
                                ExistenciaKgTarima = dr.GetDecimal(6);
                                //ExistenciaUnidades = dr.GetDecimal(3);
                                if (ExistenciaKgTarima <= 0)
                                {
                                    mensaje = "Esta tarima ya fue entregada en Alimentación!" +
                                              "\nSi tiene la tarima en fisico, significa que ubico dos rotulos iguales \nen varias tarimas" +
                                              "\nTip: Debe generar un nuevo rotulo para esta Tarima...";
                                    frmVentanaMsjTarimaAlimentacion frm =
                                        new frmVentanaMsjTarimaAlimentacion(mensaje, tarimaEncontrada.CodigoBarra);
                                    frm.ShowDialog();
                                    lblMensaje.Text = mensaje;
                                    panelNotificacion.BackColor = Color.Red;
                                    timerLimpiarMensaje.Enabled = true;
                                    timerLimpiarMensaje.Start();
                                    return;
                                }

                                Pentregado = dr.GetDecimal(3);
                                //Psolicitado = dr.GetDecimal(4);
                                factor = dr.GetDecimal(5);
                            }
                            dr.Close();
                            con.Close();

                        }
                        catch (Exception ec)
                        {
                            CajaDialogo.Error(ec.Message);
                        }

                        frmResumenToEntregar frms = new frmResumenToEntregar(ExistenciaKgTarima
                                                                            , ExistenciaUnidades
                                                                            , Pentregado
                                                                            , 0//Psolicitado
                                                                            , DT_Tarima
                                                                            , idTarima
                                                                            , factor);
                        if (frms.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {

                                DataOperations dp = new DataOperations();
                                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                                con.Open();

                                //SqlCommand cmm = new SqlCommand("sp_generar_codigo_from_tables_id_V3", con);
                                //cmm.CommandType = CommandType.StoredProcedure;
                                //cmm.Parameters.AddWithValue("@id", 8);
                                //string barcode = cmm.ExecuteScalar().ToString();

                                //SqlCommand cmd = new SqlCommand("sp_set_insert_salida_tarima_bodega_mp", con);
                                SqlCommand cmd = new SqlCommand("sp_insert_tarima_micro_ing", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_tarima", tarimaEncontrada.Id);
                                cmd.Parameters.AddWithValue("@id_usuario", usuarioLogueado.Id);
                                cmd.Parameters.AddWithValue("@cantidad_unidades", frms.ud_enviar);
                                cmd.Parameters.AddWithValue("@cantidadkg", frms.pesoKg);

                                //cmd.Parameters.AddWithValue("@id_req", RequisicionActual.IdRequisicion);
                                SqlDataReader dr = cmd.ExecuteReader();
                                if (dr.Read())
                                {
                                    Guardo = dr.GetInt32(0) == 1 ? true : false;
                                }
                                dr.Close();
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
                    else
                    {
                        lblMensaje.Text = mensaje;
                        Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                        if (frm.ShowDialog() == DialogResult.Cancel)
                        {

                        }
                        panelNotificacion.BackColor = Color.Red;
                        timerLimpiarMensaje.Enabled = true;
                        timerLimpiarMensaje.Start();
                        return;
                    }
                }
                else
                {
                    error = true;
                    mensaje = "El codigo de barra leido no es correcto!";
                    Utileria.frmMensajeCalidad frm = new Utileria.frmMensajeCalidad(Utileria.frmMensajeCalidad.TipoMsj.error, mensaje);
                    if (frm.ShowDialog() == DialogResult.Cancel)
                    {

                    }
                    panelNotificacion.BackColor = Color.Red;
                    timerLimpiarMensaje.Enabled = true;
                    timerLimpiarMensaje.Start();
                    return;
                }


            }
        }

        private void frmEntregaTarimaMicros_Activated(object sender, EventArgs e)
        {
            //txtRequisicion.Focus();
            txtTarima.Focus();
        }

        private void frmEntregaTarimaMicros_Load(object sender, EventArgs e)
        {

            //txtRequisicion.Focus();
        }

        private void cmdSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //seleccionar materia prima en planta

            //try
            //{
            //    var gridView = (GridView)grd_bines.FocusedView;
            //    var row = (dsTransaccionesMP.bines_dispo_prdRow)gridView.GetFocusedDataRow();

            //    if (row.disponibles_prd == 0)
            //    {
            //        CajaDialogo.Error("No hay bines pendientes que consumir en produccion.");
            //        return;
            //    }
            //    if (row.solicitada == row.entregada)
            //    {
            //        CajaDialogo.Error("Ya se ha entregado toda la materia prima de este producto.");
            //        return;
            //    }


            //    frmBinesEnPRD frm = new frmBinesEnPRD(RequisicionActual.IdRequisicion, row.id_materia_prima);
            //    if (frm.ShowDialog() == DialogResult.OK)
            //    {

            //        load_tarimas_scan_v2();
            //        load_bines_disponiblesByReq(RequisicionActual.IdRequisicion);
            //    }
            //}
            //catch (Exception ex)
            //{

            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void cmdLotesProximosVencerMP_Click(object sender, EventArgs e)
        {
            if(tarimaEncontrada != null)
            {
                if(tarimaEncontrada.Id_materiaprima >0)
                {
                    frmProximosA_vencer frm = new frmProximosA_vencer(tarimaEncontrada.Id_materiaprima);
                    frm.ShowDialog();
                }
            }
            
        }

        private void cmdLiquidos_Click(object sender, EventArgs e)
        {

        }

        private void cmdTrasladarA_Micros_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grid_mp_disponible_prd.FocusedView;
            var row = (dsMicro.informacionPRD_micro_tentativeRow)gridView.GetFocusedDataRow();


            frm_entrega_tarima_micros frmx = new frm_entrega_tarima_micros
                (row.id_mp, row.id_lote_alosy, row.lote);

            //Validar la disponibilidad de la tarima para poder efectuar la entrega
            //SqlCommand cmd = new SqlCommand("[sp_get_lotes_micro_ingredientes_V5]", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@id_tarima", tarimaEncontrada.Id);
            //cmd.Parameters.AddWithValue("@bar_code", tarimaEncontrada.CodigoBarra);
            //SqlDataAdapter adat = new SqlDataAdapter(cmd);
            //dsMicro2.informacionPRD_micro.Clear();
            //adat.Fill(dsMicro2.informacionPRD_micro);

            //frmResumenToEntregar frms = new frmResumenToEntregar(ExistenciaTM
            //                                                    , Pentregado
            //                                                    , 0//Psolicitado
            //                                                    , DT_Tarima
            //                                                    , idTarima
            //                                                    , factor);
            //if (frms.ShowDialog() == DialogResult.OK)
            bool Guardo = false;
            if (frmx.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("[sp_insert_tarima_micro_ing_out_tarima]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@numero_transaccion", row.numero_transaccion);
                    cmd.Parameters.AddWithValue("@id_materia_prima", row.id_mp);
                    cmd.Parameters.AddWithValue("@lotemp", row.lote);
                    cmd.Parameters.AddWithValue("@id_usuario", usuarioLogueado.Id);
                    cmd.Parameters.AddWithValue("@cantidad_unidades", frmx.UdEnviar);
                    cmd.Parameters.AddWithValue("@cantidadkg", frmx.KgEnviar);
                    

                    //cmd.Parameters.AddWithValue("@id_req", RequisicionActual.IdRequisicion);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Guardo = dr.GetInt32(0) == 1 ? true : false;
                    }
                    dr.Close();
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

            }
            else
            {
                txtTarima.Text = "";
                txtTarima.Focus();
            }
            if (Guardo)
            {
                //Mensaje de transaccion exitosa
                lblMensaje.Text = "Transacción Exitosa!";
                panelNotificacion.BackColor = Color.MediumSeaGreen;
                timerLimpiarMensaje.Enabled = true;
                timerLimpiarMensaje.Start();
                LoadDataMicros();
            }
        }

        private void cmdRecargar_Click(object sender, EventArgs e)
        {
            LoadDataMicros();
            LoadTarimas();
        }

        private void cmdImprimirHoja_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            

        }

        private void cmdPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControlTarimasMicros.FocusedView;
            var row = (dsMicro.tarimas_microRow)gridView.GetFocusedDataRow();

            rptReporteIngresoTarimaMicros report = new rptReporteIngresoTarimaMicros(row.id);// { DataSource = dsCompras1, DataMember = "oc_detalle", ShowPrintMarginsWarning = false };
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            report.ShowPrintMarginsWarning = false;
            ReportPrintTool printReport = new ReportPrintTool(report);

            printReport.Print();
        }

        private void LoadTarimas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_tarimas_resumen_micros_actives", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idbodega", idBodega);
                dsMicro1.tarimas_micro.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMicro1.tarimas_micro);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPageIndex == 2)
            {
                LoadTarimas();
            }
        }

        private void cmdVistaPrevia_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControlTarimasMicros.FocusedView;
            var row = (dsMicro.tarimas_microRow)gridView.GetFocusedDataRow();

            rptReporteIngresoTarimaMicros report = new rptReporteIngresoTarimaMicros(row.id);// { DataSource = dsCompras1, DataMember = "oc_detalle", ShowPrintMarginsWarning = false };
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            report.ShowPrintMarginsWarning = false;
            ReportPrintTool printReport = new ReportPrintTool(report);

            printReport.ShowPreview();
        }
    }
}