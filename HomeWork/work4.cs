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
    public partial class work4 : Form
    {
        public work4()
        {
            InitializeComponent();
        }
       public struct suject
        {
           public string name;
            public int chine;
            public int math;
            public int eng;
            
        }

        suject pro;
        

        private void button1_Click(object sender, EventArgs e)
        {
            pro.name =textBox1.Text;

            pro.chine = int.Parse(textBox2.Text);

            pro.math = int.Parse(textBox3.Text);

            pro.eng = int.Parse(textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = $"姓名：{pro.name}\n國文：{pro.chine}\n數學：{pro.math}\n英文：{pro.eng}";
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            string aaa="";

            //pro.chine = int.Parse(textBox2.Text);

            //pro.math = int.Parse(textBox3.Text);

            //pro.eng = int.Parse(textBox4.Text);

            if (pro.chine > pro.math && pro.chine > pro.eng)
            {               
                aaa= aaa + "最高分"+pro.chine.ToString();
            }
            else if(pro.math > pro.chine && pro.math > pro.eng)
            {
                aaa= aaa + "最高分" + pro.math.ToString();
            }
            else
            {
                aaa = aaa + "最高分" + pro.eng.ToString();
            }
           
            
            if (pro.chine < pro.math && pro.chine < pro.eng)
            {
                aaa= aaa + "最第分" + pro.chine.ToString();
            }
            else if (pro.math < pro.chine && pro.math < pro.eng)
            {
                aaa= aaa + "最第分" + pro.math.ToString();
            }
            else
            {
                aaa=aaa+ "最第分" + pro.eng.ToString();
                
            }

            label6.Text =aaa;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (pro.chine <pro.math && pro.chine < pro.eng)
            {
                label6.Text = pro.chine.ToString();
            }
            else if (pro.math < pro.chine && pro.math <pro.eng)
            {
                label6.Text = pro.math.ToString();
            }
            else
            {
                label6.Text = pro.eng.ToString();
            }
        }
    }
    }

