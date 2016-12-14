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
    /// Creates a ReservationInfoForm form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ReservationInfoForm : Form
    {
        string status = "Reserved";

        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationInfoForm"/> class.
        /// </summary>
        /// <param name="tableNum">The table number.</param>
        /// <param name="reservationName">Name of customer for the reservation.</param>
        /// <param name="reservationTime">The reservation time.</param>
        public ReservationInfoForm(int tableNum, string reservationName, string reservationTime)
        {
            InitializeComponent();
            this.CenterToParent();
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

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <returns>Returns string of status.</returns>
        public String getStatus()
        {
            return status;
        }
    }
}
