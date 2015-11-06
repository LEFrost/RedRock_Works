using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入所要到的数:");
            int i;
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("从0到{0}:{1}", i, way(i));
        }
        static string way(int y, int x = 0)
        {
            int[] a;
            a = new int[10] { -1, 0, 0, 1, 2, 4, 3, 3, 5, 6 };
            if (y == 0)
            {
                return "0";
            }
            else
            {
                return way(a[y]) + " " + y;
            }
        }
    }
}
