namespace LOSA.RRHH_Planilla.Planilla
{
    partial class frmCargaPlantillaDeduccionesBeneficios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaPlantillaDeduccionesBeneficios));
            this.gcPlantilla = new DevExpress.XtraGrid.GridControl();
            this.dsCargasPlantillas1 = new LOSA.RRHH_Planilla.Planilla.dsCargasPlantillas();
            this.gvPlantilla = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODIGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOMBRE_COLABORADOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTURNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtArchivo = new DevExpress.XtraEditors.TextEdit();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.lblPreview = new DevExpress.XtraEditors.LabelControl();
            this.lblLoaded = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tpImportados = new DevExpress.XtraTab.XtraTabPage();
            this.tpFallidos = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFallidos = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnDownload = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcPlantilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCargasPlantillas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlantilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArchivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tpImportados.SuspendLayout();
            this.tpFallidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPlantilla
            // 
            this.gcPlantilla.DataMember = "plantilla_deduccion_beneficiones";
            this.gcPlantilla.DataSource = this.dsCargasPlantillas1;
            this.gcPlantilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPlantilla.Location = new System.Drawing.Point(0, 0);
            this.gcPlantilla.MainView = this.gvPlantilla;
            this.gcPlantilla.Name = "gcPlantilla";
            this.gcPlantilla.Size = new System.Drawing.Size(1304, 392);
            this.gcPlantilla.TabIndex = 0;
            this.gcPlantilla.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPlantilla});
            // 
            // dsCargasPlantillas1
            // 
            this.dsCargasPlantillas1.DataSetName = "dsCargasPlantillas";
            this.dsCargasPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvPlantilla
            // 
            this.gvPlantilla.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPlantilla.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPlantilla.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODIGO,
            this.colNombre,
            this.colNOMBRE_COLABORADOR,
            this.colTURNO,
            this.colESTADO,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn22});
            this.gvPlantilla.GridControl = this.gcPlantilla;
            this.gvPlantilla.Name = "gvPlantilla";
            this.gvPlantilla.OptionsView.ShowAutoFilterRow = true;
            this.gvPlantilla.OptionsView.ShowGroupPanel = false;
            // 
            // colCODIGO
            // 
            this.colCODIGO.Caption = "Código";
            this.colCODIGO.FieldName = "codigo_empleado";
            this.colCODIGO.Name = "colCODIGO";
            this.colCODIGO.OptionsColumn.ReadOnly = true;
            this.colCODIGO.OptionsFilter.AllowFilter = false;
            this.colCODIGO.Visible = true;
            this.colCODIGO.VisibleIndex = 0;
            this.colCODIGO.Width = 171;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 182;
            // 
            // colNOMBRE_COLABORADOR
            // 
            this.colNOMBRE_COLABORADOR.Caption = "Fecha Efectiva";
            this.colNOMBRE_COLABORADOR.FieldName = "fecha_efectiva";
            this.colNOMBRE_COLABORADOR.Name = "colNOMBRE_COLABORADOR";
            this.colNOMBRE_COLABORADOR.OptionsColumn.ReadOnly = true;
            this.colNOMBRE_COLABORADOR.OptionsFilter.AllowFilter = false;
            this.colNOMBRE_COLABORADOR.Visible = true;
            this.colNOMBRE_COLABORADOR.VisibleIndex = 2;
            this.colNOMBRE_COLABORADOR.Width = 134;
            // 
            // colTURNO
            // 
            this.colTURNO.Caption = "Concepto";
            this.colTURNO.FieldName = "concepto_deduccion";
            this.colTURNO.Name = "colTURNO";
            this.colTURNO.OptionsColumn.ReadOnly = true;
            this.colTURNO.OptionsFilter.AllowFilter = false;
            this.colTURNO.Visible = true;
            this.colTURNO.VisibleIndex = 3;
            this.colTURNO.Width = 242;
            // 
            // colESTADO
            // 
            this.colESTADO.FieldName = "ESTADO_formateado";
            this.colESTADO.Name = "colESTADO";
            this.colESTADO.Width = 143;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cuotas";
            this.gridColumn1.FieldName = "cuotas";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 74;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tipo Deducción";
            this.gridColumn2.FieldName = "tipo_deduccion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Width = 214;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "estado_master";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 77;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "turno_id_master";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 101;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "turno_id_formateado";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Cuotas Restantes";
            this.gridColumn6.FieldName = "cuotas_restantes";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.OptionsFilter.AllowFilter = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 160;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Valor";
            this.gridColumn7.DisplayFormat.FormatString = "{0:N2}";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "valor";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.OptionsFilter.AllowFilter = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            this.gridColumn7.Width = 102;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Meses Deducción";
            this.gridColumn8.FieldName = "meses_deduccion";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.OptionsFilter.AllowFilter = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            this.gridColumn8.Width = 121;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(27, 28);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Properties.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(271, 20);
            this.txtArchivo.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBuscar.ImageOptions.SvgImage")));
            this.btnBuscar.Location = new System.Drawing.Point(304, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 38);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar Archivo";
            this.btnBuscar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuardar.ImageOptions.SvgImage")));
            this.btnGuardar.Location = new System.Drawing.Point(448, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 38);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblPreview
            // 
            this.lblPreview.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.Appearance.Options.UseFont = true;
            this.lblPreview.Location = new System.Drawing.Point(736, 2);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(186, 19);
            this.lblPreview.TabIndex = 5;
            this.lblPreview.Text = "Registros Previsualizados: 0";
            // 
            // lblLoaded
            // 
            this.lblLoaded.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblLoaded.Appearance.Options.UseFont = true;
            this.lblLoaded.Location = new System.Drawing.Point(737, 25);
            this.lblLoaded.Name = "lblLoaded";
            this.lblLoaded.Size = new System.Drawing.Size(159, 19);
            this.lblLoaded.TabIndex = 6;
            this.lblLoaded.Text = "Registros Procesados: 0";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 71);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tpImportados;
            this.xtraTabControl1.Size = new System.Drawing.Size(1306, 417);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpImportados,
            this.tpFallidos});
            // 
            // tpImportados
            // 
            this.tpImportados.Controls.Add(this.gcPlantilla);
            this.tpImportados.Name = "tpImportados";
            this.tpImportados.Size = new System.Drawing.Size(1304, 392);
            this.tpImportados.Text = "Importados (0)";
            // 
            // tpFallidos
            // 
            this.tpFallidos.Controls.Add(this.gridControl1);
            this.tpFallidos.Name = "tpFallidos";
            this.tpFallidos.Size = new System.Drawing.Size(1304, 392);
            this.tpFallidos.Text = "Fallidos (0)";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "plantilla_deduccion_beneficiones_failure";
            this.gridControl1.DataSource = this.dsCargasPlantillas1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1304, 392);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Código";
            this.gridColumn9.FieldName = "codigo_empleado";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.OptionsFilter.AllowFilter = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            this.gridColumn9.Width = 114;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Fecha Efectiva";
            this.gridColumn10.FieldName = "fecha_efectiva";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.OptionsFilter.AllowFilter = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 98;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Concepto";
            this.gridColumn11.FieldName = "concepto";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.ReadOnly = true;
            this.gridColumn11.OptionsFilter.AllowFilter = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            this.gridColumn11.Width = 94;
            // 
            // gridColumn12
            // 
            this.gridColumn12.FieldName = "ESTADO_formateado";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Width = 143;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Cuotas";
            this.gridColumn13.FieldName = "cuotas";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.ReadOnly = true;
            this.gridColumn13.OptionsFilter.AllowFilter = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 4;
            this.gridColumn13.Width = 179;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Tipo Deducción";
            this.gridColumn14.FieldName = "tipo_deduccion_beneficio";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.ReadOnly = true;
            this.gridColumn14.OptionsFilter.AllowFilter = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 3;
            this.gridColumn14.Width = 119;
            // 
            // gridColumn15
            // 
            this.gridColumn15.FieldName = "estado_master";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Width = 77;
            // 
            // gridColumn16
            // 
            this.gridColumn16.FieldName = "turno_id_master";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Width = 101;
            // 
            // gridColumn17
            // 
            this.gridColumn17.FieldName = "turno_id_formateado";
            this.gridColumn17.Name = "gridColumn17";
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Cuotas Restantes";
            this.gridColumn18.FieldName = "cuotas_restantes";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.OptionsColumn.ReadOnly = true;
            this.gridColumn18.OptionsFilter.AllowFilter = false;
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 5;
            this.gridColumn18.Width = 135;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Valor";
            this.gridColumn19.FieldName = "valor";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.ReadOnly = true;
            this.gridColumn19.OptionsFilter.AllowFilter = false;
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 6;
            this.gridColumn19.Width = 102;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Meses Deducción";
            this.gridColumn20.FieldName = "meses_deduccion_beneficio";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsColumn.ReadOnly = true;
            this.gridColumn20.OptionsFilter.AllowFilter = false;
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 7;
            this.gridColumn20.Width = 126;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Causa del Fallo";
            this.gridColumn21.FieldName = "evento";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.ReadOnly = true;
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 8;
            this.gridColumn21.Width = 312;
            // 
            // lblFallidos
            // 
            this.lblFallidos.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblFallidos.Appearance.Options.UseFont = true;
            this.lblFallidos.Location = new System.Drawing.Point(737, 48);
            this.lblFallidos.Name = "lblFallidos";
            this.lblFallidos.Size = new System.Drawing.Size(133, 19);
            this.lblFallidos.TabIndex = 8;
            this.lblFallidos.Text = "Registros Fallidos: 0";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancelar.ImageOptions.SvgImage")));
            this.btnCancelar.Location = new System.Drawing.Point(1169, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 38);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.simpleButton1_Click_2);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.Appearance.Options.UseTextOptions = true;
            this.btnDownload.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnDownload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDownload.ImageOptions.SvgImage")));
            this.btnDownload.Location = new System.Drawing.Point(1058, 19);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(105, 38);
            this.btnDownload.TabIndex = 10;
            this.btnDownload.Text = "Descargar Plantilla";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Tipo";
            this.gridColumn22.FieldName = "tipo";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.OptionsColumn.ReadOnly = true;
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 4;
            this.gridColumn22.Width = 93;
            // 
            // frmCargaPlantillaDeduccionesBeneficios
            // 
            this.Appearance.Options.UseTextOptions = true;
            this.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 489);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblFallidos);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.lblLoaded);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtArchivo);
            this.Name = "frmCargaPlantillaDeduccionesBeneficios";
            this.Text = "Carga Masiva de Deducciones o Beneficios";
            ((System.ComponentModel.ISupportInitialize)(this.gcPlantilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCargasPlantillas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlantilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArchivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tpImportados.ResumeLayout(false);
            this.tpFallidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPlantilla;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPlantilla;
        private DevExpress.XtraGrid.Columns.GridColumn colCODIGO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOMBRE_COLABORADOR;
        private DevExpress.XtraGrid.Columns.GridColumn colTURNO;
        private DevExpress.XtraGrid.Columns.GridColumn colESTADO;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.TextEdit txtArchivo;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
    
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.LabelControl lblPreview;
        private DevExpress.XtraEditors.LabelControl lblLoaded;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tpImportados;
        private DevExpress.XtraTab.XtraTabPage tpFallidos;
        private DevExpress.XtraEditors.LabelControl lblFallidos;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnDownload;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private dsCargasPlantillas dsCargasPlantillas1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
    }
}