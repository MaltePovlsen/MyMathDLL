using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathDLL
{
    public class Math
    {
        /// <summary>
        /// Add numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        /// <summary>
        /// Multiply numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
        /// <summary>
        /// subtract
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
