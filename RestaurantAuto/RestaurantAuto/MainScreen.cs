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

        public MainScreen()
        {
            InitializeComponent();
            btnTable1.BackColor = Color.FromArgb(0, 255, 0);
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

        private void btnTable1_Click(object sender, EventArgs e)
        {
            /*
             * IMPORTANT,THIS CODE WILL BE USED FOR EVERY TABLE! 
             */
            timeout = 0;
            if (tableStatus[0] == "Reserved")
            {
                ReservationInfoForm info = new ReservationInfoForm(0, reservationList[0, 0], reservationList[0, 1]);
                info.ShowDialog();
                tableStatus[0] = info.getStatus();
                if (tableStatus[0] == "Empty")
                {
                    reservationList[0, 0] = "";
                    reservationList[0, 1] = "";
                }
            }
            else
            {
                TableOptions tabOpt = new TableOptions(tableStatus[0], 1);
                tabOpt.ShowDialog();
                tableStatus[0] = tabOpt.getStatus();
                if (tableStatus[0] == "Reserved")
                {
                    reservationList[0, 0] = tabOpt.getName();
                    reservationList[0, 1] = tabOpt.getTime();
                }
            }
            changeTableColor(0);
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

        public void changeTableColor(int position)
        {
            if (tableStatus[position] == "Empty")
            {
                btnTable1.BackColor = Color.FromArgb(0, 255, 0);
            }
            else if (tableStatus[position] == "Occupied")
            {
                btnTable1.BackColor = Color.FromArgb(255, 0, 0);
            }
            else if (tableStatus[position] == "Reserved")
            {
                btnTable1.BackColor = Color.FromArgb(128, 128, 128);
            }
        }
    }
}
