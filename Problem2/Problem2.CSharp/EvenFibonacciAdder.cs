using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.CSharp
{
    class EvenFibonacciAdder
    {
        public int AddEvenFibonacciNumbers(int maxSequenceValue)
        {
            var term1 = 1;
            var term2 = 2;
            var result = 0;

            while(term2 <= maxSequenceValue)
            {
                var temp = term2;
                term2 = term1 + term2;
                term1 = temp;
                if(term1 %2 == 0)
                {
                    result += term1;
                }
            }

            return result;
        }
    }
}
