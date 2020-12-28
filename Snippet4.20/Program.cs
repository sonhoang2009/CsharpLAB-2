using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet4._20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even number in the rage of (1-10) :");
            for (int i=1;i<=10;i++)
            {
                if(i%2 !=0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
