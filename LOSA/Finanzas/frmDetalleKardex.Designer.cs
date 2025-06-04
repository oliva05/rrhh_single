
namespace LOSA.Finanzas
{
    partial class frmDetalleKardex
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdDetalleKArdex = new DevExpress.XtraGrid.GridControl();
            this.dsMaterialEmpaque1 = new LOSA.Produccion.dsMaterialEmpaque();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_operacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reposVerDocumento = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colud_entrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colud_salida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_transaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_me = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_d_entrada_mercancia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_requisa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWsBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleKArdex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterialEmpaque1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposVerDocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDetalleKArdex
            // 
            this.grdDetalleKArdex.DataMember = "detalle_kardex";
            this.grdDetalleKArdex.DataSource = this.dsMaterialEmpaque1;
            this.grdDetalleKArdex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalleKArdex.Location = new System.Drawing.Point(0, 0);
            this.grdDetalleKArdex.MainView = this.gridView1;
            this.grdDetalleKArdex.Name = "grdDetalleKArdex";
            this.grdDetalleKArdex.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reposVerDocumento});
            this.grdDetalleKArdex.Size = new System.Drawing.Size(1283, 605);
            this.grdDetalleKArdex.TabIndex = 1;
            this.grdDetalleKArdex.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsMaterialEmpaque1
            // 
            this.dsMaterialEmpaque1.DataSetName = "dsMaterialEmpaque";
            this.dsMaterialEmpaque1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coltipo_operacion,
            this.coloperacion,
            this.colud_entrada,
            this.colud_salida,
            this.colfecha_transaccion,
            this.collote,
            this.colid_me,
            this.colItemName,
            this.colitemcode,
            this.colid_usuario,
            this.colusuario,
            this.colid_d_entrada_mercancia,
            this.colid_requisa,
            this.colWsBodega});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(-848, 412, 259, 332);
            this.gridView1.GridControl = this.grdDetalleKArdex;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coltipo_operacion
            // 
            this.coltipo_operacion.FieldName = "tipo_operacion";
            this.coltipo_operacion.Name = "coltipo_operacion";
            // 
            // coloperacion
            // 
            this.coloperacion.Caption = "Tipo Operacion";
            this.coloperacion.FieldName = "operacion";
            this.coloperacion.Name = "coloperacion";
            this.coloperacion.OptionsColumn.ReadOnly = true;
            this.coloperacion.Visible = true;
            this.coloperacion.VisibleIndex = 0;
            this.coloperacion.Width = 137;
            // 
            // reposVerDocumento
            // 
            this.reposVerDocumento.AutoHeight = false;
            editorButtonImageOptions3.Image = global::LOSA.Properties.Resources.next_16x16;
            this.reposVerDocumento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.reposVerDocumento.Name = "reposVerDocumento";
            // 
            // colud_entrada
            // 
            this.colud_entrada.Caption = "Entrada";
            this.colud_entrada.FieldName = "ud_entrada";
            this.colud_entrada.Name = "colud_entrada";
            this.colud_entrada.OptionsColumn.AllowEdit = false;
            this.colud_entrada.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ud_entrada", "SUMA={0:#.##}")});
            this.colud_entrada.Visible = true;
            this.colud_entrada.VisibleIndex = 1;
            this.colud_entrada.Width = 111;
            // 
            // colud_salida
            // 
            this.colud_salida.Caption = "Salida";
            this.colud_salida.FieldName = "ud_salida";
            this.colud_salida.Name = "colud_salida";
            this.colud_salida.OptionsColumn.AllowEdit = false;
            this.colud_salida.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ud_salida", "SUMA={0:#.##}")});
            this.colud_salida.Visible = true;
            this.colud_salida.VisibleIndex = 2;
            this.colud_salida.Width = 111;
            // 
            // colfecha_transaccion
            // 
            this.colfecha_transaccion.Caption = "Fecha Operacion";
            this.colfecha_transaccion.DisplayFormat.FormatString = "g";
            this.colfecha_transaccion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_transaccion.FieldName = "fecha_transaccion";
            this.colfecha_transaccion.Name = "colfecha_transaccion";
            this.colfecha_transaccion.OptionsColumn.AllowEdit = false;
            this.colfecha_transaccion.Visible = true;
            this.colfecha_transaccion.VisibleIndex = 3;
            this.colfecha_transaccion.Width = 145;
            // 
            // collote
            // 
            this.collote.Caption = "Lote";
            this.collote.FieldName = "lote";
            this.collote.Name = "collote";
            this.collote.OptionsColumn.AllowEdit = false;
            this.collote.Visible = true;
            this.collote.VisibleIndex = 4;
            this.collote.Width = 103;
            // 
            // colid_me
            // 
            this.colid_me.FieldName = "id_me";
            this.colid_me.Name = "colid_me";
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Articulo";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 5;
            this.colItemName.Width = 103;
            // 
            // colitemcode
            // 
            this.colitemcode.Caption = "ItmeCode";
            this.colitemcode.FieldName = "itemcode";
            this.colitemcode.Name = "colitemcode";
            this.colitemcode.OptionsColumn.AllowEdit = false;
            this.colitemcode.Visible = true;
            this.colitemcode.VisibleIndex = 6;
            this.colitemcode.Width = 103;
            // 
            // colid_usuario
            // 
            this.colid_usuario.FieldName = "id_usuario";
            this.colid_usuario.Name = "colid_usuario";
            this.colid_usuario.OptionsColumn.AllowEdit = false;
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.AllowEdit = false;
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 8;
            this.colusuario.Width = 108;
            // 
            // colid_d_entrada_mercancia
            // 
            this.colid_d_entrada_mercancia.FieldName = "id_d_entrada_mercancia";
            this.colid_d_entrada_mercancia.Name = "colid_d_entrada_mercancia";
            // 
            // colid_requisa
            // 
            this.colid_requisa.FieldName = "id_requisa";
            this.colid_requisa.Name = "colid_requisa";
            // 
            // colWsBodega
            // 
            this.colWsBodega.Caption = "Bodega";
            this.colWsBodega.FieldName = "WsBodega";
            this.colWsBodega.Name = "colWsBodega";
            this.colWsBodega.OptionsColumn.AllowEdit = false;
            this.colWsBodega.Visible = true;
            this.colWsBodega.VisibleIndex = 7;
            this.colWsBodega.Width = 119;
            // 
            // frmDetalleKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 605);
            this.Controls.Add(this.grdDetalleKArdex);
            this.Name = "frmDetalleKardex";
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleKArdex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterialEmpaque1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposVerDocumento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdDetalleKArdex;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_operacion;
        private DevExpress.XtraGrid.Columns.GridColumn coloperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colud_entrada;
        private DevExpress.XtraGrid.Columns.GridColumn colud_salida;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_transaccion;
        private DevExpress.XtraGrid.Columns.GridColumn collote;
        private DevExpress.XtraGrid.Columns.GridColumn colid_me;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colid_d_entrada_mercancia;
        private DevExpress.XtraGrid.Columns.GridColumn colid_requisa;
        private DevExpress.XtraGrid.Columns.GridColumn colWsBodega;
        private Produccion.dsMaterialEmpaque dsMaterialEmpaque1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit reposVerDocumento;
    }
}