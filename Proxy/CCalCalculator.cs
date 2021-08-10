using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class CCalCalculator : ICalculator
    {
        public ICalculator CaloriesCalculator { get; set; }

        public int DailyCalories(int weight, int height, string line)
        {
            int result = (height - weight + 1500);
            return result; 
        }

    }
}
