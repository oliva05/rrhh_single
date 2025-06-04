﻿
namespace LOSA.AlmacenesExterno
{
    partial class frmvertodasMPinbodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmvertodasMPinbodega));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.lblBodega = new DevExpress.XtraEditors.LabelControl();
            this.txtBodega = new DevExpress.XtraEditors.TextEdit();
            this.txtbodegaName = new DevExpress.XtraEditors.TextEdit();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsReporteAlmacenExterno = new LOSA.AlmacenesExterno.dsReporteAlmacenExterno();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coloc1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalkg2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coludtotal2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfvencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiastovencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiasalmacenado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmpNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigoMp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaproduccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposAjustarNegativos = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtBodega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbodegaName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteAlmacenExterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposAjustarNegativos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Appearance.Options.UseFont = true;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1208, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 55);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblBodega
            // 
            this.lblBodega.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodega.Appearance.Options.UseFont = true;
            this.lblBodega.Location = new System.Drawing.Point(12, 12);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(118, 20);
            this.lblBodega.TabIndex = 11;
            this.lblBodega.Text = "Bodega Asignada";
            // 
            // txtBodega
            // 
            this.txtBodega.Enabled = false;
            this.txtBodega.Location = new System.Drawing.Point(8, 38);
            this.txtBodega.Name = "txtBodega";
            this.txtBodega.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBodega.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtBodega.Properties.Appearance.Options.UseFont = true;
            this.txtBodega.Properties.Appearance.Options.UseForeColor = true;
            this.txtBodega.Size = new System.Drawing.Size(97, 22);
            this.txtBodega.TabIndex = 12;
            // 
            // txtbodegaName
            // 
            this.txtbodegaName.Enabled = false;
            this.txtbodegaName.Location = new System.Drawing.Point(109, 38);
            this.txtbodegaName.Name = "txtbodegaName";
            this.txtbodegaName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbodegaName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtbodegaName.Properties.Appearance.Options.UseFont = true;
            this.txtbodegaName.Properties.Appearance.Options.UseForeColor = true;
            this.txtbodegaName.Size = new System.Drawing.Size(229, 22);
            this.txtbodegaName.TabIndex = 13;
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "controlBodegaExterna";
            this.grd_data.DataSource = this.dsReporteAlmacenExterno;
            this.grd_data.Location = new System.Drawing.Point(5, 101);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposAjustarNegativos});
            this.grd_data.Size = new System.Drawing.Size(1336, 658);
            this.grd_data.TabIndex = 14;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsReporteAlmacenExterno
            // 
            this.dsReporteAlmacenExterno.DataSetName = "dsReporteAlmacenExterno";
            this.dsReporteAlmacenExterno.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdv_data.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_data.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdv_data.Appearance.Empty.Options.UseFont = true;
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coloc1,
            this.colfactura,
            this.colfingreso,
            this.collote,
            this.coltotalkg2,
            this.coludtotal2,
            this.colfvencimiento,
            this.coldiastovencimiento,
            this.coldiasalmacenado,
            this.colmpNombre,
            this.colcodigoMp,
            this.colproducCodigo,
            this.colfechaproduccion,
            this.colpresentacion,
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn3});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowFooter = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // coloc1
            // 
            this.coloc1.Caption = "OC";
            this.coloc1.FieldName = "oc";
            this.coloc1.Name = "coloc1";
            this.coloc1.OptionsColumn.ReadOnly = true;
            this.coloc1.Visible = true;
            this.coloc1.VisibleIndex = 1;
            this.coloc1.Width = 41;
            // 
            // colfactura
            // 
            this.colfactura.Caption = "Factura";
            this.colfactura.FieldName = "factura";
            this.colfactura.Name = "colfactura";
            this.colfactura.OptionsColumn.ReadOnly = true;
            this.colfactura.Visible = true;
            this.colfactura.VisibleIndex = 2;
            this.colfactura.Width = 56;
            // 
            // colfingreso
            // 
            this.colfingreso.Caption = "Fecha Ingreso Bodega";
            this.colfingreso.FieldName = "fingreso";
            this.colfingreso.Name = "colfingreso";
            this.colfingreso.OptionsColumn.ReadOnly = true;
            this.colfingreso.Visible = true;
            this.colfingreso.VisibleIndex = 0;
            this.colfingreso.Width = 99;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.ReadOnly = true;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 6;
            this.collote.Width = 195;
            // 
            // coltotalkg2
            // 
            this.coltotalkg2.Caption = "Kilogramos";
            this.coltotalkg2.DisplayFormat.FormatString = "{0:0.##.##} Kg.";
            this.coltotalkg2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotalkg2.FieldName = "totalkg";
            this.coltotalkg2.Name = "coltotalkg2";
            this.coltotalkg2.OptionsColumn.ReadOnly = true;
            this.coltotalkg2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "totalkg", "{0:0.##.##} Kg.")});
            this.coltotalkg2.Visible = true;
            this.coltotalkg2.VisibleIndex = 12;
            this.coltotalkg2.Width = 60;
            // 
            // coludtotal2
            // 
            this.coludtotal2.Caption = "Unidades";
            this.coludtotal2.DisplayFormat.FormatString = "{0:0.##.##} Ud.";
            this.coludtotal2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coludtotal2.FieldName = "udtotal";
            this.coludtotal2.Name = "coludtotal2";
            this.coludtotal2.OptionsColumn.ReadOnly = true;
            this.coludtotal2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "udtotal", "{0:0.##.##} Ud.")});
            this.coludtotal2.Visible = true;
            this.coludtotal2.VisibleIndex = 10;
            this.coludtotal2.Width = 62;
            // 
            // colfvencimiento
            // 
            this.colfvencimiento.Caption = "Fecha V.";
            this.colfvencimiento.FieldName = "fvencimiento";
            this.colfvencimiento.Name = "colfvencimiento";
            this.colfvencimiento.OptionsColumn.ReadOnly = true;
            this.colfvencimiento.Visible = true;
            this.colfvencimiento.VisibleIndex = 8;
            this.colfvencimiento.Width = 67;
            // 
            // coldiastovencimiento
            // 
            this.coldiastovencimiento.Caption = "Dias para vencer";
            this.coldiastovencimiento.FieldName = "diastovencimiento";
            this.coldiastovencimiento.Name = "coldiastovencimiento";
            this.coldiastovencimiento.OptionsColumn.ReadOnly = true;
            this.coldiastovencimiento.Visible = true;
            this.coldiastovencimiento.VisibleIndex = 9;
            this.coldiastovencimiento.Width = 91;
            // 
            // coldiasalmacenado
            // 
            this.coldiasalmacenado.Caption = "Dias en Almacen";
            this.coldiasalmacenado.FieldName = "diasalmacenado";
            this.coldiasalmacenado.Name = "coldiasalmacenado";
            this.coldiasalmacenado.OptionsColumn.ReadOnly = true;
            this.coldiasalmacenado.Visible = true;
            this.coldiasalmacenado.VisibleIndex = 13;
            this.coldiasalmacenado.Width = 96;
            // 
            // colmpNombre
            // 
            this.colmpNombre.Caption = "Nombre Materia Prima";
            this.colmpNombre.FieldName = "mpNombre";
            this.colmpNombre.Name = "colmpNombre";
            this.colmpNombre.OptionsColumn.ReadOnly = true;
            this.colmpNombre.Visible = true;
            this.colmpNombre.VisibleIndex = 4;
            this.colmpNombre.Width = 220;
            // 
            // colcodigoMp
            // 
            this.colcodigoMp.Caption = "Cod. SAP";
            this.colcodigoMp.FieldName = "codigoMp";
            this.colcodigoMp.Name = "colcodigoMp";
            this.colcodigoMp.OptionsColumn.ReadOnly = true;
            this.colcodigoMp.Visible = true;
            this.colcodigoMp.VisibleIndex = 3;
            this.colcodigoMp.Width = 55;
            // 
            // colproducCodigo
            // 
            this.colproducCodigo.Caption = "Cod. Produccion";
            this.colproducCodigo.FieldName = "producCodigo";
            this.colproducCodigo.Name = "colproducCodigo";
            this.colproducCodigo.OptionsColumn.ReadOnly = true;
            this.colproducCodigo.Width = 74;
            // 
            // colfechaproduccion
            // 
            this.colfechaproduccion.Caption = "Fecha E.";
            this.colfechaproduccion.FieldName = "fechaproduccion";
            this.colfechaproduccion.Name = "colfechaproduccion";
            this.colfechaproduccion.OptionsColumn.ReadOnly = true;
            this.colfechaproduccion.Visible = true;
            this.colfechaproduccion.VisibleIndex = 7;
            this.colfechaproduccion.Width = 72;
            // 
            // colpresentacion
            // 
            this.colpresentacion.Caption = "Presentacion";
            this.colpresentacion.FieldName = "presentacion";
            this.colpresentacion.Name = "colpresentacion";
            this.colpresentacion.OptionsColumn.ReadOnly = true;
            this.colpresentacion.Visible = true;
            this.colpresentacion.VisibleIndex = 11;
            this.colpresentacion.Width = 66;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Proveedor";
            this.gridColumn2.FieldName = "proveedor";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 138;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cod Proveedor";
            this.gridColumn1.FieldName = "cardcode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ajustar Negativos";
            this.gridColumn3.ColumnEdit = this.reposAjustarNegativos;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 14;
            // 
            // reposAjustarNegativos
            // 
            this.reposAjustarNegativos.AutoHeight = false;
            //editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.changedatasourcepivottable_16x16;
            this.reposAjustarNegativos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposAjustarNegativos.Name = "reposAjustarNegativos";
            this.reposAjustarNegativos.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposAjustarNegativos.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposAjustarNegativos_ButtonClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1076, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(117, 57);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmvertodasMPinbodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 758);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.lblBodega);
            this.Controls.Add(this.txtBodega);
            this.Controls.Add(this.txtbodegaName);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmvertodasMPinbodega";
            this.Text = "Reporte total de toda la bodega";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txtBodega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbodegaName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteAlmacenExterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposAjustarNegativos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.LabelControl lblBodega;
        private DevExpress.XtraEditors.TextEdit txtBodega;
        private DevExpress.XtraEditors.TextEdit txtbodegaName;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.Columns.GridColumn coloc1;
        private DevExpress.XtraGrid.Columns.GridColumn colfactura;
        private DevExpress.XtraGrid.Columns.GridColumn colfingreso;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalkg2;
        private DevExpress.XtraGrid.Columns.GridColumn coludtotal2;
        private DevExpress.XtraGrid.Columns.GridColumn colfvencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn coldiastovencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn coldiasalmacenado;
        private DevExpress.XtraGrid.Columns.GridColumn colmpNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigoMp;
        private DevExpress.XtraGrid.Columns.GridColumn colproducCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaproduccion;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private dsReporteAlmacenExterno dsReporteAlmacenExterno;
        private DevExpress.XtraGrid.Columns.GridColumn colpresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposAjustarNegativos;
    }
}