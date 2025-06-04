namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    partial class frmEmployeeChildrenHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeChildrenHome));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcHijos = new DevExpress.XtraGrid.GridControl();
            this.employeechildrenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaestroEmpleados1 = new LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado.dsMaestroEmpleados();
            this.gvHijos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgenero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_nacimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coledad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_employee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcHijos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeechildrenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaestroEmpleados1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHijos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // gcHijos
            // 
            this.gcHijos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcHijos.DataSource = this.employeechildrenBindingSource;
            this.gcHijos.Location = new System.Drawing.Point(0, 57);
            this.gcHijos.MainView = this.gvHijos;
            this.gcHijos.Name = "gcHijos";
            this.gcHijos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnDelete});
            this.gcHijos.Size = new System.Drawing.Size(479, 189);
            this.gcHijos.TabIndex = 0;
            this.gcHijos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHijos});
            // 
            // employeechildrenBindingSource
            // 
            this.employeechildrenBindingSource.DataMember = "employee_children";
            this.employeechildrenBindingSource.DataSource = this.dsMaestroEmpleados1;
            // 
            // dsMaestroEmpleados1
            // 
            this.dsMaestroEmpleados1.DataSetName = "dsMaestroEmpleados";
            this.dsMaestroEmpleados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvHijos
            // 
            this.gvHijos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colgenero,
            this.colfecha_nacimiento,
            this.coledad,
            this.colid_employee,
            this.colEditar,
            this.colDelete});
            this.gvHijos.GridControl = this.gcHijos;
            this.gvHijos.Name = "gvHijos";
            this.gvHijos.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colgenero
            // 
            this.colgenero.Caption = "Género";
            this.colgenero.FieldName = "genero";
            this.colgenero.Name = "colgenero";
            this.colgenero.OptionsColumn.ReadOnly = true;
            this.colgenero.OptionsFilter.AllowFilter = false;
            this.colgenero.Visible = true;
            this.colgenero.VisibleIndex = 0;
            this.colgenero.Width = 96;
            // 
            // colfecha_nacimiento
            // 
            this.colfecha_nacimiento.Caption = "Fecha de Nacimiento";
            this.colfecha_nacimiento.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colfecha_nacimiento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_nacimiento.FieldName = "fecha_nacimiento";
            this.colfecha_nacimiento.Name = "colfecha_nacimiento";
            this.colfecha_nacimiento.OptionsColumn.ReadOnly = true;
            this.colfecha_nacimiento.OptionsFilter.AllowFilter = false;
            this.colfecha_nacimiento.Visible = true;
            this.colfecha_nacimiento.VisibleIndex = 1;
            this.colfecha_nacimiento.Width = 115;
            // 
            // coledad
            // 
            this.coledad.Caption = "Edad";
            this.coledad.FieldName = "edad";
            this.coledad.Name = "coledad";
            this.coledad.OptionsColumn.ReadOnly = true;
            this.coledad.OptionsFilter.AllowFilter = false;
            this.coledad.Visible = true;
            this.coledad.VisibleIndex = 2;
            this.coledad.Width = 98;
            // 
            // colid_employee
            // 
            this.colid_employee.FieldName = "id_employee";
            this.colid_employee.Name = "colid_employee";
            // 
            // colEditar
            // 
            this.colEditar.Caption = "Editar";
            this.colEditar.ColumnEdit = this.btnEdit;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 3;
            this.colEditar.Width = 71;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEdit.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEdit_ButtonPressed);
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Desactivar";
            this.colDelete.ColumnEdit = this.btnDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 4;
            this.colDelete.Width = 74;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDelete.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDelete_ButtonPressed);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(251, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(362, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cancelar";
            this.btnClose.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(146, 20);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Información de Hijos";
            // 
            // frmEmployeeChildrenHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 245);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gcHijos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployeeChildrenHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hijos";
            ((System.ComponentModel.ISupportInitialize)(this.gcHijos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeechildrenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaestroEmpleados1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHijos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcHijos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHijos;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.BindingSource employeechildrenBindingSource;
        private dsMaestroEmpleados dsMaestroEmpleados1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colgenero;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_nacimiento;
        private DevExpress.XtraGrid.Columns.GridColumn coledad;
        private DevExpress.XtraGrid.Columns.GridColumn colid_employee;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}