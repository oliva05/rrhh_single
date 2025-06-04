using ACS.Classes;
using ClosedXML.Excel;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.RRHH_Planilla.Clases;
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

namespace LOSA.RRHH_Planilla.Planilla
{
    public partial class frmCargaPlantillaDeduccionesBeneficios : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogueado;
        int totalRegistrosPrevisualizados;
        int totalRegistrosProcesados;
        int totalRegistrosFallidos;
        //string path_default = "C://plantilla_rrhh";
        public frmCargaPlantillaDeduccionesBeneficios(UserLogin usuario)
        {
            InitializeComponent();
            usuarioLogueado=usuario;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                // Set filter options and filter index.
                openFileDialog1.Filter = "All Files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;

                lblFallidos.Text = $"Registros Fallidos: {0}";
                lblLoaded.Text = $"Registros Procesados: {0}";
                lblPreview.Text = $"Registros Previsualizados: {0}";
                tpImportados.Text = $"Importados (0)";
                tpFallidos.Text = $"Fallidos (0)";
                dsCargasPlantillas1.plantilla_deduccion_beneficiones.Clear();
                dsCargasPlantillas1.plantilla_deduccion_beneficiones_failure.Clear();
                xtraTabControl1.SelectedTabPage = tpImportados;

                // Open the file dialog and check if the user selected a file
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    string filePath = openFileDialog1.FileName;

                    // Display file path in the TextBox
                    txtArchivo.Text = filePath;

                    var dt = ImportExcelToDataTable(txtArchivo.Text);

                    foreach (DataRow dr in dt.Rows)
                    {
                        dsCargasPlantillas1.plantilla_deduccion_beneficiones.Rows.Add(dr["codigo_empleado"]
                                    ,string.IsNullOrEmpty( dr["fecha_efectiva"].ToString()) ? DBNull.Value: dr["fecha_efectiva"]
                                    , dr["concepto_deduccion_beneficio"]
                                    , dr["cuotas"]
                                    , dr["cuotas_restantes"]
                                    , dr["valor"]
                                    , dr["meses_deduccion_beneficio"]
                                    , dr["nombre"]
                                    , dr["tipo"]);
                    }

                    if (dsCargasPlantillas1.plantilla_deduccion_beneficiones.Rows.Count > 0)
                    {
                        CajaDialogo.Information($"Se han previsualizado {dsCargasPlantillas1.plantilla_deduccion_beneficiones.Rows.Count} registro(s)");
                        btnGuardar.Enabled = true;
                        totalRegistrosPrevisualizados = dsCargasPlantillas1.plantilla_deduccion_beneficiones.Rows.Count;

                        lblPreview.Text = $"Registros Previsualizados: {dsCargasPlantillas1.plantilla_deduccion_beneficiones.Rows.Count}";
                        tpImportados.Text = $"Importados ({dsCargasPlantillas1.plantilla_deduccion_beneficiones.Rows.Count})";
                    }


                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                this.txtArchivo.Text = string.Empty;
            }
        }

       
        public DataTable ImportExcelToDataTable(string filePath)
        {
            List<PlantillaDeduccionesBeneficios> plantilla = new List<PlantillaDeduccionesBeneficios>();

            DataTable dt = new DataTable();
            dt.Columns.Add("codigo_empleado", typeof(string));
            dt.Columns.Add("nombre", typeof(string));
            dt.Columns.Add("fecha_efectiva", typeof(string));
            dt.Columns.Add("concepto_deduccion_beneficio", typeof(string));
            dt.Columns.Add("tipo", typeof(string));
            dt.Columns.Add("cuotas", typeof(string));
            dt.Columns.Add("cuotas_restantes", typeof(string));
            dt.Columns.Add("valor", typeof(string));
            dt.Columns.Add("meses_deduccion_beneficio", typeof(string));

            List<string> columnasCorrectas = new List<string> 
            { "codigo_empleado"
                , "nombre"
                , "fecha_efectiva"
                , "concepto_deduccion_beneficio"
                , "tipo"
                , "cuotas"
                , "cuotas_restantes"
                , "valor"
                , "meses_deduccion_beneficio"};

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1); // Suponemos que los datos están en la primera hoja
                var rows = worksheet.RangeUsed().RowsUsed();

                var firstRow = worksheet.Row(1);
                var conteoColumnas=firstRow.CellsUsed().Count();

                // Lee todos los nombres de las columnas
                var columnNames = new List<string>();
                foreach (var cell in firstRow.CellsUsed())
                {
                    columnNames.Add(cell.GetString());
                }

                var conteoNombresCorrectos = columnNames.Where(columnName => columnasCorrectas.Contains(columnName)).Count();

                if (conteoColumnas!=9)
                {
                    CajaDialogo.Error("LA PLANTILLA DEBE TENER 9 COLUMNAS: \n\ncodigo_empleado, fecha_efectiva, concepto_deduccion_beneficio, tipo_deduccion_beneficio, cuotas, tipo, cuotas_restantes, valor, meses_deduccion_beneficio. \n\nEL ARHICVO CARGADO NO TIENE LA CANTIDAD DE COLUMNAS REQUERIDAS");
                    return new DataTable();
                }

                if (conteoNombresCorrectos != 9)
                {
                    CajaDialogo.Error("EL ARHICVO CARGADO NO TIENE LOS NOMBRES DE COLUMNAS CORRECTOS, VERIFIQUE QUE SEAN LOS SIGUIENTES NOMBRES: \n\ncodigo_empleado, fecha_efectiva, concepto_deduccion_beneficio, tipo, tipo_deduccion_beneficio, cuotas, cuotas_restantes, valor, meses_deduccion_beneficio.");
                    return new DataTable();
                }

                foreach (var row in rows)
                {

                    // Suponemos que los datos comienzan desde la segunda fila, saltando los encabezados
                    if (row.RowNumber() > 1)
                    {
                        DataRow dr = dt.NewRow();
                        dr["codigo_empleado"] = row.Cell(1).GetValue<string>();
                        dr["nombre"] = row.Cell(2).GetValue<string>();
                        dr["fecha_efectiva"] = row.Cell(3).GetValue<string>();
                        dr["concepto_deduccion_beneficio"] = row.Cell(4).GetValue<string>();
                        dr["tipo"] = row.Cell(5).GetValue<string>();
                        dr["cuotas"] = row.Cell(6).GetValue<string>();
                        dr["cuotas_restantes"] = row.Cell(7).GetValue<string>();
                        dr["valor"] = row.Cell(8).GetValue<string>();
                        dr["meses_deduccion_beneficio"] = row.Cell(9).GetValue<string>();
                        dt.Rows.Add(dr);
                    }
                }

                if (dt.Rows.Count == 0)
                {
                    CajaDialogo.Error("No hay registros disponibles");
                    return new DataTable();

                }

                foreach (var row in rows)
                {
                    plantilla.Add(new PlantillaDeduccionesBeneficios
                    {
                        CodigoEmpleado = row.Cell(1).GetValue<string>(),
                        Nombre = row.Cell(2).GetValue<string>(),
                        FechaEfectiva = row.Cell(3).GetValue<string>(),
                        ConceptoDeduccionBeneficio = row.Cell(4).GetValue<string>(),
                        Tipo =  row.Cell(5).GetValue<string>( ),
                        Cuotas =  row.Cell(6).GetValue<string>( ),
                        CuotasRestantes  =  row.Cell(7).GetValue<string>() ,
                        Valor =  row.Cell(8).GetValue<string>() ,
                        MesesDeduccionBeneficio = row.Cell(8).GetValue<string>() ,
                    });
                }
            }

            return dt;
        }

        public static List<PlantillaDeduccionesBeneficios> ConvertDataTableToList(DataTable dataTable)
        {
            List<PlantillaDeduccionesBeneficios> list = new List<PlantillaDeduccionesBeneficios>();

            foreach (DataRow row in dataTable.Rows)
            {
                PlantillaDeduccionesBeneficios plantilla = new PlantillaDeduccionesBeneficios
                {
                    CodigoEmpleado = row["codigo_empleado"].ToString(),
                    FechaEfectiva =  row["fecha_efectiva"].ToString(),
                    ConceptoDeduccionBeneficio = row["concepto_deduccion_beneficio"].ToString(),
                    Tipo = row["tipo"].ToString() ,
                    Nombre = row["nombre"].ToString(),
                    Cuotas = row["cuotas"].ToString() ,
                    CuotasRestantes =  row["cuotas_restantes"].ToString() ,
                    Valor =   row["valor"].ToString() ,
                    MesesDeduccionBeneficio =  row["meses_deduccion_beneficio"].ToString() 
                };

                list.Add(plantilla);
            }

            return list;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                //SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
                int finalizado = 0;
                string mensaje = "";
                bool proceso_terminado=false;

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                    {
                        SqlCommand cmd = new SqlCommand("dbo.uspProcesarPlantillaBeneficiosDeducciones", cnx);
                        cmd.CommandType= CommandType.StoredProcedure;
                        SqlParameter parameter = cmd.Parameters.AddWithValue("@plantilla", dsCargasPlantillas1.plantilla_deduccion_beneficiones);
                        parameter.SqlDbType = SqlDbType.Structured;
                        parameter.TypeName = "dbo.plantilla_deduccion_beneficios";
                        cmd.Parameters.AddWithValue("user_Id",usuarioLogueado.Id);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        proceso_terminado = false;
                        
                        cnx.Open();                     
                        da.Fill(dsCargasPlantillas1.plantilla_deduccion_beneficiones_failure);                        
                        cnx.Close();

                        proceso_terminado = true;
                    }

                if (proceso_terminado)
                {
                    totalRegistrosFallidos = dsCargasPlantillas1.plantilla_deduccion_beneficiones_failure.Rows.Count;
                    totalRegistrosProcesados = totalRegistrosPrevisualizados - totalRegistrosFallidos;

                    lblFallidos.Text = $"Registros Fallidos: {totalRegistrosFallidos}";
                    lblLoaded.Text = $"Registros Procesados: {totalRegistrosProcesados}";

                    mensaje = $"Se han cargado {totalRegistrosProcesados} registro(s)";

                    if (totalRegistrosFallidos>0)
                    {
                        xtraTabControl1.SelectedTabPage = tpFallidos;
                    }
                    
                    CajaDialogo.Information(mensaje);
                    tpFallidos.Text = $"Fallidos ({totalRegistrosFallidos})";
                    tpImportados.Text = $"Fallidos (0)";

                    dsCargasPlantillas1.plantilla_deduccion_beneficiones.Clear();
                    txtArchivo.Text = "";
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

       

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                frmSeleccionConcepto frm = new frmSeleccionConcepto();

                if (frm.ShowDialog()== DialogResult.OK)
                {
                    var dt = GetData(frm.concept_id,frm.tipo_planilla_id,frm.tipo_id);
                    
                    saveFileDialog1.Filter = "Archivos de Excel (*.xlsx; *.xls)|*.xlsx;*.xls";


                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (ExportToExcel(dt, saveFileDialog1.FileName))
                        {
                            DialogResult result = CajaDialogo.Pregunta("¿Deseas abrir el archivo?");
                            if (result == DialogResult.Yes)
                            {
                                Process.Start(new ProcessStartInfo( saveFileDialog1.FileName) { UseShellExecute = true });

                            }
                        } 
                    }

            }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
  
            }
        }

        static bool ExportToExcel(DataTable dt, string filePath)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                //filePath = filePath + "//AQF-01-PlantillaMasivaDeduccionesBeneficios.xlsx";
                using (ExcelPackage pck = new ExcelPackage())
                {
                    ExcelWorksheet ws = pck.Workbook.Worksheets.Add("DeduccionesBeneficios");
                    ws.Cells["A1"].LoadFromDataTable(dt, true);

                    using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        pck.SaveAs(stream);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }


        public DataTable GetData(int conceptId, int tipo_planilla_id,int tipo_id)
        {
            DataOperations dp = new DataOperations();

            using (SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.uspLoadPlanillaBenefit_Deductions", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@concept_id", conceptId);
                    cmd.Parameters.AddWithValue("@tipo_planilla_id", tipo_planilla_id);
                    cmd.Parameters.AddWithValue("@tipo_id", tipo_id);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

        }
    }
}