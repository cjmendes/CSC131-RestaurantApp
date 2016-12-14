namespace RestaurantAuto
{
    partial class ReservationInfoForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTableNum = new System.Windows.Forms.Label();
            this.lblReservationName = new System.Windows.Forms.Label();
            this.lblReservationTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 159);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(110, 24);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(153, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 24);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel Reservation";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTableNum
            // 
            this.lblTableNum.AutoSize = true;
            this.lblTableNum.Location = new System.Drawing.Point(112, 21);
            this.lblTableNum.Name = "lblTableNum";
            this.lblTableNum.Size = new System.Drawing.Size(44, 13);
            this.lblTableNum.TabIndex = 2;
            this.lblTableNum.Text = "Table #";
            // 
            // lblReservationName
            // 
            this.lblReservationName.AutoSize = true;
            this.lblReservationName.Location = new System.Drawing.Point(19, 61);
            this.lblReservationName.Name = "lblReservationName";
            this.lblReservationName.Size = new System.Drawing.Size(95, 13);
            this.lblReservationName.TabIndex = 3;
            this.lblReservationName.Text = "Reservation Name";
            // 
            // lblReservationTime
            // 
            this.lblReservationTime.AutoSize = true;
            this.lblReservationTime.Location = new System.Drawing.Point(19, 101);
            this.lblReservationTime.Name = "lblReservationTime";
            this.lblReservationTime.Size = new System.Drawing.Size(90, 13);
            this.lblReservationTime.TabIndex = 4;
            this.lblReservationTime.Text = "Reservation Time";
            // 
            // ReservationInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 195);
            this.ControlBox = false;
            this.Controls.Add(this.lblReservationTime);
            this.Controls.Add(this.lblReservationName);
            this.Controls.Add(this.lblTableNum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservationInfoForm";
            this.Text = "Reservation Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTableNum;
        private System.Windows.Forms.Label lblReservationName;
        private System.Windows.Forms.Label lblReservationTime;
    }
}