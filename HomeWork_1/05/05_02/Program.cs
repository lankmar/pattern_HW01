using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_1._05._05_02
{
    class Program
    {
        public interface IMath 
        {
            public double Add(double x, double y);
            public double Subtract(double x, double y);
            public double Multiply(double x, double y);
            public double Divide(double x, double y); 
        }

        class Math : IMath
        {
            public double Add(double x, double y) { return x + y; }
            public double Subtract(double x, double y) { return x - y; }
            public double Multiply(double x, double y) { return x * y; }
            public double Divide(double x, double y) { return x / y; }
        }

        class MathProxy : IMath
        {
            Math math = new Math();

            public double Add(double x, double y) => math.Add(x,y);
            public double Subtract(double x, double y) => math.Subtract(x, y);
            public double Multiply(double x, double y) => math.Multiply(x, y);
            public double Divide(double x, double y) => math.Divide(x, y);

        }
        static void Main(string[] args)
        {
            MathProxy proxy = new MathProxy();

            Console.WriteLine("25 + 3 = " + proxy.Add(25, 3));
            Console.WriteLine("25 - 3 = " + proxy.Subtract(25, 3));
            Console.WriteLine("25 * 3 = " + proxy.Multiply(25, 3));
            Console.WriteLine("25 / 3 = " + proxy.Divide(25, 3));
        }
    }
}
