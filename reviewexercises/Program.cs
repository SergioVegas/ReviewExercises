using System;
using MyLibrary;
 namespace reviewexercises
{
    public class Exercici6
    {
        public static void Main()
        {
            const string MsgEX9 = "Introdueix primer el preu  i després el percentatge de la propina.";

            Console.WriteLine(MsgEX9);
            double price = EX9.CheckType();
            double percentage = EX9.CheckType();
            Console.WriteLine($"{EX9.CheckPropina(price, percentage)}euros es la propina  que has de deixar");

        }
    }
}