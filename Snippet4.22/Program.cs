﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet4._22
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num = 0;
            while(true)
            {
                byte fact = 1;
                Console.Write("Please enter the number : ");
                num = Convert.ToByte(Console.ReadLine());
                if (num < 0)
                {
                    goto stop;
                }
                for(byte j =num; j>0;j--)
                { 
                    if(j>4)
                    {
                        goto stop;
                      }
                    fact *= j;
                    Console.WriteLine("Factorial of {0} is {1} ", num, fact);
                }
            stop:
                Console.WriteLine("Exting the program ");
                Console.ReadKey();
            }
            
        }
        
    }
}
