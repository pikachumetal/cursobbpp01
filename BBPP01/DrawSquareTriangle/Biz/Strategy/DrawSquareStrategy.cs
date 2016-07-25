using DrawSquareTriangle.Biz.Objects;

namespace DrawSquareTriangle.Biz.Strategy
{
    class DrawSquareStrategy : IDrawStrategy
    {
        bool IDrawStrategy.CanHandle(string type)
        {
            return type == "s";
        }

        bool IDrawStrategy.Draw()
        {
            var drawer = new Drawer.Drawer();
            var figure = new Square();
           return drawer.Draw(figure);
        }
    }
}
