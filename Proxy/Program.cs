using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height");
            int height = Convert.ToInt32(Console.ReadLine());

            ICalculator caloriesCalculator = new CCalCalculator();

            StreamReader file = new StreamReader("C:\\Users\\Stas\\Desktop\\config.txt");
            string line = file.ReadLine();
            
            if (line == "file")
            {
                caloriesCalculator = new FileLogProxy(caloriesCalculator);
            }
            line = file.ReadLine();
            if (line == "console")
            {
                caloriesCalculator = new ConsoleProxy(caloriesCalculator);
            }
            file.Close();
            caloriesCalculator.DailyCalories(weight, height, line);
        }
    }
}
