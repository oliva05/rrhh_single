namespace LOSA.RRHH_Planilla.Mantenimientos
{
    partial class frmPlanillaCategoria
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
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCategoria = new DevExpress.XtraEditors.TextEdit();
            this.ceProvision = new DevExpress.XtraEditors.CheckEdit();
            this.cePatronal = new DevExpress.XtraEditors.CheckEdit();
            this.ceDeducible = new DevExpress.XtraEditors.CheckEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNota = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceProvision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePatronal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceDeducible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(109, 50);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Properties.Appearance.Options.UseFont = true;
            this.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Size = new System.Drawing.Size(236, 24);
            this.txtCode.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(55, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Código:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(40, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Categoría:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(109, 80);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Properties.Appearance.Options.UseFont = true;
            this.txtCategoria.Size = new System.Drawing.Size(236, 24);
            this.txtCategoria.TabIndex = 1;
            // 
            // ceProvision
            // 
            this.ceProvision.Location = new System.Drawing.Point(28, 8);
            this.ceProvision.Name = "ceProvision";
            this.ceProvision.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceProvision.Properties.Appearance.Options.UseFont = true;
            this.ceProvision.Properties.Caption = "Provisional";
            this.ceProvision.Size = new System.Drawing.Size(101, 21);
            this.ceProvision.TabIndex = 3;
            this.ceProvision.Visible = false;
            // 
            // cePatronal
            // 
            this.cePatronal.Location = new System.Drawing.Point(109, 177);
            this.cePatronal.Name = "cePatronal";
            this.cePatronal.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cePatronal.Properties.Appearance.Options.UseFont = true;
            this.cePatronal.Properties.Caption = "es Patronal?";
            this.cePatronal.Size = new System.Drawing.Size(101, 21);
            this.cePatronal.TabIndex = 4;
            // 
            // ceDeducible
            // 
            this.ceDeducible.Location = new System.Drawing.Point(28, 26);
            this.ceDeducible.Name = "ceDeducible";
            this.ceDeducible.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceDeducible.Properties.Appearance.Options.UseFont = true;
            this.ceDeducible.Properties.Caption = "ISR Deducible";
            this.ceDeducible.Size = new System.Drawing.Size(130, 21);
            this.ceDeducible.TabIndex = 5;
            this.ceDeducible.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = global::LOSA.Properties.Resources.save_24x24;
            this.btnSave.Location = new System.Drawing.Point(84, 218);
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
            this.simpleButton2.Location = new System.Drawing.Point(201, 218);
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
            this.labelControl3.Location = new System.Drawing.Point(149, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(118, 25);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Regla Salarial";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(109, 110);
            this.txtNota.Name = "txtNota";
            this.txtNota.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Properties.Appearance.Options.UseFont = true;
            this.txtNota.Size = new System.Drawing.Size(236, 61);
            this.txtNota.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(69, 112);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 17);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Nota:";
            // 
            // frmPlanillaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 279);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ceDeducible);
            this.Controls.Add(this.cePatronal);
            this.Controls.Add(this.ceProvision);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlanillaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regla Salarial";
            this.Load += new System.EventHandler(this.frmPlanillaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceProvision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePatronal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceDeducible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCategoria;
        private DevExpress.XtraEditors.CheckEdit ceProvision;
        private DevExpress.XtraEditors.CheckEdit cePatronal;
        private DevExpress.XtraEditors.CheckEdit ceDeducible;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txtNota;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}