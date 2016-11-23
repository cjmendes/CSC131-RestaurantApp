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
        int timeout = 0;

        public MainScreen()
        {
            InitializeComponent();
        }

        /********************************************
         ***               BUTTONS                ***
         ********************************************/

        // If Log Out button clicked, close this form and opens Form1
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)Tag;
            form1.Show();
            Close();
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            btnAssign.Enabled = true;
        }

        /********************************************
         ***                TIMERS                ***
         ********************************************/

        // Timer get clock time and passes it as string to label
        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        // Timer ticks every second. Once it reaches 60, MainScreen form closes
        // and brings Form1 form back
        private void tmrTimeout_Tick(object sender, EventArgs e)
        {
            timeout++;
            label1.Text = "" + timeout;
            if (timeout >= 60)
            {
                var form1 = (Form1)Tag;
                form1.Show();
                Close();
            }
        }

        private void btnVacate_Click(object sender, EventArgs e)
        {
            // btnTable1.BackColor = 
        }
    }
}
