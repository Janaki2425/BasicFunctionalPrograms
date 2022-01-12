using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalPrograms
{
    internal class Harmonic
    {
        public static void harmonicSeries()
        {
            int i, n;
            double s = 0.0;

            Console.Write("harmonic series:");


            Console.Write("Enter the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                for (i = 1; i <= n; i++)
                {
                    Console.Write("1/{0} + ", i);
                    s += 1 / (float)i;
                }
                Console.WriteLine("Sum of  harmonic Series on {0} terms : {1} ", n, s);
            }
            else
            {
                Console.WriteLine("enter a value greater than '0'");
            }

        }
    }
}

