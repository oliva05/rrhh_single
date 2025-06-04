using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.ITManagement
{
    public partial class frmUsuariosAccesos : DevExpress.XtraEditors.XtraForm
    {
        public frmUsuariosAccesos()
        {
            InitializeComponent();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            //Agregar un nuevo user
            frmAddUserACS frmU = new frmAddUserACS();
            if (frmU.ShowDialog() == DialogResult.OK)
            {
                //CargarUsuarios();
            }
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //try
            //{
            //    var gridView = (GridView)gridControl1.FocusedView;
            //    var row = (dsMant_IT.usuariosRow)gridView.GetFocusedDataRow();

            //    frmAddUserACS frm = new frmAddUserACS(row.id);
            //    if (frm.ShowDialog() == DialogResult.OK)
            //    {
            //        CargarUsuarios();
            //    }
            //}
            //catch (Exception ex)
            //{

            //    CajaDialogo.Error(ex.Message);
            //}
        }
    }
}