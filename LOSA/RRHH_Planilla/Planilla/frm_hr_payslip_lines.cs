using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Fields;
using LOSA.Clases;
using LOSA.Clases.Colaborador;
using LOSA.Clases.Planilla;
using LOSA.MigracionACS.RRHH.RelojFace;
using LOSA.RRHH_Planilla.BenefitsDeductions;
using LOSA.RRHH_Planilla.Planilla.Reportes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.Planilla
{
    public partial class frm_hr_payslip_lines : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        int SlipId;
        DateTime desde;
        DateTime hasta;
        Payslip_Run PlanillaHeaderObject;
        ArrayList ArraySlips;
        int FilaActual;
        int UltimaFila;
        int IdEmpleadoLoaded;
        DataOperations dp;
        private frm_hr_slips_employees FormPlanillasList;

        public frm_hr_payslip_lines(UserLogin pUsuario, string pDescripcion, string pEstado, 
                                    DateTime pdesde, DateTime phasta, int pSlipId, string pcodigo, string pname)
        {
            InitializeComponent();
            desde=pdesde;
            hasta=phasta;
            PlanillaHeaderObject = new Payslip_Run();
            dp = new DataOperations();

            UsuarioLogeado = pUsuario;
            lblDescripcion.Text = pDescripcion;
            lblEstado.Text = pEstado;
            lblDesde.Text = string.Format("{0:dd-MMM-yyyy}", pdesde);
            lblHasta.Text = string.Format("{0:dd-MMM-yyyy}", phasta);
            lblCodigo.Text = pcodigo;
            lblNombre.Text = pname;
            SlipId = pSlipId;
            

            if (PlanillaHeaderObject.RecuperarRegistroBySlipId(pSlipId))
            {
                if (PlanillaHeaderObject.PayrollTypeId == 3)//Horas Extra
                {
                    cmdSiguiente.Visible = cmdAnterior.Visible = 
                    cmdVerMarcas.Visible = true;
                    
                    LoadDetalleNominasHE(SlipId);
                    //gridView1.Columns["salario_hora"].Visible = true;
                }
                else
                {
                    cmdSiguiente.Visible = cmdAnterior.Visible =
                    cmdVerMarcas.Visible = false;

                    gridView1.Columns["salario_hora"].Visible = false;
                    LoadDetalleNominas();
                }
            }
        }

        public frm_hr_payslip_lines(UserLogin pUsuario, string pDescripcion, string pEstado,
                                    DateTime pdesde, DateTime phasta, int pSlipId, string pcodigo, 
                                    string pname, ArrayList pArraySlips, int pLineaActual, frm_hr_slips_employees pForm)
        {
            InitializeComponent();
            FormPlanillasList = pForm;
            desde = pdesde;
            hasta = phasta;
            PlanillaHeaderObject = new Payslip_Run();
            dp = new DataOperations();
            UsuarioLogeado = pUsuario;
            lblDescripcion.Text = pDescripcion;
            lblEstado.Text = pEstado;
            lblDesde.Text = string.Format("{0:dd-MMM-yyyy}", pdesde);
            lblHasta.Text = string.Format("{0:dd-MMM-yyyy}", phasta);
            lblCodigo.Text = pcodigo;
            lblNombre.Text = pname;
            SlipId = pSlipId;


            if (PlanillaHeaderObject.RecuperarRegistroBySlipId(pSlipId))
            {
                //if (PlanillaHeaderObject.PayrollTypeId == 3)//Horas Extra
                //{
                //    cmdSiguiente.Visible = cmdAnterior.Visible = true;
                //    cmdVerMarcas.Visible = true;
                //    //LoadDetalleNominasHE(SlipId);
                //    //gridView1.Columns["salario_hora"].Visible = true;

                //    this.ArraySlips = pArraySlips;

                //    FilaActual = pLineaActual;
                //    UltimaFila = this.ArraySlips.Count;
                //    foreach (PaySlip slip in this.ArraySlips)
                //    {
                //        if (slip != null)
                //        {
                //            if (slip.LineaNum_Orden == pLineaActual)
                //            {
                //                LoadDetalleNominasHE(slip.PaySlip_id);
                //                break;
                //            }
                //        }
                //    }
                //}
                //else
                //{
                //    cmdSiguiente.Visible = cmdAnterior.Visible = false;
                //    cmdVerMarcas.Visible = false;
                //    gridView1.Columns["salario_hora"].Visible = false;
                //    LoadDetalleNominas();
                //}

                switch (PlanillaHeaderObject.PayrollTypeId)
                {
                    case 1: //Planilla General Lempiras
                    case 2: //Planilla Confidencial USD
                        cmdSiguiente.Visible = cmdAnterior.Visible = false;
                        cmdVerMarcas.Visible = false;
                        gridView1.Columns["salario_hora"].Visible = false;
                        LoadDetalleNominas();
                        break;
                    case 3://Horas Extras
                        cmdSiguiente.Visible = cmdAnterior.Visible = true;
                        cmdVerMarcas.Visible = true;

                        this.ArraySlips = pArraySlips;

                        FilaActual = pLineaActual;
                        UltimaFila = this.ArraySlips.Count;
                        foreach (PaySlip slip in this.ArraySlips)
                        {
                            if (slip != null)
                            {
                                if (slip.LineaNum_Orden == pLineaActual)
                                {
                                    LoadDetalleNominasHE(slip.PaySlip_id);
                                    break;
                                }
                            }
                        }
                        break;
                    case 4://Planilla décimo tercero (L.)
                    case 5://Planilla décimo tercero ($)
                    case 6://Planilla décimo cuarto (L.)
                    case 7://Planilla décimo cuarto ($)
                        gridView1.Columns["salario_hora"].Visible = false;
                        
                        cmdSiguiente.Visible = cmdAnterior.Visible = false;
                        cmdVerMarcas.Visible = false;
                        LoadDetalleNominasDecimo();
                        break;
                    default:
                        break;
                }

                switch (PlanillaHeaderObject.IdEstado)
                {
                    case 1: //

                        break;
                    case 2: //Confirmada
                        cmdAgregarDeduccion.Visible = false;
                        //Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna,
                        //para elegir columnas, ordenar, etc
                        gridView1.OptionsMenu.EnableColumnMenu = false;

                        //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el dataset
                        gridView1.Columns["delete"].Visible = false; 

                        //Poner todas las columnas como ReadOnly = true
                        foreach (GridColumn column in gridView1.Columns)
                        {
                            column.OptionsColumn.ReadOnly = true;
                        }
                        break;
                    case 3: //

                        break;

                }
            }

            
        }

        private void LoadDetalleNominasDecimo()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[GetPlanillasEmpleadosLineas_Detalle_Decimo]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@slip_id", SlipId);
                dsPlanillasTransaccion1.hr_payslip_lines.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPlanillasTransaccion1.hr_payslip_lines);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDetalleNominas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.GetPlanillasEmpleadosLineas_Detalle", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@slip_id", SlipId);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                dsPlanillasTransaccion1.hr_payslip_lines.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPlanillasTransaccion1.hr_payslip_lines);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDetalleNominasHE(int pSlipId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[GetPlanillasEmpleadosLineas_Detalle_HE]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@slip_id", pSlipId);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                dsPlanillasTransaccion1.hr_payslip_lines.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPlanillasTransaccion1.hr_payslip_lines);

                PaySlip SlipNow = new PaySlip();
                if (SlipNow.RecuperarRegistro(pSlipId))
                {
                    lblCodigo.Text = SlipNow.EmployeeCode;
                    lblNombre.Text = SlipNow.EmployeeName;
                    IdEmpleadoLoaded = SlipNow.EmployeeId;
                }

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.FormPlanillasList.LoadDetalleNominas();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView1 = (GridView)gridControl1.FocusedView;
            var row = (dsPlanillasTransaccion.hr_payslip_linesRow)gridView1.GetFocusedDataRow();

            if(row != null)
            {
                if(row.salary_rule_id == 67 ||//Dias Laborado
                   row.salary_rule_id == 89 ||//Dias Incapacidad 100%
                   row.salary_rule_id == 66 ||//Dias Faltados
                   row.salary_rule_id == 6  ||//Dias Vacaciones
                   row.salary_rule_id == 49 ||//Dias Vacaciones pagadas
                   row.salary_rule_id == 57 ||//Dias Incapacidad 34%
                   row.salary_rule_id == 1  ||//Salario basico
                   row.salary_rule_id == 2  ||//Total Ingresos
                   row.salary_rule_id == 51 ||//IHSS
                   row.salary_rule_id == 52 ||//AFP
                   row.salary_rule_id == 84 ||//Total Egresos
                   row.salary_rule_id == 3)   //Total a Pagar
                {
                    CajaDialogo.Error("No se permite elminar esta linea, es una linea obligatoria!");
                    return;
                }
                else
                {
                    DialogResult result = CajaDialogo.Pregunta("Esta seguro de elminar esta linea?");
                    if (result != DialogResult.Yes)
                        return;

                    //Eliminar row del grid y la tabla
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                        con.Open();

                        SqlCommand cmd = new SqlCommand("[dbo].[Update_payslip_line_id_disable]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_payslip_line_id", row.id);
                        //cmd.Parameters.AddWithValue("@enable", 0);
                        //cmd.Parameters.AddWithValue("@state", "anulated");
                        cmd.ExecuteNonQuery();

                        con.Close();

                        gridView1.DeleteRow(gridView1.FocusedRowHandle);
                        LoadDetalleNominas();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                }
            }
            else
            {
                CajaDialogo.Error("No se pudo validar la Regla Salarial que intento elminar! El proceso fue fallido!");
                return;
            }
        }//cmdDelete_ButtonClick

        private void cmdAgregarDeduccion_Click(object sender, EventArgs e)
        {
            frmDeductionsCRUD_PayslipLine frm = new frmDeductionsCRUD_PayslipLine(frmDeductionsCRUD_PayslipLine.TipoTransaccionPlanilla.Nuevo,
                                                                                  this.UsuarioLogeado, SlipId);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadDetalleNominas();
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView1 = (GridView)gridControl1.FocusedView;
            var row = (dsPlanillasTransaccion.hr_payslip_linesRow)gridView1.GetFocusedDataRow();

            switch(e.Column.FieldName)
            {
                case "note":
                    if(!row.IsnoteNull())
                    {
                        if (!string.IsNullOrEmpty(row.note))
                        {
                            if(row.note.Length > 0)
                            {
                                try
                                {
                                    DataOperations dp = new DataOperations();
                                    SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                                    con.Open();

                                    SqlCommand cmd = new SqlCommand("[dbo].[SetNotaLineaPlanilla_empleado]", con);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@note", row.note);
                                    cmd.Parameters.AddWithValue("@id", row.id);
                                    cmd.ExecuteNonQuery();

                                    con.Close();
                                }
                                catch (Exception ec)
                                {
                                    CajaDialogo.Error(ec.Message);
                                }
                            }
                        }
                    }
                    break;
                case "quantity":
                    decimal percent = 1M;

                    if (row.code == "PHE25" || row.code == "PHE50" || row.code == "PHE75" || row.code == "PHE100")
                    {
                        switch (row.code)
                        {
                            case "PHE25":
                                percent = 1.25M;
                                break;
                            case "PHE50":
                                percent = 1.50M;
                                break;
                            case "PHE75":
                                percent = 1.75M;
                                break;
                            case "PHE100":
                                percent = 2M;
                                break;
                            default:

                                break;
                        }
                        row.Credito = row.quantity * (row.salario_hora * percent);

                        UpdateLineaPlanilla(row.id, row.Credito, row.quantity);

                        decimal TotalA_Pagar = 0;
                        decimal TotalHorasExtra = 0;
                        foreach(dsPlanillasTransaccion.hr_payslip_linesRow rowS in dsPlanillasTransaccion1.hr_payslip_lines)
                        {
                            if (rowS.code == "PHE25" || rowS.code == "PHE50" || rowS.code == "PHE75" || rowS.code == "PHE100")
                            {
                                TotalA_Pagar += rowS.Credito;
                                TotalHorasExtra += rowS.quantity;
                            }
                        }

                        foreach (dsPlanillasTransaccion.hr_payslip_linesRow rowT in dsPlanillasTransaccion1.hr_payslip_lines)
                        {
                            if(rowT.code == "TPHE")
                            {
                                rowT.Saldo = TotalA_Pagar;
                                rowT.quantity = TotalHorasExtra;
                                UpdateLineaPlanilla(rowT.id, TotalA_Pagar, TotalHorasExtra);
                            }
                        }
                    }
                    break;
                case "Credito":
                    //if (row.code != "CTAVO" && row.code != "TCAVO")
                    //{
                    //    row.Credito = dp.ValidateNumberDecimal(e.OldValue);
                    //}
                    //else
                    //{
                    //    decimal SaldoDecimo = dp.ValidateNumberDecimal(e.Value);
                    //    decimal DeduccionesDecimo = 0;
                    //    foreach (dsPlanillasTransaccion.hr_payslip_linesRow rowS in dsPlanillasTransaccion1.hr_payslip_lines)
                    //    {
                    //        if (rowS.salary_rule_id == 50)
                    //        {
                    //            DeduccionesDecimo += rowS.Debito;
                    //        }
                    //    }

                    //    foreach (dsPlanillasTransaccion.hr_payslip_linesRow rowS in dsPlanillasTransaccion1.hr_payslip_lines)
                    //    {
                    //        if (rowS.salary_rule_id == 3)
                    //        {
                    //            rowS.Saldo = (SaldoDecimo - DeduccionesDecimo);
                    //            try
                    //            {
                    //                DataOperations dp = new DataOperations();
                    //                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                    //                con.Open();

                    //                SqlCommand cmd = new SqlCommand("[dbo].[spSetUpdate_Payslip_line_by_id]", con);
                    //                cmd.CommandType = CommandType.StoredProcedure;
                    //                cmd.Parameters.AddWithValue("@payslip_line_id", row.id);
                    //                cmd.Parameters.AddWithValue("@quantity", 1);
                    //                cmd.Parameters.AddWithValue("@total", rowS.Saldo);
                    //                cmd.ExecuteNonQuery();

                    //                con.Close();
                    //            }
                    //            catch (Exception ec)
                    //            {
                    //                CajaDialogo.Error(ec.Message);
                    //            }
                    //            break; 
                    //        }
                    //    }
                    //}
                    break;
            }
        }

        private void UpdateLineaPlanilla(int idPaySlipLine, decimal pCredito, decimal pCantidad)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.spSetUpdate_Payslip_line_by_id", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@payslip_line_id", idPaySlipLine);
                cmd.Parameters.AddWithValue("@quantity", pCantidad);
                cmd.Parameters.AddWithValue("@total", pCredito);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                rptNominaEmpleado report = new rptNominaEmpleado(lblDescripcion.Text,lblEstado.Text,desde,hasta,SlipId,lblCodigo.Text,lblNombre.Text);

                using (ReportPrintTool printTool = new ReportPrintTool(report))
                {
                    // Send the report to the default printer.
                    printTool.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                throw;
            }
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            if(FilaActual < this.ArraySlips.Count)
            {
                //Siguiente Planilla
                
                foreach (PaySlip slip in this.ArraySlips)
                {
                    if (slip != null)
                    {
                        if (slip.LineaNum_Orden == (FilaActual + 1))
                        {
                            FilaActual += 1;
                            LoadDetalleNominasHE(slip.PaySlip_id);
                            break;
                        }
                    }
                }
            }
            else
            {
                //Nos iremos a la 1
                FilaActual = 1;
                UltimaFila = this.ArraySlips.Count;
                foreach (PaySlip slip in this.ArraySlips)
                {
                    if (slip != null)
                    {
                        if (slip.LineaNum_Orden == 1)
                        {
                            LoadDetalleNominasHE(slip.PaySlip_id);
                        }
                    }
                }
            }
            
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            if (FilaActual > 1)
            {
                //Planilla anterior

                foreach (PaySlip slip in this.ArraySlips)
                {
                    if (slip != null)
                    {
                        if (slip.LineaNum_Orden == (FilaActual - 1))
                        {
                            FilaActual -= 1;
                            LoadDetalleNominasHE(slip.PaySlip_id);
                        }
                    }
                }
            }
            else
            {
                //Nos iremos a la Ultima
                FilaActual = UltimaFila;
                
                foreach (PaySlip slip in this.ArraySlips)
                {
                    if (slip != null)
                    {
                        if (slip.LineaNum_Orden == UltimaFila)
                        {
                            LoadDetalleNominasHE(slip.PaySlip_id);
                        }
                    }
                }
            }
        }

        private void cmdVerMarcas_Click(object sender, EventArgs e)
        {
            HrEmployee EmpleadoClicked = new HrEmployee();
            if (EmpleadoClicked.RecuperarDatosPorId(IdEmpleadoLoaded))
            {
                frmResumenHorasExtraTrabajadas frm = new frmResumenHorasExtraTrabajadas(EmpleadoClicked, desde, hasta);
                frm.Show();
            }
            
        }

        private void frm_hr_payslip_lines_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FormPlanillasList.LoadDetalleNominas();
        }
    }
}