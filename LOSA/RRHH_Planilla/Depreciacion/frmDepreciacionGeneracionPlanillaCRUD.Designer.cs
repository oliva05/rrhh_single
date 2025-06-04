namespace LOSA.RRHH_Planilla.Depreciacion
{
    partial class frmDepreciacionGeneracionPlanillaCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepreciacionGeneracionPlanillaCRUD));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.chkSeleccionarTodos = new DevExpress.XtraEditors.CheckEdit();
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
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.txtComentarios = new DevExpress.XtraEditors.MemoEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTasaDeCambio = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.gleEstado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDescripcionPaySlipRun = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdMes = new DevExpress.XtraEditors.GridLookUpEdit();
            this.mesesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmes_numero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmes = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionarTodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepreciacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaDeCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionPaySlipRun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // chkSeleccionarTodos
            // 
            this.chkSeleccionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSeleccionarTodos.EditValue = true;
            this.chkSeleccionarTodos.Location = new System.Drawing.Point(1017, 39);
            this.chkSeleccionarTodos.Name = "chkSeleccionarTodos";
            this.chkSeleccionarTodos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.chkSeleccionarTodos.Properties.Appearance.Options.UseFont = true;
            this.chkSeleccionarTodos.Properties.Caption = "Seleccionar Todos";
            this.chkSeleccionarTodos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSeleccionarTodos.Size = new System.Drawing.Size(163, 20);
            this.chkSeleccionarTodos.TabIndex = 141;
            this.chkSeleccionarTodos.CheckedChanged += new System.EventHandler(this.chkSeleccionarTodos_CheckedChanged);
            // 
            // grdDetalle
            // 
            this.grdDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetalle.DataMember = "lista_deprecicacion_d";
            this.grdDetalle.DataSource = this.dsDepreciacion1;
            this.grdDetalle.Location = new System.Drawing.Point(353, 59);
            this.grdDetalle.MainView = this.gridView3;
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEliminar});
            this.grdDetalle.Size = new System.Drawing.Size(834, 430);
            this.grdDetalle.TabIndex = 140;
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
            this.gridColumn5});
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
            this.colrow_num.Width = 57;
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
            this.colnombre.Width = 202;
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
            this.colimporte_total.Width = 112;
            // 
            // colfecha_inicio
            // 
            this.colfecha_inicio.Caption = "Fecha Inicio";
            this.colfecha_inicio.FieldName = "fecha_inicio";
            this.colfecha_inicio.Name = "colfecha_inicio";
            this.colfecha_inicio.OptionsColumn.ReadOnly = true;
            this.colfecha_inicio.Visible = true;
            this.colfecha_inicio.VisibleIndex = 3;
            this.colfecha_inicio.Width = 81;
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
            this.coldistancia.Width = 90;
            // 
            // colnum_pago
            // 
            this.colnum_pago.Caption = "Num. de Pago";
            this.colnum_pago.FieldName = "num_pago";
            this.colnum_pago.Name = "colnum_pago";
            this.colnum_pago.OptionsColumn.ReadOnly = true;
            this.colnum_pago.Visible = true;
            this.colnum_pago.VisibleIndex = 2;
            this.colnum_pago.Width = 93;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Seleccionado";
            this.gridColumn4.FieldName = "seleccionado";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            this.gridColumn4.Width = 77;
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
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Reflejar Pago";
            this.gridColumn5.FieldName = "reflejar_pago";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 97;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Image = global::LOSA.Properties.Resources.Custom_Save_24;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(1002, 0);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(86, 33);
            this.cmdGuardar.TabIndex = 138;
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
            this.cmdCerrar.Location = new System.Drawing.Point(1094, 0);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(86, 33);
            this.cmdCerrar.TabIndex = 139;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(96, 21);
            this.lblTitulo.TabIndex = 142;
            this.lblTitulo.Text = "Depreciacion";
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(101, 198);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtComentarios.Properties.Appearance.Options.UseFont = true;
            this.txtComentarios.Properties.MaxLength = 500;
            this.txtComentarios.Size = new System.Drawing.Size(246, 96);
            this.txtComentarios.TabIndex = 151;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(3, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 160;
            this.label8.Text = "Comentarios";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTasaDeCambio
            // 
            this.txtTasaDeCambio.EditValue = "0.00";
            this.txtTasaDeCambio.Location = new System.Drawing.Point(101, 166);
            this.txtTasaDeCambio.Name = "txtTasaDeCambio";
            this.txtTasaDeCambio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTasaDeCambio.Properties.Appearance.Options.UseFont = true;
            this.txtTasaDeCambio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTasaDeCambio.Size = new System.Drawing.Size(246, 22);
            this.txtTasaDeCambio.TabIndex = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(4, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 158;
            this.label5.Text = "Tasa de Cambio";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.EditValue = "0.00";
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Location = new System.Drawing.Point(101, 300);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMontoTotal.Properties.Appearance.Options.UseFont = true;
            this.txtMontoTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMontoTotal.Size = new System.Drawing.Size(246, 22);
            this.txtMontoTotal.TabIndex = 157;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Enabled = false;
            this.labelControl2.Location = new System.Drawing.Point(6, 303);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 15);
            this.labelControl2.TabIndex = 156;
            this.labelControl2.Text = "Monto Total";
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(101, 113);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtFecha.Properties.Appearance.Options.UseFont = true;
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Size = new System.Drawing.Size(246, 22);
            this.dtFecha.TabIndex = 144;
            // 
            // gleEstado
            // 
            this.gleEstado.Enabled = false;
            this.gleEstado.Location = new System.Drawing.Point(101, 86);
            this.gleEstado.Name = "gleEstado";
            this.gleEstado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gleEstado.Properties.Appearance.Options.UseFont = true;
            this.gleEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleEstado.Properties.DataSource = this.estadosBindingSource;
            this.gleEstado.Properties.DisplayMember = "descripcion";
            this.gleEstado.Properties.NullText = "";
            this.gleEstado.Properties.PopupView = this.gridView1;
            this.gleEstado.Properties.ValueMember = "id";
            this.gleEstado.Size = new System.Drawing.Size(246, 22);
            this.gleEstado.TabIndex = 153;
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "estados";
            this.estadosBindingSource.DataSource = this.dsDepreciacion1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Estado";
            this.gridColumn2.FieldName = "descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // txtDescripcionPaySlipRun
            // 
            this.txtDescripcionPaySlipRun.Location = new System.Drawing.Point(101, 60);
            this.txtDescripcionPaySlipRun.Name = "txtDescripcionPaySlipRun";
            this.txtDescripcionPaySlipRun.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcionPaySlipRun.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcionPaySlipRun.Size = new System.Drawing.Size(246, 22);
            this.txtDescripcionPaySlipRun.TabIndex = 143;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(8, 63);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(63, 15);
            this.labelControl13.TabIndex = 152;
            this.labelControl13.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 164;
            this.label3.Text = "Mes:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 163;
            this.label2.Text = "Fecha:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 89);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 15);
            this.labelControl1.TabIndex = 162;
            this.labelControl1.Text = "Estado";
            // 
            // grdMes
            // 
            this.grdMes.Location = new System.Drawing.Point(101, 139);
            this.grdMes.Name = "grdMes";
            this.grdMes.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grdMes.Properties.Appearance.Options.UseFont = true;
            this.grdMes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdMes.Properties.DataSource = this.mesesBindingSource;
            this.grdMes.Properties.DisplayMember = "mes";
            this.grdMes.Properties.NullText = "";
            this.grdMes.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdMes.Properties.ValueMember = "mes_numero";
            this.grdMes.Size = new System.Drawing.Size(246, 22);
            this.grdMes.TabIndex = 165;
            this.grdMes.EditValueChanged += new System.EventHandler(this.grdMes_EditValueChanged);
            // 
            // mesesBindingSource
            // 
            this.mesesBindingSource.DataMember = "meses";
            this.mesesBindingSource.DataSource = this.dsDepreciacion1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmes_numero,
            this.colmes});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colmes_numero
            // 
            this.colmes_numero.FieldName = "mes_numero";
            this.colmes_numero.Name = "colmes_numero";
            // 
            // colmes
            // 
            this.colmes.Caption = "Mes";
            this.colmes.FieldName = "mes";
            this.colmes.Name = "colmes";
            this.colmes.Visible = true;
            this.colmes.VisibleIndex = 0;
            // 
            // frmDepreciacionGeneracionPlanillaCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 490);
            this.Controls.Add(this.grdMes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTasaDeCambio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.gleEstado);
            this.Controls.Add(this.txtDescripcionPaySlipRun);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.chkSeleccionarTodos);
            this.Controls.Add(this.grdDetalle);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdCerrar);
            this.Name = "frmDepreciacionGeneracionPlanillaCRUD";
            this.Text = "Depreciacion";
            ((System.ComponentModel.ISupportInitialize)(this.chkSeleccionarTodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepreciacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaDeCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionPaySlipRun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chkSeleccionarTodos;
        private DevExpress.XtraGrid.GridControl grdDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEliminar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCerrar;
        private DevExpress.XtraEditors.LabelControl lblTitulo;
        private DevExpress.XtraEditors.MemoEdit txtComentarios;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtTasaDeCambio;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtMontoTotal;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.GridLookUpEdit gleEstado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.TextEdit txtDescripcionPaySlipRun;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsDepreciacion dsDepreciacion1;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colrow_num;
        private DevExpress.XtraGrid.Columns.GridColumn colid_prestamo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte_total;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn coldistancia;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_pago;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.GridLookUpEdit grdMes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource mesesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colmes_numero;
        private DevExpress.XtraGrid.Columns.GridColumn colmes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}