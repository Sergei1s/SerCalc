﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double total;
            char oper;
            Console.WriteLine("enter the number :");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the operation :");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("and last one number : ");
            b = Convert.ToDouble(Console.ReadLine());
            if (oper == '+')
            {
                total = a + b;
                Console.WriteLine(" Sum " + a + " and " + b + " Equals " + total + " . ");
            }
            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine(" difference " + a + " and " + b + " equals " + total + " . ");

            }
            else if (oper == '/')
            {
                total = a / b;
                Console.WriteLine(" division " + a + "and" + b + " equals " + total + ".");
            }
            else if ( oper == '*')
            {
                total = a * b;
                Console.WriteLine(" multiplication "  +  a  +  " and "  +  b  +  " equals "  + total + " . ");
            }
            else
            {
                Console.WriteLine("Wrong operation");
            }

            Console.ReadKey();
        }
    }
}