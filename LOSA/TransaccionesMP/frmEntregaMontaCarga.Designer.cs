﻿namespace LOSA.TransaccionesMP
{
    partial class frmEntregaMontaCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntregaMontaCarga));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdDetalleMP = new DevExpress.XtraEditors.SimpleButton();
            this.cmdEntrega = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDevoluciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnResumenTarimas = new DevExpress.XtraEditors.SimpleButton();
            this.btnEntregaBines = new DevExpress.XtraEditors.SimpleButton();
            this.btnDevolucionesMacro = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(81, 438);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(173, 29);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Entregar Tarima";
            // 
            // cmdDetalleMP
            // 
            this.cmdDetalleMP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDetalleMP.Appearance.Options.UseFont = true;
            this.cmdDetalleMP.Appearance.Options.UseTextOptions = true;
            this.cmdDetalleMP.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.cmdDetalleMP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdDetalleMP.ImageOptions.Image = global::LOSA.Properties.Resources.trucksss;
            this.cmdDetalleMP.Location = new System.Drawing.Point(323, 101);
            this.cmdDetalleMP.Name = "cmdDetalleMP";
            this.cmdDetalleMP.Size = new System.Drawing.Size(274, 67);
            this.cmdDetalleMP.TabIndex = 15;
            this.cmdDetalleMP.Text = "Materia Prima entregada";
            this.cmdDetalleMP.Click += new System.EventHandler(this.cmdDetalleMP_Click);
            // 
            // cmdEntrega
            // 
            this.cmdEntrega.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEntrega.Appearance.Options.UseFont = true;
            this.cmdEntrega.Appearance.Options.UseTextOptions = true;
            this.cmdEntrega.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmdEntrega.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.cmdEntrega.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.cmdEntrega.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdEntrega.ImageOptions.Image = global::LOSA.Properties.Resources.Forklift_icon;
            this.cmdEntrega.Location = new System.Drawing.Point(25, 101);
            this.cmdEntrega.Name = "cmdEntrega";
            this.cmdEntrega.Size = new System.Drawing.Size(274, 331);
            this.cmdEntrega.TabIndex = 14;
            this.cmdEntrega.Click += new System.EventHandler(this.cmdEntrega_Click);
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
            this.cmdHome.Location = new System.Drawing.Point(411, 12);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(199, 71);
            this.cmdHome.TabIndex = 18;
            this.cmdHome.Text = "Cerrar";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(323, 172);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(274, 67);
            this.simpleButton1.TabIndex = 19;
            this.simpleButton1.Text = "Requisas";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnDevoluciones.Appearance.Options.UseFont = true;
            this.btnDevoluciones.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDevoluciones.ImageOptions.Image")));
            this.btnDevoluciones.Location = new System.Drawing.Point(323, 243);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Size = new System.Drawing.Size(274, 67);
            this.btnDevoluciones.TabIndex = 21;
            this.btnDevoluciones.Text = "Devoluciones";
            this.btnDevoluciones.Click += new System.EventHandler(this.btnDevoluciones_Click);
            // 
            // btnResumenTarimas
            // 
            this.btnResumenTarimas.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnResumenTarimas.Appearance.Options.UseFont = true;
            this.btnResumenTarimas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnResumenTarimas.ImageOptions.Image")));
            this.btnResumenTarimas.Location = new System.Drawing.Point(323, 384);
            this.btnResumenTarimas.Name = "btnResumenTarimas";
            this.btnResumenTarimas.Size = new System.Drawing.Size(274, 67);
            this.btnResumenTarimas.TabIndex = 22;
            this.btnResumenTarimas.Text = "Tarimas Por Ingreso";
            this.btnResumenTarimas.Click += new System.EventHandler(this.btnResumenTarimas_Click);
            // 
            // btnEntregaBines
            // 
            this.btnEntregaBines.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregaBines.Appearance.Options.UseFont = true;
            this.btnEntregaBines.ImageOptions.Image = global::LOSA.Properties.Resources.tanque;
            this.btnEntregaBines.Location = new System.Drawing.Point(323, 454);
            this.btnEntregaBines.Name = "btnEntregaBines";
            this.btnEntregaBines.Size = new System.Drawing.Size(274, 67);
            this.btnEntregaBines.TabIndex = 23;
            this.btnEntregaBines.Text = "Entrega de Bines a PRD";
            this.btnEntregaBines.Visible = false;
            this.btnEntregaBines.Click += new System.EventHandler(this.btnEntregaBines_Click);
            // 
            // btnDevolucionesMacro
            // 
            this.btnDevolucionesMacro.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnDevolucionesMacro.Appearance.Options.UseFont = true;
            this.btnDevolucionesMacro.Appearance.Options.UseTextOptions = true;
            this.btnDevolucionesMacro.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnDevolucionesMacro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnDevolucionesMacro.Location = new System.Drawing.Point(323, 314);
            this.btnDevolucionesMacro.Name = "btnDevolucionesMacro";
            this.btnDevolucionesMacro.Size = new System.Drawing.Size(274, 67);
            this.btnDevolucionesMacro.TabIndex = 24;
            this.btnDevolucionesMacro.Text = "Macro Ingredientes Devoluciones ";
            this.btnDevolucionesMacro.Click += new System.EventHandler(this.btnDevolucionesMacro_Click);
            // 
            // frmEntregaMontaCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 521);
            this.Controls.Add(this.btnDevolucionesMacro);
            this.Controls.Add(this.btnEntregaBines);
            this.Controls.Add(this.btnResumenTarimas);
            this.Controls.Add(this.btnDevoluciones);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdDetalleMP);
            this.Controls.Add(this.cmdEntrega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEntregaMontaCarga";
            this.Text = "frmEntregaMontaCarga";
            this.Load += new System.EventHandler(this.frmEntregaMontaCarga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdDetalleMP;
        private DevExpress.XtraEditors.SimpleButton cmdEntrega;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnDevoluciones;
        private DevExpress.XtraEditors.SimpleButton btnResumenTarimas;
        private DevExpress.XtraEditors.SimpleButton btnEntregaBines;
        private DevExpress.XtraEditors.SimpleButton btnDevolucionesMacro;
    }
}