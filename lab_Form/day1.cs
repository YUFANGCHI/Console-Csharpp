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
    public partial class day1 : Form
    {
        public day1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textbox1.Text;    // string 變數 name自訂名稱 = 空白方框name為text1 . 開啟屬性
            string englishname = textbox2.Text;
            string sex = textbox3.Text;
            string mnbvc1 = textbox4.Text;
            MessageBox.Show("姓名:"+name+"\n英文名字:"+englishname+"\n性別:"+sex+"\n星座:"+mnbvc1);    // MessageBox為彈出視窗 . show 為顯示變數 ("hello," + 自訂名稱 ) 

            MessageBox.Show(usestatic.stat.ToString());
            MessageBox.Show(uuusea.staviccc.ToString());

        }


    }
    }

