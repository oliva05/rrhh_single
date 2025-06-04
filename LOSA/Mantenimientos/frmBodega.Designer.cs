namespace LOSA.Mantenimientos
{
    partial class frmBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBodega));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.gcBodegas = new DevExpress.XtraGrid.GridControl();
            this.bodegasDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimiento = new LOSA.Mantenimientos.dsMantenimiento();
            this.gvBodegas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDescripcion = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.coldescripcion_corta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.coleditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcBodegas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBodegas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAgregar.ImageOptions.Image = global::LOSA.Properties.Resources.plus;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.Location = new System.Drawing.Point(1144, 77);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 49);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(12, 77);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(103, 49);
            this.btnAtras.TabIndex = 20;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // gcBodegas
            // 
            this.gcBodegas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcBodegas.DataSource = this.bodegasDataTableBindingSource;
            this.gcBodegas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gcBodegas.Location = new System.Drawing.Point(0, 132);
            this.gcBodegas.MainView = this.gvBodegas;
            this.gcBodegas.Name = "gcBodegas";
            this.gcBodegas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditar,
            this.repositoryItemCheckEdit1,
            this.txtDescripcion});
            this.gcBodegas.Size = new System.Drawing.Size(1288, 486);
            this.gcBodegas.TabIndex = 23;
            this.gcBodegas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBodegas});
            // 
            // bodegasDataTableBindingSource
            // 
            this.bodegasDataTableBindingSource.DataMember = "BodegasDataTable";
            this.bodegasDataTableBindingSource.DataSource = this.dsMantenimiento;
            // 
            // dsMantenimiento
            // 
            this.dsMantenimiento.DataSetName = "LOSADataSet";
            this.dsMantenimiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvBodegas
            // 
            this.gvBodegas.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvBodegas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvBodegas.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvBodegas.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvBodegas.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvBodegas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvBodegas.Appearance.FocusedRow.Options.UseFont = true;
            this.gvBodegas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvBodegas.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvBodegas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvBodegas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvBodegas.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvBodegas.Appearance.Row.Options.UseFont = true;
            this.gvBodegas.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvBodegas.Appearance.SelectedRow.Options.UseFont = true;
            this.gvBodegas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvBodegas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvBodegas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colid,
            this.coldescripcion,
            this.coldescripcion_corta,
            this.colenable,
            this.coleditar});
            this.gvBodegas.GridControl = this.gcBodegas;
            this.gvBodegas.Name = "gvBodegas";
            this.gvBodegas.OptionsView.RowAutoHeight = true;
            this.gvBodegas.OptionsView.ShowAutoFilterRow = true;
            this.gvBodegas.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "Código Interno";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 126;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.ColumnEdit = this.txtDescripcion;
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.ReadOnly = true;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 2;
            this.coldescripcion.Width = 180;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Name = "txtDescripcion";
            // 
            // coldescripcion_corta
            // 
            this.coldescripcion_corta.Caption = "Descripción Corta";
            this.coldescripcion_corta.FieldName = "descripcion_corta";
            this.coldescripcion_corta.Name = "coldescripcion_corta";
            this.coldescripcion_corta.OptionsColumn.ReadOnly = true;
            this.coldescripcion_corta.Visible = true;
            this.coldescripcion_corta.VisibleIndex = 3;
            this.coldescripcion_corta.Width = 119;
            // 
            // colenable
            // 
            this.colenable.Caption = "Enable";
            this.colenable.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.AllowEdit = false;
            this.colenable.Visible = true;
            this.colenable.VisibleIndex = 4;
            this.colenable.Width = 46;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AllowGrayed = true;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // coleditar
            // 
            this.coleditar.Caption = "Editar";
            this.coleditar.ColumnEdit = this.btnEditar;
            this.coleditar.FieldName = "editar";
            this.coleditar.Name = "coleditar";
            this.coleditar.Visible = true;
            this.coleditar.VisibleIndex = 5;
            this.coleditar.Width = 44;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoHeight = false;
            editorButtonImageOptions3.Image = global::LOSA.Properties.Resources.edit;
            this.btnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(0, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1288, 30);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Mantenimiento de Bodega";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Codigo SAP";
            this.gridColumn1.FieldName = "whs_equivalente";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 98;
            // 
            // frmBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1288, 618);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gcBodegas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBodega";
            ((System.ComponentModel.ISupportInitialize)(this.gcBodegas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBodegas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraGrid.GridControl gcBodegas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBodegas;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_corta;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private System.Windows.Forms.BindingSource bodegasDataTableBindingSource;
  
        private dsMantenimiento dsMantenimiento;
        private DevExpress.XtraGrid.Columns.GridColumn coleditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}