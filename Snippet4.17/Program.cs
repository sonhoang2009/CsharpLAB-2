﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet4._17
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int num, i;
            Console.WriteLine("Enter the number whose factorial you wis to calculate ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; fact *= i++ ) ;
            Console.WriteLine("Factorial : " + fact);
            Console.ReadKey();
        }
        
    }

}
