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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sister siss = sister.admin;  // enum列舉 在day2

            if (siss == sister.admin)  //判斷式
            {
                button2.Enabled = true; //Enabled 按鈕開關
            }
            else
            {
                button2.Enabled = false;
            }
        }
    }
}
