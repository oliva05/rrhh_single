
namespace LOSA.MigracionACS.RRHH.RelojFace
{
    partial class frmResumenHorasExtraTrabajadas
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumenHorasExtraTrabajadas));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.administracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFaceReloj = new LOSA.MigracionACS.RRHH.RelojFace.dsFaceReloj();
            this.turnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblFechas = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblEmpleado = new DevExpress.XtraEditors.LabelControl();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.cmdAgregarMarca = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdActualizar = new System.Windows.Forms.Button();
            this.dt_final = new DevExpress.XtraEditors.DateEdit();
            this.dt_inicial = new DevExpress.XtraEditors.DateEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grd_Admin = new DevExpress.XtraGrid.GridControl();
            this.grdv_Admin = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colserial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeReloj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeODOO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNormalHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtraHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBegin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btneditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.coldepartamento1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarcasAdmon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdMoreDetails = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colweek = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.administracionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFaceReloj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_Admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMoreDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // administracionBindingSource
            // 
            this.administracionBindingSource.DataMember = "Administracion";
            this.administracionBindingSource.DataSource = this.dsFaceReloj;
            // 
            // dsFaceReloj
            // 
            this.dsFaceReloj.DataSetName = "dsFaceReloj";
            this.dsFaceReloj.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // turnosBindingSource
            // 
            this.turnosBindingSource.DataMember = "Turnos";
            this.turnosBindingSource.DataSource = this.dsFaceReloj;
            // 
            // lblFechas
            // 
            this.lblFechas.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblFechas.Appearance.Options.UseFont = true;
            this.lblFechas.Location = new System.Drawing.Point(8, 30);
            this.lblFechas.Name = "lblFechas";
            this.lblFechas.Size = new System.Drawing.Size(63, 13);
            this.lblFechas.TabIndex = 2;
            this.lblFechas.Text = "Fecha Inicial";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Fecha Final";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpleado.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblEmpleado.Appearance.Options.UseFont = true;
            this.lblEmpleado.Location = new System.Drawing.Point(8, 77);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(116, 19);
            this.lblEmpleado.TabIndex = 9;
            this.lblEmpleado.Text = "Empleado Nombre";
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.dsFaceReloj;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.cmdCerrar);
            this.panelControl1.Controls.Add(this.cmdAgregarMarca);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.cmdActualizar);
            this.panelControl1.Controls.Add(this.dt_final);
            this.panelControl1.Controls.Add(this.dt_inicial);
            this.panelControl1.Controls.Add(this.lblFechas);
            this.panelControl1.Controls.Add(this.lblEmpleado);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1157, 100);
            this.panelControl1.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(8, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(173, 17);
            this.labelControl3.TabIndex = 143;
            this.labelControl3.Text = "Resumen de hora de trabajo";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Image = global::LOSA.Properties.Resources.Danieledesantis_Playstation_Flat_Playstation_cross_black_and_white_24;
            this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(1029, 55);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(123, 33);
            this.cmdCerrar.TabIndex = 142;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdAgregarMarca
            // 
            this.cmdAgregarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAgregarMarca.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregarMarca.Image = global::LOSA.Properties.Resources.boton_mas24px2;
            this.cmdAgregarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAgregarMarca.Location = new System.Drawing.Point(900, 55);
            this.cmdAgregarMarca.Name = "cmdAgregarMarca";
            this.cmdAgregarMarca.Size = new System.Drawing.Size(123, 33);
            this.cmdAgregarMarca.TabIndex = 141;
            this.cmdAgregarMarca.Text = "Agregar Marca";
            this.cmdAgregarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAgregarMarca.UseVisualStyleBackColor = true;
            this.cmdAgregarMarca.Click += new System.EventHandler(this.cmdAgregarMarca_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::LOSA.Properties.Resources.sobresalir24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(771, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 33);
            this.button1.TabIndex = 140;
            this.button1.Text = "Exportar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdActualizar
            // 
            this.cmdActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdActualizar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdActualizar.Image = global::LOSA.Properties.Resources.Pictogrammers_Material_Refresh1;
            this.cmdActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdActualizar.Location = new System.Drawing.Point(651, 55);
            this.cmdActualizar.Name = "cmdActualizar";
            this.cmdActualizar.Size = new System.Drawing.Size(114, 33);
            this.cmdActualizar.TabIndex = 139;
            this.cmdActualizar.Text = "Actualizar";
            this.cmdActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdActualizar.UseVisualStyleBackColor = true;
            this.cmdActualizar.Click += new System.EventHandler(this.cmdActualizar_Click);
            // 
            // dt_final
            // 
            this.dt_final.EditValue = null;
            this.dt_final.Location = new System.Drawing.Point(77, 52);
            this.dt_final.Name = "dt_final";
            this.dt_final.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
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
            this.dt_final.Size = new System.Drawing.Size(179, 20);
            this.dt_final.TabIndex = 13;
            this.dt_final.EditValueChanged += new System.EventHandler(this.dt_final_EditValueChanged);
            // 
            // dt_inicial
            // 
            this.dt_inicial.EditValue = null;
            this.dt_inicial.Location = new System.Drawing.Point(77, 26);
            this.dt_inicial.Name = "dt_inicial";
            this.dt_inicial.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
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
            this.dt_inicial.Size = new System.Drawing.Size(179, 20);
            this.dt_inicial.TabIndex = 12;
            this.dt_inicial.EditValueChanged += new System.EventHandler(this.dt_inicial_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // grd_Admin
            // 
            this.grd_Admin.DataSource = this.administracionBindingSource;
            this.grd_Admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Admin.Location = new System.Drawing.Point(0, 100);
            this.grd_Admin.MainView = this.grdv_Admin;
            this.grd_Admin.Name = "grd_Admin";
            this.grd_Admin.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btneditar,
            this.cmdMoreDetails});
            this.grd_Admin.Size = new System.Drawing.Size(1157, 580);
            this.grd_Admin.TabIndex = 13;
            this.grd_Admin.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_Admin});
            // 
            // grdv_Admin
            // 
            this.grdv_Admin.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_Admin.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_Admin.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_Admin.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_Admin.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_Admin.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_Admin.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_Admin.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_Admin.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_Admin.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_Admin.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_Admin.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_Admin.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_Admin.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_Admin.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_Admin.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_Admin.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grdv_Admin.Appearance.Preview.Options.UseFont = true;
            this.grdv_Admin.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_Admin.Appearance.Row.Options.UseFont = true;
            this.grdv_Admin.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_Admin.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_Admin.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colserial,
            this.colCodeReloj,
            this.colCodeODOO,
            this.colName,
            this.colNormalHours,
            this.colExtraHours,
            this.colBegin,
            this.colEnd,
            this.colEditar,
            this.coldepartamento1,
            this.colMarcasAdmon,
            this.colweek});
            this.grdv_Admin.GridControl = this.grd_Admin;
            this.grdv_Admin.Name = "grdv_Admin";
            this.grdv_Admin.OptionsView.ShowAutoFilterRow = true;
            this.grdv_Admin.OptionsView.ShowFooter = true;
            // 
            // colserial
            // 
            this.colserial.FieldName = "serial";
            this.colserial.Name = "colserial";
            this.colserial.OptionsColumn.AllowEdit = false;
            // 
            // colCodeReloj
            // 
            this.colCodeReloj.FieldName = "Code";
            this.colCodeReloj.Name = "colCodeReloj";
            this.colCodeReloj.OptionsColumn.AllowEdit = false;
            this.colCodeReloj.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Code", "{0}")});
            this.colCodeReloj.Visible = true;
            this.colCodeReloj.VisibleIndex = 0;
            this.colCodeReloj.Width = 61;
            // 
            // colCodeODOO
            // 
            this.colCodeODOO.FieldName = "Code ODOO";
            this.colCodeODOO.Name = "colCodeODOO";
            this.colCodeODOO.OptionsColumn.AllowEdit = false;
            this.colCodeODOO.Width = 133;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Width = 137;
            // 
            // colNormalHours
            // 
            this.colNormalHours.FieldName = "Normal  Hours";
            this.colNormalHours.Name = "colNormalHours";
            this.colNormalHours.OptionsColumn.AllowEdit = false;
            this.colNormalHours.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Normal  Hours", "SUM={0:0.##}")});
            this.colNormalHours.Visible = true;
            this.colNormalHours.VisibleIndex = 2;
            this.colNormalHours.Width = 118;
            // 
            // colExtraHours
            // 
            this.colExtraHours.FieldName = "Extra Hours";
            this.colExtraHours.Name = "colExtraHours";
            this.colExtraHours.OptionsColumn.AllowEdit = false;
            this.colExtraHours.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Extra Hours", "SUM={0:0.##}")});
            this.colExtraHours.Visible = true;
            this.colExtraHours.VisibleIndex = 3;
            this.colExtraHours.Width = 118;
            // 
            // colBegin
            // 
            this.colBegin.DisplayFormat.FormatString = "g";
            this.colBegin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBegin.FieldName = "Begin";
            this.colBegin.Name = "colBegin";
            this.colBegin.OptionsColumn.AllowEdit = false;
            this.colBegin.Visible = true;
            this.colBegin.VisibleIndex = 4;
            this.colBegin.Width = 118;
            // 
            // colEnd
            // 
            this.colEnd.DisplayFormat.FormatString = "g";
            this.colEnd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEnd.FieldName = "End";
            this.colEnd.Name = "colEnd";
            this.colEnd.OptionsColumn.AllowEdit = false;
            this.colEnd.Visible = true;
            this.colEnd.VisibleIndex = 5;
            this.colEnd.Width = 161;
            // 
            // colEditar
            // 
            this.colEditar.Caption = "Edit";
            this.colEditar.ColumnEdit = this.btneditar;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 7;
            this.colEditar.Width = 84;
            // 
            // btneditar
            // 
            this.btneditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btneditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btneditar.Name = "btneditar";
            this.btneditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // coldepartamento1
            // 
            this.coldepartamento1.Caption = "Roll";
            this.coldepartamento1.FieldName = "departamento";
            this.coldepartamento1.Name = "coldepartamento1";
            this.coldepartamento1.OptionsColumn.AllowEdit = false;
            this.coldepartamento1.Visible = true;
            this.coldepartamento1.VisibleIndex = 1;
            this.coldepartamento1.Width = 146;
            // 
            // colMarcasAdmon
            // 
            this.colMarcasAdmon.Caption = "More";
            this.colMarcasAdmon.ColumnEdit = this.cmdMoreDetails;
            this.colMarcasAdmon.Name = "colMarcasAdmon";
            this.colMarcasAdmon.Width = 93;
            // 
            // cmdMoreDetails
            // 
            this.cmdMoreDetails.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdMoreDetails.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdMoreDetails.Name = "cmdMoreDetails";
            this.cmdMoreDetails.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colweek
            // 
            this.colweek.Caption = "Week";
            this.colweek.FieldName = "week";
            this.colweek.Name = "colweek";
            this.colweek.Visible = true;
            this.colweek.VisibleIndex = 6;
            // 
            // frmResumenHorasExtraTrabajadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 680);
            this.Controls.Add(this.grd_Admin);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmResumenHorasExtraTrabajadas";
            this.Text = "Resumen de Horas de trabajo";
            ((System.ComponentModel.ISupportInitialize)(this.administracionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFaceReloj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_final.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_inicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_Admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMoreDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblFechas;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblEmpleado;
        private dsFaceReloj dsFaceReloj;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit dt_final;
        private DevExpress.XtraEditors.DateEdit dt_inicial;
        private System.Windows.Forms.BindingSource administracionBindingSource;
        private System.Windows.Forms.BindingSource turnosBindingSource;
        private System.Windows.Forms.Button cmdActualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdAgregarMarca;
        private System.Windows.Forms.Button cmdCerrar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl grd_Admin;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_Admin;
        private DevExpress.XtraGrid.Columns.GridColumn colserial;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeReloj;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeODOO;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colNormalHours;
        private DevExpress.XtraGrid.Columns.GridColumn colExtraHours;
        private DevExpress.XtraGrid.Columns.GridColumn colBegin;
        private DevExpress.XtraGrid.Columns.GridColumn colEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btneditar;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento1;
        private DevExpress.XtraGrid.Columns.GridColumn colMarcasAdmon;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdMoreDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colweek;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}