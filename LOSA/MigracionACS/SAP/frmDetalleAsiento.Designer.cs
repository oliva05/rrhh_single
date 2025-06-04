namespace LOSA.MigracionACS.SAP
{
    partial class frmDetalleAsiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleAsiento));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsDataSetSAP1 = new LOSA.MigracionACS.SAP.dsDataSetSAP();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_header = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colregla_salarial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanalytic_account_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanayltic_account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaccount_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcuenta_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcuenta_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldebito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpayslip_run_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdCargar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataSetSAP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "DetalleAsiento";
            this.gridControl1.DataSource = this.dsDataSetSAP1;
            this.gridControl1.Location = new System.Drawing.Point(3, 37);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1263, 604);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsDataSetSAP1
            // 
            this.dsDataSetSAP1.DataSetName = "dsDataSetSAP";
            this.dsDataSetSAP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_header,
            this.colregla_salarial,
            this.colanalytic_account_id,
            this.colanayltic_account,
            this.colcode,
            this.colaccount_id,
            this.colcuenta_code,
            this.colcuenta_name,
            this.coldebito,
            this.colcredito,
            this.colcurrency,
            this.colpayslip_run_id});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colid_header
            // 
            this.colid_header.FieldName = "id_header";
            this.colid_header.Name = "colid_header";
            this.colid_header.Visible = true;
            this.colid_header.VisibleIndex = 0;
            // 
            // colregla_salarial
            // 
            this.colregla_salarial.FieldName = "regla_salarial";
            this.colregla_salarial.Name = "colregla_salarial";
            this.colregla_salarial.Visible = true;
            this.colregla_salarial.VisibleIndex = 1;
            // 
            // colanalytic_account_id
            // 
            this.colanalytic_account_id.FieldName = "analytic_account_id";
            this.colanalytic_account_id.Name = "colanalytic_account_id";
            this.colanalytic_account_id.Visible = true;
            this.colanalytic_account_id.VisibleIndex = 2;
            // 
            // colanayltic_account
            // 
            this.colanayltic_account.FieldName = "anayltic_account";
            this.colanayltic_account.Name = "colanayltic_account";
            this.colanayltic_account.Visible = true;
            this.colanayltic_account.VisibleIndex = 3;
            // 
            // colcode
            // 
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 4;
            // 
            // colaccount_id
            // 
            this.colaccount_id.FieldName = "account_id";
            this.colaccount_id.Name = "colaccount_id";
            this.colaccount_id.Visible = true;
            this.colaccount_id.VisibleIndex = 5;
            // 
            // colcuenta_code
            // 
            this.colcuenta_code.FieldName = "cuenta_code";
            this.colcuenta_code.Name = "colcuenta_code";
            this.colcuenta_code.Visible = true;
            this.colcuenta_code.VisibleIndex = 6;
            // 
            // colcuenta_name
            // 
            this.colcuenta_name.FieldName = "cuenta_name";
            this.colcuenta_name.Name = "colcuenta_name";
            this.colcuenta_name.Visible = true;
            this.colcuenta_name.VisibleIndex = 7;
            // 
            // coldebito
            // 
            this.coldebito.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.coldebito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldebito.FieldName = "debito";
            this.coldebito.Name = "coldebito";
            this.coldebito.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "debito", "{0:#,###,##0.00}")});
            this.coldebito.Visible = true;
            this.coldebito.VisibleIndex = 8;
            // 
            // colcredito
            // 
            this.colcredito.DisplayFormat.FormatString = "{0:#,###,##0.00}";
            this.colcredito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcredito.FieldName = "credito";
            this.colcredito.Name = "colcredito";
            this.colcredito.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "credito", "{0:#,###,##0.00}")});
            this.colcredito.Visible = true;
            this.colcredito.VisibleIndex = 9;
            // 
            // colcurrency
            // 
            this.colcurrency.FieldName = "currency";
            this.colcurrency.Name = "colcurrency";
            this.colcurrency.Visible = true;
            this.colcurrency.VisibleIndex = 10;
            // 
            // colpayslip_run_id
            // 
            this.colpayslip_run_id.FieldName = "payslip_run_id";
            this.colpayslip_run_id.Name = "colpayslip_run_id";
            this.colpayslip_run_id.Visible = true;
            this.colpayslip_run_id.VisibleIndex = 11;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Appearance.Options.UseFont = true;
            this.cmdCargar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCargar.ImageOptions.Image")));
            this.cmdCargar.Location = new System.Drawing.Point(12, 1);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(112, 30);
            this.cmdCargar.TabIndex = 1;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // frmDetalleAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 647);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmDetalleAsiento";
            this.Text = "frmDetalleAsiento";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataSetSAP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsDataSetSAP dsDataSetSAP1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_header;
        private DevExpress.XtraGrid.Columns.GridColumn colregla_salarial;
        private DevExpress.XtraGrid.Columns.GridColumn colanalytic_account_id;
        private DevExpress.XtraGrid.Columns.GridColumn colanayltic_account;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn colaccount_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcuenta_code;
        private DevExpress.XtraGrid.Columns.GridColumn colcuenta_name;
        private DevExpress.XtraGrid.Columns.GridColumn coldebito;
        private DevExpress.XtraGrid.Columns.GridColumn colcredito;
        private DevExpress.XtraGrid.Columns.GridColumn colcurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colpayslip_run_id;
        private DevExpress.XtraEditors.SimpleButton cmdCargar;
    }
}