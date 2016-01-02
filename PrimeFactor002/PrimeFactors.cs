using System.Collections.Generic;

namespace PrimeFactor002
{
    public class PrimeFactors
    {
        public static IEnumerable<int> Generate(int n)
        {
            var factors = new List<int>();
            var candidate = 2;

            while (n > 1)
            {
                while ((n % candidate) == 0)
                {
                    factors.Add(candidate);
                    n /= candidate;
                }
                candidate++;
            }

            return factors;
        }
    }
}
