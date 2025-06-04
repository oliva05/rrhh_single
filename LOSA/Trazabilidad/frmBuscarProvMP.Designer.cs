﻿
namespace LOSA.Trazabilidad
{
    partial class frmBuscarProvMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarProvMP));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsMantoTrazabilidad1 = new LOSA.Trazabilidad.dsMantoTrazabilidad();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigodeProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombredeProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreForaneo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRTN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colauditoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colriesgo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.cmdExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantoTrazabilidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "proveedores_master";
            this.gridControl1.DataSource = this.dsMantoTrazabilidad1;
            this.gridControl1.Location = new System.Drawing.Point(2, 66);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(956, 468);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMantoTrazabilidad1
            // 
            this.dsMantoTrazabilidad1.DataSetName = "dsMantoTrazabilidad";
            this.dsMantoTrazabilidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigodeProveedor,
            this.colNombredeProveedor,
            this.colNombreForaneo,
            this.colRTN,
            this.colaprobacion,
            this.colauditoria,
            this.colriesgo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colCodigodeProveedor
            // 
            this.colCodigodeProveedor.FieldName = "Codigo de Proveedor";
            this.colCodigodeProveedor.Name = "colCodigodeProveedor";
            this.colCodigodeProveedor.OptionsColumn.AllowEdit = false;
            this.colCodigodeProveedor.Visible = true;
            this.colCodigodeProveedor.VisibleIndex = 0;
            this.colCodigodeProveedor.Width = 109;
            // 
            // colNombredeProveedor
            // 
            this.colNombredeProveedor.FieldName = "Nombre de Proveedor";
            this.colNombredeProveedor.Name = "colNombredeProveedor";
            this.colNombredeProveedor.OptionsColumn.AllowEdit = false;
            this.colNombredeProveedor.Visible = true;
            this.colNombredeProveedor.VisibleIndex = 1;
            this.colNombredeProveedor.Width = 180;
            // 
            // colNombreForaneo
            // 
            this.colNombreForaneo.FieldName = "Nombre Foraneo";
            this.colNombreForaneo.Name = "colNombreForaneo";
            this.colNombreForaneo.OptionsColumn.AllowEdit = false;
            this.colNombreForaneo.Visible = true;
            this.colNombreForaneo.VisibleIndex = 2;
            this.colNombreForaneo.Width = 140;
            // 
            // colRTN
            // 
            this.colRTN.FieldName = "RTN";
            this.colRTN.Name = "colRTN";
            this.colRTN.OptionsColumn.AllowEdit = false;
            this.colRTN.Visible = true;
            this.colRTN.VisibleIndex = 3;
            this.colRTN.Width = 131;
            // 
            // colaprobacion
            // 
            this.colaprobacion.Caption = "Aprobación";
            this.colaprobacion.FieldName = "aprobacion";
            this.colaprobacion.Name = "colaprobacion";
            this.colaprobacion.OptionsColumn.AllowEdit = false;
            this.colaprobacion.Visible = true;
            this.colaprobacion.VisibleIndex = 4;
            this.colaprobacion.Width = 121;
            // 
            // colauditoria
            // 
            this.colauditoria.Caption = "Auditoría";
            this.colauditoria.FieldName = "auditoria";
            this.colauditoria.Name = "colauditoria";
            this.colauditoria.OptionsColumn.AllowEdit = false;
            this.colauditoria.Visible = true;
            this.colauditoria.VisibleIndex = 5;
            this.colauditoria.Width = 121;
            // 
            // colriesgo
            // 
            this.colriesgo.Caption = "Riesgo";
            this.colriesgo.FieldName = "riesgo";
            this.colriesgo.Name = "colriesgo";
            this.colriesgo.OptionsColumn.AllowEdit = false;
            this.colriesgo.Visible = true;
            this.colriesgo.VisibleIndex = 6;
            this.colriesgo.Width = 136;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(315, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(155, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Elija un Proveedor";
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(831, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(127, 51);
            this.cmdHome.TabIndex = 11;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // cmdExcel
            // 
            this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExcel.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdExcel.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cmdExcel.Appearance.Options.UseBackColor = true;
            this.cmdExcel.Appearance.Options.UseFont = true;
            this.cmdExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdExcel.ImageOptions.Image")));
            this.cmdExcel.Location = new System.Drawing.Point(698, 12);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(127, 51);
            this.cmdExcel.TabIndex = 32;
            this.cmdExcel.Text = "Exportar";
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // frmBuscarProvMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 536);
            this.Controls.Add(this.cmdExcel);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmBuscarProvMP";
            this.Text = "Buscar Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantoTrazabilidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsMantoTrazabilidad dsMantoTrazabilidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigodeProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colNombredeProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreForaneo;
        private DevExpress.XtraGrid.Columns.GridColumn colRTN;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.SimpleButton cmdExcel;
        private DevExpress.XtraGrid.Columns.GridColumn colaprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn colauditoria;
        private DevExpress.XtraGrid.Columns.GridColumn colriesgo;
    }
}