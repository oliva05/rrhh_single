using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Mantenimientos;
using LOSA.Presupuesto;
using LOSA.Clases.Colaborador;

namespace LOSA.MigracionACS.RRHH.RelojFace
{
    public partial class frmResumenHorasExtraTrabajadas : DevExpress.XtraEditors.XtraForm
    {
        public DateTime inicial;
        public DateTime final;
        public int SelectedPage;
        public int id_empleado;
        int tipoBusqueda;
        DataOperations dp;
        HrEmployee EmpleadoActual;
        DateTime FechaActual;

        public frmResumenHorasExtraTrabajadas(HrEmployee pEmpleadoActual, DateTime pDesde, DateTime pHasta)
        {
            InitializeComponent();
            EmpleadoActual = pEmpleadoActual;
            lblEmpleado.Text = pEmpleadoActual.Name;

            dp = new DataOperations();
            FechaActual = dp.Now();

            dt_inicial.EditValue = FechaActual.AddDays(-15);
            dt_final.EditValue = FechaActual;

            if(pDesde.Year >= 2020)
            {
                dt_inicial.DateTime = pDesde;
                if(pHasta.Year >= 2020)
                {
                    dt_final.DateTime = pHasta;
                }
            }

            //LoadMarcas();
            Cargar_reporte();
        }
        public void LoadMarcas()
        {
            string query = @"sp_load_empleados_administracion";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsFaceReloj.Empleados.Clear();
                da.Fill(dsFaceReloj.Empleados);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        //public void load_turnos()
        //{
        //    string query = @"sp_load_empleados_turnos";
        //    SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
        //    try
        //    {
        //        cn.Open();
        //        SqlCommand cmd = new SqlCommand(query, cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        dsFaceReloj.Empleados.Clear();
        //        da.Fill(dsFaceReloj.Empleados);
        //        cn.Close();
        //    }
        //    catch (Exception ex)
        //    {

        //        CajaDialogo.Error(ex.Message);
        //    }
        //}

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            //SelectedPage = tabPane1.SelectedPageIndex;
            //grd_empleados.EditValue = null;
            //if (SelectedPage == 1)
            //{
            //    load_turnos();
            //}
            //else
            //{
            //    LoadMarcas();
            //}
            
        }

        private void tggTodos_Toggled(object sender, EventArgs e)
        {
            //if (tggTodos.IsOn)
            //{
            //    tipoBusqueda = 1;
            //    grd_empleados.Enabled = true;

            //}
            //else
            //{
            //    tipoBusqueda = 0;
            //    grd_empleados.Enabled = false;
            //}
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Cargar_reporte();
        }

