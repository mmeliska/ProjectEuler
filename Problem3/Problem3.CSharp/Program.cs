using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.CSharp
{
    class Program
    {
        static void Main(string[] args)
        { 
            long number = 600851475143;

            var factors = new PrimeFactorizer().PerformPrimeFactorization(number);

            if(factors.Any())
                Console.WriteLine(factors.Max());
            else
                Console.Write("Number is prime");



        }
    }
}