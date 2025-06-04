using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Layout;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Wordprocessing;
using LOSA.Clases;
using LOSA.Clases.Colaborador;
using LOSA.Clases.Planilla;
using LOSA.MigracionACS.RRHH.Vacaciones;
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

namespace LOSA.RRHH_Planilla.Planilla.Ausencias
{
    public partial class frmLeaveCRUD : DevExpress.XtraEditors.XtraForm
    {
        int id_employee = 0;
        int IdDetalle = 0;
        double dias_solicitados = 0;
        HrEmployee employee = new HrEmployee();
        public enum TransaccionTipo
        {
            Nuevo = 1,
            Editar = 2
        }

        private enum TipoLeaves
        {
            LegalLeaves2020 = 1,
            IncapacidadPagada=2,
            DiasCompensatorios=3,
            DiasSinPago=4,
            Vacaciones=5,
            Incapacidad34Porciento=6,
            AusenciaSinJustificacion=7,
            AusentismoLaboralSinPago=8,
            VacacionesPagadas=9,
            AusentismoLaboralConPago=11
        }

        TransaccionTipo transaccionActual;

        UserLogin userLogged = new UserLogin();

        public frmLeaveCRUD(int pEmployee_id, TransaccionTipo transaccionActual, UserLogin pUsuario, int pIdDetalle)
        {
            InitializeComponent();
            id_employee = pEmployee_id;

            LoadTipoAusencia();
            //LoadCategoriaAusencia();
            this.transaccionActual = transaccionActual;
            tsAplicado.IsOn = false;
            employee.RecuperarDatosPorId(pEmployee_id);
            userLogged = pUsuario;
            IdDetalle = pIdDetalle;
            switch (transaccionActual)
            {
                case TransaccionTipo.Nuevo:
                    break;
                case TransaccionTipo.Editar:
                    HrLeave leave = new HrLeave();
                    if (leave.RecuperarDetalleAusencias(IdDetalle))
                    {
                        
                        slueTipoAusencia.EditValue = leave.HolidayStatusId;
                        dtInicio.EditValue = leave.DateFrom;
                        dtFin.EditValue = leave.DateTo;
                        deRegreso.EditValue = leave.DateReturn;
                        seDiasVacaciones.EditValue = leave.NumberOfDays;
                        txtNote.Text = leave.Notes;
                        tsAplicado.Enabled = false;
                        if (leave.Aplicado)
                        {
                            tsAplicado.IsOn = true;
                           
                        }
                        else
                        {
                            tsAplicado.IsOn = false;
                        }
                    }

                    break;
                default:
                    break;
            }
        }


