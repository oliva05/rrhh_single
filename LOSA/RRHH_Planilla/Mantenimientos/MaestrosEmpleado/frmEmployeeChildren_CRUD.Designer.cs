namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    partial class frmEmployeeChildren_CRUD
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
            this.cbxGenero = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.deFechaNacimiento = new DevExpress.XtraEditors.DateEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGenero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaNacimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaNacimiento.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxGenero
            // 
            this.cbxGenero.Location = new System.Drawing.Point(165, 48);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGenero.Properties.Appearance.Options.UseFont = true;
            this.cbxGenero.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGenero.Properties.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbxGenero.Size = new System.Drawing.Size(131, 24);
            this.cbxGenero.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Género________________:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(26, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(133, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Fecha de Nacimiento:";
            // 
            // deFechaNacimiento
            // 
            this.deFechaNacimiento.EditValue = null;
            this.deFechaNacimiento.Location = new System.Drawing.Point(165, 87);
            this.deFechaNacimiento.Name = "deFechaNacimiento";
            this.deFechaNacimiento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deFechaNacimiento.Properties.Appearance.Options.UseFont = true;
            this.deFechaNacimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaNacimiento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaNacimiento.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deFechaNacimiento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFechaNacimiento.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.deFechaNacimiento.Size = new System.Drawing.Size(131, 22);
            this.deFechaNacimiento.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_24x24;
            this.btnClose.Location = new System.Drawing.Point(177, 139);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 46);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Cancelar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = global::LOSA.Properties.Resources.save_24x24;
            this.btnSave.Location = new System.Drawing.Point(60, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 46);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(82, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(158, 21);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Información del Hijo";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // frmEmployeeChildren_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 211);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.deFechaNacimiento);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbxGenero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployeeChildren_CRUD";
            this.Text = "Hijo";
            this.Load += new System.EventHandler(this.frmEmployeeChildren_CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbxGenero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaNacimiento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaNacimiento.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbxGenero;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit deFechaNacimiento;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}