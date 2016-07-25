namespace DrawSquareTriangle.Biz.Strategy
{
    interface IDrawStrategy
    {
        bool CanHandle(string type);

        bool Draw();
    }
}
