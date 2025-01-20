using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class EX8
    {
        public static bool CheckLength (string something)
        { 
            return something.Length == 5?true:false;
        }
        public static bool CheckNumbersOnString(string something)
        {
            for (int i = 0; i < something.Length; i++)
            {
                if (!Char.IsNumber(something[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
