namespace LOSA.Compras
{
    partial class frmAddGastosAdicionales
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddGastosAdicionales));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsCompras1 = new LOSA.Compras.dsCompras();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltaxcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpnsCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposgridConceptos = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.expnscodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colimport_isv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmtd_distrb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposgridDistribucion = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.metododistribuciongastosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colimporta_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposgridConceptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expnscodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposgridDistribucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metododistribuciongastosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "gastos_adicionales";
            this.gridControl1.DataSource = this.dsCompras1;
            this.gridControl1.Location = new System.Drawing.Point(0, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposgridConceptos,
            this.reposgridDistribucion});
            this.gridControl1.Size = new System.Drawing.Size(840, 285);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltaxcode,
            this.colExpnsCode,
            this.colimport_isv,
            this.colmtd_distrb,
            this.colimporta_total,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // coltaxcode
            // 
            this.coltaxcode.Caption = "Indicador de Impuestos";
            this.coltaxcode.FieldName = "taxcode";
            this.coltaxcode.Name = "coltaxcode";
            this.coltaxcode.OptionsColumn.ReadOnly = true;
            this.coltaxcode.Visible = true;
            this.coltaxcode.VisibleIndex = 1;
            // 
            // colExpnsCode
            // 
            this.colExpnsCode.Caption = "Descripcion del gasto adicional";
            this.colExpnsCode.ColumnEdit = this.reposgridConceptos;
            this.colExpnsCode.FieldName = "expnscode";
            this.colExpnsCode.Name = "colExpnsCode";
            this.colExpnsCode.OptionsColumn.AllowEdit = false;
            this.colExpnsCode.Visible = true;
            this.colExpnsCode.VisibleIndex = 0;
            // 
            // reposgridConceptos
            // 
            this.reposgridConceptos.AutoHeight = false;
            this.reposgridConceptos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposgridConceptos.DataSource = this.expnscodeBindingSource;
            this.reposgridConceptos.DisplayMember = "expnscode";
            this.reposgridConceptos.Name = "reposgridConceptos";
            this.reposgridConceptos.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.reposgridConceptos.ValueMember = "id";
            // 
            // expnscodeBindingSource
            // 
            this.expnscodeBindingSource.DataMember = "expnscode";
            this.expnscodeBindingSource.DataSource = this.dsCompras1;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colimport_isv
            // 
            this.colimport_isv.Caption = "Monto total impuesto";
            this.colimport_isv.DisplayFormat.FormatString = "n6";
            this.colimport_isv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colimport_isv.FieldName = "import_isv";
            this.colimport_isv.Name = "colimport_isv";
            this.colimport_isv.Visible = true;
            this.colimport_isv.VisibleIndex = 2;
            // 
            // colmtd_distrb
            // 
            this.colmtd_distrb.Caption = "Metodo de distribucion";
            this.colmtd_distrb.ColumnEdit = this.reposgridDistribucion;
            this.colmtd_distrb.FieldName = "mtd_distrb";
            this.colmtd_distrb.Name = "colmtd_distrb";
            this.colmtd_distrb.Visible = true;
            this.colmtd_distrb.VisibleIndex = 3;
            // 
            // reposgridDistribucion
            // 
            this.reposgridDistribucion.AutoHeight = false;
            this.reposgridDistribucion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reposgridDistribucion.DataSource = this.metododistribuciongastosBindingSource;
            this.reposgridDistribucion.DisplayMember = "mtd_distrb";
            this.reposgridDistribucion.Name = "reposgridDistribucion";
            this.reposgridDistribucion.PopupView = this.repositoryItemGridLookUpEdit2View;
            this.reposgridDistribucion.ValueMember = "code";
            // 
            // metododistribuciongastosBindingSource
            // 
            this.metododistribuciongastosBindingSource.DataMember = "metodo_distribucion_gastos";
            this.metododistribuciongastosBindingSource.DataSource = this.dsCompras1;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colimporta_total
            // 
            this.colimporta_total.Caption = "Importe Neto";
            this.colimporta_total.DisplayFormat.FormatString = "n6";
            this.colimporta_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colimporta_total.FieldName = "importa_total";
            this.colimporta_total.Name = "colimporta_total";
            this.colimporta_total.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "importa_total", "Total Gastos ={0:0.##}")});
            this.colimporta_total.Visible = true;
            this.colimporta_total.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "detalle_gasto";
            this.gridColumn1.FieldName = "id_detalle_gasto";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmdClose);
            this.panelControl1.Controls.Add(this.cmdGuardar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(840, 49);
            this.panelControl1.TabIndex = 1;
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.ImageOptions.Image")));
            this.cmdClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdClose.Location = new System.Drawing.Point(781, 10);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(47, 33);
            this.cmdClose.TabIndex = 53;
            this.cmdClose.ToolTip = "Cerrar Ventana";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.ImageOptions.Image")));
            this.cmdGuardar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(12, 10);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(47, 33);
            this.cmdGuardar.TabIndex = 52;
            this.cmdGuardar.ToolTip = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // frmAddGastosAdicionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 334);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmAddGastosAdicionales";
            this.Text = "Adicion de Gastos Adicionales";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposgridConceptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expnscodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposgridDistribucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metododistribuciongastosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private dsCompras dsCompras1;
        private DevExpress.XtraGrid.Columns.GridColumn coltaxcode;
        private DevExpress.XtraGrid.Columns.GridColumn colExpnsCode;
        private DevExpress.XtraGrid.Columns.GridColumn colimport_isv;
        private DevExpress.XtraGrid.Columns.GridColumn colmtd_distrb;
        private DevExpress.XtraGrid.Columns.GridColumn colimporta_total;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit reposgridConceptos;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit reposgridDistribucion;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private System.Windows.Forms.BindingSource expnscodeBindingSource;
        private System.Windows.Forms.BindingSource metododistribuciongastosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}