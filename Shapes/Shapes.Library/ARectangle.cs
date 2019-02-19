using System;

namespace Shapes.Library
{
    public abstract class ARectangle : Shape
    {
        public double length { get; set; }
        public double width { get; set; }

        public int Sides { get; set; }

        abstract public void Area();
    }
}
