namespace LOSA.RRHH_Planilla.BenefitsDeductions
{
    partial class frmDeductionsCRUD_PayslipLine
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.slueConcepto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.conceptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimientoPlanilla1 = new LOSA.RRHH_Planilla.Mantenimientos.dsMantenimientoPlanilla();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.benefitdeductiontypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtValor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtComments = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.benefitsdeductionstipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsColaborador1 = new LOSA.RRHH_Planilla.dsColaborador();
            ((System.ComponentModel.ISupportInitialize)(this.slueConcepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benefitdeductiontypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComments.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benefitsdeductionstipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsColaborador1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(58, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Concepto:";
            // 
            // slueConcepto
            // 
            this.slueConcepto.Location = new System.Drawing.Point(126, 43);
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
            this.slueConcepto.TabIndex = 0;
            this.slueConcepto.EditValueChanged += new System.EventHandler(this.slueConcepto_EditValueChanged);
            this.slueConcepto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.slueConcepto_KeyDown);
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
            // benefitdeductiontypeBindingSource
            // 
            this.benefitdeductiontypeBindingSource.DataMember = "benefit_deduction_type";
            this.benefitdeductiontypeBindingSource.DataSource = this.dsMantenimientoPlanilla1;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(126, 73);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Properties.Appearance.Options.UseFont = true;
            this.txtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValor.Properties.DisplayFormat.FormatString = "{0:N2}";
            this.txtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValor.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtValor.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtValor.Properties.MaskSettings.Set("mask", "n2");
            this.txtValor.Properties.NullText = "0";
            this.txtValor.Size = new System.Drawing.Size(158, 24);
            this.txtValor.TabIndex = 1;
            this.txtValor.EditValueChanged += new System.EventHandler(this.txtValor_EditValueChanged);
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(83, 76);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 17);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Valor:";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(126, 103);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(252, 82);
            this.txtComments.TabIndex = 2;
            this.txtComments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComments_KeyDown);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(38, 104);
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
            this.labelControl7.Location = new System.Drawing.Point(2, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(436, 25);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Agregar Beneficio/Deducción";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_24x24;
            this.simpleButton2.Location = new System.Drawing.Point(227, 191);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 46);
            this.simpleButton2.TabIndex = 4;
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
            this.btnSave.Location = new System.Drawing.Point(110, 191);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 46);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // frmDeductionsCRUD_PayslipLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 248);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.slueConcepto);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtComments);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeductionsCRUD_PayslipLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beneficio o Deducción";
            this.Load += new System.EventHandler(this.frmDeductionsCRUD_PayslipLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slueConcepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benefitdeductiontypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComments.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benefitsdeductionstipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsColaborador1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit slueConcepto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtValor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
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
        private System.Windows.Forms.BindingSource benefitsdeductionstipoBindingSource;
        private dsColaborador dsColaborador1;
    }
}