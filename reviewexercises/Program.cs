using System;
using MyLibrary;
 namespace reviewexercises
{
    public class Exercici10
    {
        public static void Main()
        {
            const string MsgEX10 = "Introdueix primer el preu  i després el percentatge de la propina.";
            const string MsgNumbPersons = "Quantes persones heu sigut?";
            Console.WriteLine(MsgEX10);
            double price = EX10.CheckType();
            double percentage = EX10.CheckType();
            Console.WriteLine(MsgNumbPersons);
            int persones = EX10.CheckTypeInt();
            Console.WriteLine($"{EX10.CheckPropinaMultiplePersons(price, percentage, 2)} euros es la propina  que heu  de deixar cada persona");

        }
    }

}