using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.MigracionACS.RRHH.Vacaciones;
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

namespace LOSA.RRHH_Planilla.Planilla.Ausencias
{
    public partial class frmLeaveDetail : DevExpress.XtraEditors.XtraForm
    {
        int EmployeeId = 0;

        public frmLeaveDetail(int pEmployeeId)
        {
            InitializeComponent();
            EmployeeId = pEmployeeId;

            LoadDetalle();
        }

        private void LoadDetalle()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                SqlConnection con_rrhh = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();
                con_rrhh.Open();

                SqlCommand cmd1 = new SqlCommand("dbo.sp_get_detalle_dias_vacaciones_acumulados", con);
                SqlCommand cmd2 = new SqlCommand("dbo.sp_get_detalle_dias_vacaciones_tomados_stand", con);
                SqlCommand cmd3 = new SqlCommand("dbo.sp_get_detalle_dias_vacaciones_tomadas_RRHH", con_rrhh);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@id_employee", EmployeeId);
                cmd2.Parameters.AddWithValue("@id_employee", EmployeeId);
                cmd3.Parameters.AddWithValue("@id_employee", EmployeeId);

                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                SqlDataAdapter adapter3 = new SqlDataAdapter(cmd3);

                dsInasistencias1.acumulados.Clear();
                dsInasistencias1.tomados_stand.Clear();
                dsInasistencias1.tomados_rrhh.Clear();

                adapter1.Fill(dsInasistencias1.acumulados);
                adapter2.Fill(dsInasistencias1.tomados_stand);
                adapter3.Fill(dsInasistencias1.tomados_rrhh);
                con.Close();
                con_rrhh.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            LoadDetalle();
        }
    }
}