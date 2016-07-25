using DrawSquareTriangle.Biz.Strategy;
using System;
using System.Linq;

namespace DrawSquareTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var option = "";
            var strats = new FactoryDrawStrategy();
            
            do
            {
                IDrawStrategy strat = strats.factory.FirstOrDefault(s => s.CanHandle(option.ToLowerInvariant()));
                if (strat != null)
                {
                    strat.Draw();
                }
                Console.Out.WriteLine("Square(s) or Triangle(t), or maybe close(c)");
                option = Console.In.ReadLine();
            }
            while (option.ToLowerInvariant() != "c");
        }
    }
}
