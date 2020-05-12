using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startree
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 8;
            for(int i = 0; i < height; i++)
            {
                for(int j = height-1-i; j >= 0; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < i*2+1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
