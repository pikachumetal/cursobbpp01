using System;

namespace DrawSquareTriangle.Biz.Objects
{
    class Square : IDrawableObject
    {

        bool IDrawableObject.Draw()
        {
            Console.Out.WriteLine("I'am a square. Hurray!");
            return true;
        }
    }
}
