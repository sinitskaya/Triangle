using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Library
{
    public class Triangle
    {
        static public string typeTriangle(double a, double b, double c)
        {
            double[] t = { a, b, c };
            Array.Sort(t);
            a = t[0]; b = t[1]; c = t[2];

            if (a + b > c)
            {
                if (a * a + b * b == c * c)
                {
                    return "Triangle is rectangular";
                }
                else if (a * a + b * b > c * c)
                {
                    return "Triangle is acute-angled";
                }
                else
                {
                    return "Triangle is obtuse";
                }
            }
            else
            {
                return "Triangle does not exist";
            }
        }
    }
}
