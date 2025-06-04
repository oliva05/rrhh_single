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
using System.DirectoryServices.AccountManagement;

namespace LOSA.ITManagement
{
    public partial class frmAddUserACS : DevExpress.XtraEditors.XtraForm
    {

        DataOperations dp = new DataOperations();
        int tipoOp = 1; //crear
        public int id_user;
        public frmAddUserACS()
        {
            InitializeComponent();
            loaddata();
            //load_Empresa();
            Load_User();
            //load_grupos_ARM();
        }

        public frmAddUserACS(int IdUSer)
        {
            InitializeComponent();
            loaddata();
            id_user = IdUSer;
            labelControl1.Text = "Edicion de Usuario.";
            //load_Empresa();
            tipoOp = 2; // editar
            Load_User();
            lblactivo.Visible = true;
            toggactivo.Visible = true;
            //load_grupos_ARM();

        }
        public void loaddata()
        {
            load_tipo();
            //load_acs();
            //load_losa();
            //load_grupos_ARM();
        }

        public void Load_User()
        {
            string Query = @"sp_load_user_data";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_user", id_user);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (!dr.IsDBNull(1)) txtusuario.Text = dr.GetString(1);
                    if (!dr.IsDBNull(2)) txtuser.Text = dr.GetString(2);
                    if (!dr.IsDBNull(3)) grdTipoUsuario.EditValue = dr.GetString(3);
                    if (!dr.IsDBNull(5)) toggleSwitch1.IsOn = dr.GetBoolean(5);
                    if (!dr.IsDBNull(7)) grdACS.EditValue = dr.GetInt32(7);
                    if (!dr.IsDBNull(8)) grdLOSA.EditValue = dr.GetInt32(8);
                    if (!dr.IsDBNull(6)) toggactivo.IsOn = dr.GetBoolean(6);
                    if (!dr.IsDBNull(9)) grd_empresa.EditValue = dr.GetInt32(9);
                    //if (!dr.IsDBNull(10)) grdARM.EditValue = dr.GetInt32(10);
                }
                cn.Close();
                dr.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        public void load_tipo()
        {
            string query = @"Select distinct tabla.tipo as id, tabla.tipo as tipo
                            from ACs.dbo.conf_usuarios tabla
                            where tabla.tipo <> '' and activo = 1";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //dsusuarios.tipos.Clear();
                //da.Fill(dsusuarios.tipos);

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }



    }
}