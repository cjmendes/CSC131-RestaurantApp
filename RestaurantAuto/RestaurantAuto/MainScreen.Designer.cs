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
            this.lblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTable1 = new System.Windows.Forms.Button();
            this.btnTable2 = new System.Windows.Forms.Button();
            this.btnTable3 = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnVacate = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(841, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 554);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Location = new System.Drawing.Point(1, 468);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(840, 85);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(852, 0);
            this.lblClock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(204, 42);
            this.lblClock.TabIndex = 2;
            this.lblClock.Text = "00 : 00 : 00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // btnTable1
            // 
            this.btnTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTable1.Location = new System.Drawing.Point(32, 32);
            this.btnTable1.Margin = new System.Windows.Forms.Padding(4);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(83, 74);
            this.btnTable1.TabIndex = 3;
            this.btnTable1.Text = "Table1";
            this.btnTable1.UseVisualStyleBackColor = false;
            this.btnTable1.Click += new System.EventHandler(this.btnTable1_Click);
            // 
            // btnTable2
            // 
            this.btnTable2.Location = new System.Drawing.Point(245, 32);
            this.btnTable2.Margin = new System.Windows.Forms.Padding(4);
            this.btnTable2.Name = "btnTable2";
            this.btnTable2.Size = new System.Drawing.Size(83, 74);
            this.btnTable2.TabIndex = 4;
            this.btnTable2.Text = "Table2";
            this.btnTable2.UseVisualStyleBackColor = true;
            // 
            // btnTable3
            // 
            this.btnTable3.Location = new System.Drawing.Point(455, 32);
            this.btnTable3.Margin = new System.Windows.Forms.Padding(4);
            this.btnTable3.Name = "btnTable3";
            this.btnTable3.Size = new System.Drawing.Size(83, 74);
            this.btnTable3.TabIndex = 5;
            this.btnTable3.Text = "Table3";
            this.btnTable3.UseVisualStyleBackColor = true;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(31, 498);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(83, 30);
            this.btnAssign.TabIndex = 6;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // btnVacate
            // 
            this.btnVacate.Location = new System.Drawing.Point(161, 498);
            this.btnVacate.Margin = new System.Windows.Forms.Padding(4);
            this.btnVacate.Name = "btnVacate";
            this.btnVacate.Size = new System.Drawing.Size(83, 30);
            this.btnVacate.TabIndex = 7;
            this.btnVacate.Text = "Vacate";
            this.btnVacate.UseVisualStyleBackColor = true;
            this.btnVacate.Click += new System.EventHandler(this.btnVacate_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(287, 498);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(4);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(83, 30);
            this.btnReserve.TabIndex = 8;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(844, 503);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(235, 49);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 554);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnVacate);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnTable3);
            this.Controls.Add(this.btnTable2);
            this.Controls.Add(this.btnTable1);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTable1;
        private System.Windows.Forms.Button btnTable2;
        private System.Windows.Forms.Button btnTable3;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnVacate;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnLogOut;
    }
}