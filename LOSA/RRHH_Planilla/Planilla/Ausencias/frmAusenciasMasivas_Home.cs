using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.RRHH_Planilla.Planilla.ImportarPlanilla;
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
using static LOSA.FromAMS.dsControlInv_AMS;

namespace LOSA.RRHH_Planilla.Planilla.Ausencias
{
    public partial class frmAusenciasMasivas_Home : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLog= new UserLogin();
        public frmAusenciasMasivas_Home(UserLogin pUsuario)
        {
            InitializeComponent();
            usuarioLog = pUsuario;
            LoadTipoAusencia();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {                
                 frmWizardLeaves form = new frmWizardLeaves();

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        foreach (var item in form.empleados_ausencias)
                        {
                            // Crear una nueva fila
                            DataRow row = dsInasistencias1.ausencias_masivas.NewRow();
                            row["employee_id"] = item.Id;
                            row["code"] = item.Codigo;
                            row["date_from"] = item.FechaInicio;
                            row["date_to"] = item.FechaFin;
                            row["date_return"] = item.FechaRegreso;
                            row["number_of_days"] = item.DiasSolicitadosVacaciones;
                            row["nombre"] = item.Nombre;
                            row["puesto"] = item.JobTitle;
                            row["note"] = item.Notas;
                            row["tipo_ausencia"] = item.TipoAusencia;
                            row["tipo_ausencia_id"] = item.TipoAusenciaId;
                            row["department"] = item.Department;
                            row["aplicado"] = item.AplicadoPlanilla;
                            row["department_id"] = item.DepartmentId;

                            // Agregar la fila al DataTable
                            dsInasistencias1.ausencias_masivas.Rows.Add(row);
                        }
                        btnSave.Enabled = true;
                    }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var result = CajaDialogo.Pregunta("Esta seguro de aplicar los cambios?");

                if (result == DialogResult.Yes)
                {
                    DataOperations dp = new DataOperations();
                    bool proceso_terminado = false;

                    using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                    {
                        cnx.Open();
                        SqlCommand cmd = new SqlCommand("dbo.uspProcesarLeavesMasivas", cnx);
                        //proceso_terminado = false;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@user_id", usuarioLog.UserId);

                        // Crear un DataTable
                        DataTable dt_leaves = new DataTable("EmployeeLeave");

                        // Definir las columnas de acuerdo a los campos mencionados
                        dt_leaves.Columns.Add("employee_id", typeof(int)); // INT
                        dt_leaves.Columns.Add("leave_type_id", typeof(int)); // INT
                        dt_leaves.Columns.Add("department_id", typeof(int)); // INT
                        dt_leaves.Columns.Add("note", typeof(string)); // VARCHAR(255)
                        dt_leaves.Columns.Add("date_from", typeof(DateTime)); // DATETIME
                        dt_leaves.Columns.Add("date_to", typeof(DateTime)); // DATETIME
                        dt_leaves.Columns.Add("date_return", typeof(DateTime)); // DATETIME
                        dt_leaves.Columns.Add("number_of_days", typeof(int)); // INT
                        dt_leaves.Columns.Add("aplicado", typeof(bool)); // BIT

                        foreach (var item in dsInasistencias1.ausencias_masivas)
                        {
                            proceso_terminado = false;
                            // Agregar algunas filas de ejemplo
                            dt_leaves.Rows.Add(item.employee_id, item.tipo_ausencia_id, item.department_id, item.note, item.date_from, item.date_to, item.date_return, item.number_of_days, item.aplicado);
                            proceso_terminado = true;
                        }


                        SqlParameter parameter = cmd.Parameters.AddWithValue("@leaves", dt_leaves);
                        parameter.SqlDbType = SqlDbType.Structured;
                        parameter.TypeName = "dbo.udttLeavesMasivas";

                        cmd.ExecuteNonQuery();

                        cnx.Close();

                        proceso_terminado = true;
                    }

                    if (proceso_terminado)
                    {
                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        dsInasistencias1.ausencias_masivas.Clear();
                        btnSave.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}