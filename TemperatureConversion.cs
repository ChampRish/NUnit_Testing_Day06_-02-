using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_For_NUnit_Testing_Day06_02
{
    public class TemperatureConversion
    {
        public static void DisplayTempConversion()
        {
            double fahrenheit;

            double celsius;
            Console.Write("Enter the value of Celsius : ");

            celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("Celsius: " + celsius);

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);


            Console.Write("Enter the value of Fehrenheit : ");
            fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine("fahrenheit: " + fahrenheit);

            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("celsius: " + celsius);
            Console.ReadLine();
        }
    }
}

