namespace LOSA.RRHH_Planilla.Planilla
{
    partial class frmSeleccionConcepto
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
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.slueConcepto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bsconcepts = new System.Windows.Forms.BindingSource(this.components);
            this.dsCargasPlantillas1 = new LOSA.RRHH_Planilla.Planilla.dsCargasPlantillas();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gleTipoPlanilla = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bstipoplanillalist = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.slueTipo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dsImportacionPlanilla = new LOSA.RRHH_Planilla.Planilla.ImportarPlanilla.dsImportacionPlanilla();
            this.benefitsdeductionstipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.slueConcepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsconcepts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCargasPlantillas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleTipoPlanilla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstipoplanillalist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImportacionPlanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benefitsdeductionstipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_24x24;
            this.simpleButton2.Location = new System.Drawing.Point(216, 171);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 46);
            this.simpleButton2.TabIndex = 4;
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
            this.btnSave.Location = new System.Drawing.Point(99, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 46);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Generar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(58, 89);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 15);
            this.labelControl4.TabIndex = 40;
            this.labelControl4.Text = "Concepto:";
            // 
            // slueConcepto
            // 
            this.slueConcepto.Location = new System.Drawing.Point(119, 86);
            this.slueConcepto.Name = "slueConcepto";
            this.slueConcepto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.slueConcepto.Properties.Appearance.Options.UseFont = true;
            this.slueConcepto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueConcepto.Properties.DataSource = this.bsconcepts;
            this.slueConcepto.Properties.DisplayMember = "name";
            this.slueConcepto.Properties.NullText = "[Seleccione un concepto]";
            this.slueConcepto.Properties.PopupView = this.gridView1;
            this.slueConcepto.Properties.ValueMember = "id";
            this.slueConcepto.Size = new System.Drawing.Size(276, 22);
            this.slueConcepto.TabIndex = 1;
            // 
            // bsconcepts
            // 
            this.bsconcepts.DataMember = "Concepts";
            this.bsconcepts.DataSource = this.dsCargasPlantillas1;
            // 
            // dsCargasPlantillas1
            // 
            this.dsCargasPlantillas1.DataSetName = "dsCargasPlantillas";
            this.dsCargasPlantillas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colname
            // 
            this.colname.Caption = "Concepto";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            // 
            // gleTipoPlanilla
            // 
            this.gleTipoPlanilla.Location = new System.Drawing.Point(119, 58);
            this.gleTipoPlanilla.Name = "gleTipoPlanilla";
            this.gleTipoPlanilla.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gleTipoPlanilla.Properties.Appearance.Options.UseFont = true;
            this.gleTipoPlanilla.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleTipoPlanilla.Properties.DataSource = this.bstipoplanillalist;
            this.gleTipoPlanilla.Properties.DisplayMember = "descripcion";
            this.gleTipoPlanilla.Properties.NullText = "[Seleccione un tipo de planilla]";
            this.gleTipoPlanilla.Properties.PopupView = this.gridView2;
            this.gleTipoPlanilla.Properties.ValueMember = "id";
            this.gleTipoPlanilla.Size = new System.Drawing.Size(246, 22);
            this.gleTipoPlanilla.TabIndex = 0;
            // 
            // bstipoplanillalist
            // 
            this.bstipoplanillalist.DataMember = "tipo_planilla_list";
            this.bstipoplanillalist.DataSource = this.dsCargasPlantillas1;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "id";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "descripcion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 122;
            this.label4.Text = "Tipo de Planilla:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(0, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(407, 21);
            this.labelControl1.TabIndex = 124;
            this.labelControl1.Text = "Generar Plantilla";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(85, 117);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 15);
            this.labelControl2.TabIndex = 126;
            this.labelControl2.Text = "Tipo:";
            // 
            // slueTipo
            // 
            this.slueTipo.Location = new System.Drawing.Point(119, 114);
            this.slueTipo.Name = "slueTipo";
            this.slueTipo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.slueTipo.Properties.Appearance.Options.UseFont = true;
            this.slueTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueTipo.Properties.DataSource = this.benefitsdeductionstipoBindingSource;
            this.slueTipo.Properties.DisplayMember = "descripcion";
            this.slueTipo.Properties.NullText = "[Seleccione un tipo]";
            this.slueTipo.Properties.PopupView = this.gridView3;
            this.slueTipo.Properties.ValueMember = "id";
            this.slueTipo.Size = new System.Drawing.Size(246, 22);
            this.slueTipo.TabIndex = 2;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // dsImportacionPlanilla
            // 
            this.dsImportacionPlanilla.DataSetName = "dsImportacionPlanilla";
            this.dsImportacionPlanilla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // benefitsdeductionstipoBindingSource
            // 
            this.benefitsdeductionstipoBindingSource.DataMember = "benefits_deductions_tipo";
            this.benefitsdeductionstipoBindingSource.DataSource = this.dsImportacionPlanilla;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tipo";
            this.gridColumn1.FieldName = "descripcion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // frmSeleccionConcepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 236);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.slueTipo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gleTipoPlanilla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.slueConcepto);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSeleccionConcepto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Plantilla";
            ((System.ComponentModel.ISupportInitialize)(this.slueConcepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsconcepts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCargasPlantillas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleTipoPlanilla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstipoplanillalist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImportacionPlanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benefitsdeductionstipoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SearchLookUpEdit slueConcepto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsconcepts;
        private dsCargasPlantillas dsCargasPlantillas1;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraEditors.GridLookUpEdit gleTipoPlanilla;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bstipoplanillalist;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit slueTipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.BindingSource benefitsdeductionstipoBindingSource;
        private ImportarPlanilla.dsImportacionPlanilla dsImportacionPlanilla;
        //private dsInasistencias dsInasistencias1;
    }
}