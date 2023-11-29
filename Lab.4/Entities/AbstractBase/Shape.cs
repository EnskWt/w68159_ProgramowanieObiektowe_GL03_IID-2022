using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._4.Entities.AbstractBase
{
    public abstract class Shape
    {
        public Position Position { get; set; } = new Position(0, 0);

        public int SizeX { get; set; } = 0;
        public int SizeY { get; set; } = 0;
        public int SizeZ { get; set; }  = 0;

        public abstract int CalculateArea();
    }

    public struct Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
