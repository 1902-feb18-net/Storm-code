using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public  int Sides { get; set; }

        public void Area()
        {
            Console.WriteLine($"The area of the triangle is {.5 * Base * Height}");
        }
    }
}
