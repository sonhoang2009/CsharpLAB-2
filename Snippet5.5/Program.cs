using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studens = new string[3] { "James", "Alex", "Fernado" };
            for(int i=0;i<studens.Length;i++)
            {
                Console.WriteLine(studens[i]);
            }
            Console.ReadKey();
        }
    }
}
