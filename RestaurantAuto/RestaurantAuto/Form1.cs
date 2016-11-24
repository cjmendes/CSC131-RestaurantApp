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
    public partial class Form1 : Form
    {
        int[] logIn = Enumerable.Repeat(-1, 4).ToArray();
        string logInPassword = "1234";
        int logInPosition = 0;

        public Form1()
        {
            InitializeComponent();
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
                    lblLogInput1.Text = "-";
                else if (logInPosition == 2)
                    lblLogInput2.Text = "-";
                else if (logInPosition == 3)
                    lblLogInput3.Text = "-";
                else if (logInPosition == 4)
                    lblLogInput4.Text = "-";
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


        /********************************************
         ***              FUNCTIONS               ***
         ********************************************/

        // Function restores all 4 labels to "-"
        private void clearLogIn()
        {
            for (int i = 0; i < logIn.Length; i++)
                logIn[i] = -1;
            logInPosition = 0;
            refreshLogIn();
        }

        // Checks whether the 4 values are the same as the password. Password is a static '1234' right now.
        // If it fails, it clears the values, if it works, it clears the password, hides the form and opens
        // up a MainScreen form
        private void checkPassword()
        {
            string tempPass = "" + logIn[0] + logIn[1] + logIn[2] + logIn[3];
            if (logInPassword == tempPass)
            {
                clearLogIn();
                MainScreen msForm = new MainScreen();
                msForm.Tag = this;
                msForm.Show(this);
                Hide();    
            }
            else
                clearLogIn();
        }

        // Refreshes the labels with what is in place.
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

        private void lblLogInput3_Click(object sender, EventArgs e)
        {

        }
    }
}
