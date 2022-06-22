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
    public partial class work3 : Form
    {
        public work3()
        {
            InitializeComponent();
        }

        private int beer;
        private int tequila;
        private int whisky;
        private int wine;
        int AA;

        void total()
        {
            AA = beer * 120 + tequila * 180 + whisky * 120 + wine * 150;
            textBox2.Text = "NT$" + AA;
        }
        void list()
        {
            //string 安安 = "啤酒x" + beer + "共NT$" + beer * 120 + "元" +
            //    "\r\n龍舌蘭x" + tequila + "共NT$" + tequila * 180 + "元" +
            //    "\r\n威士忌x" + whisky + "共NT$" + whisky * 120 + "元" +
            //    "\r\n紅酒x" + wine + "共NT$" + wine * 150 + "元";
            //textBox1.Text = 安安;
            string 清單 = "";

            if (beer >= 1)
            {
                //如果 += "啤酒x" + beer + "共NT$" + beer * 120 + "元";
                清單 += $"啤酒{beer}共NT${beer * 120}元";
                textBox1.Text = 清單;
            }
            if (tequila >= 1)
            {
                清單 += "\r\n龍舌蘭x" + tequila + "共NT$" + tequila * 180 + "元";
                textBox1.Text = 清單;
            }
            if (whisky >= 1)
            {
                清單 = "\r\n威士忌x" + whisky + "共NT$" + whisky * 120 + "元";
                textBox1.Text = 清單;
            }
            if (wine >= 1)
            {
                清單 = "\r\n紅酒x" + wine + "共NT$" + wine * 150 + "元";
                textBox1.Text = 清單;
            }
        }

        private void btn_beer_Click(object sender, EventArgs e)
        {
            beer ++;
            total();  //int AA = beer * 120 + tequila * 180 + whisky * 120 + wine * 150;
                      //textBox2.Text = "NT$" + AA;
            list();
        }

        private void btn_tequila_Click(object sender, EventArgs e)
        {
            tequila ++;
            total();  //int AA = beer * 120 + tequila * 180 + whisky * 120 + wine * 150;
                      //textBox2.Text = "NT$" + AA;
            list();
        }

        private void btn_whisky_Click(object sender, EventArgs e)
        {
            whisky++;
            total();  //int AA = beer * 120 + tequila * 180 + whisky * 120 + wine * 150;
                      //textBox2.Text = "NT$" + AA;
            list();
        }

        private void btn_wine_Click(object sender, EventArgs e)
        {
            wine++;
            total();  //int AA = beer * 120 + tequila * 180 + whisky * 120 + wine * 150;
                      //textBox2.Text = "NT$" + AA;
            list();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (AA==0)
            {
               DialogResult result =MessageBox.Show("尚未點餐","確認付款",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("總金額:" +AA.ToString()+"元",
                    "確認付款",MessageBoxButtons.OKCancel);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (AA == 0)
            {
                DialogResult result = MessageBox.Show("尚未點餐", "確認付款",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               DialogResult result= MessageBox.Show("總金額:"+AA+"元"+
                   "\n折扣金額:"+(AA*0.9).ToString(), "確認付款",MessageBoxButtons.OKCancel);
            }
        }

  
    }
}
