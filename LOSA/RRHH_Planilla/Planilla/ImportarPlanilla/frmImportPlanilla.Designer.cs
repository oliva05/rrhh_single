namespace LOSA.RRHH_Planilla.Planilla.ImportarPlanilla
{
    partial class frmImportPlanilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportPlanilla));
            this.gcPlanilla = new DevExpress.XtraGrid.GridControl();
            this.dsImportacionPlanilla1 = new LOSA.RRHH_Planilla.Planilla.ImportarPlanilla.dsImportacionPlanilla();
            this.gvPlanilla = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombrePlanilla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoPlanilla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldesde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colempleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDENTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCARGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDFT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBASIC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPVAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOTING = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGROSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAHRCOO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBANC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRCOOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAHRECOOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtrasDedCoop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col45095 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSMED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSULA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIHSS_T = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINCAPACIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEGRESO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadTemplate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnProcesar = new DevExpress.XtraEditors.SimpleButton();
            this.btnDownload = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gcPlanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImportacionPlanilla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlanilla)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPlanilla
            // 
            this.gcPlanilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPlanilla.DataMember = "template_planilla";
            this.gcPlanilla.DataSource = this.dsImportacionPlanilla1;
            this.gcPlanilla.Location = new System.Drawing.Point(3, 78);
            this.gcPlanilla.MainView = this.gvPlanilla;
            this.gcPlanilla.Name = "gcPlanilla";
            this.gcPlanilla.Size = new System.Drawing.Size(1254, 377);
            this.gcPlanilla.TabIndex = 0;
            this.gcPlanilla.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPlanilla});
            // 
            // dsImportacionPlanilla1
            // 
            this.dsImportacionPlanilla1.DataSetName = "dsImportacionPlanilla";
            this.dsImportacionPlanilla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvPlanilla
            // 
            this.gvPlanilla.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombrePlanilla,
            this.colTipoPlanilla,
            this.coldesde,
            this.colhasta,
            this.colcodigo_empleado,
            this.colempleado,
            this.colIDENTIDAD,
            this.colCARGO,
            this.colDVAC,
            this.colDFT,
            this.colDLB,
            this.colBASIC,
            this.colPVAC,
            this.colTRANS,
            this.colOTING,
            this.colGROSS,
            this.colAHRCOO,
            this.colBANC,
            this.colPRCOOP,
            this.colCAF,
            this.colAHRECOOP,
            this.colOtrasDedCoop,
            this.col45095,
            this.colSMED,
            this.colUSULA,
            this.colIHSS_T,
            this.colINCAPACIDAD,
            this.colISR,
            this.colTEGRESO,
            this.colNET,
            this.gridColumn1,
            this.gridColumn2});
            this.gvPlanilla.GridControl = this.gcPlanilla;
            this.gvPlanilla.Name = "gvPlanilla";
            this.gvPlanilla.OptionsView.ShowGroupPanel = false;
            // 
            // colNombrePlanilla
            // 
            this.colNombrePlanilla.FieldName = "NombrePlanilla";
            this.colNombrePlanilla.Name = "colNombrePlanilla";
            this.colNombrePlanilla.OptionsColumn.AllowMove = false;
            this.colNombrePlanilla.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNombrePlanilla.OptionsColumn.ReadOnly = true;
            this.colNombrePlanilla.OptionsFilter.AllowFilter = false;
            this.colNombrePlanilla.Visible = true;
            this.colNombrePlanilla.VisibleIndex = 0;
            this.colNombrePlanilla.Width = 82;
            // 
            // colTipoPlanilla
            // 
            this.colTipoPlanilla.FieldName = "TipoPlanilla";
            this.colTipoPlanilla.Name = "colTipoPlanilla";
            this.colTipoPlanilla.OptionsColumn.AllowMove = false;
            this.colTipoPlanilla.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTipoPlanilla.OptionsColumn.ReadOnly = true;
            this.colTipoPlanilla.OptionsFilter.AllowFilter = false;
            this.colTipoPlanilla.Visible = true;
            this.colTipoPlanilla.VisibleIndex = 1;
            this.colTipoPlanilla.Width = 64;
            // 
            // coldesde
            // 
            this.coldesde.Caption = "Desde";
            this.coldesde.FieldName = "desde";
            this.coldesde.Name = "coldesde";
            this.coldesde.OptionsColumn.AllowMove = false;
            this.coldesde.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coldesde.OptionsColumn.ReadOnly = true;
            this.coldesde.OptionsFilter.AllowFilter = false;
            this.coldesde.Visible = true;
            this.coldesde.VisibleIndex = 2;
            this.coldesde.Width = 42;
            // 
            // colhasta
            // 
            this.colhasta.Caption = "Hasta";
            this.colhasta.FieldName = "hasta";
            this.colhasta.Name = "colhasta";
            this.colhasta.OptionsColumn.AllowMove = false;
            this.colhasta.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colhasta.OptionsColumn.ReadOnly = true;
            this.colhasta.OptionsFilter.AllowFilter = false;
            this.colhasta.Visible = true;
            this.colhasta.VisibleIndex = 3;
            this.colhasta.Width = 53;
            // 
            // colcodigo_empleado
            // 
            this.colcodigo_empleado.Caption = "Codigo Empleado";
            this.colcodigo_empleado.FieldName = "codigo_empleado";
            this.colcodigo_empleado.Name = "colcodigo_empleado";
            this.colcodigo_empleado.OptionsColumn.AllowMove = false;
            this.colcodigo_empleado.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colcodigo_empleado.OptionsColumn.ReadOnly = true;
            this.colcodigo_empleado.OptionsFilter.AllowFilter = false;
            this.colcodigo_empleado.Visible = true;
            this.colcodigo_empleado.VisibleIndex = 6;
            this.colcodigo_empleado.Width = 31;
            // 
            // colempleado
            // 
            this.colempleado.Caption = "Empleado";
            this.colempleado.FieldName = "empleado";
            this.colempleado.Name = "colempleado";
            this.colempleado.OptionsColumn.AllowMove = false;
            this.colempleado.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colempleado.OptionsColumn.ReadOnly = true;
            this.colempleado.OptionsFilter.AllowFilter = false;
            this.colempleado.Visible = true;
            this.colempleado.VisibleIndex = 7;
            this.colempleado.Width = 31;
            // 
            // colIDENTIDAD
            // 
            this.colIDENTIDAD.FieldName = "IDENTIDAD";
            this.colIDENTIDAD.Name = "colIDENTIDAD";
            this.colIDENTIDAD.OptionsColumn.AllowMove = false;
            this.colIDENTIDAD.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIDENTIDAD.OptionsColumn.ReadOnly = true;
            this.colIDENTIDAD.OptionsFilter.AllowFilter = false;
            this.colIDENTIDAD.Visible = true;
            this.colIDENTIDAD.VisibleIndex = 8;
            this.colIDENTIDAD.Width = 31;
            // 
            // colCARGO
            // 
            this.colCARGO.FieldName = "CARGO";
            this.colCARGO.Name = "colCARGO";
            this.colCARGO.OptionsColumn.AllowMove = false;
            this.colCARGO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCARGO.OptionsColumn.ReadOnly = true;
            this.colCARGO.OptionsFilter.AllowFilter = false;
            this.colCARGO.Visible = true;
            this.colCARGO.VisibleIndex = 9;
            this.colCARGO.Width = 35;
            // 
            // colDVAC
            // 
            this.colDVAC.FieldName = "DVAC";
            this.colDVAC.Name = "colDVAC";
            this.colDVAC.OptionsColumn.AllowMove = false;
            this.colDVAC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDVAC.OptionsColumn.ReadOnly = true;
            this.colDVAC.OptionsFilter.AllowFilter = false;
            this.colDVAC.Visible = true;
            this.colDVAC.VisibleIndex = 10;
            this.colDVAC.Width = 30;
            // 
            // colDFT
            // 
            this.colDFT.FieldName = "DFT";
            this.colDFT.Name = "colDFT";
            this.colDFT.OptionsColumn.AllowMove = false;
            this.colDFT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDFT.OptionsColumn.ReadOnly = true;
            this.colDFT.OptionsFilter.AllowFilter = false;
            this.colDFT.Visible = true;
            this.colDFT.VisibleIndex = 11;
            this.colDFT.Width = 30;
            // 
            // colDLB
            // 
            this.colDLB.FieldName = "DLB";
            this.colDLB.Name = "colDLB";
            this.colDLB.OptionsColumn.AllowMove = false;
            this.colDLB.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDLB.OptionsColumn.ReadOnly = true;
            this.colDLB.OptionsFilter.AllowFilter = false;
            this.colDLB.Visible = true;
            this.colDLB.VisibleIndex = 12;
            this.colDLB.Width = 30;
            // 
            // colBASIC
            // 
            this.colBASIC.FieldName = "BASIC";
            this.colBASIC.Name = "colBASIC";
            this.colBASIC.OptionsColumn.AllowMove = false;
            this.colBASIC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBASIC.OptionsColumn.ReadOnly = true;
            this.colBASIC.OptionsFilter.AllowFilter = false;
            this.colBASIC.Visible = true;
            this.colBASIC.VisibleIndex = 13;
            this.colBASIC.Width = 30;
            // 
            // colPVAC
            // 
            this.colPVAC.FieldName = "PVAC";
            this.colPVAC.Name = "colPVAC";
            this.colPVAC.OptionsColumn.AllowMove = false;
            this.colPVAC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPVAC.OptionsColumn.ReadOnly = true;
            this.colPVAC.OptionsFilter.AllowFilter = false;
            this.colPVAC.Visible = true;
            this.colPVAC.VisibleIndex = 14;
            this.colPVAC.Width = 30;
            // 
            // colTRANS
            // 
            this.colTRANS.FieldName = "TRANS";
            this.colTRANS.Name = "colTRANS";
            this.colTRANS.OptionsColumn.AllowMove = false;
            this.colTRANS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTRANS.OptionsColumn.ReadOnly = true;
            this.colTRANS.OptionsFilter.AllowFilter = false;
            this.colTRANS.Visible = true;
            this.colTRANS.VisibleIndex = 15;
            this.colTRANS.Width = 30;
            // 
            // colOTING
            // 
            this.colOTING.FieldName = "OTING";
            this.colOTING.Name = "colOTING";
            this.colOTING.OptionsColumn.AllowMove = false;
            this.colOTING.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colOTING.OptionsColumn.ReadOnly = true;
            this.colOTING.OptionsFilter.AllowFilter = false;
            this.colOTING.Visible = true;
            this.colOTING.VisibleIndex = 16;
            this.colOTING.Width = 30;
            // 
            // colGROSS
            // 
            this.colGROSS.FieldName = "GROSS";
            this.colGROSS.Name = "colGROSS";
            this.colGROSS.OptionsColumn.AllowMove = false;
            this.colGROSS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGROSS.OptionsColumn.ReadOnly = true;
            this.colGROSS.OptionsFilter.AllowFilter = false;
            this.colGROSS.Visible = true;
            this.colGROSS.VisibleIndex = 17;
            this.colGROSS.Width = 30;
            // 
            // colAHRCOO
            // 
            this.colAHRCOO.FieldName = "AHRCOO";
            this.colAHRCOO.Name = "colAHRCOO";
            this.colAHRCOO.OptionsColumn.AllowMove = false;
            this.colAHRCOO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAHRCOO.OptionsColumn.ReadOnly = true;
            this.colAHRCOO.OptionsFilter.AllowFilter = false;
            this.colAHRCOO.Visible = true;
            this.colAHRCOO.VisibleIndex = 18;
            this.colAHRCOO.Width = 30;
            // 
            // colBANC
            // 
            this.colBANC.FieldName = "BANC";
            this.colBANC.Name = "colBANC";
            this.colBANC.OptionsColumn.AllowMove = false;
            this.colBANC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBANC.OptionsColumn.ReadOnly = true;
            this.colBANC.OptionsFilter.AllowFilter = false;
            this.colBANC.Visible = true;
            this.colBANC.VisibleIndex = 19;
            this.colBANC.Width = 30;
            // 
            // colPRCOOP
            // 
            this.colPRCOOP.FieldName = "PRCOOP";
            this.colPRCOOP.Name = "colPRCOOP";
            this.colPRCOOP.OptionsColumn.AllowMove = false;
            this.colPRCOOP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPRCOOP.OptionsColumn.ReadOnly = true;
            this.colPRCOOP.OptionsFilter.AllowFilter = false;
            this.colPRCOOP.Visible = true;
            this.colPRCOOP.VisibleIndex = 20;
            this.colPRCOOP.Width = 30;
            // 
            // colCAF
            // 
            this.colCAF.FieldName = "CAF";
            this.colCAF.Name = "colCAF";
            this.colCAF.OptionsColumn.AllowMove = false;
            this.colCAF.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCAF.OptionsColumn.ReadOnly = true;
            this.colCAF.OptionsFilter.AllowFilter = false;
            this.colCAF.Visible = true;
            this.colCAF.VisibleIndex = 21;
            this.colCAF.Width = 30;
            // 
            // colAHRECOOP
            // 
            this.colAHRECOOP.FieldName = "AHRECOOP";
            this.colAHRECOOP.Name = "colAHRECOOP";
            this.colAHRECOOP.OptionsColumn.AllowMove = false;
            this.colAHRECOOP.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAHRECOOP.OptionsColumn.ReadOnly = true;
            this.colAHRECOOP.OptionsFilter.AllowFilter = false;
            this.colAHRECOOP.Visible = true;
            this.colAHRECOOP.VisibleIndex = 22;
            this.colAHRECOOP.Width = 30;
            // 
            // colOtrasDedCoop
            // 
            this.colOtrasDedCoop.FieldName = "OtrasDedCoop";
            this.colOtrasDedCoop.Name = "colOtrasDedCoop";
            this.colOtrasDedCoop.OptionsColumn.AllowMove = false;
            this.colOtrasDedCoop.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colOtrasDedCoop.OptionsColumn.ReadOnly = true;
            this.colOtrasDedCoop.OptionsFilter.AllowFilter = false;
            this.colOtrasDedCoop.Visible = true;
            this.colOtrasDedCoop.VisibleIndex = 23;
            this.colOtrasDedCoop.Width = 51;
            // 
            // col45095
            // 
            this.col45095.FieldName = "45095";
            this.col45095.Name = "col45095";
            this.col45095.OptionsColumn.AllowMove = false;
            this.col45095.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.col45095.OptionsColumn.ReadOnly = true;
            this.col45095.OptionsFilter.AllowFilter = false;
            this.col45095.Visible = true;
            this.col45095.VisibleIndex = 24;
            this.col45095.Width = 37;
            // 
            // colSMED
            // 
            this.colSMED.FieldName = "SMED";
            this.colSMED.Name = "colSMED";
            this.colSMED.OptionsColumn.AllowMove = false;
            this.colSMED.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSMED.OptionsColumn.ReadOnly = true;
            this.colSMED.OptionsFilter.AllowFilter = false;
            this.colSMED.Visible = true;
            this.colSMED.VisibleIndex = 25;
            this.colSMED.Width = 41;
            // 
            // colUSULA
            // 
            this.colUSULA.FieldName = "USULA";
            this.colUSULA.Name = "colUSULA";
            this.colUSULA.OptionsColumn.AllowMove = false;
            this.colUSULA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUSULA.OptionsColumn.ReadOnly = true;
            this.colUSULA.OptionsFilter.AllowFilter = false;
            this.colUSULA.Visible = true;
            this.colUSULA.VisibleIndex = 26;
            this.colUSULA.Width = 43;
            // 
            // colIHSS_T
            // 
            this.colIHSS_T.FieldName = "IHSS_T";
            this.colIHSS_T.Name = "colIHSS_T";
            this.colIHSS_T.OptionsColumn.AllowMove = false;
            this.colIHSS_T.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIHSS_T.OptionsColumn.ReadOnly = true;
            this.colIHSS_T.OptionsFilter.AllowFilter = false;
            this.colIHSS_T.Visible = true;
            this.colIHSS_T.VisibleIndex = 27;
            this.colIHSS_T.Width = 41;
            // 
            // colINCAPACIDAD
            // 
            this.colINCAPACIDAD.FieldName = "INCAPACIDAD";
            this.colINCAPACIDAD.Name = "colINCAPACIDAD";
            this.colINCAPACIDAD.OptionsColumn.AllowMove = false;
            this.colINCAPACIDAD.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colINCAPACIDAD.OptionsColumn.ReadOnly = true;
            this.colINCAPACIDAD.OptionsFilter.AllowFilter = false;
            this.colINCAPACIDAD.Visible = true;
            this.colINCAPACIDAD.VisibleIndex = 28;
            this.colINCAPACIDAD.Width = 40;
            // 
            // colISR
            // 
            this.colISR.FieldName = "ISR";
            this.colISR.Name = "colISR";
            this.colISR.OptionsColumn.AllowMove = false;
            this.colISR.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colISR.OptionsColumn.ReadOnly = true;
            this.colISR.OptionsFilter.AllowFilter = false;
            this.colISR.Visible = true;
            this.colISR.VisibleIndex = 29;
            this.colISR.Width = 50;
            // 
            // colTEGRESO
            // 
            this.colTEGRESO.FieldName = "TEGRESO";
            this.colTEGRESO.Name = "colTEGRESO";
            this.colTEGRESO.OptionsColumn.AllowMove = false;
            this.colTEGRESO.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTEGRESO.OptionsColumn.ReadOnly = true;
            this.colTEGRESO.OptionsFilter.AllowFilter = false;
            this.colTEGRESO.Visible = true;
            this.colTEGRESO.VisibleIndex = 30;
            this.colTEGRESO.Width = 41;
            // 
            // colNET
            // 
            this.colNET.FieldName = "NET";
            this.colNET.Name = "colNET";
            this.colNET.OptionsColumn.AllowMove = false;
            this.colNET.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNET.OptionsColumn.ReadOnly = true;
            this.colNET.OptionsFilter.AllowFilter = false;
            this.colNET.Visible = true;
            this.colNET.VisibleIndex = 31;
            this.colNET.Width = 57;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tipo Cambio";
            this.gridColumn1.FieldName = "tipo_cambio";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 31;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Moneda";
            this.gridColumn2.FieldName = "Moneda";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowMove = false;
            this.gridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 38;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLoadTemplate
            // 
            this.btnLoadTemplate.ImageOptions.Image = global::LOSA.Properties.Resources.import_24X24;
            this.btnLoadTemplate.Location = new System.Drawing.Point(35, 22);
            this.btnLoadTemplate.Name = "btnLoadTemplate";
            this.btnLoadTemplate.Size = new System.Drawing.Size(105, 38);
            this.btnLoadTemplate.TabIndex = 1;
            this.btnLoadTemplate.Text = "Cargar Plantilla";
            this.btnLoadTemplate.Click += new System.EventHandler(this.btnLoadTemplate_Click);
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
            this.labelControl1.Location = new System.Drawing.Point(296, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(687, 31);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Importar Planilla";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(1128, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 38);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Enabled = false;
            this.btnProcesar.ImageOptions.Image = global::LOSA.Properties.Resources.refreshpivottable_32x32;
            this.btnProcesar.Location = new System.Drawing.Point(159, 22);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(105, 38);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.Appearance.Options.UseTextOptions = true;
            this.btnDownload.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnDownload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDownload.ImageOptions.SvgImage")));
            this.btnDownload.Location = new System.Drawing.Point(1017, 22);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(105, 38);
            this.btnDownload.TabIndex = 11;
            this.btnDownload.Text = "Descargar Plantilla";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // frmImportPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 455);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoadTemplate);
            this.Controls.Add(this.gcPlanilla);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmImportPlanilla";
            this.Text = "Importar Plantilla";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gcPlanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsImportacionPlanilla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlanilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPlanilla;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPlanilla;
        private dsImportacionPlanilla dsImportacionPlanilla1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.SimpleButton btnLoadTemplate;
        private DevExpress.XtraGrid.Columns.GridColumn colNombrePlanilla;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoPlanilla;
        private DevExpress.XtraGrid.Columns.GridColumn coldesde;
        private DevExpress.XtraGrid.Columns.GridColumn colhasta;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colempleado;
        private DevExpress.XtraGrid.Columns.GridColumn colIDENTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn colCARGO;
        private DevExpress.XtraGrid.Columns.GridColumn colDVAC;
        private DevExpress.XtraGrid.Columns.GridColumn colDFT;
        private DevExpress.XtraGrid.Columns.GridColumn colDLB;
        private DevExpress.XtraGrid.Columns.GridColumn colBASIC;
        private DevExpress.XtraGrid.Columns.GridColumn colPVAC;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANS;
        private DevExpress.XtraGrid.Columns.GridColumn colOTING;
        private DevExpress.XtraGrid.Columns.GridColumn colGROSS;
        private DevExpress.XtraGrid.Columns.GridColumn colAHRCOO;
        private DevExpress.XtraGrid.Columns.GridColumn colBANC;
        private DevExpress.XtraGrid.Columns.GridColumn colPRCOOP;
        private DevExpress.XtraGrid.Columns.GridColumn colCAF;
        private DevExpress.XtraGrid.Columns.GridColumn colAHRECOOP;
        private DevExpress.XtraGrid.Columns.GridColumn colOtrasDedCoop;
        private DevExpress.XtraGrid.Columns.GridColumn col45095;
        private DevExpress.XtraGrid.Columns.GridColumn colSMED;
        private DevExpress.XtraGrid.Columns.GridColumn colUSULA;
        private DevExpress.XtraGrid.Columns.GridColumn colIHSS_T;
        private DevExpress.XtraGrid.Columns.GridColumn colINCAPACIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn colISR;
        private DevExpress.XtraGrid.Columns.GridColumn colTEGRESO;
        private DevExpress.XtraGrid.Columns.GridColumn colNET;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnProcesar;
        private DevExpress.XtraEditors.SimpleButton btnDownload;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}