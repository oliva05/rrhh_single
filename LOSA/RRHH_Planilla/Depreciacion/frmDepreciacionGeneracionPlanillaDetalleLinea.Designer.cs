namespace LOSA.RRHH_Planilla.Depreciacion
{
    partial class frmDepreciacionGeneracionPlanillaDetalleLinea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepreciacionGeneracionPlanillaDetalleLinea));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsDepreciacion1 = new LOSA.RRHH_Planilla.Depreciacion.dsDepreciacion();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_d = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_vehiculo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpago_programado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpago_anual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmantenimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcosto_total_anual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpago_mensual_final = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeduccion_copmixal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_a_pagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_a_pagarLps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTasa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepreciacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::LOSA.Properties.Resources.impresora_24X24;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(1085, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 33);
            this.btnPrint.TabIndex = 139;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::LOSA.Properties.Resources.boton_mas24px2;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(1177, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 33);
            this.btnAgregar.TabIndex = 138;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Image = global::LOSA.Properties.Resources.Danieledesantis_Playstation_Flat_Playstation_cross_black_and_white_24;
            this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(1269, 12);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(86, 33);
            this.cmdCerrar.TabIndex = 137;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_planilla";
            this.gridControl1.DataSource = this.dsDepreciacion1;
            this.gridControl1.Location = new System.Drawing.Point(2, 71);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdDelete});
            this.gridControl1.Size = new System.Drawing.Size(1353, 480);
            this.gridControl1.TabIndex = 140;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.colid_d,
            this.colid_empleado,
            this.colcodigo,
            this.colnombre,
            this.colmonto_vehiculo,
            this.colpago_programado,
            this.colpago_anual,
            this.colmantenimiento,
            this.colpeaje,
            this.colcosto_total_anual,
            this.colpago_mensual_final,
            this.coldeduccion_copmixal,
            this.coltotal_a_pagar,
            this.coltotal_a_pagarLps,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colid_d
            // 
            this.colid_d.FieldName = "id_d";
            this.colid_d.Name = "colid_d";
            this.colid_d.OptionsColumn.ReadOnly = true;
            // 
            // colid_empleado
            // 
            this.colid_empleado.FieldName = "id_empleado";
            this.colid_empleado.Name = "colid_empleado";
            this.colid_empleado.OptionsColumn.ReadOnly = true;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.ReadOnly = true;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 51;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Empleado";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 138;
            // 
            // colmonto_vehiculo
            // 
            this.colmonto_vehiculo.Caption = "Monto Vehiculo";
            this.colmonto_vehiculo.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colmonto_vehiculo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmonto_vehiculo.FieldName = "monto_vehiculo";
            this.colmonto_vehiculo.Name = "colmonto_vehiculo";
            this.colmonto_vehiculo.OptionsColumn.ReadOnly = true;
            this.colmonto_vehiculo.Visible = true;
            this.colmonto_vehiculo.VisibleIndex = 2;
            this.colmonto_vehiculo.Width = 85;
            // 
            // colpago_programado
            // 
            this.colpago_programado.Caption = "Pago Programado";
            this.colpago_programado.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colpago_programado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpago_programado.FieldName = "pago_programado";
            this.colpago_programado.Name = "colpago_programado";
            this.colpago_programado.OptionsColumn.ReadOnly = true;
            this.colpago_programado.Visible = true;
            this.colpago_programado.VisibleIndex = 3;
            this.colpago_programado.Width = 94;
            // 
            // colpago_anual
            // 
            this.colpago_anual.Caption = "Valor Anual";
            this.colpago_anual.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colpago_anual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpago_anual.FieldName = "pago_anual";
            this.colpago_anual.Name = "colpago_anual";
            this.colpago_anual.OptionsColumn.ReadOnly = true;
            this.colpago_anual.Visible = true;
            this.colpago_anual.VisibleIndex = 4;
            this.colpago_anual.Width = 64;
            // 
            // colmantenimiento
            // 
            this.colmantenimiento.Caption = "Manto";
            this.colmantenimiento.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colmantenimiento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmantenimiento.FieldName = "mantenimiento";
            this.colmantenimiento.Name = "colmantenimiento";
            this.colmantenimiento.OptionsColumn.ReadOnly = true;
            this.colmantenimiento.Visible = true;
            this.colmantenimiento.VisibleIndex = 5;
            this.colmantenimiento.Width = 64;
            // 
            // colpeaje
            // 
            this.colpeaje.Caption = "Peaje";
            this.colpeaje.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colpeaje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeaje.FieldName = "peaje";
            this.colpeaje.Name = "colpeaje";
            this.colpeaje.OptionsColumn.ReadOnly = true;
            this.colpeaje.Visible = true;
            this.colpeaje.VisibleIndex = 6;
            this.colpeaje.Width = 51;
            // 
            // colcosto_total_anual
            // 
            this.colcosto_total_anual.Caption = "Costo Total Anual";
            this.colcosto_total_anual.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colcosto_total_anual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcosto_total_anual.FieldName = "costo_total_anual";
            this.colcosto_total_anual.Name = "colcosto_total_anual";
            this.colcosto_total_anual.OptionsColumn.ReadOnly = true;
            this.colcosto_total_anual.Visible = true;
            this.colcosto_total_anual.VisibleIndex = 7;
            this.colcosto_total_anual.Width = 98;
            // 
            // colpago_mensual_final
            // 
            this.colpago_mensual_final.Caption = "Pago Mensual";
            this.colpago_mensual_final.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colpago_mensual_final.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpago_mensual_final.FieldName = "pago_mensual_final";
            this.colpago_mensual_final.Name = "colpago_mensual_final";
            this.colpago_mensual_final.OptionsColumn.ReadOnly = true;
            this.colpago_mensual_final.Visible = true;
            this.colpago_mensual_final.VisibleIndex = 8;
            this.colpago_mensual_final.Width = 77;
            // 
            // coldeduccion_copmixal
            // 
            this.coldeduccion_copmixal.Caption = "Deduccion";
            this.coldeduccion_copmixal.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.coldeduccion_copmixal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldeduccion_copmixal.FieldName = "deduccion_copmixal";
            this.coldeduccion_copmixal.Name = "coldeduccion_copmixal";
            this.coldeduccion_copmixal.OptionsColumn.ReadOnly = true;
            this.coldeduccion_copmixal.Visible = true;
            this.coldeduccion_copmixal.VisibleIndex = 10;
            this.coldeduccion_copmixal.Width = 60;
            // 
            // coltotal_a_pagar
            // 
            this.coltotal_a_pagar.Caption = "Total a Pagar ($)";
            this.coltotal_a_pagar.DisplayFormat.FormatString = "$ {0:#,###,##0.00}";
            this.coltotal_a_pagar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal_a_pagar.FieldName = "total_a_pagar";
            this.coltotal_a_pagar.Name = "coltotal_a_pagar";
            this.coltotal_a_pagar.OptionsColumn.ReadOnly = true;
            this.coltotal_a_pagar.Visible = true;
            this.coltotal_a_pagar.VisibleIndex = 11;
            this.coltotal_a_pagar.Width = 96;
            // 
            // coltotal_a_pagarLps
            // 
            this.coltotal_a_pagarLps.Caption = "Total a Pagar (Lps.)";
            this.coltotal_a_pagarLps.DisplayFormat.FormatString = "{0:#,###,##0.00} Lps";
            this.coltotal_a_pagarLps.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal_a_pagarLps.FieldName = "total_a_pagarLps";
            this.coltotal_a_pagarLps.Name = "coltotal_a_pagarLps";
            this.coltotal_a_pagarLps.OptionsColumn.ReadOnly = true;
            this.coltotal_a_pagarLps.Visible = true;
            this.coltotal_a_pagarLps.VisibleIndex = 12;
            this.coltotal_a_pagarLps.Width = 103;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Eliminar";
            this.gridColumn1.ColumnEdit = this.cmdDelete;
            this.gridColumn1.FieldName = "eliminar";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 13;
            this.gridColumn1.Width = 54;
            // 
            // cmdDelete
            // 
            this.cmdDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdDelete_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tipo de Deduccion";
            this.gridColumn2.FieldName = "tipo_deduccion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 9;
            this.gridColumn2.Width = 96;
            // 
            // lblTasa
            // 
            this.lblTasa.AutoSize = true;
            this.lblTasa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasa.Location = new System.Drawing.Point(330, 53);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(45, 15);
            this.lblTasa.TabIndex = 150;
            this.lblTasa.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 149;
            this.label5.Text = "Tasa Cambio:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(63, 53);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(45, 15);
            this.lblMes.TabIndex = 148;
            this.lblMes.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 147;
            this.label6.Text = "Mes:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(63, 33);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(45, 15);
            this.lblAnio.TabIndex = 146;
            this.lblAnio.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 145;
            this.label4.Text = "Año:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(330, 33);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 144;
            this.lblEstado.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 143;
            this.label1.Text = "Planilla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 142;
            this.label2.Text = "Estado:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescripcion.Location = new System.Drawing.Point(62, 9);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 19);
            this.lblDescripcion.TabIndex = 141;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = global::LOSA.Properties.Resources.excel32px;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(993, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(86, 33);
            this.btnExport.TabIndex = 151;
            this.btnExport.Text = "Exportar";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmDepreciacionGeneracionPlanillaDetalleLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 553);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblTasa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmdCerrar);
            this.Name = "frmDepreciacionGeneracionPlanillaDetalleLinea";
            this.Text = "Depreciacion Generacion Planilla Detalle Linea";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepreciacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button cmdCerrar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdDelete;
        private System.Windows.Forms.Label lblTasa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescripcion;
        private dsDepreciacion dsDepreciacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_d;
        private DevExpress.XtraGrid.Columns.GridColumn colid_empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_vehiculo;
        private DevExpress.XtraGrid.Columns.GridColumn colpago_programado;
        private DevExpress.XtraGrid.Columns.GridColumn colpago_anual;
        private DevExpress.XtraGrid.Columns.GridColumn colmantenimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colpeaje;
        private DevExpress.XtraGrid.Columns.GridColumn colcosto_total_anual;
        private DevExpress.XtraGrid.Columns.GridColumn colpago_mensual_final;
        private DevExpress.XtraGrid.Columns.GridColumn coldeduccion_copmixal;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_a_pagar;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_a_pagarLps;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Button btnExport;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}