        public void Cargar_reporte()
        {
            if (dt_inicial.EditValue == null)
            {
                CajaDialogo.Error("Debe seleccionar fecha inicial.");
                return;
            }
            if (dt_final.EditValue == null)
            {
                dt_final.EditValue = dp.Now();
                //CajaDialogo.Error("Debe seleccionar fecha final.");
                //return;
            }
            
            if (Convert.ToDateTime(dt_inicial.EditValue) > Convert.ToDateTime(dt_final.EditValue))
            {
                CajaDialogo.Error("La fecha inicial no puede ser menor que la fecha final para generar el reporte.");
                return;
            }

            try
            {
                string query = @"";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd;

                #region codigo Anterior
                //if (SelectedPage == 0)
                //{          //Administracion

                //    if (tipoBusqueda == 0)
                //    {   // Buscar Todos los empleados
                //        query = @"sp_load_marcas_administracion";
                //        cmd = new SqlCommand(query, cn);
                //        cmd.CommandType = CommandType.StoredProcedure;

                //    }
                //    else
                //    {  // Buscar uno en especifico.
                //        query = @"sp_load_marcas_administracion_filtro_empleado";
                //        cmd = new SqlCommand(query, cn);
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.Parameters.AddWithValue("@aqf", grd_empleados.EditValue);
                //    }
                //}                               
                //else
                //{   //Turnos
                //    if (tipoBusqueda == 0)
                //    {   // Buscar Todos los empleados
                //        query = @"sp_load_marcas_turno";
                //        cmd = new SqlCommand(query, cn);
                //        cmd.CommandType = CommandType.StoredProcedure;
                //    }
                //    else
                //    {  // Buscar uno en especifico.
                //        query = @"sp_load_marcas_turno_filtro_empleado";
                //        cmd = new SqlCommand(query, cn);
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.Parameters.AddWithValue("@aqf", grd_empleados.EditValue);
                //    }
                //}
                #endregion


                // Buscar uno en especifico.
                //Turnos
                //query = @"sp_load_marcas_turno_filtro_empleado";
                //cmd = new SqlCommand(query, cn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@aqf", grd_empleados.EditValue);


                //query = @"sp_load_marcas_administracion_filtro_empleado";
                query = @"[dbo].[spGetMarcasEmpleado]";
                cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo_emp", EmpleadoActual.Barcode);
                cmd.Parameters.AddWithValue("@dt_inicial", dt_inicial.EditValue);
                cmd.Parameters.AddWithValue("@dt_final", dt_final.EditValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                dsFaceReloj.Administracion.Clear();
                da.Fill(dsFaceReloj.Administracion);
                //dsFaceReloj.Turnos.Clear();
                //da.Fill(dsFaceReloj.Turnos);

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnexport_Click(object sender, EventArgs e)
        {
            
        }

        private void grd_empleados_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_Admin.FocusedView;
                var row = (dsFaceReloj.AdministracionRow)gridView.GetFocusedDataRow();

                frm_Operaciones_Marcas frm = new frm_Operaciones_Marcas(row.serial, row.Code_ODOO);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Cargar_reporte();
                }
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdMoreDetails_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //
            var gridView = (GridView)grd_Admin.FocusedView;
            var row = (dsFaceReloj.AdministracionRow)gridView.GetFocusedDataRow();

            frmDetalleMarcasFaceID frm = new frmDetalleMarcasFaceID(row.Name, row.fecha, row.Code);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void dt_inicial_EditValueChanged(object sender, EventArgs e)
        {
            if (dt_inicial.EditValue != null)
            {
                Cargar_reporte();
            }
            
        }

        private void dt_final_EditValueChanged(object sender, EventArgs e)
        {
            //if (dt_inicial.EditValue != null)
            //{
            //    Cargar_reporte();
            //}
        }

        private void cmdDeleteButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ////Eliminar row del grid
            //DialogResult r = MessageBox.Show("¿Desea Eliminar ésta linea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (r != DialogResult.Yes)
            //{
            //    return;
            //}

            //var gridView1 = (GridView)grd_Turnos.FocusedView;
            //var row = (dsFaceReloj.TurnosRow)gridView1.GetFocusedDataRow();

            //if (!row.IsserialNull())
            //{
            //    try
            //    {

            //        DataOperations dp = new DataOperations();
            //        SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
            //        con.Open();

            //        SqlCommand cmd = new SqlCommand("sp_update_horas_trabajadas_delete", con);
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@id", row.serial);
            //        cmd.ExecuteNonQuery();
            //        con.Close();

            //        gridView1.DeleteRow(gridView1.FocusedRowHandle);
            //    }
            //    catch (Exception ec)
            //    {
            //        CajaDialogo.Error(ec.Message);
            //    }
            //}
        }

        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            Cargar_reporte();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (grdv_Admin.RowCount < 1)
            {
                CajaDialogo.Error("Debe de generar el reporte primero.");
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_Admin.ExportToXlsx(dialog.FileName);
            }
        }

        private void cmdAgregarDeduccion_Click(object sender, EventArgs e)
        {

        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdAgregarMarca_Click(object sender, EventArgs e)
        {
            frm_Operaciones_Marcas frm = new frm_Operaciones_Marcas(EmpleadoActual.Barcode);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Cargar_reporte();
            }
        }
    }
}