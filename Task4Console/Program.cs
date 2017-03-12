using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4Logic;

namespace Task4Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var concat = new StringConcatenation("qwejluhabcdefjrt", "ytrewqqqq");
            var str = concat.Concatenation();
            if (str != null)
                Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
