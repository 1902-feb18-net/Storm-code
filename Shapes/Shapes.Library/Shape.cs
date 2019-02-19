using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    public interface Shape
    {
        int Sides { get; set; }


        void Area();
    }

}
