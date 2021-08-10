using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class FileLogProxy : ICalculator
    {
        private readonly ICalculator _caloriesCalculator;

        public FileLogProxy(ICalculator caloriesCalculator)
        {
            _caloriesCalculator = caloriesCalculator;
        }

        public int DailyCalories(int weight, int height, string line)
        {
            int resultCalories = _caloriesCalculator.DailyCalories(weight, height, line);

            File.AppendAllText("C:\\Users\\Stas\\Desktop\\result.txt", Convert.ToString(resultCalories));  
    
            return resultCalories;
        }
    }
}
