﻿namespace LOSA.RecepcionMP
{
    partial class frmGestionIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionIngresos));
            this.grd_ingreso = new DevExpress.XtraGrid.GridControl();
            this.dsRecepcionMPx1 = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.grdv_ingreso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltarimas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnver = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ingreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_ingreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnver)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_ingreso
            // 
            this.grd_ingreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_ingreso.DataMember = "IngresosMP";
            this.grd_ingreso.DataSource = this.dsRecepcionMPx1;
            this.grd_ingreso.Location = new System.Drawing.Point(2, 80);
            this.grd_ingreso.MainView = this.grdv_ingreso;
            this.grd_ingreso.Name = "grd_ingreso";
            this.grd_ingreso.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnver});
            this.grd_ingreso.Size = new System.Drawing.Size(619, 440);
            this.grd_ingreso.TabIndex = 1;
            this.grd_ingreso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_ingreso});
            // 
            // dsRecepcionMPx1
            // 
            this.dsRecepcionMPx1.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_ingreso
            // 
            this.grdv_ingreso.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_ingreso.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_ingreso.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_ingreso.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_ingreso.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_ingreso.Appearance.Row.Options.UseFont = true;
            this.grdv_ingreso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNingreso,
            this.colitemcode,
            this.colItemName,
            this.colid_proveedor,
            this.colCardName,
            this.coltarimas,
            this.colid});
            this.grdv_ingreso.GridControl = this.grd_ingreso;
            this.grdv_ingreso.Name = "grdv_ingreso";
            this.grdv_ingreso.OptionsView.ShowAutoFilterRow = true;
            this.grdv_ingreso.OptionsView.ShowGroupPanel = false;
            // 
            // colNingreso
            // 
            this.colNingreso.Caption = "Ingreso";
            this.colNingreso.FieldName = "Ningreso";
            this.colNingreso.Name = "colNingreso";
            this.colNingreso.OptionsColumn.AllowEdit = false;
            this.colNingreso.Visible = true;
            this.colNingreso.VisibleIndex = 0;
            this.colNingreso.Width = 71;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Codigo MP";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 1;
            this.colitemcode.Width = 97;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "MP";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 2;
            this.colItemName.Width = 119;
            // 
            // colid_proveedor
            // 
            this.colid_proveedor.Caption = "Codigo Prove.";
            this.colid_proveedor.FieldName = "id_proveedor";
            this.colid_proveedor.Name = "colid_proveedor";
            this.colid_proveedor.OptionsColumn.AllowEdit = false;
            this.colid_proveedor.Visible = true;
            this.colid_proveedor.VisibleIndex = 3;
            this.colid_proveedor.Width = 111;
            // 
            // colCardName
            // 
            this.colCardName.Caption = "Proveedor";
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            this.colCardName.OptionsColumn.AllowEdit = false;
            this.colCardName.Visible = true;
            this.colCardName.VisibleIndex = 4;
            this.colCardName.Width = 159;
            // 
            // coltarimas
            // 
            this.coltarimas.Caption = "Ver Detalle";
            this.coltarimas.ColumnEdit = this.btnver;
            this.coltarimas.Name = "coltarimas";
            this.coltarimas.Visible = true;
            this.coltarimas.VisibleIndex = 5;
            this.coltarimas.Width = 137;
            // 
            // btnver
            // 
            this.btnver.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.tap;
            this.btnver.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnver.Name = "btnver";
            this.btnver.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnver.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnver_ButtonClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(167, 29);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(272, 44);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "Gestión de Ingresos";
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(443, 13);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(178, 58);
            this.btnAtras.TabIndex = 32;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmGestionIngresos
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 521);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.grd_ingreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionIngresos";
            this.Text = "frmGestionIngresos";
            ((System.ComponentModel.ISupportInitialize)(this.grd_ingreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_ingreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_ingreso;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colNingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colid_proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn coltarimas;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnver;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private dsRecepcionMPx dsRecepcionMPx1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
    }
}