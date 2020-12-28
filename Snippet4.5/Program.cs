using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 5;
        
            switch(day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tusday");
                    break;
                case 4:
                    Console.WriteLine("Wedday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Sartuday");
                    break;

                default:
                    Console.WriteLine("Enter a number between 1 to 7:");
                    break;


            }
            Console.ReadKey();
        }
        
    }
}
