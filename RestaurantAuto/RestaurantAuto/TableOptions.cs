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
    public partial class TableOptions : Form
    {
        int tableNumGlobal = 0;
        string tableAval;
        string name;
        string time;

        // Form must be given the status of the table and the table number. If availability is 'Empty',
        // Vacate button is disabled. If availability is 'Occupied', Assign and Reserve buttons are disabled.
        public TableOptions(string availability, int tableNum)
        {
            InitializeComponent();
            if(availability == "Empty")
            {
                btnVacate.Enabled = false;
            }
            else if (availability == "Occupied")
            {
                btnAssign.Enabled = false;
                btnReserve.Enabled = false;
            }
            tableNumGlobal = tableNum - 1;
        }

        /********************************************
         ***               BUTTONS                ***
         ********************************************/

        // If clicked, tableAval is changed to 'Occupied' and the form is closed
        private void btnAssign_Click(object sender, EventArgs e)
        {
            // TODO: Open new form with list of employees to choose from
            tableAval = "Occupied";
            Close();
        }

        // If clicked, asks if table should be vacated. If yes, tableAval is changed to 'Empty' 
        // and the form is closed
        private void btnVacate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to vacate table?", "Vacate Table", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tableAval = "Empty";
                Close();
            }
        }

        // If clicked, opens a new reservation form, and will retrieve the reservation name and time.
        // tableAval is changed to 'Reserved' and the form is closed.
        private void btnReserve_Click(object sender, EventArgs e)
        {
            Reservation reserve = new Reservation();
            reserve.ShowDialog();
            name = reserve.getName();
            time = reserve.getTime();
            tableAval = "Reserved";
            Close();
        }

        // If clicked, it just closes the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /********************************************
         ***              FUNCTIONS               ***
         ********************************************/

        // Returns the status of the table
        public String getStatus()
        {
            return tableAval;
        }

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
