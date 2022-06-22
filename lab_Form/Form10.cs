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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int[] math = new int[4];
            //math[0] = 1;
            //math[1] = 2;
            //math[2] = 3;
            //math[3] = 4;

            //int[] math = new int[4] { 1, 2,3, 4 };

            int[] math ={ 1, 2, 3, 4 };
            string result = "";
            
            for(int i=0; i<math.Length; i++) //  for ( 設定起始值開始跑 ; 何時停止 ; 增加的幅度 ) 
            {
                result += math[i]+"\n";
            }

            MessageBox.Show(result);
        }
        
    }
}
