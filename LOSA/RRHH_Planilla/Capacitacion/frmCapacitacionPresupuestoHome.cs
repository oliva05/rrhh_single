using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
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
    public partial class frmCapacitacionPresupuestoHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLog;
        public frmCapacitacionPresupuestoHome(UserLogin user)
        {
            InitializeComponent();
            usuarioLog = user;
            CargarDatos();

            
        }

        public void CargarDatos( )
        {
            try
            {
                DataOperations dp = new DataOperations();


                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("dbo.uspGet_ppto_capacitacion", cnx);
                    cmd.CommandType= CommandType.StoredProcedure;
    
                    dsCapacitacion1.capacitacion_presupuesto.Clear();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsCapacitacion1.capacitacion_presupuesto);
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
                frmCapacitacionPresupuestoCRUD frm = new frmCapacitacionPresupuestoCRUD( frmCapacitacionPresupuestoCRUD.TipoTransaccion.Nuevo, usuarioLog);

                if (frm.ShowDialog()== DialogResult.OK)
                {
                    CargarDatos();
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
                var row = (dsCapacitacion.capacitacion_presupuestoRow)gvPPTO.GetFocusedDataRow();

                if (row != null)
                {
                    frmCapacitacionPresupuestoCRUD frm = new frmCapacitacionPresupuestoCRUD(frmCapacitacionPresupuestoCRUD.TipoTransaccion.Editar,row.id, usuarioLog);

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

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
           
            CargarDatos();
            //CambiarFormatoMonedaColumna();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsCapacitacion.capacitacion_presupuestoRow)gvPPTO.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                   var respuesta= CajaDialogo.Pregunta("¿Desea desactivar el registro?");

                if (respuesta== DialogResult.Yes)
                {

                using (SqlCommand cmd = new SqlCommand("dbo.uspDisablePresupuestoCapacitacion", cnx))
                {
                    cnx.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", row.id);
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                }

                    CajaDialogo.Information("Presupuesto desactivado!");
 
                        CargarDatos();
                    
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CambiarFormatoMonedaColumna()
        {
            // Configurar el formato dinámico al cargar el formulario
            for (int i = 0; i < gvPPTO.RowCount; i++)
            {
                // Obtén el valor de la columna "Moneda" para cada fila
                string moneda = Convert.ToString(gvPPTO.GetRowCellValue(i, "moneda"));

                // Crea un RepositoryItemTextEdit para la columna "Presupuesto"
                RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();

                if (moneda == "USD")
                {
                    colpresupuesto_asignado.DisplayFormat.FormatString = "c"; // Formato de moneda local
                    colpresupuesto_asignado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                }
                else if (moneda == "HNL")
                {

                    colpresupuesto_asignado.DisplayFormat.FormatString = "L#,##0.00"; // Formato personalizado para euros
                    colpresupuesto_asignado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                }
                else
                {
                    colpresupuesto_asignado.DisplayFormat.FormatString = "N2"; // Formato genérico
                    colpresupuesto_asignado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                }

                // Asigna el RepositoryItemTextEdit dinámico a la columna "Presupuesto"
                gvPPTO.Columns["presupuesto_asignado"].ColumnEdit = textEdit;
            }
        }

        private void lueAnio_EditValueChanged(object sender, EventArgs e)
        {
           
              CargarDatos( );
      
        }

        private void frmCapacitacionPresupuestoHome_Load(object sender, EventArgs e)
        {
            //CambiarFormatoMonedaColumna();
        }

        
    }
}