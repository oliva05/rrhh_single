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
using LOSA.Produccion;

namespace LOSA.Finanzas
{
    public partial class frmDetalleKardex : DevExpress.XtraEditors.XtraForm
    {
        int id_me;
        string lote;

        public frmDetalleKardex(int pid_me, string plote)
        {
            InitializeComponent();
            id_me = pid_me;
            lote = plote;

            cargar_data();
        }

        private void cargar_data()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAMS);
                conn.Open();

                string sql = "sp_get_detalle_por_lote";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_me", id_me);
                cmd.Parameters.AddWithValue("@lote", lote);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMaterialEmpaque1.detalle_kardex.Clear();
                da.Fill(dsMaterialEmpaque1.detalle_kardex);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}