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
using ACS.Classes;
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Despachos
{
    public partial class frmplandespacho : DevExpress.XtraEditors.XtraForm
    {
        int ParId; //Este id nos hace la operacion de crear el plan de la orden de venta.
        int IdOfPlan = 0; // Id DEl plan creadi
        DataOperations dp = new DataOperations();
        UserLogin ParUser;
        public frmplandespacho(int IdOrdendeVenta, UserLogin UsuarioLogeado, string CardCode, string CardName, int DocNum)
        {
            InitializeComponent();
            ParId = IdOrdendeVenta;
            ParUser = UsuarioLogeado;
            if (ParUser.GrupoUsuario.GrupoUsuarioActivo == GrupoUser.GrupoUsuario.Administradores)
                txtNameForIT_Support.Visible = txtNameForIT_Support.ReadOnly = true;
            else
                txtNameForIT_Support.Visible = txtNameForIT_Support.ReadOnly = false;


            exe_sp_get_plan();
            txtcliente.Text = "(" + CardCode + ") - " + CardName;
            txtdocnum.Text = DocNum.ToString();
           
        }
        public void exe_sp_get_plan()// Crea el plan, o si ya esta creado para esta orden de venta lo trae de vuelta.
        {
            string query = @"EXECUTE [dbo].[sp_cargar_detalle_orden_de_venta] 
                               @DocEntry = @DocEntryy";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@DocEntryy", SqlDbType.Int).Value = ParId;   
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds_despachos.plan_despacho.Clear();
                da.Fill(ds_despachos.plan_despacho);
                cn.Close();
                recorrido_get_id();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void recorrido_get_id()
        {
            string valor = "";
            foreach (DataRow row in ds_despachos.plan_despacho.Rows)
            {
                IdOfPlan = Convert.ToInt32(row["id"].ToString());
                valor = row["date_plafinificada"].ToString();
                if (valor != "")
                {
                    dtfechaplan.EditValue = Convert.ToDateTime(row["date_plafinificada"].ToString());
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Si se da para atras se cancela el plan y se deshabilita.
            if (MessageBox.Show("Seguro que decias cancelar este plan?", "Pregunta",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                string query = @"EXECUTE [dbo].[orden_venta_sp_cambio_estado_plan_only]
	                            @Parid = @id
	                            ,@estado = @Pestado";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                try
                {
                    cn.Open();
                    SqlCommand Command = new SqlCommand(query, cn);
                    Command.Parameters.Add("@id", SqlDbType.Int).Value = IdOfPlan;
                    Command.Parameters.Add("@Pestado", SqlDbType.Bit).Value = 0;
                    Command.ExecuteNonQuery();
                    cn.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }

                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE [dbo].[LOSA_orden_venta_programacion_header]
                               SET [date_plafinificada] = @Date
                             WHERE id = @idplan";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = dtfechaplan.DateTime;
                cmd.Parameters.Add("@idplan", SqlDbType.Int).Value = IdOfPlan;
                cmd.ExecuteNonQuery();
                cn.Close();
                CajaDialogo.Information("Guardado con exito!");

            }
            catch (Exception ex )
            {
                CajaDialogo.Error(ex.Message);
            }
        }

       

        private void btnlotess_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_detalle.FocusedView;
                var row = (ds_despachos.plan_despachoRow)gridview.GetFocusedDataRow();
                LOSA.Despachos.frm_generar_despacho frm = new frm_generar_despacho(row.DocNum, row.iddetalle, ParUser);
                //if (frm.ShowDialog() == DialogResult.OK)
                //{

                //   // exe_sp_get_plan();
                //}
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            try
            {
                var gridview = (GridView)grd_detalle.FocusedView;
                var row = (ds_despachos.plan_despachoRow)gridview.GetFocusedDataRow();
                if (row.Enviado == 0)
                {
                    CajaDialogo.Error("No se ha creado ningun despacho relacionado a esa solicitud de venta.");
                    return;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}