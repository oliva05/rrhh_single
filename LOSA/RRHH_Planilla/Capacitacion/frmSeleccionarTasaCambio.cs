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

namespace LOSA.RRHH_Planilla.Capacitacion
{
    public partial class frmSeleccionarTasaCambio : DevExpress.XtraEditors.XtraForm
    {
        public decimal tasa_cambio = 0;
        public frmSeleccionarTasaCambio()
        {
            InitializeComponent();
            CargarDatosCurrency();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (slueTasaCambio.EditValue==null)
                {
                    CajaDialogo.Error("Debe seleccionar una tasa de cambio");
                    return;
                }

                tasa_cambio = (decimal)slueTasaCambio.EditValue;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarDatosCurrency()
        {
            try
            {
                DataOperations dp = new DataOperations();

                //SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsCapacitacion1.tipo_cambio.Clear();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetTasa_Cambio_for_ppto_capacitacion", cnx);
                    cnx.Open();
                    //da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsCapacitacion1.tipo_cambio);
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