namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    partial class frmNewDIreccionPrivada
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
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.lblNombreEmpleado = new DevExpress.XtraEditors.LabelControl();
            this.txtStreet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.txtDireccionName = new DevExpress.XtraEditors.MemoEdit();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtStreet2 = new DevExpress.XtraEditors.TextEdit();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtStreet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStreet2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Appearance.Options.UseFont = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 27);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 21);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "AQ000";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Appearance.Options.UseFont = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(97, 27);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(119, 21);
            this.lblNombreEmpleado.TabIndex = 5;
            this.lblNombreEmpleado.Text = "Employee Name";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(116, 230);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtStreet.Properties.Appearance.Options.UseFont = true;
            this.txtStreet.Size = new System.Drawing.Size(382, 22);
            this.txtStreet.TabIndex = 38;
            this.txtStreet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStreet_KeyDown);
            this.txtStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStreet_KeyPress);
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Location = new System.Drawing.Point(7, 74);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(51, 15);
            this.labelControl21.TabIndex = 37;
            this.labelControl21.Text = "Dirección";
            // 
            // txtDireccionName
            // 
            this.txtDireccionName.Location = new System.Drawing.Point(116, 68);
            this.txtDireccionName.Name = "txtDireccionName";
            this.txtDireccionName.Size = new System.Drawing.Size(382, 156);
            this.txtDireccionName.TabIndex = 39;
            this.txtDireccionName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDireccionName_KeyDown);
            this.txtDireccionName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccionName_KeyPress);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 233);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 15);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Bloque/Lote";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 261);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 15);
            this.labelControl2.TabIndex = 42;
            this.labelControl2.Text = "Punto de referencia";
            // 
            // txtStreet2
            // 
            this.txtStreet2.Location = new System.Drawing.Point(116, 258);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtStreet2.Properties.Appearance.Options.UseFont = true;
            this.txtStreet2.Size = new System.Drawing.Size(382, 22);
            this.txtStreet2.TabIndex = 41;
            this.txtStreet2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStreet2_KeyDown);
            this.txtStreet2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStreet2_KeyPress);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Image = global::LOSA.Properties.Resources.Custom_Save_24;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(153, 287);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(86, 33);
            this.cmdGuardar.TabIndex = 43;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Image = global::LOSA.Properties.Resources.Danieledesantis_Playstation_Flat_Playstation_cross_black_and_white_24;
            this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(257, 287);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(86, 33);
            this.cmdCerrar.TabIndex = 44;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmNewDIreccionPrivada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 332);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtStreet2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDireccionName);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.labelControl21);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Name = "frmNewDIreccionPrivada";
            this.Text = "Nueva Dirección";
            this.Activated += new System.EventHandler(this.frmNewDIreccionPrivada_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.txtStreet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStreet2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.LabelControl lblNombreEmpleado;
        private DevExpress.XtraEditors.TextEdit txtStreet;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.MemoEdit txtDireccionName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtStreet2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCerrar;
    }
}