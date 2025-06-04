﻿namespace LOSA.Calidad.LoteConfConsumo
{
    partial class frmSearchMultItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchMultItems));
            this.gridControlDetalleMP = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcat_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtParametroBusqueda = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dsPlanillasCalculo1 = new LOSA.RRHH_Planilla.Planilla.dsPlanillasCalculo();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParametroBusqueda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanillasCalculo1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlDetalleMP
            // 
            this.gridControlDetalleMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlDetalleMP.DataMember = "search_employee";
            this.gridControlDetalleMP.DataSource = this.dsPlanillasCalculo1;
            this.gridControlDetalleMP.Location = new System.Drawing.Point(2, 101);
            this.gridControlDetalleMP.MainView = this.gridView1;
            this.gridControlDetalleMP.Name = "gridControlDetalleMP";
            this.gridControlDetalleMP.Size = new System.Drawing.Size(642, 309);
            this.gridControlDetalleMP.TabIndex = 15;
            this.gridControlDetalleMP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colName,
            this.colSeleccionado,
            this.colconcat_});
            this.gridView1.GridControl = this.gridControlDetalleMP;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.AllowEdit = false;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 78;
            // 
            // colName
            // 
            this.colName.Caption = "Item Name";
            this.colName.FieldName = "Name_";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 441;
            // 
            // colSeleccionado
            // 
            this.colSeleccionado.FieldName = "Seleccionado";
            this.colSeleccionado.Name = "colSeleccionado";
            this.colSeleccionado.Visible = true;
            this.colSeleccionado.VisibleIndex = 2;
            this.colSeleccionado.Width = 105;
            // 
            // colconcat_
            // 
            this.colconcat_.FieldName = "concat_";
            this.colconcat_.Name = "colconcat_";
            // 
            // cmdAplicar
            // 
            this.cmdAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAplicar.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAplicar.Appearance.Options.UseFont = true;
            this.cmdAplicar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAplicar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAplicar.ImageOptions.SvgImage")));
            this.cmdAplicar.Location = new System.Drawing.Point(435, 2);
            this.cmdAplicar.Name = "cmdAplicar";
            this.cmdAplicar.Size = new System.Drawing.Size(104, 47);
            this.cmdAplicar.TabIndex = 14;
            this.cmdAplicar.Text = "Aplicar";
            this.cmdAplicar.Click += new System.EventHandler(this.cmdAplicar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(545, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 47);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtParametroBusqueda
            // 
            this.txtParametroBusqueda.Location = new System.Drawing.Point(2, 71);
            this.txtParametroBusqueda.Name = "txtParametroBusqueda";
            this.txtParametroBusqueda.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametroBusqueda.Properties.Appearance.Options.UseFont = true;
            this.txtParametroBusqueda.Size = new System.Drawing.Size(427, 24);
            this.txtParametroBusqueda.TabIndex = 12;
            this.txtParametroBusqueda.EditValueChanged += new System.EventHandler(this.txtParametroBusqueda_EditValueChanged);
            this.txtParametroBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParametroBusqueda_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(2, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(142, 17);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Seleccione un Empleado";
            // 
            // dsPlanillasCalculo1
            // 
            this.dsPlanillasCalculo1.DataSetName = "dsPlanillasCalculo";
            this.dsPlanillasCalculo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmSearchMultItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 412);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControlDetalleMP);
            this.Controls.Add(this.cmdAplicar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtParametroBusqueda);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmSearchMultItems";
            this.Activated += new System.EventHandler(this.frmSearchMultItems_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParametroBusqueda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanillasCalculo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlDetalleMP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colconcat_;
        private DevExpress.XtraEditors.SimpleButton cmdAplicar;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.TextEdit txtParametroBusqueda;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private RRHH_Planilla.Planilla.dsPlanillasCalculo dsPlanillasCalculo1;
    }
}