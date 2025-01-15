using System;
using MyLibrary;

 namespace reviewexercises
{
    public class Exercici4
    {
        public static void Main()
        {
            const string MsgEX4 = "Introdueix els graus Kelvins";

            Console.WriteLine(MsgEX4 );
            double kelvin = EX4.CheckType();
            Console.WriteLine($"{EX4.KelvinToFahrenheit(kelvin)} graus Fahrenheit");

        }
    }

}