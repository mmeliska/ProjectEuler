using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            MultipleAdder adder = new MultipleAdder();

            var result = adder.GetSumOfMultiples(new List<int>() { 3, 5 }, 1000);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
