namespace LOSA.RRHH_Planilla.Mantenimientos
{
    partial class frmPlanillaTipoAsignacionHome
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanillaTipoAsignacionHome));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsMantenimientoPlanilla1 = new LOSA.RRHH_Planilla.Mantenimientos.dsMantenimientoPlanilla();
            this.gvAsignacionTipo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreate_uid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_creacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario_creacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCargarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAsignacionTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "hr_employee_asignacion_type";
            this.gridControl1.DataSource = this.dsMantenimientoPlanilla1;
            this.gridControl1.Location = new System.Drawing.Point(0, 78);
            this.gridControl1.MainView = this.gvAsignacionTipo;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditar,
            this.btnDelete});
            this.gridControl1.Size = new System.Drawing.Size(1428, 443);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAsignacionTipo});
            // 
            // dsMantenimientoPlanilla1
            // 
            this.dsMantenimientoPlanilla1.DataSetName = "dsMantenimientoPlanilla";
            this.dsMantenimientoPlanilla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvAsignacionTipo
            // 
            this.gvAsignacionTipo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colcreate_uid,
            this.colfecha_creacion,
            this.colusuario_creacion,
            this.gridColumn1,
            this.gridColumn2});
            this.gvAsignacionTipo.GridControl = this.gridControl1;
            this.gvAsignacionTipo.Name = "gvAsignacionTipo";
            this.gvAsignacionTipo.OptionsView.ShowAutoFilterRow = true;
            this.gvAsignacionTipo.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Width = 200;
            // 
            // colname
            // 
            this.colname.Caption = "Nombre";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.ReadOnly = true;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 776;
            // 
            // colcreate_uid
            // 
            this.colcreate_uid.FieldName = "create_uid";
            this.colcreate_uid.Name = "colcreate_uid";
            this.colcreate_uid.Width = 220;
            // 
            // colfecha_creacion
            // 
            this.colfecha_creacion.Caption = "Fecha Creación";
            this.colfecha_creacion.FieldName = "create_date";
            this.colfecha_creacion.Name = "colfecha_creacion";
            this.colfecha_creacion.OptionsColumn.ReadOnly = true;
            this.colfecha_creacion.Visible = true;
            this.colfecha_creacion.VisibleIndex = 1;
            this.colfecha_creacion.Width = 116;
            // 
            // colusuario_creacion
            // 
            this.colusuario_creacion.Caption = "Usuario Creación";
            this.colusuario_creacion.FieldName = "usuario_creacion";
            this.colusuario_creacion.Name = "colusuario_creacion";
            this.colusuario_creacion.OptionsColumn.ReadOnly = true;
            this.colusuario_creacion.Visible = true;
            this.colusuario_creacion.VisibleIndex = 2;
            this.colusuario_creacion.Width = 334;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.btnEditar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 68;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
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
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 109;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
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
            this.labelControl1.Size = new System.Drawing.Size(1428, 25);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Mantenimiento Tipo Asignación";
            // 
            // frmPlanillaTipoAsignacionHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 521);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdCargarDatos);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmPlanillaTipoAsignacionHome";
            this.Text = "Tipo Asignación";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAsignacionTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAsignacionTipo;
        private dsMantenimientoPlanilla dsMantenimientoPlanilla1;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdCargarDatos;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colcreate_uid;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_creacion;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_creacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}