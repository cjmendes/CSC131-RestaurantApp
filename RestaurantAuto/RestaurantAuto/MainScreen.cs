using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RestaurantAuto
{
    public partial class MainScreen : Form
    {

        public MainScreen()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)Tag;
            form1.Show();
            Hide();
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            btnAssign.Enabled = true;
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
    }
}
