using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItCloud.Education.MathLibs
{
    public class MultipyOverflowException: Exception
    {
        public MultipyOverflowException(string message, Exception err): base(message, err)
        {

        }
    }

    public static class Calculator
    {
        public enum Operation
        {
            Plus,
            Minus,
            Devide,
            Multiply
        }

        public static int Calculate(int a, int b, Operation operation)
        {
            switch (operation)
            {
                case Operation.Plus:
                    return a + b;
                case Operation.Minus:
                    return a - b;
                case Operation.Devide:
                    if (b == 0)
                    {
                    }
                    try
                    {
                        return a / b;
                    }
                    catch (DivideByZeroException err)
                    {
                        throw new ArgumentException($"For {operation} operation the '{nameof(b)}' argument should not be equal to 0", err);
                    }
                case Operation.Multiply:
                    try
                    {
                        return (int)((long)a * (long)b);
                    }
                    catch (ArgumentOutOfRangeException err)
                    {
                        throw new MultipyOverflowException($"{a}*{b} is out of integer range", err);
                    }
                default:
                    return -1;
            }
        }
    }
}
