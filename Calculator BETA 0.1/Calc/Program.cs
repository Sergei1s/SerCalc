using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1

{
    public class Calculator
    {
        public char oper;


        public float Plus(float x, float y)
        {
            return (x + y);
        }
        public float Minus(float x, float y)
        {
            return (x - y);
        }
        public float Multiply(float x, float y)
        {
            return (x * y);
        }
        public float Dividing(float x, float y)
        {
            return (x / y);
        }
        class ConsoleManager
        { }

        class Program
        {
            static void Main(string[] args)
            {

            }
        }
    }
}
