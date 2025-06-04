namespace LOSA.Logistica.CheckList
{
    partial class frmCheckListItemsHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckListItemsHome));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcItems = new DevExpress.XtraGrid.GridControl();
            this.dsCheckList1 = new LOSA.Logistica.CheckList.dsCheckList();
            this.gvItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre_corto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_largo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmodelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCheckList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // gcItems
            // 
            this.gcItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcItems.DataMember = "checklist_items";
            this.gcItems.DataSource = this.dsCheckList1;
            this.gcItems.Location = new System.Drawing.Point(-1, 97);
            this.gcItems.MainView = this.gvItems;
            this.gcItems.Name = "gcItems";
            this.gcItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnDelete});
            this.gcItems.Size = new System.Drawing.Size(1183, 467);
            this.gcItems.TabIndex = 0;
            this.gcItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvItems});
            // 
            // dsCheckList1
            // 
            this.dsCheckList1.DataSetName = "dsCheckList";
            this.dsCheckList1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvItems
            // 
            this.gvItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre_corto,
            this.colnombre_largo,
            this.colmodelo,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvItems.GridControl = this.gcItems;
            this.gvItems.Name = "gvItems";
            this.gvItems.OptionsView.ShowGroupPanel = false;
            // 
            // colnombre_corto
            // 
            this.colnombre_corto.Caption = "Nombre Corto";
            this.colnombre_corto.FieldName = "nombre_corto";
            this.colnombre_corto.Name = "colnombre_corto";
            this.colnombre_corto.OptionsColumn.ReadOnly = true;
            this.colnombre_corto.Visible = true;
            this.colnombre_corto.VisibleIndex = 0;
            this.colnombre_corto.Width = 216;
            // 
            // colnombre_largo
            // 
            this.colnombre_largo.Caption = "Nombre Largo";
            this.colnombre_largo.FieldName = "nombre_largo";
            this.colnombre_largo.Name = "colnombre_largo";
            this.colnombre_largo.OptionsColumn.ReadOnly = true;
            this.colnombre_largo.Visible = true;
            this.colnombre_largo.VisibleIndex = 1;
            this.colnombre_largo.Width = 216;
            // 
            // colmodelo
            // 
            this.colmodelo.Caption = "Modelo";
            this.colmodelo.FieldName = "modelo";
            this.colmodelo.Name = "colmodelo";
            this.colmodelo.OptionsColumn.ReadOnly = true;
            this.colmodelo.Visible = true;
            this.colmodelo.VisibleIndex = 3;
            this.colmodelo.Width = 409;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.btnEdit;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 87;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEdit_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Borrar";
            this.gridColumn2.ColumnEdit = this.btnDelete;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 85;
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
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Código";
            this.gridColumn3.FieldName = "codigo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 145;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.LightCoral;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.AppearancePressed.Options.UseForeColor = true;
            //this.simpleButton1.ImageOptions.SvgImage = global::LOSA.Properties.Resources.HomeSolid;
            this.simpleButton1.Location = new System.Drawing.Point(1056, 31);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(111, 41);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Home";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.AppearancePressed.Options.UseForeColor = true;
            //this.btnAdd.ImageOptions.SvgImage = global::LOSA.Properties.Resources.NewFolder;
            this.btnAdd.Location = new System.Drawing.Point(930, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Nuevo";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Appearance.BackColor = System.Drawing.Color.Moccasin;
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Appearance.Options.UseBackColor = true;
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Appearance.Options.UseForeColor = true;
            this.btnUpdate.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.AppearancePressed.Options.UseForeColor = true;
            //this.btnUpdate.ImageOptions.SvgImage = global::LOSA.Properties.Resources.UpdateRestore;
            this.btnUpdate.Location = new System.Drawing.Point(803, 31);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 41);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.labelControl1.Location = new System.Drawing.Point(-1, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1183, 25);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Equipos de Checklist";
            // 
            // frmCheckListItemsHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 562);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gcItems);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmCheckListItemsHome";
            this.Text = "Checklist Home";
            ((System.ComponentModel.ISupportInitialize)(this.gcItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCheckList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gvItems;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private dsCheckList dsCheckList1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_corto;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_largo;
        private DevExpress.XtraGrid.Columns.GridColumn colmodelo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}