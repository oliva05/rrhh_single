﻿namespace LOSA.Mantenimientos
{
    partial class frmTipoPresentacionCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoPresentacionCRUD));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.memoDescripcion = new DevExpress.XtraEditors.MemoEdit();
            this.chkEnable = new DevExpress.XtraEditors.CheckEdit();
            this.txtFactor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(100, 24);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Descripción";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGuardar.Location = new System.Drawing.Point(16, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 47);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(445, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(127, 47);
            this.btnAtras.TabIndex = 24;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // memoDescripcion
            // 
            this.memoDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoDescripcion.Location = new System.Drawing.Point(12, 130);
            this.memoDescripcion.Name = "memoDescripcion";
            this.memoDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoDescripcion.Properties.Appearance.Options.UseFont = true;
            this.memoDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.memoDescripcion.Properties.MaxLength = 30;
            this.memoDescripcion.Size = new System.Drawing.Size(417, 86);
            this.memoDescripcion.TabIndex = 0;
            this.memoDescripcion.EditValueChanged += new System.EventHandler(this.memoDescripcion_EditValueChanged);
            // 
            // chkEnable
            // 
            this.chkEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEnable.Location = new System.Drawing.Point(492, 140);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.chkEnable.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.chkEnable.Properties.Appearance.Options.UseBackColor = true;
            this.chkEnable.Properties.Appearance.Options.UseFont = true;
            this.chkEnable.Properties.AutoHeight = false;
            this.chkEnable.Properties.Caption = "Enable";
            this.chkEnable.Size = new System.Drawing.Size(80, 28);
            this.chkEnable.TabIndex = 27;
            // 
            // txtFactor
            // 
            this.txtFactor.Location = new System.Drawing.Point(13, 289);
            this.txtFactor.Name = "txtFactor";
            this.txtFactor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtFactor.Properties.Appearance.Options.UseFont = true;
            this.txtFactor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtFactor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtFactor.Properties.Mask.EditMask = "n";
            this.txtFactor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFactor.Properties.NullText = "0";
            this.txtFactor.Size = new System.Drawing.Size(165, 32);
            this.txtFactor.TabIndex = 28;
            this.txtFactor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextEdit1_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 259);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 24);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Factor";
            // 
            // frmTipoPresentacionCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 375);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtFactor);
            this.Controls.Add(this.chkEnable);
            this.Controls.Add(this.memoDescripcion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTipoPresentacionCRUD";
            this.Text = "frmTipoPresentacionCRUD";
            this.Load += new System.EventHandler(this.frmTipoPresentacionCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memoDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.MemoEdit memoDescripcion;
        private DevExpress.XtraEditors.CheckEdit chkEnable;
        private DevExpress.XtraEditors.TextEdit txtFactor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}