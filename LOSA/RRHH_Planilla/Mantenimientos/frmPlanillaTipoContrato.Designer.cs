namespace LOSA.RRHH_Planilla.Mantenimientos
{
    partial class frmPlanillaTipoContrato
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
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSecuencia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.cbSchedulePay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.slueHorasTrabajo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.rescalendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMantenimientoPlanilla = new LOSA.RRHH_Planilla.Mantenimientos.dsMantenimientoPlanilla();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.slueHorasTrabVac = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.slueConfVacaciones = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.hrvacationconfiguratiionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.slueContratoFormato = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.hrcontractformatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecuencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSchedulePay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueHorasTrabajo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rescalendarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueHorasTrabVac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueConfVacaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrvacationconfiguratiionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueContratoFormato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrcontractformatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(165, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(276, 24);
            this.txtNombre.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(105, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nombre:";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = global::LOSA.Properties.Resources.save_24x24;
            this.btnSave.Location = new System.Drawing.Point(156, 276);
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
            this.simpleButton2.Location = new System.Drawing.Point(273, 276);
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
            this.labelControl3.Location = new System.Drawing.Point(183, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(125, 25);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Tipo Contrato";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(95, 80);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 17);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Secuencia:";
            // 
            // txtSecuencia
            // 
            this.txtSecuencia.Location = new System.Drawing.Point(165, 77);
            this.txtSecuencia.Name = "txtSecuencia";
            this.txtSecuencia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecuencia.Properties.Appearance.Options.UseFont = true;
            this.txtSecuencia.Size = new System.Drawing.Size(276, 24);
            this.txtSecuencia.TabIndex = 14;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(50, 110);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(109, 17);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Conf. Vacaciones:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(49, 140);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(110, 17);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "Horas de Trabajo:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(13, 162);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(146, 30);
            this.labelControl9.TabIndex = 21;
            this.labelControl9.Text = "Hora Trab. Vacaciones:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(58, 201);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(104, 17);
            this.labelControl10.TabIndex = 25;
            this.labelControl10.Text = "Programar Pago:";
            // 
            // cbSchedulePay
            // 
            this.cbSchedulePay.EditValue = "";
            this.cbSchedulePay.Location = new System.Drawing.Point(165, 198);
            this.cbSchedulePay.Name = "cbSchedulePay";
            this.cbSchedulePay.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSchedulePay.Properties.Appearance.Options.UseFont = true;
            this.cbSchedulePay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSchedulePay.Properties.Items.AddRange(new object[] {
            "Semanal",
            "Bi-Semanal",
            "Mensual",
            "Anual"});
            this.cbSchedulePay.Properties.NullText = " ";
            this.cbSchedulePay.Properties.NullValuePrompt = " ";
            this.cbSchedulePay.Properties.PopupSizeable = true;
            this.cbSchedulePay.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSchedulePay.Size = new System.Drawing.Size(276, 24);
            this.cbSchedulePay.TabIndex = 24;
            // 
            // slueHorasTrabajo
            // 
            this.slueHorasTrabajo.Location = new System.Drawing.Point(165, 137);
            this.slueHorasTrabajo.Name = "slueHorasTrabajo";
            this.slueHorasTrabajo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slueHorasTrabajo.Properties.Appearance.Options.UseFont = true;
            this.slueHorasTrabajo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueHorasTrabajo.Properties.DataSource = this.rescalendarBindingSource;
            this.slueHorasTrabajo.Properties.DisplayMember = "name";
            this.slueHorasTrabajo.Properties.NullText = "";
            this.slueHorasTrabajo.Properties.PopupView = this.searchLookUpEdit1View;
            this.slueHorasTrabajo.Properties.ValueMember = "id";
            this.slueHorasTrabajo.Size = new System.Drawing.Size(276, 24);
            this.slueHorasTrabajo.TabIndex = 18;
            // 
            // rescalendarBindingSource
            // 
            this.rescalendarBindingSource.DataMember = "res_calendar";
            this.rescalendarBindingSource.DataSource = this.dsMantenimientoPlanilla;
            // 
            // dsMantenimientoPlanilla
            // 
            this.dsMantenimientoPlanilla.DataSetName = "dsMantenimientoPlanilla";
            this.dsMantenimientoPlanilla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nombre";
            this.gridColumn1.FieldName = "name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Horas Por Dia";
            this.gridColumn2.FieldName = "hours_per_day";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // slueHorasTrabVac
            // 
            this.slueHorasTrabVac.Location = new System.Drawing.Point(165, 168);
            this.slueHorasTrabVac.Name = "slueHorasTrabVac";
            this.slueHorasTrabVac.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slueHorasTrabVac.Properties.Appearance.Options.UseFont = true;
            this.slueHorasTrabVac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueHorasTrabVac.Properties.DataSource = this.rescalendarBindingSource;
            this.slueHorasTrabVac.Properties.DisplayMember = "name";
            this.slueHorasTrabVac.Properties.NullText = "";
            this.slueHorasTrabVac.Properties.PopupView = this.gridView1;
            this.slueHorasTrabVac.Properties.ValueMember = "id";
            this.slueHorasTrabVac.Size = new System.Drawing.Size(276, 24);
            this.slueHorasTrabVac.TabIndex = 20;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nombre";
            this.gridColumn3.FieldName = "name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Horas por dia";
            this.gridColumn4.FieldName = "hours_per_day";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // slueConfVacaciones
            // 
            this.slueConfVacaciones.Location = new System.Drawing.Point(165, 107);
            this.slueConfVacaciones.Name = "slueConfVacaciones";
            this.slueConfVacaciones.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slueConfVacaciones.Properties.Appearance.Options.UseFont = true;
            this.slueConfVacaciones.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueConfVacaciones.Properties.DataSource = this.hrvacationconfiguratiionBindingSource;
            this.slueConfVacaciones.Properties.DisplayMember = "name";
            this.slueConfVacaciones.Properties.NullText = "";
            this.slueConfVacaciones.Properties.PopupView = this.gridView2;
            this.slueConfVacaciones.Properties.ValueMember = "id";
            this.slueConfVacaciones.Size = new System.Drawing.Size(276, 24);
            this.slueConfVacaciones.TabIndex = 16;
            // 
            // hrvacationconfiguratiionBindingSource
            // 
            this.hrvacationconfiguratiionBindingSource.DataMember = "hr_vacation_configuratiion";
            this.hrvacationconfiguratiionBindingSource.DataSource = this.dsMantenimientoPlanilla;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Nombre";
            this.gridColumn5.FieldName = "name";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tipo Calculo";
            this.gridColumn6.FieldName = "calc_type";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(42, 224);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(120, 30);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Formato Contrato:";
            // 
            // slueContratoFormato
            // 
            this.slueContratoFormato.Location = new System.Drawing.Point(165, 228);
            this.slueContratoFormato.Name = "slueContratoFormato";
            this.slueContratoFormato.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slueContratoFormato.Properties.Appearance.Options.UseFont = true;
            this.slueContratoFormato.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueContratoFormato.Properties.DataSource = this.hrcontractformatBindingSource;
            this.slueContratoFormato.Properties.DisplayMember = "name";
            this.slueContratoFormato.Properties.NullText = "";
            this.slueContratoFormato.Properties.PopupView = this.gridView3;
            this.slueContratoFormato.Properties.ValueMember = "id";
            this.slueContratoFormato.Size = new System.Drawing.Size(276, 24);
            this.slueContratoFormato.TabIndex = 26;
            // 
            // hrcontractformatBindingSource
            // 
            this.hrcontractformatBindingSource.DataMember = "hr_contract_format";
            this.hrcontractformatBindingSource.DataSource = this.dsMantenimientoPlanilla;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Nombre";
            this.gridColumn7.FieldName = "name";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // frmPlanillaTipoContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 345);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.slueContratoFormato);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.cbSchedulePay);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtSecuencia);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.slueHorasTrabajo);
            this.Controls.Add(this.slueHorasTrabVac);
            this.Controls.Add(this.slueConfVacaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlanillaTipoContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Contrato";
            this.Load += new System.EventHandler(this.frmPlanillaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecuencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSchedulePay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueHorasTrabajo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rescalendarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueHorasTrabVac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueConfVacaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrvacationconfiguratiionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueContratoFormato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrcontractformatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private dsMantenimientoPlanilla dsMantenimientoPlanilla;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSecuencia;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.ComboBoxEdit cbSchedulePay;
        private DevExpress.XtraEditors.SearchLookUpEdit slueHorasTrabajo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource rescalendarBindingSource;
        private DevExpress.XtraEditors.SearchLookUpEdit slueHorasTrabVac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SearchLookUpEdit slueConfVacaciones;
        private System.Windows.Forms.BindingSource hrvacationconfiguratiionBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit slueContratoFormato;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.BindingSource hrcontractformatBindingSource;
    }
}