using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.CSharp
{
    public class MultipleAdder
    {
        public int GetSumOfMultiples(List<int> divisors, int nonInclusiveUpperBound)
        {
            var multiples = FindMultiples(divisors, nonInclusiveUpperBound);
            var result = multiples.Sum();

            return result;
        }

        private List<int> FindMultiples(List<int> divisors, int nonInclusiveUpperBound)
        {
            var resultList = new List<int>();
            for (int i = 2; i < nonInclusiveUpperBound; i++)
            {
                foreach (int d in divisors)
                {
                    if(i % d == 0)
                    {
                        resultList.Add(i);
                        break;
                    }
                }
            }

            return resultList;
        }
    }
}
