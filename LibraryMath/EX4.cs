using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class EX4
    {
        public static double KelvinToFahrenheit(double kelvin)
        {
            return 1.8*(kelvin-273)+32;
        }
        public static double CheckType()
        {
            double needCheck = 0;
            bool flag = true;

            while (flag)
            {
                try
                {
                    needCheck = double.Parse(Console.ReadLine());
                    flag = false;
                    if(needCheck <0)
                    {
                        flag = true;
                        Console.WriteLine("Els graus Kelvins no poden ser negatius");
                    }
                }
                catch (FormatException)
                { Console.WriteLine("Format incorrecte"); }
               
            }
            return needCheck;
        }
    }
}
