using ACS.Classes;
using DevExpress.Utils.CommonDialogs;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using ExcelDataReader;
using LOSA.Clases;
using LOSA.RRHH_Planilla.Capacitacion;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.Planilla.ImportarPlanilla
{
    public partial class frmImportPlanilla : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLog;

        public frmImportPlanilla(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLog = pUser;
        }

        private void btnLoadTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Archivos Excel|*.xls;*.xlsx";
                string filePath = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName; // Cargar los datos desde el archivo Excel DataTable dataTable = LoadDataTableFromExcel(filePath); gridControl.DataSource = dataTable; } }
                }

                LoadExcelToGrid(filePath);

                if (gvPlanilla.RowCount == 0)
                {
                    CajaDialogo.Error("No se puede procesar la planilla ya que no hay datos precargados.");
                    return;
                }
                else
                btnProcesar.Enabled = true; 
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
        }

        public void LoadExcelToGrid(string filePath)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            // Verifica si el archivo existe
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Archivo no encontrado");
                return;
            }         

            // Leer el archivo de Excel usando EPPlus
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Obtener la primera hoja

                // Validar encabezados de las columnas
                List<string> actualColumns = new List<string>();
                for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                {
                    string columnName = worksheet.Cells[1, col].Text.Trim();
                    actualColumns.Add(columnName);
                    //dataTable.Columns.Add(columnName); // Agregar columna al DataTable
                }

                // Comparar encabezados del archivo con los esperados
                if (!actualColumns.SequenceEqual(expectedColumns))
                {
                    MessageBox.Show("El archivo de Excel no tiene los nombres de columna correctos.");
                    return; // Salir si los nombres de las columnas no coinciden
                }

                // Leer las filas de datos si los encabezados son correctos
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    DataRow dataRow = dsImportacionPlanilla1.template_planilla.NewRow();

                    for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                    {
                        
                       dataRow[col - 1] = worksheet.Cells[row, col].Text;
 
                    }

                    dsImportacionPlanilla1.template_planilla.Rows.Add(dataRow);
                }
            }

      
        }

        private readonly List<string> expectedColumns = new List<string>
        {
            "Nombre_Planilla", "Tipo_Planilla", "Desde", "Hasta", "Moneda","tipo_cambio","Codigo_Empleado",
            "EMPLEADO", "IDENTIDAD", "CARGO", "DVAC", "DFT", "DLB", "BASIC", "PVAC",
            "TRANS", "OTING", "GROSS", "AHRCOO", "BANC", "PRCOOP", "CAF", "AHRECOOP",
            "Otras ded Coop", "45095", "SMED", "USULA", "IHSS_T", "INCAPACIDAD",
            "ISR", "TEGRESO", "NET"
        };

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvPlanilla.RowCount==0)
                {
                    CajaDialogo.Error("No se puede procesar la planilla ya que no hay datos precargados.");
                    return;
                }

                foreach (var item in dsImportacionPlanilla1.template_planilla)
                {
                    // Convertir el string en formato dd/MM/yyyy a DateTime
                    DateTime fechaConvertidaDesde = DateTime.ParseExact(item.desde, "d/mm/yyyy", null);
                    DateTime fechaConvertidaHasta = DateTime.ParseExact(item.hasta, "d/MM/yyyy", null);

                    item.desde= fechaConvertidaDesde.ToString("yyyy/MM/dd");
                    item.hasta= fechaConvertidaHasta.ToString("yyyy/MM/dd");
                }

                DataOperations dp = new DataOperations();
       
                bool proceso_terminado = false;

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("dbo.uspProcesarPlanillaDesdeExcel", cnx);
                    proceso_terminado = false;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_id",UsuarioLog.UserId);

                    SqlParameter parameter = cmd.Parameters.AddWithValue("@planilla", dsImportacionPlanilla1.template_planilla);
                    parameter.SqlDbType = SqlDbType.Structured;
                    parameter.TypeName = "dbo.udttImportPlanilla";

                    cmd.ExecuteNonQuery();
                    
                    cnx.Close();

                    proceso_terminado = true;
                }

                if (proceso_terminado)
                {
                    CajaDialogo.Information("Se ha cargado la planilla exitosamente!");
                    dsImportacionPlanilla1.template_planilla.Clear();
                    btnProcesar.Enabled=false;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
   
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                FTP_Class ftp = new FTP_Class();
                DataOperations dp = new DataOperations();
                saveFileDialog1.FileName = "AQF-02-ImportarPlanilla.xlsx";

                // Establece el filtro para mostrar todos los tipos de archivos
                saveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ftp.DownloadFileV2(dp.FTP_RRHH_ImportarPlanilla, saveFileDialog1.FileName.Replace(Path.GetFileName(saveFileDialog1.FileName), ""), UsuarioLog, saveFileDialog1.FileName);

                    DialogResult result = CajaDialogo.Pregunta("¿Deseas abrir el archivo?");
                    if (result == DialogResult.Yes)
                    {
                        Process.Start(new ProcessStartInfo(saveFileDialog1.FileName) { UseShellExecute = true });

                    }

                    //CajaDialogo.Information("Documento descargado en '" + saveFileDialog1.FileName + "'");
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
        }
    }
}