namespace LOSA.RRHH_Planilla.Depreciacion
{
    partial class frmDepreciacionPerfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepreciacionPerfiles));
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
            this.grdPerfiles = new DevExpress.XtraGrid.GridControl();
            this.dsDepreciacion1 = new LOSA.RRHH_Planilla.Depreciacion.dsDepreciacion();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmodelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_creacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpaga_peaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpago_mantenimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdVerPlanillasEmployees = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdOpcioensPlanilla = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.cmdNuevaP = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tggActivos = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.grdPerfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepreciacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerPlanillasEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdOpcioensPlanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggActivos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPerfiles
            // 
            this.grdPerfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPerfiles.DataMember = "perfiles";
            this.grdPerfiles.DataSource = this.dsDepreciacion1;
            this.grdPerfiles.Location = new System.Drawing.Point(0, 81);
            this.grdPerfiles.MainView = this.gridView1;
            this.grdPerfiles.Name = "grdPerfiles";
            this.grdPerfiles.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdVerPlanillasEmployees,
            this.cmdOpcioensPlanilla,
            this.cmdEditar});
            this.grdPerfiles.Size = new System.Drawing.Size(1364, 672);
            this.grdPerfiles.TabIndex = 146;
            this.grdPerfiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsDepreciacion1
            // 
            this.dsDepreciacion1.DataSetName = "dsDepreciacion";
            this.dsDepreciacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_empleado,
            this.colcode,
            this.colnombre,
            this.colmarca,
            this.colmodelo,
            this.colplaca,
            this.colfecha_creacion,
            this.colkm,
            this.colpaga_peaje,
            this.colpago_mantenimiento,
            this.gridColumn1});
            this.gridView1.GridControl = this.grdPerfiles;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colid_empleado
            // 
            this.colid_empleado.FieldName = "id_empleado";
            this.colid_empleado.Name = "colid_empleado";
            this.colid_empleado.OptionsColumn.AllowEdit = false;
            // 
            // colcode
            // 
            this.colcode.Caption = "Cod. Empleado";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.OptionsColumn.AllowEdit = false;
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 0;
            this.colcode.Width = 89;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre ";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 196;
            // 
            // colmarca
            // 
            this.colmarca.Caption = "Marca Vehiculo";
            this.colmarca.FieldName = "marca";
            this.colmarca.Name = "colmarca";
            this.colmarca.OptionsColumn.AllowEdit = false;
            this.colmarca.Visible = true;
            this.colmarca.VisibleIndex = 2;
            this.colmarca.Width = 148;
            // 
            // colmodelo
            // 
            this.colmodelo.Caption = "Modelo";
            this.colmodelo.FieldName = "modelo";
            this.colmodelo.Name = "colmodelo";
            this.colmodelo.OptionsColumn.AllowEdit = false;
            this.colmodelo.Visible = true;
            this.colmodelo.VisibleIndex = 3;
            this.colmodelo.Width = 148;
            // 
            // colplaca
            // 
            this.colplaca.Caption = "Placa";
            this.colplaca.FieldName = "placa";
            this.colplaca.Name = "colplaca";
            this.colplaca.OptionsColumn.AllowEdit = false;
            this.colplaca.Visible = true;
            this.colplaca.VisibleIndex = 4;
            this.colplaca.Width = 148;
            // 
            // colfecha_creacion
            // 
            this.colfecha_creacion.FieldName = "fecha_creacion";
            this.colfecha_creacion.Name = "colfecha_creacion";
            this.colfecha_creacion.OptionsColumn.AllowEdit = false;
            // 
            // colkm
            // 
            this.colkm.Caption = "Distancia Domicilio";
            this.colkm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colkm.FieldName = "km";
            this.colkm.Name = "colkm";
            this.colkm.OptionsColumn.AllowEdit = false;
            this.colkm.Visible = true;
            this.colkm.VisibleIndex = 5;
            this.colkm.Width = 148;
            // 
            // colpaga_peaje
            // 
            this.colpaga_peaje.Caption = "Peaje";
            this.colpaga_peaje.FieldName = "paga_peaje";
            this.colpaga_peaje.Name = "colpaga_peaje";
            this.colpaga_peaje.OptionsColumn.AllowEdit = false;
            this.colpaga_peaje.Visible = true;
            this.colpaga_peaje.VisibleIndex = 6;
            this.colpaga_peaje.Width = 148;
            // 
            // colpago_mantenimiento
            // 
            this.colpago_mantenimiento.Caption = "Mantanimiento";
            this.colpago_mantenimiento.FieldName = "pago_mantenimiento";
            this.colpago_mantenimiento.Name = "colpago_mantenimiento";
            this.colpago_mantenimiento.OptionsColumn.AllowEdit = false;
            this.colpago_mantenimiento.Visible = true;
            this.colpago_mantenimiento.VisibleIndex = 7;
            this.colpago_mantenimiento.Width = 148;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Editar";
            this.gridColumn1.ColumnEdit = this.cmdEditar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 166;
            // 
            // cmdEditar
            // 
            this.cmdEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdEditar_ButtonClick);
            // 
            // cmdVerPlanillasEmployees
            // 
            this.cmdVerPlanillasEmployees.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdVerPlanillasEmployees.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdVerPlanillasEmployees.Name = "cmdVerPlanillasEmployees";
            this.cmdVerPlanillasEmployees.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cmdOpcioensPlanilla
            // 
            this.cmdOpcioensPlanilla.AutoHeight = false;
            editorButtonImageOptions3.Image = global::LOSA.Properties.Resources.ver_mas16px;
            this.cmdOpcioensPlanilla.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdOpcioensPlanilla.Name = "cmdOpcioensPlanilla";
            this.cmdOpcioensPlanilla.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Image = global::LOSA.Properties.Resources.Danieledesantis_Playstation_Flat_Playstation_cross_black_and_white_24;
            this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(1268, 12);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(86, 33);
            this.cmdCerrar.TabIndex = 147;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdNuevaP
            // 
            this.cmdNuevaP.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdNuevaP.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmdNuevaP.Appearance.Options.UseBackColor = true;
            this.cmdNuevaP.Appearance.Options.UseFont = true;
            this.cmdNuevaP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdNuevaP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevaP.ImageOptions.Image")));
            this.cmdNuevaP.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdNuevaP.Location = new System.Drawing.Point(12, 11);
            this.cmdNuevaP.Name = "cmdNuevaP";
            this.cmdNuevaP.Size = new System.Drawing.Size(101, 33);
            this.cmdNuevaP.TabIndex = 148;
            this.cmdNuevaP.Text = "Nuevo Perfil";
            this.cmdNuevaP.Click += new System.EventHandler(this.cmdNuevaP_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 150;
            this.label1.Text = "Perfiles Activos:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tggActivos
            // 
            this.tggActivos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tggActivos.EditValue = true;
            this.tggActivos.Location = new System.Drawing.Point(639, 46);
            this.tggActivos.Name = "tggActivos";
            this.tggActivos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tggActivos.Properties.Appearance.Options.UseFont = true;
            this.tggActivos.Properties.OffText = "No";
            this.tggActivos.Properties.OnText = "Si";
            this.tggActivos.Size = new System.Drawing.Size(89, 20);
            this.tggActivos.TabIndex = 149;
            this.tggActivos.Toggled += new System.EventHandler(this.tggActivos_Toggled);
            // 
            // frmDepreciacionPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 756);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tggActivos);
            this.Controls.Add(this.cmdNuevaP);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.grdPerfiles);
            this.Name = "frmDepreciacionPerfiles";
            ((System.ComponentModel.ISupportInitialize)(this.grdPerfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepreciacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVerPlanillasEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdOpcioensPlanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggActivos.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdPerfiles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdVerPlanillasEmployees;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdOpcioensPlanilla;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditar;
        private System.Windows.Forms.Button cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdNuevaP;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ToggleSwitch tggActivos;
        private dsDepreciacion dsDepreciacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colmarca;
        private DevExpress.XtraGrid.Columns.GridColumn colmodelo;
        private DevExpress.XtraGrid.Columns.GridColumn colplaca;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_creacion;
        private DevExpress.XtraGrid.Columns.GridColumn colkm;
        private DevExpress.XtraGrid.Columns.GridColumn colpaga_peaje;
        private DevExpress.XtraGrid.Columns.GridColumn colpago_mantenimiento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}