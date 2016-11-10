namespace RestaurantAuto
{
    partial class Form1
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
            this.num1But = new System.Windows.Forms.Button();
            this.num2But = new System.Windows.Forms.Button();
            this.lblLogInput = new System.Windows.Forms.Label();
            this.num3But = new System.Windows.Forms.Button();
            this.num4But = new System.Windows.Forms.Button();
            this.num5But = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1But
            // 
            this.num1But.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1But.Location = new System.Drawing.Point(295, 176);
            this.num1But.Name = "num1But";
            this.num1But.Size = new System.Drawing.Size(53, 53);
            this.num1But.TabIndex = 0;
            this.num1But.Text = "1";
            this.num1But.UseVisualStyleBackColor = true;
            this.num1But.Click += new System.EventHandler(this.num1But_Click);
            // 
            // num2But
            // 
            this.num2But.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2But.Location = new System.Drawing.Point(365, 176);
            this.num2But.Name = "num2But";
            this.num2But.Size = new System.Drawing.Size(53, 53);
            this.num2But.TabIndex = 1;
            this.num2But.Text = "2";
            this.num2But.UseVisualStyleBackColor = true;
            this.num2But.Click += new System.EventHandler(this.num2But_Click);
            // 
            // lblLogInput
            // 
            this.lblLogInput.AutoSize = true;
            this.lblLogInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogInput.Location = new System.Drawing.Point(319, 106);
            this.lblLogInput.Name = "lblLogInput";
            this.lblLogInput.Size = new System.Drawing.Size(109, 39);
            this.lblLogInput.TabIndex = 2;
            this.lblLogInput.Text = " - - - -";
            // 
            // num3But
            // 
            this.num3But.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3But.Location = new System.Drawing.Point(432, 176);
            this.num3But.Name = "num3But";
            this.num3But.Size = new System.Drawing.Size(53, 53);
            this.num3But.TabIndex = 3;
            this.num3But.Text = "3";
            this.num3But.UseVisualStyleBackColor = true;
            this.num3But.Click += new System.EventHandler(this.num3But_Click);
            // 
            // num4But
            // 
            this.num4But.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4But.Location = new System.Drawing.Point(295, 242);
            this.num4But.Name = "num4But";
            this.num4But.Size = new System.Drawing.Size(53, 53);
            this.num4But.TabIndex = 4;
            this.num4But.Text = "4";
            this.num4But.UseVisualStyleBackColor = true;
            this.num4But.Click += new System.EventHandler(this.num4But_Click);
            // 
            // num5But
            // 
            this.num5But.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5But.Location = new System.Drawing.Point(365, 243);
            this.num5But.Name = "num5But";
            this.num5But.Size = new System.Drawing.Size(53, 53);
            this.num5But.TabIndex = 5;
            this.num5But.Text = "5";
            this.num5But.UseVisualStyleBackColor = true;
            this.num5But.Click += new System.EventHandler(this.num5But_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(810, 454);
            this.Controls.Add(this.num5But);
            this.Controls.Add(this.num4But);
            this.Controls.Add(this.num3But);
            this.Controls.Add(this.lblLogInput);
            this.Controls.Add(this.num2But);
            this.Controls.Add(this.num1But);
            this.Name = "Form1";
            this.Text = "Red-E";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button num1But;
        private System.Windows.Forms.Button num2But;
        private System.Windows.Forms.Label lblLogInput;
        private System.Windows.Forms.Button num3But;
        private System.Windows.Forms.Button num4But;
        private System.Windows.Forms.Button num5But;
    }
}

