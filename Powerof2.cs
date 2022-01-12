using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalPrograms
{
    internal class Powerof2
    {
        public static void power()
        {
            int n;
            Console.WriteLine("Enter the Value: \n");
            n = Convert.ToInt32(Console.ReadLine());

            if (n < 31)
            {
                for (int i = 0; n <= 300; i += 1)
                {
                    n *= n;
                    Console.WriteLine(n);
                }
            }
            else
            {
                Console.WriteLine("enter the value under 31");
            }

        }
    }
}



