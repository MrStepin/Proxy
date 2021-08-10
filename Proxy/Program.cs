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

            CCalCalculator caloriesCalculator = new CCalCalculator();

            StreamReader file = new StreamReader("C:\\Users\\Stas\\Desktop\\config.txt");
            
            while(!file.EndOfStream)
            {
                string line = file.ReadLine();
                if (line == "console")
                {
                    ICalculator calculator = new ConsoleProxy(caloriesCalculator);
                    calculator.DailyCalories(weight, height, line);
                    continue;
                }
                if (line == "file")
                {
                    ICalculator calculator = new FileLogProxy(caloriesCalculator);
                    calculator.DailyCalories(weight, height, line);
                }
            }
            file.Close();
        }
    }
}
