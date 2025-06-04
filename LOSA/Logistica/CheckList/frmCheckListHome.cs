using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using LOSA.Logistica.CheckList.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Logistica.CheckList
{
    public partial class frmCheckListHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuario;
        public frmCheckListHome(UserLogin pUser)
        {
            InitializeComponent();

            usuario = pUser;

            deI.DateTime = DateTime.Now;
            deF.DateTime = DateTime.Now;
            CargarCheckListFiltering(DateTime.Now, DateTime.Now);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCheckListCRUD frm = new frmCheckListCRUD(usuario,frmCheckListCRUD.TipoTransaccion.Nuevo);

            if (frm.ShowDialog()== DialogResult.OK)
            {
                
            }
        }

        public void CargarCheckList()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                dsCheckList1.checklist_header.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetChecklist_header", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsCheckList1.checklist_header);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarCheckListFiltering(DateTime fecha_inicia,DateTime fecha_final)
        {
            try
            {
                DataOperations dp = new DataOperations();
                
                dsCheckList1.checklist_header.Clear();

                using (SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    SqlCommand cmd = new SqlCommand("dbo.uspGetChecklist_header_filtering", connection);
                    cmd.Parameters.AddWithValue("@fecha_i",fecha_inicia);
                    cmd.Parameters.AddWithValue("@fecha_f",fecha_final);

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    connection.Open();

                    da.Fill(dsCheckList1.checklist_header);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            CargarCheckList();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCheckListCRUD frm = new frmCheckListCRUD(usuario, frmCheckListCRUD.TipoTransaccion.Nuevo);

            if (frm.ShowDialog()== DialogResult.OK)
            {
                //CargarCheckList();
                CargarCheckListFiltering(deI.DateTime, deF.DateTime);
            }
        }

        private void btnPrint_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            try
            {
                var row = (dsCheckList.checklist_headerRow)gvChecklist.GetFocusedDataRow();
               
                
                if (row != null)
                {

                // Crea una instancia de tu reporte
                rptChecklist reporte = new rptChecklist(row.id); // Reemplaza "MiReporte" con el nombre de tu clase de reporte.


                // Muestra el reporte en el visor de reportes.
                ReportPrintTool printTool = new ReportPrintTool(reporte);
                printTool.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarCheckListFiltering(deI.DateTime, deF.DateTime);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}