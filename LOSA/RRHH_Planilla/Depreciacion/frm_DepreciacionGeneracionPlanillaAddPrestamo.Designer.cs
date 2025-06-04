namespace LOSA.RRHH_Planilla.Depreciacion
{
    partial class frm_DepreciacionGeneracionPlanillaAddPrestamo
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DepreciacionGeneracionPlanillaAddPrestamo));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdDetalle = new DevExpress.XtraGrid.GridControl();
            this.dsDepreciacion1 = new LOSA.RRHH_Planilla.Depreciacion.dsDepreciacion();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colrow_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_prestamo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldistancia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepreciacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDetalle
            // 
            this.grdDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetalle.DataMember = "lista_deprecicacion_d";
            this.grdDetalle.DataSource = this.dsDepreciacion1;
            this.grdDetalle.Location = new System.Drawing.Point(1, 41);
            this.grdDetalle.MainView = this.gridView3;
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEliminar});
            this.grdDetalle.Size = new System.Drawing.Size(935, 470);
            this.grdDetalle.TabIndex = 141;
            this.grdDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // dsDepreciacion1
            // 
            this.dsDepreciacion1.DataSetName = "dsDepreciacion";
            this.dsDepreciacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colrow_num,
            this.colid_prestamo,
            this.colnombre,
            this.colimporte_total,
            this.colfecha_inicio,
            this.coldistancia,
            this.colnum_pago,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn1});
            this.gridView3.GridControl = this.grdDetalle;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colrow_num
            // 
            this.colrow_num.Caption = "# Linea";
            this.colrow_num.DisplayFormat.FormatString = "{0:0.##} ";
            this.colrow_num.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colrow_num.FieldName = "row_num";
            this.colrow_num.Name = "colrow_num";
            this.colrow_num.OptionsColumn.ReadOnly = true;
            this.colrow_num.Visible = true;
            this.colrow_num.VisibleIndex = 0;
            this.colrow_num.Width = 64;
            // 
            // colid_prestamo
            // 
            this.colid_prestamo.FieldName = "id_prestamo";
            this.colid_prestamo.Name = "colid_prestamo";
            this.colid_prestamo.OptionsColumn.ReadOnly = true;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 227;
            // 
            // colimporte_total
            // 
            this.colimporte_total.Caption = "Total Prestamo";
            this.colimporte_total.DisplayFormat.FormatString = "$ {0:#,###,##0.00} ";
            this.colimporte_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colimporte_total.FieldName = "importe_total";
            this.colimporte_total.Name = "colimporte_total";
            this.colimporte_total.OptionsColumn.ReadOnly = true;
            this.colimporte_total.Visible = true;
            this.colimporte_total.VisibleIndex = 5;
            this.colimporte_total.Width = 126;
            // 
            // colfecha_inicio
            // 
            this.colfecha_inicio.Caption = "Fecha Inicio";
            this.colfecha_inicio.FieldName = "fecha_inicio";
            this.colfecha_inicio.Name = "colfecha_inicio";
            this.colfecha_inicio.OptionsColumn.ReadOnly = true;
            this.colfecha_inicio.Visible = true;
            this.colfecha_inicio.VisibleIndex = 3;
            this.colfecha_inicio.Width = 91;
            // 
            // coldistancia
            // 
            this.coldistancia.Caption = "Distancia";
            this.coldistancia.DisplayFormat.FormatString = "{0:#,###,##0.00} km";
            this.coldistancia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldistancia.FieldName = "distancia";
            this.coldistancia.Name = "coldistancia";
            this.coldistancia.OptionsColumn.ReadOnly = true;
            this.coldistancia.Visible = true;
            this.coldistancia.VisibleIndex = 4;
            this.coldistancia.Width = 101;
            // 
            // colnum_pago
            // 
            this.colnum_pago.Caption = "Num. de Pago";
            this.colnum_pago.FieldName = "num_pago";
            this.colnum_pago.Name = "colnum_pago";
            this.colnum_pago.OptionsColumn.ReadOnly = true;
            this.colnum_pago.Visible = true;
            this.colnum_pago.VisibleIndex = 2;
            this.colnum_pago.Width = 105;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Seleccionado";
            this.gridColumn4.FieldName = "seleccionado";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            this.gridColumn4.Width = 108;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Eliminar";
            this.gridColumn3.ColumnEdit = this.cmdEliminar;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 70;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Image = global::LOSA.Properties.Resources.Custom_Save_24;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(12, 2);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(86, 33);
            this.cmdGuardar.TabIndex = 142;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Image = global::LOSA.Properties.Resources.Danieledesantis_Playstation_Flat_Playstation_cross_black_and_white_24;
            this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(840, 2);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(86, 33);
            this.cmdCerrar.TabIndex = 143;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Reflejar Pago";
            this.gridColumn1.FieldName = "reflejar_pago";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 88;
            // 
            // frm_DepreciacionGeneracionPlanillaAddPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 513);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.grdDetalle);
            this.Name = "frm_DepreciacionGeneracionPlanillaAddPrestamo";
            this.Text = "Adicionar Prestamos a Planilla";
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepreciacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colrow_num;
        private DevExpress.XtraGrid.Columns.GridColumn colid_prestamo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte_total;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn coldistancia;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_pago;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEliminar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCerrar;
        private dsDepreciacion dsDepreciacion1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}