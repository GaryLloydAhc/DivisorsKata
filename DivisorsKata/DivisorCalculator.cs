using System.Collections.Generic;
using System.Linq;

namespace DivisorsKata
{
    public class DivisorCalculator
    {
        public int[] Calculate(int inputNumber)
        {
            List<int> list = new List<int>();
            var divisors = Enumerable.Range(1, inputNumber).Where((x) => inputNumber%x == 0);

            foreach (var div in divisors)
            {
                list.Add(div);
            }

            return list.ToArray();
        }
    }
}
