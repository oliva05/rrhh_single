using DevExpress.XtraScheduler.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huellas
{
    public partial class SplashForm : Form
    {
        int Interval = 0;
        public SplashForm()
        {
            InitializeComponent();
        }

        public SplashForm(int MiliSegundos)
        {
            InitializeComponent();
            Interval= MiliSegundos;
            timer1.Interval = MiliSegundos;
            timer1.Enabled = true;
            //timer1.Start();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            if(Interval>0)
                timer1.Interval = Interval;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Width += 5;
            if (pictureBox2.Width >= 259)
                this.Close();
        }
    }
}
