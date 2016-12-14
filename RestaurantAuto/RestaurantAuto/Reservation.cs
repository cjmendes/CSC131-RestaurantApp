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
    /// <summary>
    /// Creates new Reservation Form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Reservation : Form
    {
        string name = "";
        string time = "";

        /// <summary>
        /// Initializes a new instance of the <see cref="Reservation"/> class.
        /// </summary>
        public Reservation()
        {
            InitializeComponent();
            this.CenterToParent();
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

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns>Returns string of waiter name.</returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// Gets the time.
        /// </summary>
        /// <returns>Returns string of time.</returns>
        public string getTime()
        {
            return time;
        }
    }
}
