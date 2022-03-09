using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_For_NUnit_Testing_Day06_02
{
     class Monthly_Payment
    {
        public static void CalculateMonthlyPayment()
        {
            int P, Y, R;
            float z, n;
            Console.WriteLine("Enter the Year: ");
            Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount percent interest: ");
            R = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Principal Amount: ");
            P = int.Parse(Console.ReadLine());
            n = 12f * Y;
            Console.WriteLine("Value of n is : " + n);
            z = R / 1200f;
            Console.WriteLine("Value of z is : " + z);

            double pow_ab = Math.Pow((1 + z), n);
            Console.WriteLine(pow_ab);

            double payment = P * z * pow_ab / pow_ab - 1;
            Console.WriteLine("Payment: " + payment);
        }
    }
}
