using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startree
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k < 16 - 2 * i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                
            }
        }
    }
}
