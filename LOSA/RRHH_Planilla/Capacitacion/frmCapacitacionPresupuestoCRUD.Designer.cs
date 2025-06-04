namespace LOSA.RRHH_Planilla.Mantenimientos
{
    partial class frmCapacitacionPresupuestoCRUD
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
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtPresupuesto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.deAnio = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.slueMoneda = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCapacitacion1 = new LOSA.RRHH_Planilla.Capacitacion.dsCapacitacion();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMontoCambio = new DevExpress.XtraEditors.TextEdit();
            this.btnTC = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresupuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAnio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAnio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCapacitacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoCambio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(139, 77);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Size = new System.Drawing.Size(213, 24);
            this.txtDescripcion.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(57, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Descripción:";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = global::LOSA.Properties.Resources.save_24x24;
            this.btnSave.Location = new System.Drawing.Point(114, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 46);
            this.btnSave.TabIndex = 4;
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
            this.simpleButton2.Location = new System.Drawing.Point(231, 223);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 46);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(176, 0);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(111, 25);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Presupuesto";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(53, 171);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(80, 17);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Presupuesto:";
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.Location = new System.Drawing.Point(139, 168);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresupuesto.Properties.Appearance.Options.UseFont = true;
            this.txtPresupuesto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPresupuesto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPresupuesto.Properties.DisplayFormat.FormatString = "L{0:n4}";
            this.txtPresupuesto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPresupuesto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPresupuesto.Properties.MaskSettings.Set("mask", "n");
            this.txtPresupuesto.Properties.NullText = "0.0000";
            this.txtPresupuesto.Properties.UseMaskAsDisplayFormat = true;
            this.txtPresupuesto.Size = new System.Drawing.Size(213, 24);
            this.txtPresupuesto.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(104, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 17);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Año:";
            // 
            // deAnio
            // 
            this.deAnio.EditValue = null;
            this.deAnio.Location = new System.Drawing.Point(139, 47);
            this.deAnio.Name = "deAnio";
            this.deAnio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deAnio.Properties.Appearance.Options.UseFont = true;
            this.deAnio.Properties.Appearance.Options.UseTextOptions = true;
            this.deAnio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.deAnio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deAnio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deAnio.Properties.DisplayFormat.FormatString = "yyyy";
            this.deAnio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deAnio.Properties.EditFormat.FormatString = "DateTime \"yyyy\"";
            this.deAnio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deAnio.Properties.MaskSettings.Set("mask", "yyyy");
            this.deAnio.Properties.NullText = "[Selecc. un año]";
            this.deAnio.Properties.UseMaskAsDisplayFormat = true;
            this.deAnio.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView;
            this.deAnio.Size = new System.Drawing.Size(113, 24);
            this.deAnio.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(79, 110);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(54, 17);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Moneda:";
            // 
            // slueMoneda
            // 
            this.slueMoneda.Location = new System.Drawing.Point(139, 107);
            this.slueMoneda.Name = "slueMoneda";
            this.slueMoneda.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slueMoneda.Properties.Appearance.Options.UseFont = true;
            this.slueMoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueMoneda.Properties.DataSource = this.currencyBindingSource;
            this.slueMoneda.Properties.DisplayMember = "name";
            this.slueMoneda.Properties.NullText = "";
            this.slueMoneda.Properties.PopupView = this.gridView2;
            this.slueMoneda.Properties.ValueMember = "id";
            this.slueMoneda.Size = new System.Drawing.Size(213, 24);
            this.slueMoneda.TabIndex = 2;
            this.slueMoneda.EditValueChanged += new System.EventHandler(this.slueMoneda_EditValueChanged);
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataMember = "currency";
            this.currencyBindingSource.DataSource = this.dsCapacitacion1;
            // 
            // dsCapacitacion1
            // 
            this.dsCapacitacion1.DataSetName = "dsCapacitacion";
            this.dsCapacitacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Moneda";
            this.gridColumn1.FieldName = "name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(50, 140);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 17);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Tasa Cambio:";
            // 
            // txtMontoCambio
            // 
            this.txtMontoCambio.Location = new System.Drawing.Point(139, 137);
            this.txtMontoCambio.Name = "txtMontoCambio";
            this.txtMontoCambio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoCambio.Properties.Appearance.Options.UseFont = true;
            this.txtMontoCambio.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMontoCambio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtMontoCambio.Properties.DisplayFormat.FormatString = "{0:n4}";
            this.txtMontoCambio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMontoCambio.Properties.EditFormat.FormatString = "{0:n4}";
            this.txtMontoCambio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMontoCambio.Properties.NullText = "0.0000";
            this.txtMontoCambio.Properties.UseMaskAsDisplayFormat = true;
            this.txtMontoCambio.Size = new System.Drawing.Size(213, 24);
            this.txtMontoCambio.TabIndex = 20;
            // 
            // btnTC
            // 
            this.btnTC.ImageOptions.Image = global::LOSA.Properties.Resources.currency_exchange_16X16;
            this.btnTC.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnTC.Location = new System.Drawing.Point(358, 138);
            this.btnTC.Name = "btnTC";
            this.btnTC.Size = new System.Drawing.Size(34, 23);
            this.btnTC.TabIndex = 60;
            this.btnTC.Click += new System.EventHandler(this.btnTC_Click);
            // 
            // frmCapacitacionPresupuestoCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 294);
            this.Controls.Add(this.btnTC);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtMontoCambio);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.slueMoneda);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtPresupuesto);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.deAnio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCapacitacionPresupuestoCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presupuesto";
            this.Load += new System.EventHandler(this.frmPlanillaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresupuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAnio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAnio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCapacitacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoCambio.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtPresupuesto;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit deAnio;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SearchLookUpEdit slueMoneda;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private Capacitacion.dsCapacitacion dsCapacitacion1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtMontoCambio;
        private DevExpress.XtraEditors.SimpleButton btnTC;
    }
}