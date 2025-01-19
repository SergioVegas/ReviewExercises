using System;
using MyLibrary;
 namespace reviewexercises
{
    public class Exercici6
    {
        public static void Main()
        {
            const string MsgEX6 = "Introdueix primer el preu inicial i després el preu final.";

            Console.WriteLine(MsgEX6);
            double initialPrice = EX6.CheckType();
            double finalPrice = EX6.CheckType();
            Console.WriteLine($"{EX6.CheckDiscount(initialPrice, finalPrice)}% es el descompte en aquest producte");

        }
    }

}