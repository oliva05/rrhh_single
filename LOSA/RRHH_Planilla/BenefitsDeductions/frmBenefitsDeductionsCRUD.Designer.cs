namespace LOSA.RRHH_Planilla.BenefitsDeductions
{
    partial class frmBenefitsDeductionsCRUD
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
            this.deFechaAplicable = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.slueConcepto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.conceptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimientoPlanilla1 = new LOSA.RRHH_Planilla.Mantenimientos.dsMantenimientoPlanilla();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.slueTipo = new DevExpress.XtraEditors.LookUpEdit();
            this.benefitdeductiontypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtValor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtComments = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.slueTypeBD = new DevExpress.XtraEditors.LookUpEdit();
            this.benefitsdeductionstipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsColaborador1 = new LOSA.RRHH_Planilla.dsColaborador();
            this.lblMontoOriginal = new DevExpress.XtraEditors.LabelControl();
            this.seCuotas = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaAplicable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaAplicable.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueConcepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benefitdeductiontypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComments.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueTypeBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benefitsdeductionstipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsColaborador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCuotas.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // deFechaAplicable
            // 
            this.deFechaAplicable.EditValue = null;
            this.deFechaAplicable.Location = new System.Drawing.Point(126, 77);
            this.deFechaAplicable.Name = "deFechaAplicable";
            this.deFechaAplicable.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deFechaAplicable.Properties.Appearance.Options.UseFont = true;
            this.deFechaAplicable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaAplicable.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaAplicable.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deFechaAplicable.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFechaAplicable.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.deFechaAplicable.Size = new System.Drawing.Size(100, 24);
            this.deFechaAplicable.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(20, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Fecha Aplicable:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(58, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Concepto:";
            // 
            // slueConcepto
            // 
            this.slueConcepto.Location = new System.Drawing.Point(126, 109);
            this.slueConcepto.Name = "slueConcepto";
            this.slueConcepto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slueConcepto.Properties.Appearance.Options.UseFont = true;
            this.slueConcepto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueConcepto.Properties.DataSource = this.conceptsBindingSource;
            this.slueConcepto.Properties.DisplayMember = "name";
            this.slueConcepto.Properties.NullText = "";
            this.slueConcepto.Properties.PopupView = this.searchLookUpEdit1View;
            this.slueConcepto.Properties.ValueMember = "id";
            this.slueConcepto.Size = new System.Drawing.Size(252, 24);
            this.slueConcepto.TabIndex = 1;
            // 
            // conceptsBindingSource
            // 
            this.conceptsBindingSource.DataMember = "Concepts";
            this.conceptsBindingSource.DataSource = this.dsMantenimientoPlanilla1;
            // 
            // dsMantenimientoPlanilla1
            // 
            this.dsMantenimientoPlanilla1.DataSetName = "dsMantenimientoPlanilla";
            this.dsMantenimientoPlanilla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Code";
            this.gridColumn1.FieldName = "code";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 156;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre";
            this.gridColumn2.FieldName = "name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 794;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(51, 144);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Periocidad:";
            // 
            // slueTipo
            // 
            this.slueTipo.Location = new System.Drawing.Point(126, 141);
            this.slueTipo.Name = "slueTipo";
            this.slueTipo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slueTipo.Properties.Appearance.Options.UseFont = true;
            this.slueTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueTipo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Descripción", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.slueTipo.Properties.DataSource = this.benefitdeductiontypeBindingSource;
            this.slueTipo.Properties.DisplayMember = "descripcion";
            this.slueTipo.Properties.NullText = "";
            this.slueTipo.Properties.ValueMember = "id";
            this.slueTipo.Size = new System.Drawing.Size(252, 24);
            this.slueTipo.TabIndex = 2;
            this.slueTipo.EditValueChanged += new System.EventHandler(this.slueTipo_EditValueChanged);
            // 
            // benefitdeductiontypeBindingSource
            // 
            this.benefitdeductiontypeBindingSource.DataMember = "benefit_deduction_type";
            this.benefitdeductiontypeBindingSource.DataSource = this.dsMantenimientoPlanilla1;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(126, 237);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Properties.Appearance.Options.UseFont = true;
            this.txtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValor.Properties.DisplayFormat.FormatString = "L {0:N2}";
            this.txtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValor.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtValor.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtValor.Properties.MaskSettings.Set("mask", "n2");
            this.txtValor.Properties.NullText = "0";
            this.txtValor.Size = new System.Drawing.Size(158, 24);
            this.txtValor.TabIndex = 5;
            this.txtValor.EditValueChanged += new System.EventHandler(this.txtValor_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(83, 240);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 17);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Valor:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(74, 208);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 17);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Cuotas:";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(126, 276);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(252, 82);
            this.txtComments.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(38, 277);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 17);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Comentarios:";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(-2, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(445, 25);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Beneficio/Deducción";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_24x24;
            this.simpleButton2.Location = new System.Drawing.Point(229, 376);
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
            this.btnSave.ImageOptions.Image = global::LOSA.Properties.Resources.save_24x24;
            this.btnSave.Location = new System.Drawing.Point(112, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 46);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(88, 174);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(32, 17);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Tipo:";
            // 
            // slueTypeBD
            // 
            this.slueTypeBD.Location = new System.Drawing.Point(126, 171);
            this.slueTypeBD.Name = "slueTypeBD";
            this.slueTypeBD.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slueTypeBD.Properties.Appearance.Options.UseFont = true;
            this.slueTypeBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueTypeBD.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Descripción", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.slueTypeBD.Properties.DataSource = this.benefitsdeductionstipoBindingSource;
            this.slueTypeBD.Properties.DisplayMember = "descripcion";
            this.slueTypeBD.Properties.NullText = "";
            this.slueTypeBD.Properties.ValueMember = "id";
            this.slueTypeBD.Size = new System.Drawing.Size(252, 24);
            this.slueTypeBD.TabIndex = 3;
            // 
            // benefitsdeductionstipoBindingSource
            // 
            this.benefitsdeductionstipoBindingSource.DataMember = "benefits_deductions_tipo";
            this.benefitsdeductionstipoBindingSource.DataSource = this.dsColaborador1;
            // 
            // dsColaborador1
            // 
            this.dsColaborador1.DataSetName = "dsColaborador";
            this.dsColaborador1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMontoOriginal
            // 
            this.lblMontoOriginal.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoOriginal.Appearance.Options.UseFont = true;
            this.lblMontoOriginal.Location = new System.Drawing.Point(126, 54);
            this.lblMontoOriginal.Name = "lblMontoOriginal";
            this.lblMontoOriginal.Size = new System.Drawing.Size(101, 17);
            this.lblMontoOriginal.TabIndex = 15;
            this.lblMontoOriginal.Text = "Valor quincenal:";
            this.lblMontoOriginal.Visible = false;
            // 
            // seCuotas
            // 
            this.seCuotas.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seCuotas.Location = new System.Drawing.Point(126, 205);
            this.seCuotas.Name = "seCuotas";
            this.seCuotas.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seCuotas.Properties.Appearance.Options.UseFont = true;
            this.seCuotas.Properties.Appearance.Options.UseTextOptions = true;
            this.seCuotas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.seCuotas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seCuotas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seCuotas.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.seCuotas.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.seCuotas.Properties.MaskSettings.Set("mask", "d");
            this.seCuotas.Properties.MaxValue = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.seCuotas.Properties.NullText = "0";
            this.seCuotas.Size = new System.Drawing.Size(158, 24);
            this.seCuotas.TabIndex = 4;
            // 
            // frmBenefitsDeductionsCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 470);
            this.Controls.Add(this.lblMontoOriginal);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.slueTypeBD);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.slueConcepto);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.deFechaAplicable);
            this.Controls.Add(this.slueTipo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.seCuotas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBenefitsDeductionsCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beneficio o Deducción";
            this.Load += new System.EventHandler(this.frmBenefitsDeductionsCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deFechaAplicable.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaAplicable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueConcepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benefitdeductiontypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComments.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueTypeBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benefitsdeductionstipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsColaborador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCuotas.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit deFechaAplicable;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit slueConcepto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit slueTipo;
        private DevExpress.XtraEditors.TextEdit txtValor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txtComments;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.BindingSource conceptsBindingSource;
        private Mantenimientos.dsMantenimientoPlanilla dsMantenimientoPlanilla1;
        private System.Windows.Forms.BindingSource benefitdeductiontypeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit slueTypeBD;
        private System.Windows.Forms.BindingSource benefitsdeductionstipoBindingSource;
        private dsColaborador dsColaborador1;
        private DevExpress.XtraEditors.LabelControl lblMontoOriginal;
        private DevExpress.XtraEditors.SpinEdit seCuotas;
    }
}