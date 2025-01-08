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
            try 
            { 
            int seconds = int.Parse(Console.ReadLine());
            }
            catch (FormatException){ Console.WriteLine("Introdueix el numero correctament"); }

            EX1.ConvertMinutes(seconds);
        }

    }
}