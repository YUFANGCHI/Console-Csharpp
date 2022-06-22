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
    public partial class work02_2 : Form
    {
        public work02_2()
        {
            InitializeComponent();
        }

        public void worktext(double a, double b, double c, double d,double e)  //設一個方法要把WORK02值帶入
        {
            label6.Text = a.ToString();
            label7.Text = b.ToString();
            label8.Text = c.ToString();
            label9.Text = d.ToString();
            label10.Text = e.ToString();

        }
    }
}
