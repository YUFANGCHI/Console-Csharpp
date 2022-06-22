using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab_Form.day2;

namespace lab_Form
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int count = 0;  //須把表單內資料拉出才不會被限制在下方事件裡
        private void button1_Click(object sender, EventArgs e)
        {
            //int count = 0 設定在事件裡會只顯示0
            count += 1;  // conunt = conunt + 1
            label1.Text = "count:" + count;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int count = 99, b;    ==  int a=99;     int b;
            int b = ++count;
            label1.Text = "count:" + count;
            MessageBox.Show(b.ToString());
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            int a = 1;
           // if(ture)
            {
                int x = 2;
                a = x;
            }
            
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        //------------------------------------------------------------------------------------------
        usestatic p = new usestatic();    //usestatic 設定在day1、day2
        private void button6_Click(object sender, EventArgs e)
        {
         
            p.inst++;
            label2.Text = "恩恩" + p.inst;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            usestatic.stat++;
            label3.Text = "恩恩" + usestatic.stat;
        }
//---------------------------------------------------------------------------------------------------------
        private void button7_Click(object sender, EventArgs e)
        {
            day1 dd = new day1();
            dd.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
          uuusea uuu  = new uuusea();
            uuu.insss++;
            label4.Text = "哈哈" + uuu.insss;
        }
    }
}
