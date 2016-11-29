using System.Collections.Generic;
using System.Linq;

namespace DivisorsKata
{
    public class DivisorCalculator
    {
        public int[] Calculate(int inputNumber)
        {
            return Enumerable.Range(1, inputNumber)
                .Where(x => inputNumber%x == 0)
                .ToArray();
        }
    }
}
