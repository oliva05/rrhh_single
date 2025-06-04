
namespace LOSA.Finanzas
{
    partial class frmRptMaterialEmpaque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptMaterialEmpaque));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TabMateriaEmpaque = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabPageAMS = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnClose1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnActualiza = new DevExpress.XtraEditors.SimpleButton();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsMaterialEmpaque1 = new LOSA.Produccion.dsMaterialEmpaque();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_me = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWsBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colud_entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colud_salida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposDetalle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tabPageSAP = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnClose2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.TabMateriaEmpaque)).BeginInit();
            this.TabMateriaEmpaque.SuspendLayout();
            this.tabPageAMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterialEmpaque1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDetalle)).BeginInit();
            this.tabPageSAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(544, -2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(312, 25);
            this.labelControl1.TabIndex = 68;
            this.labelControl1.Text = "Inventario de Material de Empaque";
            // 
            // TabMateriaEmpaque
            // 
            this.TabMateriaEmpaque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabMateriaEmpaque.Controls.Add(this.tabPageAMS);
            this.TabMateriaEmpaque.Controls.Add(this.tabPageSAP);
            this.TabMateriaEmpaque.Location = new System.Drawing.Point(4, 29);
            this.TabMateriaEmpaque.Name = "TabMateriaEmpaque";
            this.TabMateriaEmpaque.PageProperties.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabMateriaEmpaque.PageProperties.AppearanceCaption.Options.UseFont = true;
            this.TabMateriaEmpaque.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabPageAMS,
            this.tabPageSAP});
            this.TabMateriaEmpaque.RegularSize = new System.Drawing.Size(1436, 790);
            this.TabMateriaEmpaque.SelectedPage = this.tabPageAMS;
            this.TabMateriaEmpaque.Size = new System.Drawing.Size(1436, 790);
            this.TabMateriaEmpaque.TabIndex = 69;
            this.TabMateriaEmpaque.Text = "tabPane1";
            // 
            // tabPageAMS
            // 
            this.tabPageAMS.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAMS.Appearance.Options.UseFont = true;
            this.tabPageAMS.Caption = "Kardex AMS";
            this.tabPageAMS.Controls.Add(this.btnClose1);
            this.tabPageAMS.Controls.Add(this.btnExport);
            this.tabPageAMS.Controls.Add(this.btnActualiza);
            this.tabPageAMS.Controls.Add(this.grd_data);
            this.tabPageAMS.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAMS.Name = "tabPageAMS";
            this.tabPageAMS.Properties.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAMS.Properties.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.tabPageAMS.Properties.AppearanceCaption.Options.UseFont = true;
            this.tabPageAMS.Size = new System.Drawing.Size(1436, 757);
            // 
            // btnClose1
            // 
            this.btnClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose1.Appearance.BackColor = System.Drawing.Color.Coral;
            this.btnClose1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose1.Appearance.Options.UseBackColor = true;
            this.btnClose1.Appearance.Options.UseFont = true;
            this.btnClose1.Appearance.Options.UseForeColor = true;
            this.btnClose1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnClose1.ImageOptions.Image = global::LOSA.Properties.Resources.close32px;
            this.btnClose1.Location = new System.Drawing.Point(1314, 15);
            this.btnClose1.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(101, 33);
            this.btnClose1.TabIndex = 68;
            this.btnClose1.Text = "Cerrar";
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // btnExport
            // 
            this.btnExport.Appearance.BackColor = System.Drawing.Color.OliveDrab;
            this.btnExport.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExport.Appearance.Options.UseBackColor = true;
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Appearance.Options.UseForeColor = true;
            this.btnExport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnExport.ImageOptions.Image = global::LOSA.Properties.Resources.Excel_2_icon32px1;
            this.btnExport.Location = new System.Drawing.Point(154, 15);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(105, 33);
            this.btnExport.TabIndex = 67;
            this.btnExport.Text = "Exportar";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnActualiza
            // 
            this.btnActualiza.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualiza.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiza.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnActualiza.Appearance.Options.UseBackColor = true;
            this.btnActualiza.Appearance.Options.UseFont = true;
            this.btnActualiza.Appearance.Options.UseForeColor = true;
            this.btnActualiza.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnActualiza.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnActualiza.ImageOptions.SvgImage")));
            this.btnActualiza.Location = new System.Drawing.Point(20, 15);
            this.btnActualiza.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualiza.Name = "btnActualiza";
            this.btnActualiza.Size = new System.Drawing.Size(106, 33);
            this.btnActualiza.TabIndex = 66;
            this.btnActualiza.Text = "Actualizar";
            this.btnActualiza.Click += new System.EventHandler(this.btnActualiza_Click);
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "kardex_me";
            this.grd_data.DataSource = this.dsMaterialEmpaque1;
            this.grd_data.Location = new System.Drawing.Point(3, 53);
            this.grd_data.MainView = this.gridView1;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposDetalle});
            this.grd_data.Size = new System.Drawing.Size(1430, 701);
            this.grd_data.TabIndex = 0;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMaterialEmpaque1
            // 
            this.dsMaterialEmpaque1.DataSetName = "dsMaterialEmpaque";
            this.dsMaterialEmpaque1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_me,
            this.colitemcode,
            this.colItemName,
            this.colWsBodega,
            this.collote,
            this.colud_entrada,
            this.colud_salida,
            this.colexistencia,
            this.gridColumn1});
            this.gridView1.GridControl = this.grd_data;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid_me
            // 
            this.colid_me.FieldName = "id_me";
            this.colid_me.Name = "colid_me";
            this.colid_me.OptionsColumn.AllowEdit = false;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "ItemCode";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            this.colitemcode.Width = 104;
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            this.colItemName.Width = 346;
            // 
            // colWsBodega
            // 
            this.colWsBodega.FieldName = "WsBodega";
            this.colWsBodega.Name = "colWsBodega";
            this.colWsBodega.OptionsColumn.AllowEdit = false;
            this.colWsBodega.Visible = true;
            this.colWsBodega.VisibleIndex = 2;
            this.colWsBodega.Width = 156;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 3;
            this.collote.Width = 156;
            // 
            // colud_entrada
            // 
            this.colud_entrada.Caption = "Ud Entrada";
            this.colud_entrada.DisplayFormat.FormatString = "n2";
            this.colud_entrada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colud_entrada.FieldName = "ud_entrada";
            this.colud_entrada.Name = "colud_entrada";
            this.colud_entrada.OptionsColumn.AllowEdit = false;
            this.colud_entrada.Visible = true;
            this.colud_entrada.VisibleIndex = 4;
            this.colud_entrada.Width = 188;
            // 
            // colud_salida
            // 
            this.colud_salida.Caption = "Ud Salida";
            this.colud_salida.DisplayFormat.FormatString = "n2";
            this.colud_salida.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colud_salida.FieldName = "ud_salida";
            this.colud_salida.Name = "colud_salida";
            this.colud_salida.OptionsColumn.AllowEdit = false;
            this.colud_salida.Visible = true;
            this.colud_salida.VisibleIndex = 5;
            this.colud_salida.Width = 165;
            // 
            // colexistencia
            // 
            this.colexistencia.Caption = "Existencia";
            this.colexistencia.DisplayFormat.FormatString = "n2";
            this.colexistencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colexistencia.FieldName = "existencia";
            this.colexistencia.Name = "colexistencia";
            this.colexistencia.OptionsColumn.AllowEdit = false;
            this.colexistencia.Visible = true;
            this.colexistencia.VisibleIndex = 6;
            this.colexistencia.Width = 136;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Detalle";
            this.gridColumn1.ColumnEdit = this.reposDetalle;
            this.gridColumn1.DisplayFormat.FormatString = "n2";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 154;
            // 
            // reposDetalle
            // 
            this.reposDetalle.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = global::LOSA.Properties.Resources.insertlistbox;
            this.reposDetalle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposDetalle.Name = "reposDetalle";
            this.reposDetalle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.reposDetalle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reposDetalle_ButtonClick);
            // 
            // tabPageSAP
            // 
            this.tabPageSAP.Caption = "Kardex Actual SAP";
            this.tabPageSAP.Controls.Add(this.btnClose2);
            this.tabPageSAP.Controls.Add(this.gridControl2);
            this.tabPageSAP.Name = "tabPageSAP";
            this.tabPageSAP.PageVisible = false;
            this.tabPageSAP.Size = new System.Drawing.Size(1436, 790);
            // 
            // btnClose2
            // 
            this.btnClose2.Appearance.BackColor = System.Drawing.Color.Coral;
            this.btnClose2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose2.Appearance.Options.UseBackColor = true;
            this.btnClose2.Appearance.Options.UseFont = true;
            this.btnClose2.Appearance.Options.UseForeColor = true;
            this.btnClose2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnClose2.ImageOptions.Image = global::LOSA.Properties.Resources.close32px;
            this.btnClose2.Location = new System.Drawing.Point(1318, 15);
            this.btnClose2.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(110, 33);
            this.btnClose2.TabIndex = 69;
            this.btnClose2.Text = "Cerrar";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Location = new System.Drawing.Point(3, 53);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1430, 734);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // frmRptMaterialEmpaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 823);
            this.Controls.Add(this.TabMateriaEmpaque);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmRptMaterialEmpaque";
            ((System.ComponentModel.ISupportInitialize)(this.TabMateriaEmpaque)).EndInit();
            this.TabMateriaEmpaque.ResumeLayout(false);
            this.tabPageAMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterialEmpaque1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDetalle)).EndInit();
            this.tabPageSAP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Navigation.TabPane TabMateriaEmpaque;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabPageAMS;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabPageSAP;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnActualiza;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraGrid.Columns.GridColumn colid_me;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colWsBodega;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colud_entrada;
        private DevExpress.XtraGrid.Columns.GridColumn colud_salida;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia;
        private DevExpress.XtraEditors.SimpleButton btnClose1;
        private DevExpress.XtraEditors.SimpleButton btnClose2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposDetalle;
        private Produccion.dsMaterialEmpaque dsMaterialEmpaque1;
    }
}