        private void LoadTipoAusencia()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("[dbo].[uspLoadLeaveType]", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                //cmd1.Parameters.AddWithValue("@id_employee", EmployeeId);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                dsInasistencias1.tipo_ausencia.Clear();

                adapter1.Fill(dsInasistencias1.tipo_ausencia);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadCategoriaAusencia()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("[dbo].[uspLoadLeaveCategory]", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                dsInasistencias1.categoria_leave.Clear();

                adapter1.Fill(dsInasistencias1.categoria_leave);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void dtInicio_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                dias_solicitados = 0;
                if (dtInicio.EditValue != null && dtFin.EditValue != null)
                {
                    seDiasVacaciones.EditValue = CalculateDays((DateTime)dtInicio.EditValue, (DateTime)dtFin.EditValue);
                    deRegreso.EditValue = CalculateReintegrationDate((DateTime)dtFin.EditValue);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void dtFin_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                dias_solicitados = 0;
                if (dtInicio.EditValue != null && dtFin.EditValue != null)
                {
                    seDiasVacaciones.EditValue = CalculateDays((DateTime)dtInicio.EditValue, (DateTime)dtFin.EditValue);
                    deRegreso.EditValue = CalculateReintegrationDate((DateTime)dtFin.EditValue);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtInicio.EditValue == null)
                {
                    CajaDialogo.Error("Debe seleccionar una fecha inicial");
                    return;
                }

                if (dtFin.EditValue == null)
                {
                    CajaDialogo.Error("Debe seleccionar una fecha final");
                    return;
                }


                if (slueTipoAusencia.EditValue == null)
                {
                    CajaDialogo.Error("Debe seleccionar un tipo de ausencia");
                    return;
                }

                if (seDiasVacaciones.EditValue==null || Convert.ToDecimal(seDiasVacaciones.EditValue)==0)
                {
                    CajaDialogo.Error("Debe de ingresar los días de vacaciones a gozar");
                    return;
                }
                DataOperations dp = new DataOperations();
                switch (transaccionActual)
                {
                    case TransaccionTipo.Nuevo:

                        // Crear un comando SQL para ejecutar el Stored Procedure
                        using (SqlConnection connection = new SqlConnection(dp.ConnectionStringRRHH))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("dbo.uspInsertLeaveV2", connection);
                            command.CommandType = CommandType.StoredProcedure;

                            // Añadir los parámetros del Stored Procedure
                            //command.Parameters.AddWithValue("@name", txtDescripcion.Text);
                            command.Parameters.AddWithValue("@leave_type_id", slueTipoAusencia.EditValue);
                            command.Parameters.AddWithValue("@employee_id", id_employee);
                            command.Parameters.AddWithValue("@department_id", employee.DepartmentId);
                            command.Parameters.AddWithValue("@note", txtNote.Text);
                            command.Parameters.AddWithValue("@date_from", dtInicio.EditValue);
                            command.Parameters.AddWithValue("@date_to", dtFin.EditValue);
                            command.Parameters.AddWithValue("@date_return", deRegreso.EditValue);
                            command.Parameters.AddWithValue("@number_of_days", seDiasVacaciones.EditValue);
                            command.Parameters.AddWithValue("@user_id", userLogged.Id);
                            //command.Parameters.AddWithValue("@categoria_id", slueCategoria.EditValue);
                            command.Parameters.AddWithValue("@categoria_id", DBNull.Value);
                            if(tsAplicado.IsOn)
                                command.Parameters.AddWithValue("@aplicado", 1);
                            else
                                command.Parameters.AddWithValue("@aplicado", 0);
                            // Ejecutar el Stored Procedure
                            command.ExecuteNonQuery();
                            connection.Close();

                            CajaDialogo.InformationAuto();
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case TransaccionTipo.Editar:

                        // Crear un comando SQL para ejecutar el Stored Procedure
                        using (SqlConnection connection = new SqlConnection(dp.ConnectionStringRRHH))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("dbo.[uspUpdateLeaveV2]", connection);
                            command.CommandType = CommandType.StoredProcedure;

                            // Añadir los parámetros del Stored Procedure
                            command.Parameters.AddWithValue("@id", IdDetalle);
                            command.Parameters.AddWithValue("@leave_type_id", slueTipoAusencia.EditValue);
                            command.Parameters.AddWithValue("@note", txtNote.Text);
                            command.Parameters.AddWithValue("@date_from", dtInicio.EditValue);
                            command.Parameters.AddWithValue("@date_to", dtFin.EditValue);
                            command.Parameters.AddWithValue("@date_return", deRegreso.EditValue);
                            command.Parameters.AddWithValue("@number_of_days", seDiasVacaciones.EditValue);
                            command.Parameters.AddWithValue("@user_id", userLogged.Id); 
                            if (tsAplicado.IsOn)
                                command.Parameters.AddWithValue("@aplicado", 1);
                            else
                                command.Parameters.AddWithValue("@aplicado", 0);

                            // Ejecutar el Stored Procedure
                            command.ExecuteNonQuery();
                            connection.Close();

                            CajaDialogo.InformationAuto();
                            this.DialogResult = DialogResult.OK;
                        }


                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDias_EditValueChanged(object sender, EventArgs e)
        {
            //if (dtInicio.EditValue!=null)
            //{
            //    dtFin.EditValue = CalculateEndDate((DateTime)dtInicio.EditValue,Convert.ToDecimal(seDiasVacaciones.EditValue));
            //    deRegreso.EditValue = CalculateReintegrationDate((DateTime)dtFin.EditValue);
            //}
        }



        private double CalculateDays(DateTime startDate, DateTime endDate)
        {
            try
            {
                double daysCount = 0;

                int id_tipo_ausencia = 0;

                if (slueTipoAusencia.EditValue != null)
                {
                    id_tipo_ausencia = (int)slueTipoAusencia.EditValue;
                }

                //if (slueTipoAusencia.EditValue != null)
                //{
                    for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                    {
                        if (id_tipo_ausencia == (int)TipoLeaves.Vacaciones && (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday))
                        {
                            continue; // Saltar fines de semana si el concepto es vacaciones
                        }
                        daysCount += 1;
                    }
                //}

                return daysCount;
            }
            catch (Exception)
            {
                throw;
            }
        }


        private DateTime CalculateReintegrationDate(DateTime endDate)
        {
            try
            {
                DateTime reintegroDate = endDate.AddDays(1);
                int id_tipo =0 ;

                if (slueTipoAusencia.EditValue != null)
                {
                    id_tipo = (int)slueTipoAusencia.EditValue; ;
                 }
                
                //if (slueTipoAusencia.EditValue != null)
                //{
                    // Si el concepto es vacaciones, ajustar la fecha de reintegro para excluir fines de semana
                    if (id_tipo == (int)TipoLeaves.Vacaciones)
                    {
                        while (reintegroDate.DayOfWeek == DayOfWeek.Saturday || reintegroDate.DayOfWeek == DayOfWeek.Sunday)
                        {
                            reintegroDate = reintegroDate.AddDays(1);
                        }
                    }
                //}
                return reintegroDate;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return new DateTime();
            }

        }

        private void slueTipoAusencia_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (slueTipoAusencia.EditValue != null)
                {

                    dias_solicitados = 0;
                    if (dtInicio.EditValue != null && dtFin.EditValue != null)
                    {
                        seDiasVacaciones.EditValue = CalculateDays((DateTime)dtInicio.EditValue, (DateTime)dtFin.EditValue);
                        deRegreso.EditValue = CalculateReintegrationDate((DateTime)dtFin.EditValue);
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        static int IsNumeric(string str)
        {
            if (int.TryParse(str, out int numericValue))
            {
                return numericValue;
            }
            else
            {
                return 0;
            }
        }

        private void deRegreso_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
    }