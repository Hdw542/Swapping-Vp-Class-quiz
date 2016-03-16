using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping
{
    class Program
    {
        static void Main(string[] args)
        {
            // class + quiz
            // swap two numbers without using third variable
            int var1 = 10;
            int var2 = 20;
            var1 = var1 + var2; //var1 = 30
            var2 = var1 - var2; //var2 swapped & equal 10
            var1 = var1 - var2; //var1 swapped & equal 20

            Console.Out.WriteLine("Variable 1 = " + var1);
            Console.Out.WriteLine("Variable 2 = " + var2);
            Console.ReadLine();
        }
    }
}
