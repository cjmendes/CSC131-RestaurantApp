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
    public partial class AssignWaiter : Form
    {
        private Waiter[] waiters;
        private string id;

        // Must be passed an array of Waiters. Starts the form, and populates the list box
        public AssignWaiter(Waiter[] waiters)
        {
            InitializeComponent();
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
                if ((w.getFirstName() + ' ' + w.getLastName() == listBox.SelectedItem.ToString()))
                    id = w.getWaiterID();
            }
            Close();
        }

        // If clicked, it closes the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /********************************************
         ***              FUNCTIONS               ***
         ********************************************/

        // If waiter is logged in, then it gets the waiter's first and last name and appends them 
        // to the list box
        public void addWaiters(Waiter[] waiters)
        {
            List<string> _items = new List<string>();
            for (int i = 0; i < waiters.Length; i++)
            {
                if (waiters[i].getStatus() == true)
                    _items.Add(waiters[i].getFirstName() + ' ' + waiters[i].getLastName());
            }
            listBox.DataSource = null;
            listBox.DataSource = _items;
        }

        // Returns the waiter ID
        public string getWaiterID()
        {
            return id;
        }

    }
}
