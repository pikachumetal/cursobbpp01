namespace DrawSquareTriangle.Biz
{
    class Drawer
    {
        public bool Draw(IDrawableObject obj)
        {
            return obj.Draw();
        }
    }
}
