using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using LOSA.Clases;
using LOSA.MigracionACS.RRHH.RelojFace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.MicroIngredientes._3erNivelBascula
{
    public partial class frmReporte3erNivelMicros : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmReporte3erNivelMicros(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            DataOperations dp = new DataOperations();
            DateTime Now_ = dp.Now();
            dt_inicial.EditValue = Now_.AddDays(-2);
            dt_final.EditValue = Now_;
            LoadDatos();
        }
        public frmReporte3erNivelMicros()
        {
            InitializeComponent();
            DataOperations dp = new DataOperations();
            DateTime Now_ = dp.Now();
            dt_inicial.EditValue = Now_.AddDays(-2);
            dt_final.EditValue = Now_;
            LoadDatos();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void LoadDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_detalle_batch_micros_3er_nivel_adicion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dt_inicial.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dt_final.DateTime);
                dsBatchActual1.reporte_batches.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsBatchActual1.reporte_batches);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            //Nueva version

            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                string path = "Reporte 3er nivel";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    //Customize export options
                    (gridControl1.MainView as GridView).OptionsPrint.PrintHeader = true;
                    XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                    advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.SheetName = "Exported from ALOSY";

                    gridControl1.ExportToXlsx(path, advOptions);
                    // Open the created XLSX file with the default application.
                    Process.Start(path);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte3erNivelMicros));
            this.dt_final = new DevExpress.XtraEditors.DateEdit();
            this.dt_inicial = new DevExpress.XtraEditors.DateEdit();
            this.lblFechas = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnexport = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsBatchActual1 = new LOSA.MicroIngredientes._3erNivelBascula.dsBatchActual();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colorder_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_rw = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_bascula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsetpoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBatchActual1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_final
            // 
            this.dt_final.EditValue = null;
            this.dt_final.Location = new System.Drawing.Point(118, 67);
            this.dt_final.Name = "dt_final";
            this.dt_final.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dt_final.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dt_final.Properties.Appearance.Options.UseFont = true;
            this.dt_final.Properties.Appearance.Options.UseForeColor = true;
            this.dt_final.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_final.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dt_final.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_final.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_final.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_final.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_final.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_final.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_final.Size = new System.Drawing.Size(212, 26);
            this.dt_final.TabIndex = 23;
            // 
            // dt_inicial
            // 
            this.dt_inicial.EditValue = null;
            this.dt_inicial.Location = new System.Drawing.Point(118, 35);
            this.dt_inicial.Name = "dt_inicial";
            this.dt_inicial.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dt_inicial.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.dt_inicial.Properties.Appearance.Options.UseFont = true;
            this.dt_inicial.Properties.Appearance.Options.UseForeColor = true;
            this.dt_inicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_inicial.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dt_inicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_inicial.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_inicial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_inicial.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dt_inicial.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dt_inicial.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_inicial.Size = new System.Drawing.Size(212, 26);
            this.dt_inicial.TabIndex = 22;
            // 
            // lblFechas
            // 
            this.lblFechas.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblFechas.Appearance.Options.UseFont = true;
            this.lblFechas.Location = new System.Drawing.Point(6, 41);
            this.lblFechas.Name = "lblFechas";
            this.lblFechas.Size = new System.Drawing.Size(123, 21);
            this.lblFechas.TabIndex = 19;
            this.lblFechas.Text = "Fecha Inicial_____";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 21);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Fecha Final_____";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(336, 58);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(143, 36);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "Actualizar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnexport
            // 
            this.btnexport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexport.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Appearance.Options.UseFont = true;
            this.btnexport.ImageOptions.Image = global::LOSA.Properties.Resources.Excel_2_icon32px1;
            this.btnexport.Location = new System.Drawing.Point(616, 58);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(146, 36);
            this.btnexport.TabIndex = 24;
            this.btnexport.Text = "Exportar a excel";
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "reporte_batches";
            this.gridControl1.DataSource = this.dsBatchActual1;
            this.gridControl1.Location = new System.Drawing.Point(5, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(757, 357);
            this.gridControl1.TabIndex = 25;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsBatchActual1
            // 
            this.dsBatchActual1.DataSetName = "dsBatchActual";
            this.dsBatchActual1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colorder_id,
            this.colid_rw,
            this.colitemcode,
            this.colitemname,
            this.colfecha,
            this.colcant_bascula,
            this.colsetpoint,
            this.coldiferencia,
            this.collote_pt,
            this.colorder_code});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colorder_id
            // 
            this.colorder_id.FieldName = "order_id";
            this.colorder_id.Name = "colorder_id";
            // 
            // colid_rw
            // 
            this.colid_rw.FieldName = "id_rw";
            this.colid_rw.Name = "colid_rw";
            // 
            // colitemcode
            // 
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.ReadOnly = true;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            this.colitemcode.Width = 62;
            // 
            // colitemname
            // 
            this.colitemname.FieldName = "itemname";
            this.colitemname.Name = "colitemname";
            this.colitemname.OptionsColumn.ReadOnly = true;
            this.colitemname.Visible = true;
            this.colitemname.VisibleIndex = 1;
            this.colitemname.Width = 166;
            // 
            // colfecha
            // 
            this.colfecha.DisplayFormat.FormatString = "g";
            this.colfecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            this.colfecha.Width = 110;
            // 
            // colcant_bascula
            // 
            this.colcant_bascula.DisplayFormat.FormatString = "n1";
            this.colcant_bascula.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcant_bascula.FieldName = "cant_bascula";
            this.colcant_bascula.Name = "colcant_bascula";
            this.colcant_bascula.OptionsColumn.ReadOnly = true;
            this.colcant_bascula.Visible = true;
            this.colcant_bascula.VisibleIndex = 3;
            // 
            // colsetpoint
            // 
            this.colsetpoint.DisplayFormat.FormatString = "n1";
            this.colsetpoint.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsetpoint.FieldName = "setpoint";
            this.colsetpoint.Name = "colsetpoint";
            this.colsetpoint.OptionsColumn.ReadOnly = true;
            this.colsetpoint.Visible = true;
            this.colsetpoint.VisibleIndex = 4;
            // 
            // coldiferencia
            // 
            this.coldiferencia.DisplayFormat.FormatString = "n1";
            this.coldiferencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldiferencia.FieldName = "diferencia";
            this.coldiferencia.Name = "coldiferencia";
            this.coldiferencia.OptionsColumn.ReadOnly = true;
            this.coldiferencia.Visible = true;
            this.coldiferencia.VisibleIndex = 5;
            this.coldiferencia.Width = 62;
            // 
            // collote_pt
            // 
            this.collote_pt.FieldName = "lote_pt";
            this.collote_pt.Name = "collote_pt";
            this.collote_pt.OptionsColumn.ReadOnly = true;
            this.collote_pt.Visible = true;
            this.collote_pt.VisibleIndex = 6;
            this.collote_pt.Width = 71;
            // 
            // colorder_code
            // 
            this.colorder_code.FieldName = "order_code";
            this.colorder_code.Name = "colorder_code";
            this.colorder_code.OptionsColumn.ReadOnly = true;
            this.colorder_code.Visible = true;
            this.colorder_code.VisibleIndex = 7;
            this.colorder_code.Width = 111;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(616, 16);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(146, 36);
            this.simpleButton2.TabIndex = 26;
            this.simpleButton2.Text = "Cerrar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmReporte3erNivelMicros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 460);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.dt_final);
            this.Controls.Add(this.dt_inicial);
            this.Controls.Add(this.lblFechas);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Name = "frmReporte3erNivelMicros";
            this.Text = "Reporte adiciones en el 3er Nivel";
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBatchActual1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}