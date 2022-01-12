using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalPrograms
{
    internal class Swapnos
    {
        public static void SwapTheNumbers()
        {
            Console.WriteLine("enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before swapping:{0} {1}", num1, num2);
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("after swapping:{0} {1}", num1, num2);
        }
    }
}
    

