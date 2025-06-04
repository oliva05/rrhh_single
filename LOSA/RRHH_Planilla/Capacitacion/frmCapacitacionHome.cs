using ACS.Classes;
using ClosedXML.Excel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraVerticalGrid;
using LOSA.Clases;
using LOSA.RRHH_Planilla.Capacitacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LOSA.RRHH_Planilla.Mantenimientos.frmPlanillaCategoria;

namespace LOSA.RRHH_Planilla.Mantenimientos
{
    public partial class frmCapacitacionHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLog;
        public frmCapacitacionHome(UserLogin user)
        {
            InitializeComponent();
            usuarioLog = user;
            lueAnio.EditValue = DateTime.Now.Year;
            CargarDatos(DateTime.Now.Year);
            CargarVistaResumen(DateTime.Now.Year);
            CargarComboAnio();
            CargarDatosPPTO(DateTime.Now.Year);

        }

        public void CargarDatos(int anio)
        {
            try
            {
                DataOperations dp = new DataOperations();


                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("dbo.uspGetCapacitacionesV2", cnx);
                    cmd.CommandType= CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@anio",anio);

                    dsCapacitacion1.capacitacion.Clear();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsCapacitacion1.capacitacion);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarVistaResumen(int anio)
        {
            try
            {
                DataOperations dp = new DataOperations();


                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {

                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("dbo.uspGet_capacitaciones_resumenV2", cnx);
                    cmd.CommandType= CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@anio", anio);
                    dsCapacitacion1.capacitacion_resumen.Clear();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsCapacitacion1.capacitacion_resumen);
                    cnx.Close();
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarDatosPPTO(int anio)
        {
            try
            {
                DataOperations dp = new DataOperations();


                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("dbo.uspRPT_Presupuesto_capacitaciones", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@anio", anio);

                    dsCapacitacion1.presupuesto_report.Clear();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsCapacitacion1.presupuesto_report);
                    cnx.Close();
                }


                //for (int i = 0; i < gvPPTO.RowCount; i++)
                //{
                //    var moneda = gvPPTO.GetRowCellValue(i, "moneda").ToString();
                //    var disponible = Convert.ToDecimal(gvPPTO.GetRowCellValue(i, "disponible"));

                //    switch (moneda)
                //    {
                //        case "USD":
                //            gvPPTO.SetRowCellValue(i, "disponible", disponible.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));
                //            break;
                //        case "HNL":
                //            gvPPTO.SetRowCellValue(i, "disponible", disponible.ToString("C2", CultureInfo.CreateSpecificCulture("es-HN")));
                //            break;
                //        default:
                //            gvPPTO.SetRowCellValue(i, "disponible", disponible.ToString());
                //            break;
                //    }
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarComboAnio()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
                

                dsCapacitacion1.capacitacion_combo_anio.Clear();

                cnx.Open();
                SqlDataAdapter da = new SqlDataAdapter("dbo.uspCargarComboAniosCapacitaciones", cnx);
                da.Fill(dsCapacitacion1.capacitacion_combo_anio);
                cnx.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                frmCapacitacionCRUD frm = new frmCapacitacionCRUD(usuarioLog,frmCapacitacionCRUD.TipoTransaccion.Nuevo);

                if (frm.ShowDialog()== DialogResult.OK)
                {
                    if (lueAnio != null)
                    {
                        CargarDatos((int)lueAnio.EditValue);
                        CargarVistaResumen((int)lueAnio.EditValue);
                    }
                    else
                    {
                        CargarDatos(DateTime.Now.Year);
                        CargarVistaResumen(DateTime.Now.Year);
                    }
                    CargarComboAnio();
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

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsCapacitacion.capacitacionRow)bandedGridView1.GetFocusedDataRow();

                if (row != null)
                {
                    frmCapacitacionCRUD frm = new frmCapacitacionCRUD(usuarioLog, frmCapacitacionCRUD.TipoTransaccion.Update,row.id);

                    if (frm.ShowDialog()== DialogResult.OK)
                    {
                        if (lueAnio != null)
                        {
                            CargarDatos((int)lueAnio.EditValue);
                            CargarVistaResumen((int)lueAnio.EditValue);
                            CargarDatosPPTO((int)lueAnio.EditValue);

                        }
                        else
                        {
                            CargarDatos(DateTime.Now.Year);
                            CargarVistaResumen(DateTime.Now.Year);
                            CargarDatosPPTO(DateTime.Now.Year);

                        }

                        CargarComboAnio();

                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            if (lueAnio != null)
            {
                CargarDatos((int)lueAnio.EditValue);
                CargarVistaResumen((int)lueAnio.EditValue);
                CargarDatosPPTO((int)lueAnio.EditValue);
            }
            else
            {
                CargarDatos(DateTime.Now.Year);
                CargarVistaResumen(DateTime.Now.Year);
                CargarDatosPPTO((int)lueAnio.EditValue);

            }

            CargarComboAnio();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsCapacitacion.capacitacionRow)bandedGridView1.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                   var respuesta= CajaDialogo.Pregunta("¿Desea desactivar el registro?");

                if (respuesta== DialogResult.Yes)
                {

                using (SqlCommand cmd = new SqlCommand("dbo.uspDesactivar_capacitacion", cnx))
                {
                    cnx.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                }

                    CajaDialogo.Information("Capacitación desactivada!");

                    if (lueAnio!=null)
                    {
                        CargarDatos((int)lueAnio.EditValue);
                        CargarVistaResumen((int)lueAnio.EditValue);
                        CargarDatosPPTO((int)lueAnio.EditValue);
                    }
                    else
                    {
                        CargarDatos(DateTime.Now.Year);
                        CargarVistaResumen(DateTime.Now.Year);
                        CargarDatosPPTO(DateTime.Now.Year);
                    }

                    CargarComboAnio();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void lueAnio_EditValueChanged(object sender, EventArgs e)
        {
            if (lueAnio.EditValue!=null)
            {
              CargarDatos((int)lueAnio.EditValue);
              CargarVistaResumen((int)lueAnio.EditValue);
                CargarDatosPPTO((int)lueAnio.EditValue);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if ((int)lueAnio.EditValue <= 0)
            {
                CajaDialogo.Error("Debe seleccionar el Año!");
                return;
            }

            DataTable dt = new DataTable("Capacitaciones");
            string ruta = ObtenerRutaGuardado();
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_detalle_capacitaciones_por_anio", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@anio", lueAnio.EditValue);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dt);
                conn.Close();

                if (!string.IsNullOrEmpty(ruta)) // Si el usuario no canceló
                {
                    ExportarDataTableAExcel(dt, ruta);
                    Console.WriteLine("Archivo Excel guardado en: " + ruta);
                }
                else
                {
                    Console.WriteLine("Operación cancelada por el usuario.");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        static string ObtenerRutaGuardado()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
                sfd.Title = "Guardar archivo Excel";
                sfd.FileName = "DatosExportados.xlsx"; 

                if (sfd.ShowDialog() == DialogResult.OK)
                { 
                    return sfd.FileName; 
                }
            }
            return null; 
        }

        static void ExportarDataTableAExcel(DataTable dt, string ruta)
        {
            using (XLWorkbook wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add(dt, "DatosSQL");
                
                ws.Columns().AdjustToContents();//Esto es para ajustar las columnas en automatico.
                wb.SaveAs(ruta);
            }
        }

    }
}