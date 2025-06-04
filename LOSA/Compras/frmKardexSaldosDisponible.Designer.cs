
namespace LOSA.Compras
{
    partial class frmKardexSaldosDisponible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKardexSaldosDisponible));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsCompras1 = new LOSA.Compras.dsCompras();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcapitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpartida_arancelaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia_saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmontoInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coludInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia_ud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposDetalle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposDetalleKardex = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmdRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.grdExoneracion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.listaexoneracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_resolucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtExoneracion = new System.Windows.Forms.TextBox();
            this.lblExoneracion = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDetalleKardex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdExoneracion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaexoneracionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "kardex";
            this.gridControl1.DataSource = this.dsCompras1;
            this.gridControl1.Location = new System.Drawing.Point(1, 56);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposDetalle,
            this.reposDetalleKardex});
            this.gridControl1.Size = new System.Drawing.Size(1371, 638);
            this.gridControl1.TabIndex = 0;
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
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcapitulo,
            this.colpartida_arancelaria,
            this.colexistencia_saldo,
            this.colmontoInicial,
            this.coludInicial,
            this.colexistencia_ud,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(0, 533, 259, 302);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colcapitulo
            // 
            this.colcapitulo.Caption = "Capitulo";
            this.colcapitulo.FieldName = "capitulo";
            this.colcapitulo.Name = "colcapitulo";
            this.colcapitulo.OptionsColumn.ReadOnly = true;
            this.colcapitulo.Visible = true;
            this.colcapitulo.VisibleIndex = 1;
            this.colcapitulo.Width = 263;
            // 
            // colpartida_arancelaria
            // 
            this.colpartida_arancelaria.Caption = "Partida Arancelaria";
            this.colpartida_arancelaria.FieldName = "partida_arancelaria";
            this.colpartida_arancelaria.Name = "colpartida_arancelaria";
            this.colpartida_arancelaria.OptionsColumn.ReadOnly = true;
            this.colpartida_arancelaria.Visible = true;
            this.colpartida_arancelaria.VisibleIndex = 2;
            this.colpartida_arancelaria.Width = 366;
            // 
            // colexistencia_saldo
            // 
            this.colexistencia_saldo.Caption = "Saldo Disponible";
            this.colexistencia_saldo.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colexistencia_saldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia_saldo.FieldName = "existencia_saldo";
            this.colexistencia_saldo.Name = "colexistencia_saldo";
            this.colexistencia_saldo.OptionsColumn.ReadOnly = true;
            this.colexistencia_saldo.Visible = true;
            this.colexistencia_saldo.VisibleIndex = 5;
            this.colexistencia_saldo.Width = 120;
            // 
            // colmontoInicial
            // 
            this.colmontoInicial.Caption = "Saldo Inicial";
            this.colmontoInicial.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colmontoInicial.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmontoInicial.FieldName = "montoInicial";
            this.colmontoInicial.Name = "colmontoInicial";
            this.colmontoInicial.Visible = true;
            this.colmontoInicial.VisibleIndex = 3;
            this.colmontoInicial.Width = 140;
            // 
            // coludInicial
            // 
            this.coludInicial.Caption = "Ud Inicial";
            this.coludInicial.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.coludInicial.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coludInicial.FieldName = "udInicial";
            this.coludInicial.Name = "coludInicial";
            this.coludInicial.Visible = true;
            this.coludInicial.VisibleIndex = 4;
            this.coludInicial.Width = 119;
            // 
            // colexistencia_ud
            // 
            this.colexistencia_ud.Caption = "Ud Disponibles";
            this.colexistencia_ud.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colexistencia_ud.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia_ud.FieldName = "existencia_ud";
            this.colexistencia_ud.Name = "colexistencia_ud";
            this.colexistencia_ud.OptionsColumn.ReadOnly = true;
            this.colexistencia_ud.Visible = true;
            this.colexistencia_ud.VisibleIndex = 6;
            this.colexistencia_ud.Width = 137;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Detalle Saldos";
            this.gridColumn1.ColumnEdit = this.reposDetalle;
            this.gridColumn1.FieldName = "reposDetalle";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 105;
            // 
            // reposDetalle
            // 
            this.reposDetalle.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.reposDetalle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposDetalle.Name = "reposDetalle";
            this.reposDetalle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposDetalle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposDetalle_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tipo";
            this.gridColumn2.FieldName = "tipo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 100;
            // 
            // reposDetalleKardex
            // 
            this.reposDetalleKardex.AutoHeight = false;
            editorButtonImageOptions2.Image = global::LOSA.Properties.Resources.movechart_16x16;
            this.reposDetalleKardex.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposDetalleKardex.Name = "reposDetalleKardex";
            this.reposDetalleKardex.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposDetalleKardex.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposDetalleKardex_ButtonClick);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.ImageOptions.Image")));
            this.cmdClose.Location = new System.Drawing.Point(1237, 12);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(116, 38);
            this.cmdClose.TabIndex = 53;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.ToolTip = "Cerrar";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRefresh.Appearance.Options.UseFont = true;
            this.cmdRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdRefresh.ImageOptions.SvgImage")));
            this.cmdRefresh.Location = new System.Drawing.Point(23, 12);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(116, 38);
            this.cmdRefresh.TabIndex = 54;
            this.cmdRefresh.Text = "Actualizar";
            this.cmdRefresh.ToolTip = "Actualizar";
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // grdExoneracion
            // 
            this.grdExoneracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grdExoneracion.Location = new System.Drawing.Point(736, 20);
            this.grdExoneracion.Name = "grdExoneracion";
            this.grdExoneracion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdExoneracion.Properties.Appearance.Options.UseFont = true;
            this.grdExoneracion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdExoneracion.Properties.DataSource = this.listaexoneracionBindingSource;
            this.grdExoneracion.Properties.DisplayMember = "num_resolucion";
            this.grdExoneracion.Properties.NullText = "";
            this.grdExoneracion.Properties.PopupView = this.gridView6;
            this.grdExoneracion.Properties.ValueMember = "id";
            this.grdExoneracion.Size = new System.Drawing.Size(189, 22);
            this.grdExoneracion.TabIndex = 102;
            // 
            // listaexoneracionBindingSource
            // 
            this.listaexoneracionBindingSource.DataMember = "lista_exoneracion";
            this.listaexoneracionBindingSource.DataSource = this.dsCompras1;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid3,
            this.colnum_resolucion});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // colid3
            // 
            this.colid3.FieldName = "id";
            this.colid3.Name = "colid3";
            // 
            // colnum_resolucion
            // 
            this.colnum_resolucion.Caption = "Num. Resolucion";
            this.colnum_resolucion.FieldName = "num_resolucion";
            this.colnum_resolucion.Name = "colnum_resolucion";
            this.colnum_resolucion.Visible = true;
            this.colnum_resolucion.VisibleIndex = 0;
            // 
            // txtExoneracion
            // 
            this.txtExoneracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExoneracion.BackColor = System.Drawing.Color.White;
            this.txtExoneracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExoneracion.Enabled = false;
            this.txtExoneracion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtExoneracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExoneracion.Location = new System.Drawing.Point(736, 24);
            this.txtExoneracion.Name = "txtExoneracion";
            this.txtExoneracion.Size = new System.Drawing.Size(189, 16);
            this.txtExoneracion.TabIndex = 101;
            this.txtExoneracion.Text = "E2023002421";
            this.txtExoneracion.Visible = false;
            // 
            // lblExoneracion
            // 
            this.lblExoneracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExoneracion.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblExoneracion.Appearance.Options.UseFont = true;
            this.lblExoneracion.Location = new System.Drawing.Point(566, 24);
            this.lblExoneracion.Name = "lblExoneracion";
            this.lblExoneracion.Size = new System.Drawing.Size(204, 16);
            this.lblExoneracion.TabIndex = 100;
            this.lblExoneracion.Text = "# Exoneracion______________";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = global::LOSA.Properties.Resources.excel_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(166, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(116, 38);
            this.simpleButton1.TabIndex = 103;
            this.simpleButton1.Text = "Exportar";
            this.simpleButton1.ToolTip = "Actualizar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmKardexSaldosDisponible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 696);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.grdExoneracion);
            this.Controls.Add(this.txtExoneracion);
            this.Controls.Add(this.lblExoneracion);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmKardexSaldosDisponible";
            this.Text = "KardexSaldosDisponible";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDetalleKardex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdExoneracion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaexoneracionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsCompras dsCompras1;
        private DevExpress.XtraGrid.Columns.GridColumn colcapitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colpartida_arancelaria;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia_saldo;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia_ud;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposDetalle;
        private DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraEditors.SimpleButton cmdRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.GridLookUpEdit grdExoneracion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colid3;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_resolucion;
        private System.Windows.Forms.TextBox txtExoneracion;
        private DevExpress.XtraEditors.LabelControl lblExoneracion;
        private System.Windows.Forms.BindingSource listaexoneracionBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposDetalleKardex;
        private DevExpress.XtraGrid.Columns.GridColumn colmontoInicial;
        private DevExpress.XtraGrid.Columns.GridColumn coludInicial;
    }
}