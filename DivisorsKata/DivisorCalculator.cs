using System.Collections.Generic;
using System.Linq;

namespace DivisorsKata
{
    public class DivisorCalculator
    {
        public int[] Calculate(int inputNumber)
        {
            var divisors = new List<int> {1};

            if (inputNumber % 2 == 0)          
                divisors.AddRange(new List<int> {2, inputNumber / 2});

            divisors.Add(inputNumber);

            divisors.Sort();
            return divisors.Distinct().ToArray();
        }
    }
}
