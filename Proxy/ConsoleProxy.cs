using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ConsoleProxy : ICalculator
    {
        private readonly ICalculator _caloriesCalculator;

        public ConsoleProxy(ICalculator caloriesCalculator)
        {
            _caloriesCalculator = caloriesCalculator;
        }

        public int DailyCalories(int weight, int height)
        {
            int resultCalories = _caloriesCalculator.DailyCalories(weight, height);

            Console.WriteLine(resultCalories);
            return resultCalories;
        }
    }
}
