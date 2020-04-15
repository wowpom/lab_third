using System;
using System.Collections.Generic;
using System.Text;

namespace lab_third
{
    class MathematicalOperation
    {
        public double Add(double x)
        {
            x = x + 2;
            Console.WriteLine("Операция сложения:" + x);
            return x;
        }
        public double Multiply(double x)
        {
            x = x * 2;
            Console.WriteLine("Операция умножения:" + x);
            return x;
        }
        public double Subtraction(double x)
        {
            x = x - 1;
            Console.WriteLine("Операция вычитания:" + x);
            return x;
        }
        public double Division(double x)
        {
            x = x / 3;
            Console.WriteLine("Операция деления без остатка:" + x);
            return x;
        }
        public double Pow(double x)
        {
            x = x * x;
            Console.WriteLine("Операция квадрата:" + x);
            return x;
        }
    }
}
