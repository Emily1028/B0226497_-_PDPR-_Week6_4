using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR__Week6_4");
            int e = 200,E;
            Console.WriteLine("雞蛋:" + e + "個，可分為:" + e/12 + "打，剩" + e%12 +"個蛋");
            Console.Write("請輸入蛋的數量:");
            E = Int32.Parse(Console.ReadLine());
            Console.WriteLine("雞蛋:" + E + "個，可分為:" + E / 12 + "打，剩" + E % 12 + "個蛋");

            Console.ReadLine();
        }
    }
}
