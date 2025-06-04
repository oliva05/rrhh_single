using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.Clases.Planilla;
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
    public partial class frmPlanillaBandaSalarial : DevExpress.XtraEditors.XtraForm
    {
        
        public enum TipoTransaccionPlanilla
        {
            Nuevo=1,
            Editar=2
        }

        TipoTransaccionPlanilla transaccion_tipo;

        UserLogin usuario = new UserLogin();
        int bandaSalarial_id;
        string bandaSalarial;
        public frmPlanillaBandaSalarial(TipoTransaccionPlanilla transact,UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo= transact;
            usuario=user_p;
            
        }

        public frmPlanillaBandaSalarial(TipoTransaccionPlanilla transact, int id_bandaSalarial,string banda_salarial, UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo = transact;
            bandaSalarial_id = id_bandaSalarial;
            bandaSalarial = banda_salarial;

            usuario = user_p;
 

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
 

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CajaDialogo.Error("Debe de ingresar una descripción");
                return;
            }

            if (ValidarBandaSalarial())
            {
                CajaDialogo.Error("Descripción ya existe");
                return;
            }


            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                switch (transaccion_tipo)
                {
                    case TipoTransaccionPlanilla.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("dbo.[uspInsertBandaSalarial]", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType= CommandType.StoredProcedure;

                            cmd.Parameters.Add("@descripcion",SqlDbType.VarChar).Value=txtNombre.Text;
 
                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccionPlanilla.Editar:
                       
                        using (SqlCommand cmd = new SqlCommand("dbo.uspUpdateBandaSalarial", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = bandaSalarial_id;
                            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtNombre.Text;

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
                                
                if (TipoTransaccionPlanilla.Editar==transaccion_tipo)
                {
                    txtNombre.Text= bandaSalarial;      
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public bool ValidarBandaSalarial()
        {
            DataOperations dp = new DataOperations();
            SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

            using (SqlCommand cmd = new SqlCommand("dbo.[uspValidarBandaSalarial]", cnx))
            {
                cnx.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtNombre.Text;


                bool existe = (bool)cmd.ExecuteScalar();

                cnx.Close();
                return existe;   
            }


        }

    }
}