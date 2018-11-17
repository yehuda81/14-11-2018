using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1411_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int m = x / 2 + 1;
            int j = 1;
            while (j <= x)
            {
                for (int i = 1; i < m; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 1; i <= j; i++)
                {
                    Console.Write("*");
                }
                m--;
                j = j + 2;
                Console.WriteLine();
            }
        }
    }
}
