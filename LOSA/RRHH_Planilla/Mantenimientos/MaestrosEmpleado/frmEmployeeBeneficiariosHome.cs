using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases.Colaborador;
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

namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    public partial class frmEmployeeBeneficiariosHome : DevExpress.XtraEditors.XtraForm
    {
        int employee_id = 0;
        bool crear_empleado=false;
       

       public List<Hr_Beneficiario> beneficiarios = new List<Hr_Beneficiario>();
        public frmEmployeeBeneficiariosHome(int pEmployeeId, bool editable, bool pCrearEmpleado, List<Hr_Beneficiario> pBeneficiarios)
        {
            InitializeComponent();
            this.employee_id = pEmployeeId;
            this.crear_empleado=pCrearEmpleado;

            if (crear_empleado)
            {
                foreach (var item in pBeneficiarios)
                {
                    DataRow dr = dsMaestroEmpleados1.employee_beneficiarios.NewRow();

                    dr["id"] = 0;
                    dr["identidad"] = item.Identidad;
                    dr["nombre"] = item.Nombre;
                    dr["porcentaje"] = item.Porcentaje;

                    dsMaestroEmpleados1.employee_beneficiarios.Rows.Add(dr);
                }

                beneficiarios = pBeneficiarios;
                //colDelete.Visible = false;
            }
            else
            {
              CargarDatos();
            }

            if (!editable)
            {
                //colEditar.Visible = false;
                colDelete.Visible = false;
                btnSave.Enabled = false;
                colnombre.OptionsColumn.ReadOnly = true  ;
                colidentidad.OptionsColumn.ReadOnly = true;
                colporcentaje.OptionsColumn.ReadOnly = true;
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dsMaestroEmpleados1.employee_beneficiarios.Rows.Count > 0)
            {
                if ((decimal)colporcentaje.SummaryItem.SummaryValue > 100)
                {
                    CajaDialogo.Error("Debe de distribuir bien los porcentajes de los beneficiarios, ya que excede el 100%");
                    return;
                }

                if ((decimal)colporcentaje.SummaryItem.SummaryValue >= 0 && (decimal)colporcentaje.SummaryItem.SummaryValue < 100)
                {
                    CajaDialogo.Error("Debe de distribuir bien los porcentajes de los beneficiarios, ya que no cumple el 100%");
                    return;
                }

               

                if (crear_empleado)
                {
                    beneficiarios = new List<Hr_Beneficiario>();

                    foreach (var item in dsMaestroEmpleados1.employee_beneficiarios)
                    {
                        beneficiarios.Add(new Hr_Beneficiario { 
                            Identidad=item.identidad,
                            Porcentaje=item.porcentaje.ToString(),
                            Nombre=item.nombre,
                        });
                    }

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    foreach (var item in dsMaestroEmpleados1.employee_beneficiarios)
                    {
                        DataOperations dp = new DataOperations();

                        using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                        {
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("uspInsertEmployeeBeneficiarios", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_employee", employee_id);
                            cmd.Parameters.AddWithValue("@identidad", item.identidad);
                            cmd.Parameters.AddWithValue("@nombre", item.nombre);
                            cmd.Parameters.AddWithValue("@porcentaje", item.porcentaje.ToString() + "%");
                            cmd.Parameters.AddWithValue("@id", item.id);

                            cmd.ExecuteNonQuery();

                            cnx.Close();
                        }
                    }
                        CajaDialogo.Information("Datos guardados exitósamente!");

                }

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }

        }

        public void CargarDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMaestroEmpleados1.employee_beneficiarios.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadBeneficiariosByEmployee", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@id_employee",employee_id);

                    da.Fill(dsMaestroEmpleados1.employee_beneficiarios);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        private void btnEdit_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsMaestroEmpleados.employee_childrenRow)gvBeneficiarios.GetFocusedDataRow();

                if (row != null)
                {
                    frmEmployeeChildren_CRUD frm = new frmEmployeeChildren_CRUD(row.id, frmEmployeeChildren_CRUD.TransaccionCRUD.Editar);

                    if (frm.ShowDialog()== DialogResult.OK)
                    {
                        CargarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDelete_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                if (crear_empleado)
                {
                    gvBeneficiarios.DeleteRow(gvBeneficiarios.FocusedRowHandle);

                    beneficiarios = new List<Hr_Beneficiario>();

                    foreach (var item in dsMaestroEmpleados1.employee_beneficiarios)
                    {
                        beneficiarios.Add(new Hr_Beneficiario
                        {
                            Nombre = item.nombre,
                            Identidad = item.identidad,
                            Porcentaje = item.porcentaje.ToString(),
                        });
                    }
                }
                else
                {

                    var row = (dsMaestroEmpleados.employee_beneficiariosRow)gvBeneficiarios.GetFocusedDataRow();

                    DataOperations dp = new DataOperations();
                    SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                    var respuesta = CajaDialogo.Pregunta("¿Desea desactivar el registro?");

                    if (respuesta == DialogResult.Yes)
                    {

                        using (SqlCommand cmd = new SqlCommand("dbo.[uspDisableEmployeeBenefi]", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                            cmd.ExecuteNonQuery();
                            cnx.Close();
                        }

                        CajaDialogo.Information("Datos desactivados!");
                        CargarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        static string CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;

            // Calcular la diferencia en años, meses y días
            int años = fechaActual.Year - fechaNacimiento.Year;
            int meses = fechaActual.Month - fechaNacimiento.Month;
            int dias = fechaActual.Day - fechaNacimiento.Day;

            // Ajustar si el cumpleaños no ha ocurrido este año
            if (meses < 0 || (meses == 0 && dias < 0))
            {
                años--;
                meses += 12; // Añadir 12 meses para ajustar el valor
            }

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(fechaActual.Year, (fechaActual.Month == 1) ? 12 : fechaActual.Month - 1);
            }

            // Devolver años o meses según corresponda
            if (años > 0)
            {
                return años == 1 ? "1 año" : años + " años";
            }
            else
            {
                return meses == 1 ? "1 mes" : meses + " meses";
            }
        }

        

        private void gvBeneficiarios_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
          

            // Verificar si la columna actual es la que debe ser obligatoria
            if (gvBeneficiarios.FocusedColumn.FieldName == "identidad") // Cambiar por el nombre del campo
            {
                // Validar que el valor no sea nulo ni vacío
                if (string.IsNullOrEmpty( e.Value as string))
                {
                    e.Valid = false; // La validación falla
                    e.ErrorText = "Este campo es obligatorio y no puede estar vacío.";
                }
            }

            // Verificar si la columna actual es la que debe ser obligatoria
            if (gvBeneficiarios.FocusedColumn.FieldName == "nombre") // Cambiar por el nombre del campo
            {
                // Validar que el valor no sea nulo ni vacío
                if (string.IsNullOrEmpty(e.Value as string))
                {
                    e.Valid = false; // La validación falla
                    e.ErrorText = "Este campo es obligatorio y no puede estar vacío.";
                }
            }

            // Verificar si la columna actual es la que debe ser obligatoria
            if (gvBeneficiarios.FocusedColumn.FieldName == "porcentaje") // Cambiar por el nombre del campo
            {
                // Validar que el valor no sea nulo ni vacío
                if (e.Value == null)
                {
                    e.Valid = false; // La validación falla
                    e.ErrorText = "Este campo es obligatorio y no puede estar vacío.";
                }
            }
        }
    }
}