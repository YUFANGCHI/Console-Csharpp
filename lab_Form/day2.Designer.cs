
namespace lab_Form
{
    partial class day2
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
            this.openform1 = new System.Windows.Forms.Button();
            this.first01 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openform1
            // 
            this.openform1.Location = new System.Drawing.Point(524, 64);
            this.openform1.Name = "openform1";
            this.openform1.Size = new System.Drawing.Size(149, 81);
            this.openform1.TabIndex = 0;
            this.openform1.Text = "openday1";
            this.openform1.UseVisualStyleBackColor = true;
            this.openform1.Click += new System.EventHandler(this.openform1_Click);
            // 
            // first01
            // 
            this.first01.Location = new System.Drawing.Point(524, 215);
            this.first01.Name = "first01";
            this.first01.Size = new System.Drawing.Size(149, 81);
            this.first01.TabIndex = 1;
            this.first01.Text = "first01";
            this.first01.UseVisualStyleBackColor = true;
            this.first01.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 81);
            this.button1.TabIndex = 2;
            this.button1.Text = "play0123";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 81);
            this.button2.TabIndex = 3;
            this.button2.Text = "return0123";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 81);
            this.button3.TabIndex = 4;
            this.button3.Text = "封裝";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(356, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 81);
            this.button4.TabIndex = 5;
            this.button4.Text = " public練習";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // day2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.first01);
            this.Controls.Add(this.openform1);
            this.Name = "day2";
            this.Text = "day2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openform1;
        private System.Windows.Forms.Button first01;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}