using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class EX7
    {
        public static int CheckType()
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
        public static void DecimalToHexadecimal(int decimalNumb)
        {
            int result = 0;


            while (decimalNumb > 16)
            {
                result = decimalNumb / 16;
                decimalNumb = decimalNumb % 16;

                Console.Write(HexadecimalsLetters(result));
            }
            Console.WriteLine(HexadecimalsLetters(decimalNumb));
        }
        public static string HexadecimalsLetters(int hexadecimalNumb)
        {
            switch (hexadecimalNumb)
            {
                case 10:
                    return "A";
                    break;
                case 11:
                    return "B";
                    break;
                case 12:
                    return "C";
                    break;
                case 13:
                    return "D";
                    break;
                case 14:
                    return "E";
                    break;
                case 15:
                    return "F";
                    break;
                default:
                    return $"{hexadecimalNumb}";
            }
        }
    }
}
