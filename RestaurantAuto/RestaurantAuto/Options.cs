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
    /// Creates new Options form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Options : Form
    {
        Waiter[] waiters;

        /// <summary>
        /// Initializes a new instance of the <see cref="Options"/> class.
        /// </summary>
        /// <param name="waiters">The list of waiters.</param>
        public Options(Waiter[] waiters)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.waiters = waiters;
            populateForm();
        }

        /********************************************
         ***               BUTTONS                ***
         ********************************************/

        // If clicked, opens a new MainScreen form.
        private void btnRestaurant_Click(object sender, EventArgs e)
        {
            MainScreen msForm = new MainScreen(waiters, true);
            msForm.Tag = this;
            msForm.Show(this);
            Hide();
        }
        
        // If clicked, opens a new Settings form.
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(waiters);
            settings.Tag = this;
            settings.Show(this);
            Hide();
        }

        // If clicked, closes this form and returns to Form1 form.
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var form1 = (LogIn)Tag;
            form1.Show();
            Close();
        }

        /********************************************
         ***              FUNCTIONS               ***
         ********************************************/

        /// <summary>
        /// Populates the form buttons with pictures.
        /// </summary>
        private void populateForm()
        {
            // Settings button
            btnSettings.BackgroundImage = RestaurantAuto.Properties.Resources.settings;
            btnSettings.BackgroundImageLayout = ImageLayout.Zoom;
            btnSettings.TabStop = false;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.Text = "";
        }
    }
}
