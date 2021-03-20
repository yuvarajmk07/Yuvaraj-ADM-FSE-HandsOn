using System;

namespace FacadePattern
{
    class FacadePatternDemo
    {
        static void Main(string[] args)
        {
            ShapeMaker shapeMaker = new ShapeMaker();
            shapeMaker.drawCircle();
            shapeMaker.drawRectangle();
            shapeMaker.drawSquare();
        }
    }
}
