using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Calidad;
using LOSA.RRHH_Planilla.Capacitacion;
using LOSA.RRHH_Planilla.Capacitacion.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.Planilla.Ausencias
{
    public partial class frmWizardLeaves : DevExpress.XtraEditors.XtraForm
    {
       public List<SeleccionAusenciaEmpleados> empleados_ausencias = new List<SeleccionAusenciaEmpleados>();
        double dias_solicitados = 0;

        private enum TipoLeaves
        {
            LegalLeaves2020 = 1,
            IncapacidadPagada = 2,
            DiasCompensatorios = 3,
            DiasSinPago = 4,
            Vacaciones = 5,
            Incapacidad34Porciento = 6,
            AusenciaSinJustificacion = 7,
            AusentismoLaboralSinPago = 8,
            VacacionesPagadas = 9,
            AusentismoLaboralConPago = 11
        }

        public frmWizardLeaves()
        {
            InitializeComponent();
            CargarDatosEmpleados();
            LoadTipoAusencia();
        }

        public void CargarDatosEmpleados()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsInasistencias1.ausencia_empleados.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetEmployeeFromAusenciasMasivas", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsInasistencias1.ausencia_empleados);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ceSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            var gridView = (GridView)gcEmpleado.FocusedView;
            int conta = dsInasistencias1.ausencia_empleados.Count;

            for (int i = 0; i < conta; i++)
            {
                dsInasistencias.ausencia_empleadosRow row = (dsInasistencias.ausencia_empleadosRow)gridView.GetDataRow(i);
                int r = gridView.GetVisibleRowHandle(i);
                if (r >= 0)
                {
                    //filtered++;
                    if (row != null)
                    {
                        row.seleccionar = ceSeleccionar.Checked;
                    }
                }
                else
                {
                    if (row != null)
                        row.seleccionar = false;
                }
            }

            //Boolean indicador_seleccion = Convert.ToBoolean(ceSeleccionar.EditValue);

            //foreach (var item in dsInasistencias1.ausencia_empleados)
            //{
            //    item.seleccionar = indicador_seleccion;
            //}
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                empleados_ausencias = new List<SeleccionAusenciaEmpleados>();

                // Recorrer cada fila visible en el GridView usando foreach
                foreach (var rowHandle in Enumerable.Range(0, gvEmployee.DataRowCount))
                {
                    // Obtener el valor del campo "Seleccionar" en la fila actual
                    bool isSelected = Convert.ToBoolean(gvEmployee.GetRowCellValue(rowHandle, "seleccionar"));

                    // Si el valor es true, marcar la fila como seleccionada
                    if (isSelected)
                    {
                        DataRow row = gvEmployee.GetDataRow(rowHandle);

                        empleados_ausencias.Add(new SeleccionAusenciaEmpleados
                        {
                            Id = Convert.ToInt32(row["id_employee"].ToString()),
                            Codigo = row["barcode"].ToString(),
                            Nombre = row["nombre"].ToString(),
                            DepartmentId = Convert.ToInt32(row["department_id"].ToString()),
                            Department = row["department"].ToString(),
                            JobId = Convert.ToInt32(row["job_id"].ToString()),
                            JobTitle = row["job_title"].ToString(),
                        });
                    }
                }

                if (empleados_ausencias.Count>0)
                {
                    CajaDialogo.Information($"Se han seleccionado {empleados_ausencias.Count} registro(s)");
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            nfAusencias.SelectedPage = npEmpleados;
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            try
            {
                empleados_ausencias = new List<SeleccionAusenciaEmpleados>();

                // Recorrer cada fila visible en el GridView usando foreach

                foreach (dsInasistencias.ausencia_empleadosRow row1 in dsInasistencias1.ausencia_empleados.Rows)
                {
                    if (row1.seleccionar)
                    {
                        empleados_ausencias.Add(new SeleccionAusenciaEmpleados
                        {
                            Id = row1.id_employee,
                            Codigo = row1.barcode,
                            Nombre = row1.nombre,
                            DepartmentId = row1.department_id,
                            Department = row1.department,
                            JobId = row1.job_id,
                            JobTitle = row1.job_title,
                        });
                    }
                }

                //foreach (var rowHandle in Enumerable.Range(0, gvEmployee.DataRowCount))
                //{
                //    // Obtener el valor del campo "Seleccionar" en la fila actual
                //    bool isSelected = Convert.ToBoolean(gvEmployee.GetRowCellValue(rowHandle, "seleccionar"));

                //    // Si el valor es true, marcar la fila como seleccionada
                //    if (isSelected)
                //    {
                //        DataRow row = gvEmployee.GetDataRow(rowHandle);

                //        empleados_ausencias.Add(new SeleccionAusenciaEmpleados
                //        {
                //            Id = Convert.ToInt32(row["id_employee"].ToString()),
                //            Codigo = row["barcode"].ToString(),
                //            Nombre = row["nombre"].ToString(),
                //            DepartmentId = Convert.ToInt32(row["department_id"].ToString()),
                //            Department = row["department"].ToString(),
                //            JobId = Convert.ToInt32(row["job_id"].ToString()),
                //            JobTitle = row["job_title"].ToString(),
                //        });
                //    }
                //}


                if (empleados_ausencias.Count==0)
                {
                    CajaDialogo.Error("Debes Seleccionar por lo menos un empleado");
                    return;
                }

                 //CajaDialogo.Information($"Se han seleccionado {empleados_ausencias.Count} registro(s)");
                 nfAusencias.SelectedPage = npAusencias;
               
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

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

        private void seDiasVacaciones_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
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

                if (seDiasVacaciones.EditValue == null || Convert.ToDecimal(seDiasVacaciones.EditValue) == 0)
                {
                    CajaDialogo.Error("Debe de ingresar los días de vacaciones a gozar");
                    return;
                }


                foreach (var item in empleados_ausencias)
                {
                    item.FechaInicio = dtInicio.DateTime;
                    item.FechaFin = dtFin.DateTime;
                    item.FechaRegreso = deRegreso.DateTime;
                    item.TipoAusenciaId = (int)slueTipoAusencia.EditValue;
                    item.TipoAusencia =  slueTipoAusencia.Text;
                    item.DiasSolicitadosVacaciones = Convert.ToInt32( seDiasVacaciones.EditValue);
                    item.AplicadoPlanilla=(bool)tsAplicado.EditValue;
                    item.Notas = txtNote.Text;
                   
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
         
            }
        }

        private void dtInicio_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                dias_solicitados = 0;

                //if (slueTipoAusencia.EditValue==null)
                //{
                //    CajaDialogo.Error("Debe seleccionar una ausencia");
                //    dtInicio.EditValue = null;
                //    return;
                //}

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

        private double CalculateDays(DateTime startDate, DateTime endDate)
        {
            try
            {
                double daysCount = 0;

                int id_tipo_ausencia = 0;

                HashSet<DateTime> holidays = new HashSet<DateTime> {
                    new DateTime(startDate.Year, 1, 1), // Fin de Año
                    new DateTime(startDate.Year+1, 1, 1), // Fin de Año
                    new DateTime(startDate.Year, 12, 25), // Navidad
                };


                if (slueTipoAusencia.EditValue != null)
                {
                    id_tipo_ausencia = (int)slueTipoAusencia.EditValue;
                }

                if (id_tipo_ausencia == (int)TipoLeaves.Vacaciones)
                {
                    for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                    {
                        if ( holidays.Contains(date) ||  date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday )
                        {
                            continue; // Saltar fines de semana si el concepto es vacaciones
                        }
                        daysCount += 1;
                    }
                }
                else
                {
                    for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                    {
                        daysCount += 1;
                    }
                }


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
                int id_tipo = 0;

                HashSet<DateTime> holidays = new HashSet<DateTime> {
                    new DateTime(endDate.Year, 12, 25), // Navidad
                    new DateTime(endDate.Year, 1, 1) // Fin de Año
                };


                if (slueTipoAusencia.EditValue != null)
                {
                    id_tipo = (int)slueTipoAusencia.EditValue; ;
                }

                if (id_tipo == (int)TipoLeaves.Vacaciones)
                {
                    while (reintegroDate.DayOfWeek == DayOfWeek.Saturday || reintegroDate.DayOfWeek == DayOfWeek.Sunday || holidays.Contains(reintegroDate))
                    {
                        reintegroDate = reintegroDate.AddDays(1);
                    }
                }

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
                else
                {
                    CajaDialogo.Error("Debe seleccionar una ausencia");
                    return;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}