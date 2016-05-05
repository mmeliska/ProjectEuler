using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.CSharp
{
    public class PrimeFactorizer
    {
        public List<long> PerformPrimeFactorization(long number)
        {
            long workingNumber = number;

            List<long> primeFactors = new List<long>();

            long? factor = null;

            do
            {
                factor = FindFactor(workingNumber);
                if(factor.HasValue)
                {
                    primeFactors.Add(factor.Value);
                    workingNumber = workingNumber / factor.Value;
                }
            }
            while (factor.HasValue);

            if(workingNumber != number)
                primeFactors.Add(workingNumber);

            return primeFactors;
        }


        private long? FindFactor(long workingNumber)
        {
            for(int i = 2; i * i <= workingNumber; i++)
            {
                if (workingNumber % i == 0)
                {
                    return i;
                }
            }

            return null;
        }
    }
}