using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathDLL
{
    public class Math
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
