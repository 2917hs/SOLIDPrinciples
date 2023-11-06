using System;
using System.Drawing;

namespace SOLIDPrinciples.OpenClosed
{
	public class OldImplementation
	{
		public OldImplementation()
		{
		}

        public double Area(object[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)shape;
                    area += rectangle.Width * rectangle.Height;
                }
                else
                {
                    Circle circle = (Circle)shape;
                    area += circle.Radius * circle.Radius * Math.PI;
                }
            }

            return area;
        }

        public class AreaCalculator
        {
            public double Area(Rectangle[] shapes)
            {
                double area = 0;
                foreach (var shape in shapes)
                {
                    area += shape.Width * shape.Height;
                }

                return area;
            }
        }
    }

    internal class Circle
    {
        public int Radius { get; internal set; }
    }
}

