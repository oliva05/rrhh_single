namespace LOSA.RRHH_Planilla.Capacitacion
{
    partial class frmSeleccionarTasaCambio
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
            this.slueTasaCambio = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.dsCapacitacion1 = new LOSA.RRHH_Planilla.Capacitacion.dsCapacitacion();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tipocambioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.colFechaTipoCambio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonedaProcedencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonedaDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoTipoCambio = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.slueTasaCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCapacitacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipocambioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // slueTasaCambio
            // 
            this.slueTasaCambio.Location = new System.Drawing.Point(160, 27);
            this.slueTasaCambio.Name = "slueTasaCambio";
            this.slueTasaCambio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slueTasaCambio.Properties.Appearance.Options.UseFont = true;
            this.slueTasaCambio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueTasaCambio.Properties.DataSource = this.tipocambioBindingSource;
            this.slueTasaCambio.Properties.DisplayMember = "MontoTipoCambio";
            this.slueTasaCambio.Properties.PopupView = this.searchLookUpEdit1View;
            this.slueTasaCambio.Properties.ValueMember = "MontoTipoCambio";
            this.slueTasaCambio.Size = new System.Drawing.Size(152, 22);
            this.slueTasaCambio.TabIndex = 0;
            // 
            // dsCapacitacion1
            // 
            this.dsCapacitacion1.DataSetName = "dsCapacitacion";
            this.dsCapacitacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFechaTipoCambio,
            this.colMonedaProcedencia,
            this.colMonedaDestino,
            this.colMontoTipoCambio});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(71, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tasa Cambio:";
            // 
            // tipocambioBindingSource
            // 
            this.tipocambioBindingSource.DataMember = "tipo_cambio";
            this.tipocambioBindingSource.DataSource = this.dsCapacitacion1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_24x24;
            this.simpleButton2.Location = new System.Drawing.Point(202, 89);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 46);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = global::LOSA.Properties.Resources.tap24px;
            this.btnSave.Location = new System.Drawing.Point(81, 89);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 46);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Seleccionar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // colFechaTipoCambio
            // 
            this.colFechaTipoCambio.FieldName = "FechaTipoCambio";
            this.colFechaTipoCambio.Name = "colFechaTipoCambio";
            this.colFechaTipoCambio.Visible = true;
            this.colFechaTipoCambio.VisibleIndex = 0;
            // 
            // colMonedaProcedencia
            // 
            this.colMonedaProcedencia.FieldName = "MonedaProcedencia";
            this.colMonedaProcedencia.Name = "colMonedaProcedencia";
            this.colMonedaProcedencia.Visible = true;
            this.colMonedaProcedencia.VisibleIndex = 1;
            // 
            // colMonedaDestino
            // 
            this.colMonedaDestino.FieldName = "MonedaDestino";
            this.colMonedaDestino.Name = "colMonedaDestino";
            this.colMonedaDestino.Visible = true;
            this.colMonedaDestino.VisibleIndex = 2;
            // 
            // colMontoTipoCambio
            // 
            this.colMontoTipoCambio.Caption = "Tasa de Cambio";
            this.colMontoTipoCambio.FieldName = "MontoTipoCambio";
            this.colMontoTipoCambio.Name = "colMontoTipoCambio";
            this.colMontoTipoCambio.Visible = true;
            this.colMontoTipoCambio.VisibleIndex = 3;
            // 
            // frmSeleccionarTasaCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 152);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.slueTasaCambio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSeleccionarTasaCambio";
            this.Text = "Seleccionar Tasa Cambio";
            ((System.ComponentModel.ISupportInitialize)(this.slueTasaCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCapacitacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipocambioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit slueTasaCambio;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private dsCapacitacion dsCapacitacion1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource tipocambioBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaTipoCambio;
        private DevExpress.XtraGrid.Columns.GridColumn colMonedaProcedencia;
        private DevExpress.XtraGrid.Columns.GridColumn colMonedaDestino;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoTipoCambio;
    }
}