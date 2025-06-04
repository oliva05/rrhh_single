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
using ACS.Classes;
using System.Data.SqlClient;
using LOSA.RecepcionMP;
using LOSA.Clases;
using LOSA.Calidad.LoteConfConsumo;
using LOSA.TransaccionesMP.DataSet;
using DevExpress.Office.Utils;

namespace LOSA.TransaccionesMP
{
    public partial class frmAsjuteInventarioPorLoteWithAutorization : DevExpress.XtraEditors.XtraForm
    {
        private string ItemCode;//Codigo MP de SAP
        private decimal factorValue;
        private int Id_MP, Id_Lote_Alosy, Id_Presentacion;
        private int Numero_transaccion; // Numero de Ingresp
        private string cardcode; //Codigo de Proveedor
        UserLogin UsuarioLogueado;
        private decimal FactorUnidades;
        MateriaPrima MateriaPrimaActual;
        bool MostrarExterno;
        private decimal existencia_bodega_selected;
        private string bodega_selected;
        public frmAsjuteInventarioPorLoteWithAutorization(UserLogin pUserLogin)
        {
            InitializeComponent();
            DataOperations dp1 = new DataOperations();
            dtFechaDocumento.DateTime = dp1.Now();
            LoadMaestrosBodegas();
            UsuarioLogueado = pUserLogin;
            radioLoteExistente.Checked = true;
            LoadPresentaciones();
        }

        public frmAsjuteInventarioPorLoteWithAutorization(UserLogin pUserLogin, int pIdMP, int id_lote_alosy, string pLote, int pid_bodega)
        {
            InitializeComponent();
            DataOperations dp1 = new DataOperations();
            dtFechaDocumento.DateTime = dp1.Now();
            MateriaPrimaActual = new MateriaPrima();
            UsuarioLogueado = pUserLogin;
            radioLoteExistente.Checked = true;
            LoadPresentaciones();
           
            MateriaPrimaActual.RecuperarRegistroFromID_MP(pIdMP);
            txtMP_Name.Text = MateriaPrimaActual.NameComercial;
            MateriaPrimaActual.IdMP_ACS = Id_MP = pIdMP;
            
            ItemCode = MateriaPrimaActual.CodeMP_SAP;
            gridLookUpEditOrigen.EditValue = pid_bodega;

            txtNumLote.Text = pLote;

            LoadMaestrosBodegas();
            gridLookUpEdit1View.FocusedRowHandle = 0;
            gridLookUpEdit1View.SelectRow(0);
            //if (MateriaPrimaActual.RecuperarRegistroFromID_RM(pIdMP))
            //{
            //    Id_MP = pIdMP;
            //    txtMP_Name.Text = MateriaPrimaActual.NameComercial;
            //    radioLoteExistente.Checked = true;
            //    radioLoteNuevo.Checked = false;
            //    SearchLoteAuto(pIdMP, pLote);
            //    ItemCode = MateriaPrimaActual.CodeMP_SAP;
            //    LoadMaestrosBodegas();
            //    tsTipoTransaccion.IsOn = false;
            //    //toggleSwTipoOperacion.Enabled = false;
            //    txtNumLote.Text = pLote;
            //    gridLookUpEditOrigen.EditValue = pid_bodega;

            //    if (pid_bodega > 0)
            //    {
            //        foreach (dsRecepcionMP_AjusteLote.bodega_origenRow item in dsRecepcionMP_AjusteLote1.bodega_origen.Rows)
            //        {
            //            if (item.id == pid_bodega)
            //            {
            //                existencia_bodega_selected = item.existencia;
            //                bodega_selected = item.descripcion;
            //            }
            //        }
            //    }
            //}

        }


        public frmAsjuteInventarioPorLoteWithAutorization(UserLogin pUserLogin, int pIdMP, int id_lote_alosy, string pLote)
        {
            InitializeComponent();
            DataOperations dp1 = new DataOperations();
            dtFechaDocumento.DateTime = dp1.Now();
            //LoadMaestrosBodegas();
            MateriaPrimaActual = new MateriaPrima();
            UsuarioLogueado = pUserLogin;
            radioLoteExistente.Checked = true;
            LoadPresentaciones();
            if (MateriaPrimaActual.RecuperarRegistroFromID_RM(pIdMP))
            {
                Id_MP = pIdMP;
                txtMP_Name.Text = MateriaPrimaActual.NameComercial;
                radioLoteExistente.Checked = true;
                radioLoteNuevo.Checked = false;
                SearchLoteAuto(pIdMP, pLote);
                ItemCode = MateriaPrimaActual.CodeMP_SAP;
                LoadMaestrosBodegas();
            }
        }

