namespace RestaurantAuto
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddWaiter = new System.Windows.Forms.Button();
            this.btnDeleteWaiter = new System.Windows.Forms.Button();
            this.btnTableSetup = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddWaiter
            // 
            this.btnAddWaiter.Location = new System.Drawing.Point(46, 154);
            this.btnAddWaiter.Name = "btnAddWaiter";
            this.btnAddWaiter.Size = new System.Drawing.Size(135, 136);
            this.btnAddWaiter.TabIndex = 1;
            this.btnAddWaiter.Text = "Add Waiter";
            this.btnAddWaiter.UseVisualStyleBackColor = true;
            this.btnAddWaiter.Click += new System.EventHandler(this.btnAddWaiter_Click);
            // 
            // btnDeleteWaiter
            // 
            this.btnDeleteWaiter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteWaiter.Location = new System.Drawing.Point(241, 154);
            this.btnDeleteWaiter.Name = "btnDeleteWaiter";
            this.btnDeleteWaiter.Size = new System.Drawing.Size(135, 136);
            this.btnDeleteWaiter.TabIndex = 2;
            this.btnDeleteWaiter.Text = "Delete Waiter";
            this.btnDeleteWaiter.UseVisualStyleBackColor = true;
            this.btnDeleteWaiter.Click += new System.EventHandler(this.btnDeleteWaiter_Click);
            // 
            // btnTableSetup
            // 
            this.btnTableSetup.Location = new System.Drawing.Point(436, 154);
            this.btnTableSetup.Name = "btnTableSetup";
            this.btnTableSetup.Size = new System.Drawing.Size(135, 136);
            this.btnTableSetup.TabIndex = 3;
            this.btnTableSetup.Text = "Table Setup";
            this.btnTableSetup.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(631, 154);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 136);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTableSetup);
            this.Controls.Add(this.btnDeleteWaiter);
            this.Controls.Add(this.btnAddWaiter);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddWaiter;
        private System.Windows.Forms.Button btnDeleteWaiter;
        private System.Windows.Forms.Button btnTableSetup;
        private System.Windows.Forms.Button btnExit;
    }
}