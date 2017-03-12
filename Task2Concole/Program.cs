using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2Logic;

namespace Task2Concole
{
    class Program
    {
        static void Main(string[] args)
        {
            EqualsSumsOfArray sums = new EqualsSumsOfArray(new int[]{5,-2,4,2,2,1,4});
            Console.WriteLine(sums.GetIndex());
            Console.ReadKey();
        }
    }
}
