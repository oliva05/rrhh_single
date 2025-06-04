namespace LOSA.Trazabilidad
{
    partial class frmRutasTrazabilidad_ObservacionAdjuntos
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsMantoTrazabilidad1 = new LOSA.Trazabilidad.dsMantoTrazabilidad();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgrupo_losa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colguardado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfile_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposOpenFile = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposDeleteObs = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposCargar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtLotePT = new DevExpress.XtraEditors.TextEdit();
            this.txtMP = new DevExpress.XtraEditors.TextEdit();
            this.xtraOpenFileDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantoTrazabilidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposOpenFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDeleteObs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposCargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLotePT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "rutas_adjuntos";
            this.gridControl1.DataSource = this.dsMantoTrazabilidad1;
            this.gridControl1.Location = new System.Drawing.Point(2, 76);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposOpenFile,
            this.reposDeleteObs,
            this.reposCargar});
            this.gridControl1.Size = new System.Drawing.Size(1292, 424);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMantoTrazabilidad1
            // 
            this.dsMantoTrazabilidad1.DataSetName = "dsMantoTrazabilidad";
            this.dsMantoTrazabilidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.collote_pt,
            this.colid_mp,
            this.colobservacion,
            this.coldepartamento,
            this.colgrupo_losa,
            this.coluser_id,
            this.colusuario,
            this.colguardado,
            this.colfecha,
            this.colpath,
            this.colfile_name,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // collote_pt
            // 
            this.collote_pt.FieldName = "lote_pt";
            this.collote_pt.Name = "collote_pt";
            this.collote_pt.OptionsColumn.AllowEdit = false;
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.Name = "colid_mp";
            this.colid_mp.OptionsColumn.AllowEdit = false;
            // 
            // colobservacion
            // 
            this.colobservacion.Caption = "Observacion";
            this.colobservacion.FieldName = "observacion";
            this.colobservacion.Name = "colobservacion";
            this.colobservacion.Visible = true;
            this.colobservacion.VisibleIndex = 0;
            this.colobservacion.Width = 588;
            // 
            // coldepartamento
            // 
            this.coldepartamento.Caption = "Grupo ALOSY";
            this.coldepartamento.FieldName = "departamento";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.OptionsColumn.AllowEdit = false;
            this.coldepartamento.Visible = true;
            this.coldepartamento.VisibleIndex = 3;
            this.coldepartamento.Width = 122;
            // 
            // colgrupo_losa
            // 
            this.colgrupo_losa.FieldName = "grupo_losa";
            this.colgrupo_losa.Name = "colgrupo_losa";
            this.colgrupo_losa.OptionsColumn.AllowEdit = false;
            this.colgrupo_losa.Width = 138;
            // 
            // coluser_id
            // 
            this.coluser_id.FieldName = "user_id";
            this.coluser_id.Name = "coluser_id";
            this.coluser_id.OptionsColumn.AllowEdit = false;
            this.coluser_id.Width = 138;
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.AllowEdit = false;
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 2;
            this.colusuario.Width = 120;
            // 
            // colguardado
            // 
            this.colguardado.Caption = "Guardado";
            this.colguardado.FieldName = "guardado";
            this.colguardado.Name = "colguardado";
            this.colguardado.OptionsColumn.AllowEdit = false;
            this.colguardado.Visible = true;
            this.colguardado.VisibleIndex = 4;
            this.colguardado.Width = 86;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            this.colfecha.Width = 110;
            // 
            // colpath
            // 
            this.colpath.FieldName = "path";
            this.colpath.Name = "colpath";
            this.colpath.OptionsColumn.AllowEdit = false;
            this.colpath.Width = 138;
            // 
            // colfile_name
            // 
            this.colfile_name.FieldName = "file_name";
            this.colfile_name.Name = "colfile_name";
            this.colfile_name.OptionsColumn.AllowEdit = false;
            this.colfile_name.Width = 148;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Abrir";
            this.gridColumn1.ColumnEdit = this.reposOpenFile;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 87;
            // 
            // reposOpenFile
            // 
            this.reposOpenFile.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = global::LOSA.Properties.Resources.imageload;
            this.reposOpenFile.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposOpenFile.Name = "reposOpenFile";
            this.reposOpenFile.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposOpenFile.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposOpenFile_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Eliminar";
            this.gridColumn2.ColumnEdit = this.reposDeleteObs;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            this.gridColumn2.Width = 82;
            // 
            // reposDeleteObs
            // 
            this.reposDeleteObs.AutoHeight = false;
            editorButtonImageOptions2.Image = global::LOSA.Properties.Resources.remove_32x32;
            this.reposDeleteObs.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposDeleteObs.Name = "reposDeleteObs";
            this.reposDeleteObs.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposDeleteObs.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposDeleteObs_ButtonClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cargar";
            this.gridColumn3.ColumnEdit = this.reposCargar;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            this.gridColumn3.Width = 72;
            // 
            // reposCargar
            // 
            this.reposCargar.AutoHeight = false;
            editorButtonImageOptions3.SvgImage = global::LOSA.Properties.Resources.openfromweb;
            this.reposCargar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposCargar.Name = "reposCargar";
            this.reposCargar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposCargar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposCargar_ButtonClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = global::LOSA.Properties.Resources.close_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(1174, 21);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 36);
            this.simpleButton1.TabIndex = 127;
            this.simpleButton1.Text = "Cerrar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = global::LOSA.Properties.Resources.add_24x24;
            this.btnAdd.Location = new System.Drawing.Point(133, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 36);
            this.btnAdd.TabIndex = 128;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(400, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 17);
            this.labelControl1.TabIndex = 129;
            this.labelControl1.Text = "Lote PT";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(400, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 17);
            this.labelControl2.TabIndex = 130;
            this.labelControl2.Text = "Materia Prima";
            // 
            // txtLotePT
            // 
            this.txtLotePT.Enabled = false;
            this.txtLotePT.Location = new System.Drawing.Point(500, 18);
            this.txtLotePT.Name = "txtLotePT";
            this.txtLotePT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLotePT.Properties.Appearance.Options.UseFont = true;
            this.txtLotePT.Size = new System.Drawing.Size(142, 24);
            this.txtLotePT.TabIndex = 131;
            // 
            // txtMP
            // 
            this.txtMP.Enabled = false;
            this.txtMP.Location = new System.Drawing.Point(500, 50);
            this.txtMP.Name = "txtMP";
            this.txtMP.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMP.Properties.Appearance.Options.UseFont = true;
            this.txtMP.Size = new System.Drawing.Size(278, 24);
            this.txtMP.TabIndex = 132;
            // 
            // xtraOpenFileDialog
            // 
            this.xtraOpenFileDialog.FileName = "xtraOpenFileDialog1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = global::LOSA.Properties.Resources.save1;
            this.simpleButton2.Location = new System.Drawing.Point(12, 21);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(100, 36);
            this.simpleButton2.TabIndex = 133;
            this.simpleButton2.Text = "Guardar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmRutasTrazabilidad_ObservacionAdjuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 504);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.txtMP);
            this.Controls.Add(this.txtLotePT);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRutasTrazabilidad_ObservacionAdjuntos";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantoTrazabilidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposOpenFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDeleteObs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposCargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLotePT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMP.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private dsMantoTrazabilidad dsMantoTrazabilidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn collote_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colgrupo_losa;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_id;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colpath;
        private DevExpress.XtraGrid.Columns.GridColumn colfile_name;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposOpenFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposDeleteObs;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtLotePT;
        private DevExpress.XtraEditors.TextEdit txtMP;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposCargar;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn colguardado;
    }
}