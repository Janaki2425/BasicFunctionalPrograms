using System;

namespace BasicFunctionalPrograms
{
    class LeapYr
    {
        public static void checkLeapYear()
        {
            int check_Leapyear;
            Console.WriteLine("Check whether a given year is leap year or not:");
            Console.WriteLine("Input an year : ");
            check_Leapyear = Convert.ToInt32(Console.ReadLine());

            if ((check_Leapyear % 400) == 0)
                Console.WriteLine("{0} is a leap year.", check_Leapyear);
            else if ((check_Leapyear % 100) == 0)
                Console.WriteLine("{0} is not a leap year.", check_Leapyear);
            else if ((check_Leapyear % 4) == 0)
                Console.WriteLine("{0} is a leap year.", check_Leapyear);
            else
                Console.WriteLine("{0} is not a leap year.", check_Leapyear);
        }
    }
}