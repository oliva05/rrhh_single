namespace LOSA.RRHH_Planilla.Planilla.Ausencias
{
    partial class frmLeaveGestionarEstado
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
            this.slueEstado = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bsleaveestado = new System.Windows.Forms.BindingSource(this.components);
            this.dsInasistencias1 = new LOSA.RRHH_Planilla.Planilla.Ausencias.dsInasistencias();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.slueEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsleaveestado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInasistencias1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_24x24;
            this.simpleButton2.Location = new System.Drawing.Point(214, 88);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 46);
            this.simpleButton2.TabIndex = 38;
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
            this.btnSave.Location = new System.Drawing.Point(97, 88);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 46);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Gestionar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(43, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 20);
            this.labelControl4.TabIndex = 40;
            this.labelControl4.Text = "Estado:";
            // 
            // slueEstado
            // 
            this.slueEstado.Location = new System.Drawing.Point(100, 31);
            this.slueEstado.Name = "slueEstado";
            this.slueEstado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.slueEstado.Properties.Appearance.Options.UseFont = true;
            this.slueEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueEstado.Properties.DataSource = this.bsleaveestado;
            this.slueEstado.Properties.DisplayMember = "descripcion";
            this.slueEstado.Properties.NullText = "[Seleccione una estado]";
            this.slueEstado.Properties.PopupView = this.gridView1;
            this.slueEstado.Properties.ValueMember = "id";
            this.slueEstado.Size = new System.Drawing.Size(295, 26);
            this.slueEstado.TabIndex = 39;
            // 
            // bsleaveestado
            // 
            this.bsleaveestado.DataMember = "leave_estado";
            this.bsleaveestado.DataSource = this.dsInasistencias1;
            // 
            // dsInasistencias1
            // 
            this.dsInasistencias1.DataSetName = "dsInasistencias";
            this.dsInasistencias1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Categoría";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // frmLeaveGestionarEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 159);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.slueEstado);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLeaveGestionarEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Estado";
            ((System.ComponentModel.ISupportInitialize)(this.slueEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsleaveestado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInasistencias1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SearchLookUpEdit slueEstado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private System.Windows.Forms.BindingSource bsleaveestado;
        private dsInasistencias dsInasistencias1;
    }
}