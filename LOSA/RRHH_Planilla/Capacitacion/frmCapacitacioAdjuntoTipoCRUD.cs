using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.Clases.Planilla;
using LOSA.RRHH_Planilla.Capacitacion.Model;
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
    public partial class frmCapacitacioAdjuntoTipoCRUD : DevExpress.XtraEditors.XtraForm
    {
        CapacitacionTipoAdjunto tipo_adjunto = new CapacitacionTipoAdjunto();

        public enum TipoTransaccionPlanilla
        {
            Nuevo=1,
            Editar=2
        }

        TipoTransaccionPlanilla transaccion_tipo;

        UserLogin usuario = new UserLogin();
        int tipo_id;
        public frmCapacitacioAdjuntoTipoCRUD(TipoTransaccionPlanilla transact,UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo= transact;
            usuario=user_p;
            
        }

        public frmCapacitacioAdjuntoTipoCRUD(TipoTransaccionPlanilla transact, int id_tipoP, UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo = transact;
            tipo_id = id_tipoP;
            
            usuario = user_p;
       

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
 

            if (string.IsNullOrEmpty(txtTipo.Text))
            {
                CajaDialogo.Error("Debe de ingresar un tipo");
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                switch (transaccion_tipo)
                {
                    case TipoTransaccionPlanilla.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("dbo.[uspInsertTipoAdjunto_capacitacion]", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType= CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@descripcion",txtTipo.Text);
                            //cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
 
                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccionPlanilla.Editar:
                       
                        using (SqlCommand cmd = new SqlCommand("dbo.uspUpdateTipoAdjunto_capacitacion", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@id", tipo_adjunto.Id);
                            cmd.Parameters.AddWithValue("descripcion", txtTipo.Text);   

                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Actualizados");
                        this.DialogResult = DialogResult.OK;
                        break;
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

        private void frmPlanillaCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                tipo_adjunto=new CapacitacionTipoAdjunto();

                tipo_adjunto.RecuperarDatosPorId(tipo_id);
                
                if (TipoTransaccionPlanilla.Editar==transaccion_tipo)
                {
                    txtTipo.Text= tipo_adjunto.Descripcion;
 
      
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

           
    }
}