namespace LOSA.RRHH_Planilla.Mantenimientos
{
    partial class frmPlanillaTipoCambio
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.slueProcedencia = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.slueDestino = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtMonto = new DevExpress.XtraEditors.TextEdit();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimientoPlanilla = new LOSA.RRHH_Planilla.Mantenimientos.dsMantenimientoPlanilla();
            this.hrtipocambioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deFecha = new DevExpress.XtraEditors.DateEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.slueProcedencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrtipocambioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(115, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Fecha:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(109, 142);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Monto:";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = global::LOSA.Properties.Resources.save_24x24;
            this.btnSave.Location = new System.Drawing.Point(120, 195);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 46);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_24x24;
            this.simpleButton2.Location = new System.Drawing.Point(237, 195);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 46);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(160, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(140, 25);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Tipo de Cambio";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(22, 82);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(132, 17);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Moneda Procedencia:";
            // 
            // slueProcedencia
            // 
            this.slueProcedencia.Location = new System.Drawing.Point(160, 79);
            this.slueProcedencia.Name = "slueProcedencia";
            this.slueProcedencia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slueProcedencia.Properties.Appearance.Options.UseFont = true;
            this.slueProcedencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueProcedencia.Properties.DataSource = this.currencyBindingSource;
            this.slueProcedencia.Properties.DisplayMember = "name";
            this.slueProcedencia.Properties.NullText = "Seleccione una moneda";
            this.slueProcedencia.Properties.PopupView = this.searchLookUpEdit1View;
            this.slueProcedencia.Properties.ValueMember = "id";
            this.slueProcedencia.Size = new System.Drawing.Size(183, 24);
            this.slueProcedencia.TabIndex = 10;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(48, 112);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(106, 17);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Moneda Destino:";
            // 
            // slueDestino
            // 
            this.slueDestino.Location = new System.Drawing.Point(160, 109);
            this.slueDestino.Name = "slueDestino";
            this.slueDestino.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slueDestino.Properties.Appearance.Options.UseFont = true;
            this.slueDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueDestino.Properties.DataSource = this.currencyBindingSource;
            this.slueDestino.Properties.DisplayMember = "name";
            this.slueDestino.Properties.NullText = "Seleccione una moneda";
            this.slueDestino.Properties.PopupView = this.gridView2;
            this.slueDestino.Properties.ValueMember = "id";
            this.slueDestino.Size = new System.Drawing.Size(183, 24);
            this.slueDestino.TabIndex = 14;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(160, 139);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Properties.Appearance.Options.UseFont = true;
            this.txtMonto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMonto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtMonto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMonto.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtMonto.Properties.MaskSettings.Set("mask", "f4");
            this.txtMonto.Properties.NullText = "1";
            this.txtMonto.Size = new System.Drawing.Size(183, 24);
            this.txtMonto.TabIndex = 1;
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataMember = "currency";
            this.currencyBindingSource.DataSource = this.dsMantenimientoPlanilla;
            // 
            // dsMantenimientoPlanilla
            // 
            this.dsMantenimientoPlanilla.DataSetName = "dsMantenimientoPlanilla";
            this.dsMantenimientoPlanilla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hrtipocambioBindingSource
            // 
            this.hrtipocambioBindingSource.DataMember = "hr_tipo_cambio";
            this.hrtipocambioBindingSource.DataSource = this.dsMantenimientoPlanilla;
            // 
            // deFecha
            // 
            this.deFecha.EditValue = null;
            this.deFecha.Location = new System.Drawing.Point(160, 53);
            this.deFecha.Name = "deFecha";
            this.deFecha.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.deFecha.Properties.Appearance.Options.UseFont = true;
            this.deFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Size = new System.Drawing.Size(183, 24);
            this.deFecha.TabIndex = 16;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Moneda";
            this.gridColumn1.FieldName = "name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Moneda";
            this.gridColumn2.FieldName = "name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // frmPlanillaTipoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 263);
            this.Controls.Add(this.deFecha);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.slueDestino);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.slueProcedencia);
            this.Controls.Add(this.txtMonto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlanillaTipoCambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Cambio";
            this.Load += new System.EventHandler(this.frmPlanillaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slueProcedencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrtipocambioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private dsMantenimientoPlanilla dsMantenimientoPlanilla;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SearchLookUpEdit slueProcedencia;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SearchLookUpEdit slueDestino;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit txtMonto;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.BindingSource hrtipocambioBindingSource;
        private DevExpress.XtraEditors.DateEdit deFecha;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}