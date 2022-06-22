
namespace lab_Form
{
    partial class day1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.hi = new System.Windows.Forms.Button();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.textbox3 = new System.Windows.Forms.TextBox();
            this.textbox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hi
            // 
            this.hi.BackColor = System.Drawing.SystemColors.Info;
            this.hi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hi.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hi.Location = new System.Drawing.Point(45, 319);
            this.hi.Margin = new System.Windows.Forms.Padding(4);
            this.hi.Name = "hi";
            this.hi.Size = new System.Drawing.Size(323, 69);
            this.hi.TabIndex = 0;
            this.hi.Text = "輸入";
            this.hi.UseVisualStyleBackColor = false;
            this.hi.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox1
            // 
            this.textbox1.AccessibleDescription = "";
            this.textbox1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textbox1.Location = new System.Drawing.Point(154, 53);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(156, 43);
            this.textbox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名：";
            // 
            // textbox2
            // 
            this.textbox2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold);
            this.textbox2.Location = new System.Drawing.Point(154, 115);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(156, 43);
            this.textbox2.TabIndex = 3;
            // 
            // textbox3
            // 
            this.textbox3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold);
            this.textbox3.Location = new System.Drawing.Point(154, 170);
            this.textbox3.Name = "textbox3";
            this.textbox3.Size = new System.Drawing.Size(155, 43);
            this.textbox3.TabIndex = 4;
            // 
            // textbox4
            // 
            this.textbox4.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold);
            this.textbox4.Location = new System.Drawing.Point(154, 218);
            this.textbox4.Name = "textbox4";
            this.textbox4.Size = new System.Drawing.Size(156, 43);
            this.textbox4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "英文名字";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "性別";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "星座";
            // 
            // hello
            // 
            this.hello.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.hello.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold);
            this.hello.Location = new System.Drawing.Point(490, 325);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(260, 63);
            this.hello.TabIndex = 9;
            this.hello.Text = "取消";
            this.hello.UseVisualStyleBackColor = true;
            // 
            // day1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(948, 562);
            this.Controls.Add(this.hello);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox4);
            this.Controls.Add(this.textbox3);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.hi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "day1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hi;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.TextBox textbox3;
        private System.Windows.Forms.TextBox textbox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button hello;
    }
}

