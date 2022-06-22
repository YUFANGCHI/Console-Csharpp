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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//堆疊
        {
            long a = 100;
            MessageBox.Show(a.ToString());

            long b = a;  // a、b 為獨立個體
            MessageBox.Show("a:" + a + ",b" + b);

            b = 200; //b在上方已宣告過了免再宣告，b在重新設定值後，會以新的方式再現
            MessageBox.Show("a:" + a + ",b" + b);
        }
//-------------------------------------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)  //在button2 裡面觸發textbox
        {
            TextBox ttbox = textBox1;  //設定 TextBox事件
            ttbox.Text = "哈哈哈";
            ttbox.BackColor = Color.Red;
            
        }
    }
}
