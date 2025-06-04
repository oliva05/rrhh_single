namespace LOSA.RRHH_Planilla.Planilla
{
    partial class frmDeduccionCafeteria
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
            this.gcDeduccion = new DevExpress.XtraGrid.GridControl();
            this.dsPlanillasTransaccion1 = new LOSA.RRHH_Planilla.Planilla.dsPlanillasTransaccion();
            this.gvDeduccion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ceExcluir = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.deFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::LOSA.RRHH_Planilla.Planilla.WaitFormDeduccionCafeteria), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.gcDeduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanillasTransaccion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDeduccion
            // 
            this.gcDeduccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDeduccion.DataMember = "deduccion_cafeteria";
            this.gcDeduccion.DataSource = this.dsPlanillasTransaccion1;
            this.gcDeduccion.Location = new System.Drawing.Point(2, 134);
            this.gcDeduccion.MainView = this.gvDeduccion;
            this.gcDeduccion.Name = "gcDeduccion";
            this.gcDeduccion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ceExcluir});
            this.gcDeduccion.Size = new System.Drawing.Size(762, 362);
            this.gcDeduccion.TabIndex = 0;
            this.gcDeduccion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDeduccion});
            // 
            // dsPlanillasTransaccion1
            // 
            this.dsPlanillasTransaccion1.DataSetName = "dsPlanillasTransaccion";
            this.dsPlanillasTransaccion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvDeduccion
            // 
            this.gvDeduccion.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDeduccion.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDeduccion.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDeduccion.Appearance.Row.Options.UseFont = true;
            this.gvDeduccion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodigo,
            this.colnombre,
            this.coltotal,
            this.gridColumn1,
            this.gridColumn2});
            this.gvDeduccion.GridControl = this.gcDeduccion;
            this.gvDeduccion.Name = "gvDeduccion";
            this.gvDeduccion.OptionsView.ShowAutoFilterRow = true;
            this.gvDeduccion.OptionsView.ShowGroupPanel = false;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Código";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.ReadOnly = true;
            this.colcodigo.OptionsFilter.AllowFilter = false;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            this.colcodigo.Width = 125;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.ReadOnly = true;
            this.colnombre.OptionsFilter.AllowFilter = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 2;
            this.colnombre.Width = 319;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.DisplayFormat.FormatString = "{0:N2}";
            this.coltotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.ReadOnly = true;
            this.coltotal.OptionsFilter.AllowFilter = false;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 3;
            this.coltotal.Width = 145;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Incluir";
            this.gridColumn1.ColumnEdit = this.ceExcluir;
            this.gridColumn1.FieldName = "excluir";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // ceExcluir
            // 
            this.ceExcluir.AutoHeight = false;
            this.ceExcluir.Name = "ceExcluir";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Num.";
            this.gridColumn2.FieldName = "row_number";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 45;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Appearance.Options.UseBackColor = true;
            this.btnCerrar.Appearance.Options.UseFont = true;
            this.btnCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCerrar.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.btnCerrar.Location = new System.Drawing.Point(636, 57);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 44);
            this.btnCerrar.TabIndex = 105;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGenerar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Appearance.Options.UseBackColor = true;
            this.btnGenerar.Appearance.Options.UseFont = true;
            this.btnGenerar.Appearance.Options.UseTextOptions = true;
            this.btnGenerar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnGenerar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGenerar.ImageOptions.Image = global::LOSA.Properties.Resources.batch_processing_32X32;
            this.btnGenerar.Location = new System.Drawing.Point(507, 57);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(123, 44);
            this.btnGenerar.TabIndex = 106;
            this.btnGenerar.Text = "Generar Deducción";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // deFecha
            // 
            this.deFecha.EditValue = null;
            this.deFecha.Location = new System.Drawing.Point(107, 68);
            this.deFecha.Name = "deFecha";
            this.deFecha.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deFecha.Properties.Appearance.Options.UseFont = true;
            this.deFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.deFecha.Size = new System.Drawing.Size(100, 24);
            this.deFecha.TabIndex = 107;
            this.deFecha.EditValueChanged += new System.EventHandler(this.deFecha_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(32, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 17);
            this.labelControl1.TabIndex = 108;
            this.labelControl1.Text = "Fecha Corte";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(2, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(762, 24);
            this.labelControl2.TabIndex = 109;
            this.labelControl2.Text = "Generación de Deducción de Gastos de Cafetería";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(32, 107);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Seleccionar Todo";
            this.checkEdit1.Size = new System.Drawing.Size(123, 21);
            this.checkEdit1.TabIndex = 111;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frmDeduccionCafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 495);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.deFecha);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gcDeduccion);
            this.Name = "frmDeduccionCafeteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deducción Cafetería";
            ((System.ComponentModel.ISupportInitialize)(this.gcDeduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanillasTransaccion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDeduccion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDeduccion;
        private dsPlanillasTransaccion dsPlanillasTransaccion1;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraEditors.SimpleButton btnCerrar;
        private DevExpress.XtraEditors.SimpleButton btnGenerar;
        private DevExpress.XtraEditors.DateEdit deFecha;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ceExcluir;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}