namespace LOSA.RRHH_Planilla.Reportes
{
    partial class frmRptBeneficiosDeducciones
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptBeneficiosDeducciones));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsPlanillaReportes1 = new LOSA.RRHH_Planilla.Reportes.dsPlanillaReportes();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_contrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposVerContrato = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colperiodicidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_restante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdRefreshDisponibles = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanillaReportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposVerContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "beneficiosydeducciones";
            this.gridControl1.DataSource = this.dsPlanillaReportes1;
            this.gridControl1.Location = new System.Drawing.Point(3, 72);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposVerContrato});
            this.gridControl1.Size = new System.Drawing.Size(1322, 688);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsPlanillaReportes1
            // 
            this.dsPlanillaReportes1.DataSetName = "dsPlanillaReportes";
            this.dsPlanillaReportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_contrato,
            this.colbarcode,
            this.colnombre_empleado,
            this.colconcepto,
            this.coltipo,
            this.colvalue,
            this.colperiodicidad,
            this.colvalor_restante});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colid_contrato
            // 
            this.colid_contrato.Caption = "# Contrato";
            this.colid_contrato.ColumnEdit = this.reposVerContrato;
            this.colid_contrato.FieldName = "id_contrato";
            this.colid_contrato.Name = "colid_contrato";
            this.colid_contrato.OptionsColumn.ReadOnly = true;
            this.colid_contrato.Visible = true;
            this.colid_contrato.VisibleIndex = 0;
            this.colid_contrato.Width = 81;
            // 
            // reposVerContrato
            // 
            this.reposVerContrato.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.converttorange_16x16;
            this.reposVerContrato.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposVerContrato.Name = "reposVerContrato";
            this.reposVerContrato.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposVerContrato_ButtonClick);
            // 
            // colbarcode
            // 
            this.colbarcode.Caption = "Codigo";
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.OptionsColumn.ReadOnly = true;
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 1;
            this.colbarcode.Width = 117;
            // 
            // colnombre_empleado
            // 
            this.colnombre_empleado.Caption = "Nombre Empleado";
            this.colnombre_empleado.FieldName = "nombre_empleado";
            this.colnombre_empleado.Name = "colnombre_empleado";
            this.colnombre_empleado.OptionsColumn.ReadOnly = true;
            this.colnombre_empleado.Visible = true;
            this.colnombre_empleado.VisibleIndex = 2;
            this.colnombre_empleado.Width = 210;
            // 
            // colconcepto
            // 
            this.colconcepto.Caption = "Concepto";
            this.colconcepto.FieldName = "concepto";
            this.colconcepto.Name = "colconcepto";
            this.colconcepto.OptionsColumn.ReadOnly = true;
            this.colconcepto.Visible = true;
            this.colconcepto.VisibleIndex = 3;
            this.colconcepto.Width = 176;
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo";
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.OptionsColumn.ReadOnly = true;
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 4;
            this.coltipo.Width = 176;
            // 
            // colvalue
            // 
            this.colvalue.Caption = "Valor";
            this.colvalue.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colvalue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalue.FieldName = "value";
            this.colvalue.Name = "colvalue";
            this.colvalue.OptionsColumn.ReadOnly = true;
            this.colvalue.Visible = true;
            this.colvalue.VisibleIndex = 5;
            this.colvalue.Width = 176;
            // 
            // colperiodicidad
            // 
            this.colperiodicidad.Caption = "Recurrencia";
            this.colperiodicidad.FieldName = "periodicidad";
            this.colperiodicidad.Name = "colperiodicidad";
            this.colperiodicidad.OptionsColumn.ReadOnly = true;
            this.colperiodicidad.Visible = true;
            this.colperiodicidad.VisibleIndex = 6;
            this.colperiodicidad.Width = 176;
            // 
            // colvalor_restante
            // 
            this.colvalor_restante.Caption = "Valor Restante";
            this.colvalor_restante.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colvalor_restante.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalor_restante.FieldName = "valor_restante";
            this.colvalor_restante.Name = "colvalor_restante";
            this.colvalor_restante.OptionsColumn.ReadOnly = true;
            this.colvalor_restante.Visible = true;
            this.colvalor_restante.VisibleIndex = 7;
            this.colvalor_restante.Width = 185;
            // 
            // cmdRefreshDisponibles
            // 
            this.cmdRefreshDisponibles.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdRefreshDisponibles.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmdRefreshDisponibles.Appearance.Options.UseBackColor = true;
            this.cmdRefreshDisponibles.Appearance.Options.UseFont = true;
            this.cmdRefreshDisponibles.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRefreshDisponibles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRefreshDisponibles.ImageOptions.Image")));
            this.cmdRefreshDisponibles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdRefreshDisponibles.Location = new System.Drawing.Point(12, 33);
            this.cmdRefreshDisponibles.Name = "cmdRefreshDisponibles";
            this.cmdRefreshDisponibles.Size = new System.Drawing.Size(114, 33);
            this.cmdRefreshDisponibles.TabIndex = 150;
            this.cmdRefreshDisponibles.Text = "Cargar";
            this.cmdRefreshDisponibles.Click += new System.EventHandler(this.cmdRefreshDisponibles_Click);
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = global::LOSA.Properties.Resources.excel32px;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(148, 33);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(114, 33);
            this.btnExport.TabIndex = 162;
            this.btnExport.Text = "Exportar";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmRptBeneficiosDeducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 764);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cmdRefreshDisponibles);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmRptBeneficiosDeducciones";
            this.Text = "Beneficios y Deducciones";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanillaReportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposVerContrato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsPlanillaReportes dsPlanillaReportes1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_contrato;
        private DevExpress.XtraGrid.Columns.GridColumn colbarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colconcepto;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colvalue;
        private DevExpress.XtraGrid.Columns.GridColumn colperiodicidad;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_restante;
        private DevExpress.XtraEditors.SimpleButton cmdRefreshDisponibles;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposVerContrato;
        private System.Windows.Forms.Button btnExport;
    }
}