namespace LOSA.RRHH_Planilla.Mantenimientos.ContratoRRHH
{
    partial class frmAddAjusteISR_Contrato
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
            this.lblSalarioMensual = new DevExpress.XtraEditors.LabelControl();
            this.lblEmpleado = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmdAgregarAjuste = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.spinEditAnio = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditCantCuotas = new DevExpress.XtraEditors.SpinEdit();
            this.txtISR_Deducido = new DevExpress.XtraEditors.TextEdit();
            this.txtIngresosDevengados = new DevExpress.XtraEditors.TextEdit();
            this.txtAFP_Deducido = new DevExpress.XtraEditors.TextEdit();
            this.errorISRDeducido = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblHabilitado = new DevExpress.XtraEditors.LabelControl();
            this.tggEnable = new DevExpress.XtraEditors.ToggleSwitch();
            this.errorDevengado = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAFP_Deducido = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAnio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCantCuotas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtISR_Deducido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngresosDevengados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAFP_Deducido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorISRDeducido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggEnable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDevengado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAFP_Deducido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalarioMensual
            // 
            this.lblSalarioMensual.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioMensual.Appearance.Options.UseFont = true;
            this.lblSalarioMensual.Location = new System.Drawing.Point(105, 12);
            this.lblSalarioMensual.Name = "lblSalarioMensual";
            this.lblSalarioMensual.Size = new System.Drawing.Size(202, 17);
            this.lblSalarioMensual.TabIndex = 1;
            this.lblSalarioMensual.Text = "Agregar Saldos iniciales para ISR";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblEmpleado.Appearance.Options.UseFont = true;
            this.lblEmpleado.Location = new System.Drawing.Point(12, 51);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(90, 15);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Empleado Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 83);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 17);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Año";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 119);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Cantidad Cuotas";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 158);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 17);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "ISR Deducido";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 196);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(132, 17);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Ingresos Devengados";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 232);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(87, 17);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "AFP Deducido";
            // 
            // cmdAgregarAjuste
            // 
            this.cmdAgregarAjuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAgregarAjuste.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregarAjuste.Image = global::LOSA.Properties.Resources.boton_mas24px2;
            this.cmdAgregarAjuste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAgregarAjuste.Location = new System.Drawing.Point(105, 297);
            this.cmdAgregarAjuste.Name = "cmdAgregarAjuste";
            this.cmdAgregarAjuste.Size = new System.Drawing.Size(100, 33);
            this.cmdAgregarAjuste.TabIndex = 137;
            this.cmdAgregarAjuste.Text = "Agregar";
            this.cmdAgregarAjuste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAgregarAjuste.UseVisualStyleBackColor = true;
            this.cmdAgregarAjuste.Click += new System.EventHandler(this.cmdAgregarAjuste_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Image = global::LOSA.Properties.Resources.Danieledesantis_Playstation_Flat_Playstation_cross_black_and_white_24;
            this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(207, 297);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(100, 33);
            this.cmdCerrar.TabIndex = 136;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // spinEditAnio
            // 
            this.spinEditAnio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditAnio.Location = new System.Drawing.Point(183, 83);
            this.spinEditAnio.Name = "spinEditAnio";
            this.spinEditAnio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEditAnio.Properties.Appearance.Options.UseFont = true;
            this.spinEditAnio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditAnio.Size = new System.Drawing.Size(100, 20);
            this.spinEditAnio.TabIndex = 138;
            this.spinEditAnio.EditValueChanged += new System.EventHandler(this.spinEditAnio_EditValueChanged);
            // 
            // spinEditCantCuotas
            // 
            this.spinEditCantCuotas.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditCantCuotas.Location = new System.Drawing.Point(183, 119);
            this.spinEditCantCuotas.Name = "spinEditCantCuotas";
            this.spinEditCantCuotas.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEditCantCuotas.Properties.Appearance.Options.UseFont = true;
            this.spinEditCantCuotas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditCantCuotas.Size = new System.Drawing.Size(100, 20);
            this.spinEditCantCuotas.TabIndex = 139;
            this.spinEditCantCuotas.EditValueChanged += new System.EventHandler(this.spinEditCantCuotas_EditValueChanged);
            // 
            // txtISR_Deducido
            // 
            this.txtISR_Deducido.Location = new System.Drawing.Point(183, 158);
            this.txtISR_Deducido.Name = "txtISR_Deducido";
            this.txtISR_Deducido.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtISR_Deducido.Properties.Appearance.Options.UseFont = true;
            this.txtISR_Deducido.Properties.DisplayFormat.FormatString = "n2";
            this.txtISR_Deducido.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtISR_Deducido.Properties.EditFormat.FormatString = "n2";
            this.txtISR_Deducido.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtISR_Deducido.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtISR_Deducido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtISR_Deducido.Size = new System.Drawing.Size(100, 20);
            this.txtISR_Deducido.TabIndex = 140;
            this.txtISR_Deducido.EditValueChanged += new System.EventHandler(this.txtISR_Deducido_EditValueChanged);
            // 
            // txtIngresosDevengados
            // 
            this.txtIngresosDevengados.Location = new System.Drawing.Point(183, 196);
            this.txtIngresosDevengados.Name = "txtIngresosDevengados";
            this.txtIngresosDevengados.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtIngresosDevengados.Properties.Appearance.Options.UseFont = true;
            this.txtIngresosDevengados.Properties.DisplayFormat.FormatString = "n2";
            this.txtIngresosDevengados.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtIngresosDevengados.Properties.EditFormat.FormatString = "n2";
            this.txtIngresosDevengados.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtIngresosDevengados.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtIngresosDevengados.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIngresosDevengados.Size = new System.Drawing.Size(100, 20);
            this.txtIngresosDevengados.TabIndex = 141;
            this.txtIngresosDevengados.EditValueChanged += new System.EventHandler(this.txtIngresosDevengados_EditValueChanged);
            // 
            // txtAFP_Deducido
            // 
            this.txtAFP_Deducido.Location = new System.Drawing.Point(183, 232);
            this.txtAFP_Deducido.Name = "txtAFP_Deducido";
            this.txtAFP_Deducido.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtAFP_Deducido.Properties.Appearance.Options.UseFont = true;
            this.txtAFP_Deducido.Properties.DisplayFormat.FormatString = "n2";
            this.txtAFP_Deducido.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAFP_Deducido.Properties.EditFormat.FormatString = "n2";
            this.txtAFP_Deducido.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAFP_Deducido.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtAFP_Deducido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAFP_Deducido.Size = new System.Drawing.Size(100, 20);
            this.txtAFP_Deducido.TabIndex = 142;
            this.txtAFP_Deducido.EditValueChanged += new System.EventHandler(this.txtAFP_Deducido_EditValueChanged);
            // 
            // errorISRDeducido
            // 
            this.errorISRDeducido.ContainerControl = this;
            // 
            // lblHabilitado
            // 
            this.lblHabilitado.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabilitado.Appearance.Options.UseFont = true;
            this.lblHabilitado.Location = new System.Drawing.Point(12, 266);
            this.lblHabilitado.Name = "lblHabilitado";
            this.lblHabilitado.Size = new System.Drawing.Size(65, 17);
            this.lblHabilitado.TabIndex = 143;
            this.lblHabilitado.Text = "Habilitado";
            // 
            // tggEnable
            // 
            this.tggEnable.EditValue = true;
            this.tggEnable.Location = new System.Drawing.Point(183, 266);
            this.tggEnable.Name = "tggEnable";
            this.tggEnable.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tggEnable.Properties.Appearance.Options.UseFont = true;
            this.tggEnable.Properties.OffText = "No";
            this.tggEnable.Properties.OnText = "Si";
            this.tggEnable.Size = new System.Drawing.Size(95, 19);
            this.tggEnable.TabIndex = 144;
            // 
            // errorDevengado
            // 
            this.errorDevengado.ContainerControl = this;
            // 
            // errorAFP_Deducido
            // 
            this.errorAFP_Deducido.ContainerControl = this;
            // 
            // frmAddAjusteISR_Contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 333);
            this.Controls.Add(this.tggEnable);
            this.Controls.Add(this.lblHabilitado);
            this.Controls.Add(this.txtAFP_Deducido);
            this.Controls.Add(this.txtIngresosDevengados);
            this.Controls.Add(this.txtISR_Deducido);
            this.Controls.Add(this.spinEditCantCuotas);
            this.Controls.Add(this.spinEditAnio);
            this.Controls.Add(this.cmdAgregarAjuste);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblSalarioMensual);
            this.Name = "frmAddAjusteISR_Contrato";
            this.Text = "Ajuste ISR ";
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAnio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCantCuotas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtISR_Deducido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngresosDevengados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAFP_Deducido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorISRDeducido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggEnable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDevengado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAFP_Deducido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblSalarioMensual;
        private DevExpress.XtraEditors.LabelControl lblEmpleado;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Button cmdAgregarAjuste;
        private System.Windows.Forms.Button cmdCerrar;
        private DevExpress.XtraEditors.SpinEdit spinEditAnio;
        private DevExpress.XtraEditors.SpinEdit spinEditCantCuotas;
        private DevExpress.XtraEditors.TextEdit txtISR_Deducido;
        private DevExpress.XtraEditors.TextEdit txtIngresosDevengados;
        private DevExpress.XtraEditors.TextEdit txtAFP_Deducido;
        private System.Windows.Forms.ErrorProvider errorISRDeducido;
        private DevExpress.XtraEditors.ToggleSwitch tggEnable;
        private DevExpress.XtraEditors.LabelControl lblHabilitado;
        private System.Windows.Forms.ErrorProvider errorDevengado;
        private System.Windows.Forms.ErrorProvider errorAFP_Deducido;
    }
}