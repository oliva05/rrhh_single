using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.RecepcionMP;
using LOSA.RRHH_Planilla.Capacitacion.Model;
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

namespace LOSA.RRHH_Planilla.Capacitacion
{
    public partial class frmSeleccionEmpleadosFromCapacitacion : DevExpress.XtraEditors.XtraForm
    {
        public List<SeleccionEmpleados> empleados = new List<SeleccionEmpleados>();
        public frmSeleccionEmpleadosFromCapacitacion(int pIdCapacitacion)
        {
            InitializeComponent();

            CargarDatos(pIdCapacitacion);
        }

        public void CargarDatos(int pIdCapacitacion)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsCapacitacion1.capacitacion_empleados.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.[uspGetEmployeeFromCapacitacionV2]", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@IdCapacitacion", pIdCapacitacion);
                    da.Fill(dsCapacitacion1.capacitacion_empleados);
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                empleados = new List<SeleccionEmpleados>();

                // Recorrer cada fila visible en el GridView usando foreach
                foreach (dsCapacitacion.capacitacion_empleadosRow item in dsCapacitacion1.capacitacion_empleados.Rows)
                {
                    

                    // Si el valor es true, marcar la fila como seleccionada
                    if (item.seleccionar)
                    {
                        empleados.Add(new SeleccionEmpleados
                        {
                            Id = item.id_employee,
                            Codigo = item.barcode,
                            Nombre = item.nombre,
                            DepartmentId = item.department_id,
                            Department = item.department,
                            JobId = item.job_id,
                            JobTitle = item.job_title
                        });
                    }
                }


                //// Recorrer cada fila visible en el GridView usando foreach
                //foreach (var rowHandle in Enumerable.Range(0, gvEmployee.DataRowCount))
                //{
                //    // Obtener el valor del campo "Seleccionar" en la fila actual
                //    bool isSelected = Convert.ToBoolean(gvEmployee.GetRowCellValue(rowHandle, "seleccionar"));

                //    // Si el valor es true, marcar la fila como seleccionada
                //    if (isSelected)
                //    {
                //        DataRow row = gvEmployee.GetDataRow(rowHandle);

                //        empleados.Add(new SeleccionEmpleados
                //        {
                //            Id = Convert.ToInt32( row["id_employee"].ToString()),
                //            Codigo = row["barcode"].ToString(),
                //            Nombre = row["nombre"].ToString(),
                //            DepartmentId = Convert.ToInt32(row["department_id"].ToString()),
                //            Department = row["department"].ToString(),
                //            JobId = Convert.ToInt32(row["job_id"].ToString()),
                //            JobTitle = row["job_title"].ToString(),
                //        });
                //    }
                //}

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
 
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            Boolean indicador_seleccion = Convert.ToBoolean(ceSeleccionar.EditValue);
           
            foreach (var item in dsCapacitacion1.capacitacion_empleados)
            {
                item.seleccionar = indicador_seleccion;
            }
        }

        private void gvEmployee_DoubleClick(object sender, EventArgs e)
        {
            var gridview = (GridView)gcEmpleado.FocusedView;
            var row = (dsCapacitacion.capacitacion_empleadosRow)gridview.GetFocusedDataRow();
            
            if (row.seleccionar)
            {
                row.seleccionar = false;
            }
            else
            {
                row.seleccionar=true;
            }

        }
    }
}