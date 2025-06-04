namespace LOSA.RRHH_Planilla.Reportes
{
    partial class frmCuadroVacaciones
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuadroVacaciones));
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsInasistencias1 = new LOSA.RRHH_Planilla.Planilla.Ausencias.dsInasistencias();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldias_acumulados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldias_tomados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colantiguedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposDetalle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tggSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.lblTipo = new DevExpress.XtraEditors.LabelControl();
            this.slueEmployee = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.hremployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaestroEmpleados1 = new LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado.dsMaestroEmpleados();
            this.cmdRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.checkedComboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInasistencias1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hremployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaestroEmpleados1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(1319, 120);
            this.tileControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "cuadro_vacaciones";
            this.gridControl1.DataSource = this.dsInasistencias1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 120);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposDetalle});
            this.gridControl1.Size = new System.Drawing.Size(1319, 653);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsInasistencias1
            // 
            this.dsInasistencias1.DataSetName = "dsInasistencias";
            this.dsInasistencias1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo,
            this.colnombre1,
            this.coldepartamento,
            this.colfecha_ingreso,
            this.coldias_acumulados,
            this.coldias_tomados,
            this.colpendiente,
            this.colantiguedad,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 66;
            // 
            // colnombre1
            // 
            this.colnombre1.Caption = "Nombre del Empleado";
            this.colnombre1.FieldName = "nombre";
            this.colnombre1.Name = "colnombre1";
            this.colnombre1.Visible = true;
            this.colnombre1.VisibleIndex = 1;
            this.colnombre1.Width = 250;
            // 
            // coldepartamento
            // 
            this.coldepartamento.Caption = "Departamento";
            this.coldepartamento.FieldName = "departamento";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.Visible = true;
            this.coldepartamento.VisibleIndex = 2;
            this.coldepartamento.Width = 98;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "Fecha de Ingreso";
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 3;
            this.colfecha_ingreso.Width = 161;
            // 
            // coldias_acumulados
            // 
            this.coldias_acumulados.Caption = "Dias que corresponden";
            this.coldias_acumulados.FieldName = "dias_acumulados";
            this.coldias_acumulados.Name = "coldias_acumulados";
            this.coldias_acumulados.Visible = true;
            this.coldias_acumulados.VisibleIndex = 4;
            this.coldias_acumulados.Width = 155;
            // 
            // coldias_tomados
            // 
            this.coldias_tomados.Caption = "Dias ya tomados";
            this.coldias_tomados.FieldName = "dias_tomados";
            this.coldias_tomados.Name = "coldias_tomados";
            this.coldias_tomados.Visible = true;
            this.coldias_tomados.VisibleIndex = 5;
            this.coldias_tomados.Width = 147;
            // 
            // colpendiente
            // 
            this.colpendiente.Caption = "Dias pendientes";
            this.colpendiente.FieldName = "pendiente";
            this.colpendiente.Name = "colpendiente";
            this.colpendiente.Visible = true;
            this.colpendiente.VisibleIndex = 6;
            this.colpendiente.Width = 113;
            // 
            // colantiguedad
            // 
            this.colantiguedad.Caption = "Antiguedad";
            this.colantiguedad.FieldName = "antiguedad";
            this.colantiguedad.Name = "colantiguedad";
            this.colantiguedad.Visible = true;
            this.colantiguedad.VisibleIndex = 7;
            this.colantiguedad.Width = 184;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ver Detalle";
            this.gridColumn1.ColumnEdit = this.reposDetalle;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 120;
            // 
            // reposDetalle
            // 
            this.reposDetalle.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.contentarrangeinrows_16x161;
            this.reposDetalle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposDetalle.Name = "reposDetalle";
            this.reposDetalle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposDetalle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposDetalle_ButtonClick);
            // 
            // tggSwitch
            // 
            this.tggSwitch.Enabled = false;
            this.tggSwitch.Location = new System.Drawing.Point(214, 44);
            this.tggSwitch.Name = "tggSwitch";
            this.tggSwitch.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.tggSwitch.Properties.Appearance.Options.UseFont = true;
            this.tggSwitch.Properties.OffText = "Por Departamento";
            this.tggSwitch.Properties.OnText = "Por Empleado";
            this.tggSwitch.Size = new System.Drawing.Size(184, 20);
            this.tggSwitch.TabIndex = 3;
            this.tggSwitch.Toggled += new System.EventHandler(this.tggSwitch_Toggled);
            // 
            // lblTipo
            // 
            this.lblTipo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipo.Appearance.Options.UseFont = true;
            this.lblTipo.Location = new System.Drawing.Point(24, 73);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(80, 15);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Departamento:";
            // 
            // slueEmployee
            // 
            this.slueEmployee.Location = new System.Drawing.Point(108, 70);
            this.slueEmployee.Name = "slueEmployee";
            this.slueEmployee.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.slueEmployee.Properties.Appearance.Options.UseFont = true;
            this.slueEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueEmployee.Properties.DataSource = this.hremployeeBindingSource;
            this.slueEmployee.Properties.DisplayMember = "nombre";
            this.slueEmployee.Properties.NullText = "";
            this.slueEmployee.Properties.PopupView = this.searchLookUpEdit1View;
            this.slueEmployee.Properties.ValueMember = "id";
            this.slueEmployee.Size = new System.Drawing.Size(325, 22);
            this.slueEmployee.TabIndex = 4;
            // 
            // hremployeeBindingSource
            // 
            this.hremployeeBindingSource.DataMember = "hr_employee";
            this.hremployeeBindingSource.DataSource = this.dsInasistencias1;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colbarcode,
            this.colnombre});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colbarcode
            // 
            this.colbarcode.Caption = "Código";
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 1;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "departamentos";
            this.departamentosBindingSource.DataSource = this.dsMaestroEmpleados1;
            // 
            // dsMaestroEmpleados1
            // 
            this.dsMaestroEmpleados1.DataSetName = "dsMaestroEmpleados";
            this.dsMaestroEmpleados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdRefresh.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmdRefresh.Appearance.Options.UseBackColor = true;
            this.cmdRefresh.Appearance.Options.UseFont = true;
            this.cmdRefresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRefresh.ImageOptions.Image")));
            this.cmdRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdRefresh.Location = new System.Drawing.Point(451, 63);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(114, 33);
            this.cmdRefresh.TabIndex = 150;
            this.cmdRefresh.Text = "Cargar";
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Image = global::LOSA.Properties.Resources.Danieledesantis_Playstation_Flat_Playstation_cross_black_and_white_24;
            this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(1221, 12);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(86, 33);
            this.cmdCerrar.TabIndex = 153;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = global::LOSA.Properties.Resources.excel32px;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(1112, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(86, 33);
            this.btnExport.TabIndex = 155;
            this.btnExport.Text = "Exportar";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::LOSA.Properties.Resources.impresora_24X24;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(1006, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 33);
            this.btnPrint.TabIndex = 154;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            // 
            // checkedComboBoxEdit1
            // 
            this.checkedComboBoxEdit1.Location = new System.Drawing.Point(108, 70);
            this.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            this.checkedComboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.checkedComboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit1.Properties.DataSource = this.departamentosBindingSource;
            this.checkedComboBoxEdit1.Properties.DisplayMember = "descripcion";
            this.checkedComboBoxEdit1.Properties.SelectAllItemCaption = "(Todos)";
            this.checkedComboBoxEdit1.Properties.ValueMember = "id";
            this.checkedComboBoxEdit1.Size = new System.Drawing.Size(325, 22);
            this.checkedComboBoxEdit1.TabIndex = 159;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(126, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 15);
            this.labelControl1.TabIndex = 160;
            this.labelControl1.Text = "Tipo Busqueda:";
            // 
            // frmCuadroVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 773);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.checkedComboBoxEdit1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.tggSwitch);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.slueEmployee);
            this.Controls.Add(this.tileControl1);
            this.Name = "frmCuadroVacaciones";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInasistencias1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggSwitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hremployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaestroEmpleados1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ToggleSwitch tggSwitch;
        private DevExpress.XtraEditors.LabelControl lblTipo;
        private DevExpress.XtraEditors.SearchLookUpEdit slueEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colbarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private Planilla.Ausencias.dsInasistencias dsInasistencias1;
        private System.Windows.Forms.BindingSource hremployeeBindingSource;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private Mantenimientos.MaestrosEmpleado.dsMaestroEmpleados dsMaestroEmpleados1;
        private DevExpress.XtraEditors.SimpleButton cmdRefresh;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre1;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn coldias_acumulados;
        private DevExpress.XtraGrid.Columns.GridColumn coldias_tomados;
        private DevExpress.XtraGrid.Columns.GridColumn colpendiente;
        private DevExpress.XtraGrid.Columns.GridColumn colantiguedad;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}