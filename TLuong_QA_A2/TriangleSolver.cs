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
            
            if (a + b < c || a + c < b || b + c < a)
            {
                return result = "Not a triangle";
            }
            else if (a == b && b == c)
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
