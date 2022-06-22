using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class work01 : Form
    {
        public work01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string eng = textBox2.Text;
            string sex = textBox3.Text;
            string cons= textBox4.Text;
            MessageBox.Show("Hello"+"\n姓名是:" + name + "\n英文姓名:" + eng + "\n性別:" + sex + "\n星座:" + cons);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string eng = textBox2.Text;
            string sex = textBox3.Text;
            string cons = textBox4.Text;
            MessageBox.Show("Hi"+"\n姓名是:" + name + "\n英文姓名:" + eng + "\n性別:" + sex + "\n星座:" + cons);
        }
    }
}
