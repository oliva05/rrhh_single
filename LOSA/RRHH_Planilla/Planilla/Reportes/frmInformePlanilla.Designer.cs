namespace LOSA.RRHH_Planilla.Planilla.Reportes
{
    partial class frmInformePlanilla
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
            this.gcPlanilla = new DevExpress.XtraGrid.GridControl();
            this.dsReporte1 = new LOSA.RRHH_Planilla.Planilla.Reportes.dsReporte();
            this.gvPlanilla = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colempleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidentidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasLaborados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasFaltados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalarioBase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvacaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltransporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtrosIngresos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalIngresos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAhorroFijoCoop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrestamoCoop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCafeteria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAhorroRetCoop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtrasDeduccionesCoop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanDental = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeguroMedico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSULA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIHSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINCAPACIDADES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalEgresos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.slueNomina = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.paysliplookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colplanilla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexport = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tpPlanillaGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.tpPlanillaHE = new DevExpress.XtraTab.XtraTabPage();
            this.gcHE = new DevExpress.XtraGrid.GridControl();
            this.bgvHE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.coldepartamento1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colempleado1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcodigo_empleado = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colidentidad1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcargo1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colsalario_hora = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gbSalarioBase = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colquantity_BASE_EX = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colsaldo_BASE_EX = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colquantity_PHE25 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colsaldo_PHE25 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colquantity_PHE50 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colsaldo_PHE50 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colquantity_PHE75 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colsaldo_PHE75 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colquantity_PHE100 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colsaldo_PHE100 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colquantity_TPHE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colsaldo_TPHE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.tpDecimoTercero = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvDecimoTercero = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldepartamento2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colempleado2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_empleado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidentidad2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcargo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTCAVO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBANC2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRCOOP3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNET = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcPlanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paysliplookupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tpPlanillaGeneral.SuspendLayout();
            this.tpPlanillaHE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvHE)).BeginInit();
            this.tpDecimoTercero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDecimoTercero)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPlanilla
            // 
            this.gcPlanilla.DataMember = "rptPlanillaGeneral";
            this.gcPlanilla.DataSource = this.dsReporte1;
            this.gcPlanilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPlanilla.Location = new System.Drawing.Point(0, 0);
            this.gcPlanilla.MainView = this.gvPlanilla;
            this.gcPlanilla.Name = "gcPlanilla";
            this.gcPlanilla.Size = new System.Drawing.Size(1494, 473);
            this.gcPlanilla.TabIndex = 0;
            this.gcPlanilla.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPlanilla});
            // 
            // dsReporte1
            // 
            this.dsReporte1.DataSetName = "dsReporte";
            this.dsReporte1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvPlanilla
            // 
            this.gvPlanilla.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPlanilla.Appearance.FooterPanel.Options.UseFont = true;
            this.gvPlanilla.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gvPlanilla.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gvPlanilla.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvPlanilla.Appearance.GroupFooter.Options.UseFont = true;
            this.gvPlanilla.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gvPlanilla.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gvPlanilla.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPlanilla.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPlanilla.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPlanilla.Appearance.Row.Options.UseFont = true;
            this.gvPlanilla.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldepartamento,
            this.colempleado,
            this.colidentidad,
            this.colcargo,
            this.colDiasLaborados,
            this.colDiasFaltados,
            this.colSalarioBase,
            this.colvacaciones,
            this.coltransporte,
            this.colOtrosIngresos,
            this.colTotalIngresos,
            this.colAhorroFijoCoop,
            this.colBancos,
            this.colPrestamoCoop,
            this.colCafeteria,
            this.colAhorroRetCoop,
            this.colOtrasDeduccionesCoop,
            this.colPlanDental,
            this.colSeguroMedico,
            this.colUSULA,
            this.colIHSS,
            this.colINCAPACIDADES,
            this.colISR,
            this.colTotalEgresos,
            this.colTotalPagar,
            this.gridColumn1});
            this.gvPlanilla.GridControl = this.gcPlanilla;
            this.gvPlanilla.GroupCount = 1;
            this.gvPlanilla.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DiasFaltados", this.colDiasFaltados, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DiasLaborados", this.colDiasLaborados, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SalarioBase", this.colSalarioBase, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "vacaciones", this.colvacaciones, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "transporte", this.coltransporte, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OtrosIngresos", this.colOtrosIngresos, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalIngresos", this.colTotalIngresos, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AhorroFijoCoop", this.colAhorroFijoCoop, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Bancos", this.colBancos, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrestamoCoop", this.colPrestamoCoop, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cafeteria", this.colCafeteria, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AhorroRetCoop", this.colAhorroRetCoop, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OtrasDeduccionesCoop", this.colOtrasDeduccionesCoop, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanDental", this.colPlanDental, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SeguroMedico", this.colSeguroMedico, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "USULA", this.colUSULA, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IHSS", this.colIHSS, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "INCAPACIDADES", this.colINCAPACIDADES, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ISR", this.colISR, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalEgresos", this.colTotalEgresos, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPagar", this.colTotalPagar, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "cargo", this.colcargo, "Totales")});
            this.gvPlanilla.Name = "gvPlanilla";
            this.gvPlanilla.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvPlanilla.OptionsView.ShowFooter = true;
            this.gvPlanilla.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coldepartamento, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // coldepartamento
            // 
            this.coldepartamento.Caption = "Departamento";
            this.coldepartamento.FieldName = "departamento";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.Visible = true;
            this.coldepartamento.VisibleIndex = 0;
            // 
            // colempleado
            // 
            this.colempleado.Caption = "Empleado";
            this.colempleado.FieldName = "empleado";
            this.colempleado.Name = "colempleado";
            this.colempleado.Visible = true;
            this.colempleado.VisibleIndex = 0;
            this.colempleado.Width = 57;
            // 
            // colidentidad
            // 
            this.colidentidad.Caption = "Identidad";
            this.colidentidad.FieldName = "identidad";
            this.colidentidad.Name = "colidentidad";
            this.colidentidad.Visible = true;
            this.colidentidad.VisibleIndex = 1;
            this.colidentidad.Width = 57;
            // 
            // colcargo
            // 
            this.colcargo.Caption = "Cargo";
            this.colcargo.FieldName = "cargo";
            this.colcargo.Name = "colcargo";
            this.colcargo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "cargo", "Gran Total")});
            this.colcargo.Visible = true;
            this.colcargo.VisibleIndex = 2;
            this.colcargo.Width = 57;
            // 
            // colDiasLaborados
            // 
            this.colDiasLaborados.DisplayFormat.FormatString = "{0:N2}";
            this.colDiasLaborados.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiasLaborados.FieldName = "DiasLaborados";
            this.colDiasLaborados.Name = "colDiasLaborados";
            this.colDiasLaborados.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DiasLaborados", "{0:N2}")});
            this.colDiasLaborados.Visible = true;
            this.colDiasLaborados.VisibleIndex = 3;
            this.colDiasLaborados.Width = 53;
            // 
            // colDiasFaltados
            // 
            this.colDiasFaltados.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiasFaltados.FieldName = "DiasFaltados";
            this.colDiasFaltados.Name = "colDiasFaltados";
            this.colDiasFaltados.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DiasFaltados", "{0:N2}")});
            this.colDiasFaltados.Visible = true;
            this.colDiasFaltados.VisibleIndex = 4;
            this.colDiasFaltados.Width = 56;
            // 
            // colSalarioBase
            // 
            this.colSalarioBase.DisplayFormat.FormatString = "{0:N2}";
            this.colSalarioBase.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalarioBase.FieldName = "SalarioBase";
            this.colSalarioBase.Name = "colSalarioBase";
            this.colSalarioBase.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SalarioBase", "{0:N2}")});
            this.colSalarioBase.Visible = true;
            this.colSalarioBase.VisibleIndex = 5;
            this.colSalarioBase.Width = 56;
            // 
            // colvacaciones
            // 
            this.colvacaciones.Caption = "Vacaciones";
            this.colvacaciones.DisplayFormat.FormatString = "{0:N2}";
            this.colvacaciones.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvacaciones.FieldName = "vacaciones";
            this.colvacaciones.Name = "colvacaciones";
            this.colvacaciones.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "vacaciones", "{0:N2}")});
            this.colvacaciones.Visible = true;
            this.colvacaciones.VisibleIndex = 6;
            this.colvacaciones.Width = 56;
            // 
            // coltransporte
            // 
            this.coltransporte.Caption = "Transporte";
            this.coltransporte.DisplayFormat.FormatString = "{0:N2}";
            this.coltransporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltransporte.FieldName = "transporte";
            this.coltransporte.Name = "coltransporte";
            this.coltransporte.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "transporte", "{0:N2}")});
            this.coltransporte.Visible = true;
            this.coltransporte.VisibleIndex = 7;
            this.coltransporte.Width = 56;
            // 
            // colOtrosIngresos
            // 
            this.colOtrosIngresos.DisplayFormat.FormatString = "{0:N2}";
            this.colOtrosIngresos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOtrosIngresos.FieldName = "OtrosIngresos";
            this.colOtrosIngresos.Name = "colOtrosIngresos";
            this.colOtrosIngresos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OtrosIngresos", "{0:N2}")});
            this.colOtrosIngresos.Visible = true;
            this.colOtrosIngresos.VisibleIndex = 8;
            this.colOtrosIngresos.Width = 56;
            // 
            // colTotalIngresos
            // 
            this.colTotalIngresos.DisplayFormat.FormatString = "{0:N2}";
            this.colTotalIngresos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalIngresos.FieldName = "TotalIngresos";
            this.colTotalIngresos.Name = "colTotalIngresos";
            this.colTotalIngresos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalIngresos", "{0:N2}")});
            this.colTotalIngresos.Visible = true;
            this.colTotalIngresos.VisibleIndex = 9;
            this.colTotalIngresos.Width = 56;
            // 
            // colAhorroFijoCoop
            // 
            this.colAhorroFijoCoop.Caption = "Ahorro Fijo Coop.";
            this.colAhorroFijoCoop.DisplayFormat.FormatString = "{0:N2}";
            this.colAhorroFijoCoop.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAhorroFijoCoop.FieldName = "AhorroFijoCoop";
            this.colAhorroFijoCoop.Name = "colAhorroFijoCoop";
            this.colAhorroFijoCoop.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AhorroFijoCoop", "{0:N2}")});
            this.colAhorroFijoCoop.Visible = true;
            this.colAhorroFijoCoop.VisibleIndex = 10;
            this.colAhorroFijoCoop.Width = 56;
            // 
            // colBancos
            // 
            this.colBancos.DisplayFormat.FormatString = "{0:N2}";
            this.colBancos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBancos.FieldName = "Bancos";
            this.colBancos.Name = "colBancos";
            this.colBancos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Bancos", "{0:N2}")});
            this.colBancos.Visible = true;
            this.colBancos.VisibleIndex = 11;
            this.colBancos.Width = 56;
            // 
            // colPrestamoCoop
            // 
            this.colPrestamoCoop.Caption = "Prestamo Coop";
            this.colPrestamoCoop.DisplayFormat.FormatString = "{0:N2}";
            this.colPrestamoCoop.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrestamoCoop.FieldName = "PrestamoCoop";
            this.colPrestamoCoop.Name = "colPrestamoCoop";
            this.colPrestamoCoop.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrestamoCoop", "{0:N2}")});
            this.colPrestamoCoop.Visible = true;
            this.colPrestamoCoop.VisibleIndex = 12;
            this.colPrestamoCoop.Width = 56;
            // 
            // colCafeteria
            // 
            this.colCafeteria.Caption = "Cafetería";
            this.colCafeteria.DisplayFormat.FormatString = "{0:N2}";
            this.colCafeteria.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCafeteria.FieldName = "Cafeteria";
            this.colCafeteria.Name = "colCafeteria";
            this.colCafeteria.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cafeteria", "{0:N2}")});
            this.colCafeteria.Visible = true;
            this.colCafeteria.VisibleIndex = 13;
            this.colCafeteria.Width = 56;
            // 
            // colAhorroRetCoop
            // 
            this.colAhorroRetCoop.Caption = "Ahorro Ret. Coop.";
            this.colAhorroRetCoop.DisplayFormat.FormatString = "{0:N2}";
            this.colAhorroRetCoop.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAhorroRetCoop.FieldName = "AhorroRetCoop";
            this.colAhorroRetCoop.Name = "colAhorroRetCoop";
            this.colAhorroRetCoop.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AhorroRetCoop", "{0:N2}")});
            this.colAhorroRetCoop.Visible = true;
            this.colAhorroRetCoop.VisibleIndex = 14;
            this.colAhorroRetCoop.Width = 56;
            // 
            // colOtrasDeduccionesCoop
            // 
            this.colOtrasDeduccionesCoop.Caption = "Otras Deducciones Coop.";
            this.colOtrasDeduccionesCoop.DisplayFormat.FormatString = "{0:N2}";
            this.colOtrasDeduccionesCoop.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOtrasDeduccionesCoop.FieldName = "OtrasDeduccionesCoop";
            this.colOtrasDeduccionesCoop.Name = "colOtrasDeduccionesCoop";
            this.colOtrasDeduccionesCoop.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OtrasDeduccionesCoop", "{0:N2}")});
            this.colOtrasDeduccionesCoop.Visible = true;
            this.colOtrasDeduccionesCoop.VisibleIndex = 15;
            this.colOtrasDeduccionesCoop.Width = 56;
            // 
            // colPlanDental
            // 
            this.colPlanDental.DisplayFormat.FormatString = "{0:N2}";
            this.colPlanDental.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPlanDental.FieldName = "PlanDental";
            this.colPlanDental.Name = "colPlanDental";
            this.colPlanDental.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PlanDental", "{0:N2}")});
            this.colPlanDental.Visible = true;
            this.colPlanDental.VisibleIndex = 16;
            this.colPlanDental.Width = 56;
            // 
            // colSeguroMedico
            // 
            this.colSeguroMedico.Caption = "Seguro Médico";
            this.colSeguroMedico.DisplayFormat.FormatString = "{0:N2}";
            this.colSeguroMedico.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSeguroMedico.FieldName = "SeguroMedico";
            this.colSeguroMedico.Name = "colSeguroMedico";
            this.colSeguroMedico.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SeguroMedico", "{0:N2}")});
            this.colSeguroMedico.Visible = true;
            this.colSeguroMedico.VisibleIndex = 17;
            this.colSeguroMedico.Width = 56;
            // 
            // colUSULA
            // 
            this.colUSULA.DisplayFormat.FormatString = "{0:N2}";
            this.colUSULA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUSULA.FieldName = "USULA";
            this.colUSULA.Name = "colUSULA";
            this.colUSULA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "USULA", "{0:N2}")});
            this.colUSULA.Visible = true;
            this.colUSULA.VisibleIndex = 18;
            this.colUSULA.Width = 56;
            // 
            // colIHSS
            // 
            this.colIHSS.DisplayFormat.FormatString = "{0:N2}";
            this.colIHSS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIHSS.FieldName = "IHSS";
            this.colIHSS.Name = "colIHSS";
            this.colIHSS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IHSS", "{0:N2}")});
            this.colIHSS.Visible = true;
            this.colIHSS.VisibleIndex = 19;
            this.colIHSS.Width = 56;
            // 
            // colINCAPACIDADES
            // 
            this.colINCAPACIDADES.Caption = "Incapacidades";
            this.colINCAPACIDADES.DisplayFormat.FormatString = "{0:N2}";
            this.colINCAPACIDADES.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colINCAPACIDADES.FieldName = "INCAPACIDADES";
            this.colINCAPACIDADES.Name = "colINCAPACIDADES";
            this.colINCAPACIDADES.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "INCAPACIDADES", "{0:N2}")});
            this.colINCAPACIDADES.Visible = true;
            this.colINCAPACIDADES.VisibleIndex = 20;
            this.colINCAPACIDADES.Width = 56;
            // 
            // colISR
            // 
            this.colISR.DisplayFormat.FormatString = "{0:N2}";
            this.colISR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colISR.FieldName = "ISR";
            this.colISR.Name = "colISR";
            this.colISR.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ISR", "{0:N2}")});
            this.colISR.Visible = true;
            this.colISR.VisibleIndex = 21;
            this.colISR.Width = 56;
            // 
            // colTotalEgresos
            // 
            this.colTotalEgresos.FieldName = "TotalEgresos";
            this.colTotalEgresos.Name = "colTotalEgresos";
            this.colTotalEgresos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalEgresos", "{0:N2}")});
            this.colTotalEgresos.Visible = true;
            this.colTotalEgresos.VisibleIndex = 22;
            this.colTotalEgresos.Width = 56;
            // 
            // colTotalPagar
            // 
            this.colTotalPagar.DisplayFormat.FormatString = "{0:N2}";
            this.colTotalPagar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPagar.FieldName = "TotalPagar";
            this.colTotalPagar.Name = "colTotalPagar";
            this.colTotalPagar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPagar", "{0:N2}")});
            this.colTotalPagar.Visible = true;
            this.colTotalPagar.VisibleIndex = 23;
            this.colTotalPagar.Width = 82;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            // 
            // slueNomina
            // 
            this.slueNomina.Location = new System.Drawing.Point(93, 16);
            this.slueNomina.Name = "slueNomina";
            this.slueNomina.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slueNomina.Properties.Appearance.Options.UseFont = true;
            this.slueNomina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueNomina.Properties.DataSource = this.paysliplookupBindingSource;
            this.slueNomina.Properties.DisplayMember = "planilla";
            this.slueNomina.Properties.PopupView = this.searchLookUpEdit1View;
            this.slueNomina.Properties.ValueMember = "id";
            this.slueNomina.Size = new System.Drawing.Size(451, 22);
            this.slueNomina.TabIndex = 1;
            this.slueNomina.EditValueChanged += new System.EventHandler(this.slueNomina_EditValueChanged);
            // 
            // paysliplookupBindingSource
            // 
            this.paysliplookupBindingSource.DataMember = "payslip_lookup";
            this.paysliplookupBindingSource.DataSource = this.dsReporte1;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colplanilla});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colplanilla
            // 
            this.colplanilla.Caption = "Planilla";
            this.colplanilla.FieldName = "planilla";
            this.colplanilla.Name = "colplanilla";
            this.colplanilla.Visible = true;
            this.colplanilla.VisibleIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(37, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Planilla:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(259, 74);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(45, 15);
            this.lblCodigo.TabIndex = 45;
            this.lblCodigo.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(206, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Código:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(90, 74);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(45, 15);
            this.lblHasta.TabIndex = 43;
            this.lblHasta.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(90, 54);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(45, 15);
            this.lblDesde.TabIndex = 41;
            this.lblDesde.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Desde:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(259, 54);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 39;
            this.lblEstado.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Estado:";
            // 
            // btnexport
            // 
            this.btnexport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexport.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Appearance.Options.UseFont = true;
            this.btnexport.Appearance.Options.UseTextOptions = true;
            this.btnexport.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnexport.ImageOptions.Image = global::LOSA.Properties.Resources.sobresalir24;
            this.btnexport.Location = new System.Drawing.Point(1269, 36);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(98, 42);
            this.btnexport.TabIndex = 135;
            this.btnexport.Text = "Exportar a excel";
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ImageOptions.Image = global::LOSA.Properties.Resources.impresora_24X24;
            this.btnPrint.Location = new System.Drawing.Point(1165, 36);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 42);
            this.btnPrint.TabIndex = 136;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = global::LOSA.Properties.Resources.Danieledesantis_Playstation_Flat_Playstation_cross_black_and_white_24;
            this.simpleButton1.Location = new System.Drawing.Point(1373, 36);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(98, 42);
            this.simpleButton1.TabIndex = 137;
            this.simpleButton1.Text = "Cerrar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 113);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tpPlanillaGeneral;
            this.xtraTabControl1.Size = new System.Drawing.Size(1496, 502);
            this.xtraTabControl1.TabIndex = 138;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpPlanillaGeneral,
            this.tpPlanillaHE,
            this.tpDecimoTercero});
            // 
            // tpPlanillaGeneral
            // 
            this.tpPlanillaGeneral.Controls.Add(this.gcPlanilla);
            this.tpPlanillaGeneral.Name = "tpPlanillaGeneral";
            this.tpPlanillaGeneral.Size = new System.Drawing.Size(1494, 473);
            this.tpPlanillaGeneral.Text = "Planilla General";
            // 
            // tpPlanillaHE
            // 
            this.tpPlanillaHE.Controls.Add(this.gcHE);
            this.tpPlanillaHE.Name = "tpPlanillaHE";
            this.tpPlanillaHE.PageVisible = false;
            this.tpPlanillaHE.Size = new System.Drawing.Size(1494, 473);
            this.tpPlanillaHE.Text = "Planilla General de HE";
            // 
            // gcHE
            // 
            this.gcHE.DataMember = "rptPlanillaGeneralHE";
            this.gcHE.DataSource = this.dsReporte1;
            this.gcHE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHE.Location = new System.Drawing.Point(0, 0);
            this.gcHE.MainView = this.bgvHE;
            this.gcHE.Name = "gcHE";
            this.gcHE.Size = new System.Drawing.Size(1494, 473);
            this.gcHE.TabIndex = 0;
            this.gcHE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgvHE});
            // 
            // bgvHE
            // 
            this.bgvHE.Appearance.BandPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgvHE.Appearance.BandPanel.Options.UseFont = true;
            this.bgvHE.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgvHE.Appearance.FooterPanel.Options.UseFont = true;
            this.bgvHE.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.bgvHE.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bgvHE.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgvHE.Appearance.GroupFooter.Options.UseFont = true;
            this.bgvHE.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.bgvHE.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.bgvHE.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.bgvHE.Appearance.HeaderPanel.Options.UseFont = true;
            this.bgvHE.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgvHE.Appearance.Row.Options.UseFont = true;
            this.bgvHE.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gbSalarioBase,
            this.gridBand3,
            this.gridBand2,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6});
            this.bgvHE.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.coldepartamento1,
            this.colempleado1,
            this.colcodigo_empleado,
            this.colidentidad1,
            this.colcargo1,
            this.colsaldo_BASE_EX,
            this.colsaldo_PHE25,
            this.colsaldo_PHE50,
            this.colsaldo_PHE75,
            this.colsaldo_PHE100,
            this.colsaldo_TPHE,
            this.colquantity_BASE_EX,
            this.colquantity_PHE25,
            this.colquantity_PHE50,
            this.colquantity_PHE75,
            this.colquantity_PHE100,
            this.colquantity_TPHE,
            this.colsalario_hora});
            this.bgvHE.GridControl = this.gcHE;
            this.bgvHE.GroupCount = 1;
            this.bgvHE.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "cargo", this.colcargo1, "Total Horas Extras"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "quantity_TPHE", this.colquantity_TPHE, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "saldo_TPHE", this.colsaldo_TPHE, "{0:N2}")});
            this.bgvHE.Name = "bgvHE";
            this.bgvHE.OptionsBehavior.AutoExpandAllGroups = true;
            this.bgvHE.OptionsView.ShowFooter = true;
            this.bgvHE.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coldepartamento1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.coldepartamento1);
            this.gridBand1.Columns.Add(this.colempleado1);
            this.gridBand1.Columns.Add(this.colcodigo_empleado);
            this.gridBand1.Columns.Add(this.colidentidad1);
            this.gridBand1.Columns.Add(this.colcargo1);
            this.gridBand1.Columns.Add(this.colsalario_hora);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.AllowMove = false;
            this.gridBand1.OptionsBand.AllowSize = false;
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 492;
            // 
            // coldepartamento1
            // 
            this.coldepartamento1.Caption = "Departamento";
            this.coldepartamento1.FieldName = "departamento";
            this.coldepartamento1.Name = "coldepartamento1";
            // 
            // colempleado1
            // 
            this.colempleado1.Caption = "Empleado";
            this.colempleado1.FieldName = "empleado";
            this.colempleado1.Name = "colempleado1";
            this.colempleado1.OptionsColumn.ReadOnly = true;
            this.colempleado1.OptionsFilter.AllowFilter = false;
            this.colempleado1.Visible = true;
            this.colempleado1.Width = 100;
            // 
            // colcodigo_empleado
            // 
            this.colcodigo_empleado.Caption = "Código";
            this.colcodigo_empleado.FieldName = "codigo_empleado";
            this.colcodigo_empleado.Name = "colcodigo_empleado";
            this.colcodigo_empleado.OptionsColumn.AllowMove = false;
            this.colcodigo_empleado.OptionsColumn.ReadOnly = true;
            this.colcodigo_empleado.OptionsFilter.AllowFilter = false;
            this.colcodigo_empleado.Visible = true;
            this.colcodigo_empleado.Width = 100;
            // 
            // colidentidad1
            // 
            this.colidentidad1.Caption = "Identidad";
            this.colidentidad1.FieldName = "identidad";
            this.colidentidad1.Name = "colidentidad1";
            this.colidentidad1.OptionsColumn.AllowMove = false;
            this.colidentidad1.OptionsColumn.ReadOnly = true;
            this.colidentidad1.OptionsFilter.AllowFilter = false;
            this.colidentidad1.Visible = true;
            this.colidentidad1.Width = 100;
            // 
            // colcargo1
            // 
            this.colcargo1.Caption = "Cargo";
            this.colcargo1.FieldName = "cargo";
            this.colcargo1.Name = "colcargo1";
            this.colcargo1.OptionsColumn.AllowMove = false;
            this.colcargo1.OptionsColumn.ReadOnly = true;
            this.colcargo1.OptionsFilter.AllowFilter = false;
            this.colcargo1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "cargo", "Gran Total")});
            this.colcargo1.Visible = true;
            this.colcargo1.Width = 81;
            // 
            // colsalario_hora
            // 
            this.colsalario_hora.Caption = "Salario x Hora";
            this.colsalario_hora.FieldName = "salario_hora";
            this.colsalario_hora.Name = "colsalario_hora";
            this.colsalario_hora.OptionsColumn.AllowMove = false;
            this.colsalario_hora.OptionsColumn.ReadOnly = true;
            this.colsalario_hora.OptionsFilter.AllowFilter = false;
            this.colsalario_hora.Visible = true;
            this.colsalario_hora.Width = 111;
            // 
            // gbSalarioBase
            // 
            this.gbSalarioBase.AppearanceHeader.Options.UseTextOptions = true;
            this.gbSalarioBase.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gbSalarioBase.Caption = "Salario Base";
            this.gbSalarioBase.Columns.Add(this.colquantity_BASE_EX);
            this.gbSalarioBase.Columns.Add(this.colsaldo_BASE_EX);
            this.gbSalarioBase.Name = "gbSalarioBase";
            this.gbSalarioBase.VisibleIndex = 1;
            this.gbSalarioBase.Width = 153;
            // 
            // colquantity_BASE_EX
            // 
            this.colquantity_BASE_EX.AppearanceCell.Options.UseTextOptions = true;
            this.colquantity_BASE_EX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colquantity_BASE_EX.AppearanceHeader.Options.UseTextOptions = true;
            this.colquantity_BASE_EX.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colquantity_BASE_EX.Caption = "Cant.";
            this.colquantity_BASE_EX.DisplayFormat.FormatString = "{0:N2}";
            this.colquantity_BASE_EX.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colquantity_BASE_EX.FieldName = "quantity_BASE_EX";
            this.colquantity_BASE_EX.Name = "colquantity_BASE_EX";
            this.colquantity_BASE_EX.OptionsColumn.AllowMove = false;
            this.colquantity_BASE_EX.OptionsColumn.ReadOnly = true;
            this.colquantity_BASE_EX.OptionsFilter.AllowFilter = false;
            this.colquantity_BASE_EX.Visible = true;
            this.colquantity_BASE_EX.Width = 70;
            // 
            // colsaldo_BASE_EX
            // 
            this.colsaldo_BASE_EX.AppearanceCell.Options.UseTextOptions = true;
            this.colsaldo_BASE_EX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colsaldo_BASE_EX.AppearanceHeader.Options.UseTextOptions = true;
            this.colsaldo_BASE_EX.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsaldo_BASE_EX.Caption = "BASE_EX";
            this.colsaldo_BASE_EX.DisplayFormat.FormatString = "{0:N2}";
            this.colsaldo_BASE_EX.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsaldo_BASE_EX.FieldName = "saldo_BASE_EX";
            this.colsaldo_BASE_EX.Name = "colsaldo_BASE_EX";
            this.colsaldo_BASE_EX.OptionsColumn.AllowMove = false;
            this.colsaldo_BASE_EX.OptionsColumn.ReadOnly = true;
            this.colsaldo_BASE_EX.OptionsFilter.AllowFilter = false;
            this.colsaldo_BASE_EX.Visible = true;
            this.colsaldo_BASE_EX.Width = 83;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Horas Extras 25%";
            this.gridBand3.Columns.Add(this.colquantity_PHE25);
            this.gridBand3.Columns.Add(this.colsaldo_PHE25);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 153;
            // 
            // colquantity_PHE25
            // 
            this.colquantity_PHE25.AppearanceCell.Options.UseTextOptions = true;
            this.colquantity_PHE25.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colquantity_PHE25.AppearanceHeader.Options.UseTextOptions = true;
            this.colquantity_PHE25.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colquantity_PHE25.Caption = "Cant.";
            this.colquantity_PHE25.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colquantity_PHE25.FieldName = "quantity_PHE25";
            this.colquantity_PHE25.Name = "colquantity_PHE25";
            this.colquantity_PHE25.OptionsColumn.AllowMove = false;
            this.colquantity_PHE25.OptionsColumn.ReadOnly = true;
            this.colquantity_PHE25.OptionsFilter.AllowFilter = false;
            this.colquantity_PHE25.Visible = true;
            this.colquantity_PHE25.Width = 68;
            // 
            // colsaldo_PHE25
            // 
            this.colsaldo_PHE25.AppearanceCell.Options.UseTextOptions = true;
            this.colsaldo_PHE25.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colsaldo_PHE25.AppearanceHeader.Options.UseTextOptions = true;
            this.colsaldo_PHE25.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsaldo_PHE25.Caption = "PHE25";
            this.colsaldo_PHE25.DisplayFormat.FormatString = "{0:N2}";
            this.colsaldo_PHE25.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsaldo_PHE25.FieldName = "saldo_PHE25";
            this.colsaldo_PHE25.Name = "colsaldo_PHE25";
            this.colsaldo_PHE25.OptionsColumn.AllowMove = false;
            this.colsaldo_PHE25.OptionsColumn.ReadOnly = true;
            this.colsaldo_PHE25.OptionsFilter.AllowFilter = false;
            this.colsaldo_PHE25.Visible = true;
            this.colsaldo_PHE25.Width = 85;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Horas Extras 50%";
            this.gridBand2.Columns.Add(this.colquantity_PHE50);
            this.gridBand2.Columns.Add(this.colsaldo_PHE50);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 3;
            this.gridBand2.Width = 169;
            // 
            // colquantity_PHE50
            // 
            this.colquantity_PHE50.AppearanceCell.Options.UseTextOptions = true;
            this.colquantity_PHE50.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colquantity_PHE50.AppearanceHeader.Options.UseTextOptions = true;
            this.colquantity_PHE50.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colquantity_PHE50.Caption = "Cant.";
            this.colquantity_PHE50.DisplayFormat.FormatString = "{0:N2}";
            this.colquantity_PHE50.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colquantity_PHE50.FieldName = "quantity_PHE50";
            this.colquantity_PHE50.Name = "colquantity_PHE50";
            this.colquantity_PHE50.OptionsColumn.AllowMove = false;
            this.colquantity_PHE50.OptionsColumn.ReadOnly = true;
            this.colquantity_PHE50.OptionsFilter.AllowFilter = false;
            this.colquantity_PHE50.Visible = true;
            this.colquantity_PHE50.Width = 82;
            // 
            // colsaldo_PHE50
            // 
            this.colsaldo_PHE50.AppearanceCell.Options.UseTextOptions = true;
            this.colsaldo_PHE50.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colsaldo_PHE50.AppearanceHeader.Options.UseTextOptions = true;
            this.colsaldo_PHE50.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsaldo_PHE50.Caption = "PHE50";
            this.colsaldo_PHE50.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsaldo_PHE50.FieldName = "saldo_PHE50";
            this.colsaldo_PHE50.Name = "colsaldo_PHE50";
            this.colsaldo_PHE50.OptionsColumn.AllowMove = false;
            this.colsaldo_PHE50.OptionsColumn.ReadOnly = true;
            this.colsaldo_PHE50.OptionsFilter.AllowFilter = false;
            this.colsaldo_PHE50.Visible = true;
            this.colsaldo_PHE50.Width = 87;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Horas Extras 75%";
            this.gridBand4.Columns.Add(this.colquantity_PHE75);
            this.gridBand4.Columns.Add(this.colsaldo_PHE75);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 4;
            this.gridBand4.Width = 169;
            // 
            // colquantity_PHE75
            // 
            this.colquantity_PHE75.AppearanceCell.Options.UseTextOptions = true;
            this.colquantity_PHE75.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colquantity_PHE75.AppearanceHeader.Options.UseTextOptions = true;
            this.colquantity_PHE75.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colquantity_PHE75.Caption = "Cant.";
            this.colquantity_PHE75.DisplayFormat.FormatString = "{0:N2}";
            this.colquantity_PHE75.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colquantity_PHE75.FieldName = "quantity_PHE75";
            this.colquantity_PHE75.Name = "colquantity_PHE75";
            this.colquantity_PHE75.OptionsColumn.AllowMove = false;
            this.colquantity_PHE75.OptionsColumn.ReadOnly = true;
            this.colquantity_PHE75.OptionsFilter.AllowFilter = false;
            this.colquantity_PHE75.Visible = true;
            this.colquantity_PHE75.Width = 82;
            // 
            // colsaldo_PHE75
            // 
            this.colsaldo_PHE75.AppearanceCell.Options.UseTextOptions = true;
            this.colsaldo_PHE75.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colsaldo_PHE75.AppearanceHeader.Options.UseTextOptions = true;
            this.colsaldo_PHE75.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsaldo_PHE75.Caption = "PHE75";
            this.colsaldo_PHE75.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsaldo_PHE75.FieldName = "saldo_PHE75";
            this.colsaldo_PHE75.Name = "colsaldo_PHE75";
            this.colsaldo_PHE75.OptionsColumn.AllowMove = false;
            this.colsaldo_PHE75.OptionsColumn.ReadOnly = true;
            this.colsaldo_PHE75.OptionsFilter.AllowFilter = false;
            this.colsaldo_PHE75.Visible = true;
            this.colsaldo_PHE75.Width = 87;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.Caption = "Horas Extras 100%";
            this.gridBand5.Columns.Add(this.colquantity_PHE100);
            this.gridBand5.Columns.Add(this.colsaldo_PHE100);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 5;
            this.gridBand5.Width = 148;
            // 
            // colquantity_PHE100
            // 
            this.colquantity_PHE100.AppearanceCell.Options.UseTextOptions = true;
            this.colquantity_PHE100.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colquantity_PHE100.AppearanceHeader.Options.UseTextOptions = true;
            this.colquantity_PHE100.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colquantity_PHE100.Caption = "Cant.";
            this.colquantity_PHE100.DisplayFormat.FormatString = "{0:N2}";
            this.colquantity_PHE100.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colquantity_PHE100.FieldName = "quantity_PHE100";
            this.colquantity_PHE100.Name = "colquantity_PHE100";
            this.colquantity_PHE100.OptionsColumn.AllowMove = false;
            this.colquantity_PHE100.OptionsColumn.ReadOnly = true;
            this.colquantity_PHE100.OptionsFilter.AllowFilter = false;
            this.colquantity_PHE100.Visible = true;
            this.colquantity_PHE100.Width = 63;
            // 
            // colsaldo_PHE100
            // 
            this.colsaldo_PHE100.AppearanceHeader.Options.UseTextOptions = true;
            this.colsaldo_PHE100.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsaldo_PHE100.Caption = "PHE100";
            this.colsaldo_PHE100.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsaldo_PHE100.FieldName = "saldo_PHE100";
            this.colsaldo_PHE100.Name = "colsaldo_PHE100";
            this.colsaldo_PHE100.OptionsColumn.AllowMove = false;
            this.colsaldo_PHE100.OptionsColumn.ReadOnly = true;
            this.colsaldo_PHE100.OptionsFilter.AllowFilter = false;
            this.colsaldo_PHE100.Visible = true;
            this.colsaldo_PHE100.Width = 85;
            // 
            // gridBand6
            // 
            this.gridBand6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand6.Caption = "Total Horas Extras";
            this.gridBand6.Columns.Add(this.colquantity_TPHE);
            this.gridBand6.Columns.Add(this.colsaldo_TPHE);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 6;
            this.gridBand6.Width = 185;
            // 
            // colquantity_TPHE
            // 
            this.colquantity_TPHE.AppearanceCell.Options.UseTextOptions = true;
            this.colquantity_TPHE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colquantity_TPHE.AppearanceHeader.Options.UseTextOptions = true;
            this.colquantity_TPHE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colquantity_TPHE.Caption = "Cant.";
            this.colquantity_TPHE.DisplayFormat.FormatString = "{0:N2}";
            this.colquantity_TPHE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colquantity_TPHE.FieldName = "quantity_TPHE";
            this.colquantity_TPHE.Name = "colquantity_TPHE";
            this.colquantity_TPHE.OptionsColumn.AllowMove = false;
            this.colquantity_TPHE.OptionsColumn.ReadOnly = true;
            this.colquantity_TPHE.OptionsFilter.AllowFilter = false;
            this.colquantity_TPHE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "quantity_TPHE", "{0:N2}")});
            this.colquantity_TPHE.Visible = true;
            this.colquantity_TPHE.Width = 74;
            // 
            // colsaldo_TPHE
            // 
            this.colsaldo_TPHE.AppearanceCell.Options.UseTextOptions = true;
            this.colsaldo_TPHE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colsaldo_TPHE.AppearanceHeader.Options.UseTextOptions = true;
            this.colsaldo_TPHE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsaldo_TPHE.Caption = "TPHE";
            this.colsaldo_TPHE.DisplayFormat.FormatString = "{0:N2}";
            this.colsaldo_TPHE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsaldo_TPHE.FieldName = "saldo_TPHE";
            this.colsaldo_TPHE.Name = "colsaldo_TPHE";
            this.colsaldo_TPHE.OptionsColumn.ReadOnly = true;
            this.colsaldo_TPHE.OptionsFilter.AllowFilter = false;
            this.colsaldo_TPHE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "saldo_TPHE", "{0:N2}")});
            this.colsaldo_TPHE.Visible = true;
            this.colsaldo_TPHE.Width = 111;
            // 
            // tpDecimoTercero
            // 
            this.tpDecimoTercero.Controls.Add(this.gridControl1);
            this.tpDecimoTercero.Name = "tpDecimoTercero";
            this.tpDecimoTercero.PageVisible = false;
            this.tpDecimoTercero.Size = new System.Drawing.Size(1494, 473);
            this.tpDecimoTercero.Text = "Planilla de Décimo Tercero";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "rptPlanillaGeneralDecimos";
            this.gridControl1.DataSource = this.dsReporte1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gvDecimoTercero;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1494, 473);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDecimoTercero});
            // 
            // gvDecimoTercero
            // 
            this.gvDecimoTercero.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDecimoTercero.Appearance.FooterPanel.Options.UseFont = true;
            this.gvDecimoTercero.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gvDecimoTercero.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gvDecimoTercero.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvDecimoTercero.Appearance.GroupFooter.Options.UseFont = true;
            this.gvDecimoTercero.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gvDecimoTercero.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gvDecimoTercero.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDecimoTercero.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDecimoTercero.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDecimoTercero.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDecimoTercero.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDecimoTercero.Appearance.Row.Options.UseFont = true;
            this.gvDecimoTercero.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldepartamento2,
            this.colempleado2,
            this.colcodigo_empleado1,
            this.colidentidad2,
            this.colcargo2,
            this.colTCAVO,
            this.colBANC2,
            this.colPRCOOP3,
            this.colNET});
            this.gvDecimoTercero.GridControl = this.gridControl1;
            this.gvDecimoTercero.GroupCount = 1;
            this.gvDecimoTercero.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "cargo", this.colcargo2, "Totales"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TCAVO", this.colTCAVO, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BANC2", this.colBANC2, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PRCOOP3", this.colPRCOOP3, "{0:N2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NET", this.colNET, "{0:N2}")});
            this.gvDecimoTercero.Name = "gvDecimoTercero";
            this.gvDecimoTercero.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvDecimoTercero.OptionsView.ShowFooter = true;
            this.gvDecimoTercero.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coldepartamento2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // coldepartamento2
            // 
            this.coldepartamento2.Caption = "Departamento";
            this.coldepartamento2.FieldName = "departamento";
            this.coldepartamento2.Name = "coldepartamento2";
            this.coldepartamento2.Visible = true;
            this.coldepartamento2.VisibleIndex = 0;
            // 
            // colempleado2
            // 
            this.colempleado2.Caption = "Empleado";
            this.colempleado2.FieldName = "empleado";
            this.colempleado2.Name = "colempleado2";
            this.colempleado2.OptionsColumn.AllowMove = false;
            this.colempleado2.OptionsColumn.ReadOnly = true;
            this.colempleado2.OptionsFilter.AllowFilter = false;
            this.colempleado2.Visible = true;
            this.colempleado2.VisibleIndex = 0;
            // 
            // colcodigo_empleado1
            // 
            this.colcodigo_empleado1.Caption = "Código";
            this.colcodigo_empleado1.FieldName = "codigo_empleado";
            this.colcodigo_empleado1.Name = "colcodigo_empleado1";
            this.colcodigo_empleado1.OptionsColumn.AllowMove = false;
            this.colcodigo_empleado1.OptionsColumn.ReadOnly = true;
            this.colcodigo_empleado1.OptionsFilter.AllowFilter = false;
            this.colcodigo_empleado1.Visible = true;
            this.colcodigo_empleado1.VisibleIndex = 1;
            // 
            // colidentidad2
            // 
            this.colidentidad2.Caption = "Identidad";
            this.colidentidad2.FieldName = "identidad";
            this.colidentidad2.Name = "colidentidad2";
            this.colidentidad2.OptionsColumn.AllowMove = false;
            this.colidentidad2.OptionsColumn.ReadOnly = true;
            this.colidentidad2.OptionsFilter.AllowFilter = false;
            this.colidentidad2.Visible = true;
            this.colidentidad2.VisibleIndex = 2;
            // 
            // colcargo2
            // 
            this.colcargo2.Caption = "Cargo";
            this.colcargo2.FieldName = "cargo";
            this.colcargo2.Name = "colcargo2";
            this.colcargo2.OptionsColumn.AllowMove = false;
            this.colcargo2.OptionsColumn.ReadOnly = true;
            this.colcargo2.OptionsFilter.AllowFilter = false;
            this.colcargo2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "cargo", "Gran Total")});
            this.colcargo2.Visible = true;
            this.colcargo2.VisibleIndex = 3;
            // 
            // colTCAVO
            // 
            this.colTCAVO.Caption = "Treceavo";
            this.colTCAVO.FieldName = "TCAVO";
            this.colTCAVO.Name = "colTCAVO";
            this.colTCAVO.OptionsColumn.AllowMove = false;
            this.colTCAVO.OptionsColumn.ReadOnly = true;
            this.colTCAVO.OptionsFilter.AllowFilter = false;
            this.colTCAVO.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TCAVO", "{0:N2}")});
            this.colTCAVO.Visible = true;
            this.colTCAVO.VisibleIndex = 4;
            // 
            // colBANC2
            // 
            this.colBANC2.Caption = "Cuota Bomba";
            this.colBANC2.FieldName = "BANC2";
            this.colBANC2.Name = "colBANC2";
            this.colBANC2.OptionsColumn.AllowMove = false;
            this.colBANC2.OptionsColumn.ReadOnly = true;
            this.colBANC2.OptionsFilter.AllowFilter = false;
            this.colBANC2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BANC2", "{0:N2}")});
            this.colBANC2.Visible = true;
            this.colBANC2.VisibleIndex = 5;
            // 
            // colPRCOOP3
            // 
            this.colPRCOOP3.Caption = "Adelanto Treceavo Coop";
            this.colPRCOOP3.FieldName = "PRCOOP3";
            this.colPRCOOP3.Name = "colPRCOOP3";
            this.colPRCOOP3.OptionsColumn.AllowMove = false;
            this.colPRCOOP3.OptionsColumn.ReadOnly = true;
            this.colPRCOOP3.OptionsFilter.AllowFilter = false;
            this.colPRCOOP3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PRCOOP3", "{0:N2}")});
            this.colPRCOOP3.Visible = true;
            this.colPRCOOP3.VisibleIndex = 6;
            // 
            // colNET
            // 
            this.colNET.Caption = "Total a Pagar";
            this.colNET.FieldName = "NET";
            this.colNET.Name = "colNET";
            this.colNET.OptionsColumn.AllowMove = false;
            this.colNET.OptionsColumn.ReadOnly = true;
            this.colNET.OptionsFilter.AllowFilter = false;
            this.colNET.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NET", "{0:N2}")});
            this.colNET.Visible = true;
            this.colNET.VisibleIndex = 7;
            // 
            // frmInformePlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 614);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.slueNomina);
            this.Name = "frmInformePlanilla";
            this.Text = "Informe de Planillas";
            ((System.ComponentModel.ISupportInitialize)(this.gcPlanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paysliplookupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tpPlanillaGeneral.ResumeLayout(false);
            this.tpPlanillaHE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgvHE)).EndInit();
            this.tpDecimoTercero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDecimoTercero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPlanilla;
        private dsReporte dsReporte1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPlanilla;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colempleado;
        private DevExpress.XtraGrid.Columns.GridColumn colidentidad;
        private DevExpress.XtraGrid.Columns.GridColumn colcargo;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasLaborados;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasFaltados;
        private DevExpress.XtraGrid.Columns.GridColumn colSalarioBase;
        private DevExpress.XtraGrid.Columns.GridColumn colvacaciones;
        private DevExpress.XtraGrid.Columns.GridColumn coltransporte;
        private DevExpress.XtraGrid.Columns.GridColumn colOtrosIngresos;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalIngresos;
        private DevExpress.XtraGrid.Columns.GridColumn colAhorroFijoCoop;
        private DevExpress.XtraGrid.Columns.GridColumn colBancos;
        private DevExpress.XtraGrid.Columns.GridColumn colPrestamoCoop;
        private DevExpress.XtraGrid.Columns.GridColumn colCafeteria;
        private DevExpress.XtraGrid.Columns.GridColumn colAhorroRetCoop;
        private DevExpress.XtraGrid.Columns.GridColumn colOtrasDeduccionesCoop;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanDental;
        private DevExpress.XtraGrid.Columns.GridColumn colSeguroMedico;
        private DevExpress.XtraGrid.Columns.GridColumn colUSULA;
        private DevExpress.XtraGrid.Columns.GridColumn colIHSS;
        private DevExpress.XtraGrid.Columns.GridColumn colINCAPACIDADES;
        private DevExpress.XtraGrid.Columns.GridColumn colISR;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalEgresos;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPagar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SearchLookUpEdit slueNomina;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource paysliplookupBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colplanilla;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnexport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tpPlanillaGeneral;
        private DevExpress.XtraTab.XtraTabPage tpPlanillaHE;
        private DevExpress.XtraGrid.GridControl gcHE;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bgvHE;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldepartamento1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colempleado1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcodigo_empleado;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colidentidad1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcargo1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colsalario_hora;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colquantity_BASE_EX;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colsaldo_BASE_EX;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colquantity_PHE25;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colsaldo_PHE25;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colquantity_PHE50;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colsaldo_PHE50;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colquantity_PHE75;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colsaldo_PHE75;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colquantity_PHE100;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colsaldo_PHE100;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colquantity_TPHE;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colsaldo_TPHE;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gbSalarioBase;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraTab.XtraTabPage tpDecimoTercero;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDecimoTercero;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento2;
        private DevExpress.XtraGrid.Columns.GridColumn colempleado2;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_empleado1;
        private DevExpress.XtraGrid.Columns.GridColumn colidentidad2;
        private DevExpress.XtraGrid.Columns.GridColumn colcargo2;
        private DevExpress.XtraGrid.Columns.GridColumn colTCAVO;
        private DevExpress.XtraGrid.Columns.GridColumn colBANC2;
        private DevExpress.XtraGrid.Columns.GridColumn colPRCOOP3;
        private DevExpress.XtraGrid.Columns.GridColumn colNET;
    }
}