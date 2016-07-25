using DrawSquareTriangle.Biz;
using System;

namespace DrawSquareTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var option = "";
            var drawer = new Drawer();
            do
            {
                switch (option.ToLowerInvariant())
                {
                    case "s":
                        drawer.Draw(new Square());
                        break;
                    case "t":
                        drawer.Draw(new Triangle());
                        break;
                }
                Console.Out.WriteLine("Square(s) or Triangle(t), or maybe close(c)");
                option = Console.In.ReadLine();
            }
            while (option.ToLowerInvariant() != "c");
        }
    }
}
