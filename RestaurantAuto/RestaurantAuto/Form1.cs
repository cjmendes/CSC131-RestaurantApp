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
        private void num1But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 1;
                logInPosition++;
                refreshLogIn();
            }
        }

        private void num2But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 2;
                logInPosition++;
                refreshLogIn();
            }
        }

        private void num3But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 3;
                logInPosition++;
                refreshLogIn();
            }
        }

        private void num4But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 4;
                logInPosition++;
                refreshLogIn();
            }
        }

        private void num5But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 5;
                logInPosition++;
                refreshLogIn();
            }
        }

        private void num6But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 6;
                logInPosition++;
                refreshLogIn();
            }
        }

        private void num7But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 7;
                logInPosition++;
                refreshLogIn();
            }
        }

        private void num8But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 8;
                logInPosition++;
                refreshLogIn();
            }
        }

        private void num9But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 9;
                logInPosition++;
                refreshLogIn();
            }
        }

        private void num0But_Click(object sender, EventArgs e)
        {
            if (logInPosition < 4)
            {
                logIn[logInPosition] = 0;
                logInPosition++;
                refreshLogIn();
            }
        }

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

        private void clearLogIn()
        {
            for (int i = 0; i < logIn.Length; i++)
                logIn[i] = -1;
            logInPosition = 0;
            refreshLogIn();
        }

        private void checkPassword()
        {
            string tempPass = "" + logIn[0] + logIn[1] + logIn[2] + logIn[3];
            if (logInPassword == tempPass)
                tempPass = "done";
            else
                clearLogIn();
        }

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

    }
}
