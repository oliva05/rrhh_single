namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    partial class frmNewItemBasic
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
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcionCorta = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionCorta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Image = global::LOSA.Properties.Resources.Danieledesantis_Playstation_Flat_Playstation_cross_black_and_white_24;
            this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(239, 100);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(86, 33);
            this.cmdCerrar.TabIndex = 46;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Image = global::LOSA.Properties.Resources.Custom_Save_24;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(135, 100);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(86, 33);
            this.cmdGuardar.TabIndex = 45;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 15);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "Nombre/Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(130, 33);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Size = new System.Drawing.Size(298, 22);
            this.txtDescripcion.TabIndex = 47;
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 15);
            this.labelControl2.TabIndex = 50;
            this.labelControl2.Text = "Nombre Corto";
            // 
            // txtDescripcionCorta
            // 
            this.txtDescripcionCorta.Location = new System.Drawing.Point(130, 61);
            this.txtDescripcionCorta.Name = "txtDescripcionCorta";
            this.txtDescripcionCorta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtDescripcionCorta.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcionCorta.Size = new System.Drawing.Size(298, 22);
            this.txtDescripcionCorta.TabIndex = 49;
            // 
            // frmNewItemBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 145);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtDescripcionCorta);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdGuardar);
            this.Name = "frmNewItemBasic";
            this.Text = "frmNewItemBasic";
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionCorta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Button cmdGuardar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDescripcionCorta;
    }
}