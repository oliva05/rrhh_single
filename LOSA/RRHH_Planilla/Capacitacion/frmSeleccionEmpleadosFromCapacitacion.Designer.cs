namespace LOSA.RRHH_Planilla.Capacitacion
{
    partial class frmSeleccionEmpleadosFromCapacitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionEmpleadosFromCapacitacion));
            this.gcEmpleado = new DevExpress.XtraGrid.GridControl();
            this.dsCapacitacion1 = new LOSA.RRHH_Planilla.Capacitacion.dsCapacitacion();
            this.gvEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_employee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartment_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljob_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljob_title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSeleccionar = new DevExpress.XtraEditors.SimpleButton();
            this.ceSeleccionar = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCapacitacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSeleccionar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcEmpleado
            // 
            this.gcEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcEmpleado.DataMember = "capacitacion_empleados";
            this.gcEmpleado.DataSource = this.dsCapacitacion1;
            this.gcEmpleado.Location = new System.Drawing.Point(-2, 95);
            this.gcEmpleado.MainView = this.gvEmployee;
            this.gcEmpleado.Name = "gcEmpleado";
            this.gcEmpleado.Size = new System.Drawing.Size(950, 322);
            this.gcEmpleado.TabIndex = 0;
            this.gcEmpleado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployee});
            // 
            // dsCapacitacion1
            // 
            this.dsCapacitacion1.DataSetName = "dsCapacitacion";
            this.dsCapacitacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvEmployee
            // 
            this.gvEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_employee,
            this.colbarcode,
            this.coldepartment_id,
            this.coldepartment,
            this.colnombre,
            this.coljob_id,
            this.coljob_title,
            this.colseleccionar});
            this.gvEmployee.GridControl = this.gcEmpleado;
            this.gvEmployee.Name = "gvEmployee";
            this.gvEmployee.OptionsView.ShowAutoFilterRow = true;
            this.gvEmployee.OptionsView.ShowGroupPanel = false;
            this.gvEmployee.DoubleClick += new System.EventHandler(this.gvEmployee_DoubleClick);
            // 
            // colid_employee
            // 
            this.colid_employee.FieldName = "id_employee";
            this.colid_employee.Name = "colid_employee";
            this.colid_employee.OptionsColumn.AllowEdit = false;
            // 
            // colbarcode
            // 
            this.colbarcode.Caption = "Código";
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.OptionsColumn.AllowEdit = false;
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 0;
            this.colbarcode.Width = 133;
            // 
            // coldepartment_id
            // 
            this.coldepartment_id.FieldName = "department_id";
            this.coldepartment_id.Name = "coldepartment_id";
            this.coldepartment_id.OptionsColumn.AllowEdit = false;
            // 
            // coldepartment
            // 
            this.coldepartment.Caption = "Departamento";
            this.coldepartment.FieldName = "department";
            this.coldepartment.Name = "coldepartment";
            this.coldepartment.OptionsColumn.AllowEdit = false;
            this.coldepartment.Visible = true;
            this.coldepartment.VisibleIndex = 2;
            this.coldepartment.Width = 187;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowEdit = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 239;
            // 
            // coljob_id
            // 
            this.coljob_id.FieldName = "job_id";
            this.coljob_id.Name = "coljob_id";
            this.coljob_id.OptionsColumn.AllowEdit = false;
            // 
            // coljob_title
            // 
            this.coljob_title.Caption = "Puesto";
            this.coljob_title.FieldName = "job_title";
            this.coljob_title.Name = "coljob_title";
            this.coljob_title.OptionsColumn.AllowEdit = false;
            this.coljob_title.Visible = true;
            this.coljob_title.VisibleIndex = 3;
            this.coljob_title.Width = 245;
            // 
            // colseleccionar
            // 
            this.colseleccionar.FieldName = "seleccionar";
            this.colseleccionar.Name = "colseleccionar";
            this.colseleccionar.Visible = true;
            this.colseleccionar.VisibleIndex = 4;
            this.colseleccionar.Width = 84;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(811, 30);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(110, 36);
            this.cmdCerrar.TabIndex = 20;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(252, 21);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Seleccionar Empleados a Capacitar";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSeleccionar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Appearance.Options.UseBackColor = true;
            this.btnSeleccionar.Appearance.Options.UseFont = true;
            this.btnSeleccionar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSeleccionar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.ImageOptions.Image")));
            this.btnSeleccionar.Location = new System.Drawing.Point(695, 30);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(110, 36);
            this.btnSeleccionar.TabIndex = 23;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // ceSeleccionar
            // 
            this.ceSeleccionar.Location = new System.Drawing.Point(792, 72);
            this.ceSeleccionar.Name = "ceSeleccionar";
            this.ceSeleccionar.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceSeleccionar.Properties.Appearance.Options.UseFont = true;
            this.ceSeleccionar.Properties.Appearance.Options.UseTextOptions = true;
            this.ceSeleccionar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ceSeleccionar.Properties.Caption = "Seleccionar Todo";
            this.ceSeleccionar.Size = new System.Drawing.Size(129, 21);
            this.ceSeleccionar.TabIndex = 24;
            this.ceSeleccionar.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // frmSeleccionEmpleadosFromCapacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 417);
            this.Controls.Add(this.ceSeleccionar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.gcEmpleado);
            this.Name = "frmSeleccionEmpleadosFromCapacitacion";
            this.Text = "Seleccionar Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCapacitacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSeleccionar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcEmpleado;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colid_employee;
        private DevExpress.XtraGrid.Columns.GridColumn colbarcode;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartment_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn coljob_id;
        private DevExpress.XtraGrid.Columns.GridColumn coljob_title;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar;
        private dsCapacitacion dsCapacitacion1;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSeleccionar;
        private DevExpress.XtraEditors.CheckEdit ceSeleccionar;
    }
}