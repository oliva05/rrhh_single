using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.Utils.CommonDialogs;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DocumentFormat.OpenXml.Office.Word;
using LOSA.Clases;
using LOSA.Clases.Colaborador;
using LOSA.MigracionACS.DataSetx;
using LOSA.MigracionACS.Tickets.EndUser;
using LOSA.MigracionACS.Tickets.Models;
using LOSA.RRHH_Planilla.BenefitsDeductions;
using LOSA.RRHH_Planilla.Capacitacion.Model;
using LOSA.RRHH_Planilla.Contrato;
using LOSA.RRHH_Planilla.Mantenimientos;
using LOSA.RRHH_Planilla.Mantenimientos.ContratoRRHH;
using LOSA.RRHH_Planilla.Mantenimientos.MaestrosContrato;
using LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado;
using LOSA.RRHH_Planilla.Planilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;
using static LOSA.Reportes.frm_reportesMaster;

namespace LOSA.RRHH_Planilla
{
    public partial class frmContratoColaborador : DevExpress.XtraEditors.XtraForm
    {
        int empleadoId, contratoId;
        HrEmployee empleado = new HrEmployee();
        string codigoEmpleado;
        UserLogin UsuarioLogeado = new UserLogin();
        string file_name_employee = "";
        string path_employee_file = "";
        DateTime FechaActualDB = DateTime.Now;
        DetalleContrato contratoActual = new DetalleContrato();
        int IdEmpleado;
        DataOperations dp;

        //public frmContratoColaborador(string employeeCode, UserLogin usuarioP, int pIdEmpleado)
        //{
        //    InitializeComponent();
        //    codigoEmpleado = employeeCode;
        //    dp = new DataOperations();
        //    FechaActualDB = dp.Now();
        //    LoadAniosForISR();

        //    CargarHistoricoContratos();
        //    CargarHistoricoAumentos();
        //    CargarDatosPlanificacionTrabajo();
        //    CargarDatosSchedulePay();
        //    CargarDatosTipoContrato();
        //    LoadTipoContrato();
        //    IdEmpleado = pIdEmpleado;

        //    this.UsuarioLogeado = usuarioP;
        //    LoadDatos();
        //    LoadHeaderISR();
        //    LoadISRDeducido();
        //    LoadProyeccionISR();
        //    LoadAjustesISR();
        //}

        public frmContratoColaborador(int pEmployeeId, UserLogin usuarioP, int pIdContrato)
        {
            InitializeComponent();
            empleadoId = IdEmpleado = pEmployeeId;
            contratoId = pIdContrato;

            dp = new DataOperations();
            FechaActualDB = dp.Now();
            LoadAniosForISR();

            CargarHistoricoContratosPorContrato();
            CargarHistoricoAumentosPorContrato();
            CargarDatosPlanificacionTrabajo();
            CargarDatosSchedulePay();
            CargarDatosTipoContrato();
            LoadTipoContrato();

            this.UsuarioLogeado = usuarioP;
            LoadDatos();
            LoadHeaderISR();
            LoadISRDeducido();
            LoadProyeccionISR();
            LoadAjustesISR();  
        }

        public frmContratoColaborador(int pEmployeeId, UserLogin usuarioP, int pIdContrato, string PBarcode)
        {
            InitializeComponent();
            empleadoId = IdEmpleado = pEmployeeId;
            contratoId = pIdContrato;

            dp = new DataOperations();
            FechaActualDB = dp.Now();
            LoadAniosForISR();

            CargarHistoricoContratosPorContrato();
            CargarHistoricoAumentosPorContrato();
            CargarDatosPlanificacionTrabajo();
            CargarDatosSchedulePay();
            CargarDatosTipoContrato();
            LoadTipoContrato();

            this.UsuarioLogeado = usuarioP;
            LoadDatos();
            LoadHeaderISR();
            LoadISRDeducido();
            LoadProyeccionISR();
            LoadAjustesISR();

            xtraTabControl1.SelectedTabPageIndex = 4;

        }

        private void CargarHistoricoContratosPorContrato()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsColaborador1.contract_historical.Clear();

