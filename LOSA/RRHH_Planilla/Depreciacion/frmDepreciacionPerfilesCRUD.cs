using ACS.Classes;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Commands;
using LOSA.Calidad.LoteConfConsumo;
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

namespace LOSA.RRHH_Planilla.Depreciacion
{
    public partial class frmDepreciacionPerfilesCRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoOperacion
        {
            Nuevo = 1,
            Editar = 2
        }

        TipoOperacion operacion;
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        int IdPerfil = 0;

        public frmDepreciacionPerfilesCRUD(frmDepreciacionPerfilesCRUD.TipoOperacion ptipo, UserLogin pUserLog, int pId)
        {
            InitializeComponent();
            operacion = ptipo;
            UsuarioLogeado = pUserLog;
            IdPerfil = pId;
            LoadData();
            switch (operacion)
            {
                case TipoOperacion.Nuevo:
                    tsActivo.IsOn = true;
                    tsActivo.Enabled = false;
                    tsPeaje.IsOn = false;
                    tsMante.IsOn = true;
                    grdMoneda.EditValue = 2;
                    break;
                case TipoOperacion.Editar:
                    cmdBuscarEmpleado.Visible = false;
                    Depreciacion dep = new Depreciacion();
                    dep.RecuperarPerfil(IdPerfil, 0);
                    txtCodeEmpleado.Text = dep.CodeEmpleado;
                    txtEmpleado.Text = dep.Nombre;
                    txtMarca.Text = dep.Marca;
                    txtModelo.Text = dep.Modelo;
                    txtPlaca.Text = dep.Placa; 
                    spinKm.EditValue = dep.Km;
                    tsPeaje.IsOn = dep.PagaPeaje;
                    tsMante.IsOn = dep.PagaMantenimiento;
                    tsActivo.IsOn = dep.Activo;
                    grdMoneda.EditValue = dep.Moneda;

                    if (tsMante.IsOn)
                    {
                        txtMontoFijo.Enabled = false;
                        txtMontoFijo.EditValue = 0.00;
                    }
                    else
                    {
                        txtMontoFijo.Enabled = true;
                        txtMontoFijo.EditValue = dep.MontoFijoPago;
                    }

                    break;
                default:
                    break;
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

        private void cmdBuscarEmpleado_Click(object sender, EventArgs e)
        {
            frmSearchEmployee frm = new frmSearchEmployee(frmSearchEmployee.TipoBusqueda.EmpleadosDepreciacion, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCodeEmpleado.Text = frm.ItemSeleccionado.ItemCode;
                txtEmpleado.Text = frm.ItemSeleccionado.ItemName;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool Guardar = false;
            if (string.IsNullOrEmpty(txtCodeEmpleado.Text))
            {
                CajaDialogo.Error("Debe seleccionar un Empleado!");
                return;
            }

            if(Convert.ToDecimal(spinKm.EditValue) <= 0)
            {
                CajaDialogo.Error("No puede indicar un valor menos a (0).");
                return;
            }

            if (string.IsNullOrEmpty(grdMoneda.Text))
            {
                CajaDialogo.Error("Debe seleccionar una Moneda de Pago!");
                return;
            }

            if (!tsMante.IsOn)
            {
                if(Convert.ToDecimal(txtMontoFijo.EditValue) <= 0) 
                {
                    CajaDialogo.Error("Debe agregar un valor mayor a 0 en Monto Fijo");
                    return;
                }

            }

            switch (operacion)
            {
                case TipoOperacion.Nuevo:
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_depreciacion_perfiles_crud", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_perfil",0);
                        cmd.Parameters.AddWithValue("@code_empleado",txtCodeEmpleado.Text.Trim());
                        cmd.Parameters.AddWithValue("@marca",txtMarca.Text.Trim());
                        cmd.Parameters.AddWithValue("@placa",txtPlaca.Text);
                        cmd.Parameters.AddWithValue("@user_id",UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@km",spinKm.EditValue);
                        if (tsPeaje.IsOn)
                            cmd.Parameters.AddWithValue("@peaje", 1);
                        else
                            cmd.Parameters.AddWithValue("@peaje", 0);
                        if(tsMante.IsOn)
                            cmd.Parameters.AddWithValue("@mantenimiento", 1);
                        else
                            cmd.Parameters.AddWithValue("@mantenimiento", 0);
                        cmd.Parameters.AddWithValue("@modelo",txtModelo.Text);
                        cmd.Parameters.AddWithValue("@activo",1);
                        cmd.Parameters.AddWithValue("@moneda", grdMoneda.EditValue);
                        cmd.Parameters.AddWithValue("@monto_fijo_pago", txtMontoFijo.EditValue);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        Guardar = true;
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                        Guardar = false;
                    }

                    break;
                case TipoOperacion.Editar:
                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_depreciacion_perfiles_crud", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_perfil", IdPerfil);
                        cmd.Parameters.AddWithValue("@code_empleado", txtCodeEmpleado.Text.Trim());
                        cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                        cmd.Parameters.AddWithValue("@placa", txtPlaca.Text);
                        cmd.Parameters.AddWithValue("@user_id", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@km", spinKm.EditValue);
                        if (tsPeaje.IsOn)
                            cmd.Parameters.AddWithValue("@peaje", 1);
                        else
                            cmd.Parameters.AddWithValue("@peaje", 0);
                        if (tsMante.IsOn)
                            cmd.Parameters.AddWithValue("@mantenimiento", 1);
                        else
                            cmd.Parameters.AddWithValue("@mantenimiento", 0);
                        cmd.Parameters.AddWithValue("@modelo", txtModelo.Text);
                        if (tsActivo.IsOn)
                            cmd.Parameters.AddWithValue("@activo", 1);
                        else
                            cmd.Parameters.AddWithValue("@activo", 0);
                        cmd.Parameters.AddWithValue("@moneda", grdMoneda.EditValue);
                        cmd.Parameters.AddWithValue("@monto_fijo_pago", txtMontoFijo.EditValue);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        Guardar = true;
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                        Guardar = false;
                    }

                    break;
                default:
                    break;
            }

            if (Guardar)
            {
                CajaDialogo.Information("Actualizado con Exito!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void tsMante_Toggled(object sender, EventArgs e)
        {
            if (tsMante.IsOn)
            {
                txtMontoFijo.Enabled = false;
                txtModelo.EditValue = 0.00;
            }
            else 
            {
                txtMontoFijo.Enabled = true;
            }
        }
    }
}