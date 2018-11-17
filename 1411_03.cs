using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1411_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
           

            for (int j = 1; j <= x; j++)
            {


                for (int i = 1; i <= j; i++)
                {

                    Console.Write(i);

                }
                Console.WriteLine();
            }
            for (int j = x-1; j >= 0; j--)
            {
                for (int i = 1; i <= j; i++)
                {

                    Console.Write(i);

                }
                Console.WriteLine();
            }
            
        }
    }
}
