using ACS.Classes;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using LOSA.Clases;
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

namespace LOSA.RRHH_Planilla.Depreciacion
{
    public partial class frm_DepreciacionGeneracionPlanillaAddPrestamo : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        int IdPlanillaH;
        public frm_DepreciacionGeneracionPlanillaAddPrestamo(UserLogin pUSer, int PidH)
        {
            InitializeComponent();
            UsuarioLogeado = pUSer;
            IdPlanillaH = PidH;

            LoadData();
        }

        private void LoadData()
        {
            DataOperations dp = new DataOperations();
            SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
            con.Open();

            SqlCommand cmd = new SqlCommand("[sp_depreciacion_listados_header_not]", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdHeader", IdPlanillaH);
            dsDepreciacion1.lista_deprecicacion_d.Clear();
            SqlDataAdapter adat = new SqlDataAdapter(cmd);
            adat.Fill(dsDepreciacion1.lista_deprecicacion_d);
            con.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea agregar los siguientes Prestamos a esta Planilla?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            bool Proceder = false;
            foreach (dsDepreciacion.lista_deprecicacion_dRow item in dsDepreciacion1.lista_deprecicacion_d)
            {
                if (item.seleccionado)
                {
                    Proceder = true;    
                }
            }

            if (!Proceder)
            {
                CajaDialogo.Error("Debe seleccionar algun Item!");
                return;
            }
         
            bool Guardar = false;
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);

            PlanillaDepreciacion dep = new PlanillaDepreciacion();
            dep.RecuperarPlanillaHeader(IdPlanillaH);
            
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction("Transaction Order");

                SqlCommand cmd = conn.CreateCommand();
                foreach (dsDepreciacion.lista_deprecicacion_dRow row in dsDepreciacion1.lista_deprecicacion_d.Rows)
                {
                    if (row.seleccionado)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "sp_depreciacion_generacion_detalle_saldos";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_h", IdPlanillaH);
                        cmd.Parameters.AddWithValue("@nombre", row.nombre);
                        cmd.Parameters.AddWithValue("@id_empleado", row.id_empleado);
                        cmd.Parameters.AddWithValue("@user_creador", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@id_prestamo", row.id_prestamo);
                        cmd.Parameters.AddWithValue("@tasa_cambio", dep.TasaCambio);
                        cmd.Parameters.AddWithValue("@distancia", row.distancia);
                        cmd.Parameters.AddWithValue("@num_pago", row.num_pago);
                        cmd.Parameters.AddWithValue("@reflejar_pago", row.reflejar_pago);
                        cmd.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
                Guardar = true;

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}