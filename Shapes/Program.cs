using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var s2d = new Shape2D(3, 4);
            var square = new Square(3);
            var s3d = new Shape3D(3, 4, 5);

            
            s3d.Volume();
        }
    }
}
