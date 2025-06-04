namespace LOSA.Reportes
{
    partial class frmprint__tarimas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprint__tarimas));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dsReportes1 = new LOSA.Reportes.dsReportes();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnTodas = new DevExpress.XtraEditors.SimpleButton();
            this.btnprint_only1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnPrintIngreso = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.grdv_tarimas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_tarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_calidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Imprimir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_tarimas = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprint_only1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_tarimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_tarimas)).BeginInit();
            this.SuspendLayout();
            // 
            // dsReportes1
            // 
            this.dsReportes1.DataSetName = "dsReportes";
            this.dsReportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(1181, 36);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(180, 52);
            this.cmdHome.TabIndex = 8;
            this.cmdHome.Text = "Atras";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(10, 17);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1320, 50);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Impresion de Tarimas";
            // 
            // btnTodas
            // 
            this.btnTodas.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodas.Appearance.Options.UseFont = true;
            this.btnTodas.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnTodas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTodas.ImageOptions.Image")));
            this.btnTodas.Location = new System.Drawing.Point(30, 36);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(180, 52);
            this.btnTodas.TabIndex = 12;
            this.btnTodas.Text = "Imprimir todas\r\n   las tarimas";
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click);
            // 
            // btnprint_only1
            // 
            this.btnprint_only1.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnprint_only1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnprint_only1.Name = "btnprint_only1";
            this.btnprint_only1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnprint_only1.Click += new System.EventHandler(this.btnprint_only1_Click);
            // 
            // btnPrintIngreso
            // 
            this.btnPrintIngreso.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.btnPrintIngreso.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnPrintIngreso.Name = "btnPrintIngreso";
            this.btnPrintIngreso.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnPrintIngreso.Click += new System.EventHandler(this.btnPrintIngreso_Click);
            // 
            // grdv_tarimas
            // 
            this.grdv_tarimas.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.grdv_tarimas.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_tarimas.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.grdv_tarimas.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_tarimas.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.grdv_tarimas.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_tarimas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_tarimas.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_tarimas.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.grdv_tarimas.Appearance.Row.Options.UseFont = true;
            this.grdv_tarimas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colmaterial,
            this.colnumero_transaccion,
            this.colfecha_vencimiento,
            this.colcodigo_barra,
            this.colcantidad,
            this.colpresentacion,
            this.collote,
            this.colfecha_ingreso,
            this.colestado_tarima,
            this.colestado_calidad,
            this.Imprimir,
            this.gridColumn2});
            this.grdv_tarimas.DetailHeight = 284;
            this.grdv_tarimas.GridControl = this.grd_tarimas;
            this.grdv_tarimas.Name = "grdv_tarimas";
            this.grdv_tarimas.OptionsEditForm.PopupEditFormWidth = 686;
            this.grdv_tarimas.OptionsView.ShowAutoFilterRow = true;
            this.grdv_tarimas.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // colmaterial
            // 
            this.colmaterial.Caption = "Materia Prima";
            this.colmaterial.FieldName = "material";
            this.colmaterial.Name = "colmaterial";
            this.colmaterial.OptionsColumn.AllowEdit = false;
            this.colmaterial.Visible = true;
            this.colmaterial.VisibleIndex = 0;
            this.colmaterial.Width = 174;
            // 
            // colnumero_transaccion
            // 
            this.colnumero_transaccion.Caption = "# Ingreso";
            this.colnumero_transaccion.FieldName = "numero_transaccion";
            this.colnumero_transaccion.Name = "colnumero_transaccion";
            this.colnumero_transaccion.OptionsColumn.AllowEdit = false;
            this.colnumero_transaccion.Visible = true;
            this.colnumero_transaccion.VisibleIndex = 1;
            this.colnumero_transaccion.Width = 82;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "F. Vencimiento";
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.OptionsColumn.AllowEdit = false;
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 2;
            this.colfecha_vencimiento.Width = 102;
            // 
            // colcodigo_barra
            // 
            this.colcodigo_barra.Caption = "Cod. Barra";
            this.colcodigo_barra.FieldName = "codigo_barra";
            this.colcodigo_barra.Name = "colcodigo_barra";
            this.colcodigo_barra.OptionsColumn.AllowEdit = false;
            this.colcodigo_barra.Visible = true;
            this.colcodigo_barra.VisibleIndex = 3;
            this.colcodigo_barra.Width = 129;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowEdit = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 6;
            this.colcantidad.Width = 98;
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Presentacion";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.OptionsColumn.AllowEdit = false;
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 7;
            this.colpresentacion.Width = 98;
            // 
            // collote
            // 
            this.collote.Caption = "Lote MP";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 8;
            this.collote.Width = 128;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.Caption = "F. Ingreso";
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.OptionsColumn.AllowEdit = false;
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 9;
            this.colfecha_ingreso.Width = 98;
            // 
            // colestado_tarima
            // 
            this.colestado_tarima.Caption = "Estado Log";
            this.colestado_tarima.FieldName = "estado_tarima";
            this.colestado_tarima.Name = "colestado_tarima";
            this.colestado_tarima.OptionsColumn.AllowEdit = false;
            this.colestado_tarima.Visible = true;
            this.colestado_tarima.VisibleIndex = 4;
            this.colestado_tarima.Width = 98;
            // 
            // colestado_calidad
            // 
            this.colestado_calidad.Caption = "Estado Calidad";
            this.colestado_calidad.FieldName = "estado_calidad";
            this.colestado_calidad.Name = "colestado_calidad";
            this.colestado_calidad.OptionsColumn.AllowEdit = false;
            this.colestado_calidad.Visible = true;
            this.colestado_calidad.VisibleIndex = 5;
            this.colestado_calidad.Width = 98;
            // 
            // Imprimir
            // 
            this.Imprimir.Caption = "Imp. Tarima";
            this.Imprimir.ColumnEdit = this.btnprint_only1;
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Visible = true;
            this.Imprimir.VisibleIndex = 10;
            this.Imprimir.Width = 91;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Imp. Ingreso";
            this.gridColumn2.ColumnEdit = this.btnPrintIngreso;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 11;
            this.gridColumn2.Width = 126;
            // 
            // grd_tarimas
            // 
            this.grd_tarimas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_tarimas.DataMember = "tmprint";
            this.grd_tarimas.DataSource = this.dsReportes1;
            this.grd_tarimas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_tarimas.Location = new System.Drawing.Point(-1, 110);
            this.grd_tarimas.MainView = this.grdv_tarimas;
            this.grd_tarimas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_tarimas.Name = "grd_tarimas";
            this.grd_tarimas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnprint_only1,
            this.btnPrintIngreso});
            this.grd_tarimas.Size = new System.Drawing.Size(1355, 595);
            this.grd_tarimas.TabIndex = 0;
            this.grd_tarimas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_tarimas});
            // 
            // frmprint__tarimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 705);
            this.Controls.Add(this.btnTodas);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grd_tarimas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmprint__tarimas";
            this.Text = "frmprint__tarimas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprint_only1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_tarimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_tarimas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTodas;
        private dsReportes dsReportes1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnprint_only1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnPrintIngreso;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_tarimas;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colmaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.GridControl grd_tarimas;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_tarima;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_calidad;
        private DevExpress.XtraGrid.Columns.GridColumn Imprimir;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}