        private void LoadMaestrosBodegas()
        {
           
            MostrarExterno = false; //Si es Ajuste Entrada y Salida o Traslado no debe mostrar las Bodegas Externas

            DataOperations dp = new DataOperations();
            SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
            con.Open();

            //SqlCommand cmd = new SqlCommand("sp_get_maestro_bodegas_ajuste_kardexV2", con);
            SqlCommand cmd = new SqlCommand("sp_get_maestro_bodegas_ajuste_kardexV2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MostrarExterno", MostrarExterno);
            if (MateriaPrimaActual != null)
            {
                if(MateriaPrimaActual.Recuperado)
                    cmd.Parameters.AddWithValue("@id_mp", MateriaPrimaActual.IdMP_ACS);
                else
                    cmd.Parameters.AddWithValue("@id_mp", 0);
            }
            else
            {
                cmd.Parameters.AddWithValue("@id_mp", 0);
            }
            dsRecepcionMP_AjusteLote1.bodega_origen.Clear();
            dsRecepcionMP_AjusteLote1.bodega_destino.Clear();
            SqlDataAdapter adat = new SqlDataAdapter(cmd);
            adat.Fill(dsRecepcionMP_AjusteLote1.bodega_origen);
            adat = new SqlDataAdapter(cmd);
            adat.Fill(dsRecepcionMP_AjusteLote1.bodega_destino);

            con.Close();


        }

        void SearchLoteAuto(int pidmp, string plote_)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_lotes_for_mp_from_lot_and_id_mp", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mp", pidmp);
                cmd.Parameters.AddWithValue("@plote", plote_);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id_Lote_Alosy = dr.GetInt32(2);
                    if (Id_Lote_Alosy > 0)
                    {
                        //txtLoteNuevo.Enabled = true;
                        //txtNumLote.Enabled= false;
                        MateriaPrima mat1 = new MateriaPrima();
                        if (mat1.RecuperarRegistroFromID_RM(pidmp))
                        {
                            ItemCode = mat1.CodeMP_SAP;//Codigo MP de SAP
                            MateriaPrimaActual = mat1;
                        }
                        txtLoteNuevo.Text = txtNumLote.Text = dr.GetString(0);
                        Numero_transaccion = dr.GetInt32(1); // Numero de Ingresp

                        factorValue = dr.GetDecimal(5);
                        Id_Presentacion = dr.GetInt32(6);
                        Id_MP = pidmp;
                        //cardcode; //Codigo de Proveedor
                    }
                    else
                    {
                        //txtLoteNuevo.Enabled = false;
                        //txtNumLote.Enabled = true;
                    }
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        private void LoadPresentaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_presentaciones_activas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsRecepcionMP_AjusteLote1.presentaciones.Clear();
                adat.Fill(dsRecepcionMP_AjusteLote1.presentaciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        SqlTransaction transaction;
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtMP_Name.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar la Materia Prima!");
                return;
            }


            if (Convert.ToDecimal(spinEditUnidades.Value) <= 0)
            {
                CajaDialogo.Error("No se puede registrar una cantidad de materia en cero (0)!");
                return;
            }

            if (!string.IsNullOrEmpty(dtFechaDocumento.Text))
            {
                if (dtFechaDocumento.DateTime.Year <= 2020)
                {
                    CajaDialogo.Error("Es necesario ingresar una fecha de documento valida!");
                    return;
                }
            }

            DataOperations dp = new DataOperations();

            //Vamos a obligar a poner la bodega de Origen
            if (dp.ValidateNumberInt32(gridLookUpEditOrigen.EditValue) <= 0)
            {
                CajaDialogo.Error("Es necesario seleccionar una bodega de correcta!");
                return;
            }

            
            //Vamos a obligar a poner la presentacion del producto
            if (dp.ValidateNumberInt32(gridLookUpEditPresentacion.EditValue) <= 0)
            {
                CajaDialogo.Error("Es necesario seleccionar una presentación correcta!");
                return;
            }

