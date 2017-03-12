using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3Logic;

namespace Task3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] {5, 67, 67, 68, 6, -46, 0, 12, 2, -4, 6};
            foreach (int x in arr)
                Console.Write(x + " ");
            Console.WriteLine();
            var merge = new MergeSort(arr);
            merge.Sort(0,arr.Length-1);
            foreach (int x in arr)
                Console.Write(x + " ");
            Console.ReadKey();
        }
    }
}
