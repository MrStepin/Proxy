using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface ICalculator
    {
        int DailyCalories(int weight, int height, string line);
    }
}
