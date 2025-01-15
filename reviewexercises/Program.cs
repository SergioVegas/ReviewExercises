using System;
using MyLibrary;
 namespace reviewexercises
{
    public class exercicis
    {
        public class Exercici5
        {
            public static void Main()
            {
                const string MsgEX3 = "Introdueix els graus Celsius";

                Console.WriteLine(MsgEX3);
                double celsius = EX5.CheckType();
                Console.WriteLine($"{EX5.CelsiusToKelvin(celsius)} graus Fahrenheit");
            }
        }
    }

}