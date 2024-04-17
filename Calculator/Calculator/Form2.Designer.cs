
namespace Calculator
{
    partial class Form2
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
            this.btnKeo = new System.Windows.Forms.Button();
            this.lbKeo = new System.Windows.Forms.Label();
            this.btnBua = new System.Windows.Forms.Button();
            this.btnBao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPlayer1 = new System.Windows.Forms.Label();
            this.lbPlayer2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTurn = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnBackGame123 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKeo
            // 
            this.btnKeo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKeo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.btnKeo.Location = new System.Drawing.Point(12, 63);
            this.btnKeo.Name = "btnKeo";
            this.btnKeo.Size = new System.Drawing.Size(242, 393);
            this.btnKeo.TabIndex = 0;
            this.btnKeo.Text = "Kéo";
            this.btnKeo.UseVisualStyleBackColor = false;
            this.btnKeo.Click += new System.EventHandler(this.btnKeo_Click);
            // 
            // lbKeo
            // 
            this.lbKeo.Location = new System.Drawing.Point(260, 63);
            this.lbKeo.Name = "lbKeo";
            this.lbKeo.Size = new System.Drawing.Size(242, 393);
            this.lbKeo.TabIndex = 1;
            // 
            // btnBua
            // 
            this.btnBua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBua.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.btnBua.Location = new System.Drawing.Point(334, 63);
            this.btnBua.Name = "btnBua";
            this.btnBua.Size = new System.Drawing.Size(242, 393);
            this.btnBua.TabIndex = 2;
            this.btnBua.Text = "Búa";
            this.btnBua.UseVisualStyleBackColor = false;
            this.btnBua.Click += new System.EventHandler(this.btnBua_Click);
            // 
            // btnBao
            // 
            this.btnBao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.btnBao.Location = new System.Drawing.Point(658, 63);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(242, 393);
            this.btnBao.TabIndex = 3;
            this.btnBao.Text = "Bao";
            this.btnBao.UseVisualStyleBackColor = false;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player 2:";
            // 
            // lbPlayer1
            // 
            this.lbPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPlayer1.Location = new System.Drawing.Point(130, 472);
            this.lbPlayer1.Name = "lbPlayer1";
            this.lbPlayer1.Size = new System.Drawing.Size(124, 38);
            this.lbPlayer1.TabIndex = 6;
            // 
            // lbPlayer2
            // 
            this.lbPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPlayer2.Location = new System.Drawing.Point(130, 510);
            this.lbPlayer2.Name = "lbPlayer2";
            this.lbPlayer2.Size = new System.Drawing.Size(124, 38);
            this.lbPlayer2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lượt của:";
            // 
            // lbTurn
            // 
            this.lbTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTurn.Location = new System.Drawing.Point(130, 9);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(105, 38);
            this.lbTurn.TabIndex = 9;
            this.lbTurn.Text = "Player 1";
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnResult.ForeColor = System.Drawing.Color.Red;
            this.btnResult.Location = new System.Drawing.Point(317, 472);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(274, 62);
            this.btnResult.TabIndex = 10;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnBackGame123
            // 
            this.btnBackGame123.Location = new System.Drawing.Point(804, 9);
            this.btnBackGame123.Name = "btnBackGame123";
            this.btnBackGame123.Size = new System.Drawing.Size(80, 38);
            this.btnBackGame123.TabIndex = 11;
            this.btnBackGame123.Text = "Back";
            this.btnBackGame123.UseVisualStyleBackColor = true;
            this.btnBackGame123.Click += new System.EventHandler(this.btnBackGame123_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 601);
            this.Controls.Add(this.btnBackGame123);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPlayer2);
            this.Controls.Add(this.lbPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBao);
            this.Controls.Add(this.btnBua);
            this.Controls.Add(this.lbKeo);
            this.Controls.Add(this.btnKeo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKeo;
        private System.Windows.Forms.Label lbKeo;
        private System.Windows.Forms.Button btnBua;
        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPlayer1;
        private System.Windows.Forms.Label lbPlayer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnBackGame123;
    }
}