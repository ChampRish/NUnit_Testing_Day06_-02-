using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_For_NUnit_Testing_Day06_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureConversion.DisplayTempConversion();
            Vending_Machine.countCurrency();
            Monthly_Payment.CalculateMonthlyPayment();
            Binary_Convert.toBinary();

            Console.ReadLine();
        }
    }
}
