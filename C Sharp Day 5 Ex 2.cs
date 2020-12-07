using System;

namespace Check_consist_uc_letters
{
    class Program
    {
        static bool IfConsistsOfUppercaseLetters(string str)
        {
            return (str[0] >= 65 && str[1] >= 65 && str[2] >= 65) && (str[0] <= 90 && str[1] <= 90 && str[2] <= 90);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IfConsistsOfUppercaseLetters("LOL"));  
            Console.WriteLine(IfConsistsOfUppercaseLetters("Sas")); 
            Console.WriteLine(IfConsistsOfUppercaseLetters("dog")); 
            Console.WriteLine(IfConsistsOfUppercaseLetters("ugesh kumar"));
            Console.WriteLine(IfConsistsOfUppercaseLetters("ANT"));
        }
    }
}