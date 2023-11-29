using Lab._56.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._56.Entities.Figures
{
    public class Circle : Shape
    {
        public int R { get; set; }

        public override int CalculateArea()
        {
            return (R ^ 2) * 3;
        }
    }
}
