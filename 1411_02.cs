using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1411_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int mea = t / 100;
            int shloshim = (t - mea * 100) / 30;
            int bait = (t - mea * 100 - shloshim * 30);
            Console.WriteLine(mea);
            Console.WriteLine(shloshim);
            Console.WriteLine(bait);
        }
    }
}
