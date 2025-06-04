namespace LOSA.RRHH_Planilla.Depreciacion
{
    partial class frmDepreciacionConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepreciacionConfiguracion));
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
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCargarDatos = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsDepreciacion1 = new LOSA.RRHH_Planilla.Depreciacion.dsDepreciacion();
            this.gvBancos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmantenimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_pagos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEDetalle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.tggMostrarCanceladas = new DevExpress.XtraEditors.ToggleSwitch();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepreciacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggMostrarCanceladas.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnNew.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseBackColor = true;
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(1124, 29);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(110, 36);
            this.btnNew.TabIndex = 28;
            this.btnNew.Text = "Nuevo";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.cmdCargarDatos.Location = new System.Drawing.Point(1004, 29);
            this.cmdCargarDatos.Name = "cmdCargarDatos";
            this.cmdCargarDatos.Size = new System.Drawing.Size(110, 36);
            this.cmdCargarDatos.TabIndex = 27;
            this.cmdCargarDatos.Text = "Actualizar";
            this.cmdCargarDatos.Click += new System.EventHandler(this.cmdCargarDatos_Click);
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
            this.cmdCerrar.Location = new System.Drawing.Point(1240, 29);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(110, 36);
            this.cmdCerrar.TabIndex = 26;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "lista_prestamos";
            this.gridControl1.DataSource = this.dsDepreciacion1;
            this.gridControl1.Location = new System.Drawing.Point(0, 71);
            this.gridControl1.MainView = this.gvBancos;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEDetalle,
            this.btnDelete});
            this.gridControl1.Size = new System.Drawing.Size(1361, 705);
            this.gridControl1.TabIndex = 25;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBancos});
            // 
            // dsDepreciacion1
            // 
            this.dsDepreciacion1.DataSetName = "dsDepreciacion";
            this.dsDepreciacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvBancos
            // 
            this.gvBancos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_empleado,
            this.colnombre,
            this.colimporte_total,
            this.colfecha_inicio,
            this.colid_estado,
            this.colestado,
            this.colkm,
            this.colmantenimiento,
            this.colcant_pagos,
            this.gridColumn1,
            this.gridColumn2});
            this.gvBancos.GridControl = this.gridControl1;
            this.gvBancos.Name = "gvBancos";
            this.gvBancos.OptionsView.ShowAutoFilterRow = true;
            this.gvBancos.OptionsView.ShowGroupPanel = false;
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
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            // 
            // colimporte_total
            // 
            this.colimporte_total.Caption = "Importe Total";
            this.colimporte_total.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colimporte_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colimporte_total.FieldName = "importe_total";
            this.colimporte_total.Name = "colimporte_total";
            this.colimporte_total.OptionsColumn.AllowEdit = false;
            this.colimporte_total.Visible = true;
            this.colimporte_total.VisibleIndex = 2;
            // 
            // colfecha_inicio
            // 
            this.colfecha_inicio.Caption = "Fecha de Inicio";
            this.colfecha_inicio.FieldName = "fecha_inicio";
            this.colfecha_inicio.Name = "colfecha_inicio";
            this.colfecha_inicio.OptionsColumn.AllowEdit = false;
            this.colfecha_inicio.Visible = true;
            this.colfecha_inicio.VisibleIndex = 3;
            // 
            // colid_estado
            // 
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            this.colid_estado.OptionsColumn.AllowEdit = false;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 4;
            // 
            // colkm
            // 
            this.colkm.Caption = "Distancia";
            this.colkm.DisplayFormat.FormatString = "{0:#,###,##0.00} Km";
            this.colkm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colkm.FieldName = "km";
            this.colkm.Name = "colkm";
            this.colkm.OptionsColumn.AllowEdit = false;
            this.colkm.Visible = true;
            this.colkm.VisibleIndex = 5;
            // 
            // colmantenimiento
            // 
            this.colmantenimiento.Caption = "Mantenimiento";
            this.colmantenimiento.FieldName = "mantenimiento";
            this.colmantenimiento.Name = "colmantenimiento";
            this.colmantenimiento.OptionsColumn.AllowEdit = false;
            // 
            // colcant_pagos
            // 
            this.colcant_pagos.Caption = "Pagos Realizados";
            this.colcant_pagos.FieldName = "cant_pagos";
            this.colcant_pagos.Name = "colcant_pagos";
            this.colcant_pagos.OptionsColumn.AllowEdit = false;
            this.colcant_pagos.Visible = true;
            this.colcant_pagos.VisibleIndex = 6;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ver Detalle";
            this.gridColumn1.ColumnEdit = this.btnEDetalle;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // btnEDetalle
            // 
            this.btnEDetalle.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.contentarrangeinrows_16x16;
            this.btnEDetalle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEDetalle.Name = "btnEDetalle";
            this.btnEDetalle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEDetalle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEDetalle_ButtonClick);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            this.labelControl1.Location = new System.Drawing.Point(0, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1361, 25);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Contrato Vehicular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 146;
            this.label1.Text = "Mostrar Canceladas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tggMostrarCanceladas
            // 
            this.tggMostrarCanceladas.Location = new System.Drawing.Point(136, 45);
            this.tggMostrarCanceladas.Name = "tggMostrarCanceladas";
            this.tggMostrarCanceladas.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tggMostrarCanceladas.Properties.Appearance.Options.UseFont = true;
            this.tggMostrarCanceladas.Properties.OffText = "No";
            this.tggMostrarCanceladas.Properties.OnText = "Si";
            this.tggMostrarCanceladas.Size = new System.Drawing.Size(89, 20);
            this.tggMostrarCanceladas.TabIndex = 145;
            this.tggMostrarCanceladas.Toggled += new System.EventHandler(this.tggMostrarCanceladas_Toggled);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Moneda";
            this.gridColumn2.FieldName = "moneda";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // frmDepreciacionConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 777);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tggMostrarCanceladas);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.cmdCargarDatos);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmDepreciacionConfiguracion";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepreciacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggMostrarCanceladas.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton cmdCargarDatos;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBancos;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEDetalle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsDepreciacion dsDepreciacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte_total;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colkm;
        private DevExpress.XtraGrid.Columns.GridColumn colmantenimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_pagos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ToggleSwitch tggMostrarCanceladas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}