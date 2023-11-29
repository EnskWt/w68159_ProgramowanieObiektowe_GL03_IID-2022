using Lab._4.Entities.AbstractBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._4.Entities
{
    class Square : Shape
    {
        public override int CalculateArea()
        {
            return SizeY * SizeZ;
        }
    }
}
