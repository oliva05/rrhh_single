using ACS.Classes;
using DevExpress.XtraEditors;
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
    public partial class frmEmployeeChildrenHome : DevExpress.XtraEditors.XtraForm
    {
        int employee_id = 0;
        bool crear_empleado=false;
       

       public List<Hr_Employee_Children> hijos = new List<Hr_Employee_Children>();
        public frmEmployeeChildrenHome(int pEmployeeId, bool editable, bool pCrearEmpleado, List<Hr_Employee_Children> phijos)
        {
            InitializeComponent();
            this.employee_id = pEmployeeId;
            this.crear_empleado=pCrearEmpleado;

            if (crear_empleado)
            {
                foreach (var item in phijos)
                {
                    DataRow dr = dsMaestroEmpleados1.employee_children.NewRow();

                    dr[0]= 0;
                    dr[1]= item.Genero;
                    dr[2]= item.FechaNacimiento;
                    dr[3]= item.Edad;

                    dsMaestroEmpleados1.employee_children.Rows.Add(dr);
                }

                hijos = phijos;
                colEditar.Visible=false;
            }
            else
            {
              CargarDatos();
            }

            if (!editable)
            {
                colEditar.Visible = false;
                colDelete.Visible = false;
                btnAdd.Enabled = false;
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            frmEmployeeChildren_CRUD frm = new frmEmployeeChildren_CRUD(frmEmployeeChildren_CRUD.TransaccionCRUD.Nuevo,employee_id, crear_empleado);
            
            if (frm.ShowDialog() == DialogResult.OK)
            {

                if (crear_empleado==true)
                {
                    hijos.Add(frm.hijo);

                    gvHijos.AddNewRow();

                    int rowHandle = gvHijos.GetRowHandle(gvHijos.DataRowCount);
                   
                    if (gvHijos.IsNewItemRow(rowHandle))
                    {
                        gvHijos.SetRowCellValue(rowHandle, gvHijos.Columns[0], 0);
                        gvHijos.SetRowCellValue(rowHandle, gvHijos.Columns[1], frm.hijo.Genero);
                        gvHijos.SetRowCellValue(rowHandle, gvHijos.Columns[2], frm.hijo.FechaNacimiento);
                        gvHijos.SetRowCellValue(rowHandle, gvHijos.Columns[3], CalcularEdad((DateTime)frm.hijo.FechaNacimiento));
                    }
                }
                else
                {
                    hijos = new List<Hr_Employee_Children>();

                    foreach (var item in dsMaestroEmpleados1.employee_children)
                {
                    hijos.Add(new Hr_Employee_Children { 
                            Genero=item.genero,
                            FechaNacimiento=item.fecha_nacimiento                    
                        });
                }
                CargarDatos();
                }

            }
        }

        public void CargarDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMaestroEmpleados1.employee_children.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadEmployee_children", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@id_employee",employee_id);

                    da.Fill(dsMaestroEmpleados1.employee_children);
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
                var row = (dsMaestroEmpleados.employee_childrenRow)gvHijos.GetFocusedDataRow();

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
                    gvHijos.DeleteRow(gvHijos.FocusedRowHandle);

                    hijos = new List<Hr_Employee_Children>();

                    foreach (var item in dsMaestroEmpleados1.employee_children)
                    {
                        hijos.Add(new Hr_Employee_Children
                        {
                            Genero = item.genero,
                            FechaNacimiento = item.fecha_nacimiento,
                            Edad=item.edad
                        });
                    }
                }
                else
                {

                    var row = (dsMaestroEmpleados.employee_childrenRow)gvHijos.GetFocusedDataRow();

                    DataOperations dp = new DataOperations();
                    SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                    var respuesta = CajaDialogo.Pregunta("¿Desea desactivar el registro?");

                    if (respuesta == DialogResult.Yes)
                    {

                        using (SqlCommand cmd = new SqlCommand("dbo.uspDisableEmployeeChildren", cnx))
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
    }
}