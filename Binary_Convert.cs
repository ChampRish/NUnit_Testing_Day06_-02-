using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_For_NUnit_Testing_Day06_02
{
    public class Binary_Convert
    {
        public static void toBinary()
        {
            Console.WriteLine("Enter to Number : ");
            int value = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            Console.WriteLine(binary);
        }
    }
}
