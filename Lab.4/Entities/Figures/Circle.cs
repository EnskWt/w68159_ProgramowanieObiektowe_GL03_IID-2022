using Lab._4.Entities.AbstractBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._4.Entities
{
    public class Circle : Shape
    {
        public override int CalculateArea()
        {
            return SizeX * SizeY;
        }
    }
}
