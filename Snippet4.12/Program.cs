using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet4._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 2;
            int colums = 2;
            for (int i =0; i< rows; i++)
            {
                for (int j=0; j<colums;j++)
                {
                    Console.Write("{0}", i * j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
