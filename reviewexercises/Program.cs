using System;
using MyLibrary;

 namespace reviewexercises
{
    public class Exercici3
    {
        public static void Main()
        {
            const string MsgEX3 = "Introdueix els graus Celsius";

            Console.WriteLine(MsgEX3 );
            double celsius = EX3.CheckType();
            Console.WriteLine($"{EX3.CelsiusToFahrenheit(celsius)} graus Fahrenheit");
        }
    }

}