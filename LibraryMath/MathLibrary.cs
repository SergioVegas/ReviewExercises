namespace LibraryMath
{
    public class EX2

    {
        public static int ClculateTriangleArea(int baseTriangle, int hight, int area)
        {   
            if (baseTriangle < 0 || hight < 0) { throw new Exception("No pots introduir nombres negatius!"); }
            else
            {
                 area = baseTriangle * hight;
            }
            return area;
        }
    }
}
