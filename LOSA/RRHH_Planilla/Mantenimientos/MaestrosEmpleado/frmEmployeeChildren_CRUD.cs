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
    public partial class frmEmployeeChildren_CRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum TransaccionCRUD
        {
            Nuevo=1,
            Editar=2,
            Nuevo_CrearEmpleado=3
        }

       public Hr_Employee_Children hijo = new Hr_Employee_Children();
        int id_hijoActual = 0;
        int employee_id = 0;
        bool crear_empleado = false;

        TransaccionCRUD transaccionActual;
        public frmEmployeeChildren_CRUD(TransaccionCRUD pTransaccionActual, int pEmployee_id,bool pCrearEmpleado)
        {
            InitializeComponent();
            transaccionActual = pTransaccionActual;
 
            employee_id=pEmployee_id;

            crear_empleado=pCrearEmpleado;
        }

        public frmEmployeeChildren_CRUD(int pId_hijo, TransaccionCRUD pTransaccionActual)
        {
            InitializeComponent();
            transaccionActual = pTransaccionActual;
            id_hijoActual = pId_hijo;
   

            hijo.RecuperaRegistro(id_hijoActual);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbxGenero.EditValue== null)
                {
                    CajaDialogo.Error("Debe seleccionar un genero");
                    return;
                }

                if (deFechaNacimiento.EditValue == null)
                {
                    CajaDialogo.Error("Debe seleccionar una fecha de nacimiento");
                    return;
                }

                if (deFechaNacimiento.DateTime > DateTime.Now)
                {
                    CajaDialogo.Error("Debe seleccionar una fecha correcta");
                    return;
                }

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                switch (transaccionActual)
                {
                    case TransaccionCRUD.Nuevo:

                        if (crear_empleado == true)
                        {
                            hijo = new Hr_Employee_Children
                            {
                                Genero = cbxGenero.Text,
                                FechaNacimiento = (DateTime?)deFechaNacimiento.EditValue,
                                Edad = CalcularEdad(deFechaNacimiento.DateTime)
                            };
                        }
                        else
                        {

                            using (SqlCommand cmd = new SqlCommand("dbo.[uspInsertEmployee_children]", cnx))
                            {
                                cnx.Open();
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = cbxGenero.Text;
                                cmd.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = deFechaNacimiento.EditValue;
                                cmd.Parameters.Add("@id_employee", SqlDbType.Int).Value = employee_id;

                                cmd.ExecuteNonQuery();

                                cnx.Close();
                            }

                            CajaDialogo.Information("Datos Guardados Exitosamente!");
                        }


                        this.DialogResult = DialogResult.OK;
                        break;
                    case TransaccionCRUD.Editar:

                        using (SqlCommand cmd = new SqlCommand("dbo.uspUpdateEmployee_children", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id_hijoActual;
                            cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = cbxGenero.Text;
                            cmd.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = deFechaNacimiento.EditValue;

                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Actualizados");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case TransaccionCRUD.Nuevo_CrearEmpleado:
 

                    break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void frmEmployeeChildren_CRUD_Load(object sender, EventArgs e)
        {
            if (transaccionActual== TransaccionCRUD.Editar)
            {
                cbxGenero.Text =hijo.Genero;
                deFechaNacimiento.EditValue =hijo.FechaNacimiento;
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