namespace LOSA.AlmacenesExterno
{
    partial class xfrmDetalleIngresoAlmacenExterno
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmDetalleIngresoAlmacenExterno));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcIngreso = new DevExpress.XtraGrid.GridControl();
            this.dsAlmacenesExternos1 = new LOSA.AlmacenesExterno.dsAlmacenesExternos();
            this.gvIngreso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnVerLote = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlmacenesExternos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerLote)).BeginInit();
            this.SuspendLayout();
            // 
            // gcIngreso
            // 
            this.gcIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcIngreso.DataMember = "ingresos_externos_d";
            this.gcIngreso.DataSource = this.dsAlmacenesExternos1;
            this.gcIngreso.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcIngreso.Location = new System.Drawing.Point(-1, 89);
            this.gcIngreso.MainView = this.gvIngreso;
            this.gcIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcIngreso.Name = "gcIngreso";
            this.gcIngreso.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnVerLote});
            this.gcIngreso.Size = new System.Drawing.Size(951, 466);
            this.gcIngreso.TabIndex = 36;
            this.gcIngreso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvIngreso});
            // 
            // dsAlmacenesExternos1
            // 
            this.dsAlmacenesExternos1.DataSetName = "dsAlmacenesExternos";
            this.dsAlmacenesExternos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvIngreso
            // 
            this.gvIngreso.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvIngreso.Appearance.FocusedRow.Options.UseFont = true;
            this.gvIngreso.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvIngreso.Appearance.FooterPanel.Options.UseFont = true;
            this.gvIngreso.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvIngreso.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvIngreso.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvIngreso.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvIngreso.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvIngreso.Appearance.Row.Options.UseFont = true;
            this.gvIngreso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colitemcode,
            this.colitemName,
            this.colid_mp,
            this.colNumLine,
            this.colfecha_vencimiento,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colpresentacion,
            this.colid_presentacion});
            this.gvIngreso.DetailHeight = 284;
            this.gvIngreso.GridControl = this.gcIngreso;
            this.gvIngreso.Name = "gvIngreso";
            this.gvIngreso.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvIngreso.OptionsEditForm.PopupEditFormWidth = 686;
            this.gvIngreso.OptionsView.ShowAutoFilterRow = true;
            this.gvIngreso.OptionsView.ShowFooter = true;
            this.gvIngreso.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 21;
            this.colid.Name = "colid";
            this.colid.Width = 81;
            // 
            // colitemcode
            // 
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.MinWidth = 21;
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.Width = 81;
            // 
            // colitemName
            // 
            this.colitemName.Caption = "Materia Prima";
            this.colitemName.FieldName = "itemName";
            this.colitemName.MinWidth = 21;
            this.colitemName.Name = "colitemName";
            this.colitemName.OptionsColumn.AllowEdit = false;
            this.colitemName.OptionsFilter.AllowFilter = false;
            this.colitemName.Visible = true;
            this.colitemName.VisibleIndex = 0;
            this.colitemName.Width = 387;
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.MinWidth = 21;
            this.colid_mp.Name = "colid_mp";
            this.colid_mp.Width = 81;
            // 
            // colNumLine
            // 
            this.colNumLine.FieldName = "NumLine";
            this.colNumLine.MinWidth = 21;
            this.colNumLine.Name = "colNumLine";
            this.colNumLine.Width = 81;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "Fecha Vencimiento";
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.MinWidth = 21;
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.OptionsColumn.AllowEdit = false;
            this.colfecha_vencimiento.Width = 159;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Peso";
            this.gridColumn1.DisplayFormat.FormatString = "{0:N2}";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "peso";
            this.gridColumn1.MinWidth = 21;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "peso", "Total ={0:N2}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 136;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Unidades";
            this.gridColumn2.DisplayFormat.FormatString = "{0:N2}";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "unidades";
            this.gridColumn2.MinWidth = 21;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "unidades", "Total ={0:N2}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 120;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ver Lotes";
            this.gridColumn3.ColumnEdit = this.btnVerLote;
            this.gridColumn3.MinWidth = 21;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 150;
            // 
            // btnVerLote
            // 
            this.btnVerLote.AutoHeight = false;
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            this.btnVerLote.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnVerLote.Name = "btnVerLote";
            this.btnVerLote.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnVerLote.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnVerLote_ButtonClick);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(775, 37);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(153, 47);
            this.btnAtras.TabIndex = 37;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(-1, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(951, 20);
            this.labelControl1.TabIndex = 38;
            this.labelControl1.Text = "Detalle de Ingreso";
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Presentacion";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.OptionsColumn.AllowEdit = false;
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 1;
            this.colpresentacion.Width = 133;
            // 
            // colid_presentacion
            // 
            this.colid_presentacion.FieldName = "id_presentacion";
            this.colid_presentacion.Name = "colid_presentacion";
            // 
            // xfrmDetalleIngresoAlmacenExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 553);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gcIngreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "xfrmDetalleIngresoAlmacenExterno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gcIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlmacenesExternos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerLote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcIngreso;
        private DevExpress.XtraGrid.Views.Grid.GridView gvIngreso;
        private dsAlmacenesExternos dsAlmacenesExternos1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colitemName;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colNumLine;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnVerLote;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_presentacion;
    }
}