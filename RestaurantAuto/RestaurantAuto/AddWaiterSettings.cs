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
    /// Creates new AddWaiterSettings form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AddWaiterSettings : Form
    {
        Waiter[] waiters;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddWaiterSettings"/> class.
        /// </summary>
        /// <param name="waiters">The list of waiters.</param>
        public AddWaiterSettings(Waiter[] waiters)
        {
            InitializeComponent();
            this.CenterToParent();
            this.waiters = waiters;
        }

        /********************************************
         ***               BUTTONS                ***
         ********************************************/

        // If clicked, creates new employee and inserts into employee file.
        private void btnOK_Click(object sender, EventArgs e)
        {
            string employee = System.Environment.NewLine + txtNumber.Text + ',' + txtFirstName.Text + ',' + txtLastName.Text + ",false";
            System.IO.File.AppendAllText(@"C:\Red-E\employees.txt", employee);
            MessageBox.Show("Employee succesfully created.");
            Close();
        }

        // If clicked, closes the form.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
