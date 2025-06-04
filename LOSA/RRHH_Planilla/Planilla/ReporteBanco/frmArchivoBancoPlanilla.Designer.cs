namespace LOSA.RRHH_Planilla.Planilla.ReporteBanco
{
    partial class frmArchivoBancoPlanilla
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
            this.cmdExportar = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsReportesBancoPlanilla1 = new LOSA.RRHH_Planilla.Planilla.ReporteBanco.dsReportesBancoPlanilla();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfila = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsalario_neto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemployee_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dsPlanillasTransaccion1 = new LOSA.RRHH_Planilla.Planilla.dsPlanillasTransaccion();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesBancoPlanilla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanillasTransaccion1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdExportar
            // 
            this.cmdExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExportar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmdExportar.Image = global::LOSA.Properties.Resources.sobresalir241;
            this.cmdExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExportar.Location = new System.Drawing.Point(583, 2);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(108, 33);
            this.cmdExportar.TabIndex = 146;
            this.cmdExportar.Text = "Exportar";
            this.cmdExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExportar.UseVisualStyleBackColor = true;
            this.cmdExportar.Click += new System.EventHandler(this.cmdExportar_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Image = global::LOSA.Properties.Resources.Danieledesantis_Playstation_Flat_Playstation_cross_black_and_white_24;
            this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(697, 2);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(108, 33);
            this.cmdCerrar.TabIndex = 147;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "detalle_reporte_banco";
            this.gridControl1.DataSource = this.dsReportesBancoPlanilla1;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(3, 46);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(802, 347);
            this.gridControl1.TabIndex = 148;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsReportesBancoPlanilla1
            // 
            this.dsReportesBancoPlanilla1.DataSetName = "dsReportesBancoPlanilla";
            this.dsReportesBancoPlanilla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfila,
            this.colcodigo,
            this.colnombre,
            this.colsalario_neto,
            this.colemployee_id,
            this.colid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colfila
            // 
            this.colfila.FieldName = "fila";
            this.colfila.Name = "colfila";
            this.colfila.Visible = true;
            this.colfila.VisibleIndex = 0;
            this.colfila.Width = 82;
            // 
            // colcodigo
            // 
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            this.colcodigo.Width = 89;
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 2;
            this.colnombre.Width = 409;
            // 
            // colsalario_neto
            // 
            this.colsalario_neto.DisplayFormat.FormatString = "L #,###,##0.00";
            this.colsalario_neto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsalario_neto.FieldName = "salario_neto";
            this.colsalario_neto.Name = "colsalario_neto";
            this.colsalario_neto.Visible = true;
            this.colsalario_neto.VisibleIndex = 3;
            this.colsalario_neto.Width = 276;
            // 
            // colemployee_id
            // 
            this.colemployee_id.FieldName = "employee_id";
            this.colemployee_id.Name = "colemployee_id";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 20);
            this.labelControl1.TabIndex = 149;
            this.labelControl1.Text = "Archivo resumen";
            // 
            // dsPlanillasTransaccion1
            // 
            this.dsPlanillasTransaccion1.DataSetName = "dsPlanillasTransaccion";
            this.dsPlanillasTransaccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmArchivoBancoPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 395);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdExportar);
            this.Name = "frmArchivoBancoPlanilla";
            this.Text = "Archivo Banco Planilla";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesBancoPlanilla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanillasTransaccion1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdExportar;
        private System.Windows.Forms.Button cmdCerrar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsReportesBancoPlanilla dsReportesBancoPlanilla1;
        private DevExpress.XtraGrid.Columns.GridColumn colfila;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colsalario_neto;
        private dsPlanillasTransaccion dsPlanillasTransaccion1;
        private DevExpress.XtraGrid.Columns.GridColumn colemployee_id;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
    }
}