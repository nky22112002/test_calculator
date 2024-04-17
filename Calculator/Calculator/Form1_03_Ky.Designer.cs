
namespace Calculator
{
    partial class Form1_03_Ky
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
            this.btnGame123_03_Ky = new System.Windows.Forms.Button();
            this.btnDice_03_Ky = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGame123_03_Ky
            // 
            this.btnGame123_03_Ky.Location = new System.Drawing.Point(139, 62);
            this.btnGame123_03_Ky.Name = "btnGame123_03_Ky";
            this.btnGame123_03_Ky.Size = new System.Drawing.Size(170, 77);
            this.btnGame123_03_Ky.TabIndex = 3;
            this.btnGame123_03_Ky.Text = "Game One, Two, Three";
            this.btnGame123_03_Ky.UseVisualStyleBackColor = true;
            this.btnGame123_03_Ky.Click += new System.EventHandler(this.btnGame123_03_Ky_Click);
            // 
            // btnDice_03_Ky
            // 
            this.btnDice_03_Ky.Location = new System.Drawing.Point(525, 62);
            this.btnDice_03_Ky.Name = "btnDice_03_Ky";
            this.btnDice_03_Ky.Size = new System.Drawing.Size(170, 86);
            this.btnDice_03_Ky.TabIndex = 4;
            this.btnDice_03_Ky.Text = "Game Dice";
            this.btnDice_03_Ky.UseVisualStyleBackColor = true;
            this.btnDice_03_Ky.Click += new System.EventHandler(this.btnDice_03_Ky_Click);
            // 
            // Form1_03_Ky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnDice_03_Ky);
            this.Controls.Add(this.btnGame123_03_Ky);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1_03_Ky";
            this.Text = "Form1_03_Ky";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGame123_03_Ky;
        private System.Windows.Forms.Button btnDice_03_Ky;
    }
}

