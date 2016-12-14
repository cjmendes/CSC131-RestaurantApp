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
    /// Creates a Settings Form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Settings : Form
    {
        private Waiter[] waiters;

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        /// <param name="waiters">The list of waiters.</param>
        public Settings(Waiter[] waiters)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.waiters = waiters;
            btnTableSetup.Enabled = false;
        }

        /********************************************
         ***               BUTTONS                ***
         ********************************************/

        // If clicked, opens new AddWaiterSettings form.
        private void btnAddWaiter_Click(object sender, EventArgs e)
        {
            AddWaiterSettings add = new AddWaiterSettings(waiters);
            add.Show();
        }

        // If clicked, opens new RemoveWaiterSettings form.
        private void btnDeleteWaiter_Click(object sender, EventArgs e)
        {
            RemoveWaiterSettings rem = new RemoveWaiterSettings(waiters);
            rem.Show();
        }

        // If clicked, closes this form.
        private void btnExit_Click(object sender, EventArgs e)
        {
            var options = (Options)Tag;
            options.Show();
            Close();
        }
    }
}
