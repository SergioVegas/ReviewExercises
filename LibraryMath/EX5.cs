using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public   class EX5
    {
        public static double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15 ;
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
                }
                catch (FormatException)
                { Console.WriteLine("Format incorrecte"); }
            }
            return needCheck;
        }
    }
}
