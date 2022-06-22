using lab_Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HOLLE WORLD");
            Console.Write("請輸入姓名:");
            String name = Console.ReadLine();
            Console.Write("哈囉" + name);
            

            Class02 mc = new Class02();
            mc.play06();
           
            Console.ReadKey();
        }

    }
}
