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
    public partial class ReservationInfoForm : Form
    {
        string status = "Reserved";

        // Form must be given a table name, the name and the time of the reservation
        // Initializes all the labels with the information given
        public ReservationInfoForm(int tableNum, string reservationName, string reservationTime)
        {
            InitializeComponent();
            lblTableNum.Text = "Table #" + tableNum;
            lblReservationName.Text = "Name: " + reservationName;
            lblReservationTime.Text = "Time: " + reservationTime;
        }

        /********************************************
         ***               BUTTONS                ***
         ********************************************/

        // If clicked, just closes the form
        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        // If clicked, it will set the status to 'Empty' and close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this reservation?", "Cancel Reservation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                status = "Empty";
            }
            Close();
        }

        /********************************************
         ***              FUNCTIONS               ***
         ********************************************/

        // Returns the status string
        public String getStatus()
        {
            return status;
        }
    }
}
