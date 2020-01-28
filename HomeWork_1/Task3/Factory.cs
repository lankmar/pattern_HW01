using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_1.Task3
{
    public class Factory
    {
        public static IFigure GetFigure(string figureType)
        {
            if (figureType == null) return null;

            switch (figureType)
            {
                
                case "Треугольник":
                    return new Triangle();
                case "Квадрат":
                    return new Square();
                case "Прямоугольник":
                    return new Rectangle();
                default:
                    break;
            }

            return null;
        }
    }
}
