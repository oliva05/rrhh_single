namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    partial class frmExpedienteCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpedienteCRUD));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.MemoEdit();
            this.btnSeleccionar = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblArchivo = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.slueTipo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.tipoExpedienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaestroEmpleados1 = new LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado.dsMaestroEmpleados();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoExpedienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaestroEmpleados1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(32, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 15);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(103, 12);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Properties.MaxLength = 100;
            this.txtDescripcion.Size = new System.Drawing.Size(230, 56);
            this.txtDescripcion.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(45, 124);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(93, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Selecc. archivo";
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblArchivo
            // 
            this.lblArchivo.Location = new System.Drawing.Point(46, 153);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(36, 13);
            this.lblArchivo.TabIndex = 3;
            this.lblArchivo.Text = "Archivo";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = global::LOSA.Properties.Resources.cancel_24x24;
            this.simpleButton2.Location = new System.Drawing.Point(193, 200);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 46);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(76, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 46);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // slueTipo
            // 
            this.slueTipo.Location = new System.Drawing.Point(103, 86);
            this.slueTipo.Name = "slueTipo";
            this.slueTipo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slueTipo.Properties.Appearance.Options.UseFont = true;
            this.slueTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueTipo.Properties.DataSource = this.tipoExpedienteBindingSource;
            this.slueTipo.Properties.DisplayMember = "descripcion";
            this.slueTipo.Properties.NullText = "[Seleccione un tipo]";
            this.slueTipo.Properties.PopupView = this.searchLookUpEdit1View;
            this.slueTipo.Properties.ValueMember = "id";
            this.slueTipo.Size = new System.Drawing.Size(230, 22);
            this.slueTipo.TabIndex = 1;
            // 
            // tipoExpedienteBindingSource
            // 
            this.tipoExpedienteBindingSource.DataMember = "TipoExpediente";
            this.tipoExpedienteBindingSource.DataSource = this.dsMaestroEmpleados1;
            // 
            // dsMaestroEmpleados1
            // 
            this.dsMaestroEmpleados1.DataSetName = "dsMaestroEmpleados";
            this.dsMaestroEmpleados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tipo";
            this.gridColumn1.FieldName = "descripcion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 15);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Tipo Doc.";
            // 
            // frmExpedienteCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 258);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.slueTipo);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExpedienteCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expediente";
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoExpedienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaestroEmpleados1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtDescripcion;
        private DevExpress.XtraEditors.SimpleButton btnSeleccionar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.LabelControl lblArchivo;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SearchLookUpEdit slueTipo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource tipoExpedienteBindingSource;
        private dsMaestroEmpleados dsMaestroEmpleados1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}