                SqlCommand cmd = new SqlCommand("uspGetContratoDetalleHistoricoByContrato", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ContractId", contratoId);
                cmd.Parameters.AddWithValue("@EmployeeId", empleadoId);
                //using (SqlDataAdapter da = new SqlDataAdapter("dbo.[uspGetContratoDetalleHistoricoByContrato]", cnx))
                //{
                //    cnx.Open();
                //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //    da.SelectCommand.Parameters.AddWithValue("@ContractId", contratoId) = codigoEmpleado;
                //    da.Fill(dsColaborador1.contract_historical);
                //    cnx.Close();
                //}
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsColaborador1.contract_historical);
                cnx.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadISRDeducido()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[GetISR_Deducido_by_empleado_by_anio]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_employee", IdEmpleado);
                cmd.Parameters.AddWithValue("@anio", gleAnioForISR.EditValue);
                dsContrato1.isr_deducido.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsContrato1.isr_deducido);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadAniosForISR()
        {
            int anio = 2000;
            while (anio <2100) 
            {
                dsContrato.anio_for_isrRow row1 = dsContrato1.anio_for_isr.Newanio_for_isrRow();
                row1.anio= anio;
                dsContrato1.anio_for_isr.Addanio_for_isrRow(row1);
                dsContrato1.AcceptChanges();
                anio++;
            }
            gleAnioForISR.EditValue = FechaActualDB.Year;
        }

        private void LoadHeaderISR()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[GetHeaderISR_ForWindowContractEmployee]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_employee", IdEmpleado);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    decimal SalarioMensual = 0;
                    decimal DevengadoAnual = 0;
                    decimal ImpuestoCobrado = 0;
                    decimal ImpuestoRestante = 0;
                    
                    if (!dr.IsDBNull(dr.GetOrdinal("salario_mensual")))
                        SalarioMensual = dr.GetDecimal(0);

                    if (!dr.IsDBNull(dr.GetOrdinal("Devengado_anual_gravado")))
                        DevengadoAnual = dr.GetDecimal(1);

                    if (!dr.IsDBNull(dr.GetOrdinal("ImpuestoCobrado")))
                        ImpuestoCobrado = dr.GetDecimal(2);

                    if (!dr.IsDBNull(dr.GetOrdinal("ImpuestoRestante")))
                        ImpuestoRestante = dr.GetDecimal(3);

