using DrawSquareTriangle.Biz.Objects;

namespace DrawSquareTriangle.Biz.Drawer
{
    class Drawer
    {
        public bool Draw(IDrawableObject obj)
        {
            return obj.Draw();
        }
    }
}
