using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    internal class EX3
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius*9/5)+32;
        }
        public static double CheckType()
        {
            double needCheck=0;
            bool flag = true;

            while (flag)
            {
                try 
                { 
                    needCheck = double.Parse(Console.ReadLine());
                    flag = false;
                }
                catch(FormatException) 
                { Console.WriteLine("Format incorrecte"); }
            }
            return needCheck;
        }
    }
}
