using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItCloud.Education.MathLibs
{
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
                    return a / b;
                case Operation.Multiply:
                    return a * b;
                default:
                    return -1;
            }
        }
    }
}
