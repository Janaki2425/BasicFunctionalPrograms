using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalPrograms
{
    internal class QuotAndRemain
    {
        public static void QuotientAndRemainder()
        {
            Console.WriteLine("enter the value of dividend and divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int dividend = Convert.ToInt32(Console.ReadLine());
            double quotient = dividend / divisor;
            double reminder = dividend % divisor;
            Console.WriteLine("Quotient=" + quotient + "\n Reminder=" + reminder);
        }
    }
}

