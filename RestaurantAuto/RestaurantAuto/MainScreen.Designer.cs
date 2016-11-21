namespace RestaurantAuto
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTable1 = new System.Windows.Forms.Button();
            this.btnTable2 = new System.Windows.Forms.Button();
            this.btnTable3 = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnVacate = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblClock = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(631, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Location = new System.Drawing.Point(1, 380);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(630, 69);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnTable1
            // 
            this.btnTable1.Location = new System.Drawing.Point(24, 26);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(62, 60);
            this.btnTable1.TabIndex = 3;
            this.btnTable1.Text = "Table1";
            this.btnTable1.UseVisualStyleBackColor = true;
            this.btnTable1.Click += new System.EventHandler(this.btnTable1_Click);
            // 
            // btnTable2
            // 
            this.btnTable2.Location = new System.Drawing.Point(184, 26);
            this.btnTable2.Name = "btnTable2";
            this.btnTable2.Size = new System.Drawing.Size(62, 60);
            this.btnTable2.TabIndex = 4;
            this.btnTable2.Text = "Table2";
            this.btnTable2.UseVisualStyleBackColor = true;
            // 
            // btnTable3
            // 
            this.btnTable3.Location = new System.Drawing.Point(341, 26);
            this.btnTable3.Name = "btnTable3";
            this.btnTable3.Size = new System.Drawing.Size(62, 60);
            this.btnTable3.TabIndex = 5;
            this.btnTable3.Text = "Table3";
            this.btnTable3.UseVisualStyleBackColor = true;
            // 
            // btnAssign
            // 
            this.btnAssign.Enabled = false;
            this.btnAssign.Location = new System.Drawing.Point(23, 405);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(62, 24);
            this.btnAssign.TabIndex = 6;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // btnVacate
            // 
            this.btnVacate.Enabled = false;
            this.btnVacate.Location = new System.Drawing.Point(121, 405);
            this.btnVacate.Name = "btnVacate";
            this.btnVacate.Size = new System.Drawing.Size(62, 24);
            this.btnVacate.TabIndex = 7;
            this.btnVacate.Text = "Vacate";
            this.btnVacate.UseVisualStyleBackColor = true;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(215, 405);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(62, 24);
            this.btnReserve.TabIndex = 8;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(633, 409);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(176, 40);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(632, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(178, 33);
            this.lblClock.TabIndex = 10;
            this.lblClock.Text = "00:00:00 AM";
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnVacate);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnTable3);
            this.Controls.Add(this.btnTable2);
            this.Controls.Add(this.btnTable1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainScreen";
            this.Text = "Red-E";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnTable1;
        private System.Windows.Forms.Button btnTable2;
        private System.Windows.Forms.Button btnTable3;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnVacate;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer tmrClock;
    }
}