using System;

namespace DrawSquareTriangle.Biz.Objects
{
    public class Triangle : IDrawableObject
    {

        bool IDrawableObject.Draw()
        {
            Console.Out.WriteLine("I'am a triangle. Hurray!");
            return true;
        }
    }
}
