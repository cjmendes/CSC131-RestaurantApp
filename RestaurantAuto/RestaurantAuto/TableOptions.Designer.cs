namespace RestaurantAuto
{
    partial class TableOptions
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
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnVacate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(22, 32);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(67, 57);
            this.btnAssign.TabIndex = 0;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(185, 33);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(56, 54);
            this.btnReserve.TabIndex = 2;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(264, 36);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(61, 51);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnVacate
            // 
            this.btnVacate.Location = new System.Drawing.Point(106, 36);
            this.btnVacate.Name = "btnVacate";
            this.btnVacate.Size = new System.Drawing.Size(60, 50);
            this.btnVacate.TabIndex = 4;
            this.btnVacate.Text = "Vacate";
            this.btnVacate.UseVisualStyleBackColor = true;
            this.btnVacate.Click += new System.EventHandler(this.btnVacate_Click);
            // 
            // TableOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 120);
            this.Controls.Add(this.btnVacate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnAssign);
            this.Name = "TableOptions";
            this.Text = "TableOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnVacate;
    }
}