                    lblSalarioMensual.Text = "Salario Mensual: "+ string.Format("{0:###,##0.00}", SalarioMensual);
                    lblDevengadoAnual.Text = "Total Devengado Anual: " + string.Format("{0:###,##0.00}", DevengadoAnual);
                    lblImpuestoCobrado.Text = "Total Impuesto Deducido: " + string.Format("{0:###,##0.00}", ImpuestoCobrado);
                    lblTotalImpuestoRestante.Text = "Total Impuesto Restante: " + string.Format("{0:###,##0.00}", ImpuestoRestante);

                    
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadProyeccionISR()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[sp_get_table_proyeccion_isr_segun_empleado_id]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_employee", IdEmpleado);
                cmd.Parameters.AddWithValue("@anio", gleAnioForISR.EditValue);
                dsContrato1.proyeccion_isr.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsContrato1.proyeccion_isr);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadAjustesISR()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[GetDetalleAjusteISR_ByEmployee]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_employee", IdEmpleado);
                //cmd.Parameters.AddWithValue("@anio", gleAnioForISR.EditValue);
                dsContrato1.ajustes_isr.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsContrato1.ajustes_isr);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public void LoadDatos()
        {
            contratoActual = new DetalleContrato();
            empleado = new HrEmployee();


            if (empleado.RecuperarDatosPorId(IdEmpleado))
            {
                lblEmpleado.Text = empleado.Name;
                lblDepartamento.Text = empleado.DepartmentTitle;
                lblCodigo.Text = empleado.Barcode;
                lblPuesto.Text = empleado.Puesto;
            }


            if (contratoActual.RecuperarRegistroPorEmpleadoId(IdEmpleado, contratoId))
            {

                lblEstadoContrato.Text = "Estado de Contrato: " + contratoActual.Estado;
                lblCategoria.Text = contratoActual.CategoriaContrato;
                btnPrintContrato.Enabled = true;
                btn_print_otorsi.Enabled = true;

                if (contratoActual.EstadoId != 5)// Cancelado
                {
                    deFechaInicio.EditValue = contratoActual.StartDate;
                    deFin.EditValue = contratoActual.EndDate;
                    sluePlanificacion.EditValue = contratoActual.PlanificacionTrabajoId;
                    sluePagoPlanificado.EditValue = contratoActual.PagoPlanificadoId;
                    txtAniosAnt.Text = contratoActual.AniosAntiguedad.ToString();
                    txtMesesAnt.Text = contratoActual.MesesAntiguedad.ToString();
                    txtNote.Text = contratoActual.Nota.ToString();
                    txtSalario.EditValue = contratoActual.Wage;
                    tsPermisoEstudio.EditValue = contratoActual.StudyPermit;
                    slueCategoriaContrato.EditValue = contratoActual.ContractTypeId;
                    slueTipoContrato2.EditValue = contratoActual.TipoContrato;
                    txtDescripcionPermiso.Text = contratoActual.DescripcionPermiso;
                    grdEstados.EditValue = contratoActual.EstadoId;
                }
                else
                {
                    colEditarAumento.Visible = false;
                    colEditarBenDed.Visible = false;
                    colInactivarAumento.Visible = false;
                    colBorrarBenDed.Visible = false;
                    colEditarAccion.Visible = false;
                    colDesactivarAccion.Visible = false;
                    btnAdd.Enabled = false;
                    btnAddAccion.Enabled = false;
                    btnAddContratoHistorico.Enabled = false;
                    btnAddAumento.Enabled = false;
                    grdEstados.EditValue = false;
                }

                CambiarMascaraMoneda(contratoActual.Moneda);
                // Ejemplo de cambiar el formato a dólares
                CambiarFormatoMonedaColumna(colamount, contratoActual.Moneda);

                //// Beneficios y Deducciones
                //CambiarFormatoMonedaColumna(colMontoOriginal, contratoActual.Moneda);
                //CambiarFormatoMonedaColumna(colValorActual, contratoActual.Moneda);
                //CambiarFormatoMonedaColumna(colValorRestante, contratoActual.Moneda);

                CargarAccionDelPersonal();
                CargarBeneficiosDeducciones();
                


            }
            CargarEstadosContratos();
            txtDescripcionPermiso.Enabled = false;
        }

        private void CargarEstadosContratos()
        {
            try
            {
                string query = @"sp_contrato_get_estados";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsContrato1.estados.Clear();
                adat.Fill(dsContrato1.estados);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void frmContratoColaborador_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region CargaDatosMaestros
        public void CargarHistoricoContratos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsColaborador1.contract_historical.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetContratoDetalleHistoricoByBarCode", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@barcode", SqlDbType.VarChar).Value = codigoEmpleado;
                    da.Fill(dsColaborador1.contract_historical);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarHistoricoAumentosPorContrato()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsColaborador1.payment_history.Clear();
                SqlCommand cmd = new SqlCommand("[uspGetHistoricoAumentoByContractId]",cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@ContractId", contratoId);
                cmd.Parameters.AddWithValue("@EmployeeId", empleadoId);
                adat.Fill(dsColaborador1.payment_history);
                cnx.Close();
                //using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetHistoricoAumentoByCodeV2", cnx))
                //{
                //    cnx.Open();
                //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //    da.SelectCommand.Parameters.Add("@barcode", SqlDbType.VarChar).Value = codigoEmpleado;
                //    da.Fill(dsColaborador1.payment_history);
                //    cnx.Close();
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarHistoricoAumentos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsColaborador1.payment_history.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetHistoricoAumentoByCodeV2", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@barcode", SqlDbType.VarChar).Value = codigoEmpleado;
                    da.Fill(dsColaborador1.payment_history);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarBeneficiosDeducciones()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsColaborador1.benefits_deductions.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetDeductionsBenefitsById", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@id_contrato",contratoActual.ID);
                    da.Fill(dsColaborador1.benefits_deductions);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void CargarDatosPlanificacionTrabajo()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla1.res_calendar.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadPlanificacionTrabajo", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
 
                    da.Fill(dsMantenimientoPlanilla1.res_calendar);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarDatosSchedulePay()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla1.schedule_pay.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadSchedulePay", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla1.schedule_pay);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarDatosTipoContrato()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla1.hr_contract_type.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadTipoContrato", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla1.hr_contract_type);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void LoadTipoContrato()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.uspLoadTipoContratoV2", con);
                cmd.CommandType = CommandType.StoredProcedure;

                dsColaborador1.hr_contrato_tipo_contrato.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsColaborador1.hr_contrato_tipo_contrato);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        public void CargarAccionDelPersonal()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsContrato1.accion_del_personal.Clear();

                SqlCommand cmd = new SqlCommand("uspLoad_accion_de_personal_by_id_contrato", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@id", contratoActual.ID);
                adat.Fill(dsContrato1.accion_del_personal);
                cnx.Close();
                //using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoad_accion_de_personal_by_id_contrato", cnx))
                //{
                //    cnx.Open();
                //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //    da.SelectCommand.Parameters.Add("@id" ,contratoActual.ID);
                //    da.Fill(dsContrato1.accion_del_personal);
                //    cnx.Close();
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetalleContrato contrato = new DetalleContrato();

            //contrato.RecuperarRegistroPorCodigo(empleado.Barcode);
            contrato.RecuperarRegistroPorEmpleadoId(IdEmpleado, contratoId);
            frmBenefitsDeductionsCRUD frm = new frmBenefitsDeductionsCRUD(frmBenefitsDeductionsCRUD.TipoTransaccionPlanilla.Nuevo,UsuarioLogeado,contrato.ID);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarBeneficiosDeducciones();
            }
        }

        private void btnEditar_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (dsColaborador.benefits_deductionsRow)gvBeneficiosDeducciones.GetFocusedDataRow();
            DetalleContrato contrato = new DetalleContrato();

            contrato.RecuperarRegistroPorEmpleadoId(empleado.Id, contratoId);

            frmBenefitsDeductionsCRUD frm = new frmBenefitsDeductionsCRUD(frmBenefitsDeductionsCRUD.TipoTransaccionPlanilla.Editar,UsuarioLogeado,contrato.ID,row.id);

            if (frm.ShowDialog()== DialogResult.OK)
            {
                CargarBeneficiosDeducciones();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Dialog.InitialDirectory = "C:/";

            // Establecer el filtro para solo permitir imágenes
            Dialog.Filter = "Archivos de imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                path_employee_file = Dialog.FileName;
                file_name_employee =Dialog.SafeFileName;
                
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
                bool transaccion_terminada=false;
                string file_name_to_upload=DateTime.Now.ToString("ddMMyyyyHHmmss")+ Path.GetExtension(path_employee_file); ;

                cnx.Open();
                SqlTransaction transaccion = cnx.BeginTransaction();

                try
                {

                SqlCommand cmd = new SqlCommand("dbo.uspSaveFileRRHH_employee", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = transaccion;

                cmd.Parameters.Add("@path", SqlDbType.VarChar).Value = dp.FTP_RRHH_Empleados + file_name_to_upload;
                cmd.Parameters.Add("@file_name", SqlDbType.VarChar).Value = file_name_employee;
                cmd.Parameters.Add("@id_employee", SqlDbType.Int).Value = empleado.Id;
                cmd.Parameters.Add("@code_employee", SqlDbType.VarChar).Value = empleado.Barcode;
                cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = UsuarioLogeado.Id;

                cmd.ExecuteNonQuery();
                transaccion_terminada = true;

                if (transaccion_terminada)
                {
                    transaccion.Commit();
                    //Subir los archivos luego de pasar el commit
                }
                else
                {
                    transaccion.Rollback();
                }

                cnx.Close();

                }
                catch (Exception ex)
                {

                CajaDialogo.Error(ex.Message);
                transaccion.Rollback();
                }

         }
        
        private void btnDelete_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsColaborador.benefits_deductionsRow)gvBeneficiosDeducciones.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                var respuesta = CajaDialogo.Pregunta("¿Desea eliminar el registro?");

                if (respuesta == DialogResult.Yes)
                {

                    using (SqlCommand cmd = new SqlCommand("dbo.uspDisableBenefitDeduction", cnx))
                    {
                        cnx.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id",row.id);
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                    }

                    CajaDialogo.Information("Datos deshabilitados!");
                    CargarBeneficiosDeducciones();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnGuardarContrato_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(grdEstados.Text))
                {
                    CajaDialogo.Error("Debe seleccionar Estado Contrato");
                    return;
                }
                else
                {
                    //sp_contrato_validacion_contrato_activo
                    if (!ValidarContratosActivos(empleadoId,contratoId))
                    {
                        CajaDialogo.Error("Ya existe un Contrato que se encuentra en Proceso\nSolo puede existir uno por Colaborador");
                        return;
                    }
                }

                if (string.IsNullOrEmpty(txtSalario.Text))
                {
                    CajaDialogo.Error("Debe de ingresar un salario");
                    return;
                }
                else
                if (Convert.ToDecimal(txtSalario.EditValue)<=0)
                {
                    CajaDialogo.Error("Debe de ingresar un salario valido");
                    return;
                }

                if (string.IsNullOrEmpty(deFechaInicio.Text))
                {
                    CajaDialogo.Error("Debe de ingresar una fecha de inicio");
                    return;
                }

                if (sluePlanificacion.EditValue==null)
                {
                    CajaDialogo.Error("Debe de seleccionar una opcion de planificación de trabajo");
                    return;
                }

                if (sluePagoPlanificado.EditValue == null)
                {
                    CajaDialogo.Error("Debe de seleccionar una opcion de pago planificado");
                    return;
                }

                if (slueCategoriaContrato.EditValue == null)
                {
                    CajaDialogo.Error("Debe de seleccionar una opcion de tipo de contrato");
                    return;
                }

                if (slueTipoContrato2.EditValue == null)
                {
                    CajaDialogo.Error("Debe de seleccionar un tipo de contrato");
                    return;
                }


                DataOperations dp = new DataOperations();
                bool termina_proceso = false;

                if (contratoActual.ID == 0 || contratoActual.EstadoId==5)// No tiene contrato
                {

                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                    {
                        cnx.Open();

                        SqlCommand cmd = new SqlCommand("uspInsertContractV2", cnx);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@name", empleado.Barcode);
                        cmd.Parameters.AddWithValue("@employee_id", empleado.Id);
                        cmd.Parameters.AddWithValue("@department_id", empleado.DepartmentId);
                        cmd.Parameters.AddWithValue("@categoria_contrato_id", slueCategoriaContrato.EditValue);
                        cmd.Parameters.AddWithValue("@job_id", empleado.JobId);
                        cmd.Parameters.AddWithValue("@date_start", deFechaInicio.EditValue);
                        cmd.Parameters.AddWithValue("@date_end", deFin.EditValue == null ? DBNull.Value : deFin.EditValue);
                        cmd.Parameters.AddWithValue("@trial_date_end", dePeriodoPrueba.EditValue== null ? DBNull.Value : dePeriodoPrueba.EditValue);
                        cmd.Parameters.AddWithValue("@resource_calendar_id", sluePlanificacion.EditValue);
                        cmd.Parameters.AddWithValue("@wage", txtSalario.EditValue);
                        cmd.Parameters.AddWithValue("@notes", txtNote.Text);
                        cmd.Parameters.AddWithValue("@company_id", 1);
                        cmd.Parameters.AddWithValue("@reported_to_secretariat", 0);
                        cmd.Parameters.AddWithValue("@create_uid", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@struct_id", DBNull.Value);
                        cmd.Parameters.AddWithValue("@id_schedule_pay", sluePagoPlanificado.EditValue);
                        cmd.Parameters.AddWithValue("@study_permit", tsPermisoEstudio.EditValue);
                        cmd.Parameters.AddWithValue("@permit_number_of_days", 0);
                        cmd.Parameters.AddWithValue("@descripcion_permiso", txtDescripcionPermiso.EditValue == null ? string.Empty : txtDescripcionPermiso.Text);
                        cmd.Parameters.AddWithValue("@state_id", 1);
                        cmd.Parameters.AddWithValue("@tipo_contrato", slueTipoContrato2.EditValue==null ? DBNull.Value : slueTipoContrato2.EditValue);

                        cmd.ExecuteNonQuery();

                        cnx.Close();
                        termina_proceso = true;

                    }

                    CajaDialogo.Information("Datos de Contrato Guardados!");
                    //btnGuardarContrato.Enabled = false;
                    btnEditContract.Enabled = true;

                    btnPrintContrato.Enabled = true;
                    btn_print_otorsi.Enabled = true;
                    contratoActual = new DetalleContrato();

                    contratoActual.RecuperarRegistroPorEmpleadoId(empleadoId, contratoId);

                    Deshabilitar_Habilitar_Controles(false);
                }
                else
                {
                    using (SqlConnection cnx2 = new SqlConnection(dp.ConnectionStringRRHH))
                    {
                        cnx2.Open();

                        SqlCommand cmd2 = new SqlCommand("uspUpdateContractV3", cnx2);
                        cmd2.CommandType = CommandType.StoredProcedure;

                        cmd2.Parameters.AddWithValue("@name", empleado.Barcode);
                        cmd2.Parameters.AddWithValue("@employee_id", empleado.Id);
                        cmd2.Parameters.AddWithValue("@department_id", empleado.DepartmentId);
                        cmd2.Parameters.AddWithValue("@categoria_contrato_id", slueCategoriaContrato.EditValue==null ? DBNull.Value : slueCategoriaContrato.EditValue);
                        cmd2.Parameters.AddWithValue("@job_id", empleado.JobId);
                        cmd2.Parameters.AddWithValue("@date_start", deFechaInicio.EditValue);
                        cmd2.Parameters.AddWithValue("@date_end", deFin.EditValue == null ? DBNull.Value : deFin.EditValue);
                        cmd2.Parameters.AddWithValue("@trial_date_end", dePeriodoPrueba.EditValue == null ? DBNull.Value : dePeriodoPrueba.EditValue);
                        cmd2.Parameters.AddWithValue("@resource_calendar_id", sluePlanificacion.EditValue);
                        cmd2.Parameters.AddWithValue("@wage", txtSalario.EditValue);
                        cmd2.Parameters.AddWithValue("@notes", txtNote.Text);
                        cmd2.Parameters.AddWithValue("@company_id", 1);
                        cmd2.Parameters.AddWithValue("@reported_to_secretariat", 0);
                        cmd2.Parameters.AddWithValue("@create_uid", UsuarioLogeado.Id);
                        cmd2.Parameters.AddWithValue("@struct_id", DBNull.Value);
                        cmd2.Parameters.AddWithValue("@id_schedule_pay", sluePagoPlanificado.EditValue== null ? DBNull.Value: sluePagoPlanificado.EditValue);
                        cmd2.Parameters.AddWithValue("@study_permit", tsPermisoEstudio.EditValue==null ? DBNull.Value : tsPermisoEstudio.EditValue);
                        cmd2.Parameters.AddWithValue("@permit_number_of_days", 0);
                        cmd2.Parameters.AddWithValue("@descripcion_permiso", txtDescripcionPermiso.EditValue == null ? string.Empty : txtDescripcionPermiso.Text);
                        cmd2.Parameters.AddWithValue("@state_id", 1);
                        cmd2.Parameters.AddWithValue("@id", contratoActual.ID);
                        cmd2.Parameters.AddWithValue("@tipo_contrato", slueTipoContrato2.EditValue == null ? DBNull.Value : slueTipoContrato2.EditValue);
                        cmd2.Parameters.AddWithValue("@estado", grdEstados.EditValue);

                        cmd2.ExecuteNonQuery();

                        cnx2.Close();
                        termina_proceso = true;

                    }

                    CajaDialogo.Information("Actualización de Contrato Exitosa!");
                    //btnGuardarContrato.Enabled = false;
                    btnEditContract.Enabled = true;

                    Deshabilitar_Habilitar_Controles(false);

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private bool ValidarContratosActivos(int empleadoId, int contratoId)
        {
            bool Permitir = false;
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_contrato_validacion_contrato_activo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employee_id", empleadoId);
                cmd.Parameters.AddWithValue("@contract_id", contratoId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) 
                {
                    Permitir = reader.GetBoolean(0);
                    reader.Close();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            return Permitir;

        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
          
                Deshabilitar_Habilitar_Controles(true);
                btnEditContract.Enabled = false;
 

        }

        public void Deshabilitar_Habilitar_Controles(bool deshabilitar)
        {

            txtSalario.Enabled =
            deFechaInicio.Enabled =
            deFin.Enabled =
            dePeriodoPrueba.Enabled =
            sluePagoPlanificado.Enabled =
            sluePlanificacion.Enabled =
            tsPermisoEstudio.Enabled =
            slueCategoriaContrato.Enabled =
            btnGuardarContrato.Enabled =
            btnCancelar.Enabled =
            slueTipoContrato2.Enabled=
            grdEstados.Enabled =
            txtNote.Enabled = deshabilitar;

                if (tsPermisoEstudio.IsOn)
                {
                    txtDescripcionPermiso.Enabled = deshabilitar;
                }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Deshabilitar_Habilitar_Controles(false);
            btnEditContract.Enabled = true;
            btnGuardarContrato.Enabled=false;

            deFechaInicio.EditValue = contratoActual.StartDate;
            deFin.EditValue = contratoActual.EndDate;
            sluePlanificacion.EditValue = contratoActual.PlanificacionTrabajoId;
            sluePagoPlanificado.EditValue = contratoActual.PagoPlanificadoId;
            txtAniosAnt.Text = contratoActual.AniosAntiguedad.ToString();
            txtMesesAnt.Text = contratoActual.MesesAntiguedad.ToString();
            txtNote.Text = contratoActual.Nota.ToString();
            lblEstadoContrato.Text = "Estado de Contrato: " + contratoActual.Estado;
            txtSalario.EditValue = contratoActual.Wage;
            tsPermisoEstudio.EditValue = contratoActual.StudyPermit;
            slueCategoriaContrato.EditValue = contratoActual.ContractTypeId;
        }

        private void deFechaInicio_EditValueChanged(object sender, EventArgs e)
        {
            txtAniosAnt.EditValue = (int)((DateTime.Now - deFechaInicio.DateTime).TotalDays / 365.25);

            // Calcular la diferencia en años y meses
            int aniosDiferencia = DateTime.Now.Year - deFechaInicio.DateTime.Year;
            int mesesDiferencia = DateTime.Now.Month - deFechaInicio.DateTime.Month;

            // Combinar los años y meses en una sola cantidad de meses
            int totalMeses = (aniosDiferencia * 12) + mesesDiferencia;

            // Ajustar si el día del mes de fechaFin es menor que el día del mes de fechaInicio
            if (DateTime.Now.Day < deFechaInicio.DateTime.Day)
            {
                totalMeses--;
            }

            txtMesesAnt.EditValue=totalMeses;
            dePeriodoPrueba.EditValue = deFechaInicio.DateTime.AddDays(60);
        }

      
        private void btnAddAumento_Click(object sender, EventArgs e)
        {
            frm_aumento_CRUD frm = new frm_aumento_CRUD(frm_aumento_CRUD.TipoTransaccion.Nuevo,UsuarioLogeado,contratoActual.ID);

            if (frm.ShowDialog()== DialogResult.OK) 
            {
                CargarHistoricoAumentos();
            }
        }

        private void btnEditarAumento_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsColaborador.payment_historyRow)gvAumentos.GetFocusedDataRow();

                if (row != null)
                {
                    frm_aumento_CRUD frm = new frm_aumento_CRUD(UsuarioLogeado,frm_aumento_CRUD.TipoTransaccion.Editar,row.id);

                    if (frm.ShowDialog()== DialogResult.OK)
                    {
                        CargarHistoricoAumentos();
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnInacticarAumento_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsColaborador.payment_historyRow)gvAumentos.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                var respuesta = CajaDialogo.Pregunta("¿Desea deshabilitar el registro?");

                if (respuesta == DialogResult.Yes)
                {

                    using (SqlCommand cmd = new SqlCommand("dbo.uspDisable_payment_history", cnx))
                    {
                        cnx.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                    }

                    CajaDialogo.Information("Datos deshabilitados!");
                    CargarHistoricoAumentos();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tsPermisoEstudio_Toggled(object sender, EventArgs e)
        {
            txtDescripcionPermiso.Enabled = (bool)tsPermisoEstudio.EditValue;

            if (!tsPermisoEstudio.IsOn)
            {
                txtDescripcionPermiso.EditValue = null;
            }
       
        }

        private void CambiarMascaraMoneda(string moneda)
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

        private void CambiarFormatoMonedaColumna(GridColumn columna, string moneda)
        {
            switch (moneda.ToUpper())
            {
                case "USD": // Dólares
                    columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    columna.DisplayFormat.FormatString = "c"; // Formato monetario
                    columna.DisplayFormat.Format = new CultureInfo("en-US"); // Cultura de EE.UU. (USD)
                    break;

                case "HNL": // Lempiras
                    columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    columna.DisplayFormat.FormatString = "c"; // Formato monetario
                    columna.DisplayFormat.Format = new CultureInfo("es-HN"); // Cultura de Honduras (HNL)
                    break;
            }
        }

        private void btnAddAccion_Click(object sender, EventArgs e)
        {
            frmAccionDePersonalCRUD frm = new frmAccionDePersonalCRUD(frmAccionDePersonalCRUD.tipo_transaccion.Nuevo, UsuarioLogeado, contratoActual.ID);

            if (frm.ShowDialog()== DialogResult.OK)
            {
                CargarHistoricoAumentos();
            }
        }

        private void btnEdit_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsContrato.accion_del_personalRow)gvAccion.GetFocusedDataRow();

                frmAccionDePersonalCRUD frm = new frmAccionDePersonalCRUD(frmAccionDePersonalCRUD.tipo_transaccion.Editar,UsuarioLogeado,contratoActual.ID,row.IdAccion);

                if (frm.ShowDialog()== DialogResult.OK)
                {
                    CargarAccionDelPersonal();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDesactivar_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsContrato.accion_del_personalRow)gvAccion.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                if (row != null)
                {

                    if (row.id_estado != 1)
                    {
                        CajaDialogo.Error("No puede editar esta Acción del Personal");
                        return;
                    }

                    var respuesta = CajaDialogo.Pregunta("¿Desea desactivar el registro?");

                    if (respuesta == DialogResult.Yes)
                    {

                        using (SqlCommand cmd = new SqlCommand("dbo.uspDisable_accion_del_personal", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.IdAccion;
                            cmd.ExecuteNonQuery();
                            cnx.Close();
                        }

                        CajaDialogo.Information("Datos deshabilitados!");
                        CargarAccionDelPersonal();
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAddContratoHistorico_Click(object sender, EventArgs e)
        {
            frmContratoHistoricoCRUD frm = new frmContratoHistoricoCRUD(contratoActual.ID,UsuarioLogeado);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarHistoricoContratos();
            }
        }

        private void gleAnioForISR_EditValueChanged(object sender, EventArgs e)
        {
            LoadISRDeducido();
        }

        private void cmdAgregarAjuste_Click(object sender, EventArgs e)
        {
            HrConfIsrAjusteSaldos ConfActual = new HrConfIsrAjusteSaldos();
            frmAddAjusteISR_Contrato frm = new frmAddAjusteISR_Contrato(UsuarioLogeado, empleado.Id, frmAddAjusteISR_Contrato.TipoTransaccion.Insert, ConfActual);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadAjustesISR();
            }
        }

        private void cmdEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsContrato.ajustes_isrRow)gridView.GetFocusedDataRow();

            HrConfIsrAjusteSaldos ConfActual = new HrConfIsrAjusteSaldos();
            ConfActual = ConfActual.GetHrConfIsrAjusteSaldosById(row.id, dp.ConnectionStringRRHH);
            if (ConfActual.Recuperado)
            {
                frmAddAjusteISR_Contrato frm = new frmAddAjusteISR_Contrato(UsuarioLogeado, empleado.Id, frmAddAjusteISR_Contrato.TipoTransaccion.Update, ConfActual);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadAjustesISR();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptContrato rpt = new rptContrato(contratoActual.ID);
            // Crear el objeto ReportPrintTool con el reporte
            ReportPrintTool printTool = new ReportPrintTool(rpt);

            // Mostrar la ventana de vista previa
            printTool.ShowPreviewDialog();
        }

        private void txtDescripcionPermiso_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_print_otorsi_Click(object sender, EventArgs e)
        {
            rptContratoOTORSI rpt = new rptContratoOTORSI(contratoActual.ID);
            // Crear el objeto ReportPrintTool con el reporte
            ReportPrintTool printTool = new ReportPrintTool(rpt);

            // Mostrar la ventana de vista previa
            printTool.ShowPreviewDialog();
        }
    }
}
