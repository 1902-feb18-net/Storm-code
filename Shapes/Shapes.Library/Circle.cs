using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    public class Circle : Shape
    {
        public double radius { get; set; }


        public int Sides { get; set; }

        public void Area()
        {
            Console.WriteLine($"The circles volume is {radius * 3.14}");
        }
    }
}
