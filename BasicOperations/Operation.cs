using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations
{
    public static class Operation
    {
        public static double Add(double left, double right)
        {
            return left + right;
        }

        public static double Subtract( double left, double right)
        {
            return left - right;
        }

        public static double Multiply( double left, double right)
        {
            return left * right;
        }

        public static double Power( double left, double right)
        {
            return Math.Pow(left, right);
        }
    }
}
