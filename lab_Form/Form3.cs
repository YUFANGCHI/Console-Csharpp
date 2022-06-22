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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            memmem mmm = new memmem(); // 先建立在設值    memmem 在class02-2
            mmm.name = "游芳季";
            mmm.age = 29;
            MessageBox.Show("姓名:" + mmm.name + ",年齡" + mmm.age);
            //--------------------------------------------------------------------------------------
            memmem mmm2 = new memmem()  // 建完就有值
            {
                name = "油坊季2",
                age = 29
            };  //記得要;
            MessageBox.Show("姓名:" + mmm2.name + ",年齡" + mmm2.age);
        }
        //---------------------------------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            // this.button1.Click += new System.EventHandler(this.button1_Click);
            bbb.Click += new EventHandler(bbbclick);
            bbb2.Click += Bbb_Click_2;
        }

        private void Bbb_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("觸發成功2");
        }

        private void bbbclick(object sender, EventArgs e)
        {
            MessageBox.Show("觸發成功");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bbb.Click -= new EventHandler(bbbclick);
        }
//----------------------------------------------------------------------------------
        private void button3_Click(object sender, EventArgs e)  //button3鈕 事件
        {
            payment pay;                              //下方定義的 payment 在定義 pay
            if (comboBox1.Text == "50%")             //如果(下拉式選單選擇=50%)
            {
                pay = discount50off;                  
            }
            else
            {
                pay = discount80off;
            }
            double Price = double.Parse(textBox1.Text);  //定義的price=(textbox1.text)(string無法直接轉成浮點數故須帶入parse)
            double result = pay(Price); //定義result = pay(Price)
            MessageBox.Show(result.ToString()); //MessageBox.Show無法顯示非字串故需加入ToString()
        }
        delegate double payment(double Price);  //委派 浮點數 定義payment (浮點數 參數)
        double discount50off(double Price)  //定義浮點數discount80of (浮點數 參數)
        {
            return Price * 0.5;  //回傳  輸入金額*0.5
        }
        double discount80off(double Price)  //定義浮點數discount80of (浮點數 參數)
        {
            return Price * 0.2;  //回傳 輸入金額*0.2
        }
        //--------------------------------------------------------------------------------------------------


        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult s_result = MessageBox.Show("今天星期幾?", "問你喔?"
                , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            
            if (s_result == DialogResult.Yes)
            {
                MessageBox.Show("今天星期一");
            }
            else
            {
                MessageBox.Show("今天不是星期二");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Text = "變更";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            day1 ddd = new day1();
            DialogResult result = ddd.ShowDialog();// DialogResult 為強制視窗
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("那就取消");
            }
            
        }
    }



    }
    

