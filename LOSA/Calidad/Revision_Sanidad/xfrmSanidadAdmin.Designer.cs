﻿
namespace LOSA.Calidad.Revision_Sanidad
{
    partial class xfrmSanidadAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmSanidadAdmin));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsSanidad1 = new LOSA.Calidad.Revision_Sanidad.dsSanidad();
            this.gvVehiculo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colconductor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontenedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRevision = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.infovehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAtras = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSanidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRevision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infovehiculoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "info_vehiculo";
            this.gridControl1.DataSource = this.dsSanidad1;
            this.gridControl1.Location = new System.Drawing.Point(1, 76);
            this.gridControl1.MainView = this.gvVehiculo;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.btnRevision});
            this.gridControl1.Size = new System.Drawing.Size(1332, 657);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVehiculo});
            // 
            // dsSanidad1
            // 
            this.dsSanidad1.DataSetName = "dsSanidad";
            this.dsSanidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvVehiculo
            // 
            this.gvVehiculo.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVehiculo.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVehiculo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvVehiculo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvVehiculo.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVehiculo.Appearance.Row.Options.UseFont = true;
            this.gvVehiculo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colconductor,
            this.colplaca,
            this.colcontenedor,
            this.colfecha,
            this.colhora,
            this.colproveedor,
            this.colcliente,
            this.colcarcode,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
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
            this.colconductor.OptionsColumn.ReadOnly = true;
            this.colconductor.Visible = true;
            this.colconductor.VisibleIndex = 2;
            this.colconductor.Width = 254;
            // 
            // colplaca
            // 
            this.colplaca.Caption = "Placa";
            this.colplaca.FieldName = "placa";
            this.colplaca.Name = "colplaca";
            this.colplaca.OptionsColumn.ReadOnly = true;
            this.colplaca.Visible = true;
            this.colplaca.VisibleIndex = 3;
            this.colplaca.Width = 85;
            // 
            // colcontenedor
            // 
            this.colcontenedor.Caption = "Contenedor";
            this.colcontenedor.FieldName = "contenedor";
            this.colcontenedor.Name = "colcontenedor";
            this.colcontenedor.OptionsColumn.ReadOnly = true;
            this.colcontenedor.Visible = true;
            this.colcontenedor.VisibleIndex = 4;
            this.colcontenedor.Width = 92;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha Ingreso";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 5;
            this.colfecha.Width = 113;
            // 
            // colhora
            // 
            this.colhora.FieldName = "hora";
            this.colhora.Name = "colhora";
            this.colhora.OptionsColumn.ReadOnly = true;
            this.colhora.Visible = true;
            this.colhora.VisibleIndex = 6;
            this.colhora.Width = 78;
            // 
            // colproveedor
            // 
            this.colproveedor.Caption = "Proveedor";
            this.colproveedor.FieldName = "proveedor";
            this.colproveedor.Name = "colproveedor";
            this.colproveedor.OptionsColumn.ReadOnly = true;
            this.colproveedor.Visible = true;
            this.colproveedor.VisibleIndex = 7;
            this.colproveedor.Width = 78;
            // 
            // colcliente
            // 
            this.colcliente.Caption = "Cliente";
            this.colcliente.FieldName = "cliente";
            this.colcliente.Name = "colcliente";
            this.colcliente.OptionsColumn.ReadOnly = true;
            this.colcliente.Visible = true;
            this.colcliente.VisibleIndex = 8;
            this.colcliente.Width = 87;
            // 
            // colcarcode
            // 
            this.colcarcode.FieldName = "carcode";
            this.colcarcode.Name = "colcarcode";
            this.colcarcode.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Reporte";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 10;
            this.gridColumn1.Width = 80;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Revisión";
            this.gridColumn2.ColumnEdit = this.btnRevision;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 11;
            this.gridColumn2.Width = 101;
            // 
            // btnRevision
            // 
            this.btnRevision.AutoHeight = false;
            this.btnRevision.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            this.btnRevision.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnRevision.Name = "btnRevision";
            this.btnRevision.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnRevision.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnRevision_ButtonClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Estado";
            this.gridColumn3.FieldName = "estado";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 9;
            this.gridColumn3.Width = 102;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Documento";
            this.gridColumn4.FieldName = "documento";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 109;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tipo de Revision";
            this.gridColumn5.FieldName = "tipo_revision";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 128;
            // 
            // infovehiculoBindingSource
            // 
            this.infovehiculoBindingSource.DataMember = "info_vehiculo";
            this.infovehiculoBindingSource.DataSource = this.dsSanidad1;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Appearance.Options.UseBackColor = true;
            this.btnAtras.Appearance.Options.UseFont = true;
            this.btnAtras.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAtras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.ImageOptions.Image")));
            this.btnAtras.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAtras.Location = new System.Drawing.Point(1219, 17);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(100, 42);
            this.btnAtras.TabIndex = 38;
            this.btnAtras.Text = "Salir";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(26, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(127, 42);
            this.simpleButton1.TabIndex = 39;
            this.simpleButton1.Text = "Nuevo";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnActualizar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Appearance.Options.UseBackColor = true;
            this.btnActualizar.Appearance.Options.UseFont = true;
            this.btnActualizar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnActualizar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnActualizar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnActualizar.ImageOptions.SvgImage")));
            this.btnActualizar.Location = new System.Drawing.Point(171, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(127, 42);
            this.btnActualizar.TabIndex = 40;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // xfrmSanidadAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 734);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gridControl1);
            this.Name = "xfrmSanidadAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Sanidad Contenedores";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSanidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRevision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infovehiculoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource infovehiculoBindingSource;
        private dsSanidad dsSanidad1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVehiculo;
        private DevExpress.XtraGrid.Columns.GridColumn colconductor;
        private DevExpress.XtraGrid.Columns.GridColumn colplaca;
        private DevExpress.XtraGrid.Columns.GridColumn colcontenedor;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colhora;
        private DevExpress.XtraGrid.Columns.GridColumn colproveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente;
        private DevExpress.XtraGrid.Columns.GridColumn colcarcode;
        private DevExpress.XtraEditors.SimpleButton btnAtras;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnRevision;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}