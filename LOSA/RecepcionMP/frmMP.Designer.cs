﻿namespace LOSA.RecepcionMP
{
    partial class frmMP
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMP));
            this.gcMP = new DevExpress.XtraGrid.GridControl();
            this.materiaPrimaBindingSource = new System.Windows.Forms.BindingSource();
            this.dsRecepcionMPx = new LOSA.RecepcionMP.dsRecepcionMPx();
            this.gvMP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcardcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcardname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemdescrip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.colid_mp = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaPrimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).BeginInit();
            this.SuspendLayout();
            // 
            // gcMP
            // 
            this.gcMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcMP.DataSource = this.materiaPrimaBindingSource;
            this.gcMP.Location = new System.Drawing.Point(0, 92);
            this.gcMP.MainView = this.gvMP;
            this.gcMP.Name = "gcMP";
            this.gcMP.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSeleccionar});
            this.gcMP.Size = new System.Drawing.Size(622, 431);
            this.gcMP.TabIndex = 0;
            this.gcMP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMP});
            // 
            // materiaPrimaBindingSource
            // 
            this.materiaPrimaBindingSource.DataMember = "Materia_Prima";
            this.materiaPrimaBindingSource.DataSource = this.dsRecepcionMPx;
            // 
            // dsRecepcionMPx
            // 
            this.dsRecepcionMPx.DataSetName = "dsRecepcionMPx";
            this.dsRecepcionMPx.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvMP
            // 
            this.gvMP.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen;
            this.gvMP.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvMP.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvMP.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightGreen;
            this.gvMP.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvMP.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvMP.Appearance.FocusedRow.Options.UseFont = true;
            this.gvMP.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gvMP.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvMP.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightGreen;
            this.gvMP.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvMP.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvMP.Appearance.Row.Options.UseFont = true;
            this.gvMP.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gvMP.Appearance.SelectedRow.Options.UseFont = true;
            this.gvMP.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvMP.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvMP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcardcode,
            this.colcardname,
            this.colSeleccionar,
            this.colitemcode,
            this.colitemdescrip,
            this.colid_mp});
            this.gvMP.GridControl = this.gcMP;
            this.gvMP.Name = "gvMP";
            this.gvMP.OptionsCustomization.AllowFilter = false;
            this.gvMP.OptionsFilter.AllowFilterEditor = false;
            this.gvMP.OptionsView.ShowAutoFilterRow = true;
            this.gvMP.OptionsView.ShowGroupPanel = false;
            this.gvMP.DoubleClick += new System.EventHandler(this.GvMP_DoubleClick);
            // 
            // colcardcode
            // 
            this.colcardcode.Caption = "Codigo SAP";
            this.colcardcode.FieldName = "carcode";
            this.colcardcode.Name = "colcardcode";
            this.colcardcode.Width = 68;
            // 
            // colcardname
            // 
            this.colcardname.Caption = "Proveedor";
            this.colcardname.FieldName = "cardname";
            this.colcardname.Name = "colcardname";
            this.colcardname.OptionsColumn.AllowEdit = false;
            this.colcardname.Width = 207;
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.Caption = "#";
            this.colSeleccionar.ColumnEdit = this.btnSeleccionar;
            this.colSeleccionar.MaxWidth = 60;
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.Visible = true;
            this.colSeleccionar.VisibleIndex = 2;
            this.colSeleccionar.Width = 60;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.tap;
            this.btnSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSeleccionar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSeleccionar_ButtonClick);
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "Cod. MP";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 0;
            this.colitemcode.Width = 89;
            // 
            // colitemdescrip
            // 
            this.colitemdescrip.Caption = "Materia Prima";
            this.colitemdescrip.FieldName = "itemdescrip";
            this.colitemdescrip.Name = "colitemdescrip";
            this.colitemdescrip.OptionsColumn.AllowEdit = false;
            this.colitemdescrip.Visible = true;
            this.colitemdescrip.VisibleIndex = 1;
            this.colitemdescrip.Width = 180;
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
            this.btnAtras.Location = new System.Drawing.Point(444, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(166, 56);
            this.btnAtras.TabIndex = 6;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // colid_mp
            // 
            this.colid_mp.FieldName = "id_mp";
            this.colid_mp.Name = "colid_mp";
            // 
            // frmMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 521);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gcMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMP";
            this.Text = "frmMP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gcMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaPrimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcionMPx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcMP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMP;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private System.Windows.Forms.BindingSource materiaPrimaBindingSource;
        private dsRecepcionMPx dsRecepcionMPx;
        private DevExpress.XtraGrid.Columns.GridColumn colcardcode;
        private DevExpress.XtraGrid.Columns.GridColumn colcardname;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSeleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colitemdescrip;
        private DevExpress.XtraGrid.Columns.GridColumn colid_mp;
    }
}