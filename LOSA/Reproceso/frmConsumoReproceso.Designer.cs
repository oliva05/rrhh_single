namespace LOSA.Reproceso
{
    partial class frmConsumoReproceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsumoReproceso));
            this.cmdRefreshDisponibles = new DevExpress.XtraEditors.SimpleButton();
            this.toggleSwitchVerTodos_Disponibles = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaHastaDisponibles = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaDesdeDisponibles = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtVentana = new System.Windows.Forms.TextBox();
            this.grdConsumoRp = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchVerTodos_Disponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsumoRp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdRefreshDisponibles
            // 
            this.cmdRefreshDisponibles.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.cmdRefreshDisponibles.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRefreshDisponibles.Appearance.Options.UseBackColor = true;
            this.cmdRefreshDisponibles.Appearance.Options.UseFont = true;
            this.cmdRefreshDisponibles.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdRefreshDisponibles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRefreshDisponibles.ImageOptions.Image")));
            this.cmdRefreshDisponibles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdRefreshDisponibles.Location = new System.Drawing.Point(297, 25);
            this.cmdRefreshDisponibles.Name = "cmdRefreshDisponibles";
            this.cmdRefreshDisponibles.Size = new System.Drawing.Size(133, 35);
            this.cmdRefreshDisponibles.TabIndex = 108;
            this.cmdRefreshDisponibles.Text = "Refresh";
            // 
            // toggleSwitchVerTodos_Disponibles
            // 
            this.toggleSwitchVerTodos_Disponibles.Location = new System.Drawing.Point(368, 66);
            this.toggleSwitchVerTodos_Disponibles.Name = "toggleSwitchVerTodos_Disponibles";
            this.toggleSwitchVerTodos_Disponibles.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitchVerTodos_Disponibles.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitchVerTodos_Disponibles.Properties.OffText = "No";
            this.toggleSwitchVerTodos_Disponibles.Properties.OnText = "Si";
            this.toggleSwitchVerTodos_Disponibles.Size = new System.Drawing.Size(117, 20);
            this.toggleSwitchVerTodos_Disponibles.TabIndex = 107;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(292, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 20);
            this.labelControl1.TabIndex = 106;
            this.labelControl1.Text = "Ver Todos:";
            // 
            // dtFechaHastaDisponibles
            // 
            this.dtFechaHastaDisponibles.EditValue = null;
            this.dtFechaHastaDisponibles.Location = new System.Drawing.Point(142, 60);
            this.dtFechaHastaDisponibles.Name = "dtFechaHastaDisponibles";
            this.dtFechaHastaDisponibles.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaHastaDisponibles.Properties.Appearance.Options.UseFont = true;
            this.dtFechaHastaDisponibles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaHastaDisponibles.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaHastaDisponibles.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaHastaDisponibles.Size = new System.Drawing.Size(142, 24);
            this.dtFechaHastaDisponibles.TabIndex = 104;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(36, 63);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(88, 18);
            this.labelControl9.TabIndex = 105;
            this.labelControl9.Text = "Fecha Hasta:";
            // 
            // dtFechaDesdeDisponibles
            // 
            this.dtFechaDesdeDisponibles.EditValue = null;
            this.dtFechaDesdeDisponibles.Location = new System.Drawing.Point(142, 25);
            this.dtFechaDesdeDisponibles.Name = "dtFechaDesdeDisponibles";
            this.dtFechaDesdeDisponibles.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaDesdeDisponibles.Properties.Appearance.Options.UseFont = true;
            this.dtFechaDesdeDisponibles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaDesdeDisponibles.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtFechaDesdeDisponibles.Properties.MinValue = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtFechaDesdeDisponibles.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtFechaDesdeDisponibles.Size = new System.Drawing.Size(142, 24);
            this.dtFechaDesdeDisponibles.TabIndex = 102;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(36, 28);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(92, 18);
            this.labelControl8.TabIndex = 103;
            this.labelControl8.Text = "Fecha Desde:";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.labelControl3.Location = new System.Drawing.Point(526, 19);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(272, 44);
            this.labelControl3.TabIndex = 109;
            this.labelControl3.Text = "Consumo de Reproceso";
            // 
            // txtVentana
            // 
            this.txtVentana.Location = new System.Drawing.Point(558, 65);
            this.txtVentana.Name = "txtVentana";
            this.txtVentana.ReadOnly = true;
            this.txtVentana.Size = new System.Drawing.Size(196, 21);
            this.txtVentana.TabIndex = 118;
            this.txtVentana.Text = "frmConsumoReproceso";
            this.txtVentana.Visible = false;
            // 
            // grdConsumoRp
            // 
            this.grdConsumoRp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdConsumoRp.Location = new System.Drawing.Point(2, 93);
            this.grdConsumoRp.MainView = this.gridView1;
            this.grdConsumoRp.Name = "grdConsumoRp";
            this.grdConsumoRp.Size = new System.Drawing.Size(1397, 556);
            this.grdConsumoRp.TabIndex = 119;
            this.grdConsumoRp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdConsumoRp;
            this.gridView1.Name = "gridView1";
            // 
            // frmConsumoReproceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 653);
            this.Controls.Add(this.grdConsumoRp);
            this.Controls.Add(this.txtVentana);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmdRefreshDisponibles);
            this.Controls.Add(this.toggleSwitchVerTodos_Disponibles);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtFechaHastaDisponibles);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.dtFechaDesdeDisponibles);
            this.Controls.Add(this.labelControl8);
            this.Name = "frmConsumoReproceso";
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchVerTodos_Disponibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaHastaDisponibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaDesdeDisponibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsumoRp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdRefreshDisponibles;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchVerTodos_Disponibles;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtFechaHastaDisponibles;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit dtFechaDesdeDisponibles;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtVentana;
        private DevExpress.XtraGrid.GridControl grdConsumoRp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}