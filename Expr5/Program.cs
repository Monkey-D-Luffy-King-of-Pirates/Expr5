using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr5
{
    internal class Program
    {
        static int LeapYears (int a, int b)
        {
            if ((a % 4 == 0) || (b % 4 == 0))
            {
                a = b - a;
                b = a / 4;
                return b + 1;

            }
            else if((a % 4 == 0) && (b % 4 == 0))
            {
                a = b - a;
                b = a / 4;
                return b + 2;
            }
            else 
            {
                a = b - a;
                return a / 4;
            }
        }
       
        static void Main(string[] args)
        {
            int c = LeapYears(1996, 2012);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
