using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet4._18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employeeNames = { "maria", "wilson", "elton", "garry" };
            Console.WriteLine("Employee Names :");
            foreach(string name in employeeNames)
            {
                Console.WriteLine("{0}", name);
                
            }
            Console.ReadKey();

        }
    }
}
