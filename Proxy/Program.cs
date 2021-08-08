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
            ICalculator calculator = new Proxy(caloriesCalculator);

            StreamReader file = new StreamReader("C:\\Users\\Stas\\Desktop\\config.txt");
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                if (line == "file")
                {
                    File.AppendAllText("C:\\Users\\Stas\\Desktop\\result.txt", Convert.ToString(calculator.DailyCalories(weight, height)));
                    continue;
                }
                if (line == "console")
                {
                    Console.WriteLine(calculator.DailyCalories(weight, height));
                    Console.ReadKey();
                }
            }
            file.Close();

        }
    }
}
