using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Logic;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrDoubles = {};
            MaximumElementOfArray maximum = new MaximumElementOfArray(arrDoubles);
            Console.WriteLine(maximum.GetMaximum(0,arrDoubles.Length-1));
            Console.ReadKey();
        }
    }
}
