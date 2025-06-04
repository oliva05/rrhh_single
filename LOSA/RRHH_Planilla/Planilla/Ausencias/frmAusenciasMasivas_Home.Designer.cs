namespace LOSA.RRHH_Planilla.Planilla.Ausencias
{
    partial class frmAusenciasMasivas_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAusenciasMasivas_Home));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            this.dsInasistencias1 = new LOSA.RRHH_Planilla.Planilla.Ausencias.dsInasistencias();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvAusencias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_from = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_to = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_return = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumber_of_days = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartment_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_ausencia_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdTipoAusencia = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tipoausenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsInasistencias1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAusencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoAusencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoausenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // dsInasistencias1
            // 
            this.dsInasistencias1.DataSetName = "dsInasistencias";
            this.dsInasistencias1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSplitContainer1.Grid = null;
            this.gridSplitContainer1.Location = new System.Drawing.Point(-2, 98);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Size = new System.Drawing.Size(948, 398);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "ausencias_masivas";
            this.gridControl1.DataSource = this.dsInasistencias1;
            this.gridControl1.Location = new System.Drawing.Point(1, 83);
            this.gridControl1.MainView = this.gvAusencias;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.grdTipoAusencia});
            this.gridControl1.Size = new System.Drawing.Size(1064, 411);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAusencias});
            // 
            // gvAusencias
            // 
            this.gvAusencias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcode,
            this.coldate_from,
            this.coldate_to,
            this.coldate_return,
            this.colnumber_of_days,
            this.coldepartment_id,
            this.coldepartment,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.coltipo_ausencia_id});
            this.gvAusencias.GridControl = this.gridControl1;
            this.gvAusencias.Name = "gvAusencias";
            this.gvAusencias.OptionsView.ShowGroupPanel = false;
            // 
            // colcode
            // 
            this.colcode.Caption = "Código";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.OptionsColumn.ReadOnly = true;
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 1;
            this.colcode.Width = 108;
            // 
            // coldate_from
            // 
            this.coldate_from.Caption = "Fecha Inicio";
            this.coldate_from.FieldName = "date_from";
            this.coldate_from.Name = "coldate_from";
            this.coldate_from.Visible = true;
            this.coldate_from.VisibleIndex = 5;
            this.coldate_from.Width = 100;
            // 
            // coldate_to
            // 
            this.coldate_to.Caption = "Fecha Fin";
            this.coldate_to.FieldName = "date_to";
            this.coldate_to.Name = "coldate_to";
            this.coldate_to.Visible = true;
            this.coldate_to.VisibleIndex = 6;
            this.coldate_to.Width = 100;
            // 
            // coldate_return
            // 
            this.coldate_return.Caption = "Fecha de Reintegro";
            this.coldate_return.FieldName = "date_return";
            this.coldate_return.Name = "coldate_return";
            this.coldate_return.Visible = true;
            this.coldate_return.VisibleIndex = 7;
            this.coldate_return.Width = 100;
            // 
            // colnumber_of_days
            // 
            this.colnumber_of_days.Caption = "Dias Solicitados";
            this.colnumber_of_days.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colnumber_of_days.FieldName = "number_of_days";
            this.colnumber_of_days.Name = "colnumber_of_days";
            this.colnumber_of_days.Visible = true;
            this.colnumber_of_days.VisibleIndex = 8;
            this.colnumber_of_days.Width = 100;
            // 
            // coldepartment_id
            // 
            this.coldepartment_id.FieldName = "department_id";
            this.coldepartment_id.Name = "coldepartment_id";
            // 
            // coldepartment
            // 
            this.coldepartment.Caption = "Departamento";
            this.coldepartment.FieldName = "department";
            this.coldepartment.Name = "coldepartment";
            this.coldepartment.OptionsColumn.ReadOnly = true;
            this.coldepartment.Visible = true;
            this.coldepartment.VisibleIndex = 3;
            this.coldepartment.Width = 100;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nombre";
            this.gridColumn1.FieldName = "nombre";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 154;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Puesto";
            this.gridColumn2.FieldName = "puesto";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 102;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nota";
            this.gridColumn3.FieldName = "note";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 9;
            this.gridColumn3.Width = 93;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tipo Ausencia";
            this.gridColumn4.FieldName = "tipo_ausencia";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 120;
            // 
            // coltipo_ausencia_id
            // 
            this.coltipo_ausencia_id.Caption = "Tipo Ausencia";
            this.coltipo_ausencia_id.ColumnEdit = this.grdTipoAusencia;
            this.coltipo_ausencia_id.FieldName = "tipo_ausencia_id";
            this.coltipo_ausencia_id.Name = "coltipo_ausencia_id";
            this.coltipo_ausencia_id.Visible = true;
            this.coltipo_ausencia_id.VisibleIndex = 0;
            this.coltipo_ausencia_id.Width = 82;
            // 
            // grdTipoAusencia
            // 
            this.grdTipoAusencia.AutoHeight = false;
            this.grdTipoAusencia.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdTipoAusencia.DataSource = this.tipoausenciaBindingSource;
            this.grdTipoAusencia.DisplayMember = "name";
            this.grdTipoAusencia.Name = "grdTipoAusencia";
            this.grdTipoAusencia.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.grdTipoAusencia.ValueMember = "id";
            // 
            // tipoausenciaBindingSource
            // 
            this.tipoausenciaBindingSource.DataMember = "tipo_ausencia";
            this.tipoausenciaBindingSource.DataSource = this.dsInasistencias1;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Appearance.Options.UseFont = true;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(12, 29);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 39);
            toolTipTitleItem1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            toolTipTitleItem1.Text = "<b>Boton para Agregar Ausencias Masivas</b>";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnNuevo.SuperTip = superToolTip1;
            this.btnNuevo.TabIndex = 29;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.SvgImage = global::LOSA.Properties.Resources.clearheaderandfooter1;
            this.btnCancelar.Location = new System.Drawing.Point(952, 29);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 39);
            toolTipTitleItem2.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            toolTipTitleItem2.Text = "<b>Boton para Agregar Ausencias Masivas</b>";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.btnCancelar.SuperTip = superToolTip2;
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Enabled = false;
            this.btnSave.ImageOptions.SvgImage = global::LOSA.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(118, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 39);
            toolTipTitleItem3.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            toolTipTitleItem3.Text = "<b>Boton para Agregar Ausencias Masivas</b>";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.btnSave.SuperTip = superToolTip3;
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // colname
            // 
            this.colname.Caption = "Tipo de Ausencia";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            // 
            // frmAusenciasMasivas_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 496);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmAusenciasMasivas_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación de Ausencias Masivas";
            ((System.ComponentModel.ISupportInitialize)(this.dsInasistencias1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAusencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoAusencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoausenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dsInasistencias dsInasistencias1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAusencias;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_from;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_to;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_return;
        private DevExpress.XtraGrid.Columns.GridColumn colnumber_of_days;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartment_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartment;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit grdTipoAusencia;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource tipoausenciaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_ausencia_id;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
    }
}