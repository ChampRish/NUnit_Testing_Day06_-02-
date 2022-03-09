using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_For_NUnit_Testing_Day06_02
{
    public class Vending_Machine
    {
        public static void countCurrency()
        {
            Console.WriteLine("Enter Your Amount :");
            int amount = int.Parse(Console.ReadLine());
            int[] notes = new int[] { 1000, 500, 200, 100, 50, 20, 10, 5, 1 };
            int[] noteCounter = new int[9];

            // count notes using Greedy approach
            for (int i = 0; i < 9; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount - noteCounter[i] * notes[i];
                }
            }
            // Print notes
            Console.WriteLine("Currency Count ->");
            for (int i = 0; i < 9; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : "
                        + noteCounter[i]);
                }
            }
        }
    }
}
