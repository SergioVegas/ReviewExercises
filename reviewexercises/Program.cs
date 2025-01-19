using System;
using MyLibrary;
 namespace reviewexercises
{

    public class Exercici7
    {
        public static void Main()
        {
            const string MsgEX7 = "Introdueix un numero en decimal per passar-ho a hexadecimal";

            Console.WriteLine(MsgEX7);
            int decimalNumb = EX7.CheckType();
            EX7.DecimalToHexadecimal(decimalNumb);

        }
    }
}