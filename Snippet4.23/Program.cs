using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet4._23
{
    class Program
    {
        static void Main(string[] args)
        {
            int yrsofSevices = 5;
            double salary = 1250;
            double bonus = 0;
            if (yrsofSevices <= 5)
            {
                bonus = 50;
                return;
            }
            else
            {
                bonus = salary * 0.2;
            }
            Console.WriteLine("Salary amount: " + salary);
            Console.WriteLine("Bonus amount: " + bonus);
            Console.ReadKey();
        }
    }
}
