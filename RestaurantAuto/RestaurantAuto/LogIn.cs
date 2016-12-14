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
    /// Creates new LogIn form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LogIn : Form
    {
        int[] logIn = Enumerable.Repeat(-1, 4).ToArray();
        int logInPosition = 0;
        string[] lines;
        Waiter[] waiters;

        /// <summary>
        /// Initializes a new instance of the <see cref="LogIn"/> class.
        /// </summary>
        public LogIn()
        {
            InitializeComponent();
            this.CenterToScreen();
            lines = System.IO.File.ReadAllLines(@"C:\Red-E\employees.txt");
            waiters = new Waiter[lines.Length+10];
            int i = 0;
            foreach (string line in lines)
            {
                string[] words = line.Split(',');
                waiters[i] = new Waiter(words[0], words[1], words[2], bool.Parse(words[3]), bool.Parse(words[4]));
                i++;
            }
            populateForm();
        }

        /********************************************
         ***               BUTTONS                ***
         ********************************************/

        // Adds the number clicked to the current label position
        private void num1But_Click(object sender, EventArgs e)  
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 1;
                logInPosition++;
                refreshLogIn();
            }
        }

        // Adds the number clicked to the current label position
        private void num2But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 2;
                logInPosition++;
                refreshLogIn();
            }
        }

        // Adds the number clicked to the current label position
        private void num3But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 3;
                logInPosition++;
                refreshLogIn();
            }
        }

        // Adds the number clicked to the current label position
        private void num4But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 4;
                logInPosition++;
                refreshLogIn();
            }
        }

        // Adds the number clicked to the current label position
        private void num5But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 5;
                logInPosition++;
                refreshLogIn();
            }
        }

        // Adds the number clicked to the current label position
        private void num6But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 6;
                logInPosition++;
                refreshLogIn();
            }
        }

        // Adds the number clicked to the current label position
        private void num7But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 7;
                logInPosition++;
                refreshLogIn();
            }
        }

        // Adds the number clicked to the current label position
        private void num8But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 8;
                logInPosition++;
                refreshLogIn();
            }
        }

        // Adds the number clicked to the current label position
        private void num9But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 9;
                logInPosition++;
                refreshLogIn();
            }
        }

        // Adds the number clicked to the current label position
        private void num0But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 0;
                logInPosition++;
                refreshLogIn();
            }
        }

        // Removes the last button clicked and restores to "-"
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (logInPosition > 0) { 
                if (logInPosition == 1)
                    logIn[0] = -1;
                else if (logInPosition == 2)
                    logIn[1] = -1;
                else if (logInPosition == 3)
                    logIn[2] = -1;
                else if (logInPosition == 4)
                    logIn[3] = -1;
                refreshLogIn();
                logInPosition--;
            }
        }

        // If clicked checks whether there were 4 values inputed. If not, it just clears the screen,
        // but if it does, calls checkPassword()
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
                clearLogIn();
            else
                checkPassword();
        }
        
        // When pressed, if waiter is not logged in, it will display message showing waiter not logged in.
        // If logged in, it will disable the waiter from the program until logged in again.
        private void btnWaiterLogout_Click(object sender, EventArgs e)
        {
            string tempPass = "" + logIn[0] + logIn[1] + logIn[2] + logIn[3];
            for (int i = 0; i < waiters.Length; i++)
            {
                if (waiters[i] != null && tempPass == waiters[i].getWaiterID())
                {
                    if (waiters[i].getStatus() == true)
                    {
                        waiters[i].changeStatus();
                        clearLogIn();
                        MessageBox.Show("You have been logged out " + waiters[i].getName(tempPass) + ".");
                    }
                    else
                    {
                        clearLogIn();
                        MessageBox.Show(waiters[i].getName(tempPass) + " is not logged in.");
                    }
                }
            }
        }

        // When pressed, ask if you want to shut down program. If yes, then looks for log file and then deletes it
        private void btnShutDown_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the system?", "System Shutdown", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (System.IO.File.Exists(@"C:\Red-E\log.txt"))
                {
                    System.IO.File.Delete(@"C:\Red-E\log.txt");
                }
                Close();
            }
        }

        /********************************************
         ***              FUNCTIONS               ***
         ********************************************/

        /// <summary>
        /// Restores all 4 login labels to "-".
        /// </summary>
        private void clearLogIn()
        {
            for (int i = 0; i < logIn.Length; i++)
                logIn[i] = -1;
            logInPosition = 0;
            refreshLogIn();
        }

        /// <summary>
        /// Checks whether the 4 values are the same as the password. Password is a static '1234' right now.
        /// If it fails, it clears the values, if it works, it clears the password, hides the form and opens
        /// up a MainScreen form
        /// </summary>
        private void checkPassword()
        {
            string tempPass = "" + logIn[0] + logIn[1] + logIn[2] + logIn[3];
            for (int i = 0; i < waiters.Length; i++)
            {
                if (waiters[i] != null && tempPass == waiters[i].getWaiterID())
                {
                    if (waiters[i].getStatus() == false)
                        waiters[i].changeStatus();
                    clearLogIn();
                    if (waiters[i].getAdmin() == true)
                    {
                        Options opt = new Options(waiters);
                        opt.Tag = this;
                        opt.Show(this);
                        Hide();
                    }
                    else
                    {
                        MainScreen msForm = new MainScreen(waiters, false);
                        msForm.Tag = this;
                        msForm.Show(this);
                        Hide();
                    }
                }
            }
            clearLogIn();
        }

        /// <summary>
        /// Refreshes the labels with what is in place.
        /// </summary>
        private void refreshLogIn()
        {

            if (logIn[0] == -1)
                lblLogInput1.Text = "-";
            else
                lblLogInput1.Text = "" + logIn[0];

            if (logIn[1] == -1)
                lblLogInput2.Text = "-";
            else
                lblLogInput2.Text = "" + logIn[1];

            if (logIn[2] == -1)
                lblLogInput3.Text = "-";
            else
                lblLogInput3.Text = "" + logIn[2];

            if (logIn[3] == -1)
                lblLogInput4.Text = "-";
            else
                lblLogInput4.Text = "" + logIn[3];
        }

        /// <summary>
        /// Populates the form buttons with pictures.
        /// </summary>
        private void populateForm()
        {
            // Number 1 button
            num1But.BackgroundImage = RestaurantAuto.Properties.Resources.num_1;
            num1But.BackgroundImageLayout = ImageLayout.Zoom;
            num1But.TabStop = false;
            num1But.FlatStyle = FlatStyle.Flat;
            num1But.FlatAppearance.BorderSize = 0;

            // Number 1 button
            num2But.BackgroundImage = RestaurantAuto.Properties.Resources.num_2;
            num2But.BackgroundImageLayout = ImageLayout.Zoom;
            num2But.TabStop = false;
            num2But.FlatStyle = FlatStyle.Flat;
            num2But.FlatAppearance.BorderSize = 0;

            // Number 2 button
            num2But.BackgroundImage = RestaurantAuto.Properties.Resources.num_2;
            num2But.BackgroundImageLayout = ImageLayout.Zoom;
            num2But.TabStop = false;
            num2But.FlatStyle = FlatStyle.Flat;
            num2But.FlatAppearance.BorderSize = 0;

            // Number 3 button
            num3But.BackgroundImage = RestaurantAuto.Properties.Resources.num_3;
            num3But.BackgroundImageLayout = ImageLayout.Zoom;
            num3But.TabStop = false;
            num3But.FlatStyle = FlatStyle.Flat;
            num3But.FlatAppearance.BorderSize = 0;

            // Number 4 button
            num4But.BackgroundImage = RestaurantAuto.Properties.Resources.num_4;
            num4But.BackgroundImageLayout = ImageLayout.Zoom;
            num4But.TabStop = false;
            num4But.FlatStyle = FlatStyle.Flat;
            num4But.FlatAppearance.BorderSize = 0;

            // Number 5 button
            num5But.BackgroundImage = RestaurantAuto.Properties.Resources.num_5;
            num5But.BackgroundImageLayout = ImageLayout.Zoom;
            num5But.TabStop = false;
            num5But.FlatStyle = FlatStyle.Flat;
            num5But.FlatAppearance.BorderSize = 0;

            // Number 6 button
            num6But.BackgroundImage = RestaurantAuto.Properties.Resources.num_6;
            num6But.BackgroundImageLayout = ImageLayout.Zoom;
            num6But.TabStop = false;
            num6But.FlatStyle = FlatStyle.Flat;
            num6But.FlatAppearance.BorderSize = 0;

            // Number 7 button
            num7But.BackgroundImage = RestaurantAuto.Properties.Resources.num_7;
            num7But.BackgroundImageLayout = ImageLayout.Zoom;
            num7But.TabStop = false;
            num7But.FlatStyle = FlatStyle.Flat;
            num7But.FlatAppearance.BorderSize = 0;

            // Number 8 button
            num8But.BackgroundImage = RestaurantAuto.Properties.Resources.num_8;
            num8But.BackgroundImageLayout = ImageLayout.Zoom;
            num8But.TabStop = false;
            num8But.FlatStyle = FlatStyle.Flat;
            num8But.FlatAppearance.BorderSize = 0;

            // Number 9 button
            num9But.BackgroundImage = RestaurantAuto.Properties.Resources.num_9;
            num9But.BackgroundImageLayout = ImageLayout.Zoom;
            num9But.TabStop = false;
            num9But.FlatStyle = FlatStyle.Flat;
            num9But.FlatAppearance.BorderSize = 0;

            // Number 0 button
            num0But.BackgroundImage = RestaurantAuto.Properties.Resources.num_0;
            num0But.BackgroundImageLayout = ImageLayout.Zoom;
            num0But.TabStop = false;
            num0But.FlatStyle = FlatStyle.Flat;
            num0But.FlatAppearance.BorderSize = 0;

            // Enter button
            btnEnter.BackgroundImage = RestaurantAuto.Properties.Resources.enter;
            btnEnter.BackgroundImageLayout = ImageLayout.Zoom;
            btnEnter.TabStop = false;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.FlatAppearance.BorderSize = 0;

            // Backspace button
            btnBackspace.BackgroundImage = RestaurantAuto.Properties.Resources.backspace;
            btnBackspace.BackgroundImageLayout = ImageLayout.Zoom;
            btnBackspace.TabStop = false;
            btnBackspace.FlatStyle = FlatStyle.Flat;
            btnBackspace.FlatAppearance.BorderSize = 0;

            // Shutdown button
            btnShutDown.BackgroundImage = RestaurantAuto.Properties.Resources.off;
            btnShutDown.BackgroundImageLayout = ImageLayout.Zoom;
            btnShutDown.TabStop = false;
            btnShutDown.FlatStyle = FlatStyle.Flat;
            btnShutDown.FlatAppearance.BorderSize = 0;
        }
    }
}
