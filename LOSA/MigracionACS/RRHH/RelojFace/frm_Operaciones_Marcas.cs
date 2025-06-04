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
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Presupuesto;
using LOSA.Clases.Colaborador;

namespace LOSA.MigracionACS.RRHH.RelojFace
{
    public partial class frm_Operaciones_Marcas : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        string codigo;
        int idMarcaEntrada;
        int idMarcaSalida;
        HrEmployee EmpleadoActual;

        enum Tipo_op
        {
              Editar = 0,
              Nuevo = 1
        }
         Tipo_op OP;
        int serie;
        public frm_Operaciones_Marcas(string Pcodigo)
        {
            InitializeComponent();
            OP = Tipo_op.Nuevo;
            codigo = Pcodigo;
            load_administracion();
            load_turnos();
            //EmpleadoActual = new HrEmployee();
            //if (EmpleadoActual.RecuperarDatosPorCodigo(Pcodigo))
            //{
                grd_empleados.EditValue = Pcodigo;
                //grd_empleados.Text = EmpleadoActual.Name;
            //}
            
            
            tgg_activo.Visible = false;
            txtestado.Visible = false;
        }
        public void load_administracion()
        {
            string query = @"sp_load_empleados_administracion";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsFaceReloj.Empleados.Clear();
                da.Fill(dsFaceReloj.Empleados);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_turnos()
        {
            string query = @"sp_load_empleados_turnos";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsFaceReloj.Empleados);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public frm_Operaciones_Marcas(int id, string Pcodigo)
        {
            InitializeComponent();
            OP = Tipo_op.Editar;
            codigo = Pcodigo;
            serie = id;
            load_administracion();
            load_turnos();
            grd_empleados.EditValue = codigo;
            load_data();
        }
        public void load_data() 
        {
            try
            {
                string query = @"sp_load_info_horas_trabajadas";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serie", serie);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dt_desde.EditValue = dr.GetDateTime(0);
                    dt_hasta.EditValue = dr.GetDateTime(1);
                    txttrabajadas.Text = dr.GetDecimal(2).ToString();
                    txtextras.Text = dr.GetDecimal(3).ToString();
                }

                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public bool Validar_fecha_entrante() 
        {
            bool Desicion;
            Desicion = false;
            int respuesta = 0;
            string query = @"";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
         
            try
            {
                cn.Open();
                SqlCommand cmd;
                SqlDataReader dr;

                switch (OP)
                {
                    case Tipo_op.Editar:

                        query = @"sp_validar_fecha_horas_empleado_trabajadas_editar";
                        cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@fecha", dt_desde.EditValue);
                        cmd.Parameters.AddWithValue("@serie",serie);

                        break;
                    case Tipo_op.Nuevo:
                        query = @"sp_validar_fecha_horas_empleado_trabajadas";
                        cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@fecha", dt_desde.EditValue);
                        cmd.Parameters.AddWithValue("@idemp", codigo);

                        break;
                    default:
                        query = @"sp_validar_fecha_horas_empleado_trabajadas";
                        cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@fecha", dt_desde.EditValue);
                        cmd.Parameters.AddWithValue("@idemp", codigo);
                        break;
                }
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    respuesta = dr.GetInt32(0);
                }
                else
                {
                    Desicion = false;
                }
                if (respuesta == 1)
                {
                    Desicion = true;
                }
                else 
                {
                    Desicion = false;
                }
                return Desicion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //CajaDialogo.Error(ex.Message);
                return Desicion;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt_desde.EditValue == null)
                {
                    CajaDialogo.Error("Debe seleccionar una fecha de entrada.");
                    return;
                }
                if (dt_hasta.EditValue == null)
                {
                    CajaDialogo.Error("Debe seleccionar una fecha de salida.");
                    return;
                }
                if (Convert.ToDateTime(dt_desde.EditValue) > Convert.ToDateTime(dt_hasta.EditValue))
                {
                    CajaDialogo.Error("La fecha de salida no puede ser menor que la fecha de entrada.");
                    return;
                }
                if (txttrabajadas.Text == "" && txttrabajadas.Text == "0")
                {
                    CajaDialogo.Error("Debe especificar las horas trabajadas.");
                    return;
                }
                if (txtextras.Text == "")
                {
                    CajaDialogo.Error("Debe especificar las horas extras y si no tiene colocar 0.");
                    return;
                }
                if (tgg_activo.IsOn)
                {
                    if (Validar_fecha_entrante())
                    {
                        CajaDialogo.Error("Ya existe un registro con esta fecha.");
                        return;
                    }
                }
                else
                {

                }
                string query = @"";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd;
                switch (OP)
                {
                    case Tipo_op.Editar:
                        query = @"sp_update_marca";
                        cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@date_in", dt_desde.EditValue);
                        cmd.Parameters.AddWithValue("@date_out", dt_hasta.EditValue);
                        cmd.Parameters.AddWithValue("@cantidad", txttrabajadas.Text);
                        cmd.Parameters.AddWithValue("@extra", txtextras.Text);
                        cmd.Parameters.AddWithValue("@id_empleado", codigo);
                        cmd.Parameters.AddWithValue("@enable", tgg_activo.IsOn ? 1 : 0);
                        cmd.Parameters.AddWithValue("@id_inserted", serie);
                        cmd.ExecuteNonQuery();

                        if(idMarcaEntrada>0)
                            UpdateMarcasReloj(idMarcaEntrada);

                        if (idMarcaSalida > 0)
                            UpdateMarcasReloj(idMarcaSalida);

                        break;
                    case Tipo_op.Nuevo:

                        query = @"sp_insert_marca";
                        cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@date_in", dt_desde.EditValue);
                        cmd.Parameters.AddWithValue("@date_out", dt_hasta.EditValue);
                        cmd.Parameters.AddWithValue("@cantidad", txttrabajadas.Text);
                        cmd.Parameters.AddWithValue("@extra", txtextras.Text );
                        cmd.Parameters.AddWithValue("@barcode", grd_empleados.EditValue);
                        cmd.Parameters.AddWithValue("@enable", 1);
                        cmd.ExecuteNonQuery();

                        if (idMarcaEntrada > 0)
                            UpdateMarcasReloj(idMarcaEntrada);

                        if (idMarcaSalida > 0)
                            UpdateMarcasReloj(idMarcaSalida);

                        break;
                    default:
                        break;
                }
                CajaDialogo.Information("Ajuste realizado con exito!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void UpdateMarcasReloj(int pIdMarca)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_set_update_marca_reloj_con_marca_manual", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", pIdMarca);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void grd_empleados_EditValueChanged(object sender, EventArgs e)
        {
            codigo = Convert.ToString(grd_empleados.EditValue);
        }

        private void cmdHoraEntrada_Click(object sender, EventArgs e)
        {
            frmMarcasReloj frm = new frmMarcasReloj(codigo);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                dt_desde.EditValue = frm.FechaHoraSelected;
                idMarcaEntrada = frm.IdMarca;
            }
        }

        private void cmdHoraSalida_Click(object sender, EventArgs e)
        {
            frmMarcasReloj frm = new frmMarcasReloj(codigo);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dt_hasta.EditValue = frm.FechaHoraSelected;
                idMarcaEntrada = frm.IdMarca;
            }
        }
    }
}