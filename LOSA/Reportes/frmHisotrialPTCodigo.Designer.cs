﻿
namespace LOSA.Reportes
{
    partial class frmHisotrialPTCodigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHisotrialPTCodigo));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.grdKardexPtExistencia = new DevExpress.XtraGrid.GridControl();
            this.dsProductos1 = new LOSA.TransaccionesPT.dsProductos();
            this.grdVKardexPtExistencia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_pt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_retenida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_retenido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm_retenidas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_existencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso_existencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm_existencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdDespachos = new DevExpress.XtraGrid.GridControl();
            this.grdvDespachos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colunidades_salida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkg_salida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm_salida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_inventario_camaron = new DevExpress.XtraGrid.GridControl();
            this.grdv_inventario_camaron = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_produccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote_pt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEspecie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingreso_unidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldias_elaborado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplazo_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldisponible_kg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldisponible_unidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia_tm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalida_unidades_totales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSearchPTCamaron = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearchPTCamaron = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKardexPtExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVKardexPtExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDespachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDespachos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario_camaron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario_camaron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchPTCamaron.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.tabPane1);
            this.panelControl2.Location = new System.Drawing.Point(3, 53);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1468, 891);
            this.panelControl2.TabIndex = 9;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tabPane1.Location = new System.Drawing.Point(2, 2);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(1464, 887);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1464, 887);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Inventario de Producto Terminado";
            this.tabNavigationPage1.Controls.Add(this.panelControl3);
            this.tabNavigationPage1.Controls.Add(this.grdDespachos);
            this.tabNavigationPage1.Controls.Add(this.grd_inventario_camaron);
            this.tabNavigationPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1464, 860);
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Controls.Add(this.grdKardexPtExistencia);
            this.panelControl3.Location = new System.Drawing.Point(3, 7);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1455, 234);
            this.panelControl3.TabIndex = 25;
            // 
            // grdKardexPtExistencia
            // 
            this.grdKardexPtExistencia.DataMember = "kardex_pt_existencia";
            this.grdKardexPtExistencia.DataSource = this.dsProductos1;
            this.grdKardexPtExistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKardexPtExistencia.Location = new System.Drawing.Point(2, 2);
            this.grdKardexPtExistencia.MainView = this.grdVKardexPtExistencia;
            this.grdKardexPtExistencia.Name = "grdKardexPtExistencia";
            this.grdKardexPtExistencia.Size = new System.Drawing.Size(1451, 230);
            this.grdKardexPtExistencia.TabIndex = 22;
            this.grdKardexPtExistencia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVKardexPtExistencia});
            // 
            // dsProductos1
            // 
            this.dsProductos1.DataSetName = "dsProductos";
            this.dsProductos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdVKardexPtExistencia
            // 
            this.grdVKardexPtExistencia.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdVKardexPtExistencia.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdVKardexPtExistencia.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdVKardexPtExistencia.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdVKardexPtExistencia.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdVKardexPtExistencia.Appearance.Row.Options.UseFont = true;
            this.grdVKardexPtExistencia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_pt1,
            this.colcode_sap1,
            this.colProducto1,
            this.colseleccion,
            this.colcantidad_retenida,
            this.colpeso_retenido,
            this.coltm_retenidas,
            this.colcantidad_existencia,
            this.colpeso_existencia,
            this.coltm_existencia});
            this.grdVKardexPtExistencia.CustomizationFormBounds = new System.Drawing.Rectangle(-665, 188, 260, 272);
            this.grdVKardexPtExistencia.GridControl = this.grdKardexPtExistencia;
            this.grdVKardexPtExistencia.Name = "grdVKardexPtExistencia";
            this.grdVKardexPtExistencia.OptionsView.ShowGroupPanel = false;
            this.grdVKardexPtExistencia.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdVKardexPtExistencia_CellValueChanging);
            // 
            // colid_pt1
            // 
            this.colid_pt1.FieldName = "id_pt";
            this.colid_pt1.Name = "colid_pt1";
            // 
            // colcode_sap1
            // 
            this.colcode_sap1.Caption = "Codigo Sap";
            this.colcode_sap1.FieldName = "code_sap";
            this.colcode_sap1.Name = "colcode_sap1";
            this.colcode_sap1.OptionsColumn.AllowEdit = false;
            this.colcode_sap1.Visible = true;
            this.colcode_sap1.VisibleIndex = 1;
            this.colcode_sap1.Width = 238;
            // 
            // colProducto1
            // 
            this.colProducto1.Caption = "Nombre";
            this.colProducto1.FieldName = "Producto";
            this.colProducto1.Name = "colProducto1";
            this.colProducto1.OptionsColumn.AllowEdit = false;
            this.colProducto1.Visible = true;
            this.colProducto1.VisibleIndex = 2;
            this.colProducto1.Width = 238;
            // 
            // colseleccion
            // 
            this.colseleccion.Caption = "Seleccionar";
            this.colseleccion.FieldName = "seleccion";
            this.colseleccion.Name = "colseleccion";
            this.colseleccion.Visible = true;
            this.colseleccion.VisibleIndex = 0;
            this.colseleccion.Width = 92;
            // 
            // colcantidad_retenida
            // 
            this.colcantidad_retenida.Caption = "Unidadres Retenidas";
            this.colcantidad_retenida.FieldName = "cantidad_retenida";
            this.colcantidad_retenida.Name = "colcantidad_retenida";
            this.colcantidad_retenida.OptionsColumn.AllowEdit = false;
            this.colcantidad_retenida.Visible = true;
            this.colcantidad_retenida.VisibleIndex = 3;
            // 
            // colpeso_retenido
            // 
            this.colpeso_retenido.Caption = "Kg Retenidos";
            this.colpeso_retenido.FieldName = "peso_retenido";
            this.colpeso_retenido.Name = "colpeso_retenido";
            this.colpeso_retenido.OptionsColumn.AllowEdit = false;
            this.colpeso_retenido.Visible = true;
            this.colpeso_retenido.VisibleIndex = 4;
            // 
            // coltm_retenidas
            // 
            this.coltm_retenidas.Caption = "TM Retenidos";
            this.coltm_retenidas.FieldName = "tm_retenidas";
            this.coltm_retenidas.Name = "coltm_retenidas";
            this.coltm_retenidas.OptionsColumn.AllowEdit = false;
            this.coltm_retenidas.Visible = true;
            this.coltm_retenidas.VisibleIndex = 5;
            // 
            // colcantidad_existencia
            // 
            this.colcantidad_existencia.Caption = "Unidades Existentes";
            this.colcantidad_existencia.FieldName = "cantidad_existencia";
            this.colcantidad_existencia.Name = "colcantidad_existencia";
            this.colcantidad_existencia.OptionsColumn.AllowEdit = false;
            this.colcantidad_existencia.Visible = true;
            this.colcantidad_existencia.VisibleIndex = 6;
            // 
            // colpeso_existencia
            // 
            this.colpeso_existencia.Caption = "Kilogramos Existencia";
            this.colpeso_existencia.FieldName = "peso_existencia";
            this.colpeso_existencia.Name = "colpeso_existencia";
            this.colpeso_existencia.OptionsColumn.AllowEdit = false;
            this.colpeso_existencia.Visible = true;
            this.colpeso_existencia.VisibleIndex = 7;
            // 
            // coltm_existencia
            // 
            this.coltm_existencia.Caption = "TM Existencia";
            this.coltm_existencia.FieldName = "tm_existencia";
            this.coltm_existencia.Name = "coltm_existencia";
            this.coltm_existencia.OptionsColumn.AllowEdit = false;
            this.coltm_existencia.Visible = true;
            this.coltm_existencia.VisibleIndex = 8;
            // 
            // grdDespachos
            // 
            this.grdDespachos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDespachos.DataMember = "despachos_pt";
            this.grdDespachos.DataSource = this.dsProductos1;
            this.grdDespachos.Location = new System.Drawing.Point(5, 523);
            this.grdDespachos.MainView = this.grdvDespachos;
            this.grdDespachos.Name = "grdDespachos";
            this.grdDespachos.Size = new System.Drawing.Size(1451, 332);
            this.grdDespachos.TabIndex = 21;
            this.grdDespachos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvDespachos});
            // 
            // grdvDespachos
            // 
            this.grdvDespachos.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdvDespachos.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdvDespachos.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdvDespachos.Appearance.FocusedRow.Options.UseFont = true;
            this.grdvDespachos.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdvDespachos.Appearance.GroupRow.Options.UseFont = true;
            this.grdvDespachos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdvDespachos.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdvDespachos.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdvDespachos.Appearance.Row.Options.UseFont = true;
            this.grdvDespachos.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdvDespachos.Appearance.TopNewRow.Options.UseFont = true;
            this.grdvDespachos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colunidades_salida,
            this.colkg_salida,
            this.coltm_salida,
            this.collote,
            this.colproducto2,
            this.colfecha_factura,
            this.colOC,
            this.colfactura,
            this.colcode_sap2});
            this.grdvDespachos.GridControl = this.grdDespachos;
            this.grdvDespachos.Name = "grdvDespachos";
            this.grdvDespachos.OptionsView.ShowAutoFilterRow = true;
            this.grdvDespachos.OptionsView.ShowGroupPanel = false;
            this.grdvDespachos.OptionsView.ShowViewCaption = true;
            this.grdvDespachos.ViewCaption = "Despachos ALOSY/SAP";
            // 
            // colunidades_salida
            // 
            this.colunidades_salida.Caption = "Salida Unidades";
            this.colunidades_salida.FieldName = "unidades_salida";
            this.colunidades_salida.Name = "colunidades_salida";
            this.colunidades_salida.OptionsColumn.AllowEdit = false;
            this.colunidades_salida.Visible = true;
            this.colunidades_salida.VisibleIndex = 5;
            this.colunidades_salida.Width = 228;
            // 
            // colkg_salida
            // 
            this.colkg_salida.Caption = "Salida Kg";
            this.colkg_salida.FieldName = "kg_salida";
            this.colkg_salida.Name = "colkg_salida";
            this.colkg_salida.OptionsColumn.AllowEdit = false;
            this.colkg_salida.Visible = true;
            this.colkg_salida.VisibleIndex = 6;
            this.colkg_salida.Width = 146;
            // 
            // coltm_salida
            // 
            this.coltm_salida.Caption = "Salida TM";
            this.coltm_salida.FieldName = "tm_salida";
            this.coltm_salida.Name = "coltm_salida";
            this.coltm_salida.OptionsColumn.AllowEdit = false;
            this.coltm_salida.Visible = true;
            this.coltm_salida.VisibleIndex = 7;
            this.coltm_salida.Width = 165;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 1;
            this.collote.Width = 159;
            // 
            // colproducto2
            // 
            this.colproducto2.FieldName = "producto";
            this.colproducto2.Name = "colproducto2";
            this.colproducto2.OptionsColumn.AllowEdit = false;
            // 
            // colfecha_factura
            // 
            this.colfecha_factura.Caption = "Fecha Facturacion";
            this.colfecha_factura.FieldName = "fecha_factura";
            this.colfecha_factura.Name = "colfecha_factura";
            this.colfecha_factura.OptionsColumn.AllowEdit = false;
            this.colfecha_factura.Visible = true;
            this.colfecha_factura.VisibleIndex = 4;
            this.colfecha_factura.Width = 131;
            // 
            // colOC
            // 
            this.colOC.FieldName = "Orden de Venta";
            this.colOC.Name = "colOC";
            this.colOC.OptionsColumn.AllowEdit = false;
            this.colOC.Visible = true;
            this.colOC.VisibleIndex = 2;
            this.colOC.Width = 152;
            // 
            // colfactura
            // 
            this.colfactura.Caption = "Factura";
            this.colfactura.FieldName = "factura";
            this.colfactura.Name = "colfactura";
            this.colfactura.OptionsColumn.AllowEdit = false;
            this.colfactura.Visible = true;
            this.colfactura.VisibleIndex = 3;
            this.colfactura.Width = 158;
            // 
            // colcode_sap2
            // 
            this.colcode_sap2.Caption = "Codigo Sap";
            this.colcode_sap2.FieldName = "code_sap";
            this.colcode_sap2.Name = "colcode_sap2";
            this.colcode_sap2.OptionsColumn.AllowEdit = false;
            this.colcode_sap2.Visible = true;
            this.colcode_sap2.VisibleIndex = 0;
            this.colcode_sap2.Width = 155;
            // 
            // grd_inventario_camaron
            // 
            this.grd_inventario_camaron.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_inventario_camaron.DataMember = "historico_pt_kardex";
            this.grd_inventario_camaron.DataSource = this.dsProductos1;
            this.grd_inventario_camaron.Location = new System.Drawing.Point(5, 247);
            this.grd_inventario_camaron.MainView = this.grdv_inventario_camaron;
            this.grd_inventario_camaron.Name = "grd_inventario_camaron";
            this.grd_inventario_camaron.Size = new System.Drawing.Size(1451, 270);
            this.grd_inventario_camaron.TabIndex = 0;
            this.grd_inventario_camaron.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_inventario_camaron});
            // 
            // grdv_inventario_camaron
            // 
            this.grdv_inventario_camaron.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_inventario_camaron.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_inventario_camaron.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.Preview.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.Row.Options.UseFont = true;
            this.grdv_inventario_camaron.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdv_inventario_camaron.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_inventario_camaron.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_pt,
            this.colfecha_produccion,
            this.colcode_sap,
            this.colProducto,
            this.collote_pt,
            this.colpresentacion,
            this.colEspecie,
            this.colingreso_unidades,
            this.colfecha_vencimiento,
            this.coldias_elaborado,
            this.colplazo_vencimiento,
            this.coldisponible_kg,
            this.coldisponible_unidades,
            this.colexistencia_tm,
            this.colsalida_unidades_totales});
            this.grdv_inventario_camaron.GridControl = this.grd_inventario_camaron;
            this.grdv_inventario_camaron.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_kg", null, "(Kilogramos: SUMA={0:0.##.##} Kg)"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_unidades", null, "(Unidades en Existencia: SUMA={0:0.##.##} Ud)"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_tm", null, "(Toneladas: SUMA={0:0.##.##} TM)")});
            this.grdv_inventario_camaron.Name = "grdv_inventario_camaron";
            this.grdv_inventario_camaron.OptionsView.ShowAutoFilterRow = true;
            this.grdv_inventario_camaron.OptionsView.ShowFooter = true;
            this.grdv_inventario_camaron.OptionsView.ShowGroupPanel = false;
            // 
            // colid_pt
            // 
            this.colid_pt.FieldName = "id_pt";
            this.colid_pt.Name = "colid_pt";
            // 
            // colfecha_produccion
            // 
            this.colfecha_produccion.Caption = "Fecha Produccion";
            this.colfecha_produccion.FieldName = "fecha_produccion";
            this.colfecha_produccion.Name = "colfecha_produccion";
            this.colfecha_produccion.OptionsColumn.AllowEdit = false;
            this.colfecha_produccion.Visible = true;
            this.colfecha_produccion.VisibleIndex = 0;
            this.colfecha_produccion.Width = 127;
            // 
            // colcode_sap
            // 
            this.colcode_sap.Caption = "Codigo SAP";
            this.colcode_sap.FieldName = "code_sap";
            this.colcode_sap.Name = "colcode_sap";
            this.colcode_sap.OptionsColumn.AllowEdit = false;
            this.colcode_sap.Visible = true;
            this.colcode_sap.VisibleIndex = 1;
            this.colcode_sap.Width = 91;
            // 
            // colProducto
            // 
            this.colProducto.Caption = "Nombre Comercial";
            this.colProducto.FieldName = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.OptionsColumn.AllowEdit = false;
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 2;
            this.colProducto.Width = 133;
            // 
            // collote_pt
            // 
            this.collote_pt.Caption = "# Lote";
            this.collote_pt.FieldName = "lote_pt";
            this.collote_pt.Name = "collote_pt";
            this.collote_pt.OptionsColumn.AllowEdit = false;
            this.collote_pt.Visible = true;
            this.collote_pt.VisibleIndex = 3;
            this.collote_pt.Width = 58;
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Presentacion";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.OptionsColumn.AllowEdit = false;
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 4;
            this.colpresentacion.Width = 98;
            // 
            // colEspecie
            // 
            this.colEspecie.Caption = "Especie";
            this.colEspecie.FieldName = "Especie";
            this.colEspecie.Name = "colEspecie";
            this.colEspecie.OptionsColumn.AllowEdit = false;
            this.colEspecie.Width = 64;
            // 
            // colingreso_unidades
            // 
            this.colingreso_unidades.Caption = "Ingreso Unidades";
            this.colingreso_unidades.DisplayFormat.FormatString = "n0";
            this.colingreso_unidades.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colingreso_unidades.FieldName = "ingreso_unidades";
            this.colingreso_unidades.Name = "colingreso_unidades";
            this.colingreso_unidades.OptionsColumn.AllowEdit = false;
            this.colingreso_unidades.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ingreso_unidades", "SUMA={0:n0}")});
            this.colingreso_unidades.Visible = true;
            this.colingreso_unidades.VisibleIndex = 5;
            this.colingreso_unidades.Width = 126;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.Caption = "Vencimiento";
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.OptionsColumn.AllowEdit = false;
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 6;
            this.colfecha_vencimiento.Width = 95;
            // 
            // coldias_elaborado
            // 
            this.coldias_elaborado.Caption = "Dias Elaborado";
            this.coldias_elaborado.FieldName = "dias_elaborado";
            this.coldias_elaborado.Name = "coldias_elaborado";
            this.coldias_elaborado.OptionsColumn.AllowEdit = false;
            this.coldias_elaborado.Visible = true;
            this.coldias_elaborado.VisibleIndex = 7;
            this.coldias_elaborado.Width = 110;
            // 
            // colplazo_vencimiento
            // 
            this.colplazo_vencimiento.Caption = "Plazo para Vencimiento";
            this.colplazo_vencimiento.FieldName = "plazo_vencimiento";
            this.colplazo_vencimiento.Name = "colplazo_vencimiento";
            this.colplazo_vencimiento.OptionsColumn.AllowEdit = false;
            this.colplazo_vencimiento.Visible = true;
            this.colplazo_vencimiento.VisibleIndex = 8;
            this.colplazo_vencimiento.Width = 162;
            // 
            // coldisponible_kg
            // 
            this.coldisponible_kg.Caption = "Disponible kg";
            this.coldisponible_kg.DisplayFormat.FormatString = "n2";
            this.coldisponible_kg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldisponible_kg.FieldName = "disponible_kg";
            this.coldisponible_kg.Name = "coldisponible_kg";
            this.coldisponible_kg.OptionsColumn.AllowEdit = false;
            this.coldisponible_kg.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "disponible_kg", "SUMA={0:n2}")});
            this.coldisponible_kg.Visible = true;
            this.coldisponible_kg.VisibleIndex = 10;
            this.coldisponible_kg.Width = 102;
            // 
            // coldisponible_unidades
            // 
            this.coldisponible_unidades.Caption = "Disponible Unidades";
            this.coldisponible_unidades.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldisponible_unidades.FieldName = "disponible_unidades";
            this.coldisponible_unidades.Name = "coldisponible_unidades";
            this.coldisponible_unidades.OptionsColumn.AllowEdit = false;
            this.coldisponible_unidades.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "disponible_unidades", "SUMA={0:#.##}")});
            this.coldisponible_unidades.Visible = true;
            this.coldisponible_unidades.VisibleIndex = 11;
            this.coldisponible_unidades.Width = 143;
            // 
            // colexistencia_tm
            // 
            this.colexistencia_tm.Caption = "Total TM";
            this.colexistencia_tm.DisplayFormat.FormatString = "n2";
            this.colexistencia_tm.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia_tm.FieldName = "existencia_tm";
            this.colexistencia_tm.Name = "colexistencia_tm";
            this.colexistencia_tm.OptionsColumn.AllowEdit = false;
            this.colexistencia_tm.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "existencia_tm", "SUMA={0:n2}")});
            this.colexistencia_tm.Visible = true;
            this.colexistencia_tm.VisibleIndex = 12;
            this.colexistencia_tm.Width = 73;
            // 
            // colsalida_unidades_totales
            // 
            this.colsalida_unidades_totales.Caption = "Total Salida";
            this.colsalida_unidades_totales.DisplayFormat.FormatString = "n0";
            this.colsalida_unidades_totales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsalida_unidades_totales.FieldName = "salida_unidades_totales";
            this.colsalida_unidades_totales.Name = "colsalida_unidades_totales";
            this.colsalida_unidades_totales.OptionsColumn.AllowEdit = false;
            this.colsalida_unidades_totales.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "salida_unidades_totales", "SUMA={0:n0}")});
            this.colsalida_unidades_totales.Visible = true;
            this.colsalida_unidades_totales.VisibleIndex = 9;
            this.colsalida_unidades_totales.Width = 89;
            // 
            // btnSearchPTCamaron
            // 
            this.btnSearchPTCamaron.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPTCamaron.Appearance.Options.UseFont = true;
            this.btnSearchPTCamaron.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSearchPTCamaron.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchPTCamaron.ImageOptions.Image")));
            this.btnSearchPTCamaron.Location = new System.Drawing.Point(923, 8);
            this.btnSearchPTCamaron.Name = "btnSearchPTCamaron";
            this.btnSearchPTCamaron.Size = new System.Drawing.Size(78, 32);
            this.btnSearchPTCamaron.TabIndex = 20;
            this.btnSearchPTCamaron.Text = "Buscar";
            this.btnSearchPTCamaron.Visible = false;
            this.btnSearchPTCamaron.Click += new System.EventHandler(this.btnSearchPTCamaron_Click);
            // 
            // txtSearchPTCamaron
            // 
            this.txtSearchPTCamaron.Location = new System.Drawing.Point(651, 14);
            this.txtSearchPTCamaron.Name = "txtSearchPTCamaron";
            this.txtSearchPTCamaron.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPTCamaron.Properties.Appearance.Options.UseFont = true;
            this.txtSearchPTCamaron.Properties.ReadOnly = true;
            this.txtSearchPTCamaron.Size = new System.Drawing.Size(266, 22);
            this.txtSearchPTCamaron.TabIndex = 19;
            this.txtSearchPTCamaron.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(531, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(114, 15);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Producto Terminado";
            this.labelControl2.Visible = false;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Appearance.Options.UseFont = true;
            this.btnExportExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExportExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.ImageOptions.Image")));
            this.btnExportExcel.Location = new System.Drawing.Point(1227, 4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(104, 39);
            this.btnExportExcel.TabIndex = 10;
            this.btnExportExcel.Text = "Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(1351, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 39);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(214, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(105, 32);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "Generar";
            this.simpleButton1.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 17);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Fecha Final";
            this.labelControl1.Visible = false;
            // 
            // dtFinal
            // 
            this.dtFinal.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtFinal.CustomFormat = "";
            this.dtFinal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(88, 12);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(118, 25);
            this.dtFinal.TabIndex = 23;
            this.dtFinal.Value = new System.DateTime(2022, 11, 17, 0, 0, 0, 0);
            this.dtFinal.Visible = false;
            // 
            // frmHisotrialPTCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 947);
            this.Controls.Add(this.dtFinal);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnSearchPTCamaron);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.txtSearchPTCamaron);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnClose);
            this.Name = "frmHisotrialPTCodigo";
            this.Text = "frmHisotrialPTCodigo";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKardexPtExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVKardexPtExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDespachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvDespachos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_inventario_camaron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_inventario_camaron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchPTCamaron.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnExportExcel;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraGrid.GridControl grd_inventario_camaron;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_inventario_camaron;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSearchPTCamaron;
        private DevExpress.XtraEditors.TextEdit txtSearchPTCamaron;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private TransaccionesPT.dsProductos dsProductos1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_produccion;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn collote_pt;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEspecie;
        private DevExpress.XtraGrid.Columns.GridColumn colingreso_unidades;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn coldias_elaborado;
        private DevExpress.XtraGrid.Columns.GridColumn colplazo_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn coldisponible_kg;
        private DevExpress.XtraGrid.Columns.GridColumn coldisponible_unidades;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia_tm;
        private DevExpress.XtraGrid.Columns.GridColumn colsalida_unidades_totales;
        private DevExpress.XtraGrid.GridControl grdDespachos;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvDespachos;
        private DevExpress.XtraGrid.Columns.GridColumn colunidades_salida;
        private DevExpress.XtraGrid.Columns.GridColumn colkg_salida;
        private DevExpress.XtraGrid.Columns.GridColumn coltm_salida;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto2;
        private DevExpress.XtraGrid.Columns.GridColumn colOC;
        private DevExpress.XtraGrid.Columns.GridColumn colfactura;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap2;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_factura;
        private DevExpress.XtraGrid.GridControl grdKardexPtExistencia;
        private DevExpress.XtraGrid.Views.Grid.GridView grdVKardexPtExistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colid_pt1;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_sap1;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccion;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_retenida;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_retenido;
        private DevExpress.XtraGrid.Columns.GridColumn coltm_retenidas;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_existencia;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso_existencia;
        private DevExpress.XtraGrid.Columns.GridColumn coltm_existencia;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dtFinal;
    }
}