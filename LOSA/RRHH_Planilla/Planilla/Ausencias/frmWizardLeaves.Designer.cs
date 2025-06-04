namespace LOSA.RRHH_Planilla.Planilla.Ausencias
{
    partial class frmWizardLeaves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWizardLeaves));
            this.nfAusencias = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.npEmpleados = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ceSeleccionar = new DevExpress.XtraEditors.CheckEdit();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.gcEmpleado = new DevExpress.XtraGrid.GridControl();
            this.dsInasistencias1 = new LOSA.RRHH_Planilla.Planilla.Ausencias.dsInasistencias();
            this.gvEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_employee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartment_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljob_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljob_title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNext1 = new DevExpress.XtraEditors.SimpleButton();
            this.npAusencias = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnCargar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tsAplicado = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.seDiasVacaciones = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtNote = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.slueTipoAusencia = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.tipoausenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtFin = new DevExpress.XtraEditors.DateEdit();
            this.deRegreso = new DevExpress.XtraEditors.DateEdit();
            this.dtInicio = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnBack1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nfAusencias)).BeginInit();
            this.nfAusencias.SuspendLayout();
            this.npEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceSeleccionar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInasistencias1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).BeginInit();
            this.npAusencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsAplicado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDiasVacaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueTipoAusencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoausenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRegreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRegreso.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // nfAusencias
            // 
            this.nfAusencias.Controls.Add(this.npEmpleados);
            this.nfAusencias.Controls.Add(this.npAusencias);
            this.nfAusencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nfAusencias.Location = new System.Drawing.Point(0, 0);
            this.nfAusencias.Name = "nfAusencias";
            this.nfAusencias.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npEmpleados,
            this.npAusencias});
            this.nfAusencias.SelectedPage = this.npEmpleados;
            this.nfAusencias.Size = new System.Drawing.Size(964, 557);
            this.nfAusencias.TabIndex = 0;
            this.nfAusencias.Text = "navigationFrame1";
            // 
            // npEmpleados
            // 
            this.npEmpleados.Controls.Add(this.ceSeleccionar);
            this.npEmpleados.Controls.Add(this.cmdCerrar);
            this.npEmpleados.Controls.Add(this.gcEmpleado);
            this.npEmpleados.Controls.Add(this.btnNext1);
            this.npEmpleados.Name = "npEmpleados";
            this.npEmpleados.Size = new System.Drawing.Size(964, 557);
            // 
            // ceSeleccionar
            // 
            this.ceSeleccionar.Location = new System.Drawing.Point(823, 59);
            this.ceSeleccionar.Name = "ceSeleccionar";
            this.ceSeleccionar.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceSeleccionar.Properties.Appearance.Options.UseFont = true;
            this.ceSeleccionar.Properties.Appearance.Options.UseTextOptions = true;
            this.ceSeleccionar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ceSeleccionar.Properties.Caption = "Seleccionar Todo";
            this.ceSeleccionar.Size = new System.Drawing.Size(129, 21);
            this.ceSeleccionar.TabIndex = 29;
            this.ceSeleccionar.CheckedChanged += new System.EventHandler(this.ceSeleccionar_CheckedChanged);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(12, 12);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(84, 36);
            this.cmdCerrar.TabIndex = 26;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // gcEmpleado
            // 
            this.gcEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcEmpleado.DataMember = "ausencia_empleados";
            this.gcEmpleado.DataSource = this.dsInasistencias1;
            this.gcEmpleado.Location = new System.Drawing.Point(0, 86);
            this.gcEmpleado.MainView = this.gvEmployee;
            this.gcEmpleado.Name = "gcEmpleado";
            this.gcEmpleado.Size = new System.Drawing.Size(964, 471);
            this.gcEmpleado.TabIndex = 25;
            this.gcEmpleado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployee});
            // 
            // dsInasistencias1
            // 
            this.dsInasistencias1.DataSetName = "dsInasistencias";
            this.dsInasistencias1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvEmployee
            // 
            this.gvEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_employee,
            this.colbarcode,
            this.coldepartment_id,
            this.coldepartment,
            this.colnombre,
            this.coljob_id,
            this.coljob_title,
            this.colseleccionar});
            this.gvEmployee.GridControl = this.gcEmpleado;
            this.gvEmployee.Name = "gvEmployee";
            this.gvEmployee.OptionsView.ShowAutoFilterRow = true;
            this.gvEmployee.OptionsView.ShowGroupPanel = false;
            this.gvEmployee.OptionsView.ShowViewCaption = true;
            this.gvEmployee.ViewCaption = "Seleccione los Empleados para aplicar Ausencias";
            // 
            // colid_employee
            // 
            this.colid_employee.FieldName = "id_employee";
            this.colid_employee.Name = "colid_employee";
            // 
            // colbarcode
            // 
            this.colbarcode.Caption = "Código";
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.OptionsColumn.ReadOnly = true;
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 0;
            this.colbarcode.Width = 78;
            // 
            // coldepartment_id
            // 
            this.coldepartment_id.FieldName = "department_id";
            this.coldepartment_id.Name = "coldepartment_id";
            // 
            // coldepartment
            // 
            this.coldepartment.Caption = "Departamento";
            this.coldepartment.FieldName = "department";
            this.coldepartment.Name = "coldepartment";
            this.coldepartment.OptionsColumn.ReadOnly = true;
            this.coldepartment.Visible = true;
            this.coldepartment.VisibleIndex = 2;
            this.coldepartment.Width = 187;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 301;
            // 
            // coljob_id
            // 
            this.coljob_id.FieldName = "job_id";
            this.coljob_id.Name = "coljob_id";
            // 
            // coljob_title
            // 
            this.coljob_title.Caption = "Puesto";
            this.coljob_title.FieldName = "job_title";
            this.coljob_title.Name = "coljob_title";
            this.coljob_title.OptionsColumn.ReadOnly = true;
            this.coljob_title.Visible = true;
            this.coljob_title.VisibleIndex = 3;
            this.coljob_title.Width = 274;
            // 
            // colseleccionar
            // 
            this.colseleccionar.FieldName = "seleccionar";
            this.colseleccionar.Name = "colseleccionar";
            this.colseleccionar.Visible = true;
            this.colseleccionar.VisibleIndex = 4;
            this.colseleccionar.Width = 84;
            // 
            // btnNext1
            // 
            this.btnNext1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnNext1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNext1.ImageOptions.SvgImage")));
            this.btnNext1.Location = new System.Drawing.Point(868, 12);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(84, 36);
            this.btnNext1.TabIndex = 0;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // npAusencias
            // 
            this.npAusencias.Controls.Add(this.labelControl4);
            this.npAusencias.Controls.Add(this.btnCargar);
            this.npAusencias.Controls.Add(this.labelControl7);
            this.npAusencias.Controls.Add(this.tsAplicado);
            this.npAusencias.Controls.Add(this.labelControl8);
            this.npAusencias.Controls.Add(this.seDiasVacaciones);
            this.npAusencias.Controls.Add(this.labelControl6);
            this.npAusencias.Controls.Add(this.txtNote);
            this.npAusencias.Controls.Add(this.labelControl5);
            this.npAusencias.Controls.Add(this.slueTipoAusencia);
            this.npAusencias.Controls.Add(this.dtFin);
            this.npAusencias.Controls.Add(this.deRegreso);
            this.npAusencias.Controls.Add(this.dtInicio);
            this.npAusencias.Controls.Add(this.labelControl3);
            this.npAusencias.Controls.Add(this.labelControl1);
            this.npAusencias.Controls.Add(this.labelControl2);
            this.npAusencias.Controls.Add(this.btnBack1);
            this.npAusencias.Name = "npAusencias";
            this.npAusencias.Size = new System.Drawing.Size(964, 557);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(366, 61);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(190, 20);
            this.labelControl4.TabIndex = 62;
            this.labelControl4.Text = "Información de la Ausencia";
            // 
            // btnCargar
            // 
            this.btnCargar.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Appearance.Options.UseFont = true;
            this.btnCargar.Appearance.Options.UseTextOptions = true;
            this.btnCargar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnCargar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnCargar.ImageOptions.SvgImage = global::LOSA.Properties.Resources.ProgressRingDots;
            this.btnCargar.Location = new System.Drawing.Point(855, 12);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(97, 36);
            this.btnCargar.TabIndex = 61;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(229, 142);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(140, 20);
            this.labelControl7.TabIndex = 60;
            this.labelControl7.Text = "Aplicado en Planilla:";
            // 
            // tsAplicado
            // 
            this.tsAplicado.Location = new System.Drawing.Point(377, 140);
            this.tsAplicado.Name = "tsAplicado";
            this.tsAplicado.Properties.AllowThumbAnimation = false;
            this.tsAplicado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tsAplicado.Properties.Appearance.Options.UseFont = true;
            this.tsAplicado.Properties.OffText = "No";
            this.tsAplicado.Properties.OnText = "Si";
            this.tsAplicado.Size = new System.Drawing.Size(116, 24);
            this.tsAplicado.TabIndex = 59;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(256, 270);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(113, 20);
            this.labelControl8.TabIndex = 58;
            this.labelControl8.Text = "Dias Solicitados:";
            // 
            // seDiasVacaciones
            // 
            this.seDiasVacaciones.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seDiasVacaciones.Location = new System.Drawing.Point(377, 267);
            this.seDiasVacaciones.Name = "seDiasVacaciones";
            this.seDiasVacaciones.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.seDiasVacaciones.Properties.Appearance.Options.UseFont = true;
            this.seDiasVacaciones.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seDiasVacaciones.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seDiasVacaciones.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seDiasVacaciones.Size = new System.Drawing.Size(179, 26);
            this.seDiasVacaciones.TabIndex = 57;
            this.seDiasVacaciones.EditValueChanged += new System.EventHandler(this.seDiasVacaciones_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(330, 303);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 20);
            this.labelControl6.TabIndex = 56;
            this.labelControl6.Text = "Nota:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(377, 302);
            this.txtNote.Name = "txtNote";
            this.txtNote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtNote.Properties.Appearance.Options.UseFont = true;
            this.txtNote.Size = new System.Drawing.Size(301, 96);
            this.txtNote.TabIndex = 50;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(269, 103);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(102, 20);
            this.labelControl5.TabIndex = 54;
            this.labelControl5.Text = "Tipo Ausencia:";
            // 
            // slueTipoAusencia
            // 
            this.slueTipoAusencia.Location = new System.Drawing.Point(377, 100);
            this.slueTipoAusencia.Name = "slueTipoAusencia";
            this.slueTipoAusencia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.slueTipoAusencia.Properties.Appearance.Options.UseFont = true;
            this.slueTipoAusencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueTipoAusencia.Properties.DataSource = this.tipoausenciaBindingSource;
            this.slueTipoAusencia.Properties.DisplayMember = "name";
            this.slueTipoAusencia.Properties.NullText = "";
            this.slueTipoAusencia.Properties.PopupView = this.searchLookUpEdit1View;
            this.slueTipoAusencia.Properties.ValueMember = "id";
            this.slueTipoAusencia.Size = new System.Drawing.Size(271, 26);
            this.slueTipoAusencia.TabIndex = 45;
            this.slueTipoAusencia.EditValueChanged += new System.EventHandler(this.slueTipoAusencia_EditValueChanged);
            // 
            // tipoausenciaBindingSource
            // 
            this.tipoausenciaBindingSource.DataMember = "tipo_ausencia";
            this.tipoausenciaBindingSource.DataSource = this.dsInasistencias1;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colname
            // 
            this.colname.Caption = "Tipo";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            // 
            // dtFin
            // 
            this.dtFin.EditValue = null;
            this.dtFin.Location = new System.Drawing.Point(377, 202);
            this.dtFin.Name = "dtFin";
            this.dtFin.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtFin.Properties.Appearance.Options.UseFont = true;
            this.dtFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFin.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtFin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFin.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtFin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFin.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dtFin.Size = new System.Drawing.Size(179, 26);
            this.dtFin.TabIndex = 48;
            this.dtFin.EditValueChanged += new System.EventHandler(this.dtFin_EditValueChanged);
            // 
            // deRegreso
            // 
            this.deRegreso.EditValue = null;
            this.deRegreso.Location = new System.Drawing.Point(377, 234);
            this.deRegreso.Name = "deRegreso";
            this.deRegreso.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.deRegreso.Properties.Appearance.Options.UseFont = true;
            this.deRegreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deRegreso.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deRegreso.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deRegreso.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deRegreso.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deRegreso.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deRegreso.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.deRegreso.Size = new System.Drawing.Size(179, 26);
            this.deRegreso.TabIndex = 49;
            // 
            // dtInicio
            // 
            this.dtInicio.EditValue = null;
            this.dtInicio.Location = new System.Drawing.Point(377, 171);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtInicio.Properties.Appearance.Options.UseFont = true;
            this.dtInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtInicio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtInicio.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtInicio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtInicio.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dtInicio.Size = new System.Drawing.Size(179, 26);
            this.dtInicio.TabIndex = 47;
            this.dtInicio.EditValueChanged += new System.EventHandler(this.dtInicio_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(264, 234);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(105, 20);
            this.labelControl3.TabIndex = 53;
            this.labelControl3.Text = "Fecha Regreso:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(300, 205);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 20);
            this.labelControl1.TabIndex = 52;
            this.labelControl1.Text = "Fecha Fin:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(283, 174);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 20);
            this.labelControl2.TabIndex = 51;
            this.labelControl2.Text = "Fecha Inicio:";
            // 
            // btnBack1
            // 
            this.btnBack1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnBack1.ImageOptions.SvgImage = global::LOSA.Properties.Resources.ArrowLeft8;
            this.btnBack1.Location = new System.Drawing.Point(12, 12);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(84, 36);
            this.btnBack1.TabIndex = 1;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // frmWizardLeaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 557);
            this.Controls.Add(this.nfAusencias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWizardLeaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistente para Aplicar Ausencias";
            ((System.ComponentModel.ISupportInitialize)(this.nfAusencias)).EndInit();
            this.nfAusencias.ResumeLayout(false);
            this.npEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceSeleccionar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInasistencias1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).EndInit();
            this.npAusencias.ResumeLayout(false);
            this.npAusencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsAplicado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDiasVacaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueTipoAusencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoausenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRegreso.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRegreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame nfAusencias;
        private DevExpress.XtraBars.Navigation.NavigationPage npEmpleados;
        private DevExpress.XtraBars.Navigation.NavigationPage npAusencias;
        private DevExpress.XtraEditors.SimpleButton btnNext1;
        private DevExpress.XtraEditors.CheckEdit ceSeleccionar;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraGrid.GridControl gcEmpleado;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colid_employee;
        private DevExpress.XtraGrid.Columns.GridColumn colbarcode;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartment_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn coljob_id;
        private DevExpress.XtraGrid.Columns.GridColumn coljob_title;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar;
        private dsInasistencias dsInasistencias1;
        private DevExpress.XtraEditors.SimpleButton btnBack1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ToggleSwitch tsAplicado;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SpinEdit seDiasVacaciones;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit txtNote;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit slueTipoAusencia;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraEditors.DateEdit dtFin;
        private DevExpress.XtraEditors.DateEdit deRegreso;
        private DevExpress.XtraEditors.DateEdit dtInicio;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource tipoausenciaBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnCargar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}