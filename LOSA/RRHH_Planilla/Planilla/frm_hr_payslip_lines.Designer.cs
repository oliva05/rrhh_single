namespace LOSA.RRHH_Planilla.Planilla
{
    partial class frm_hr_payslip_lines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_hr_payslip_lines));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsPlanillasTransaccion1 = new LOSA.RRHH_Planilla.Planilla.dsPlanillasTransaccion();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colslip_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalary_rule_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalary_rule_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemployee_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontract_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colamount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collinea_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colsalario_hora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblHasta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.cmdAgregarDeduccion = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.cmdAnterior = new System.Windows.Forms.Button();
            this.cmdVerMarcas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanillasTransaccion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "hr_payslip_lines";
            this.gridControl1.DataSource = this.dsPlanillasTransaccion1;
            this.gridControl1.Location = new System.Drawing.Point(1, 82);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdDelete});
            this.gridControl1.Size = new System.Drawing.Size(976, 513);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsPlanillasTransaccion1
            // 
            this.dsPlanillasTransaccion1.DataSetName = "dsPlanillasTransaccion";
            this.dsPlanillasTransaccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colslip_id,
            this.colsalary_rule_id,
            this.colsalary_rule_name,
            this.colemployee_id,
            this.colcontract_id,
            this.colrate,
            this.colamount,
            this.colquantity,
            this.colCredito,
            this.colDebito,
            this.colSaldo,
            this.colname,
            this.colcode,
            this.colnote,
            this.collinea_num,
            this.colDelete,
            this.colsalario_hora});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colslip_id
            // 
            this.colslip_id.FieldName = "slip_id";
            this.colslip_id.Name = "colslip_id";
            // 
            // colsalary_rule_id
            // 
            this.colsalary_rule_id.FieldName = "salary_rule_id";
            this.colsalary_rule_id.Name = "colsalary_rule_id";
            // 
            // colsalary_rule_name
            // 
            this.colsalary_rule_name.FieldName = "salary_rule_name";
            this.colsalary_rule_name.Name = "colsalary_rule_name";
            // 
            // colemployee_id
            // 
            this.colemployee_id.FieldName = "employee_id";
            this.colemployee_id.Name = "colemployee_id";
            // 
            // colcontract_id
            // 
            this.colcontract_id.FieldName = "contract_id";
            this.colcontract_id.Name = "colcontract_id";
            // 
            // colrate
            // 
            this.colrate.FieldName = "rate";
            this.colrate.Name = "colrate";
            // 
            // colamount
            // 
            this.colamount.FieldName = "amount";
            this.colamount.Name = "colamount";
            // 
            // colquantity
            // 
            this.colquantity.DisplayFormat.FormatString = "n0";
            this.colquantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colquantity.FieldName = "quantity";
            this.colquantity.Name = "colquantity";
            this.colquantity.Visible = true;
            this.colquantity.VisibleIndex = 3;
            this.colquantity.Width = 66;
            // 
            // colCredito
            // 
            this.colCredito.DisplayFormat.FormatString = "n2";
            this.colCredito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCredito.FieldName = "Credito";
            this.colCredito.Name = "colCredito";
            this.colCredito.Visible = true;
            this.colCredito.VisibleIndex = 5;
            this.colCredito.Width = 101;
            // 
            // colDebito
            // 
            this.colDebito.DisplayFormat.FormatString = "n2";
            this.colDebito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDebito.FieldName = "Debito";
            this.colDebito.Name = "colDebito";
            this.colDebito.OptionsColumn.ReadOnly = true;
            this.colDebito.Visible = true;
            this.colDebito.VisibleIndex = 6;
            this.colDebito.Width = 104;
            // 
            // colSaldo
            // 
            this.colSaldo.DisplayFormat.FormatString = "n2";
            this.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaldo.FieldName = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.OptionsColumn.ReadOnly = true;
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 7;
            this.colSaldo.Width = 101;
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.ReadOnly = true;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            this.colname.Width = 167;
            // 
            // colcode
            // 
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.OptionsColumn.ReadOnly = true;
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 1;
            this.colcode.Width = 69;
            // 
            // colnote
            // 
            this.colnote.FieldName = "note";
            this.colnote.Name = "colnote";
            this.colnote.Visible = true;
            this.colnote.VisibleIndex = 8;
            this.colnote.Width = 160;
            // 
            // collinea_num
            // 
            this.collinea_num.FieldName = "linea_num";
            this.collinea_num.Name = "collinea_num";
            this.collinea_num.OptionsColumn.ReadOnly = true;
            this.collinea_num.Visible = true;
            this.collinea_num.VisibleIndex = 0;
            this.collinea_num.Width = 46;
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Eliminar";
            this.colDelete.ColumnEdit = this.cmdDelete;
            this.colDelete.FieldName = "delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 9;
            this.colDelete.Width = 59;
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
            // colsalario_hora
            // 
            this.colsalario_hora.DisplayFormat.FormatString = "n4";
            this.colsalario_hora.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsalario_hora.FieldName = "salario_hora";
            this.colsalario_hora.Name = "colsalario_hora";
            this.colsalario_hora.OptionsColumn.ReadOnly = true;
            this.colsalario_hora.Visible = true;
            this.colsalario_hora.VisibleIndex = 4;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(54, 64);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(45, 15);
            this.lblHasta.TabIndex = 35;
            this.lblHasta.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(54, 44);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(45, 15);
            this.lblDesde.TabIndex = 33;
            this.lblDesde.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Desde:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(223, 44);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 31;
            this.lblEstado.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Planilla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Estado:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescripcion.Location = new System.Drawing.Point(53, 20);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 19);
            this.lblDescripcion.TabIndex = 28;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(223, 64);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(45, 15);
            this.lblCodigo.TabIndex = 37;
            this.lblCodigo.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(338, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 15);
            this.lblNombre.TabIndex = 39;
            this.lblNombre.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(285, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Nombre:";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Image = global::LOSA.Properties.Resources.Danieledesantis_Playstation_Flat_Playstation_cross_black_and_white_24;
            this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(879, 46);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(98, 33);
            this.cmdCerrar.TabIndex = 133;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdAgregarDeduccion
            // 
            this.cmdAgregarDeduccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAgregarDeduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAgregarDeduccion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregarDeduccion.Image = global::LOSA.Properties.Resources.boton_mas24px2;
            this.cmdAgregarDeduccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAgregarDeduccion.Location = new System.Drawing.Point(879, 6);
            this.cmdAgregarDeduccion.Name = "cmdAgregarDeduccion";
            this.cmdAgregarDeduccion.Size = new System.Drawing.Size(98, 33);
            this.cmdAgregarDeduccion.TabIndex = 135;
            this.cmdAgregarDeduccion.Text = "Agregar";
            this.cmdAgregarDeduccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAgregarDeduccion.UseVisualStyleBackColor = true;
            this.cmdAgregarDeduccion.Click += new System.EventHandler(this.cmdAgregarDeduccion_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::LOSA.Properties.Resources.impresora_24X24;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(775, 46);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 33);
            this.btnPrint.TabIndex = 136;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSiguiente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSiguiente.Image = global::LOSA.Properties.Resources.flecha_derecha24;
            this.cmdSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSiguiente.Location = new System.Drawing.Point(677, 46);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(92, 33);
            this.cmdSiguiente.TabIndex = 137;
            this.cmdSiguiente.Text = "Siguiente";
            this.cmdSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAnterior.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnterior.Image = global::LOSA.Properties.Resources.flecha_izquierda24;
            this.cmdAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAnterior.Location = new System.Drawing.Point(579, 46);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(92, 33);
            this.cmdAnterior.TabIndex = 138;
            this.cmdAnterior.Text = "Anterior";
            this.cmdAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAnterior.UseVisualStyleBackColor = true;
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // cmdVerMarcas
            // 
            this.cmdVerMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdVerMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVerMarcas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerMarcas.Image = global::LOSA.Properties.Resources.calendario24;
            this.cmdVerMarcas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdVerMarcas.Location = new System.Drawing.Point(775, 7);
            this.cmdVerMarcas.Name = "cmdVerMarcas";
            this.cmdVerMarcas.Size = new System.Drawing.Size(98, 33);
            this.cmdVerMarcas.TabIndex = 139;
            this.cmdVerMarcas.Text = "Ver Marcas";
            this.cmdVerMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdVerMarcas.UseVisualStyleBackColor = true;
            this.cmdVerMarcas.Visible = false;
            this.cmdVerMarcas.Click += new System.EventHandler(this.cmdVerMarcas_Click);
            // 
            // frm_hr_payslip_lines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 598);
            this.Controls.Add(this.cmdVerMarcas);
            this.Controls.Add(this.cmdAnterior);
            this.Controls.Add(this.cmdSiguiente);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cmdAgregarDeduccion);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.gridControl1);
            this.Name = "frm_hr_payslip_lines";
            this.Text = "Detalle de Nómina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_hr_payslip_lines_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanillasTransaccion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsPlanillasTransaccion dsPlanillasTransaccion1;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colslip_id;
        private DevExpress.XtraGrid.Columns.GridColumn colsalary_rule_id;
        private DevExpress.XtraGrid.Columns.GridColumn colsalary_rule_name;
        private DevExpress.XtraGrid.Columns.GridColumn colemployee_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcontract_id;
        private DevExpress.XtraGrid.Columns.GridColumn colrate;
        private DevExpress.XtraGrid.Columns.GridColumn colamount;
        private DevExpress.XtraGrid.Columns.GridColumn colquantity;
        private DevExpress.XtraGrid.Columns.GridColumn colCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colDebito;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn colnote;
        private DevExpress.XtraGrid.Columns.GridColumn collinea_num;
        private System.Windows.Forms.Button cmdCerrar;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdDelete;
        private System.Windows.Forms.Button cmdAgregarDeduccion;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button cmdSiguiente;
        private System.Windows.Forms.Button cmdAnterior;
        private DevExpress.XtraGrid.Columns.GridColumn colsalario_hora;
        private System.Windows.Forms.Button cmdVerMarcas;
    }
}