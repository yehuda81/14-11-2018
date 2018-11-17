using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1411_01
{
    class Program
    {
        static void Main(string[] args)
        {
            rishoni();

        }

        private static void rishoni()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int m = 2;
            while (a % m != 0 && m < a)
            {
                m++;
            }
            if (a == m)
            {
                Console.WriteLine("rishoni");
                
            }
            else
                Console.WriteLine("try again");
                rishoni();
        }
    }
}
