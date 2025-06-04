
namespace LOSA.Reproceso
{
    partial class frmEleccionReproceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEleccionReproceso));
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnReprocesoIngreso = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHome = new DevExpress.XtraEditors.SimpleButton();
            this.btnDetaleTarimaReproceso = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseBackColor = true;
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAgregar.ImageOptions.SvgImage")));
            this.btnAgregar.Location = new System.Drawing.Point(535, 46);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(201, 58);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Reproceso por Tarima";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnReprocesoIngreso
            // 
            this.btnReprocesoIngreso.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReprocesoIngreso.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprocesoIngreso.Appearance.Options.UseBackColor = true;
            this.btnReprocesoIngreso.Appearance.Options.UseFont = true;
            this.btnReprocesoIngreso.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnReprocesoIngreso.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReprocesoIngreso.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReprocesoIngreso.ImageOptions.SvgImage")));
            this.btnReprocesoIngreso.Location = new System.Drawing.Point(288, 46);
            this.btnReprocesoIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnReprocesoIngreso.Name = "btnReprocesoIngreso";
            this.btnReprocesoIngreso.Size = new System.Drawing.Size(201, 58);
            this.btnReprocesoIngreso.TabIndex = 35;
            this.btnReprocesoIngreso.Text = "Generar por Ingreso";
            this.btnReprocesoIngreso.Click += new System.EventHandler(this.btnReprocesoIngreso_Click);
            // 
            // cmdHome
            // 
            this.cmdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdHome.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdHome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Appearance.Options.UseBackColor = true;
            this.cmdHome.Appearance.Options.UseFont = true;
            this.cmdHome.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdHome.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdHome.ImageOptions.SvgImage")));
            this.cmdHome.Location = new System.Drawing.Point(670, 1);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(100, 40);
            this.cmdHome.TabIndex = 55;
            this.cmdHome.Text = "Atras";
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // btnDetaleTarimaReproceso
            // 
            this.btnDetaleTarimaReproceso.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnDetaleTarimaReproceso.Appearance.Options.UseFont = true;
            this.btnDetaleTarimaReproceso.Appearance.Options.UseTextOptions = true;
            this.btnDetaleTarimaReproceso.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnDetaleTarimaReproceso.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnDetaleTarimaReproceso.ImageOptions.Image = global::LOSA.Properties.Resources.logout;
            this.btnDetaleTarimaReproceso.Location = new System.Drawing.Point(39, 47);
            this.btnDetaleTarimaReproceso.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetaleTarimaReproceso.Name = "btnDetaleTarimaReproceso";
            this.btnDetaleTarimaReproceso.Size = new System.Drawing.Size(201, 58);
            this.btnDetaleTarimaReproceso.TabIndex = 56;
            this.btnDetaleTarimaReproceso.Text = "Tarimas Generadas";
            this.btnDetaleTarimaReproceso.Click += new System.EventHandler(this.btnDetaleTarimaReproceso_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(39, 128);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(201, 58);
            this.simpleButton1.TabIndex = 57;
            this.simpleButton1.Text = "Reporte Generacion de Reproceso";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmEleccionReproceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 217);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnDetaleTarimaReproceso);
            this.Controls.Add(this.cmdHome);
            this.Controls.Add(this.btnReprocesoIngreso);
            this.Controls.Add(this.btnAgregar);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmEleccionReproceso";
            this.Text = "Reproceso";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnReprocesoIngreso;
        private DevExpress.XtraEditors.SimpleButton cmdHome;
        private DevExpress.XtraEditors.SimpleButton btnDetaleTarimaReproceso;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}