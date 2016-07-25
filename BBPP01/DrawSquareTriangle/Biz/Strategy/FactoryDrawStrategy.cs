using System.Collections.Generic;

namespace DrawSquareTriangle.Biz.Strategy
{
    class FactoryDrawStrategy
    {
        public IEnumerable<IDrawStrategy> factory { get; }

        public FactoryDrawStrategy()
        {
            factory = new List<IDrawStrategy>(new IDrawStrategy[] {
                new DrawTriangleStrategy(),
                new DrawSquareStrategy() }
            );
        }
    }
}
