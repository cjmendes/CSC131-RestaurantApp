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

        void clockTimer_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {

        }

        private void btnVacate_Click(object sender, EventArgs e)
        {
            // btnTable1.BackColor = 
        }
    }
}
