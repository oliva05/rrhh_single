﻿
namespace LOSA.Nir
{
    partial class frmSeleccionarLectura
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionarLectura));
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsNir = new LOSA.Nir.dsNir();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collectura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coln_curva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_bromatologia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbroma_porcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_h = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnseleccionar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colselecionada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSubirSeleccionada = new DevExpress.XtraEditors.SimpleButton();
            this.chTodas = new DevExpress.XtraEditors.CheckEdit();
            this.dtDesde = new DevExpress.XtraEditors.DateEdit();
            this.dtHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tsVerTodos = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnseleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chTodas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsVerTodos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.Image = global::LOSA.Properties.Resources.cancel;
            this.cmdHome.Location = new System.Drawing.Point(1083, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(184, 49);
            this.cmdHome.TabIndex = 10;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // grd_data
            // 
            this.grd_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_data.DataMember = "seleccion_lectura";
            this.grd_data.DataSource = this.dsNir;
            this.grd_data.Location = new System.Drawing.Point(1, 86);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnseleccionar});
            this.grd_data.Size = new System.Drawing.Size(1288, 670);
            this.grd_data.TabIndex = 11;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsNir
            // 
            this.dsNir.DataSetName = "dsNir";
            this.dsNir.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grdv_data.Appearance.Empty.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Empty.Options.UseFont = true;
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.collectura,
            this.colfecha,
            this.colcurva,
            this.coln_curva,
            this.colid_bromatologia,
            this.colbroma_porcentaje,
            this.colGH,
            this.colNB,
            this.colTS,
            this.colcomentario,
            this.colnombre_producto,
            this.collote,
            this.colid_h,
            this.colseleccionar,
            this.colselecionada});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            this.grdv_data.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdv_data_CellValueChanging);
            this.grdv_data.DoubleClick += new System.EventHandler(this.grdv_data_DoubleClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // collectura
            // 
            this.collectura.FieldName = "lectura";
            this.collectura.Name = "collectura";
            this.collectura.Visible = true;
            this.collectura.VisibleIndex = 0;
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowEdit = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            // 
            // colcurva
            // 
            this.colcurva.FieldName = "curva";
            this.colcurva.Name = "colcurva";
            this.colcurva.OptionsColumn.AllowEdit = false;
            this.colcurva.Visible = true;
            this.colcurva.VisibleIndex = 2;
            // 
            // coln_curva
            // 
            this.coln_curva.FieldName = "n_curva";
            this.coln_curva.Name = "coln_curva";
            this.coln_curva.OptionsColumn.AllowEdit = false;
            this.coln_curva.Visible = true;
            this.coln_curva.VisibleIndex = 3;
            // 
            // colid_bromatologia
            // 
            this.colid_bromatologia.FieldName = "id_bromatologia";
            this.colid_bromatologia.Name = "colid_bromatologia";
            this.colid_bromatologia.OptionsColumn.AllowEdit = false;
            this.colid_bromatologia.Visible = true;
            this.colid_bromatologia.VisibleIndex = 4;
            // 
            // colbroma_porcentaje
            // 
            this.colbroma_porcentaje.FieldName = "broma_porcentaje";
            this.colbroma_porcentaje.Name = "colbroma_porcentaje";
            this.colbroma_porcentaje.OptionsColumn.AllowEdit = false;
            this.colbroma_porcentaje.Visible = true;
            this.colbroma_porcentaje.VisibleIndex = 5;
            // 
            // colGH
            // 
            this.colGH.FieldName = "GH";
            this.colGH.Name = "colGH";
            this.colGH.OptionsColumn.AllowEdit = false;
            // 
            // colNB
            // 
            this.colNB.FieldName = "NB";
            this.colNB.Name = "colNB";
            this.colNB.OptionsColumn.AllowEdit = false;
            // 
            // colTS
            // 
            this.colTS.FieldName = "TS";
            this.colTS.Name = "colTS";
            this.colTS.OptionsColumn.AllowEdit = false;
            // 
            // colcomentario
            // 
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.AllowEdit = false;
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 6;
            // 
            // colnombre_producto
            // 
            this.colnombre_producto.FieldName = "nombre_producto";
            this.colnombre_producto.Name = "colnombre_producto";
            this.colnombre_producto.OptionsColumn.AllowEdit = false;
            this.colnombre_producto.Visible = true;
            this.colnombre_producto.VisibleIndex = 7;
            // 
            // collote
            // 
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 8;
            // 
            // colid_h
            // 
            this.colid_h.FieldName = "id_h";
            this.colid_h.Name = "colid_h";
            // 
            // colseleccionar
            // 
            this.colseleccionar.Caption = "Seleccionar";
            this.colseleccionar.ColumnEdit = this.btnseleccionar;
            this.colseleccionar.Name = "colseleccionar";
            this.colseleccionar.Visible = true;
            this.colseleccionar.VisibleIndex = 10;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.AutoHeight = false;
            editorButtonImageOptions1.Image = global::LOSA.Properties.Resources.tap;
            this.btnseleccionar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // colselecionada
            // 
            this.colselecionada.Caption = "Seleccionar";
            this.colselecionada.FieldName = "selecionada";
            this.colselecionada.Name = "colselecionada";
            this.colselecionada.Visible = true;
            this.colselecionada.VisibleIndex = 9;
            // 
            // btnSubirSeleccionada
            // 
            this.btnSubirSeleccionada.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirSeleccionada.Appearance.Options.UseFont = true;
            this.btnSubirSeleccionada.ImageOptions.Image = global::LOSA.Properties.Resources.tap;
            this.btnSubirSeleccionada.Location = new System.Drawing.Point(853, 12);
            this.btnSubirSeleccionada.Name = "btnSubirSeleccionada";
            this.btnSubirSeleccionada.Size = new System.Drawing.Size(197, 49);
            this.btnSubirSeleccionada.TabIndex = 12;
            this.btnSubirSeleccionada.Text = "Subir seleccionadas";
            this.btnSubirSeleccionada.Click += new System.EventHandler(this.btnSubirSeleccionada_Click);
            // 
            // chTodas
            // 
            this.chTodas.Location = new System.Drawing.Point(684, 58);
            this.chTodas.Name = "chTodas";
            this.chTodas.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.chTodas.Properties.Appearance.Options.UseFont = true;
            this.chTodas.Properties.Caption = "Seleccionar todas";
            this.chTodas.Size = new System.Drawing.Size(152, 22);
            this.chTodas.TabIndex = 13;
            this.chTodas.CheckedChanged += new System.EventHandler(this.chTodas_CheckedChanged);
            // 
            // dtDesde
            // 
            this.dtDesde.EditValue = null;
            this.dtDesde.Location = new System.Drawing.Point(117, 10);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesde.Properties.Appearance.Options.UseFont = true;
            this.dtDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDesde.Size = new System.Drawing.Size(125, 28);
            this.dtDesde.TabIndex = 14;
            // 
            // dtHasta
            // 
            this.dtHasta.EditValue = null;
            this.dtHasta.Location = new System.Drawing.Point(117, 49);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtHasta.Properties.Appearance.Options.UseFont = true;
            this.dtHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHasta.Size = new System.Drawing.Size(125, 28);
            this.dtHasta.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 21);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Fecha Desde:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 21);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Fecha Hasta:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Location = new System.Drawing.Point(261, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 36);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(261, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 21);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Ver Todos:";
            // 
            // tsVerTodos
            // 
            this.tsVerTodos.Location = new System.Drawing.Point(340, 48);
            this.tsVerTodos.Name = "tsVerTodos";
            this.tsVerTodos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsVerTodos.Properties.Appearance.Options.UseFont = true;
            this.tsVerTodos.Properties.OffText = "No";
            this.tsVerTodos.Properties.OnText = "Si";
            this.tsVerTodos.Size = new System.Drawing.Size(136, 32);
            this.tsVerTodos.TabIndex = 20;
            this.tsVerTodos.Toggled += new System.EventHandler(this.tsVerTodos_Toggled);
            // 
            // frmSeleccionarLectura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 756);
            this.Controls.Add(this.tsVerTodos);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.chTodas);
            this.Controls.Add(this.btnSubirSeleccionada);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.cmdHome);
            this.Name = "frmSeleccionarLectura";
            this.Text = "Seleccion de lote";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnseleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chTodas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsVerTodos.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private dsNir dsNir;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn collectura;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcurva;
        private DevExpress.XtraGrid.Columns.GridColumn coln_curva;
        private DevExpress.XtraGrid.Columns.GridColumn colid_bromatologia;
        private DevExpress.XtraGrid.Columns.GridColumn colbroma_porcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn colGH;
        private DevExpress.XtraGrid.Columns.GridColumn colNB;
        private DevExpress.XtraGrid.Columns.GridColumn colTS;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentario;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_producto;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colid_h;
        private DevExpress.XtraGrid.Columns.GridColumn colseleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnseleccionar;
        private DevExpress.XtraEditors.SimpleButton btnSubirSeleccionada;
        private DevExpress.XtraGrid.Columns.GridColumn colselecionada;
        private DevExpress.XtraEditors.CheckEdit chTodas;
        private DevExpress.XtraEditors.DateEdit dtDesde;
        private DevExpress.XtraEditors.DateEdit dtHasta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ToggleSwitch tsVerTodos;
    }
}