using ACS.Classes;
using DevExpress.Charts.Native;
using DevExpress.RichEdit.Export;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Commands.Internal;
using LOSA.Calidad.LoteConfConsumo;
using LOSA.Clases;
using LOSA.Clases.Colaborador;
using LOSA.RecepcionMP;
using LOSA.RRHH_Planilla.Capacitacion.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.Depreciacion
{
    public partial class frmDepreciacionCRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoOperacion
        { 
            Nuevo = 1,
            Editar = 2
        }

        TipoOperacion operacion;
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        int IdHeader, IdEstado;

        public frmDepreciacionCRUD(UserLogin pUserLog, frmDepreciacionCRUD.TipoOperacion ptipoOperacion, int pId_h)
        {
            InitializeComponent();
            operacion = ptipoOperacion;
            UsuarioLogeado = pUserLog;
            IdHeader = pId_h;
            dtFechaInicio.EditValue = dp.Now();
            loadTipoDeducciones();
            grdDeduccion.EditValue = 1;//Ninguna
            LoadData();
            grdMoneda.EditValue = 2;
            switch (operacion)
            {
                case TipoOperacion.Nuevo:
                    btnCancelar.Visible = false;
                    txtTasaInteresAnual.Enabled = true;
                    txtTasaInteresAnual.Enabled = true;
                    txtTasaCambioFija.Enabled = true;
                    break;
                case TipoOperacion.Editar:
                    cmdBuscarEmpleado.Visible = false;
                    txtImporteTotal.Enabled = false;
                    dtFechaInicio.Enabled = false;
                    txtKM.Enabled = true;
                    btnCargar.Visible = false;
                    txtTasaInteresAnual.Enabled = false;
                    txtTasaCambioFija.Enabled = false;
                    Depreciacion dep = new Depreciacion();
                    if(dep.RecuperarPrestamo(IdHeader))
                    {
                        HrEmployee emp = new HrEmployee();
                        emp.RecuperarDatosPorId(dep.Id_Empledo);
                        txtCodeEmpleado.Text = emp.Barcode;
                        txtEmpleado.Text = emp.Name;
                        txtImporteTotal.EditValue = dep.ImportaTotal;
                        dtFechaInicio.EditValue = dep.FechaInicio;
                        txtKM.EditValue = dep.KmDistancia;
                        IdEstado = dep.IdEstado;
                        grdDeduccion.EditValue = dep.TipoDeduccion;
                        txtMontoDeduccion.EditValue = dep.MontoDeduccion;
                        grdMoneda.EditValue = dep.Moneda;
                        if (dep.Moneda == 44) //Lempiras
                        {
                            lblTasaCambioFija.Visible = true;
                            txtTasaCambioFija.Visible = true;
                        }
                        else
                        {
                            lblTasaCambioFija.Visible = false;
                            txtTasaCambioFija.Visible = false;
                        }
                        txtTasaCambioFija.EditValue = dep.Tasa_cambio_fija;
                        txtTasaInteresAnual.EditValue = (dep.TasaInteresAnual * 100);
                        LoadDetallePrestamo(IdHeader);

                        grdMoneda.Enabled = false;
                        switch (IdEstado)
                        {
                            case 1://En Proceso
                                btnSave.Enabled = true;                              
                                break;

                            case 2://Completado
                                btnSave.Enabled = true;
                                btnCancelar.Visible = false;
                                break;


                            case 3://Cancelado
                                btnSave.Enabled = false;
                                txtImporteTotal.Enabled = false;
                                grdDeduccion.Enabled = false;
                                txtMontoDeduccion.Enabled = false;
                                btnCancelar.Visible = false;
                                break;

                            default:
                                break;
                        }
                    }
                   
                    

                    break;
                default:
                    break;
            }
        }

        private void loadTipoDeducciones()
        {
            string sql = @"sp_depreciacion_get_tipo_deducciones";
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsDepreciacion1.tipo_deduccion.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsDepreciacion1.tipo_deduccion);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadDetallePrestamo(int idHeader)
        {
            string sql = @"sp_depreciacion_get_detalle_saldo_prestamo";
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn); 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idH", idHeader);
                dsDepreciacion1.detalle_prestamos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsDepreciacion1.detalle_prestamos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdBuscarEmpleado_Click(object sender, EventArgs e)
        {
            frmSearchEmployee frm = new frmSearchEmployee(frmSearchEmployee.TipoBusqueda.PrestamoDepreciacion, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCodeEmpleado.Text = frm.ItemSeleccionado.ItemCode;
                txtEmpleado.Text = frm.ItemSeleccionado.ItemName;

                Empleado emp = new Empleado();
                emp.RecuperarIdFromCode(txtCodeEmpleado.Text.ToString());
                Depreciacion dep = new Depreciacion();
                dep.RecuperarPerfil(0,emp.Id);
                if (dep.Km > 0)
                    txtKM.EditValue = dep.Km;
                else
                    txtKM.EditValue = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grdMoneda.Text))
            {
                CajaDialogo.Error("Debe seleccionar la Moneda del Prestamo!");
                return;
            }
            else
            {
                if (Convert.ToInt32(grdMoneda.EditValue) == 44)//Lempiras
                {
                    if (Convert.ToDecimal(txtTasaCambioFija.EditValue) <= 0)
                    {
                        CajaDialogo.Error("Debe indicar una Tasa de Cambio Fijada para el Contrato!");
                        return;
                    }
                }
            }

            if (string.IsNullOrEmpty(txtEmpleado.Text))
            {
                CajaDialogo.Error("Debe seleccionar un empleado!");
                return;
            }

            if (Convert.ToDecimal(txtImporteTotal.EditValue) <= 0)
            {
                CajaDialogo.Error("Debe agregar un Monto mayor a 0!");
                return;
            }

            if (string.IsNullOrEmpty(txtKM.Text))
            {
                CajaDialogo.Error("La Distancia debe ser mayor que 0!");
                return;
            }

            if(Convert.ToDecimal(grdDeduccion.EditValue) != 1)
            {
                if (Convert.ToDecimal(txtMontoDeduccion.EditValue) <= 0)
                {
                    CajaDialogo.Error("Debe Agregar el Monto a Deducir!");
                    txtMontoDeduccion.Focus();
                    return;
                }
            }

            bool Guardar = false;
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);

            switch (operacion)
            {
                case TipoOperacion.Nuevo:


                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "sp_depreciacion_insert_prestamo_h";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@empleado_code",txtCodeEmpleado.Text.Trim());
                        cmd.Parameters.AddWithValue("@importe_total", txtImporteTotal.EditValue);
                        cmd.Parameters.AddWithValue("@fecha_inicio", dtFechaInicio.DateTime);
                        cmd.Parameters.AddWithValue("@creacion_fecha", dp.Now());
                        cmd.Parameters.AddWithValue("@creacion_user_id",UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@km", txtKM.EditValue);
                        cmd.Parameters.AddWithValue("@mantenimiento", DBNull.Value);
                        cmd.Parameters.AddWithValue("@deduccion", grdDeduccion.EditValue);
                        if (Convert.ToDecimal(grdDeduccion.EditValue) != 1)
                            cmd.Parameters.AddWithValue("@monto_deduccion", txtMontoDeduccion.EditValue);
                        else
                            cmd.Parameters.AddWithValue("@monto_deduccion", 0);
                        cmd.Parameters.AddWithValue("@id_moneda", grdMoneda.EditValue);
                        cmd.Parameters.AddWithValue("@tasa_interes_anual", ConvertirPorcentaje(Convert.ToDecimal(txtTasaInteresAnual.EditValue)));
                        cmd.Parameters.AddWithValue("@tasa_cambio_fija", dp.ValidateNumberDecimal(txtTasaCambioFija.EditValue));
                        int id_header_ = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsDepreciacion.detalle_prestamosRow row in dsDepreciacion1.detalle_prestamos.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_depreciacion_insert_prestamo_d";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_h", id_header_);
                            cmd.Parameters.AddWithValue("@num_pago",row.num_pago);
                            cmd.Parameters.AddWithValue("@pago_fecha",row.fecha_pago);
                            cmd.Parameters.AddWithValue("@inicia_saldo",row.saldo_inicial);
                            cmd.Parameters.AddWithValue("@pago_programado",row.pago_programado); 
                            cmd.Parameters.AddWithValue("@pago_adicional",row.pago_adicional);
                            cmd.Parameters.AddWithValue("@total_pago",row.pago_total);
                            cmd.Parameters.AddWithValue("@director",row.director);
                            cmd.Parameters.AddWithValue("@interes",row.interes);
                            cmd.Parameters.AddWithValue("@fin_saldo",row.saldo_final);
                            cmd.Parameters.AddWithValue("@acumulado_interes",row.acumulado_interes);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        Guardar = true;

                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }

                    break;
                case TipoOperacion.Editar:

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "[sp_depreciacion_update_prestamo_h]";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idHeader", IdHeader);
                        cmd.Parameters.AddWithValue("@importe_total", txtImporteTotal.EditValue);
                        cmd.Parameters.AddWithValue("@fecha_inicio", dtFechaInicio.DateTime);
                        cmd.Parameters.AddWithValue("@modi_fecha", dp.Now());
                        cmd.Parameters.AddWithValue("@modi_user_id", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@km", txtKM.EditValue);
                        cmd.Parameters.AddWithValue("@mantenimiento", DBNull.Value);
                        cmd.Parameters.AddWithValue("@deduccion", grdDeduccion.EditValue);
                        if (Convert.ToDecimal(grdDeduccion.EditValue) != 1)
                            cmd.Parameters.AddWithValue("@monto_deduccion", txtMontoDeduccion.EditValue);
                        else
                            cmd.Parameters.AddWithValue("@monto_deduccion", 0);

                        cmd.ExecuteNonQuery();
                        //foreach (dsDepreciacion.detalle_prestamosRow row in dsDepreciacion1.detalle_prestamos.Rows)
                        //{
                        //    cmd.Parameters.Clear();
                        //    cmd.CommandText = "sp_depreciacion_insert_prestamo_d";
                        //    cmd.Connection = conn;
                        //    cmd.Transaction = transaction;
                        //    cmd.CommandType = CommandType.StoredProcedure;
                        //    cmd.Parameters.AddWithValue("@id_h", id_header_);
                        //    cmd.Parameters.AddWithValue("@num_pago", row.num_pago);
                        //    cmd.Parameters.AddWithValue("@pago_fecha", row.fecha_pago);
                        //    cmd.Parameters.AddWithValue("@inicia_saldo", row.saldo_inicial);
                        //    cmd.Parameters.AddWithValue("@pago_programado", row.pago_programado);
                        //    cmd.Parameters.AddWithValue("@pago_adicional", row.pago_adicional);
                        //    cmd.Parameters.AddWithValue("@total_pago", row.pago_total);
                        //    cmd.Parameters.AddWithValue("@director", row.director);
                        //    cmd.Parameters.AddWithValue("@interes", row.interes);
                        //    cmd.Parameters.AddWithValue("@fin_saldo", row.saldo_final);
                        //    cmd.Parameters.AddWithValue("@acumulado_interes", row.acumulado_interes);
                        //    //cmd.Parameters.AddWithValue("",)
                        //    cmd.ExecuteNonQuery();
                        //}

                        transaction.Commit();
                        Guardar = true;

                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }


                    break;
                default:
                    break;

            }
            if (Guardar)
            {
                CajaDialogo.Information("Configuracion Actualizada!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_depreciacion_obtener_pago_programado", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ImportePrestamo", dp.ValidateNumberDecimal(txtImporteTotal.EditValue));
                cmd.Parameters.AddWithValue("@TasaInteres", ConvertirPorcentaje(Convert.ToDecimal(txtTasaInteresAnual.EditValue)));
                cmd.Parameters.AddWithValue("@PagoPorAnio", dp.ValidateNumberDecimal(txtPagosPorAnio.EditValue));//12 meses
                cmd.Parameters.AddWithValue("@NumPagosTotal", dp.ValidateNumberDecimal(txtNumeroDePagos.EditValue));
                //cmd.Parameters.AddWithValue("",);
                //cmd.Parameters.AddWithValue("",);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtPagoProgramado.EditValue = dr.GetDecimal(0);
                    dr.Close();
                }

                SqlCommand cmd2 = new SqlCommand("[sp_depreciacion_obtener_detalle_prestamo]", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@ImportePrestamo", dp.ValidateNumberDecimal(txtImporteTotal.EditValue));
                cmd2.Parameters.AddWithValue("@TasaInteres", ConvertirPorcentaje(Convert.ToDecimal(txtTasaInteresAnual.EditValue)));
                cmd2.Parameters.AddWithValue("@NumPagosTotal", dp.ValidateNumberDecimal(txtNumeroDePagos.EditValue));
                cmd2.Parameters.AddWithValue("@PagosPorAnio", dp.ValidateNumberDecimal(txtPagosPorAnio.EditValue));//12 meses
                cmd2.Parameters.AddWithValue("@PagoProgramado", dp.ValidateNumberDecimal(txtPagoProgramado.EditValue));
                cmd2.Parameters.AddWithValue("@PagoAdicional", dp.ValidateNumberDecimal(txtPagoAdicionalO.EditValue));
                cmd2.Parameters.AddWithValue("@FechaInicio", dtFechaInicio.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd2);
                dsDepreciacion1.detalle_prestamos.Clear();
                adat.Fill(dsDepreciacion1.detalle_prestamos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private decimal ConvertirPorcentaje(decimal pporcentaje)
        {
            decimal valorDecimal = pporcentaje / 100;

            return valorDecimal;
        }



        private void txtImporteTotal_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtImporteTotal.EditValue) > 0)
            {
                btnCargar_Click(sender,e);
            }
        }

        private void dtFechaInicio_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (Convert.ToDecimal(txtImporteTotal.EditValue) > 0)
            {
                btnCargar_Click(sender, e);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmpleado_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodeEmpleado_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void grdDeduccion_EditValueChanged(object sender, EventArgs e)
        {
            int TipoDeduccion = Convert.ToInt32(grdDeduccion.EditValue);

            if (TipoDeduccion == 1)//Ninguno
            {

                txtMontoDeduccion.Enabled = false;
                txtMontoDeduccion.EditValue = 0.00;
            }
            else
            {
                txtMontoDeduccion.Enabled = true;
            }
        }

        private void LoadData()
        {
            try
            {
                string query = @"[sp_depreciacion_get_moneda]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsDepreciacion1.moneda.Clear();
                adat.Fill(dsDepreciacion1.moneda);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void txtMontoDeduccion_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void grdMoneda_EditValueChanged(object sender, EventArgs e)
        {

            int IdMoneda = Convert.ToInt32(grdMoneda.EditValue);

            switch (IdMoneda)
            {
                case 2: //Dolares
                    lblTasaCambioFija.Visible = false;
                    txtTasaCambioFija.Visible = false;
                    txtTasaCambioFija.EditValue = 0;
                    break;

                case 44: //Lempiras
                    lblTasaCambioFija.Visible = true;
                    txtTasaCambioFija.Visible = true;
                    txtTasaCambioFija.EditValue = 0;
                    break;

                default:
                    break;
            }
        }

        private void txtTasaInteresAnual_TextChanged(object sender, EventArgs e)
        {
            btnCargar_Click(sender, e); 
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {


            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
            switch (idNivel)
            {
                case 1://Basic View
                case 2://Basic No Autorization
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    var gridview = (GridView)grdDetallePrestamo.FocusedView;
                    var row = (dsDepreciacion.detalle_prestamosRow)gridview.GetFocusedDataRow();
                    
                    if (e.Column.Name == "colpagado")
                    {
                        try
                        {
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("sp_admin_marcar_pagado_contrato", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id",row.id);
                            cmd.Parameters.AddWithValue("@pagado",Convert.ToBoolean(e.Value));
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        catch (Exception EX)
                        {
                            CajaDialogo.Error(EX.Message);
                        }


                    }

                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bool Proceder = false;
            string mensaje = "";
            switch (IdEstado)
            {
                case 1://En Proceso
                    Proceder = true;    
                    break;
                case 2: //Completado
                    Proceder = false;
                    mensaje = "No se puede Cancelar un prestamo Completado";
                    
                    break;
                case 3: //Cancelado
                    Proceder = false;

                    mensaje = "Prestamo Cancelado";
                    break;
                default:
                    Proceder = false;
                    break;
            }



            if (Proceder)
            {
                DialogResult r = CajaDialogo.Pregunta("Desea Cancelar este Prestamo?");
                if (r != System.Windows.Forms.DialogResult.Yes)
                    return;

                try
                {
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_depreciacion_cancelar_prestamo", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdHeader", IdHeader);
                    cmd.ExecuteNonQuery();

                    CajaDialogo.Information("Prestamo Cancelado con Exito!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            else
            {
                CajaDialogo.Error(mensaje);
                return;
            }
        }
    }
}