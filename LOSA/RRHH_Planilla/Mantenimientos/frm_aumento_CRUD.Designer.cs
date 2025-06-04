namespace LOSA.RRHH_Planilla.Mantenimientos
{
    partial class frm_aumento_CRUD
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
            this.deFecha = new DevExpress.XtraEditors.DateEdit();
            this.slueTipoAumento = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.paymenthistorytypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsColaborador1 = new LOSA.RRHH_Planilla.dsColaborador();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtValor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtSalarioActual = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblNuevoSalario = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueTipoAumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymenthistorytypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsColaborador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalarioActual.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(95, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fecha:";
            // 
            // deFecha
            // 
            this.deFecha.EditValue = null;
            this.deFecha.Location = new System.Drawing.Point(140, 31);
            this.deFecha.Name = "deFecha";
            this.deFecha.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deFecha.Properties.Appearance.Options.UseFont = true;
            this.deFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Size = new System.Drawing.Size(100, 24);
            this.deFecha.TabIndex = 0;
            // 
            // slueTipoAumento
            // 
            this.slueTipoAumento.Location = new System.Drawing.Point(140, 60);
            this.slueTipoAumento.Name = "slueTipoAumento";
            this.slueTipoAumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slueTipoAumento.Properties.Appearance.Options.UseFont = true;
            this.slueTipoAumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueTipoAumento.Properties.DataSource = this.paymenthistorytypeBindingSource;
            this.slueTipoAumento.Properties.DisplayMember = "descripcion";
            this.slueTipoAumento.Properties.PopupView = this.searchLookUpEdit1View;
            this.slueTipoAumento.Properties.ValueMember = "id";
            this.slueTipoAumento.Size = new System.Drawing.Size(179, 24);
            this.slueTipoAumento.TabIndex = 1;
            this.slueTipoAumento.EditValueChanged += new System.EventHandler(this.slueTipoAumento_EditValueChanged);
            // 
            // paymenthistorytypeBindingSource
            // 
            this.paymenthistorytypeBindingSource.DataMember = "payment_history_type";
            this.paymenthistorytypeBindingSource.DataSource = this.dsColaborador1;
            // 
            // dsColaborador1
            // 
            this.dsColaborador1.DataSetName = "dsColaborador";
            this.dsColaborador1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tipo";
            this.gridColumn1.FieldName = "descripcion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(41, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tipo Aumento:";
            // 
            // txtValor
            // 
            this.txtValor.EditValue = "0";
            this.txtValor.Location = new System.Drawing.Point(140, 121);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Properties.Appearance.Options.UseFont = true;
            this.txtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValor.Properties.DisplayFormat.FormatString = "{0:N2}";
            this.txtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValor.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtValor.Properties.MaskSettings.Set("mask", "n");
            this.txtValor.Size = new System.Drawing.Size(100, 24);
            this.txtValor.TabIndex = 3;
            this.txtValor.EditValueChanged += new System.EventHandler(this.txtValor_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(97, 124);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 17);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Valor:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_24x24;
            this.simpleButton2.Location = new System.Drawing.Point(213, 201);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 46);
            this.simpleButton2.TabIndex = 5;
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
            this.btnSave.Location = new System.Drawing.Point(96, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 46);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSalarioActual
            // 
            this.txtSalarioActual.EditValue = "0";
            this.txtSalarioActual.Enabled = false;
            this.txtSalarioActual.Location = new System.Drawing.Point(140, 91);
            this.txtSalarioActual.Name = "txtSalarioActual";
            this.txtSalarioActual.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioActual.Properties.Appearance.Options.UseFont = true;
            this.txtSalarioActual.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSalarioActual.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSalarioActual.Properties.DisplayFormat.FormatString = "{0:N2}";
            this.txtSalarioActual.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSalarioActual.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSalarioActual.Properties.MaskSettings.Set("mask", "n");
            this.txtSalarioActual.Size = new System.Drawing.Size(100, 24);
            this.txtSalarioActual.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(45, 94);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 17);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Salario Actual:";
            // 
            // lblNuevoSalario
            // 
            this.lblNuevoSalario.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoSalario.Appearance.Options.UseFont = true;
            this.lblNuevoSalario.Location = new System.Drawing.Point(45, 160);
            this.lblNuevoSalario.Name = "lblNuevoSalario";
            this.lblNuevoSalario.Size = new System.Drawing.Size(89, 17);
            this.lblNuevoSalario.TabIndex = 12;
            this.lblNuevoSalario.Text = "Salario Actual:";
            // 
            // frm_aumento_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 257);
            this.Controls.Add(this.lblNuevoSalario);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtSalarioActual);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.slueTipoAumento);
            this.Controls.Add(this.deFecha);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_aumento_CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aumento";
            this.Load += new System.EventHandler(this.frm_aumento_CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueTipoAumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymenthistorytypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsColaborador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalarioActual.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit deFecha;
        private DevExpress.XtraEditors.SearchLookUpEdit slueTipoAumento;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtValor;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.BindingSource paymenthistorytypeBindingSource;
        private dsColaborador dsColaborador1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.TextEdit txtSalarioActual;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblNuevoSalario;
    }
}