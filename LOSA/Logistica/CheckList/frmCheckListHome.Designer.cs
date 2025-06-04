namespace LOSA.Logistica.CheckList
{
    partial class frmCheckListHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckListHome));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHome = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsCheckList1 = new LOSA.Logistica.CheckList.dsCheckList();
            this.gvChecklist = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_inspeccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colequipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmodelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsemana_inspeccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.deF = new DevExpress.XtraEditors.DateEdit();
            this.deI = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCheckList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChecklist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deF.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deI.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(-1, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1164, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Checklist Montacargas";
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.Appearance.BackColor = System.Drawing.Color.White;
            this.btnHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Appearance.Options.UseBackColor = true;
            this.btnHome.Appearance.Options.UseFont = true;
            this.btnHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnHome.ImageOptions.Image = global::LOSA.Properties.Resources.home_automation_24X24;
            this.btnHome.Location = new System.Drawing.Point(995, 54);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(153, 46);
            this.btnHome.TabIndex = 12;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(677, 54);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(153, 46);
            this.simpleButton3.TabIndex = 13;
            this.simpleButton3.Text = "Actualizar";
            this.simpleButton3.Visible = false;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "checklist_header";
            this.gridControl1.DataSource = this.dsCheckList1;
            this.gridControl1.Location = new System.Drawing.Point(-1, 136);
            this.gridControl1.MainView = this.gvChecklist;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnPrint});
            this.gridControl1.Size = new System.Drawing.Size(1164, 430);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChecklist});
            // 
            // dsCheckList1
            // 
            this.dsCheckList1.DataSetName = "dsCheckList";
            this.dsCheckList1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvChecklist
            // 
            this.gvChecklist.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvChecklist.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvChecklist.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvChecklist.Appearance.Row.Options.UseFont = true;
            this.gvChecklist.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfecha,
            this.colnumero_inspeccion,
            this.coloperador,
            this.colequipo,
            this.colmodelo,
            this.colsemana_inspeccion,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvChecklist.GridControl = this.gridControl1;
            this.gvChecklist.Name = "gvChecklist";
            this.gvChecklist.OptionsView.ShowGroupPanel = false;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 3;
            this.colfecha.Width = 102;
            // 
            // colnumero_inspeccion
            // 
            this.colnumero_inspeccion.Caption = "# Inspección";
            this.colnumero_inspeccion.FieldName = "numero_inspeccion";
            this.colnumero_inspeccion.Name = "colnumero_inspeccion";
            this.colnumero_inspeccion.OptionsColumn.AllowEdit = false;
            this.colnumero_inspeccion.Visible = true;
            this.colnumero_inspeccion.VisibleIndex = 0;
            this.colnumero_inspeccion.Width = 154;
            // 
            // coloperador
            // 
            this.coloperador.Caption = "Operador";
            this.coloperador.FieldName = "operador";
            this.coloperador.Name = "coloperador";
            this.coloperador.OptionsColumn.AllowEdit = false;
            this.coloperador.Visible = true;
            this.coloperador.VisibleIndex = 4;
            this.coloperador.Width = 145;
            // 
            // colequipo
            // 
            this.colequipo.Caption = "Equipo";
            this.colequipo.FieldName = "equipo";
            this.colequipo.Name = "colequipo";
            this.colequipo.OptionsColumn.AllowEdit = false;
            this.colequipo.Visible = true;
            this.colequipo.VisibleIndex = 5;
            this.colequipo.Width = 120;
            // 
            // colmodelo
            // 
            this.colmodelo.Caption = "Modelo";
            this.colmodelo.FieldName = "modelo";
            this.colmodelo.Name = "colmodelo";
            this.colmodelo.OptionsColumn.AllowEdit = false;
            this.colmodelo.Visible = true;
            this.colmodelo.VisibleIndex = 6;
            this.colmodelo.Width = 91;
            // 
            // colsemana_inspeccion
            // 
            this.colsemana_inspeccion.Caption = "Semana Insp.";
            this.colsemana_inspeccion.FieldName = "semana_inspeccion";
            this.colsemana_inspeccion.Name = "colsemana_inspeccion";
            this.colsemana_inspeccion.OptionsColumn.AllowEdit = false;
            this.colsemana_inspeccion.Visible = true;
            this.colsemana_inspeccion.VisibleIndex = 7;
            this.colsemana_inspeccion.Width = 126;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Imprimir";
            this.gridColumn1.ColumnEdit = this.btnPrint;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 122;
            // 
            // btnPrint
            // 
            this.btnPrint.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.btnPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnPrint.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnPrint_ButtonPressed);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Horometro Inicial";
            this.gridColumn2.FieldName = "horometro_inicial";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 144;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Horómetro Final";
            this.gridColumn3.FieldName = "horometro_final";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 135;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Appearance.BackColor = System.Drawing.Color.White;
            this.btnNuevo.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Appearance.Options.UseBackColor = true;
            this.btnNuevo.Appearance.Options.UseFont = true;
            this.btnNuevo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnNuevo.ImageOptions.Image = global::LOSA.Properties.Resources.add_32x32;
            this.btnNuevo.Location = new System.Drawing.Point(836, 54);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(153, 46);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // deF
            // 
            this.deF.EditValue = null;
            this.deF.Location = new System.Drawing.Point(109, 81);
            this.deF.Name = "deF";
            this.deF.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.deF.Properties.Appearance.Options.UseFont = true;
            this.deF.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deF.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deF.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.deF.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deF.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.deF.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deF.Properties.MaskSettings.Set("mask", "dd-MM-yyyy");
            this.deF.Size = new System.Drawing.Size(179, 32);
            this.deF.TabIndex = 16;
            // 
            // deI
            // 
            this.deI.EditValue = null;
            this.deI.Location = new System.Drawing.Point(109, 43);
            this.deI.Name = "deI";
            this.deI.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.deI.Properties.Appearance.Options.UseFont = true;
            this.deI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deI.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deI.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.deI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deI.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.deI.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deI.Properties.MaskSettings.Set("mask", "dd-MM-yyyy");
            this.deI.Size = new System.Drawing.Size(179, 32);
            this.deI.TabIndex = 17;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Location = new System.Drawing.Point(29, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 25);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "F. Inicio:";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Location = new System.Drawing.Point(51, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 25);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "F. Fin:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnBuscar.Appearance.Options.UseFont = true;
            this.btnBuscar.ImageOptions.Image = global::LOSA.Properties.Resources.lookup_reference_32x32;
            this.btnBuscar.Location = new System.Drawing.Point(313, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 49);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmCheckListHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 564);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.deI);
            this.Controls.Add(this.deF);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmCheckListHome";
            this.Text = "+";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCheckList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChecklist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deF.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deI.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deI.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHome;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private dsCheckList dsCheckList1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChecklist;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_inspeccion;
        private DevExpress.XtraGrid.Columns.GridColumn coloperador;
        private DevExpress.XtraGrid.Columns.GridColumn colequipo;
        private DevExpress.XtraGrid.Columns.GridColumn colmodelo;
        private DevExpress.XtraGrid.Columns.GridColumn colsemana_inspeccion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.DateEdit deF;
        private DevExpress.XtraEditors.DateEdit deI;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
    }
}