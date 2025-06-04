namespace LOSA.RRHH_Planilla.Capacitacion
{
    partial class frmCapacitacionAdjuntoCRUDPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapacitacionAdjuntoCRUDPreview));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcArchivos = new DevExpress.XtraGrid.GridControl();
            this.dsCapacitacion1 = new LOSA.RRHH_Planilla.Capacitacion.dsCapacitacion();
            this.gvArchivos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfile_name_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_expediente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcArchivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCapacitacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArchivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // gcArchivos
            // 
            this.gcArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcArchivos.DataMember = "capacitacion_adjuntos";
            this.gcArchivos.DataSource = this.dsCapacitacion1;
            this.gcArchivos.Location = new System.Drawing.Point(0, 72);
            this.gcArchivos.MainView = this.gvArchivos;
            this.gcArchivos.Name = "gcArchivos";
            this.gcArchivos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDelete});
            this.gcArchivos.Size = new System.Drawing.Size(673, 255);
            this.gcArchivos.TabIndex = 0;
            this.gcArchivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvArchivos});
            // 
            // dsCapacitacion1
            // 
            this.dsCapacitacion1.DataSetName = "dsCapacitacion";
            this.dsCapacitacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvArchivos
            // 
            this.gvArchivos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion,
            this.colpath,
            this.colfile_name_,
            this.coltipo_expediente,
            this.gridColumn1});
            this.gvArchivos.GridControl = this.gcArchivos;
            this.gvArchivos.Name = "gvArchivos";
            this.gvArchivos.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripción";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 232;
            // 
            // colpath
            // 
            this.colpath.FieldName = "path";
            this.colpath.Name = "colpath";
            this.colpath.Width = 87;
            // 
            // colfile_name_
            // 
            this.colfile_name_.Caption = "Documento";
            this.colfile_name_.FieldName = "file_name_original";
            this.colfile_name_.Name = "colfile_name_";
            this.colfile_name_.Visible = true;
            this.colfile_name_.VisibleIndex = 1;
            this.colfile_name_.Width = 204;
            // 
            // coltipo_expediente
            // 
            this.coltipo_expediente.Caption = "Tipo Adjunto";
            this.coltipo_expediente.FieldName = "tipo_adjunto";
            this.coltipo_expediente.Name = "coltipo_expediente";
            this.coltipo_expediente.OptionsColumn.ReadOnly = true;
            this.coltipo_expediente.Visible = true;
            this.coltipo_expediente.VisibleIndex = 2;
            this.coltipo_expediente.Width = 145;
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.btnDelete;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 67;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDelete.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDelete_ButtonPressed);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = global::LOSA.Properties.Resources.Custom_Save_24;
            this.btnSave.Location = new System.Drawing.Point(474, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 31);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = global::LOSA.Properties.Resources.Danieledesantis_Playstation_Flat_Playstation_cross_black_and_white_24;
            this.btnCancelar.Location = new System.Drawing.Point(568, 26);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 31);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCapacitacionAdjuntoCRUDPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 326);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gcArchivos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCapacitacionAdjuntoCRUDPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacitacion Adjuntos";
            this.Load += new System.EventHandler(this.frmExpedienteCRUDPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcArchivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCapacitacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArchivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcArchivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvArchivos;
        
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpath;
        private DevExpress.XtraGrid.Columns.GridColumn colfile_name_;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_expediente;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private dsCapacitacion dsCapacitacion1;
    }
}