namespace LOSA.Logistica.CheckList
{
    partial class frmDialogResult
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
            this.btnYes = new DevExpress.XtraEditors.SimpleButton();
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            this.lblMessage = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnYes.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Appearance.Options.UseBackColor = true;
            this.btnYes.Appearance.Options.UseFont = true;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Location = new System.Drawing.Point(134, 115);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(107, 55);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Si";
            // 
            // btnNo
            // 
            this.btnNo.Appearance.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNo.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Appearance.Options.UseBackColor = true;
            this.btnNo.Appearance.Options.UseFont = true;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Location = new System.Drawing.Point(258, 115);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(107, 55);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            // 
            // lblMessage
            // 
            this.lblMessage.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Appearance.Options.UseFont = true;
            this.lblMessage.Appearance.Options.UseTextOptions = true;
            this.lblMessage.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblMessage.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblMessage.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMessage.Location = new System.Drawing.Point(36, 26);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(434, 72);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "labelControl1";
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnOK.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseBackColor = true;
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(380, 115);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 55);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            // 
            // frmDialogResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 183);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDialogResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inspección";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnYes;
        private DevExpress.XtraEditors.SimpleButton btnNo;
        private DevExpress.XtraEditors.LabelControl lblMessage;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}