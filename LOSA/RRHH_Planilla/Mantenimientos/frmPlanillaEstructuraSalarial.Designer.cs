namespace LOSA.RRHH_Planilla.Mantenimientos
{
    partial class frmPlanillaEstructuraSalarial
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
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lueCompania = new DevExpress.XtraEditors.LookUpEdit();
            this.companiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimientoPlanilla1 = new LOSA.RRHH_Planilla.Mantenimientos.dsMantenimientoPlanilla();
            this.lueMoneda = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(96, 54);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Size = new System.Drawing.Size(111, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(41, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Código:";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = global::LOSA.Properties.Resources.save_24x24;
            this.btnSave.Location = new System.Drawing.Point(123, 202);
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
            this.simpleButton2.Location = new System.Drawing.Point(240, 202);
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
            this.labelControl3.Location = new System.Drawing.Point(156, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(160, 25);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Estructura Salarial";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(35, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 17);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(354, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(23, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 17);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Compañía:";
            // 
            // lueCompania
            // 
            this.lueCompania.Location = new System.Drawing.Point(96, 107);
            this.lueCompania.Name = "lueCompania";
            this.lueCompania.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lueCompania.Properties.Appearance.Options.UseFont = true;
            this.lueCompania.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lueCompania.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lueCompania.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lueCompania.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueCompania.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lueCompania.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueCompania.Properties.AppearanceFocused.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lueCompania.Properties.AppearanceFocused.Options.UseFont = true;
            this.lueCompania.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lueCompania.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lueCompania.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCompania.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 19, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Compañía", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueCompania.Properties.DataSource = this.companiaBindingSource;
            this.lueCompania.Properties.DisplayMember = "name";
            this.lueCompania.Properties.NullText = "[Seleccione la compañía]";
            this.lueCompania.Properties.ValueMember = "id";
            this.lueCompania.Size = new System.Drawing.Size(160, 22);
            this.lueCompania.TabIndex = 13;
            // 
            // companiaBindingSource
            // 
            this.companiaBindingSource.DataMember = "Compania";
            this.companiaBindingSource.DataSource = this.dsMantenimientoPlanilla1;
            // 
            // dsMantenimientoPlanilla1
            // 
            this.dsMantenimientoPlanilla1.DataSetName = "dsMantenimientoPlanilla";
            this.dsMantenimientoPlanilla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lueMoneda
            // 
            this.lueMoneda.Location = new System.Drawing.Point(96, 135);
            this.lueMoneda.Name = "lueMoneda";
            this.lueMoneda.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lueMoneda.Properties.Appearance.Options.UseFont = true;
            this.lueMoneda.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lueMoneda.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lueMoneda.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lueMoneda.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueMoneda.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lueMoneda.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueMoneda.Properties.AppearanceFocused.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lueMoneda.Properties.AppearanceFocused.Options.UseFont = true;
            this.lueMoneda.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lueMoneda.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lueMoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMoneda.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 19, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Moneda", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueMoneda.Properties.DataSource = this.currencyBindingSource;
            this.lueMoneda.Properties.DisplayMember = "name";
            this.lueMoneda.Properties.NullText = "[Seleccione una moneda]";
            this.lueMoneda.Properties.ValueMember = "id";
            this.lueMoneda.Size = new System.Drawing.Size(160, 22);
            this.lueMoneda.TabIndex = 15;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(35, 136);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 17);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Moneda:";
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataMember = "currency";
            this.currencyBindingSource.DataSource = this.dsMantenimientoPlanilla1;
            // 
            // frmPlanillaEstructuraSalarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 260);
            this.Controls.Add(this.lueMoneda);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lueCompania);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlanillaEstructuraSalarial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.frmPlanillaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private dsMantenimientoPlanilla dsMantenimientoPlanilla1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lueCompania;
        private System.Windows.Forms.BindingSource companiaBindingSource;
        private DevExpress.XtraEditors.LookUpEdit lueMoneda;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}