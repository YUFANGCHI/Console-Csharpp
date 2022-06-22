using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_Form
{
    
   public partial class Class02
    {
        void play01()  
        {
            MessageBox.Show("play01");
        }
        private void play02()
        {
            MessageBox.Show("play02");
        }
        public void play03()
        {
            MessageBox.Show("play03");
        }
        internal void play04()
        {
            MessageBox.Show("play04");
        }

        public void play05()  // 通用修飾詞公開下列內容
        {
            play01();
            play02();
        }
    }

}
