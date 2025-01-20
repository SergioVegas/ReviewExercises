using System;
using MyLibrary;
 namespace reviewexercises
{
    public class Exercici8
    {
        public static void Main()
        {
            const string MsgEX8 = "Introdueix un codi postal.";
            const string MsgNoPostal = "Aquest numero no es un codi postal";
            const string MsgPostal = "Aquest numero  es un codi postal";
            Console.WriteLine(MsgEX8);
            string postalCode = Console.ReadLine();

            if (EX8.CheckLength(postalCode) && EX8.CheckNumbersOnString(postalCode))
            {
               
               Console.WriteLine(MsgPostal);
                
            }
            else { Console.WriteLine(MsgNoPostal); }
                
        }
    }
}