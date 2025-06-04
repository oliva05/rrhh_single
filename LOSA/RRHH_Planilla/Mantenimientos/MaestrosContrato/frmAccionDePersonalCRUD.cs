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

namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosContrato
{
    public partial class frmAccionDePersonalCRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum tipo_transaccion { 
            Nuevo=1,
            Editar=2
        }

        public enum tipo_accion
        {
            AumentoSalarial = 1,
            Cambio_de_puesto = 2
        }

        tipo_transaccion transaccionActual;
        UserLogin usuarioLog= new UserLogin();
        DetalleContrato contratoActual = new DetalleContrato();
        int contrato_id = 0;
        AccionDelPersonal accion = new AccionDelPersonal();
        HrEmployee empleado = new HrEmployee();

        public frmAccionDePersonalCRUD(tipo_transaccion pTransaccionActual,UserLogin pUsuario,int pContrato_id)
        {
            InitializeComponent();

            transaccionActual = pTransaccionActual;
            usuarioLog = pUsuario;
            contrato_id = pContrato_id;
            CargarTipoAccion();

           if( contratoActual.RecuperarRegistroPorId(pContrato_id))
            {
                empleado.RecuperarDatosPorCodigo(contratoActual.Barcode);
                CambiarMascaraMoneda(contratoActual.Moneda);
            }

            CargarPuestos();
        }

        public frmAccionDePersonalCRUD(tipo_transaccion pTransaccionActual, UserLogin pUsuario, int pContrato_id,int id_accion)
        {
            InitializeComponent();

            transaccionActual = pTransaccionActual;
            usuarioLog = pUsuario;
            contrato_id = pContrato_id;
            CargarTipoAccion();

            if (contratoActual.RecuperarRegistroPorId(pContrato_id))
            {
                empleado.RecuperarDatosPorCodigo(contratoActual.Barcode);
                CambiarMascaraMoneda(contratoActual.Moneda);
            }

            accion.RecuperarRegistro(id_accion);
            CargarPuestos();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                if (deFechaEfectiva.EditValue == null)
                {
                    CajaDialogo.Error("Debe seleccionar un fecha de aplicación de la acción");
                    return;
                }

                if (slueTipoAcccion.EditValue==null)
                {
                    CajaDialogo.Error("Debe seleccionar un tipo de acción");
                    return;
                }


                if ((int)tipo_accion.AumentoSalarial== (int)slueTipoAcccion.EditValue)
                {
                    if (txtSalarioNuevo.EditValue==null)
                    {
                        CajaDialogo.Error("Debe ingresar un nuevo salario");
                        return;
                    }

                    if (Convert.ToDecimal(txtSalarioNuevo.EditValue)<=contratoActual.Wage)
                    {
                        CajaDialogo.Error("El nuevo salario debe ser mayor al salario actual");
                        return;
                    }
                }

                if ((int)tipo_accion.Cambio_de_puesto == (int)slueTipoAcccion.EditValue)
                {
                    if (sluePuesto.EditValue==null)
                    {
                        CajaDialogo.Error("Debe seleccionar un nuevo puesto");
                        return;
                    }

                    if (empleado.JobId==(int)sluePuesto.EditValue)
                    {
                        CajaDialogo.Error("Debe seleccionar un puesto diferente al actual");
                        return;
                    }
                }

                    switch (transaccionActual)
                {   
                    case tipo_transaccion.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("dbo.[uspInsert_accion_del_personal]", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@fecha_efectiva", deFechaEfectiva.EditValue);
                            cmd.Parameters.Add("@user_id",usuarioLog.Id);
                            cmd.Parameters.Add("@id_tipo_accion", slueTipoAcccion.EditValue);
                           

                            if ((int)slueTipoAcccion.EditValue== (int)tipo_accion.AumentoSalarial)
                            {
                                cmd.Parameters.Add("@job_id_anterior",DBNull.Value);
                                cmd.Parameters.Add("@job_id_nuevo",  DBNull.Value);

                                cmd.Parameters.Add("@salario_anterior", contratoActual.Wage);
                                cmd.Parameters.Add("@salario_nuevo", txtSalarioNuevo.EditValue);
                            }

                            if ((int)slueTipoAcccion.EditValue == (int)tipo_accion.Cambio_de_puesto)
                            {
                                cmd.Parameters.Add("@salario_anterior", DBNull.Value);
                                cmd.Parameters.Add("@salario_nuevo", DBNull.Value);

                                cmd.Parameters.Add("@job_id_anterior", empleado.JobId);
                                cmd.Parameters.Add("@job_id_nuevo", sluePuesto.EditValue);
                            }

                                //cmd.Parameters.Add("@job_id_anterior", (int)sluePuesto.EditValue != 2 ?? DBNull.Value : empleado.JobId.GetValueOrDefault());
                                cmd.Parameters.Add("@contrato_id", contrato_id);

                            cmd.ExecuteNonQuery();

                            cnx.Close();
                        }

                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case tipo_transaccion.Editar:

                        using (SqlCommand cmd = new SqlCommand("dbo.uspUpdate_accion_del_personal", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;


                            cmd.Parameters.Add("@fecha_efectiva", deFechaEfectiva.EditValue);
                            //cmd.Parameters.Add("@user_id", usuarioLog.Id);
                            cmd.Parameters.Add("@id_tipo_accion", slueTipoAcccion.EditValue);


                            if ((int)slueTipoAcccion.EditValue == (int)tipo_accion.AumentoSalarial)
                            {
                                cmd.Parameters.Add("@job_id_anterior", DBNull.Value);
                                cmd.Parameters.Add("@job_id_nuevo", DBNull.Value);

                                cmd.Parameters.Add("@salario_anterior", contratoActual.Wage);
                                cmd.Parameters.Add("@salario_nuevo", txtSalarioNuevo.EditValue);
                            }

                            if ((int)slueTipoAcccion.EditValue == (int)tipo_accion.Cambio_de_puesto)
                            {
                                cmd.Parameters.Add("@salario_anterior", DBNull.Value);
                                cmd.Parameters.Add("@salario_nuevo", DBNull.Value);

                                cmd.Parameters.Add("@job_id_anterior", empleado.JobId);
                                cmd.Parameters.Add("@job_id_nuevo", sluePuesto.EditValue);
                            }

                            //cmd.Parameters.Add("@job_id_anterior", (int)sluePuesto.EditValue != 2 ?? DBNull.Value : empleado.JobId.GetValueOrDefault());
                            cmd.Parameters.Add("@contrato_id", contrato_id);

                            cmd.Parameters.Add("@id", accion.IdAccion);


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

        private void CambiarMascaraMoneda(string moneda)
        {
            switch (moneda.ToUpper())
            {
                case "USD": // Dólares
                    txtSalarioNuevo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    txtSalarioNuevo.Properties.Mask.EditMask = "c"; // Formato monetario
                    txtSalarioNuevo.Properties.Mask.Culture = new CultureInfo("en-US"); // Formato de EE.UU. (USD)
                    txtSalarioNuevo.Properties.Mask.UseMaskAsDisplayFormat = true;
                    break;

                case "HNL": // Lempiras
                    txtSalarioNuevo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    txtSalarioNuevo.Properties.Mask.EditMask = "c"; // Formato monetario
                    txtSalarioNuevo.Properties.Mask.Culture = new CultureInfo("es-HN"); // Formato de Honduras (HNL)
                    txtSalarioNuevo.Properties.Mask.UseMaskAsDisplayFormat = true;
                    break;

            }
        }

        public void CargarTipoAccion()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsContrato1.accion_del_personal.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoad_accion_del_personal_tipo", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //da.SelectCommand.Parameters.Add("@barcode", SqlDbType.VarChar).Value = codigoEmpleado;
                    da.Fill(dsContrato1.accion_del_personal);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void frmAccionDePersonalCRUD_Load(object sender, EventArgs e)
        {
            if (transaccionActual== tipo_transaccion.Editar)
            {
                deFechaEfectiva.EditValue = accion.FechaEfectiva;
                txtSalarioNuevo.EditValue = accion.SalarioNuevo;
                sluePuesto.EditValue = accion.PuestoNuevoId;
                //txtSalarioNuevo.EditValue = accion.SalarioNuevo;
                slueTipoAcccion.EditValue = accion.TipoAccionId;

            }
        }

        private void slueTipoAcccion_EditValueChanged(object sender, EventArgs e)
        {
            if ((int)tipo_accion.AumentoSalarial==(int)slueTipoAcccion.EditValue)
            {
                lblAnterior.Visible= true;    
                lblCambiante.Visible= true;
                lblCambiante.Text = "Salario Nuevo";
                lblAnterior.Text = "Salario anterior: "+contratoActual.SimboloMoneda+ contratoActual.Wage.ToString("N2");
                sluePuesto.Visible= false;
                txtSalarioNuevo.Visible= true;
                txtSalarioNuevo.Location = new System.Drawing.Point(117, 108);
            }
            else
            {
                lblAnterior.Visible= true;
                sluePuesto.Location = new System.Drawing.Point(117, 108);
                sluePuesto.Visible= true;
                txtSalarioNuevo.Visible= false;
                lblAnterior.Text = "Puesto anterior: "+empleado.JobTitle;
                lblCambiante.Visible = true;
                lblCambiante.Text = "Puesto Nuevo";
         

            }
        }

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
    }
}