            //Validar que se escriba una justificacion para solicitar el ajuste de inventario en kardex'
            if (string.IsNullOrEmpty(txtJustificacion.Text))
            {
                CajaDialogo.Error("Es necesario escribir una justificación o comentario!");
                return;
            }

            if (txtJustificacion.Text.Length < 20)
            {
                CajaDialogo.Error("Es necesario escribir una justificación o comentario de al menos 20 caracteres!");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Esta seguro de hacer la solicitud de este ajuste de inventario?");
            if (r != DialogResult.Yes)
                return;


            if (tsTipoTransaccion.IsOn) //ENTRADA EN EL KARDEX GENERAL
            {
                if (radioLoteExistente.Checked)
                {
                    try
                    {
                        
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_ajuste_kardex_por_lote_v6", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@cant_entrada", txtPesoKG.Text);
                        cmd.Parameters.AddWithValue("@cant_entrada", spinEditPesoKg.EditValue);
                        cmd.Parameters.AddWithValue("@cant_salida", 0);
                        cmd.Parameters.AddWithValue("@ud_entrada", spinEditUnidades.EditValue);
                        cmd.Parameters.AddWithValue("@ud_salida", 0);
                        if(Id_Lote_Alosy == 0)
                            cmd.Parameters.AddWithValue("@id_referencia_operacion", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@id_referencia_operacion", Id_Lote_Alosy);
                        if (Id_Lote_Alosy == 0)
                            cmd.Parameters.AddWithValue("@id_lote_alosy", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@id_lote_alosy", Id_Lote_Alosy);
                        cmd.Parameters.AddWithValue("@lote", txtNumLote.Text);
                        cmd.Parameters.AddWithValue("@id_mp", Id_MP);
                        cmd.Parameters.AddWithValue("@itemcode", ItemCode);
                        //cmd.Parameters.AddWithValue("@id_bodega");
                        cmd.Parameters.AddWithValue("@id_usercreate", UsuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@fechaDocumento", dtFechaDocumento.DateTime);

                        //Solo se hacen ajustes, asi que l misma bodega de origen es la bodega de destino
                        cmd.Parameters.AddWithValue("@bodega_origen", gridLookUpEditOrigen.EditValue);
                        cmd.Parameters.AddWithValue("@bodega_destino", gridLookUpEditOrigen.EditValue);
                        

                        if(Convert.ToInt32(gridLookUpEditPresentacion.EditValue) == 0)
                            cmd.Parameters.AddWithValue("@id_presentacion", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);

                        cmd.Parameters.AddWithValue("@tipo_operacion", 1);//1=Ajuste,   0=Traslado
                        cmd.Parameters.AddWithValue("@justificacion", txtJustificacion.Text); 
                        cmd.Parameters.AddWithValue("@es_nuevo_lote", 0);
                        cmd.Parameters.AddWithValue("@cant_tarimas", txtCantidadTarimas.Value);
                        cmd.Parameters.AddWithValue("@cant_por_tarima", txtUnidadsPorTarima.Value);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        CajaDialogo.Information("Transaccion Exitosa!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                }
                if(radioLoteNuevo.Checked)
                {
                    //DataOperations dp = new DataOperations();
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                    int id_lote_h = 0;

                    conn.Open();
                    transaction = conn.BeginTransaction("SampleTransaction");

                    try
                    {
                        ////EN CASO DE SER UN LOTE NUEVO CREAMOS EL LOTE 

                        ////INSERT DE ENCABEZADO
                        //SqlCommand command = new SqlCommand("sp_insert_mp_lote_h_for_kardex", transaction.Connection);
                        //command.Transaction = transaction;
                        //command.CommandType = CommandType.StoredProcedure;
                        //command.Parameters.AddWithValue("@numero_transaccion", Numero_transaccion);
                        //command.Parameters.AddWithValue("@itemcode", ItemCode);
                        //command.Parameters.AddWithValue("@itemname", txtMP_Name.Text);
                        //command.Parameters.AddWithValue("@usuario_creado", UsuarioLogueado.Id);
                        //if (ItemCode == "MP00080" || ItemCode == "MP00081")//Reproceso Tilapia - Camaron
                        //{
                        //    command.Parameters.AddWithValue("@cardname", DBNull.Value);
                        //    command.Parameters.AddWithValue("@cardcode", DBNull.Value);
                        //}
                        //else
                        //{
                        //    command.Parameters.AddWithValue("@cardname", buttonProveedores.Text);
                        //    command.Parameters.AddWithValue("@cardcode", cardcode);
                        //}

                        //id_lote_h = Convert.ToInt32(command.ExecuteScalar());

                        ////INSERT DE DETALLE
                        //SqlCommand cmd2 = new SqlCommand("sp_insert_mp_lote_d_for_kardex_ajuste",transaction.Connection);
                        //cmd2.Transaction = transaction;
                        //cmd2.CommandType = CommandType.StoredProcedure;
                        //cmd2.Parameters.AddWithValue("@id_h", id_lote_h);
                        //cmd2.Parameters.AddWithValue("@numero_transaccion", Numero_transaccion);
                        //cmd2.Parameters.AddWithValue("@lote", txtLoteNuevo.Text);
                        //cmd2.Parameters.AddWithValue("@cantidadtotal", spinEditUnidades.EditValue);
                        //cmd2.Parameters.AddWithValue("@cantidadportarima", dp.ValidateNumberInt32(txtUnidadsPorTarima.Text));
                        //cmd2.Parameters.AddWithValue("@totaltarimas", dp.ValidateNumberInt32(txtCantidadTarimas));
                        //cmd2.Parameters.AddWithValue("@id_unidadmedida", gridLookUpEditPresentacion.EditValue);
                        //cmd2.Parameters.AddWithValue("@peso", spinEditPesoKg.EditValue);
                        //cmd2.Parameters.AddWithValue("@id_mp", Id_MP);
                        //cmd2.ExecuteNonQuery();


                        //REALIZAMOS EL INSERT DEL MOVIMIENTO EN KARDEX
                        SqlCommand cmd3 = new SqlCommand("sp_ajuste_kardex_por_lote_v6", transaction.Connection);
                        cmd3.Transaction = transaction;
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.AddWithValue("@cant_entrada", spinEditPesoKg.EditValue);
                        cmd3.Parameters.AddWithValue("@cant_salida", 0);
                        cmd3.Parameters.AddWithValue("@ud_entrada", spinEditUnidades.EditValue);
                        cmd3.Parameters.AddWithValue("@ud_salida", 0);
                        cmd3.Parameters.AddWithValue("@fechaDocumento", dtFechaDocumento.EditValue);

                        cmd3.Parameters.AddWithValue("@bodega_origen", gridLookUpEditOrigen.EditValue);

                        //Ponemos el mismo valor, esto es por que es un ajuste a una sola bodega, entrada o salida
                        cmd3.Parameters.AddWithValue("@bodega_destino", gridLookUpEditOrigen.EditValue);
                        
                        cmd3.Parameters.AddWithValue("@id_referencia_operacion", DBNull.Value);
                        cmd3.Parameters.AddWithValue("id_lote_alosy", DBNull.Value);
                        cmd3.Parameters.AddWithValue("@lote", txtLoteNuevo.Text);
                        cmd3.Parameters.AddWithValue("@id_mp", Id_MP);
                        cmd3.Parameters.AddWithValue("@itemcode", ItemCode);
                        cmd3.Parameters.AddWithValue("@id_usercreate", UsuarioLogueado.Id);
                        cmd3.Parameters.AddWithValue("@id_presentacion", gridLookUpEditPresentacion.EditValue);
                        cmd3.Parameters.AddWithValue("@tipo_operacion", 1);
                        cmd3.Parameters.AddWithValue("@justificacion", txtJustificacion.Text);
                        cmd3.Parameters.AddWithValue("@es_nuevo_lote", 1);
                        cmd3.Parameters.AddWithValue("@cant_tarimas", txtCantidadTarimas.Value);
                        cmd3.Parameters.AddWithValue("@cant_por_tarima", txtUnidadsPorTarima.Value);
                        cmd3.ExecuteNonQuery();
                        //Attempt to commit the transaction.

                        transaction.Commit();
                        conn.Close();

                        CajaDialogo.Information("Transaccion de Lote Exitosa!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                        transaction.Rollback();
                    }
                }
               
            }
            if (tsTipoTransaccion.IsOn == false) //SALIDA EN EL KARDEX GENERAL
            {
                if (existencia_bodega_selected <= 0)
                {
                    CajaDialogo.Error("No puede dar salida al item " + ItemCode + " por que es 0 en la Bodega: " + bodega_selected);
                    return;
                }
                if (radioLoteExistente.Checked)
                {
                    try
                    {
                        //DataOperations dp = new DataOperations();
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_ajuste_kardex_por_lote_v6", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@cant_entrada", 0);
                        cmd.Parameters.AddWithValue("@cant_salida", spinEditPesoKg.EditValue);

                        if(Id_Lote_Alosy == 0)
                            cmd.Parameters.AddWithValue("@id_referencia_operacion", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@id_referencia_operacion", Id_Lote_Alosy);

                        if (Id_Lote_Alosy == 0)
                            cmd.Parameters.AddWithValue("@id_lote_alosy", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@id_lote_alosy", Id_Lote_Alosy);

                        cmd.Parameters.AddWithValue("@lote", txtNumLote.Text);
                        cmd.Parameters.AddWithValue("@id_mp", Id_MP);
                        cmd.Parameters.AddWithValue("@itemcode", ItemCode);
                        cmd.Parameters.AddWithValue("@id_usercreate", UsuarioLogueado.Id);
                        cmd.Parameters.AddWithValue("@ud_entrada", 0);
                        cmd.Parameters.AddWithValue("@ud_salida", spinEditUnidades.EditValue);
                        cmd.Parameters.AddWithValue("@fechaDocumento", dtFechaDocumento.EditValue);
                        
                        cmd.Parameters.AddWithValue("@bodega_origen", gridLookUpEditOrigen.EditValue);
                        cmd.Parameters.AddWithValue("@bodega_destino", gridLookUpEditOrigen.EditValue);

                        cmd.Parameters.AddWithValue("id_presentacion", gridLookUpEditPresentacion.EditValue);

                        cmd.Parameters.AddWithValue("@tipo_operacion", 1);//1=Ajuste,   0=Traslado
                        cmd.Parameters.AddWithValue("@justificacion", txtJustificacion.Text);
                        cmd.Parameters.AddWithValue("@es_nuevo_lote", 0);
                        cmd.Parameters.AddWithValue("@cant_tarimas", txtCantidadTarimas.Value);
                        cmd.Parameters.AddWithValue("@cant_por_tarima", txtUnidadsPorTarima.Value);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        CajaDialogo.Information("Transaccion Exitosa!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                }
            }
            
            
        }

        private void txtMP_Name_Click(object sender, EventArgs e)
        {
            //frmMP frm = new frmMP();
            frmSearchMP frm = new frmSearchMP(frmSearchMP.TipoBusqueda.MateriaPrima);
            if (this.MdiParent != null)
            {
                //frm.MdiParent = this.MdiParent;
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtMP_Name.Text = frm.ItemSeleccionado.ItemName;
                ItemCode = frm.ItemSeleccionado.ItemCode;
                Id_MP = frm.ItemSeleccionado.id;
                if (MateriaPrimaActual == null)
                    MateriaPrimaActual = new MateriaPrima();
                if(MateriaPrimaActual.RecuperarRegistroFromID_RM(frm.ItemSeleccionado.id))
                    LoadMaestrosBodegas();
                MateriaPrima mp = new MateriaPrima();
                if (mp.Get_if_mp_is_granel(Id_MP))
                {
                    //Cancelamos los eventos de unidades para que no se dispare y no recalcule los Kg.
                    spinEditUnidades.EditValueChanged -= new EventHandler(spinEditUnidades_EditValueChanged);
                    spinEditUnidades.EditValue = 1;
                    spinEditUnidades.EditValueChanged += new EventHandler(spinEditUnidades_EditValueChanged);
                    //spinEditUnidades.Enabled = false;
                    //spinEditPesoKg.Enabled = true;
                }
                else
                {
                    //spinEditUnidades.Enabled = true;
                    //spinEditPesoKg.Enabled = false;
                }

                //txtCodigoProveedor.Text = frm.idProveedor;
                //txtProveedorName.Text = frm.NombreProveedor;
                //this.ItemCode = frm.ItemCode;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCantidadUnidades_Leave(object sender, EventArgs e)
        {
            //gridLookUpEditPresentacion.EditValue = Id_Presentacion;
            //if (gvLookUpEditPresentacion.RowCount <= 0)
            //{
            //    this.factorValue = 0;
            //}
            //else
            //{
            //    this.factorValue = Convert.ToDecimal(gvLookUpEditPresentacion.GetFocusedRowCellValue(gvLookUpEditPresentacion.Columns[2]).ToString());
            //}

            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(spinEditUnidades.EditValue);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            if (radioLoteNuevo.Checked)
            {
                spinEditPesoKg.EditValue = (factorValue * cantidad_).ToString();
            }
            else
                spinEditPesoKg.EditValue = (FactorUnidades * cantidad_).ToString();
        }

        private void radioLoteNuevo_CheckedChanged(object sender, EventArgs e)
        {
            txtLoteNuevo.Enabled = true;
            txtLoteNuevo.Visible = true;
            txtNumLote.Visible = false;
            buttonProveedores.Enabled = true;
            txtCantidadTarimas.Enabled = true;
            txtUnidadsPorTarima.Enabled = true;
            spinEditUnidades.EditValue = 0;
            spinEditPesoKg.EditValue = 0;
        }

        private void buttonProveedores_Click(object sender, EventArgs e)
        {
            frm_select_pv frm = new frm_select_pv();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cardcode = frm.Cardcode;
                buttonProveedores.Text = frm.pv;
                
            }
        }

        private void radioLoteExistente_CheckedChanged(object sender, EventArgs e)
        {
            txtLoteNuevo.Enabled = false;
            txtLoteNuevo.Visible = false;
            buttonProveedores.Enabled = false;
            txtCantidadTarimas.Enabled = false;
            txtUnidadsPorTarima.Enabled = false;
            txtNumLote.Visible = true;
            buttonProveedores.Text = "";
        }

        private void gridLookUpEditPresentacion_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (gvLookUpEditPresentacion.RowCount <= 0)
            {
                this.factorValue = 0;
            }
            else
            {
                this.factorValue = Convert.ToDecimal(gvLookUpEditPresentacion.GetFocusedRowCellValue(gvLookUpEditPresentacion.Columns[2]).ToString());
            }

            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(spinEditUnidades.EditValue);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            spinEditPesoKg.EditValue = (factorValue * cantidad_).ToString();
        }

        private void txtNumLote_Click(object sender, EventArgs e)
        {
            frmLotePorMP frm = new frmLotePorMP(Id_MP);
            if (this.MdiParent != null)
            {
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtNumLote.Text = frm.Lote;
                Id_Lote_Alosy = frm.Id_Lote;
                gridLookUpEditPresentacion.EditValue = frm.Id_UnidadMedida;
                Numero_transaccion = frm.Num_ingreso;
                FactorUnidades = frm.Factor;

                spinEditUnidades.Focus();
            }
        }

        private void tsTipoTransaccion_Toggled(object sender, EventArgs e)
        {
            if (tsTipoTransaccion.IsOn == true)
            {
                radioLoteNuevo.Checked = true;
                radioLoteNuevo.Visible = true;
                radioLoteExistente.Checked = true;


                ////Vamos a desbloquear el traslado si es Entrada
                //toggleSwTipoOperacion.IsOn = true;
                //toggleSwTipoOperacion.Enabled = false;
                if (Id_MP == 1110 || Id_MP == 1101)
                {
                    radioLoteNuevo.Visible = false;
                }

            }
            else
            {
                radioLoteNuevo.Checked = false;
                radioLoteNuevo.Visible = false;
                radioLoteExistente.Checked = true;
                

                ////Vamos a bloquear el traslado si es Salida
                //toggleSwTipoOperacion.IsOn = true;
                //toggleSwTipoOperacion.Enabled = false;
            }
        }

        private void txtCantidadUnidades_Enter(object sender, EventArgs e)
        {
            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(spinEditUnidades.EditValue);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            spinEditPesoKg.EditValue = (FactorUnidades * cantidad_).ToString();
        }

        private void txtPesoKG_Validated(object sender, EventArgs e)
        {
            //decimal valor = 0;
            //errorProvider1.Clear();
            //try
            //{
            //    valor = Convert.ToDecimal(txtPesoKG.EditValue);
            //}
            //catch 
            //{
            //    errorProvider1.SetError(txtPesoKG, "Debe ingresar un numero Valido!");
            //}
        }

        private void spinEditUnidades_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void spinEditUnidades_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                decimal cantidad_ = 0;
                try
                {
                    cantidad_ = Convert.ToDecimal(spinEditUnidades.EditValue);
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
                if (radioLoteNuevo.Checked)
                {
                    spinEditPesoKg.EditValue = (factorValue * cantidad_).ToString();
                }
                else
                    spinEditPesoKg.EditValue = (FactorUnidades * cantidad_).ToString();
            }
            
        }

        private void toggleSwTipoOperacion_Toggled(object sender, EventArgs e)
        {
            //if (toggleSwTipoOperacion.IsOn)//Ajuste
            //{
            //    gridLookUpEditDestino.Visible = lblBodegaDestino.Visible = false;
            //    lblBodegaOrigen.Text = "Bodega____________________";

            //    tsTipoTransaccion.Visible = lblTipo_transaccion.Visible = true;
            //    //tsTipoTransaccion.IsOn = tsTipoTransaccion.Enabled = false;
            //}
            //else//Traslado
            //{
            //    gridLookUpEditDestino.Visible = lblBodegaDestino.Visible = true;
            //    lblBodegaOrigen.Text = "Bodega Origen____________";

            //    tsTipoTransaccion.Visible = lblTipo_transaccion.Visible = false;
            //    tsTipoTransaccion.IsOn = true;
            //}
        }

        private void gridLookUpEdit1View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var SelectedBodega = gridLookUpEdit1View.GetDataRow(e.RowHandle);

            existencia_bodega_selected = Convert.ToDecimal(SelectedBodega["existencia"]);
            bodega_selected = Convert.ToString(SelectedBodega["descripcion"]);
        }

        private void txtNumLote_Enter(object sender, EventArgs e)
        {
            frmLotePorMP frm = new frmLotePorMP(Id_MP);
            if (this.MdiParent != null)
            {
                frm.FormBorderStyle = FormBorderStyle.Sizable;
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtNumLote.Text = frm.Lote;
                Id_Lote_Alosy = frm.Id_Lote;
                gridLookUpEditPresentacion.EditValue = frm.Id_UnidadMedida;
                Numero_transaccion = frm.Num_ingreso;
               // gridLookUpEditPresentacion.EditValue = Id_Presentacion;
                FactorUnidades = frm.Factor;
                gridLookUpEditPresentacion.Enabled = false;
                spinEditUnidades.Focus();
            }
        }

        private void gridLookUpEditPresentacion_EditValueChanged(object sender, EventArgs e)
        {


            if (gvLookUpEditPresentacion.RowCount <= 0)
            {
                this.factorValue = 0;
            }
            else
            {
                this.factorValue = Convert.ToDecimal(gvLookUpEditPresentacion.GetFocusedRowCellValue(gvLookUpEditPresentacion.Columns[2]).ToString());
            }

            decimal cantidad_ = 0;
            try
            {
                cantidad_ = Convert.ToDecimal(spinEditUnidades.EditValue);
            }
            catch {}

            spinEditPesoKg.EditValue = (factorValue * cantidad_).ToString();

            int idSeleccionado = Convert.ToInt32(gridLookUpEditOrigen.EditValue);

            DataTable dt = dsRecepcionMP_AjusteLote1.bodega_origen;

            DataRow[] filaEncontrada = dt.Select("id = " + idSeleccionado);

            if (filaEncontrada.Length > 0)
            {
                bodega_selected = filaEncontrada[0]["descripcion"].ToString();
                existencia_bodega_selected = (decimal)filaEncontrada[0]["existencia"];

                //existencia_bodega_selected = Convert.ToDecimal(SelectedBodega["existencia"]);
                //bodega_selected = Convert.ToString(SelectedBodega["descripcion"]);
            }
        }
    }
}