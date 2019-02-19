using System;
using Shapes.Library;

namespace Shapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle
            {
                Sides = 1,
                radius = 4.67
            };

            var triangle = new Triangle
            {
                Sides = 3,
                Base = 6,
                Height = 3.5
            };

            var square = new Square
            {
                Sides = 4,
                width = 2.98,
                length = 8.11
            };

            var items = new Shape[3];
            items[0] = circle;
            items[1] = triangle;
            items[2] = square;

            foreach (var item in items)
            {
                Console.WriteLine($"I have {item.Sides} number of sides");
                item.Area();

            }

        }
    }
}
