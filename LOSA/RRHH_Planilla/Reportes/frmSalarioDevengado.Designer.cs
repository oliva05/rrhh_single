namespace LOSA.RRHH_Planilla.Reportes
{
    partial class frmSalarioDevengado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalarioDevengado));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsPlanillaReportes1 = new LOSA.RRHH_Planilla.Reportes.dsPlanillaReportes();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colcodigo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colnombre = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colpuesto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colbasic_salary = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldias_vacaciones = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colbeneficioes = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colvacaciones = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colincapacidades = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldia_incapacidad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldias_faltados = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldias_laborados = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colihss = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colisr = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tggMostrarCanceladas = new DevExpress.XtraEditors.ToggleSwitch();
            this.cmdRefreshDisponibles = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkComboReglasSalariales = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.salaryrulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanillaReportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggMostrarCanceladas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkComboReglasSalariales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryrulesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "salario_devengados";
            this.gridControl1.DataSource = this.dsPlanillaReportes1;
            this.gridControl1.Location = new System.Drawing.Point(2, 93);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1446, 672);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // dsPlanillaReportes1
            // 
            this.dsPlanillaReportes1.DataSetName = "dsPlanillaReportes";
            this.dsPlanillaReportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colcodigo,
            this.colnombre,
            this.coldepartamento,
            this.colpuesto,
            this.colbasic_salary,
            this.coldias_vacaciones,
            this.colbeneficioes,
            this.colvacaciones,
            this.colincapacidades,
            this.coldias_faltados,
            this.coldias_laborados,
            this.coldia_incapacidad,
            this.colihss,
            this.colisr,
            this.bandedGridColumn1,
            this.bandedGridColumn2});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridView1.OptionsView.ShowFooter = true;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Información de Empleado";
            this.gridBand1.Columns.Add(this.colcodigo);
            this.gridBand1.Columns.Add(this.colnombre);
            this.gridBand1.Columns.Add(this.coldepartamento);
            this.gridBand1.Columns.Add(this.colpuesto);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 433;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.ReadOnly = true;
            this.colcodigo.Visible = true;
            this.colcodigo.Width = 41;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.Width = 163;
            // 
            // coldepartamento
            // 
            this.coldepartamento.Caption = "Departamento";
            this.coldepartamento.FieldName = "departamento";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.OptionsColumn.ReadOnly = true;
            this.coldepartamento.Visible = true;
            this.coldepartamento.Width = 107;
            // 
            // colpuesto
            // 
            this.colpuesto.Caption = "Puesto";
            this.colpuesto.FieldName = "puesto";
            this.colpuesto.Name = "colpuesto";
            this.colpuesto.OptionsColumn.ReadOnly = true;
            this.colpuesto.Visible = true;
            this.colpuesto.Width = 122;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Crédito";
            this.gridBand2.Columns.Add(this.colbasic_salary);
            this.gridBand2.Columns.Add(this.coldias_vacaciones);
            this.gridBand2.Columns.Add(this.colbeneficioes);
            this.gridBand2.Columns.Add(this.colvacaciones);
            this.gridBand2.Columns.Add(this.colincapacidades);
            this.gridBand2.Columns.Add(this.coldia_incapacidad);
            this.gridBand2.Columns.Add(this.coldias_faltados);
            this.gridBand2.Columns.Add(this.coldias_laborados);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 721;
            // 
            // colbasic_salary
            // 
            this.colbasic_salary.Caption = "Salario Base";
            this.colbasic_salary.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colbasic_salary.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colbasic_salary.FieldName = "basic_salary";
            this.colbasic_salary.Name = "colbasic_salary";
            this.colbasic_salary.OptionsColumn.ReadOnly = true;
            this.colbasic_salary.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "basic_salary", "Total={0:#,###,##0.00}")});
            this.colbasic_salary.Visible = true;
            this.colbasic_salary.Width = 70;
            // 
            // coldias_vacaciones
            // 
            this.coldias_vacaciones.Caption = "Dias de Vacaciones";
            this.coldias_vacaciones.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.coldias_vacaciones.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldias_vacaciones.FieldName = "dias_vacaciones";
            this.coldias_vacaciones.Name = "coldias_vacaciones";
            this.coldias_vacaciones.OptionsColumn.ReadOnly = true;
            this.coldias_vacaciones.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dias_vacaciones", "Total={0:#,###,##0.00}")});
            this.coldias_vacaciones.Visible = true;
            this.coldias_vacaciones.Width = 101;
            // 
            // colbeneficioes
            // 
            this.colbeneficioes.Caption = "Beneficios";
            this.colbeneficioes.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colbeneficioes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colbeneficioes.FieldName = "beneficioes";
            this.colbeneficioes.Name = "colbeneficioes";
            this.colbeneficioes.OptionsColumn.ReadOnly = true;
            this.colbeneficioes.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "beneficioes", "Total={0:#,###,##0.00}")});
            this.colbeneficioes.Visible = true;
            this.colbeneficioes.Width = 60;
            // 
            // colvacaciones
            // 
            this.colvacaciones.Caption = "Vacaciones";
            this.colvacaciones.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colvacaciones.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvacaciones.FieldName = "vacaciones";
            this.colvacaciones.Name = "colvacaciones";
            this.colvacaciones.OptionsColumn.ReadOnly = true;
            this.colvacaciones.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "vacaciones", "Total={0:#,###,##0.00}")});
            this.colvacaciones.Visible = true;
            this.colvacaciones.Width = 66;
            // 
            // colincapacidades
            // 
            this.colincapacidades.Caption = "Incapacidades";
            this.colincapacidades.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colincapacidades.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colincapacidades.FieldName = "incapacidades";
            this.colincapacidades.Name = "colincapacidades";
            this.colincapacidades.OptionsColumn.ReadOnly = true;
            this.colincapacidades.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "incapacidades", "Total={0:#,###,##0.00}")});
            this.colincapacidades.Visible = true;
            this.colincapacidades.Width = 85;
            // 
            // coldia_incapacidad
            // 
            this.coldia_incapacidad.Caption = "Días de Incapacidad";
            this.coldia_incapacidad.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.coldia_incapacidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldia_incapacidad.FieldName = "dia_incapacidad";
            this.coldia_incapacidad.Name = "coldia_incapacidad";
            this.coldia_incapacidad.OptionsColumn.ReadOnly = true;
            this.coldia_incapacidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dia_incapacidad", "Total={0:#,###,##0.00}")});
            this.coldia_incapacidad.Visible = true;
            this.coldia_incapacidad.Width = 115;
            // 
            // coldias_faltados
            // 
            this.coldias_faltados.Caption = "Días Faltados";
            this.coldias_faltados.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.coldias_faltados.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldias_faltados.FieldName = "dias_faltados";
            this.coldias_faltados.Name = "coldias_faltados";
            this.coldias_faltados.OptionsColumn.ReadOnly = true;
            this.coldias_faltados.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dias_faltados", "Total={0:#,###,##0.00}")});
            this.coldias_faltados.Visible = true;
            this.coldias_faltados.Width = 77;
            // 
            // coldias_laborados
            // 
            this.coldias_laborados.Caption = "Días Laborados";
            this.coldias_laborados.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.coldias_laborados.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldias_laborados.FieldName = "dias_laborados";
            this.coldias_laborados.Name = "coldias_laborados";
            this.coldias_laborados.OptionsColumn.ReadOnly = true;
            this.coldias_laborados.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dias_laborados", "Total={0:#,###,##0.00}")});
            this.coldias_laborados.Visible = true;
            this.coldias_laborados.Width = 147;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Débito";
            this.gridBand3.Columns.Add(this.bandedGridColumn2);
            this.gridBand3.Columns.Add(this.colihss);
            this.gridBand3.Columns.Add(this.bandedGridColumn1);
            this.gridBand3.Columns.Add(this.colisr);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 269;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Caption = "Deducciones";
            this.bandedGridColumn2.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.bandedGridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bandedGridColumn2.FieldName = "deducciones";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "deducciones", "Total={0:#,###,##0.00}")});
            this.bandedGridColumn2.Visible = true;
            this.bandedGridColumn2.Width = 74;
            // 
            // colihss
            // 
            this.colihss.Caption = "IHSS";
            this.colihss.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colihss.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colihss.FieldName = "ihss";
            this.colihss.Name = "colihss";
            this.colihss.OptionsColumn.ReadOnly = true;
            this.colihss.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ihss", "Total={0:#,###,##0.00}")});
            this.colihss.Visible = true;
            this.colihss.Width = 46;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "AFP";
            this.bandedGridColumn1.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.bandedGridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bandedGridColumn1.FieldName = "AFP";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.OptionsColumn.ReadOnly = true;
            this.bandedGridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AFP", "Total={0:#,###,##0.00}")});
            this.bandedGridColumn1.Visible = true;
            this.bandedGridColumn1.Width = 52;
            // 
            // colisr
            // 
            this.colisr.Caption = "ISR";
            this.colisr.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colisr.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colisr.FieldName = "isr";
            this.colisr.Name = "colisr";
            this.colisr.OptionsColumn.ReadOnly = true;
            this.colisr.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "isr", "Total={0:#,###,##0.00}")});
            this.colisr.Visible = true;
            this.colisr.Width = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 151;
            this.label1.Text = "Mostrar Inactivos:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // tggMostrarCanceladas
            // 
            this.tggMostrarCanceladas.Location = new System.Drawing.Point(627, 52);
            this.tggMostrarCanceladas.Name = "tggMostrarCanceladas";
            this.tggMostrarCanceladas.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tggMostrarCanceladas.Properties.Appearance.Options.UseFont = true;
            this.tggMostrarCanceladas.Properties.OffText = "No";
            this.tggMostrarCanceladas.Properties.OnText = "Si";
            this.tggMostrarCanceladas.Size = new System.Drawing.Size(89, 20);
            this.tggMostrarCanceladas.TabIndex = 150;
            this.tggMostrarCanceladas.Visible = false;
            this.tggMostrarCanceladas.Toggled += new System.EventHandler(this.tggMostrarCanceladas_Toggled);
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
            this.cmdRefreshDisponibles.Location = new System.Drawing.Point(223, 40);
            this.cmdRefreshDisponibles.Name = "cmdRefreshDisponibles";
            this.cmdRefreshDisponibles.Size = new System.Drawing.Size(114, 33);
            this.cmdRefreshDisponibles.TabIndex = 149;
            this.cmdRefreshDisponibles.Text = "Cargar";
            this.cmdRefreshDisponibles.Click += new System.EventHandler(this.cmdRefreshDisponibles_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 148;
            this.label3.Text = "Hasta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 147;
            this.label2.Text = "Desde:";
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(55, 59);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Size = new System.Drawing.Size(162, 22);
            this.dtHasta.TabIndex = 146;
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(55, 30);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Size = new System.Drawing.Size(162, 22);
            this.dtDesde.TabIndex = 145;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Image = global::LOSA.Properties.Resources.Danieledesantis_Playstation_Flat_Playstation_cross_black_and_white_24;
            this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(1351, 5);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(86, 33);
            this.cmdCerrar.TabIndex = 152;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 157;
            this.label4.Text = "Reglas Salariales:";
            this.label4.Visible = false;
            // 
            // checkComboReglasSalariales
            // 
            this.checkComboReglasSalariales.Location = new System.Drawing.Point(497, 16);
            this.checkComboReglasSalariales.Name = "checkComboReglasSalariales";
            this.checkComboReglasSalariales.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.checkComboReglasSalariales.Properties.Appearance.Options.UseFont = true;
            this.checkComboReglasSalariales.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkComboReglasSalariales.Properties.DataSource = this.salaryrulesBindingSource;
            this.checkComboReglasSalariales.Properties.DisplayMember = "salary_rule_name";
            this.checkComboReglasSalariales.Properties.SelectAllItemCaption = "(Todos)";
            this.checkComboReglasSalariales.Properties.ValueMember = "salary_rule_id";
            this.checkComboReglasSalariales.Size = new System.Drawing.Size(314, 22);
            this.checkComboReglasSalariales.TabIndex = 160;
            this.checkComboReglasSalariales.Visible = false;
            // 
            // salaryrulesBindingSource
            // 
            this.salaryrulesBindingSource.DataMember = "salary_rules";
            this.salaryrulesBindingSource.DataSource = this.dsPlanillaReportes1;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = global::LOSA.Properties.Resources.excel32px;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(1224, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(86, 33);
            this.btnExport.TabIndex = 161;
            this.btnExport.Text = "Exportar";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmSalarioDevengado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 765);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.checkComboReglasSalariales);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tggMostrarCanceladas);
            this.Controls.Add(this.cmdRefreshDisponibles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmSalarioDevengado";
            this.Text = "Salario Devengado";
            this.Load += new System.EventHandler(this.frmSalarioDevengado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanillaReportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggMostrarCanceladas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkComboReglasSalariales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryrulesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ToggleSwitch tggMostrarCanceladas;
        private DevExpress.XtraEditors.SimpleButton cmdRefreshDisponibles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private System.Windows.Forms.Button cmdCerrar;
        private dsPlanillaReportes dsPlanillaReportes1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkComboReglasSalariales;
        private System.Windows.Forms.BindingSource salaryrulesBindingSource;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcodigo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colnombre;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldepartamento;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colpuesto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colbasic_salary;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldias_vacaciones;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colbeneficioes;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colvacaciones;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colincapacidades;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldias_faltados;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldias_laborados;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldia_incapacidad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colihss;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colisr;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private System.Windows.Forms.Button btnExport;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
    }
}