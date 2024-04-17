
namespace Calculator
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
            this.btnGame123 = new System.Windows.Forms.Button();
            this.btnDice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGame123
            // 
            this.btnGame123.Location = new System.Drawing.Point(139, 62);
            this.btnGame123.Name = "btnGame123";
            this.btnGame123.Size = new System.Drawing.Size(170, 77);
            this.btnGame123.TabIndex = 3;
            this.btnGame123.Text = "Game One, Two, Three";
            this.btnGame123.UseVisualStyleBackColor = true;
            this.btnGame123.Click += new System.EventHandler(this.btnGame123_Click);
            // 
            // btnDice
            // 
            this.btnDice.Location = new System.Drawing.Point(525, 62);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(170, 86);
            this.btnDice.TabIndex = 4;
            this.btnDice.Text = "Game Dice";
            this.btnDice.UseVisualStyleBackColor = true;
            this.btnDice.Click += new System.EventHandler(this.btnDice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnDice);
            this.Controls.Add(this.btnGame123);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGame123;
        private System.Windows.Forms.Button btnDice;
    }
}

