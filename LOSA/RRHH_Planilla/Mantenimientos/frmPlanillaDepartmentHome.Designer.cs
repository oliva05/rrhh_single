namespace LOSA.RRHH_Planilla.Mantenimientos
{
    partial class frmPlanillaDepartmentHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanillaDepartmentHome));
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
            this.gvDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomplete_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcompany_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colparent_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_departamento_parent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreate_uid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreate_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colwrite_uid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colwrite_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpayment_account_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanalytic_department_account_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCargarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "hr_deparment";
            this.gridControl1.DataSource = this.dsMantenimientoPlanilla;
            this.gridControl1.Location = new System.Drawing.Point(0, 78);
            this.gridControl1.MainView = this.gvDepartment;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditar,
            this.btnDelete});
            this.gridControl1.Size = new System.Drawing.Size(1521, 843);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDepartment});
            // 
            // dsMantenimientoPlanilla
            // 
            this.dsMantenimientoPlanilla.DataSetName = "dsMantenimientoPlanilla";
            this.dsMantenimientoPlanilla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvDepartment
            // 
            this.gvDepartment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colcomplete_name,
            this.colactive,
            this.colcompany_id,
            this.colparent_id,
            this.colid_departamento_parent,
            this.colcreate_uid,
            this.colcreate_date,
            this.colwrite_uid,
            this.colwrite_date,
            this.colpayment_account_id,
            this.colanalytic_department_account_id,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvDepartment.GridControl = this.gridControl1;
            this.gvDepartment.Name = "gvDepartment";
            this.gvDepartment.OptionsView.ShowAutoFilterRow = true;
            this.gvDepartment.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colname
            // 
            this.colname.Caption = "Nombre";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.OptionsColumn.ReadOnly = true;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 192;
            // 
            // colcomplete_name
            // 
            this.colcomplete_name.Caption = "Nombre Completo";
            this.colcomplete_name.FieldName = "complete_name";
            this.colcomplete_name.Name = "colcomplete_name";
            this.colcomplete_name.OptionsColumn.AllowEdit = false;
            this.colcomplete_name.OptionsColumn.ReadOnly = true;
            this.colcomplete_name.Visible = true;
            this.colcomplete_name.VisibleIndex = 1;
            this.colcomplete_name.Width = 287;
            // 
            // colactive
            // 
            this.colactive.FieldName = "active";
            this.colactive.Name = "colactive";
            this.colactive.OptionsColumn.AllowEdit = false;
            this.colactive.OptionsColumn.ReadOnly = true;
            this.colactive.Width = 106;
            // 
            // colcompany_id
            // 
            this.colcompany_id.FieldName = "company_id";
            this.colcompany_id.Name = "colcompany_id";
            this.colcompany_id.OptionsColumn.AllowEdit = false;
            this.colcompany_id.OptionsColumn.ReadOnly = true;
            this.colcompany_id.Width = 106;
            // 
            // colparent_id
            // 
            this.colparent_id.FieldName = "parent_id";
            this.colparent_id.Name = "colparent_id";
            this.colparent_id.OptionsColumn.AllowEdit = false;
            this.colparent_id.OptionsColumn.ReadOnly = true;
            this.colparent_id.Width = 176;
            // 
            // colid_departamento_parent
            // 
            this.colid_departamento_parent.FieldName = "id_departamento_parent";
            this.colid_departamento_parent.Name = "colid_departamento_parent";
            this.colid_departamento_parent.OptionsColumn.AllowEdit = false;
            this.colid_departamento_parent.OptionsColumn.ReadOnly = true;
            this.colid_departamento_parent.Width = 145;
            // 
            // colcreate_uid
            // 
            this.colcreate_uid.FieldName = "create_uid";
            this.colcreate_uid.Name = "colcreate_uid";
            this.colcreate_uid.OptionsColumn.AllowEdit = false;
            this.colcreate_uid.OptionsColumn.ReadOnly = true;
            // 
            // colcreate_date
            // 
            this.colcreate_date.Caption = "Fecha Creación";
            this.colcreate_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm tt";
            this.colcreate_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colcreate_date.FieldName = "create_date";
            this.colcreate_date.Name = "colcreate_date";
            this.colcreate_date.OptionsColumn.AllowEdit = false;
            this.colcreate_date.OptionsColumn.ReadOnly = true;
            this.colcreate_date.Visible = true;
            this.colcreate_date.VisibleIndex = 5;
            this.colcreate_date.Width = 155;
            // 
            // colwrite_uid
            // 
            this.colwrite_uid.FieldName = "write_uid";
            this.colwrite_uid.Name = "colwrite_uid";
            this.colwrite_uid.OptionsColumn.AllowEdit = false;
            this.colwrite_uid.OptionsColumn.ReadOnly = true;
            // 
            // colwrite_date
            // 
            this.colwrite_date.FieldName = "write_date";
            this.colwrite_date.Name = "colwrite_date";
            this.colwrite_date.OptionsColumn.AllowEdit = false;
            this.colwrite_date.OptionsColumn.ReadOnly = true;
            // 
            // colpayment_account_id
            // 
            this.colpayment_account_id.FieldName = "payment_account_id";
            this.colpayment_account_id.Name = "colpayment_account_id";
            this.colpayment_account_id.OptionsColumn.AllowEdit = false;
            this.colpayment_account_id.OptionsColumn.ReadOnly = true;
            this.colpayment_account_id.Width = 169;
            // 
            // colanalytic_department_account_id
            // 
            this.colanalytic_department_account_id.FieldName = "analytic_department_account_id";
            this.colanalytic_department_account_id.Name = "colanalytic_department_account_id";
            this.colanalytic_department_account_id.OptionsColumn.AllowEdit = false;
            this.colanalytic_department_account_id.OptionsColumn.ReadOnly = true;
            this.colanalytic_department_account_id.Width = 81;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.btnEditar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 67;
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
            this.gridColumn2.Caption = "Usuario Creación";
            this.gridColumn2.FieldName = "usuario_creacion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 234;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Compañía";
            this.gridColumn3.FieldName = "compania";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 210;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Deshabilitar";
            this.gridColumn4.ColumnEdit = this.btnDelete;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            this.gridColumn4.Width = 65;
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
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cuenta";
            this.gridColumn5.FieldName = "cuenta";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 193;
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
            this.cmdCerrar.Location = new System.Drawing.Point(1386, 22);
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
            this.cmdCargarDatos.Location = new System.Drawing.Point(1150, 22);
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
            this.simpleButton1.Location = new System.Drawing.Point(1268, 22);
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
            this.labelControl1.Size = new System.Drawing.Size(1521, 25);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Mantenimiento Departamentos";
            // 
            // frmPlanillaDepartmentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 921);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdCargarDatos);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmPlanillaDepartmentHome";
            this.Text = "Departamentos";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDepartment;
        private dsMantenimientoPlanilla dsMantenimientoPlanilla;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdCargarDatos;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colcomplete_name;
        private DevExpress.XtraGrid.Columns.GridColumn colactive;
        private DevExpress.XtraGrid.Columns.GridColumn colcompany_id;
        private DevExpress.XtraGrid.Columns.GridColumn colparent_id;
        private DevExpress.XtraGrid.Columns.GridColumn colid_departamento_parent;
        private DevExpress.XtraGrid.Columns.GridColumn colcreate_uid;
        private DevExpress.XtraGrid.Columns.GridColumn colcreate_date;
        private DevExpress.XtraGrid.Columns.GridColumn colwrite_uid;
        private DevExpress.XtraGrid.Columns.GridColumn colwrite_date;
        private DevExpress.XtraGrid.Columns.GridColumn colpayment_account_id;
        private DevExpress.XtraGrid.Columns.GridColumn colanalytic_department_account_id;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}