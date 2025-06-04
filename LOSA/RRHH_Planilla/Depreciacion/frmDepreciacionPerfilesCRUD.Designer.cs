namespace LOSA.RRHH_Planilla.Depreciacion
{
    partial class frmDepreciacionPerfilesCRUD
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
            this.cmdBuscarEmpleado = new DevExpress.XtraEditors.SimpleButton();
            this.txtEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodeEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.txtMarca = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtModelo = new DevExpress.XtraEditors.TextEdit();
            this.txtPlaca = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.spinKm = new DevExpress.XtraEditors.SpinEdit();
            this.tsPeaje = new DevExpress.XtraEditors.ToggleSwitch();
            this.tsMante = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.tsActivo = new DevExpress.XtraEditors.ToggleSwitch();
            this.grdMoneda = new DevExpress.XtraEditors.GridLookUpEdit();
            this.monedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDepreciacion1 = new LOSA.RRHH_Planilla.Depreciacion.dsDepreciacion();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsymbol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcat_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtMontoFijo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinKm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsPeaje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsMante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monedaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepreciacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoFijo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdBuscarEmpleado
            // 
            this.cmdBuscarEmpleado.ImageOptions.Image = global::LOSA.Properties.Resources.search_32x32;
            this.cmdBuscarEmpleado.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdBuscarEmpleado.Location = new System.Drawing.Point(467, 35);
            this.cmdBuscarEmpleado.Name = "cmdBuscarEmpleado";
            this.cmdBuscarEmpleado.Size = new System.Drawing.Size(47, 33);
            this.cmdBuscarEmpleado.TabIndex = 128;
            this.cmdBuscarEmpleado.Tag = "Agregar Item o Servicio";
            this.cmdBuscarEmpleado.ToolTip = "Guardar";
            this.cmdBuscarEmpleado.Click += new System.EventHandler(this.cmdBuscarEmpleado_Click);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Enabled = false;
            this.txtEmpleado.Location = new System.Drawing.Point(196, 39);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleado.Properties.Appearance.Options.UseFont = true;
            this.txtEmpleado.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEmpleado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtEmpleado.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtEmpleado.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtEmpleado.Properties.MaskSettings.Set("mask", "d");
            this.txtEmpleado.Size = new System.Drawing.Size(256, 24);
            this.txtEmpleado.TabIndex = 127;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(37, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 17);
            this.labelControl1.TabIndex = 126;
            this.labelControl1.Text = "Empleado:";
            // 
            // txtCodeEmpleado
            // 
            this.txtCodeEmpleado.Enabled = false;
            this.txtCodeEmpleado.Location = new System.Drawing.Point(108, 39);
            this.txtCodeEmpleado.Name = "txtCodeEmpleado";
            this.txtCodeEmpleado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeEmpleado.Properties.Appearance.Options.UseFont = true;
            this.txtCodeEmpleado.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodeEmpleado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodeEmpleado.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCodeEmpleado.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtCodeEmpleado.Properties.MaskSettings.Set("mask", "d");
            this.txtCodeEmpleado.Size = new System.Drawing.Size(82, 24);
            this.txtCodeEmpleado.TabIndex = 125;
            // 
            // txtMarca
            // 
            this.txtMarca.EditValue = "";
            this.txtMarca.Location = new System.Drawing.Point(108, 85);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Properties.Appearance.Options.UseFont = true;
            this.txtMarca.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMarca.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtMarca.Properties.NullText = "0";
            this.txtMarca.Size = new System.Drawing.Size(154, 24);
            this.txtMarca.TabIndex = 130;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(37, 88);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 17);
            this.labelControl4.TabIndex = 129;
            this.labelControl4.Text = "Marca:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(37, 131);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 17);
            this.labelControl2.TabIndex = 131;
            this.labelControl2.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.EditValue = "";
            this.txtModelo.Location = new System.Drawing.Point(108, 128);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Properties.Appearance.Options.UseFont = true;
            this.txtModelo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtModelo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtModelo.Properties.NullText = "0";
            this.txtModelo.Size = new System.Drawing.Size(154, 24);
            this.txtModelo.TabIndex = 132;
            // 
            // txtPlaca
            // 
            this.txtPlaca.EditValue = "";
            this.txtPlaca.Location = new System.Drawing.Point(108, 178);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Properties.Appearance.Options.UseFont = true;
            this.txtPlaca.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPlaca.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPlaca.Properties.NullText = "0";
            this.txtPlaca.Size = new System.Drawing.Size(154, 24);
            this.txtPlaca.TabIndex = 134;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(37, 181);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 17);
            this.labelControl3.TabIndex = 133;
            this.labelControl3.Text = "Placa:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(37, 235);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(170, 17);
            this.labelControl5.TabIndex = 135;
            this.labelControl5.Text = "Distancia a Domicilio (Km):";
            // 
            // spinKm
            // 
            this.spinKm.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinKm.Location = new System.Drawing.Point(209, 232);
            this.spinKm.Name = "spinKm";
            this.spinKm.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.spinKm.Properties.Appearance.Options.UseFont = true;
            this.spinKm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinKm.Size = new System.Drawing.Size(111, 24);
            this.spinKm.TabIndex = 137;
            // 
            // tsPeaje
            // 
            this.tsPeaje.Location = new System.Drawing.Point(150, 283);
            this.tsPeaje.Name = "tsPeaje";
            this.tsPeaje.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tsPeaje.Properties.Appearance.Options.UseFont = true;
            this.tsPeaje.Properties.OffText = "No";
            this.tsPeaje.Properties.OnText = "Si";
            this.tsPeaje.Size = new System.Drawing.Size(95, 22);
            this.tsPeaje.TabIndex = 138;
            // 
            // tsMante
            // 
            this.tsMante.EditValue = true;
            this.tsMante.Location = new System.Drawing.Point(150, 328);
            this.tsMante.Name = "tsMante";
            this.tsMante.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tsMante.Properties.Appearance.Options.UseFont = true;
            this.tsMante.Properties.OffText = "No";
            this.tsMante.Properties.OnText = "Si";
            this.tsMante.Size = new System.Drawing.Size(95, 22);
            this.tsMante.TabIndex = 139;
            this.tsMante.Toggled += new System.EventHandler(this.tsMante_Toggled);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(37, 285);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 17);
            this.labelControl6.TabIndex = 140;
            this.labelControl6.Text = "Peaje:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(37, 330);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(99, 17);
            this.labelControl7.TabIndex = 141;
            this.labelControl7.Text = "Mantenimiento:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_24x24;
            this.simpleButton2.Location = new System.Drawing.Point(544, 330);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 46);
            this.simpleButton2.TabIndex = 143;
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
            this.btnSave.Location = new System.Drawing.Point(387, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 46);
            this.btnSave.TabIndex = 142;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(431, 282);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 17);
            this.labelControl8.TabIndex = 145;
            this.labelControl8.Text = "Activo:";
            // 
            // tsActivo
            // 
            this.tsActivo.EditValue = true;
            this.tsActivo.Location = new System.Drawing.Point(502, 280);
            this.tsActivo.Name = "tsActivo";
            this.tsActivo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tsActivo.Properties.Appearance.Options.UseFont = true;
            this.tsActivo.Properties.OffText = "No";
            this.tsActivo.Properties.OnText = "Si";
            this.tsActivo.Size = new System.Drawing.Size(95, 22);
            this.tsActivo.TabIndex = 144;
            // 
            // grdMoneda
            // 
            this.grdMoneda.Location = new System.Drawing.Point(502, 232);
            this.grdMoneda.Name = "grdMoneda";
            this.grdMoneda.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grdMoneda.Properties.Appearance.Options.UseFont = true;
            this.grdMoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdMoneda.Properties.DataSource = this.monedaBindingSource;
            this.grdMoneda.Properties.DisplayMember = "concat_";
            this.grdMoneda.Properties.NullText = "";
            this.grdMoneda.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdMoneda.Properties.ValueMember = "id";
            this.grdMoneda.Size = new System.Drawing.Size(125, 24);
            this.grdMoneda.TabIndex = 146;
            // 
            // monedaBindingSource
            // 
            this.monedaBindingSource.DataMember = "moneda";
            this.monedaBindingSource.DataSource = this.dsDepreciacion1;
            // 
            // dsDepreciacion1
            // 
            this.dsDepreciacion1.DataSetName = "dsDepreciacion";
            this.dsDepreciacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colsymbol,
            this.colconcat_});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            // 
            // colsymbol
            // 
            this.colsymbol.FieldName = "symbol";
            this.colsymbol.Name = "colsymbol";
            // 
            // colconcat_
            // 
            this.colconcat_.Caption = "Descripcion";
            this.colconcat_.FieldName = "concat_";
            this.colconcat_.Name = "colconcat_";
            this.colconcat_.Visible = true;
            this.colconcat_.VisibleIndex = 0;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(375, 235);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(108, 17);
            this.labelControl9.TabIndex = 147;
            this.labelControl9.Text = "Moneda de Pago:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(37, 372);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(72, 17);
            this.labelControl10.TabIndex = 148;
            this.labelControl10.Text = "Monto Fijo:";
            // 
            // txtMontoFijo
            // 
            this.txtMontoFijo.EditValue = "0.00";
            this.txtMontoFijo.Enabled = false;
            this.txtMontoFijo.Location = new System.Drawing.Point(150, 369);
            this.txtMontoFijo.Name = "txtMontoFijo";
            this.txtMontoFijo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMontoFijo.Properties.Appearance.Options.UseFont = true;
            this.txtMontoFijo.Properties.DisplayFormat.FormatString = "{0:#,###,##0.00} Lps";
            this.txtMontoFijo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMontoFijo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMontoFijo.Properties.MaskSettings.Set("mask", "c");
            this.txtMontoFijo.Size = new System.Drawing.Size(112, 24);
            this.txtMontoFijo.TabIndex = 149;
            // 
            // frmDepreciacionPerfilesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 413);
            this.Controls.Add(this.txtMontoFijo);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.grdMoneda);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.tsActivo);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.tsMante);
            this.Controls.Add(this.tsPeaje);
            this.Controls.Add(this.spinKm);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cmdBuscarEmpleado);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCodeEmpleado);
            this.Name = "frmDepreciacionPerfilesCRUD";
            this.Text = "Perfiles";
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinKm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsPeaje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsMante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monedaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepreciacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoFijo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton cmdBuscarEmpleado;
        private DevExpress.XtraEditors.TextEdit txtEmpleado;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCodeEmpleado;
        private DevExpress.XtraEditors.TextEdit txtMarca;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtModelo;
        private DevExpress.XtraEditors.TextEdit txtPlaca;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit spinKm;
        private DevExpress.XtraEditors.ToggleSwitch tsPeaje;
        private DevExpress.XtraEditors.ToggleSwitch tsMante;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ToggleSwitch tsActivo;
        private dsDepreciacion dsDepreciacion1;
        private DevExpress.XtraEditors.GridLookUpEdit grdMoneda;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.BindingSource monedaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colsymbol;
        private DevExpress.XtraGrid.Columns.GridColumn colconcat_;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtMontoFijo;
    }
}