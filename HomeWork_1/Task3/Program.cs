using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_1.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure f = Factory.GetFigure("Квадрат");
            f.Draw();

            Console.ReadLine();
        }
    }
}
