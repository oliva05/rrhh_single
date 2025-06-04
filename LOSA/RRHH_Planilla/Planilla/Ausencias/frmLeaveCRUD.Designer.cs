namespace LOSA.RRHH_Planilla.Planilla.Ausencias
{
    partial class frmLeaveCRUD
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtInicio = new DevExpress.XtraEditors.DateEdit();
            this.deRegreso = new DevExpress.XtraEditors.DateEdit();
            this.dtFin = new DevExpress.XtraEditors.DateEdit();
            this.slueTipoAusencia = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bstipoausencia = new System.Windows.Forms.BindingSource(this.components);
            this.dsInasistencias1 = new LOSA.RRHH_Planilla.Planilla.Ausencias.dsInasistencias();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.categorialeaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtNote = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.seDiasVacaciones = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.tsAplicado = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRegreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRegreso.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueTipoAusencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstipoausencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInasistencias1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorialeaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDiasVacaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAplicado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(64, 134);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 20);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Fecha Inicio:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(81, 165);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 20);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Fecha Fin:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(45, 194);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(105, 20);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Fecha Regreso:";
            // 
            // dtInicio
            // 
            this.dtInicio.EditValue = null;
            this.dtInicio.Location = new System.Drawing.Point(158, 131);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtInicio.Properties.Appearance.Options.UseFont = true;
            this.dtInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtInicio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtInicio.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtInicio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtInicio.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dtInicio.Size = new System.Drawing.Size(179, 26);
            this.dtInicio.TabIndex = 3;
            this.dtInicio.EditValueChanged += new System.EventHandler(this.dtInicio_EditValueChanged);
            // 
            // deRegreso
            // 
            this.deRegreso.EditValue = null;
            this.deRegreso.Location = new System.Drawing.Point(158, 194);
            this.deRegreso.Name = "deRegreso";
            this.deRegreso.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.deRegreso.Properties.Appearance.Options.UseFont = true;
            this.deRegreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deRegreso.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deRegreso.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deRegreso.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deRegreso.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deRegreso.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deRegreso.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.deRegreso.Size = new System.Drawing.Size(179, 26);
            this.deRegreso.TabIndex = 5;
            this.deRegreso.EditValueChanged += new System.EventHandler(this.deRegreso_EditValueChanged);
            // 
            // dtFin
            // 
            this.dtFin.EditValue = null;
            this.dtFin.Location = new System.Drawing.Point(158, 162);
            this.dtFin.Name = "dtFin";
            this.dtFin.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtFin.Properties.Appearance.Options.UseFont = true;
            this.dtFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFin.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtFin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFin.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtFin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFin.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dtFin.Size = new System.Drawing.Size(179, 26);
            this.dtFin.TabIndex = 4;
            this.dtFin.EditValueChanged += new System.EventHandler(this.dtFin_EditValueChanged);
            // 
            // slueTipoAusencia
            // 
            this.slueTipoAusencia.Location = new System.Drawing.Point(158, 60);
            this.slueTipoAusencia.Name = "slueTipoAusencia";
            this.slueTipoAusencia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.slueTipoAusencia.Properties.Appearance.Options.UseFont = true;
            this.slueTipoAusencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueTipoAusencia.Properties.DataSource = this.bstipoausencia;
            this.slueTipoAusencia.Properties.DisplayMember = "name";
            this.slueTipoAusencia.Properties.NullText = "";
            this.slueTipoAusencia.Properties.PopupView = this.searchLookUpEdit1View;
            this.slueTipoAusencia.Properties.ValueMember = "id";
            this.slueTipoAusencia.Size = new System.Drawing.Size(271, 26);
            this.slueTipoAusencia.TabIndex = 1;
            this.slueTipoAusencia.EditValueChanged += new System.EventHandler(this.slueTipoAusencia_EditValueChanged);
            // 
            // bstipoausencia
            // 
            this.bstipoausencia.DataMember = "tipo_ausencia";
            this.bstipoausencia.DataSource = this.dsInasistencias1;
            // 
            // dsInasistencias1
            // 
            this.dsInasistencias1.DataSetName = "dsInasistencias";
            this.dsInasistencias1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colname
            // 
            this.colname.Caption = "Tipo";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(48, 65);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(102, 20);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "Tipo Ausencia:";
            // 
            // categorialeaveBindingSource
            // 
            this.categorialeaveBindingSource.DataMember = "categoria_leave";
            this.categorialeaveBindingSource.DataSource = this.dsInasistencias1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_24x24;
            this.simpleButton2.Location = new System.Drawing.Point(275, 375);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 46);
            this.simpleButton2.TabIndex = 36;
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
            this.btnSave.Location = new System.Drawing.Point(158, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 46);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(158, 262);
            this.txtNote.Name = "txtNote";
            this.txtNote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtNote.Properties.Appearance.Options.UseFont = true;
            this.txtNote.Size = new System.Drawing.Size(301, 96);
            this.txtNote.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(111, 263);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 20);
            this.labelControl6.TabIndex = 38;
            this.labelControl6.Text = "Nota:";
            // 
            // seDiasVacaciones
            // 
            this.seDiasVacaciones.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seDiasVacaciones.Location = new System.Drawing.Point(158, 227);
            this.seDiasVacaciones.Name = "seDiasVacaciones";
            this.seDiasVacaciones.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.seDiasVacaciones.Properties.Appearance.Options.UseFont = true;
            this.seDiasVacaciones.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seDiasVacaciones.Size = new System.Drawing.Size(179, 26);
            this.seDiasVacaciones.TabIndex = 40;
            this.seDiasVacaciones.EditValueChanged += new System.EventHandler(this.lblDias_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(37, 230);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(113, 20);
            this.labelControl8.TabIndex = 41;
            this.labelControl8.Text = "Dias Solicitados:";
            // 
            // tsAplicado
            // 
            this.tsAplicado.Location = new System.Drawing.Point(158, 100);
            this.tsAplicado.Name = "tsAplicado";
            this.tsAplicado.Properties.AllowThumbAnimation = false;
            this.tsAplicado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tsAplicado.Properties.Appearance.Options.UseFont = true;
            this.tsAplicado.Properties.OffText = "No";
            this.tsAplicado.Properties.OnText = "Si";
            this.tsAplicado.Size = new System.Drawing.Size(116, 24);
            this.tsAplicado.TabIndex = 43;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(10, 102);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(140, 20);
            this.labelControl7.TabIndex = 44;
            this.labelControl7.Text = "Aplicado en Planilla:";
            // 
            // frmLeaveCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 438);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.tsAplicado);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.seDiasVacaciones);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.slueTipoAusencia);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.deRegreso);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLeaveCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ausencia";
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRegreso.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRegreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueTipoAusencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstipoausencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInasistencias1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorialeaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDiasVacaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAplicado.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtInicio;
        private DevExpress.XtraEditors.DateEdit deRegreso;
        private DevExpress.XtraEditors.DateEdit dtFin;
        private DevExpress.XtraEditors.SearchLookUpEdit slueTipoAusencia;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.BindingSource bstipoausencia;
        private dsInasistencias dsInasistencias1;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private System.Windows.Forms.BindingSource categorialeaveBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.MemoEdit txtNote;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SpinEdit seDiasVacaciones;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ToggleSwitch tsAplicado;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}