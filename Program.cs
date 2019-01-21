//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("MutenSudak");
            Calc.Add(-10, 20);
            System.Console.ReadKey();
        }
    }
    class Calc
    {
        public static void Add(int x, int y)
        {
            int z = x + y;
            System.Console.WriteLine($"{x} + {y} = {z}");
        }
    }
}
