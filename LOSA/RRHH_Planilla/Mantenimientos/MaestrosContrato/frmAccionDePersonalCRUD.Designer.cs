namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosContrato
{
    partial class frmAccionDePersonalCRUD
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deFechaEfectiva = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.slueTipoAcccion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblCambiante = new DevExpress.XtraEditors.LabelControl();
            this.txtSalarioNuevo = new DevExpress.XtraEditors.TextEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblAnterior = new DevExpress.XtraEditors.LabelControl();
            this.sluePuesto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bsacciondelpersonal = new System.Windows.Forms.BindingSource(this.components);
            this.dsContrato1 = new LOSA.RRHH_Planilla.Mantenimientos.MaestrosContrato.dsContrato();
            this.hrjobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEfectiva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEfectiva.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueTipoAcccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalarioNuevo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluePuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsacciondelpersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContrato1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrjobsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 15);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Fecha Efectiva";
            // 
            // deFechaEfectiva
            // 
            this.deFechaEfectiva.EditValue = null;
            this.deFechaEfectiva.Location = new System.Drawing.Point(117, 46);
            this.deFechaEfectiva.Name = "deFechaEfectiva";
            this.deFechaEfectiva.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.deFechaEfectiva.Properties.Appearance.Options.UseFont = true;
            this.deFechaEfectiva.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaEfectiva.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaEfectiva.Properties.EditFormat.FormatString = "";
            this.deFechaEfectiva.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFechaEfectiva.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.deFechaEfectiva.Properties.UseMaskAsDisplayFormat = true;
            this.deFechaEfectiva.Size = new System.Drawing.Size(178, 22);
            this.deFechaEfectiva.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(23, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 15);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tipo Acción";
            // 
            // slueTipoAcccion
            // 
            this.slueTipoAcccion.Location = new System.Drawing.Point(117, 77);
            this.slueTipoAcccion.Name = "slueTipoAcccion";
            this.slueTipoAcccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.slueTipoAcccion.Properties.Appearance.Options.UseFont = true;
            this.slueTipoAcccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueTipoAcccion.Properties.DataSource = this.bsacciondelpersonal;
            this.slueTipoAcccion.Properties.DisplayFormat.FormatString = "d";
            this.slueTipoAcccion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.slueTipoAcccion.Properties.DisplayMember = "descripcion";
            this.slueTipoAcccion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.slueTipoAcccion.Properties.NullText = "";
            this.slueTipoAcccion.Properties.PopupView = this.searchLookUpEdit1View;
            this.slueTipoAcccion.Properties.ValueMember = "id";
            this.slueTipoAcccion.Size = new System.Drawing.Size(178, 22);
            this.slueTipoAcccion.TabIndex = 1;
            this.slueTipoAcccion.EditValueChanged += new System.EventHandler(this.slueTipoAcccion_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // lblCambiante
            // 
            this.lblCambiante.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCambiante.Appearance.Options.UseFont = true;
            this.lblCambiante.Location = new System.Drawing.Point(23, 111);
            this.lblCambiante.Name = "lblCambiante";
            this.lblCambiante.Size = new System.Drawing.Size(36, 15);
            this.lblCambiante.TabIndex = 5;
            this.lblCambiante.Text = "Monto";
            this.lblCambiante.Visible = false;
            // 
            // txtSalarioNuevo
            // 
            this.txtSalarioNuevo.Location = new System.Drawing.Point(117, 108);
            this.txtSalarioNuevo.Name = "txtSalarioNuevo";
            this.txtSalarioNuevo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtSalarioNuevo.Properties.Appearance.Options.UseFont = true;
            this.txtSalarioNuevo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSalarioNuevo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSalarioNuevo.Properties.DisplayFormat.FormatString = "d";
            this.txtSalarioNuevo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtSalarioNuevo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtSalarioNuevo.Properties.NullText = "0";
            this.txtSalarioNuevo.Size = new System.Drawing.Size(178, 22);
            this.txtSalarioNuevo.TabIndex = 2;
            this.txtSalarioNuevo.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseBackColor = true;
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_24x24;
            this.btnCancelar.Location = new System.Drawing.Point(176, 213);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 46);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = global::LOSA.Properties.Resources.save_24x24;
            this.btnSave.Location = new System.Drawing.Point(59, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 46);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAnterior
            // 
            this.lblAnterior.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblAnterior.Appearance.Options.UseFont = true;
            this.lblAnterior.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAnterior.Location = new System.Drawing.Point(23, 178);
            this.lblAnterior.Name = "lblAnterior";
            this.lblAnterior.Size = new System.Drawing.Size(272, 15);
            this.lblAnterior.TabIndex = 6;
            this.lblAnterior.Text = "Salario Anterior";
            this.lblAnterior.Visible = false;
            // 
            // sluePuesto
            // 
            this.sluePuesto.Location = new System.Drawing.Point(117, 136);
            this.sluePuesto.Name = "sluePuesto";
            this.sluePuesto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.sluePuesto.Properties.Appearance.Options.UseFont = true;
            this.sluePuesto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sluePuesto.Properties.DataSource = this.hrjobsBindingSource;
            this.sluePuesto.Properties.DisplayFormat.FormatString = "d";
            this.sluePuesto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.sluePuesto.Properties.DisplayMember = "name";
            this.sluePuesto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.sluePuesto.Properties.NullText = "";
            this.sluePuesto.Properties.PopupView = this.gridView1;
            this.sluePuesto.Properties.ValueMember = "id";
            this.sluePuesto.Size = new System.Drawing.Size(178, 22);
            this.sluePuesto.TabIndex = 7;
            this.sluePuesto.Visible = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // bsacciondelpersonal
            // 
            this.bsacciondelpersonal.DataMember = "accion_del_personal";
            this.bsacciondelpersonal.DataSource = this.dsContrato1;
            // 
            // dsContrato1
            // 
            this.dsContrato1.DataSetName = "dsContrato";
            this.dsContrato1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hrjobsBindingSource
            // 
            this.hrjobsBindingSource.DataMember = "hr_jobs";
            this.hrjobsBindingSource.DataSource = this.dsContrato1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Puesto";
            this.gridColumn2.FieldName = "name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tipo";
            this.gridColumn1.FieldName = "descripcion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // frmAccionDePersonalCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 282);
            this.Controls.Add(this.sluePuesto);
            this.Controls.Add(this.lblAnterior);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCambiante);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.deFechaEfectiva);
            this.Controls.Add(this.slueTipoAcccion);
            this.Controls.Add(this.txtSalarioNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccionDePersonalCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acción del Personal";
            this.Load += new System.EventHandler(this.frmAccionDePersonalCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEfectiva.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEfectiva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueTipoAcccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalarioNuevo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluePuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsacciondelpersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContrato1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrjobsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit deFechaEfectiva;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit slueTipoAcccion;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl lblCambiante;
        private DevExpress.XtraEditors.TextEdit txtSalarioNuevo;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.BindingSource bsacciondelpersonal;
        private dsContrato dsContrato1;
        private DevExpress.XtraEditors.LabelControl lblAnterior;
        private DevExpress.XtraEditors.SearchLookUpEdit sluePuesto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.BindingSource hrjobsBindingSource;
    }
}