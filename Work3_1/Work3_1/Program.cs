using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int high, upBase, tmepHigh;//命令行参数中依次输入上底和高
            upBase = Convert.ToInt32(args[0]);
            tmepHigh = high = Convert.ToInt32(args[1]);
            for (int i = 1; i <= high; i++)
            {
                for (int j = 1; j <= tmepHigh - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= upBase; k++)
                {
                    Console.Write("*");
                }
                tmepHigh--;
                upBase += 2;
                Console.WriteLine();
            }
        }
    }
}
