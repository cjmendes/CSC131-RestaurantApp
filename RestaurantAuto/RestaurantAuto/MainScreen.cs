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
    public partial class MainScreen : Form
    {
        public string[] tableStatus = Enumerable.Repeat("Empty", 20).ToArray();
        string[,] reservationList = new string[20, 2];
        int timeout = 0;
        Table[] table;
        string[] lines;
        private Waiter[] waiters;

        // Must be passed an array of Waiters. Starts the form, read the table setup file into an array
        // creates the tables and then adds the waiters to the list box
        public MainScreen(Waiter[] waiters)
        {
            InitializeComponent();
            lines = System.IO.File.ReadAllLines(@"C:\Users\Chris\Desktop\setup.txt");
            createTables();
            this.waiters = waiters;
            addWaiters(waiters);

        }

        /********************************************
         ***               BUTTONS                ***
         ********************************************/

        // If Log Out button clicked, close this form and opens Form1
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)Tag;
            form1.Show();
            Close();
        }

        // Everytime any table is clicked, it calls this function. If the table is 'Reserved' it calls the
        // 'ReservationInfoForm'. If the reservation is cancelled, then the reservation is cleared from the array.
        // If it is not 'Reserved' then it calls 'TableOptions' where table can be Assigned, Vacated
        // or Reserved. At the end, it checks what the status of the table is and is changed to 
        // the appropriate color
        void btnTable_Click(object sender, EventArgs e)
        {
            timeout = 0;
            var button = sender as Button;
            if (button != null)
            {
                if (table[Int32.Parse(button.Text) - 1].getStatus() == "Reserved")
                {
                    ReservationInfoForm info =
                        new ReservationInfoForm(table[Int32.Parse(button.Text) - 1].getTableNum(),
                        reservationList[Int32.Parse(button.Text) - 1, 0], reservationList[Int32.Parse(button.Text) - 1, 1]);
                    info.ShowDialog();
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
                    tabOpt.ShowDialog();
                    table[Int32.Parse(button.Text) - 1].setStatus(tabOpt.getStatus());
                    if (table[Int32.Parse(button.Text) - 1].getStatus() == "Reserved")
                    {
                        reservationList[Int32.Parse(button.Text) - 1, 0] = tabOpt.getName();
                        reservationList[Int32.Parse(button.Text) - 1, 1] = tabOpt.getTime();
                        button.BackColor = Color.FromArgb(128, 128, 128);
                    }
                    else if (table[Int32.Parse(button.Text) - 1].getStatus() == "Occupied")
                    {
                        table[Int32.Parse(button.Text) - 1].setWaiterID(tabOpt.getWaiterID());
                    }
                }

                if (table[Int32.Parse(button.Text) - 1].getStatus() == "Empty")
                {
                    button.BackColor = Color.FromArgb(0, 255, 0);
                }
                else if (table[Int32.Parse(button.Text) - 1].getStatus() == "Occupied")
                {
                    button.BackColor = Color.FromArgb(255, 0, 0);
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
            timeout++;
            if (timeout >= 60)
            {
                var form1 = (Form1)Tag;
                form1.Show();
                Close();
            }
        }

        /********************************************
         ***              FUNCTION                ***
         ********************************************/

        // This creates all the tables and the buttons for the tables. It reads all the values from the setup array
        // and the creates a new Table class and a button for that table
        public void createTables()
        {            
            table = new Table[lines.Length];

            foreach (string line in lines)
            {
                string[] words = line.Split(',');
                table[Int32.Parse(words[0])] = new Table(Int32.Parse(words[1]), Int32.Parse(words[2]));

                var button = new Button();
                button.Location = new Point(Int32.Parse(words[3]), Int32.Parse(words[4]));
                button.BackColor = Color.FromArgb(Int32.Parse(words[5]), Int32.Parse(words[6]), Int32.Parse(words[7]));
                button.Text = words[8];
                button.Size = new Size(Int32.Parse(words[9]), Int32.Parse(words[10]));
                button.Name = string.Format("btnTable_{0}", words[1]);              
                button.Click += btnTable_Click;
                this.Controls.Add(button);
            }

        }

        // Receives an array of Waiters and gets each of the waiter's first and last name who are logged in
        // and populates the list box with them
        public void addWaiters(Waiter[] waiters)
        {
            List<string> _items = new List<string>();
            for (int i = 0; i < waiters.Length; i++)
            {
                if (waiters[i].getStatus() == true)
                    _items.Add(waiters[i].getFirstName() + ' ' + waiters[i].getLastName());
            }
            listWaiters.DataSource = null;
            listWaiters.DataSource = _items;
        }
    }
}
