namespace LOSA.RRHH_Planilla.Mantenimientos
{
    partial class frmPlanillaSalaryRules
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
            this.dsMantenimientoPlanilla = new LOSA.RRHH_Planilla.Mantenimientos.dsMantenimientoPlanilla();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSecuencia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.slueCat = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ceAppear = new DevExpress.XtraEditors.CheckEdit();
            this.txtNote = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecuencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueCat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAppear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(338, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 89);
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
            this.btnSave.Location = new System.Drawing.Point(126, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 46);
            this.btnSave.TabIndex = 7;
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
            this.simpleButton2.Location = new System.Drawing.Point(243, 374);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 46);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(183, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(118, 25);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Regla Salarial";
            // 
            // dsMantenimientoPlanilla
            // 
            this.dsMantenimientoPlanilla.DataSetName = "dsMantenimientoPlanilla";
            this.dsMantenimientoPlanilla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(32, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 17);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Código:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(88, 52);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Properties.Appearance.Options.UseFont = true;
            this.txtCode.Size = new System.Drawing.Size(132, 24);
            this.txtCode.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(16, 115);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 17);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Secuencia:";
            // 
            // txtSecuencia
            // 
            this.txtSecuencia.EditValue = "0";
            this.txtSecuencia.Location = new System.Drawing.Point(88, 112);
            this.txtSecuencia.Name = "txtSecuencia";
            this.txtSecuencia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecuencia.Properties.Appearance.Options.UseFont = true;
            this.txtSecuencia.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSecuencia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSecuencia.Size = new System.Drawing.Size(338, 24);
            this.txtSecuencia.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(21, 146);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 17);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.EditValue = "0";
            this.txtCantidad.Location = new System.Drawing.Point(88, 143);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Properties.Appearance.Options.UseFont = true;
            this.txtCantidad.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCantidad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCantidad.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCantidad.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtCantidad.Properties.MaskSettings.Set("mask", "d");
            this.txtCantidad.Size = new System.Drawing.Size(338, 24);
            this.txtCantidad.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(17, 176);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 17);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Categoría:";
            // 
            // slueCat
            // 
            this.slueCat.Location = new System.Drawing.Point(88, 173);
            this.slueCat.Name = "slueCat";
            this.slueCat.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slueCat.Properties.Appearance.Options.UseFont = true;
            this.slueCat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueCat.Properties.DataSource = this.categoriaBindingSource;
            this.slueCat.Properties.DisplayMember = "name";
            this.slueCat.Properties.NullText = "";
            this.slueCat.Properties.PopupView = this.searchLookUpEdit1View;
            this.slueCat.Properties.ValueMember = "id";
            this.slueCat.Size = new System.Drawing.Size(338, 24);
            this.slueCat.TabIndex = 4;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.dsMantenimientoPlanilla;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Code";
            this.gridColumn2.FieldName = "code";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nombre";
            this.gridColumn1.FieldName = "name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // ceAppear
            // 
            this.ceAppear.Location = new System.Drawing.Point(88, 213);
            this.ceAppear.Name = "ceAppear";
            this.ceAppear.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceAppear.Properties.Appearance.Options.UseFont = true;
            this.ceAppear.Properties.Caption = "Aparece en Nómina";
            this.ceAppear.Size = new System.Drawing.Size(149, 21);
            this.ceAppear.TabIndex = 5;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(88, 254);
            this.txtNote.Name = "txtNote";
            this.txtNote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Properties.Appearance.Options.UseFont = true;
            this.txtNote.Properties.MaxLength = 255;
            this.txtNote.Size = new System.Drawing.Size(338, 90);
            this.txtNote.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(46, 256);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 17);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "Nota:";
            // 
            // frmPlanillaSalaryRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 437);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.ceAppear);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtSecuencia);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.slueCat);
            this.Controls.Add(this.txtNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlanillaSalaryRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regla Salarial";
            this.Load += new System.EventHandler(this.frmPlanillaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMantenimientoPlanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecuencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueCat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAppear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSecuencia;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCantidad;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SearchLookUpEdit slueCat;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.CheckEdit ceAppear;
        private DevExpress.XtraEditors.MemoEdit txtNote;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}