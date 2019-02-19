using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    public class Square : ARectangle
    {
        public override void Area()
        {
            Console.WriteLine($"The area of the Square is {4 * length}");
        }
    }
}
