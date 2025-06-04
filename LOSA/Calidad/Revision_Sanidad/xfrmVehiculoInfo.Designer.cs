
namespace LOSA.Calidad.Revision_Sanidad
{
    partial class xfrmVehiculoInfo
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmVehiculoInfo));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.infovehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSanidad = new LOSA.Calidad.Revision_Sanidad.dsSanidad();
            this.gvVehiculo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colconductor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontenedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infovehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSanidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.infovehiculoBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 57);
            this.gridControl1.MainView = this.gvVehiculo;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSeleccionar});
            this.gridControl1.Size = new System.Drawing.Size(1170, 352);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVehiculo});
            // 
            // infovehiculoBindingSource
            // 
            this.infovehiculoBindingSource.DataMember = "info_vehiculo";
            this.infovehiculoBindingSource.DataSource = this.dsSanidad;
            // 
            // dsSanidad
            // 
            this.dsSanidad.DataSetName = "dsSanidad";
            this.dsSanidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvVehiculo
            // 
            this.gvVehiculo.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVehiculo.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVehiculo.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVehiculo.Appearance.Row.Options.UseFont = true;
            this.gvVehiculo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colconductor,
            this.colplaca,
            this.colcontenedor,
            this.colfecha,
            this.colhora,
            this.colproveedor,
            this.colcliente,
            this.gridColumn1});
            this.gvVehiculo.GridControl = this.gridControl1;
            this.gvVehiculo.Name = "gvVehiculo";
            this.gvVehiculo.OptionsView.ShowAutoFilterRow = true;
            this.gvVehiculo.OptionsView.ShowGroupPanel = false;
            // 
            // colconductor
            // 
            this.colconductor.Caption = "Conductor";
            this.colconductor.FieldName = "conductor";
            this.colconductor.Name = "colconductor";
            this.colconductor.OptionsColumn.AllowEdit = false;
            this.colconductor.Visible = true;
            this.colconductor.VisibleIndex = 0;
            this.colconductor.Width = 170;
            // 
            // colplaca
            // 
            this.colplaca.Caption = "Placa";
            this.colplaca.FieldName = "placa";
            this.colplaca.Name = "colplaca";
            this.colplaca.OptionsColumn.AllowEdit = false;
            this.colplaca.Visible = true;
            this.colplaca.VisibleIndex = 1;
            this.colplaca.Width = 107;
            // 
            // colcontenedor
            // 
            this.colcontenedor.Caption = "Contenedor";
            this.colcontenedor.FieldName = "contenedor";
            this.colcontenedor.Name = "colcontenedor";
            this.colcontenedor.OptionsColumn.AllowEdit = false;
            this.colcontenedor.Visible = true;
            this.colcontenedor.VisibleIndex = 2;
            this.colcontenedor.Width = 125;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 3;
            this.colfecha.Width = 155;
            // 
            // colhora
            // 
            this.colhora.Caption = "Hora";
            this.colhora.FieldName = "hora";
            this.colhora.Name = "colhora";
            this.colhora.OptionsColumn.AllowEdit = false;
            this.colhora.Visible = true;
            this.colhora.VisibleIndex = 4;
            this.colhora.Width = 134;
            // 
            // colproveedor
            // 
            this.colproveedor.Caption = "Proveedor";
            this.colproveedor.FieldName = "proveedor";
            this.colproveedor.Name = "colproveedor";
            this.colproveedor.OptionsColumn.AllowEdit = false;
            this.colproveedor.Visible = true;
            this.colproveedor.VisibleIndex = 5;
            this.colproveedor.Width = 173;
            // 
            // colcliente
            // 
            this.colcliente.Caption = "Cliente";
            this.colcliente.FieldName = "cliente";
            this.colcliente.Name = "colcliente";
            this.colcliente.OptionsColumn.AllowEdit = false;
            this.colcliente.Visible = true;
            this.colcliente.VisibleIndex = 6;
            this.colcliente.Width = 170;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Seleccionar";
            this.gridColumn1.ColumnEdit = this.btnSeleccionar;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 107;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.tap;
            this.btnSeleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSeleccionar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSeleccionar_ButtonClick);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(1053, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(105, 39);
            this.btnAtras.TabIndex = 37;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // xfrmVehiculoInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 410);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gridControl1);
            this.Name = "xfrmVehiculoInfo";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infovehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSanidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVehiculo;
        private System.Windows.Forms.BindingSource infovehiculoBindingSource;
        private dsSanidad dsSanidad;
        private DevExpress.XtraGrid.Columns.GridColumn colconductor;
        private DevExpress.XtraGrid.Columns.GridColumn colplaca;
        private DevExpress.XtraGrid.Columns.GridColumn colcontenedor;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colhora;
        private DevExpress.XtraGrid.Columns.GridColumn colproveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSeleccionar;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
    }
}