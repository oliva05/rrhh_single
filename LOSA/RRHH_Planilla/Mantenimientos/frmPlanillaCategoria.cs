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
    public partial class frmPlanillaCategoria : DevExpress.XtraEditors.XtraForm
    {
        PlanillaSalaryRuleCategory categoria = new PlanillaSalaryRuleCategory();

        public enum TipoTransaccionPlanilla
        {
            Nuevo=1,
            Editar=2
        }

        TipoTransaccionPlanilla transaccion_tipo;
        UserLogin usuario = new UserLogin();
        int categoria_id;
        public frmPlanillaCategoria(TipoTransaccionPlanilla transact,UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo= transact;
            usuario=user_p;
        }

        public frmPlanillaCategoria(TipoTransaccionPlanilla transact, int id_categoria)
        {
            InitializeComponent();
            transaccion_tipo = transact;
            categoria_id = id_categoria;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                if (string.IsNullOrEmpty(txtCode.Text))
                {
                    CajaDialogo.Error("Debe de ingresar un codigo");
                    return;
                }

                if (string.IsNullOrEmpty(txtCategoria.Text))
                {
                    CajaDialogo.Error("Debe de ingresar una categoria");
                    return;
                }

                switch (transaccion_tipo)
                {
                    case TipoTransaccionPlanilla.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("uspInsertCategoriaPlanilla", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType= CommandType.StoredProcedure;

                            cmd.Parameters.Add("@name",SqlDbType.VarChar).Value=txtCategoria.Text;
                            cmd.Parameters.Add("@note",SqlDbType.VarChar).Value=txtNota.Text;
                            cmd.Parameters.Add("@code",SqlDbType.VarChar).Value=txtCode.Text;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value=usuario.Id;
                            cmd.Parameters.Add("@provision", SqlDbType.Bit).Value=ceProvision.EditValue;
                            cmd.Parameters.Add("@patronal", SqlDbType.Bit).Value=cePatronal.EditValue;
                            cmd.Parameters.Add("@isrdeductible", SqlDbType.Bit).Value=ceDeducible.EditValue;

                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccionPlanilla.Editar:
                       
                        using (SqlCommand cmd = new SqlCommand("uspUpdateSalaryRuleCategory", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = categoria.ID;
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtCategoria.Text;
                            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = txtNota.Text;
                            //cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = txtCode.Text;
                            //cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@provision", SqlDbType.Bit).Value = ceProvision.EditValue;
                            cmd.Parameters.Add("@patronal", SqlDbType.Bit).Value = cePatronal.EditValue;
                            cmd.Parameters.Add("@isrdeducible", SqlDbType.Bit).Value = ceDeducible.EditValue;

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
                categoria=new PlanillaSalaryRuleCategory();

                categoria.RecuperaRegistro(categoria_id);

                if (TipoTransaccionPlanilla.Editar==transaccion_tipo)
                {
                    txtCode.Text=categoria.Code;
                    txtCode.Enabled=false;
                    txtCategoria.Text=categoria.Name;
                    txtNota.Text=categoria.Note;
                    ceDeducible.EditValue=categoria.Deducible;
                    cePatronal.EditValue=categoria.Patronal;
                    ceProvision.EditValue=categoria.Provisional;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}