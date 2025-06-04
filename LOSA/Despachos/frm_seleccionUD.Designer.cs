﻿namespace LOSA.Despachos
{
    partial class frm_seleccionUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_seleccionUD));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnidades = new DevExpress.XtraEditors.TextEdit();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.btnUP = new DevExpress.XtraEditors.SimpleButton();
            this.btnDown = new DevExpress.XtraEditors.SimpleButton();
            this.lblPendiente = new DevExpress.XtraEditors.LabelControl();
            this.txtPendiente = new DevExpress.XtraEditors.TextEdit();
            this.txtEnTarima = new DevExpress.XtraEditors.TextEdit();
            this.lblEnTarima = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPendiente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnTarima.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 128);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 32);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Unidades:";
            // 
            // txtUnidades
            // 
            this.txtUnidades.EditValue = "0";
            this.txtUnidades.Enabled = false;
            this.txtUnidades.Location = new System.Drawing.Point(184, 125);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidades.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtUnidades.Properties.Appearance.Options.UseFont = true;
            this.txtUnidades.Properties.Appearance.Options.UseForeColor = true;
            this.txtUnidades.Size = new System.Drawing.Size(167, 56);
            this.txtUnidades.TabIndex = 2;
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(357, 3);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(200, 71);
            this.cmdHome.TabIndex = 7;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Appearance.Options.UseFont = true;
            this.btnConfirmar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.ImageOptions.Image")));
            this.btnConfirmar.Location = new System.Drawing.Point(165, 221);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(221, 61);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnUP
            // 
            this.btnUP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUP.ImageOptions.Image")));
            this.btnUP.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnUP.Location = new System.Drawing.Point(357, 107);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(123, 45);
            this.btnUP.TabIndex = 9;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnDown
            // 
            this.btnDown.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.ImageOptions.Image")));
            this.btnDown.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDown.Location = new System.Drawing.Point(357, 158);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(123, 45);
            this.btnDown.TabIndex = 10;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lblPendiente
            // 
            this.lblPendiente.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendiente.Appearance.Options.UseFont = true;
            this.lblPendiente.Location = new System.Drawing.Point(30, 4);
            this.lblPendiente.Name = "lblPendiente";
            this.lblPendiente.Size = new System.Drawing.Size(122, 32);
            this.lblPendiente.TabIndex = 11;
            this.lblPendiente.Text = "Pendiente:";
            this.lblPendiente.Visible = false;
            // 
            // txtPendiente
            // 
            this.txtPendiente.EditValue = "0";
            this.txtPendiente.Enabled = false;
            this.txtPendiente.Location = new System.Drawing.Point(184, 1);
            this.txtPendiente.Name = "txtPendiente";
            this.txtPendiente.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPendiente.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPendiente.Properties.Appearance.Options.UseFont = true;
            this.txtPendiente.Properties.Appearance.Options.UseForeColor = true;
            this.txtPendiente.Size = new System.Drawing.Size(167, 56);
            this.txtPendiente.TabIndex = 12;
            this.txtPendiente.Visible = false;
            // 
            // txtEnTarima
            // 
            this.txtEnTarima.EditValue = "0";
            this.txtEnTarima.Enabled = false;
            this.txtEnTarima.Location = new System.Drawing.Point(184, 63);
            this.txtEnTarima.Name = "txtEnTarima";
            this.txtEnTarima.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnTarima.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtEnTarima.Properties.Appearance.Options.UseFont = true;
            this.txtEnTarima.Properties.Appearance.Options.UseForeColor = true;
            this.txtEnTarima.Size = new System.Drawing.Size(167, 56);
            this.txtEnTarima.TabIndex = 13;
            this.txtEnTarima.Visible = false;
            // 
            // lblEnTarima
            // 
            this.lblEnTarima.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnTarima.Appearance.Options.UseFont = true;
            this.lblEnTarima.Location = new System.Drawing.Point(29, 66);
            this.lblEnTarima.Name = "lblEnTarima";
            this.lblEnTarima.Size = new System.Drawing.Size(121, 32);
            this.lblEnTarima.TabIndex = 14;
            this.lblEnTarima.Text = "En Tarima:";
            this.lblEnTarima.Visible = false;
            // 
            // frm_seleccionUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 309);
            this.Controls.Add(this.lblEnTarima);
            this.Controls.Add(this.txtEnTarima);
            this.Controls.Add(this.txtPendiente);
            this.Controls.Add(this.lblPendiente);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.labelControl1);
            this.Name = "frm_seleccionUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_seleccionUD";
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPendiente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnTarima.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUnidades;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.SimpleButton btnConfirmar;
        private DevExpress.XtraEditors.SimpleButton btnUP;
        private DevExpress.XtraEditors.SimpleButton btnDown;
        private DevExpress.XtraEditors.LabelControl lblPendiente;
        private DevExpress.XtraEditors.TextEdit txtPendiente;
        private DevExpress.XtraEditors.TextEdit txtEnTarima;
        private DevExpress.XtraEditors.LabelControl lblEnTarima;
    }
}