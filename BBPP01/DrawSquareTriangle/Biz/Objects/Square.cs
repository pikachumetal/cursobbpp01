using System;

namespace DrawSquareTriangle.Biz
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
