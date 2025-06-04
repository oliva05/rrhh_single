using ACS.Classes;
using Devart.Data.PostgreSql;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using LOSA.Clases;
using LOSA.MigracionACS.RRHH.Reportes;
using LOSA.RecepcionMP;
using LOSA.RRHH_Planilla.Planilla.Ausencias;
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
 

namespace LOSA.RRHH_Planilla.Planilla.Inasistencias
{
    public partial class frmLeavesHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin userLogged= new UserLogin();
        DateTime Now;
        DataOperations dp;
        public frmLeavesHome(UserLogin pUser)
        {
            InitializeComponent();
            CargarEmpleados();
            userLogged= new UserLogin();
            dp = new DataOperations();
            Now = dp.Now();
            dtDesde.DateTime = Now.AddDays(-8);
            dtHasta.DateTime = Now.AddDays(8);
        }

        public void CargarEmpleados()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsInasistencias1.hr_employee.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadEmployeeFromLeaves", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //da.SelectCommand.Parameters.Add("@barcode", SqlDbType.VarChar).Value = codigoEmpleado;
                    da.Fill(dsInasistencias1.hr_employee);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarDatos_Click(object sender, EventArgs e)
        {
            if (slueEmployee.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar a un empleado");
                return;
            }

            if (dtDesde.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar a una fecha inicial");
                return;
            }

            if (dtHasta.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar a una fecha final");
                return;
            }
            LoadData();
        }

        private void LoadData()
        {
            if (dtDesde.DateTime.Year<2000 || dtHasta.DateTime.Year < 2000)
            {
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand(@"uspLoadResumenInasistencia", con);
                cmd.CommandType= CommandType.StoredProcedure;
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pfechadesde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@pfechahasta", dtHasta.EditValue);
                cmd.Parameters.AddWithValue("@id_employee", slueEmployee.EditValue);
                dsInasistencias1.vacaciones.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsInasistencias1.vacaciones);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnDetail_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //try
            //{
            //    frmLeaveDetail frm = new frmLeaveDetail((int)slueEmployee.EditValue);

            //    frm.ShowDialog();

            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (slueEmployee.EditValue==null)
                {
                    CajaDialogo.Error("Debe seleccionar a un empleado");
                    return;
                }

                frmLeaveCRUD frm = new frmLeaveCRUD((int)slueEmployee.EditValue,frmLeaveCRUD.TransaccionTipo.Nuevo,userLogged, 0);

                if (frm.ShowDialog()== DialogResult.OK)
                {
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnGestionar_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (dsInasistencias.vacacionesRow)gvResumenInasistencia.GetFocusedDataRow();

            if (row != null)
            {

                if (row.id_estado == 2)
                {
                    CajaDialogo.Error("La transaccion seleccionada se encuentra anulada");
                    return;
                }
                frmLeaveGestionarEstado frm = new  frmLeaveGestionarEstado(row.id,row.id_estado);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (slueEmployee.EditValue==null)
                {
                    CajaDialogo.Error("Debe de seleccionar un empleado");
                    return;
                }
                frmLeaveDetail frm = new frmLeaveDetail((int)slueEmployee.EditValue);

                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            try
            {

                if (gvResumenInasistencia.RowCount > 0)
                {

                    string filePath = "ResumenAusencias.xlsx";

                    // Configurar opciones de exportación
                    XlsxExportOptionsEx exportOptions = new XlsxExportOptionsEx();
                    //exportOptions.ExportedRowType = ExportedRowType.All;
                    exportOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG;
                    exportOptions.SheetName = "Ausencias";

                    // Ocultar la columna "Gestion de Estado" durante la exportación
                    colGestionarEstado.Visible = false;

                    gvResumenInasistencia.ExportToXlsx(filePath, exportOptions);

                    // Mostrar la columna "Gestion de Estado" durante la exportación
                    colGestionarEstado.Visible = true;

                    DialogResult result = MessageBox.Show("¿Deseas abrir el archivo?", "Abrir Archivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });

                    }
                }
            }

            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gcResumenInasistencia.FocusedView;
            var row = (dsInasistencias.vacacionesRow)gridview.GetFocusedDataRow();

            frmLeaveCRUD frm = new frmLeaveCRUD((int)slueEmployee.EditValue, frmLeaveCRUD.TransaccionTipo.Editar, userLogged, row.id);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}