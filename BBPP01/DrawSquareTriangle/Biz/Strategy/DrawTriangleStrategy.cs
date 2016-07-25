using DrawSquareTriangle.Biz.Objects;

namespace DrawSquareTriangle.Biz.Strategy
{
    class DrawTriangleStrategy : IDrawStrategy
    {
        bool IDrawStrategy.CanHandle(string type)
        {
            return type == "t";
        }

        bool IDrawStrategy.Draw()
        {
            var drawer = new Drawer.Drawer();
            var figure = new Triangle();
            return drawer.Draw(figure);
        }
    }
}
