using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantAuto
{
    /// <summary>
    /// Creates new RemoveWaiterSettings form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class RemoveWaiterSettings : Form
    {
        Waiter[] waiters;

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveWaiterSettings"/> class.
        /// </summary>
        /// <param name="waiters">The list of waiters.</param>
        public RemoveWaiterSettings(Waiter[] waiters)
        {
            InitializeComponent();
            this.CenterToParent();
            this.waiters = waiters;
        }

        /********************************************
         ***               BUTTONS                ***
         ********************************************/

        // If clicked, it checks if given waiter ID is valid. If it is, opens message box offering confirmation,
        // then finds waiter in file and deletes the waiter. If ID not valid, it says it isn't.
        private void btnOK_Click(object sender, EventArgs e)
        {
            string waiterID = txtID.Text;
            bool deleted = false;

            for (int i = 0; i < waiters.Length; i++)
            {
                if (waiters[i] != null && waiters[i].getWaiterID() == waiterID)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this waiter?", "Remove Waiter", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string line = null;
                        int line_number = 0;
                        int line_to_delete = i+1;

                        using (StreamReader reader = new StreamReader("C:\\Red-E\\employees.txt"))
                        {
                            using (StreamWriter writer = new StreamWriter("C:\\Red-E\\employees_new.txt"))
                            {
                                while ((line = reader.ReadLine()) != null)
                                {
                                    line_number++;

                                    if (line_number == line_to_delete)
                                        continue;

                                    writer.WriteLine(line);
                                }
                            }
                        }
                        
                    }
                    deleted = true;
                    File.Delete(@"C:\Red-E\employees.txt");
                    File.Move(@"C:\Red-E\employees_new.txt", @"C:\Red-E\employees.txt");
                    Close();
                }
            }
            if (deleted == false)
                MessageBox.Show("No employee with that ID exists.");
        }

        // If clicked, close form.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
