﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter the month :");
            input = Console.ReadLine().ToUpper();
            switch(input)
            {
                case "JANUARY":
                case "MARCH":
                case "MAY":
                case "JULY":
                case "AUGUST":
                case "OCTOBER":
                case "DECEMBER":
                    Console.WriteLine("This month has 31 days");
                    break;
                case "APRIL":
                case "JUNE":
                case "SEPTEMBER":
                case "NOVEMBER":
                    Console.WriteLine("This month has 30 days");
                    break;
                case "FEBRURY":
                    Console.WriteLine("This month has 28 days or 29 days");
                    break;
                default:
                    Console.WriteLine("Incorrect choice");
                    break;
                    





            }
            Console.ReadKey();

        }
    }
}
