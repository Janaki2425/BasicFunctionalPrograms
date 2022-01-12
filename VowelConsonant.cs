using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
namespace BasicFunctionalPrograms
{
    internal class VowelConsonant
    { 
        public static void UserInput()
       {

        Console.WriteLine("enter any alphabet");
          char c = Convert.ToChar(Console.ReadLine());
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                Console.WriteLine("alphabet is vowel");
            }
            else if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                Console.WriteLine("alphabet is consonant");
             }
            else
            {
                Console.WriteLine("Invalid Input");
            }
          }
     }       
}
