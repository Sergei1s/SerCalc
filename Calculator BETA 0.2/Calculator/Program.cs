using System;

namespace Calculator1

{
    public class Calculator
    {
        private char _oper;


        public double Plus(double x, double y)
        {
            return x + y;
        }

        public double Minus(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }

        private class ConsoleManager
        {
        }

        private class Program
        {
            private static void Main(string[] args)
            {
            }
        }
    }
}