using System.Collections.Generic;
using System.Drawing;

//Реализовать шаблон «Приспособленец» при отображении на экране окружностей и прямоугольников в приложении Windows Forms.

namespace adapter
{
    class Factory
    {
        static Dictionary<string, IShape> windows = new Dictionary<string, IShape>();

        public static IShape GetShape(string shapeType)
        {
            switch (shapeType)
            {
                case "RedRectangle":
                    if (!windows.ContainsKey("RedRectangle"))
                        windows["RedRectangle"] = new RedRectangle();
                    return windows["RedRectangle"];
                case "BlueEllipse":
                    if (!windows.ContainsKey("BlueEllipse"))
                        windows["BlueEllipse"] = new BlueEllipse();
                    return windows["BlueEllipse"];
                default:
                    break;
            }
            return null;
        }
    }

    public interface IShape
    {
        void Draw(Graphics g, int x, int y, int width, int height);
    }

    public class RedRectangle : IShape
    {
        public static int count = 0;
        Brush brush;

        public RedRectangle()
        {
            brush = Brushes.Red;
            count++;
        }

        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            g.FillRectangle(brush, x, y, width, height);
        }
    }

    public class BlueEllipse : IShape
    {
        public static int count = 0;
        Brush brush;

        public BlueEllipse()
        {
            brush = Brushes.Blue;
            count++;
        }

        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            g.FillEllipse(brush, x, y, width, height);
        }
    }
}
