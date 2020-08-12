using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Shape3D : Shape2D
    {
        private int hight;
        public Shape3D(int width, int length, int hight) : base(width, length)
        {
            this.hight = hight;
        }

        public int Volume()
        {
            return base.Area() * hight;
        }
    }
}
