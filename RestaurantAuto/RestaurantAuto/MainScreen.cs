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
    /// Creates new MainScreen form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainScreen : Form
    {
        string[,] reservationList = new string[20, 2];
        Table[] table;
        string[] lines;
        bool admin = false;
        private Waiter[] waiters;
        //int timeout = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainScreen"/> class.
        /// </summary>
        /// <param name="waiters">The list of waiters.</param>
        /// <param name="admin">if set to <c>true</c> [admin].</param>
        public MainScreen(Waiter[] waiters, bool admin)
        {
            InitializeComponent();
            this.CenterToScreen();
            lines = System.IO.File.ReadAllLines(@"C:\Red-E\setup.txt");
            createTables();
            this.waiters = waiters;
            this.admin = admin;
            addWaiters(waiters);

        }

        /********************************************
         ***               BUTTONS                ***
         ********************************************/

        // If Log Out button clicked, close this form and opens Form1
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (admin == true)
            {
                var options = (Options)Tag;
                options.Show();
                Hide();
            }
            else
            {
                var form1 = (LogIn)Tag;
                form1.Show();
                Hide();
            }
        }

        // Everytime any table is clicked, it calls this function. If the table is 'Reserved' it calls the
        // 'ReservationInfoForm'. If the reservation is cancelled, then the reservation is cleared from the array.
        // If it is not 'Reserved' then it calls 'TableOptions' where table can be Assigned, Vacated
        // or Reserved. At the end, it checks what the status of the table is and is changed to 
        // the appropriate color
        void btnTable_Click(object sender, EventArgs e)
        {
            //timeout = 0;
            var button = sender as Button;
            if (button != null)
            {
                if (table[Int32.Parse(button.Text) - 1].getStatus() == "Reserved")
                {
                    ReservationInfoForm info =
                        new ReservationInfoForm(table[Int32.Parse(button.Text) - 1].getTableNum(),
                        reservationList[Int32.Parse(button.Text) - 1, 0], reservationList[Int32.Parse(button.Text) - 1, 1]);
                    info.StartPosition = FormStartPosition.CenterParent;
                    info.ShowDialog(this);
                    table[Int32.Parse(button.Text) - 1].setStatus(info.getStatus());
                    if (table[Int32.Parse(button.Text) - 1].getStatus() == "Empty")
                    {
                        reservationList[Int32.Parse(button.Text) - 1, 0] = "";
                        reservationList[Int32.Parse(button.Text) - 1, 1] = "";
                    }
                }
                else
                {
                    TableOptions tabOpt = new TableOptions(table[Int32.Parse(button.Text) - 1].getStatus(),
                        table[Int32.Parse(button.Text) - 1].getTableNum(), waiters, table);
                    tabOpt.StartPosition = FormStartPosition.CenterParent;
                    tabOpt.ShowDialog(this);
                    table[Int32.Parse(button.Text) - 1].setStatus(tabOpt.getStatus());
                    if (table[Int32.Parse(button.Text) - 1].getStatus() == "Reserved")
                    {
                        reservationList[Int32.Parse(button.Text) - 1, 0] = tabOpt.getName();
                        reservationList[Int32.Parse(button.Text) - 1, 1] = tabOpt.getTime();

                        if (table[Int32.Parse(button.Text) - 1].getTableCapacity() == 2)
                        {
                            if (table[Int32.Parse(button.Text) - 1].getRotation() == "normal")
                                button.BackgroundImage = RestaurantAuto.Properties.Resources.table_2_res;
                            else
                                button.BackgroundImage = RestaurantAuto.Properties.Resources.table_2_res_rev;
                        }
                        else if (table[Int32.Parse(button.Text) - 1].getTableCapacity() == 4)
                        {
                            if (table[Int32.Parse(button.Text) - 1].getRotation() == "normal")
                                button.BackgroundImage = RestaurantAuto.Properties.Resources.table_4_res;
                            else
                                button.BackgroundImage = RestaurantAuto.Properties.Resources.table_4_res_rev;
                        }
                        else if (table[Int32.Parse(button.Text) - 1].getTableCapacity() == 8)
                        {
                            if (table[Int32.Parse(button.Text) - 1].getRotation() == "normal")
                                button.BackgroundImage = RestaurantAuto.Properties.Resources.table_8_res;
                            else
                                button.BackgroundImage = RestaurantAuto.Properties.Resources.table_8_res_rev;
                        }
                    }
                    else if (table[Int32.Parse(button.Text) - 1].getStatus() == "Occupied")
                    {
                        table[Int32.Parse(button.Text) - 1].setWaiterID(tabOpt.getWaiterID());
                    }
                }

                if (table[Int32.Parse(button.Text) - 1].getStatus() == "Empty")
                {
                    if (table[Int32.Parse(button.Text) - 1].getTableCapacity() == 2)
                    {
                        if (table[Int32.Parse(button.Text) - 1].getRotation() == "normal")
                            button.BackgroundImage = RestaurantAuto.Properties.Resources.table_2_avl;
                        else
                            button.BackgroundImage = RestaurantAuto.Properties.Resources.table_2_avl_rev;
                    }
                    else if (table[Int32.Parse(button.Text) - 1].getTableCapacity() == 4)
                    {
                        if (table[Int32.Parse(button.Text) - 1].getRotation() == "normal")
                            button.BackgroundImage = RestaurantAuto.Properties.Resources.table_4_avl;
                        else
                            button.BackgroundImage = RestaurantAuto.Properties.Resources.table_4_avl_rev;
                    }
                    else if (table[Int32.Parse(button.Text) - 1].getTableCapacity() == 8)
                    {
                        if (table[Int32.Parse(button.Text) - 1].getRotation() == "normal")
                            button.BackgroundImage = RestaurantAuto.Properties.Resources.table_8_avl;
                        else
                            button.BackgroundImage = RestaurantAuto.Properties.Resources.table_8_avl_rev;
                    }
                }
                else if (table[Int32.Parse(button.Text) - 1].getStatus() == "Occupied")
                {
                    if (table[Int32.Parse(button.Text) - 1].getTableCapacity() == 2)
                    {
                        if (table[Int32.Parse(button.Text) - 1].getRotation() == "normal")
                            button.BackgroundImage = RestaurantAuto.Properties.Resources.table_2_occ;
                        else
                            button.BackgroundImage = RestaurantAuto.Properties.Resources.table_2_occ_rev;
                    }
                    else if (table[Int32.Parse(button.Text) - 1].getTableCapacity() == 4)
                    {
                        if (table[Int32.Parse(button.Text) - 1].getRotation() == "normal")
                            button.BackgroundImage = RestaurantAuto.Properties.Resources.table_4_occ;
                        else
                            button.BackgroundImage = RestaurantAuto.Properties.Resources.table_4_occ_rev;
                    }
                    else if (table[Int32.Parse(button.Text) - 1].getTableCapacity() == 8)
                    {
                        if (table[Int32.Parse(button.Text) - 1].getRotation() == "normal")
                            button.BackgroundImage = RestaurantAuto.Properties.Resources.table_8_occ;
                        else
                            button.BackgroundImage = RestaurantAuto.Properties.Resources.table_8_occ_rev;
                    }

                }
            }
        }

        /********************************************
         ***                TIMERS                ***
         ********************************************/

        // Timer get clock time and passes it as string to label
        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        // Timer ticks every second. Once it reaches 60, MainScreen form closes
        // and brings Form1 form back
        private void tmrTimeout_Tick(object sender, EventArgs e)
        {
            /*timeout++;
            if (timeout >= 60)
            {
                var form1 = (Form1)Tag;
                form1.Show();
                Close();
            }*/
        }

        /********************************************
         ***              FUNCTION                ***
         ********************************************/

        /// <summary>
        /// Creates all the tables and the buttons for the tables. It reads all the values from the setup array
        /// and the creates a new Table class and a button for that table.
        /// </summary>
        public void createTables()
        {            
            table = new Table[lines.Length];

            foreach (string line in lines)
            {
                string[] words = line.Split(',');
                table[Int32.Parse(words[0])] = new Table(Int32.Parse(words[1]), Int32.Parse(words[2]), words[7]);

                var button = new Button();
                button.Location = new Point(Int32.Parse(words[3]), Int32.Parse(words[4]));
                if (words[2] == "2")
                {
                    if (words[7] == "normal")
                        button.BackgroundImage = RestaurantAuto.Properties.Resources.table_2_avl;
                    else
                        button.BackgroundImage = RestaurantAuto.Properties.Resources.table_2_avl_rev;
                }
                else if (words[2] == "4")
                {
                    if (words[7] == "normal")
                        button.BackgroundImage = RestaurantAuto.Properties.Resources.table_4_avl;
                    else
                        button.BackgroundImage = RestaurantAuto.Properties.Resources.table_4_avl_rev;
                }
                else if (words[2] == "8")
                {
                    if (words[7] == "normal")
                        button.BackgroundImage = RestaurantAuto.Properties.Resources.table_8_avl;
                    else
                        button.BackgroundImage = RestaurantAuto.Properties.Resources.table_8_avl_rev;
                }
                button.BackgroundImageLayout = ImageLayout.Zoom;
                button.TabStop = false;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Text = words[1];
                button.Size = new Size(Int32.Parse(words[5]), Int32.Parse(words[6]));
                button.Name = string.Format("btnTable_{0}", words[1]);              
                button.Click += btnTable_Click;
                this.Controls.Add(button);
            }

        }

        /// <summary>
        /// Gets each of the waiter's first and last name who are logged in and populates the list box with them.
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
            listWaiters.DataSource = null;
            listWaiters.DataSource = _items;
        }
    }
}
