namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    partial class frmEmployeeBeneficiariosHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeBeneficiariosHome));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcBeneficiarios = new DevExpress.XtraGrid.GridControl();
            this.dsMaestroEmpleados1 = new LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado.dsMaestroEmpleados();
            this.gvBeneficiarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidentidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colporcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPorcentaje = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcBeneficiarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaestroEmpleados1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBeneficiarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // gcBeneficiarios
            // 
            this.gcBeneficiarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcBeneficiarios.DataMember = "employee_beneficiarios";
            this.gcBeneficiarios.DataSource = this.dsMaestroEmpleados1;
            this.gcBeneficiarios.Location = new System.Drawing.Point(0, 56);
            this.gcBeneficiarios.MainView = this.gvBeneficiarios;
            this.gcBeneficiarios.Name = "gcBeneficiarios";
            this.gcBeneficiarios.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnDelete,
            this.txtPorcentaje});
            this.gcBeneficiarios.Size = new System.Drawing.Size(479, 201);
            this.gcBeneficiarios.TabIndex = 0;
            this.gcBeneficiarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBeneficiarios});
            // 
            // dsMaestroEmpleados1
            // 
            this.dsMaestroEmpleados1.DataSetName = "dsMaestroEmpleados";
            this.dsMaestroEmpleados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvBeneficiarios
            // 
            this.gvBeneficiarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colidentidad,
            this.colnombre,
            this.colporcentaje,
            this.colDelete});
            this.gvBeneficiarios.GridControl = this.gcBeneficiarios;
            this.gvBeneficiarios.Name = "gvBeneficiarios";
            this.gvBeneficiarios.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvBeneficiarios.OptionsView.ShowGroupPanel = false;
            this.gvBeneficiarios.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvBeneficiarios_ValidatingEditor);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colidentidad
            // 
            this.colidentidad.Caption = "Identidad";
            this.colidentidad.FieldName = "identidad";
            this.colidentidad.Name = "colidentidad";
            this.colidentidad.Visible = true;
            this.colidentidad.VisibleIndex = 0;
            this.colidentidad.Width = 167;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 172;
            // 
            // colporcentaje
            // 
            this.colporcentaje.Caption = "Porcentaje";
            this.colporcentaje.ColumnEdit = this.txtPorcentaje;
            this.colporcentaje.DisplayFormat.FormatString = "{0:N2}%";
            this.colporcentaje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colporcentaje.FieldName = "porcentaje";
            this.colporcentaje.Name = "colporcentaje";
            this.colporcentaje.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "porcentaje", "SUM={0:N2}%")});
            this.colporcentaje.Visible = true;
            this.colporcentaje.VisibleIndex = 2;
            this.colporcentaje.Width = 115;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.AutoHeight = false;
            this.txtPorcentaje.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPorcentaje.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPorcentaje.MaskSettings.Set("mask", "P");
            this.txtPorcentaje.Name = "txtPorcentaje";
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Borrar";
            this.colDelete.ColumnEdit = this.btnDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDelete.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDelete_ButtonPressed);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEdit.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEdit_ButtonPressed);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(251, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.labelControl1.Size = new System.Drawing.Size(168, 20);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Especificar Beneficiarios";
            // 
            // frmEmployeeBeneficiariosHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 256);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gcBeneficiarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployeeBeneficiariosHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beneficiarios";
            ((System.ComponentModel.ISupportInitialize)(this.gcBeneficiarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaestroEmpleados1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBeneficiarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcBeneficiarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBeneficiarios;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private dsMaestroEmpleados dsMaestroEmpleados1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colidentidad;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colporcentaje;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtPorcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
    }
}