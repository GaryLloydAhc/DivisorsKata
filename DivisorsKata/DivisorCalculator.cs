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

            if (inputNumber % 3 == 0)
                divisors.AddRange(new List<int> { 3, inputNumber / 3 });

            if (inputNumber % 4 == 0)
                divisors.AddRange(new List<int> { 4, inputNumber / 4 });

            if (inputNumber % 6 == 0)
                divisors.AddRange(new List<int> { 6, inputNumber / 6 });

            divisors.Add(inputNumber);

            divisors.Sort();
            return divisors.Distinct().ToArray();
        }
    }
}
