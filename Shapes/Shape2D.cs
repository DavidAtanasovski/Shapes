using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Shape2D
    {
        private int width;
        private int length;
        public Shape2D(int width, int length)
        {
            this.width = width;
            this.length = length;
        }

        protected int Area()
        {
            return width * length;
        }
    }
} 
