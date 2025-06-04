using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.RRHH_Planilla.Mantenimientos;
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

namespace LOSA.Logistica.CheckList
{
    public partial class frmCheckListItemsHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLogged;
        public frmCheckListItemsHome(UserLogin usuarioLog)
        {
            InitializeComponent();
            CargarDatos();

            usuarioLogged = usuarioLog;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCheckListItemsCRUD frm = new frmCheckListItemsCRUD(frmCheckListItemsCRUD.TipoTransaccion.Save, usuarioLogged);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        public void CargarDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                dsCheckList1.checklist_items.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadCheckList", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
     
                    da.Fill(dsCheckList1.checklist_items);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsCheckList.checklist_itemsRow)gvItems.GetFocusedDataRow();

                frmCheckListItemsCRUD frm = new frmCheckListItemsCRUD(frmCheckListItemsCRUD.TipoTransaccion.Update,row.id);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsCheckList.checklist_itemsRow)gvItems.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringLOSA);

                var respuesta = CajaDialogo.Pregunta("¿Desea borrar el registro?");

                if (respuesta == DialogResult.Yes)
                {

                    using (SqlCommand cmd = new SqlCommand("dbo.uspDisableChecklistItem", cnx))
                    {
                        cnx.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                    }

                    CajaDialogo.Information("Datos deshabilitados!");
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}