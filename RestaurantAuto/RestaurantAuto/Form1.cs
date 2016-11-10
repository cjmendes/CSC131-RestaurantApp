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

        private void num1But_Click(object sender, EventArgs e)
        {
            logIn[logInPosition] = 1;
            logInPosition++;
            refreshLogIn();
        }

        private void num2But_Click(object sender, EventArgs e)
        {
            logIn[logInPosition] = 2;
            logInPosition++;
            refreshLogIn();
        }

        private void num3But_Click(object sender, EventArgs e)
        {
            logIn[logInPosition] = 3;
            logInPosition++;
            refreshLogIn();
        }

        private void num4But_Click(object sender, EventArgs e)
        {
            logIn[logInPosition] = 4;
            logInPosition++;
            refreshLogIn();
        }

        private void num5But_Click(object sender, EventArgs e)
        {
            logIn[logInPosition] = 5;
            logInPosition++;
            refreshLogIn();
        }

        private void refreshLogIn()
        {
            string input = "";
            for(int i = 0; i < logIn.Length; i++)
            {
                if(logIn[i] == -1)
                    input += " -";
                else
                    input = input + " " + logIn[i] + " ";
            }
            input += " ";
            lblLogInput.Text = input;
        }
    }
}
