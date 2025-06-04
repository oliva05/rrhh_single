namespace LOSA.MigracionACS.OIL
{
    partial class frmReportePostPellet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportePostPellet));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.CargarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.dsAceites1 = new LOSA.MigracionACS.OIL.dsAceites();
            this.cmdExportar = new DevExpress.XtraEditors.SimpleButton();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collot_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomercial_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colintake_real = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colno_coater = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collong_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsAceites1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(25, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Fecha Desde:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(262, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Fecha Hasta:";
            // 
            // CargarDatos
            // 
            this.CargarDatos.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarDatos.Appearance.Options.UseFont = true;
            this.CargarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CargarDatos.ImageOptions.Image")));
            this.CargarDatos.Location = new System.Drawing.Point(475, 12);
            this.CargarDatos.Name = "CargarDatos";
            this.CargarDatos.Size = new System.Drawing.Size(137, 39);
            this.CargarDatos.TabIndex = 5;
            this.CargarDatos.Text = "Cargar Datos";
            this.CargarDatos.Click += new System.EventHandler(this.cmdCargarDatos_Click);
            // 
            // dsAceites1
            // 
            this.dsAceites1.DataSetName = "dsAceites";
            this.dsAceites1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmdExportar
            // 
            this.cmdExportar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportar.Appearance.Options.UseFont = true;
            this.cmdExportar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdExportar.ImageOptions.Image")));
            this.cmdExportar.Location = new System.Drawing.Point(618, 12);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(116, 39);
            this.cmdExportar.TabIndex = 7;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(108, 25);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtDesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDesde.Size = new System.Drawing.Size(128, 26);
            this.dtDesde.TabIndex = 8;
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(341, 25);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtHasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtHasta.Size = new System.Drawing.Size(128, 26);
            this.dtHasta.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "reporte_post_pellet";
            this.gridControl1.DataSource = this.dsAceites1;
            this.gridControl1.Location = new System.Drawing.Point(1, 57);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(948, 387);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.collot_pt,
            this.colcode_sap_pt,
            this.colcomercial_name,
            this.colorder_code,
            this.coldate,
            this.colintake_real,
            this.colno_coater,
            this.colid_tank,
            this.colcode,
            this.collong_name,
            this.colcode_sap_mp});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // collot_pt
            // 
            this.collot_pt.FieldName = "lot_pt";
            this.collot_pt.Name = "collot_pt";
            this.collot_pt.OptionsColumn.ReadOnly = true;
            this.collot_pt.Visible = true;
            this.collot_pt.VisibleIndex = 0;
            this.collot_pt.Width = 63;
            // 
            // colcode_sap_pt
            // 
            this.colcode_sap_pt.FieldName = "code_sap_pt";
            this.colcode_sap_pt.Name = "colcode_sap_pt";
            this.colcode_sap_pt.OptionsColumn.ReadOnly = true;
            this.colcode_sap_pt.Visible = true;
            this.colcode_sap_pt.VisibleIndex = 1;
            this.colcode_sap_pt.Width = 80;
            // 
            // colcomercial_name
            // 
            this.colcomercial_name.FieldName = "comercial_name";
            this.colcomercial_name.Name = "colcomercial_name";
            this.colcomercial_name.OptionsColumn.ReadOnly = true;
            this.colcomercial_name.Visible = true;
            this.colcomercial_name.VisibleIndex = 2;
            this.colcomercial_name.Width = 112;
            // 
            // colorder_code
            // 
            this.colorder_code.FieldName = "order_code";
            this.colorder_code.Name = "colorder_code";
            this.colorder_code.OptionsColumn.ReadOnly = true;
            this.colorder_code.Visible = true;
            this.colorder_code.VisibleIndex = 3;
            this.colorder_code.Width = 95;
            // 
            // coldate
            // 
            this.coldate.DisplayFormat.FormatString = "g";
            this.coldate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldate.FieldName = "date";
            this.coldate.Name = "coldate";
            this.coldate.OptionsColumn.ReadOnly = true;
            this.coldate.Visible = true;
            this.coldate.VisibleIndex = 4;
            this.coldate.Width = 126;
            // 
            // colintake_real
            // 
            this.colintake_real.DisplayFormat.FormatString = "n2";
            this.colintake_real.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colintake_real.FieldName = "intake_real";
            this.colintake_real.Name = "colintake_real";
            this.colintake_real.OptionsColumn.ReadOnly = true;
            this.colintake_real.Visible = true;
            this.colintake_real.VisibleIndex = 5;
            this.colintake_real.Width = 84;
            // 
            // colno_coater
            // 
            this.colno_coater.FieldName = "no_coater";
            this.colno_coater.Name = "colno_coater";
            this.colno_coater.OptionsColumn.ReadOnly = true;
            this.colno_coater.Visible = true;
            this.colno_coater.VisibleIndex = 6;
            this.colno_coater.Width = 61;
            // 
            // colid_tank
            // 
            this.colid_tank.FieldName = "id_tank";
            this.colid_tank.Name = "colid_tank";
            this.colid_tank.OptionsColumn.ReadOnly = true;
            // 
            // colcode
            // 
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.OptionsColumn.ReadOnly = true;
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 7;
            this.colcode.Width = 80;
            // 
            // collong_name
            // 
            this.collong_name.FieldName = "long_name";
            this.collong_name.Name = "collong_name";
            this.collong_name.OptionsColumn.ReadOnly = true;
            this.collong_name.Visible = true;
            this.collong_name.VisibleIndex = 8;
            this.collong_name.Width = 74;
            // 
            // colcode_sap_mp
            // 
            this.colcode_sap_mp.FieldName = "code_sap_mp";
            this.colcode_sap_mp.Name = "colcode_sap_mp";
            this.colcode_sap_mp.OptionsColumn.ReadOnly = true;
            this.colcode_sap_mp.Visible = true;
            this.colcode_sap_mp.VisibleIndex = 9;
            // 
            // frmReportePostPellet
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 445);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.CargarDatos);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmReportePostPellet.IconOptions.Icon")));
            this.Name = "frmReportePostPellet";
            this.Text = "Reporte de salida de aceites post pellet";
            ((System.ComponentModel.ISupportInitialize)(this.dsAceites1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton CargarDatos;
        private DevExpress.XtraEditors.SimpleButton cmdExportar;
        private dsAceites dsAceites1;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn collot_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colcomercial_name;
        private DevExpress.XtraGrid.Columns.GridColumn colorder_code;
        private DevExpress.XtraGrid.Columns.GridColumn coldate;
        private DevExpress.XtraGrid.Columns.GridColumn colintake_real;
        private DevExpress.XtraGrid.Columns.GridColumn colno_coater;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tank;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn collong_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap_mp;
    }
}