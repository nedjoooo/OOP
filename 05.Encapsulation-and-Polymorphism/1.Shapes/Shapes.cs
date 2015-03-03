using System;
using System.Collections.Generic;

namespace _1.Shapes.Shapes
{
    class Shapes
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>()
            {
                new Circle(2.3),
                new Rectangle(2, 3),
                new Triangle(2, 3.5, 75),
                new Circle(4),
                new Rectangle(1.3, 5.5),
                new Triangle(2.5, 4, 60)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name);
                Console.WriteLine("Area -> " + shape.CalculateArea());
                Console.WriteLine("Perimeter -> " + shape.CalculatePerimeter());
                Console.WriteLine();
            }
        }
    }
}
