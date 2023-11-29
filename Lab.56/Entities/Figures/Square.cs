using Lab._56.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._56.Entities.Figures
{
    public class Square : Shape
    {
        public int A { get; set; }

        public override int CalculateArea()
        {
            return A ^ 2;
        }
    }
}
