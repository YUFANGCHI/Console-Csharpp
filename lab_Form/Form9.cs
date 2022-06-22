using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_Form
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        bool frog = true;  // 須放在區域變數才能
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (frog)
            {
                button1.BackColor = Color.Black;
                //frog = false;
            }
            else
            {
                button1.BackColor = Color.Red;
                //frog = true;
            }
            frog = !frog;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //要變更的內容=判斷值  ?後方接更改內容    :反之
            button1.BackColor=frog?Color.Black: Color.Red;  
            
            frog = !frog;
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            //90~100 =A
            //80~89 = B
            //70~79 = C
            //~69 =D

           

            int Scord檢查=0;

            //bool notthis = int.TryParse(textBox1.Text, out Scord檢查);

            if (int.TryParse(textBox1.Text, out Scord檢查)) //  if (notthis)
            {
                int scord = int.Parse(textBox1.Text);
                if (scord >= 90 && scord <= 100)
                {
                    label1.Text = "A";
                }
                else if (scord >= 80)
                {
                    label1.Text = "B";
                }
                else if (scord >= 70) //只有單行指令可以不用加{}
                    label1.Text = "C";
                else                    //只有單行指令可以不用加{}
                    label1.Text = "D";
            }
            else
            {
                MessageBox.Show("請輸入正確數字!!!!!!");
                textBox1.Clear();
                textBox1.Focus();
            }

            



        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("下雨天", "???", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes: //case回輸入值的判斷
                    MessageBox.Show("下雨天");
                    break;
                case DialogResult.No:
                    MessageBox.Show("下");
                    break;
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = 0;// 如果打i=10  不會顯示任何內容
            string result = "";
            while (i < 9)// 前測試迴圈
            {
                result += i + "\n"; 
                i++;
            }
             MessageBox.Show(result); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i = 0;  // 如果打i=10  會顯示10
            string result = "";

            do
            {
                result += i + "";
                i++;

            } while (i <9);//後測試迴圈

            MessageBox.Show(result);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string result = "";

            //for (int i =0;i<9;i++)
            //{
            //    result += i + "";
            //}

            for(int i=0,z=10,k=5;i<=k+z; i += 2, k++)
            {
                result += $"i={i},z={z},k={k}\n";
            }
          
            MessageBox.Show(result);
        }
    }
}
