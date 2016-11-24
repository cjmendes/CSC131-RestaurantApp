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
    public partial class Reservation : Form
    {
        string name = "";
        string time = "";

        public Reservation()
        {
            InitializeComponent();
        }

        /********************************************
         ***               BUTTONS                ***
         ********************************************/

        // If clicked, it will assign the variables (name and time) to the text that was inputted
        // and will close the current form 
        private void btnReserve_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to reserve this table?", "Reserve Table", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                name = txtName.Text;
                time = txtTime.Text;
                Close();
            }
        }

        // If clicked, it will close the current form and will NOT record the reservation
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to stop this reservation?", "Reserve Table", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        /********************************************
         ***              FUNCTIONS               ***
         ********************************************/

        // Returns the reservation name
        public String getName()
        {
            return name;
        }

        // Returns the reservation time
        public String getTime()
        {
            return time;
        }
    }
}
