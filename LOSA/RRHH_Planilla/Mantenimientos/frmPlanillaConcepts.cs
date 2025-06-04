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
    public partial class frmPlanillaConcepts : DevExpress.XtraEditors.XtraForm
    {
        Conceptos concepto = new Conceptos();

        public enum TipoTransaccionPlanilla
        {
            Nuevo=1,
            Editar=2
        }

        TipoTransaccionPlanilla transaccion_tipo;

        UserLogin usuario = new UserLogin();
        int concept_id;
        public frmPlanillaConcepts(TipoTransaccionPlanilla transact,UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo= transact;
            usuario=user_p;
            CargarDatosCategoria();
            CargarDatosGrupo();
        }

        public frmPlanillaConcepts(TipoTransaccionPlanilla transact, int id_concept)
        {
            InitializeComponent();
            transaccion_tipo = transact;
            concept_id = id_concept;
            CargarDatosCategoria();
            CargarDatosGrupo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (slueCategoria.EditValue == null)
            {
                CajaDialogo.Error("Debe se seleccionar una categoria");
                return;
            }

            if (slueGrupo.EditValue == null)
            {
                CajaDialogo.Error("Debe se seleccionar un grupo");
                return;
            }

            if (string.IsNullOrEmpty(txtCode.Text))
            {
                CajaDialogo.Error("Debe de ingresar un codigo");
                return;
            }

            if (string.IsNullOrEmpty(txtConcepto.Text))
            {
                CajaDialogo.Error("Debe de ingresar un concepto");
                return;
            }

            if (TipoTransaccionPlanilla.Nuevo== transaccion_tipo)
            {
                if (ValidarCodigo())
                {
                    CajaDialogo.Error("Ya existe este código");
                    return;
                }
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                switch (transaccion_tipo)
                {
                    case TipoTransaccionPlanilla.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("[uspInsertConcepts]", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType= CommandType.StoredProcedure;

                            cmd.Parameters.Add("@name",SqlDbType.VarChar).Value=txtConcepto.Text;
                            cmd.Parameters.Add("@note",SqlDbType.VarChar).Value=txtNota.Text;
                            cmd.Parameters.Add("@code",SqlDbType.VarChar).Value=txtCode.Text;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value=usuario.Id;
                            cmd.Parameters.Add("@group_by_id", SqlDbType.Int).Value=slueGrupo.EditValue==null?DBNull.Value: slueGrupo.EditValue;
                            cmd.Parameters.Add("@category_id", SqlDbType.Int).Value=slueCategoria.EditValue;
                       

                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccionPlanilla.Editar:
                       
                        using (SqlCommand cmd = new SqlCommand("uspUpdateConcepts", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtConcepto.Text;
                            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = txtNota.Text;
                            //cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = txtCode.Text;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = concept_id;
                            cmd.Parameters.Add("@group_by_id", SqlDbType.Int).Value = slueGrupo.EditValue == null ? DBNull.Value : slueGrupo.EditValue;
                            cmd.Parameters.Add("@category_id", SqlDbType.Int).Value = slueCategoria.EditValue;


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
                concepto=new Conceptos();

                concepto.RecuperaRegistro(concept_id);

                if (TipoTransaccionPlanilla.Editar==transaccion_tipo)
                {
                    txtCode.Text= concepto.Code;
                    txtConcepto.Text= concepto.Name;
                    txtNota.Text= concepto.Note;
                    txtCode.Enabled = false;
                    slueCategoria.EditValue = concepto.CategoriaID;
                    slueGrupo.EditValue = concepto.GrupoID;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarDatosGrupo()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla.Groups.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetGroups", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla.Groups);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarDatosCategoria()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla.Categoria.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadSalaryRuleCategory", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla.Categoria);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public bool ValidarCodigo()
        {
            DataOperations dp = new DataOperations();
            SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
            bool existe = false;

            using (SqlCommand cmd = new SqlCommand("dbo.[uspValidateConceptsCode]", cnx))
            {
                cnx.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = txtCode.EditValue;


                existe = (bool)cmd.ExecuteScalar();

                cnx.Close();
            }

            return existe;
        }
    }
}