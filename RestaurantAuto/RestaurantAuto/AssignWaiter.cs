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
    /// Creates new AssignWaiter form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AssignWaiter : Form
    {
        private Waiter[] waiters;
        private string id;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignWaiter"/> class.
        /// </summary>
        /// <param name="waiters">The list of waiters.</param>
        public AssignWaiter(Waiter[] waiters)
        {
            InitializeComponent();
            this.CenterToParent();
            this.waiters = waiters;
            addWaiters(this.waiters);
        }

        /********************************************
         ***               BUTTONS                ***
         ********************************************/

        // If clicked, it searches through the list box and if the first and last name is equal to
        // the selected item in the list box, then it stores the waiter's ID and closes the form
        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach (Waiter w in waiters)
            {
                if (w != null && (w.getFirstName() + ' ' + w.getLastName() == listBox.SelectedItem.ToString()))
                    id = w.getWaiterID();
            }
            Close();
        }

        // If clicked, it closes the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            id = "";
            Close();
        }

        /********************************************
         ***              FUNCTIONS               ***
         ********************************************/

        /// <summary>
        /// If waiter is logged in, then it gets the waiter's first and last name and appends them 
        /// to the list box
        /// </summary>
        /// <param name="waiters">The list of waiters.</param>
        public void addWaiters(Waiter[] waiters)
        {
            List<string> _items = new List<string>();
            for (int i = 0; i < waiters.Length; i++)
            {
                if (waiters[i] != null && waiters[i].getStatus() == true)
                    _items.Add(waiters[i].getFirstName() + ' ' + waiters[i].getLastName());
            }
            listBox.DataSource = null;
            listBox.DataSource = _items;
        }

        /// <summary>
        /// Gets the waiter identifier.
        /// </summary>
        /// <returns>Returns string of waiter ID.</returns>
        public string getWaiterID()
        {
            return id;
        }

    }
}
