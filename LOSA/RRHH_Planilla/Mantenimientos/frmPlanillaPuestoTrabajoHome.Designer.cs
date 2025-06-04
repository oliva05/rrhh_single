namespace LOSA.RRHH_Planilla.Mantenimientos
{
    partial class frmPlanillaPuestoTrabajoHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanillaPuestoTrabajoHome));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsMantenimientoPlanilla = new LOSA.RRHH_Planilla.Mantenimientos.dsMantenimientoPlanilla();
            this.gvJobs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_actual_empleados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnotas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_departamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_company = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreate_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_creacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCargarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "hr_jobs";
            this.gridControl1.DataSource = this.dsMantenimientoPlanilla;
            this.gridControl1.Location = new System.Drawing.Point(0, 78);
            this.gridControl1.MainView = this.gvJobs;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditar,
            this.btnDelete});
            this.gridControl1.Size = new System.Drawing.Size(1428, 443);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvJobs});
            // 
            // dsMantenimientoPlanilla
            // 
            this.dsMantenimientoPlanilla.DataSetName = "dsMantenimientoPlanilla";
            this.dsMantenimientoPlanilla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvJobs
            // 
            this.gvJobs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colnumero_actual_empleados,
            this.colnotas,
            this.colid_departamento,
            this.coldepartamento,
            this.colid_company,
            this.colcompany,
            this.colcreate_date,
            this.colusuario_creacion,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvJobs.GridControl = this.gridControl1;
            this.gvJobs.Name = "gvJobs";
            this.gvJobs.OptionsView.ShowAutoFilterRow = true;
            this.gvJobs.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colname
            // 
            this.colname.Caption = "Nombre";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.ReadOnly = true;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 108;
            // 
            // colnumero_actual_empleados
            // 
            this.colnumero_actual_empleados.Caption = "Num. Empleados";
            this.colnumero_actual_empleados.FieldName = "numero_actual_empleados";
            this.colnumero_actual_empleados.Name = "colnumero_actual_empleados";
            this.colnumero_actual_empleados.OptionsColumn.ReadOnly = true;
            this.colnumero_actual_empleados.Visible = true;
            this.colnumero_actual_empleados.VisibleIndex = 2;
            this.colnumero_actual_empleados.Width = 102;
            // 
            // colnotas
            // 
            this.colnotas.Caption = "Notas";
            this.colnotas.FieldName = "notas";
            this.colnotas.Name = "colnotas";
            this.colnotas.OptionsColumn.ReadOnly = true;
            this.colnotas.Visible = true;
            this.colnotas.VisibleIndex = 5;
            this.colnotas.Width = 291;
            // 
            // colid_departamento
            // 
            this.colid_departamento.FieldName = "id_departamento";
            this.colid_departamento.Name = "colid_departamento";
            this.colid_departamento.OptionsColumn.ReadOnly = true;
            // 
            // coldepartamento
            // 
            this.coldepartamento.Caption = "Departamento";
            this.coldepartamento.FieldName = "departamento";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.OptionsColumn.ReadOnly = true;
            this.coldepartamento.Visible = true;
            this.coldepartamento.VisibleIndex = 3;
            this.coldepartamento.Width = 102;
            // 
            // colid_company
            // 
            this.colid_company.FieldName = "id_company";
            this.colid_company.Name = "colid_company";
            this.colid_company.OptionsColumn.ReadOnly = true;
            // 
            // colcompany
            // 
            this.colcompany.Caption = "Compañía";
            this.colcompany.FieldName = "company";
            this.colcompany.Name = "colcompany";
            this.colcompany.OptionsColumn.ReadOnly = true;
            this.colcompany.Visible = true;
            this.colcompany.VisibleIndex = 4;
            this.colcompany.Width = 214;
            // 
            // colcreate_date
            // 
            this.colcreate_date.Caption = "Fecha Creación";
            this.colcreate_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colcreate_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colcreate_date.FieldName = "create_date";
            this.colcreate_date.Name = "colcreate_date";
            this.colcreate_date.OptionsColumn.ReadOnly = true;
            this.colcreate_date.Visible = true;
            this.colcreate_date.VisibleIndex = 6;
            this.colcreate_date.Width = 136;
            // 
            // colusuario_creacion
            // 
            this.colusuario_creacion.Caption = "Usuario Creación";
            this.colusuario_creacion.FieldName = "usuario_creacion";
            this.colusuario_creacion.Name = "colusuario_creacion";
            this.colusuario_creacion.OptionsColumn.ReadOnly = true;
            this.colusuario_creacion.Visible = true;
            this.colusuario_creacion.VisibleIndex = 7;
            this.colusuario_creacion.Width = 155;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.btnEditar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 65;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditar_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Deshabilitar";
            this.gridColumn2.ColumnEdit = this.btnDelete;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 9;
            this.gridColumn2.Width = 92;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDelete_ButtonClick);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(1293, 22);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(110, 36);
            this.cmdCerrar.TabIndex = 19;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdCargarDatos
            // 
            this.cmdCargarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCargarDatos.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdCargarDatos.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarDatos.Appearance.Options.UseBackColor = true;
            this.cmdCargarDatos.Appearance.Options.UseFont = true;
            this.cmdCargarDatos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCargarDatos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargarDatos.ImageOptions.Image")));
            this.cmdCargarDatos.Location = new System.Drawing.Point(1057, 22);
            this.cmdCargarDatos.Name = "cmdCargarDatos";
            this.cmdCargarDatos.Size = new System.Drawing.Size(110, 36);
            this.cmdCargarDatos.TabIndex = 21;
            this.cmdCargarDatos.Text = "Actualizar";
            this.cmdCargarDatos.Click += new System.EventHandler(this.cmdCargarDatos_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1175, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(110, 36);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Text = "Nuevo";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(2, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1426, 25);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Mantenimiento Puestos de Trabajo";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(73, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(137, 17);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Mostrar Deshabilitados";
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.EditValue = true;
            this.toggleSwitch1.Location = new System.Drawing.Point(21, 54);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "No";
            this.toggleSwitch1.Properties.OnText = "Si";
            this.toggleSwitch1.Properties.ShowText = false;
            this.toggleSwitch1.Properties.ValueOff = true;
            this.toggleSwitch1.Properties.ValueOn = false;
            this.toggleSwitch1.Size = new System.Drawing.Size(58, 18);
            this.toggleSwitch1.TabIndex = 29;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Banda Salarial";
            this.gridColumn3.FieldName = "banda_salarial";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 138;
            // 
            // frmPlanillaPuestoTrabajoHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 521);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdCargarDatos);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmPlanillaPuestoTrabajoHome";
            this.Text = "Puestos de Trabajo";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvJobs;
        private dsMantenimientoPlanilla dsMantenimientoPlanilla;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdCargarDatos;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_actual_empleados;
        private DevExpress.XtraGrid.Columns.GridColumn colnotas;
        private DevExpress.XtraGrid.Columns.GridColumn colid_departamento;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colid_company;
        private DevExpress.XtraGrid.Columns.GridColumn colcompany;
        private DevExpress.XtraGrid.Columns.GridColumn colcreate_date;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_creacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}