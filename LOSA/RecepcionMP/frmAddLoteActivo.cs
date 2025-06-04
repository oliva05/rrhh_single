﻿using ACS.Classes;
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
    public partial class frmAddLoteActivo : Form
    {
        UserLogin UsuarioLogeado;
        public frmAddLoteActivo(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            LoadMP();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLote.Text))
            {
                CajaDialogo.Error("No se puede grabar un lote en blanco!");
                return;
            }

            if (gridLookUpEdit1.EditValue == null)
            {
                CajaDialogo.Error("Debe Elejir la Materia Prima a la que pertenece el Lote!");
                return;
            }

            if (dtFechaProd.Value == null)
            {
                CajaDialogo.Error("Debe ingresar la fecha de Producción!");
                return;
            }

            if (dtFechaVence.Value == null)
            {
                CajaDialogo.Error("Debe ingresar la fecha de Vencimiento!");
                return;
            }

            if (dtFechaProd.Value >= dtFechaVence.Value)
            {
                CajaDialogo.Error("La fecha de vencimiento no puede ser menor o igual a la fecha de Producción!");
                return;
            }

           

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringBascula);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_insert_new_lote_activo_granel_v2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lote", txtLote.Text);
                cmd.Parameters.AddWithValue("@id_user_create", UsuarioLogeado.Id);
                cmd.Parameters.AddWithValue("@itemcode", gridLookUpEdit1.EditValue);
                cmd.Parameters.AddWithValue("@fechap", dtFechaProd.Value);
                cmd.Parameters.AddWithValue("@fechav", dtFechaVence.Value);
                
                cmd.ExecuteNonQuery();

                con.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public void LoadMP()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_load_mp_bascula", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@lote", txtLote.Text);
                //cmd.Parameters.AddWithValue("@id_user_create", UsuarioLogeado.Id);
                dsRecepcionMPx1.mp.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsRecepcionMPx1.mp);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
