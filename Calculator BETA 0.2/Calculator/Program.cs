namespace Calculator1

{
    public class Calculator
    {
        private char _oper;


        public float Plus(float x, float y)
        {
            return x + y;
        }

        public float Minus(float x, float y)
        {
            return x - y;
        }

        public float Multiply(float x, float y)
        {
            return x * y;
        }

        public float Dividing(float x, float y)
        {
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