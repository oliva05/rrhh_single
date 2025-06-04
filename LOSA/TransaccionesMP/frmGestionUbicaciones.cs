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
using LOSA.Clases;
using LOSA.RecepcionMP;
using LOSA.Mantenimientos.Modelos;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.TransaccionesMP
{
    public partial class frmGestionUbicaciones : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        int idUbicacionNueva;
        int TypeOf;
        //public enum VentanaTarima
        //{
        //    asignarUbicacion = 1,
        //    cambiarUbicacion = 2,
        //    CambiarUbicacionPT = 5
        //};
        public frmGestionUbicaciones(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            TypeOf = 1;
        }


        public frmGestionUbicaciones(UserLogin pUser, int PtypeOf)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            TypeOf = PtypeOf;
            if (TypeOf == 1)
            {
                labelControl6.Text = "No. de Ingreso";
            }
            else
            {

                labelControl6.Text = "No. de Lote";
            }
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            if (TypeOf == 1)
            {
                LoadTarimas();
            }
            else
            {
                LoadTarimas_Pt();
            }
        }

        private void LoadTarimas_Pt()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_tarimas_from_ingreso_pt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", txtNumIngreso.Text);
                dsTransaccionesMP1.detalle_tarimas_ingreso.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP1.detalle_tarimas_ingreso);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
        private void LoadTarimas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_detalle_tarimas_from_ingreso", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_numero_ingreso", txtNumIngreso.Text);
                dsTransaccionesMP1.detalle_tarimas_ingreso.Clear(); 
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsTransaccionesMP1.detalle_tarimas_ingreso);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void txtNumIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (TypeOf == 1)
                {
                    LoadTarimas();
                }
                else
                {
                    LoadTarimas_Pt();
                }
            }
        }

        private void txtNumIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            frmUbicacionTarima2 frm = new frmUbicacionTarima2();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                idUbicacionNueva = frm.idUbicacion;
                gcNuevaUbicación.DataSource = CreateDataNuevaUbicacion(frm.idUbicacion, "");
                //gvNuevaUbicacion.InitNewRow += GvNuevaUbicacion_InitNewRow;
                gvNuevaUbicacion.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            }
        }


        private DataTable CreateDataNuevaUbicacion(int pIdUbicacion, string pCodigoBarra)
        {
            DataTable dt = new DataTable();
            Ubicaciones infoUbicaciones = new Ubicaciones();

            dt.Columns.Add("Detalle", typeof(string));
            dt.Columns.Add("Valor", typeof(string));

            if (infoUbicaciones.RecuperarRegistro_v2(pIdUbicacion, pCodigoBarra))
            {
                idUbicacionNueva = infoUbicaciones.Id;
                
                Bodega bod1 = new Bodega();
                Ubicaciones ub1 = new Ubicaciones();
                if (ub1.RecuperarRegistro_v2(idUbicacionNueva, ""))
                {
                    if (bod1.RecuperarRegistro(ub1.IdBodega))
                    {
                        dt.Rows.Add("BODEGA", bod1.Descripcion);
                    }
                }
                dt.Rows.Add("RACK", infoUbicaciones.Rack);
            }

            return dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Está seguro que desea guardar este ingreso en la nueva ubicacion?");
            if (r != DialogResult.Yes)
                return;
            bool guardo = false;
            try
            {
                foreach (dsTransaccionesMP.detalle_tarimas_ingresoRow row in dsTransaccionesMP1.detalle_tarimas_ingreso.Rows)
                {
                    if (row.seleccionar)
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                        con.Open();

                        SqlCommand cmd = new SqlCommand("sp_set_cambio_ubicacion_mp_from_ingreso", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_usuario", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@id_ubactual", row.id_ubicacion);
                        cmd.Parameters.AddWithValue("@id_ubnew", idUbicacionNueva);
                        cmd.Parameters.AddWithValue("@id_tarima", row.id);
                        cmd.ExecuteScalar();
                        guardo = true;
                        con.Close();
                    }
                }
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            if (guardo)
            {
                CajaDialogo.Information("Transacción Exitosa!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "colseleccionar")
            {
                try
                {
                    var gridView = (GridView)grDetalle.FocusedView;
                    var row = (dsTransaccionesMP.detalle_tarimas_ingresoRow)gridView.GetFocusedDataRow();
                    row.seleccionar = Convert.ToBoolean(e.Value);
                }
                catch (Exception ex)
                {
                          
                }
            }
            if (e.Column.Name == "collote_seleccionar")
            {
                var gridView = (GridView)grDetalle.FocusedView;
                var row = (dsTransaccionesMP.detalle_tarimas_ingresoRow)gridView.GetFocusedDataRow();
                foreach (dsTransaccionesMP.detalle_tarimas_ingresoRow row2 in dsTransaccionesMP1.detalle_tarimas_ingreso.Rows)
                {
                  
                    if (row.lote == row2.lote)
                    {
                          row2.seleccionar = Convert.ToBoolean(e.Value);
                        row2.lote_seleccionar = Convert.ToBoolean(e.Value);
                    }
                    
                }
            }
            

            }
        }
    }
