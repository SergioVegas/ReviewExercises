using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class EX10
    {
        public static double CheckType()
        {
            const string MsgNoNegative = "Aquest nombre no pot ser negatiu. ";
            double needCheck = 0;
            bool flag = true;

            while (flag)
            {
                try
                {
                    needCheck = double.Parse(Console.ReadLine());
                    flag = false;
                    if (needCheck < 0)
                    {
                        flag = true;
                        Console.WriteLine(MsgNoNegative);
                    }
                }
                catch (FormatException)
                { Console.WriteLine("Format incorrecte"); }

            }
            return needCheck;
        }
        public static int CheckTypeInt()
        {
            const string MsgNoNegative = "Aquest nombre no pot ser negatiu. ";
            int needCheck = 0;
            bool flag = true;

            while (flag)
            {
                try
                {
                    needCheck = int.Parse(Console.ReadLine());
                    flag = false;
                    if (needCheck < 0)
                    {
                        flag = true;
                        Console.WriteLine(MsgNoNegative);
                    }
                }
                catch (FormatException)
                { Console.WriteLine("Format incorrecte"); }

            }
            return needCheck;
        }
        public static double CheckPropinaMultiplePersons(double price, double discount, int persones)
        {
            return ((price * discount) / 100)/persones;
        }

    }
}
