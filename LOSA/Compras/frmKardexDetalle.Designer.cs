
namespace LOSA.Compras
{
    partial class frmKardexDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKardexDetalle));
            this.txtCapitulo = new System.Windows.Forms.TextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtPartidaArancelaria = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsCompras1 = new LOSA.Compras.dsCompras();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_orden_h = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWhsCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbase_ref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_linea_solicitud_d = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnite_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabDetalleOC = new DevExpress.XtraTab.XtraTabPage();
            this.TabDetalleKardex = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDocNum1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_operacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colud_entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colud_salida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtExistencia = new DevExpress.XtraEditors.TextEdit();
            this.txtCargaInicial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSaldoConsumido = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtGridResta = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TabDetalleOC.SuspendLayout();
            this.TabDetalleKardex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargaInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoConsumido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGridResta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCapitulo
            // 
            this.txtCapitulo.BackColor = System.Drawing.Color.White;
            this.txtCapitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCapitulo.Enabled = false;
            this.txtCapitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCapitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtCapitulo.Location = new System.Drawing.Point(206, 13);
            this.txtCapitulo.Name = "txtCapitulo";
            this.txtCapitulo.Size = new System.Drawing.Size(231, 16);
            this.txtCapitulo.TabIndex = 80;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(69, 13);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(141, 16);
            this.labelControl12.TabIndex = 79;
            this.labelControl12.Text = "Capitulo___________";
            // 
            // txtPartidaArancelaria
            // 
            this.txtPartidaArancelaria.BackColor = System.Drawing.Color.White;
            this.txtPartidaArancelaria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPartidaArancelaria.Enabled = false;
            this.txtPartidaArancelaria.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPartidaArancelaria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtPartidaArancelaria.Location = new System.Drawing.Point(206, 46);
            this.txtPartidaArancelaria.Name = "txtPartidaArancelaria";
            this.txtPartidaArancelaria.Size = new System.Drawing.Size(231, 16);
            this.txtPartidaArancelaria.TabIndex = 82;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(69, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(215, 16);
            this.labelControl1.TabIndex = 81;
            this.labelControl1.Text = "Partida Arancelaria___________";
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.ImageOptions.Image")));
            this.cmdClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdClose.Location = new System.Drawing.Point(1189, 12);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(47, 33);
            this.cmdClose.TabIndex = 83;
            this.cmdClose.ToolTip = "Cerrar Ventana";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "kardex_detalle";
            this.gridControl1.DataSource = this.dsCompras1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1262, 508);
            this.gridControl1.TabIndex = 84;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_orden_h,
            this.colDocNum,
            this.colItemCode,
            this.colDescription,
            this.colDocDate,
            this.colCurrency,
            this.colWhsCode,
            this.colbase_ref,
            this.colnum_linea_solicitud_d,
            this.colQuantity,
            this.colUnite_Price,
            this.coltotal,
            this.colestado});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_orden_h
            // 
            this.colid_orden_h.FieldName = "id_orden_h";
            this.colid_orden_h.Name = "colid_orden_h";
            this.colid_orden_h.OptionsColumn.ReadOnly = true;
            // 
            // colDocNum
            // 
            this.colDocNum.Caption = "# OC SAP";
            this.colDocNum.FieldName = "DocNum";
            this.colDocNum.Name = "colDocNum";
            this.colDocNum.OptionsColumn.ReadOnly = true;
            this.colDocNum.Visible = true;
            this.colDocNum.VisibleIndex = 0;
            this.colDocNum.Width = 70;
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.ReadOnly = true;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 2;
            this.colItemCode.Width = 105;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Descripcion";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.ReadOnly = true;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 169;
            // 
            // colDocDate
            // 
            this.colDocDate.Caption = "Fecha ";
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.OptionsColumn.ReadOnly = true;
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 4;
            this.colDocDate.Width = 101;
            // 
            // colCurrency
            // 
            this.colCurrency.Caption = "Moneda";
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.OptionsColumn.ReadOnly = true;
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 8;
            this.colCurrency.Width = 92;
            // 
            // colWhsCode
            // 
            this.colWhsCode.FieldName = "WhsCode";
            this.colWhsCode.Name = "colWhsCode";
            this.colWhsCode.OptionsColumn.ReadOnly = true;
            this.colWhsCode.Visible = true;
            this.colWhsCode.VisibleIndex = 5;
            this.colWhsCode.Width = 101;
            // 
            // colbase_ref
            // 
            this.colbase_ref.Caption = "Solicitud de Compra";
            this.colbase_ref.FieldName = "base_ref";
            this.colbase_ref.Name = "colbase_ref";
            this.colbase_ref.OptionsColumn.ReadOnly = true;
            this.colbase_ref.Visible = true;
            this.colbase_ref.VisibleIndex = 6;
            this.colbase_ref.Width = 116;
            // 
            // colnum_linea_solicitud_d
            // 
            this.colnum_linea_solicitud_d.FieldName = "num_linea_solicitud_d";
            this.colnum_linea_solicitud_d.Name = "colnum_linea_solicitud_d";
            this.colnum_linea_solicitud_d.OptionsColumn.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Canitdad";
            this.colQuantity.DisplayFormat.FormatString = "{0:#,###,##0.00} Ud";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.ReadOnly = true;
            this.colQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:#,###,##0.00} Ud")});
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 7;
            this.colQuantity.Width = 85;
            // 
            // colUnite_Price
            // 
            this.colUnite_Price.Caption = "Precio Unitario";
            this.colUnite_Price.DisplayFormat.FormatString = "{0:#,###,##0.00} Lps";
            this.colUnite_Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnite_Price.FieldName = "Unite_Price";
            this.colUnite_Price.Name = "colUnite_Price";
            this.colUnite_Price.OptionsColumn.ReadOnly = true;
            this.colUnite_Price.Visible = true;
            this.colUnite_Price.VisibleIndex = 9;
            this.colUnite_Price.Width = 153;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.DisplayFormat.FormatString = "{0:#,###,##0.00} Lps";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.ReadOnly = true;
            this.coltotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", "{0:#,###,##0.00} Lps")});
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 10;
            this.coltotal.Width = 111;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.ReadOnly = true;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 1;
            this.colestado.Width = 136;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(633, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(168, 16);
            this.labelControl2.TabIndex = 85;
            this.labelControl2.Text = "Carga Inicial___________";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(633, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(185, 16);
            this.labelControl3.TabIndex = 86;
            this.labelControl3.Text = "Saldo Disponible__________";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 94);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabDetalleOC;
            this.xtraTabControl1.Size = new System.Drawing.Size(1264, 538);
            this.xtraTabControl1.TabIndex = 89;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabDetalleOC,
            this.TabDetalleKardex});
            // 
            // TabDetalleOC
            // 
            this.TabDetalleOC.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.TabDetalleOC.Appearance.Header.Options.UseFont = true;
            this.TabDetalleOC.Appearance.HeaderActive.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabDetalleOC.Appearance.HeaderActive.Options.UseFont = true;
            this.TabDetalleOC.Controls.Add(this.gridControl1);
            this.TabDetalleOC.Name = "TabDetalleOC";
            this.TabDetalleOC.Size = new System.Drawing.Size(1262, 508);
            this.TabDetalleOC.Text = "Detalle de Ordenes de Compra";
            // 
            // TabDetalleKardex
            // 
            this.TabDetalleKardex.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.TabDetalleKardex.Appearance.Header.Options.UseFont = true;
            this.TabDetalleKardex.Appearance.HeaderActive.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabDetalleKardex.Appearance.HeaderActive.Options.UseFont = true;
            this.TabDetalleKardex.Controls.Add(this.gridControl2);
            this.TabDetalleKardex.Name = "TabDetalleKardex";
            this.TabDetalleKardex.Size = new System.Drawing.Size(1262, 571);
            this.TabDetalleKardex.Text = "Movimientos en Kardex";
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "move_kardex";
            this.gridControl2.DataSource = this.dsCompras1;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1262, 571);
            this.gridControl2.TabIndex = 86;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocNum1,
            this.colitemcode1,
            this.colDescription1,
            this.colDocDate1,
            this.colCurrency1,
            this.coloperacion,
            this.coltipo_operacion,
            this.colud_entrada,
            this.colud_salida,
            this.colentrada,
            this.colsalida});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            // 
            // colDocNum1
            // 
            this.colDocNum1.FieldName = "DocNum";
            this.colDocNum1.Name = "colDocNum1";
            this.colDocNum1.OptionsColumn.ReadOnly = true;
            this.colDocNum1.Visible = true;
            this.colDocNum1.VisibleIndex = 0;
            this.colDocNum1.Width = 70;
            // 
            // colitemcode1
            // 
            this.colitemcode1.Caption = "ItemCode";
            this.colitemcode1.FieldName = "itemcode";
            this.colitemcode1.Name = "colitemcode1";
            this.colitemcode1.OptionsColumn.ReadOnly = true;
            this.colitemcode1.Visible = true;
            this.colitemcode1.VisibleIndex = 1;
            this.colitemcode1.Width = 73;
            // 
            // colDescription1
            // 
            this.colDescription1.Caption = "Descripcion";
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.OptionsColumn.ReadOnly = true;
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 2;
            this.colDescription1.Width = 179;
            // 
            // colDocDate1
            // 
            this.colDocDate1.Caption = "Fecha Transaccion";
            this.colDocDate1.FieldName = "DocDate";
            this.colDocDate1.Name = "colDocDate1";
            this.colDocDate1.OptionsColumn.ReadOnly = true;
            this.colDocDate1.Visible = true;
            this.colDocDate1.VisibleIndex = 3;
            this.colDocDate1.Width = 124;
            // 
            // colCurrency1
            // 
            this.colCurrency1.Caption = "Moneda";
            this.colCurrency1.FieldName = "Currency";
            this.colCurrency1.Name = "colCurrency1";
            this.colCurrency1.OptionsColumn.ReadOnly = true;
            this.colCurrency1.Visible = true;
            this.colCurrency1.VisibleIndex = 4;
            this.colCurrency1.Width = 87;
            // 
            // coloperacion
            // 
            this.coloperacion.Caption = "Operacion";
            this.coloperacion.FieldName = "operacion";
            this.coloperacion.Name = "coloperacion";
            this.coloperacion.OptionsColumn.ReadOnly = true;
            this.coloperacion.Visible = true;
            this.coloperacion.VisibleIndex = 5;
            this.coloperacion.Width = 245;
            // 
            // coltipo_operacion
            // 
            this.coltipo_operacion.FieldName = "tipo_operacion";
            this.coltipo_operacion.Name = "coltipo_operacion";
            this.coltipo_operacion.OptionsColumn.ReadOnly = true;
            this.coltipo_operacion.Width = 96;
            // 
            // colud_entrada
            // 
            this.colud_entrada.Caption = "Ud Entrada";
            this.colud_entrada.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colud_entrada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colud_entrada.FieldName = "ud_entrada";
            this.colud_entrada.Name = "colud_entrada";
            this.colud_entrada.OptionsColumn.ReadOnly = true;
            this.colud_entrada.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ud_entrada", "{0:#,###,##0.00}")});
            this.colud_entrada.Visible = true;
            this.colud_entrada.VisibleIndex = 8;
            this.colud_entrada.Width = 108;
            // 
            // colud_salida
            // 
            this.colud_salida.Caption = "Ud Salida";
            this.colud_salida.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colud_salida.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colud_salida.FieldName = "ud_salida";
            this.colud_salida.Name = "colud_salida";
            this.colud_salida.OptionsColumn.ReadOnly = true;
            this.colud_salida.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ud_salida", "{0:#,###,##0.00}")});
            this.colud_salida.Visible = true;
            this.colud_salida.VisibleIndex = 9;
            this.colud_salida.Width = 108;
            // 
            // colentrada
            // 
            this.colentrada.Caption = "Entrada";
            this.colentrada.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colentrada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colentrada.FieldName = "entrada";
            this.colentrada.Name = "colentrada";
            this.colentrada.OptionsColumn.ReadOnly = true;
            this.colentrada.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "entrada", "{0:#,###,##0.00}")});
            this.colentrada.Visible = true;
            this.colentrada.VisibleIndex = 6;
            this.colentrada.Width = 135;
            // 
            // colsalida
            // 
            this.colsalida.Caption = "Salida";
            this.colsalida.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colsalida.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsalida.FieldName = "salida";
            this.colsalida.Name = "colsalida";
            this.colsalida.OptionsColumn.ReadOnly = true;
            this.colsalida.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "salida", "{0:#,###,##0.00}")});
            this.colsalida.Visible = true;
            this.colsalida.VisibleIndex = 7;
            this.colsalida.Width = 108;
            // 
            // txtExistencia
            // 
            this.txtExistencia.EditValue = "0";
            this.txtExistencia.Enabled = false;
            this.txtExistencia.Location = new System.Drawing.Point(746, 66);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtExistencia.Properties.Appearance.Options.UseFont = true;
            this.txtExistencia.Properties.Appearance.Options.UseTextOptions = true;
            this.txtExistencia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtExistencia.Properties.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.txtExistencia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtExistencia.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtExistencia.Properties.MaskSettings.Set("mask", "f3");
            this.txtExistencia.Properties.UseMaskAsDisplayFormat = true;
            this.txtExistencia.Size = new System.Drawing.Size(194, 22);
            this.txtExistencia.TabIndex = 90;
            // 
            // txtCargaInicial
            // 
            this.txtCargaInicial.EditValue = "0";
            this.txtCargaInicial.Enabled = false;
            this.txtCargaInicial.Location = new System.Drawing.Point(746, 10);
            this.txtCargaInicial.Name = "txtCargaInicial";
            this.txtCargaInicial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCargaInicial.Properties.Appearance.Options.UseFont = true;
            this.txtCargaInicial.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCargaInicial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCargaInicial.Properties.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.txtCargaInicial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCargaInicial.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCargaInicial.Properties.MaskSettings.Set("mask", "f3");
            this.txtCargaInicial.Properties.UseMaskAsDisplayFormat = true;
            this.txtCargaInicial.Size = new System.Drawing.Size(194, 22);
            this.txtCargaInicial.TabIndex = 91;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(633, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(189, 16);
            this.labelControl4.TabIndex = 92;
            this.labelControl4.Text = "Saldo Consumido__________";
            // 
            // txtSaldoConsumido
            // 
            this.txtSaldoConsumido.EditValue = "0";
            this.txtSaldoConsumido.Enabled = false;
            this.txtSaldoConsumido.Location = new System.Drawing.Point(746, 38);
            this.txtSaldoConsumido.Name = "txtSaldoConsumido";
            this.txtSaldoConsumido.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSaldoConsumido.Properties.Appearance.Options.UseFont = true;
            this.txtSaldoConsumido.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSaldoConsumido.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSaldoConsumido.Properties.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.txtSaldoConsumido.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSaldoConsumido.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSaldoConsumido.Properties.MaskSettings.Set("mask", "f3");
            this.txtSaldoConsumido.Properties.UseMaskAsDisplayFormat = true;
            this.txtSaldoConsumido.Size = new System.Drawing.Size(194, 22);
            this.txtSaldoConsumido.TabIndex = 93;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(625, 49);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(329, 16);
            this.labelControl5.TabIndex = 94;
            this.labelControl5.Text = "_________________________________________";
            // 
            // txtGridResta
            // 
            this.txtGridResta.EditValue = "0";
            this.txtGridResta.Enabled = false;
            this.txtGridResta.Location = new System.Drawing.Point(847, 638);
            this.txtGridResta.Name = "txtGridResta";
            this.txtGridResta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtGridResta.Properties.Appearance.Options.UseFont = true;
            this.txtGridResta.Properties.Appearance.Options.UseTextOptions = true;
            this.txtGridResta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtGridResta.Properties.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.txtGridResta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtGridResta.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtGridResta.Properties.MaskSettings.Set("mask", "f3");
            this.txtGridResta.Properties.UseMaskAsDisplayFormat = true;
            this.txtGridResta.Size = new System.Drawing.Size(194, 22);
            this.txtGridResta.TabIndex = 95;
            // 
            // frmKardexDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 794);
            this.Controls.Add(this.txtGridResta);
            this.Controls.Add(this.txtSaldoConsumido);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtCargaInicial);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.txtPartidaArancelaria);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCapitulo);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl5);
            this.Name = "frmKardexDetalle";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TabDetalleOC.ResumeLayout(false);
            this.TabDetalleKardex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargaInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoConsumido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGridResta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCapitulo;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.TextBox txtPartidaArancelaria;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsCompras dsCompras1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_orden_h;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colWhsCode;
        private DevExpress.XtraGrid.Columns.GridColumn colbase_ref;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_linea_solicitud_d;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnite_Price;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabDetalleOC;
        private DevExpress.XtraTab.XtraTabPage TabDetalleKardex;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNum1;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription1;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency1;
        private DevExpress.XtraGrid.Columns.GridColumn coloperacion;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_operacion;
        private DevExpress.XtraGrid.Columns.GridColumn colud_entrada;
        private DevExpress.XtraGrid.Columns.GridColumn colud_salida;
        private DevExpress.XtraGrid.Columns.GridColumn colentrada;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida;
        private DevExpress.XtraEditors.TextEdit txtExistencia;
        private DevExpress.XtraEditors.TextEdit txtCargaInicial;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSaldoConsumido;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtGridResta;
    }
}