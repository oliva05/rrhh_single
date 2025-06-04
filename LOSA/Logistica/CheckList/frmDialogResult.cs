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

namespace LOSA.Logistica.CheckList
{
    public partial class frmDialogResult : DevExpress.XtraEditors.XtraForm
    {
       
        public enum MessageDialog
        {
            DialogResult = 1,
            Message = 2
        }

        MessageDialog mensajeActual;

        public frmDialogResult(string message,MessageDialog mensajeDialog)
        {
            InitializeComponent();
            mensajeActual = mensajeDialog;

            lblMessage.Text = message;


            if (mensajeDialog == MessageDialog.Message)
            {
                btnOK.Left = (this.Width - btnOK.Width) / 2;  // Centrar horizontalmente
                btnYes.Visible = false;
                btnNo.Visible = false;
            }

            if (mensajeDialog == MessageDialog.DialogResult)
            {
               
                btnOK.Visible = false;
            }
        }
    }
}