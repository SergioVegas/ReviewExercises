using System;
using LibraryMath;
using MyLibrary;
 namespace reviewexercises
{
    public class ExercicisRepas
    {
        public static void Main()
        {
           int restantMinuts = 0;
           int restantSeconds= 0;
           int hours = 0;
           int seconds = 0;

            Console.WriteLine("Introdueix el numero de segons per pasar");
            try 
            { 
             seconds = int.Parse(Console.ReadLine());
            }
            catch (FormatException){ Console.WriteLine("Introdueix el numero correctament"); }

            restantSeconds = EX1.RestantSeconds(seconds);
            restantMinuts = EX1.RestantMinutes(seconds);
            hours = EX1.ConvertHour(seconds);

            Console.WriteLine($"Et quedan {hours} hores, {restantMinuts} minuts i {restantSeconds} segons.");
        }

    }
}