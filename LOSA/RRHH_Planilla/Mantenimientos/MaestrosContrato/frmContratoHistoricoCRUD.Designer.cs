namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosContrato
{
    partial class frmContratoHistoricoCRUD
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
            this.slueDepto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.sluePuesto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSalario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNota = new DevExpress.XtraEditors.MemoEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsContrato1 = new LOSA.RRHH_Planilla.Mantenimientos.MaestrosContrato.dsContrato();
            this.bshrjobs = new System.Windows.Forms.BindingSource(this.components);
            this.bshrdeparment = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.slueDepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluePuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContrato1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bshrjobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bshrdeparment)).BeginInit();
            this.SuspendLayout();
            // 
            // slueDepto
            // 
            this.slueDepto.Location = new System.Drawing.Point(100, 31);
            this.slueDepto.Name = "slueDepto";
            this.slueDepto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.slueDepto.Properties.Appearance.Options.UseFont = true;
            this.slueDepto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueDepto.Properties.DataSource = this.bshrdeparment;
            this.slueDepto.Properties.DisplayMember = "name";
            this.slueDepto.Properties.NullText = "";
            this.slueDepto.Properties.PopupView = this.searchLookUpEdit1View;
            this.slueDepto.Properties.ValueMember = "id";
            this.slueDepto.Size = new System.Drawing.Size(232, 22);
            this.slueDepto.TabIndex = 8;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl5.Location = new System.Drawing.Point(15, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 15);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Departamento";
            // 
            // sluePuesto
            // 
            this.sluePuesto.Location = new System.Drawing.Point(100, 59);
            this.sluePuesto.Name = "sluePuesto";
            this.sluePuesto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.sluePuesto.Properties.Appearance.Options.UseFont = true;
            this.sluePuesto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sluePuesto.Properties.DataSource = this.bshrjobs;
            this.sluePuesto.Properties.DisplayMember = "name";
            this.sluePuesto.Properties.NullText = "";
            this.sluePuesto.Properties.PopupView = this.gridView1;
            this.sluePuesto.Properties.ValueMember = "id";
            this.sluePuesto.Size = new System.Drawing.Size(232, 22);
            this.sluePuesto.TabIndex = 10;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.Location = new System.Drawing.Point(15, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 15);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Puesto";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.Location = new System.Drawing.Point(15, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 15);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(100, 87);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtSalario.Properties.Appearance.Options.UseFont = true;
            this.txtSalario.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSalario.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSalario.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSalario.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtSalario.Properties.MaskSettings.Set("mask", "n");
            this.txtSalario.Properties.NullText = "0";
            this.txtSalario.Size = new System.Drawing.Size(232, 22);
            this.txtSalario.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl3.Location = new System.Drawing.Point(15, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 15);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Notas";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(100, 115);
            this.txtNota.Name = "txtNota";
            this.txtNota.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtNota.Properties.Appearance.Options.UseFont = true;
            this.txtNota.Size = new System.Drawing.Size(232, 65);
            this.txtNota.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_24x24;
            this.btnCancel.Location = new System.Drawing.Point(206, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 46);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = global::LOSA.Properties.Resources.save_24x24;
            this.btnSave.Location = new System.Drawing.Point(89, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 46);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Name";
            this.gridColumn1.FieldName = "name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Name";
            this.gridColumn3.FieldName = "name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // dsContrato1
            // 
            this.dsContrato1.DataSetName = "dsContrato";
            this.dsContrato1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bshrjobs
            // 
            this.bshrjobs.DataMember = "hr_jobs";
            this.bshrjobs.DataSource = this.dsContrato1;
            // 
            // bshrdeparment
            // 
            this.bshrdeparment.DataMember = "hr_deparment";
            this.bshrdeparment.DataSource = this.dsContrato1;
            // 
            // frmContratoHistoricoCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 274);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.sluePuesto);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.slueDepto);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContratoHistoricoCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato";
            ((System.ComponentModel.ISupportInitialize)(this.slueDepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluePuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContrato1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bshrjobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bshrdeparment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit slueDepto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit sluePuesto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSalario;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txtNota;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.BindingSource bshrdeparment;
        private dsContrato dsContrato1;
        private System.Windows.Forms.BindingSource bshrjobs;
    }
}