using ACS.Classes;
using DevExpress.XtraEditors;
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

namespace LOSA.RRHH_Planilla.Mantenimientos
{
    public partial class frmPlanillaConf_ISR_ViewDetail : DevExpress.XtraEditors.XtraForm
    {
        
        public frmPlanillaConf_ISR_ViewDetail(int isr_id)
        {
            InitializeComponent();

            CargarDetalleISR(isr_id);
        }
        public void CargarDetalleISR(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla.Conf_ISR_detalle.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetConf_ISR_D_ByID", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    da.Fill(dsMantenimientoPlanilla.Conf_ISR_detalle);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }


}