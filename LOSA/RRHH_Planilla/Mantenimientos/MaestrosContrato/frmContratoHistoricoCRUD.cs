using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.Clases.Colaborador;
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

namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosContrato
{
    public partial class frmContratoHistoricoCRUD : DevExpress.XtraEditors.XtraForm
    {
        DetalleContrato contratoActual= new DetalleContrato();
        HrEmployee empleadoActual = new HrEmployee();
        UserLogin usuario = new UserLogin();
        public frmContratoHistoricoCRUD(int pContractr,UserLogin pUser)
        {
            InitializeComponent();
            CargarPuestos();
            CargarDepartamentos();
            usuario = pUser;

            if (contratoActual.RecuperarRegistroPorId(pContractr))
            {
                empleadoActual.RecuperarDatosPorCodigo(contratoActual.Barcode);

                slueDepto.EditValue = empleadoActual.DepartmentId;
                sluePuesto.EditValue = empleadoActual.JobId;
                txtSalario.EditValue = contratoActual.Wage;
                CambiarMascaraMoneda(contratoActual.Moneda);
            }

        }

        #region Datos Maestros
        public void CargarPuestos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsContrato1.hr_jobs.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadJobsV2", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@active", true);
                    da.Fill(dsContrato1.hr_jobs);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarDepartamentos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsContrato1.hr_deparment.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadDepartment", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsContrato1.hr_deparment);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close  ();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (slueDepto.EditValue== null)
                {
                    CajaDialogo.Error("Debe seleccionar un departamento");
                    return;
                }

                if (sluePuesto.EditValue == null)
                {
                    CajaDialogo.Error("Debe seleccionar un puesto");
                    return;
                }

                if (txtSalario.EditValue == null)
                {
                    CajaDialogo.Error("Debe ingresar un salario");
                    return;
                }

                if (Convert.ToDecimal(txtSalario.EditValue) <= contratoActual.Wage)
                {
                    CajaDialogo.Error("El nuevo salario debe ser mayor al salario actual");
                    return;
                }

                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("uspInsertManual_contrato_historico", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@salario",txtSalario.EditValue);
                    cmd.Parameters.AddWithValue("@notas",txtNota.EditValue);
                    cmd.Parameters.AddWithValue("@departamento_id",slueDepto.EditValue);
                    cmd.Parameters.AddWithValue("@puesto_id",sluePuesto.EditValue);
                    cmd.Parameters.AddWithValue("@contract_id",contratoActual.ID);
                    cmd.Parameters.AddWithValue("@user_create", usuario.Id);

                    cmd.ExecuteNonQuery();

                    cnx.Close ();
                }

                CajaDialogo.InformationAuto();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CambiarMascaraMoneda(string moneda)
        {
            try
            {

                switch (moneda.ToUpper())
                {
                    case "USD": // Dólares
                        txtSalario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                        txtSalario.Properties.Mask.EditMask = "c"; // Formato monetario
                        txtSalario.Properties.Mask.Culture = new CultureInfo("en-US"); // Formato de EE.UU. (USD)
                        txtSalario.Properties.Mask.UseMaskAsDisplayFormat = true;
                        break;

                    case "HNL": // Lempiras
                        txtSalario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                        txtSalario.Properties.Mask.EditMask = "c"; // Formato monetario
                        txtSalario.Properties.Mask.Culture = new CultureInfo("es-HN"); // Formato de Honduras (HNL)
                        txtSalario.Properties.Mask.UseMaskAsDisplayFormat = true;
                        break;
                }
            }
            catch (Exception ex )
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}