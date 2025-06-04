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

namespace LOSA.RRHH_Planilla.Planilla.Ausencias
{
    public partial class frmLeaveGestionarEstado : DevExpress.XtraEditors.XtraForm
    {
        int id_leave = 0;
        public frmLeaveGestionarEstado(int pId_leave,int id_estado)
        {
            InitializeComponent();
            LoadEstado();
            id_leave = pId_leave;

            slueEstado.EditValue = id_estado;
        }


        private void LoadEstado()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("[dbo].[uspLoadLeave_estados]", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                //cmd1.Parameters.AddWithValue("@id_employee", EmployeeId);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                dsInasistencias1.leave_estado.Clear();

                adapter1.Fill(dsInasistencias1.leave_estado);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();
                        SqlCommand cmd = new SqlCommand("uspUpdateEstadoLeave", cnx);
                        cmd.CommandType= CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_leave",id_leave);
                        cmd.Parameters.AddWithValue("@id_estado",slueEstado.EditValue);

                        cmd.ExecuteNonQuery();
           
                    cnx.Close();
                    CajaDialogo.InformationAuto();
                    this.DialogResult= DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}