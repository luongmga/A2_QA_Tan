using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLuong_QA_A2
{
    public static class TriangleSolver
    {
        static string result = "";
        public static string Analyze(int a, int b, int c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return result = "Not a triangle";
            }
            else if (a + b < 0 || a + c < 0 || b + c < 0)
            {
                return result = "Out of calculation range";
            }
            else if (a < 0 || b < 0 || c < 0)
            {
                return result = "Invalid";
            }
            else
            {
                if (a == b && b == c)
                {
                    return result = "Equilateral Triangle";
                }
                else if (a == b || b == c || a == c)
                {
                    return result = "Isosceles Triangle";
                }
                return result = "Scalene Triangle";
            }
        }
    }
}
