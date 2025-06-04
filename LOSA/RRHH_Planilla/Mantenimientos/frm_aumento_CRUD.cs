using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.Clases.Colaborador;
using LOSA.Clases.Contrato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LOSA.RRHH_Planilla.Mantenimientos
{
    public partial class frm_aumento_CRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoTransaccion {
            Nuevo = 1,
            Editar = 2
        }

        TipoTransaccion transaccion_tipo;
        UserLogin usuario_logueado = new UserLogin();
        int id_contrato = 0;
        ContratoAumento aumento = new ContratoAumento();
        DetalleContrato contrato = new DetalleContrato();

        public frm_aumento_CRUD(TipoTransaccion t_tipo, UserLogin usuarioLog, int contract_id)
        {
            InitializeComponent();
            CargarTipoAumento();
            transaccion_tipo = t_tipo;
            usuario_logueado = usuarioLog;

            deFecha.EditValue = DateTime.Now;
            contrato.RecuperarRegistroPorId(contract_id);

        }

        public frm_aumento_CRUD(UserLogin usuarioLog, TipoTransaccion t_tipo, long id_aumento)
        {
            InitializeComponent();
            CargarTipoAumento();
            transaccion_tipo = t_tipo;
            usuario_logueado = usuarioLog;

            deFecha.EditValue = DateTime.Now;
            aumento.RecuperarRegistro(id_aumento);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                if (deFecha.EditValue == null)
                {
                    CajaDialogo.Error("Debe de seleccionar una fecha para el aumento!");
                    return;
                }

                if (slueTipoAumento.EditValue == null)
                {
                    CajaDialogo.Error("Debe de seleccionar una tipo de aumento reconocido!");
                    return;
                }

                if (Convert.ToDecimal(txtValor.Text) <= 0)
                {
                    CajaDialogo.Error("El valor, debe ser un valor reconocido!");
                    return;
                }

                if ((int)slueTipoAumento.EditValue == 1)
                {
                    if (Convert.ToDecimal(txtValor.EditValue) <= Convert.ToDecimal(txtSalarioActual.EditValue) && (Convert.ToUInt32(slueTipoAumento.EditValue) == 1 || Convert.ToUInt32(slueTipoAumento.EditValue) == 2))
                    {
                        CajaDialogo.Error("El valor nuevo, debe ser mayor al salario actual");
                        return;
                    }
                }

                switch (transaccion_tipo)
                {
                    case TipoTransaccion.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("[uspInsertAumento]", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@contract_id", contrato.ID);
                            cmd.Parameters.AddWithValue("@fecha", deFecha.EditValue);
                            cmd.Parameters.AddWithValue("@new_amount", txtValor.EditValue);
                            cmd.Parameters.AddWithValue("@amount", 0);
                            cmd.Parameters.AddWithValue("@create_uid", usuario_logueado.Id);
                            cmd.Parameters.AddWithValue("@id_tipo_aumento", slueTipoAumento.EditValue);

                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccion.Editar:

                        using (SqlCommand cmd = new SqlCommand("uspUpdateAumento", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@contract_id", id_contrato);
                            cmd.Parameters.AddWithValue("@fecha", deFecha.EditValue);
                            cmd.Parameters.AddWithValue("@amount", txtValor.EditValue);
                            cmd.Parameters.AddWithValue("@create_uid", usuario_logueado.Id);
                            cmd.Parameters.AddWithValue("@id_tipo_aumento", slueTipoAumento.EditValue);
                            cmd.Parameters.AddWithValue("@id", aumento.Id);


                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Actualizados");
                        this.DialogResult = DialogResult.OK;
                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void frm_aumento_CRUD_Load(object sender, EventArgs e)
        {
            try
            {
                CambiarMascaraMoneda(contrato.Moneda);

                if (transaccion_tipo == TipoTransaccion.Editar)
                {

                    txtValor.EditValue = aumento.Amount;
                    deFecha.EditValue = aumento.Fecha;
                    slueTipoAumento.EditValue = aumento.TipoAumento;
                    txtSalarioActual.EditValue = ObtenerSalarioActualEmpleado(aumento.EmployeeId);
                }
                else
                {
                    txtSalarioActual.EditValue = ObtenerSalarioActualEmpleado(contrato.EmployeeId);

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        public void CargarTipoAumento()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsColaborador1.payment_history_type.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoad_paymment_history_type", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(dsColaborador1.payment_history_type);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public decimal ObtenerSalarioActualEmpleado(int employee_id)
        {
            try
            {
                DataOperations dp = new DataOperations();
                decimal salario=0;

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();
                    string commandText = $"SELECT dbo.ft_get_salario_empleado_from_id({ employee_id}) AS salario";

                    SqlCommand cmd = new SqlCommand(commandText,cnx);
                    cmd.CommandType = CommandType.Text;

                    //cmd.Parameters.AddWithValue("@id_employee",employee_id);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        salario = dr.IsDBNull(dr.GetOrdinal("salario")) ? 0 : Convert.ToDecimal(dr["salario"].ToString());
                    }
                    cnx.Close() ;
                }

                return salario;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return 0;
            }
        }

        private void txtValor_EditValueChanged(object sender, EventArgs e)
        {
           

            if (slueTipoAumento.EditValue != null)
            {
                if ((int)slueTipoAumento.EditValue == 1)//Importe
                {
                    //txtValor.EditValue = 0;

                    if (txtValor.EditValue != null)
                    {
                        lblNuevoSalario.Text = $"Nuevo Salario: {contrato.SimboloMoneda}{Convert.ToDecimal( txtValor.EditValue).ToString("N2")}";
                    }
                }

                if ((int)slueTipoAumento.EditValue == 2)//Incremento
                {
                    if (txtValor.EditValue != null)
                    {
                        //txtValor.EditValue = 0;

                        // Calcular el aumento
                        decimal importe = Convert.ToDecimal(txtValor.EditValue)  + Convert.ToDecimal(txtSalarioActual.EditValue);

                        lblNuevoSalario.Text = $"Nuevo Salario: {contrato.SimboloMoneda}{(Convert.ToDecimal(txtSalarioActual.EditValue) + Convert.ToDecimal(txtValor.EditValue)).ToString("N2")}";
                    }
                }

                if ((int)slueTipoAumento.EditValue == 3)//Porcentaje
                {
                    if (txtValor.EditValue != null)
                    {
                        //txtValor.EditValue = 0;

                        // Calcular el aumento
                        decimal valor_porcentaje = decimal.Parse(txtValor.EditValue.ToString()) * (decimal)txtSalarioActual.EditValue;
                        lblNuevoSalario.Text = $"Nuevo Salario: {contrato.SimboloMoneda}{((decimal)txtSalarioActual.EditValue + valor_porcentaje).ToString("N2")}";
                    }
                }
            }
        }

        private void CambiarMascaraValor(int opcion)
        {
            // Asumimos que tienes un TextEdit llamado 'textEdit1'

            switch (opcion) // Convertimos la opción a minúsculas para comparar
            {
                case 1:
                case 2:
                    // Mascara para valores decimales
                    txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    txtValor.Properties.Mask.EditMask = "n2";  // Decimal con 2 decimales
                    txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;  // Usar el formato de la máscara para mostrar
                    break;

                case 3:
                    // Mascara para porcentaje
                    txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    txtValor.Properties.Mask.EditMask = "p";  // Mascara de porcentaje
                    txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;  // Usar el formato de la máscara para mostrar
                    break;

                default:
                    // En caso de que no se seleccione ninguna opción válida
                    txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;  // Sin máscara
                    txtValor.Text = "";  // Limpiamos el texto
                    break;
            }
        }

        private void slueTipoAumento_EditValueChanged(object sender, EventArgs e)
        {
            CambiarMascaraValor((int)slueTipoAumento.EditValue);
        }

        private void CambiarMascaraMoneda(string moneda)
        {
            if (moneda != null)
            {
                switch (moneda.ToUpper())
                {
                    case "USD": // Dólares
                        txtSalarioActual.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                        txtSalarioActual.Properties.Mask.EditMask = "c"; // Formato monetario
                        txtSalarioActual.Properties.Mask.Culture = new CultureInfo("en-US"); // Formato de EE.UU. (USD)
                        txtSalarioActual.Properties.Mask.UseMaskAsDisplayFormat = true;
                        break;

                    case "HNL": // Lempiras
                        txtSalarioActual.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                        txtSalarioActual.Properties.Mask.EditMask = "c"; // Formato monetario
                        txtSalarioActual.Properties.Mask.Culture = new CultureInfo("es-HN"); // Formato de Honduras (HNL)
                        txtSalarioActual.Properties.Mask.UseMaskAsDisplayFormat = true;
                        break;
                }
            }
        }
    }
}