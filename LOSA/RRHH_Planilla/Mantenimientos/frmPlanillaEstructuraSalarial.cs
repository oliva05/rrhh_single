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
    public partial class frmPlanillaEstructuraSalarial : DevExpress.XtraEditors.XtraForm
    {
        EstructuraSalarial estructura_salarial = new EstructuraSalarial();

        public enum TipoTransaccion
        {
            Nuevo=1,
            Editar=2
        }

        TipoTransaccion transaccion_tipo;

        UserLogin usuario = new UserLogin();
        int estructura_id;
       
        public frmPlanillaEstructuraSalarial(TipoTransaccion transact,UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo= transact;
            usuario=user_p;
            CargarCompania();
            CargarDatosCurrency();


        }

        public frmPlanillaEstructuraSalarial(TipoTransaccion transact, int id_estructura, UserLogin user_p)
        {
            InitializeComponent();
            CargarCompania();
            CargarDatosCurrency();

            transaccion_tipo = transact;
            estructura_id = id_estructura;
            
            usuario = user_p;
       

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
 

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                CajaDialogo.Error("Debe de ingresar un código");
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CajaDialogo.Error("Debe de ingresar un nombre");
                return;
            }

            if (lueCompania.EditValue== null)
            {
                CajaDialogo.Error("Debe de seleccionar una compañía");
                return;
            }



            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                switch (transaccion_tipo)
                {
                    case TipoTransaccion.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("dbo.[uspInsertEstructuraSalarial]", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType= CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@name",txtNombre.Text);
                            cmd.Parameters.AddWithValue("@code",txtCodigo.Text);
                            cmd.Parameters.AddWithValue("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.AddWithValue("@company_id",  lueCompania.EditValue);
                            cmd.Parameters.AddWithValue("@currency_id",  lueMoneda.EditValue);
 
                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccion.Editar:
                       
                        using (SqlCommand cmd = new SqlCommand("dbo.uspUpdateEstructuraSalarial", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@id",  estructura_salarial.Id);
                            cmd.Parameters.AddWithValue("@name", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@code", txtCodigo.Text);
                            cmd.Parameters.AddWithValue("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.AddWithValue("@company_id", lueCompania.EditValue);
                            cmd.Parameters.AddWithValue("@currency_id", lueMoneda.EditValue);


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
                estructura_salarial=new EstructuraSalarial();

                estructura_salarial.RecuperaRegistro(estructura_id);
                
                if (TipoTransaccion.Editar==transaccion_tipo)
                {
                    txtNombre.Text= estructura_salarial.Nombre;
                    txtCodigo.Text= estructura_salarial.Codigo;
                    lueMoneda.EditValue = estructura_salarial.MonedaId;
                    lueCompania.EditValue = estructura_salarial.CompaniaId;
                }
                else
                {
                    lueCompania.EditValue = 1; // Aquafeed
                    lueMoneda.EditValue = 44; //HNL
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        public void CargarCompania()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla1.Compania.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetCompany", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla1.Compania);
                    cnx.Close();
                }
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

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla1.currency.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadCurrency", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla1.currency);
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