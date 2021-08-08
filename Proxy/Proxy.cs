using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Proxy : ICalculator
    {
        private readonly ICalculator _caloriesCalculator;

        public Proxy(ICalculator caloriesCalculator)
        {
            _caloriesCalculator = caloriesCalculator;
        }

        public int DailyCalories(int weight, int height)
        {
            int resultCalories = _caloriesCalculator.DailyCalories(weight, height);

            return resultCalories;
        }
    }
}
