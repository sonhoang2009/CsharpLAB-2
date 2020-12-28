using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet5._11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentName = new string[3] { "Ashley", "Joe", "Mikel" };
            foreach(string studName in studentName)
            {
                Console.WriteLine("Congratilations!!" + studName + " you have been granted an extra leave");
            }
            Console.ReadKey();
        }
    }
}
