using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenFibonacciAdder adder = new EvenFibonacciAdder();
            var result = adder.AddEvenFibonacciNumbers(4000000);

            Console.WriteLine(result);
        }
    }
}
