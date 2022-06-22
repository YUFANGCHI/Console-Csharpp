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
    public partial class Form8 : Form  // 19章
    {
        public Form8()
        {
            InitializeComponent();
        }
        string result="產品";
        int count=0;
        decimal total = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //product pro;   // 設在day2 結構
            //pro.productname = textBox1.Text; //把textBox1.Text輸入的值帶入pro.productname變數中
            //pro.productprice =decimal.Parse (textBox2.Text);  // decimal.Parse為強制轉型
            ////string result="產品";  無法在方法中跑

            //product pro = new product();
            //pro.productname = textBox1.Text; //把textBox1.Text輸入的值帶入pro.productname變數中
            //pro.productprice = decimal.Parse(textBox2.Text);  // decimal.Parse為強制轉型


            decimal notprice=0;
           bool notthis =decimal.TryParse(textBox2.Text, out notprice);

            if (notthis)
            {
                product pro = new product(textBox1.Text, notprice);
                //result += "\n產品名稱" + pro.productname + "產品價格" + pro.productprice;
                result += $"\n產品名稱{pro.productname}產品價格{pro.productprice}";
                count++;  //點擊次數
                total += pro.productprice;
            }
            else
            {
                MessageBox.Show("請輸入正確數字!!!!!!");
                textBox2.Clear();
                textBox2.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text=result+"\n------------------\n產品總數:"+count+
                "\n平均價格:"+total/count;  //把result 帶入 label3.Text 顯示出來

        }
    }
}
