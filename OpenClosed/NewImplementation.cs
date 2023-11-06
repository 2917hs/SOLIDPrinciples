using System;
namespace SOLIDPrinciples.OpenClosed
{
	public class NewImplementation
	{
		public NewImplementation()
		{
		}

        public abstract class Shape
        {
            public abstract double Area();
        }

        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public override double Area()
            {
                return Width * Height;
            }
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }
            public override double Area()
            {
                return Radius * Radius * Math.PI;
            }
        }

        public class Triangle : Shape
        {
            public int Base { get; private set; }
            public int Height { get; private set; }

            public override double Area()
            {
                return Base * Height / 2;
            }
        }

        public double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }
    }
}

