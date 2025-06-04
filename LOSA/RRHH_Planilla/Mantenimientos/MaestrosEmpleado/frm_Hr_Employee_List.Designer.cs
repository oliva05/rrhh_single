namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    partial class frm_Hr_Employee_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Hr_Employee_List));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsMaestroEmpleados1 = new LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado.dsMaestroEmpleados();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgenero_descrip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljob_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljob_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartment_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colView = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdVerEmpleado = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colrow_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdExcel = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.tggVerInactivos = new DevExpress.XtraEditors.ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado.WaitFormEmployee), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaestroEmpleados1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggVerInactivos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "empleados_list";
            this.gridControl1.DataSource = this.dsMaestroEmpleados1;
            this.gridControl1.Location = new System.Drawing.Point(1, 69);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdVerEmpleado});
            this.gridControl1.Size = new System.Drawing.Size(1409, 556);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMaestroEmpleados1
            // 
            this.dsMaestroEmpleados1.DataSetName = "dsMaestroEmpleados";
            this.dsMaestroEmpleados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colactive,
            this.colestado_nombre,
            this.colgender,
            this.colgenero_descrip,
            this.coladdress_id,
            this.coldireccion,
            this.coljob_id,
            this.coljob_name,
            this.coldepartment_id,
            this.coldepartamento,
            this.colbarcode,
            this.colView,
            this.colrow_num,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.OptionsColumn.ReadOnly = true;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            this.colname.Width = 161;
            // 
            // colactive
            // 
            this.colactive.FieldName = "active";
            this.colactive.Name = "colactive";
            this.colactive.OptionsColumn.ReadOnly = true;
            // 
            // colestado_nombre
            // 
            this.colestado_nombre.FieldName = "estado_nombre";
            this.colestado_nombre.Name = "colestado_nombre";
            this.colestado_nombre.OptionsColumn.AllowEdit = false;
            this.colestado_nombre.OptionsColumn.ReadOnly = true;
            this.colestado_nombre.Visible = true;
            this.colestado_nombre.VisibleIndex = 8;
            this.colestado_nombre.Width = 77;
            // 
            // colgender
            // 
            this.colgender.FieldName = "gender";
            this.colgender.Name = "colgender";
            this.colgender.OptionsColumn.ReadOnly = true;
            // 
            // colgenero_descrip
            // 
            this.colgenero_descrip.FieldName = "genero_descrip";
            this.colgenero_descrip.Name = "colgenero_descrip";
            this.colgenero_descrip.OptionsColumn.AllowEdit = false;
            this.colgenero_descrip.OptionsColumn.ReadOnly = true;
            this.colgenero_descrip.Visible = true;
            this.colgenero_descrip.VisibleIndex = 3;
            this.colgenero_descrip.Width = 105;
            // 
            // coladdress_id
            // 
            this.coladdress_id.FieldName = "address_id";
            this.coladdress_id.Name = "coladdress_id";
            this.coladdress_id.OptionsColumn.ReadOnly = true;
            // 
            // coldireccion
            // 
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.OptionsColumn.AllowEdit = false;
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 9;
            this.coldireccion.Width = 182;
            // 
            // coljob_id
            // 
            this.coljob_id.FieldName = "job_id";
            this.coljob_id.Name = "coljob_id";
            this.coljob_id.OptionsColumn.ReadOnly = true;
            // 
            // coljob_name
            // 
            this.coljob_name.FieldName = "job_name";
            this.coljob_name.Name = "coljob_name";
            this.coljob_name.OptionsColumn.AllowEdit = false;
            this.coljob_name.OptionsColumn.ReadOnly = true;
            this.coljob_name.Visible = true;
            this.coljob_name.VisibleIndex = 6;
            this.coljob_name.Width = 197;
            // 
            // coldepartment_id
            // 
            this.coldepartment_id.FieldName = "department_id";
            this.coldepartment_id.Name = "coldepartment_id";
            this.coldepartment_id.OptionsColumn.ReadOnly = true;
            // 
            // coldepartamento
            // 
            this.coldepartamento.FieldName = "departamento";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.OptionsColumn.AllowEdit = false;
            this.coldepartamento.OptionsColumn.ReadOnly = true;
            this.coldepartamento.Visible = true;
            this.coldepartamento.VisibleIndex = 7;
            this.coldepartamento.Width = 206;
            // 
            // colbarcode
            // 
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.OptionsColumn.AllowEdit = false;
            this.colbarcode.OptionsColumn.ReadOnly = true;
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 1;
            this.colbarcode.Width = 98;
            // 
            // colView
            // 
            this.colView.Caption = "Ver";
            this.colView.ColumnEdit = this.cmdVerEmpleado;
            this.colView.Name = "colView";
            this.colView.Visible = true;
            this.colView.VisibleIndex = 10;
            this.colView.Width = 97;
            // 
            // cmdVerEmpleado
            // 
            this.cmdVerEmpleado.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdVerEmpleado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdVerEmpleado.Name = "cmdVerEmpleado";
            this.cmdVerEmpleado.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdVerEmpleado.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdVerEmpleado_ButtonClick);
            // 
            // colrow_num
            // 
            this.colrow_num.FieldName = "row_num";
            this.colrow_num.Name = "colrow_num";
            this.colrow_num.OptionsColumn.AllowEdit = false;
            this.colrow_num.OptionsColumn.ReadOnly = true;
            this.colrow_num.Visible = true;
            this.colrow_num.VisibleIndex = 0;
            this.colrow_num.Width = 64;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Fecha Ingreso";
            this.gridColumn1.FieldName = "fecha_inicio";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 97;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Fecha Salida";
            this.gridColumn2.FieldName = "fecha_fin";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 100;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(4, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 21);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Empleados";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAgregar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Image = global::LOSA.Properties.Resources.Ionic_Ionicons_Add_circle_sharp_24;
            this.cmdAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAgregar.Location = new System.Drawing.Point(1, 30);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(86, 33);
            this.cmdAgregar.TabIndex = 2;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdExcel
            // 
            this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExcel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcel.Image = global::LOSA.Properties.Resources.Dakirby309_Simply_Styled_Microsoft_Excel_2013_24;
            this.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExcel.Location = new System.Drawing.Point(1232, 30);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(86, 33);
            this.cmdExcel.TabIndex = 3;
            this.cmdExcel.Text = "Exportar";
            this.cmdExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExcel.UseVisualStyleBackColor = true;
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Image = global::LOSA.Properties.Resources.Danieledesantis_Playstation_Flat_Playstation_cross_black_and_white_24;
            this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(1324, 30);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(86, 33);
            this.cmdCerrar.TabIndex = 4;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // tggVerInactivos
            // 
            this.tggVerInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tggVerInactivos.Location = new System.Drawing.Point(1068, 42);
            this.tggVerInactivos.Name = "tggVerInactivos";
            this.tggVerInactivos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tggVerInactivos.Properties.Appearance.Options.UseFont = true;
            this.tggVerInactivos.Properties.OffText = "No";
            this.tggVerInactivos.Properties.OnText = "Si";
            this.tggVerInactivos.Size = new System.Drawing.Size(95, 19);
            this.tggVerInactivos.TabIndex = 5;
            this.tggVerInactivos.Toggled += new System.EventHandler(this.tggVerInactivos_Toggled);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(991, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ver Inactivos";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frm_Hr_Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tggVerInactivos);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdExcel);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frm_Hr_Employee_List";
            this.Text = "Lista de Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaestroEmpleados1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggVerInactivos.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdExcel;
        private System.Windows.Forms.Button cmdCerrar;
        private dsMaestroEmpleados dsMaestroEmpleados1;
        private DevExpress.XtraEditors.ToggleSwitch tggVerInactivos;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colactive;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colgender;
        private DevExpress.XtraGrid.Columns.GridColumn colgenero_descrip;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraGrid.Columns.GridColumn coljob_id;
        private DevExpress.XtraGrid.Columns.GridColumn coljob_name;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartment_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colbarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colView;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVerEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colrow_num;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}