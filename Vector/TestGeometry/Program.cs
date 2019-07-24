using VectorFramework;
using VectorFramework.Geometry;

namespace TestGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2 center = new Vector2(1, 1);
            Point point = new Point(center);

            Vector2 move = new Vector2(2, 0);
            Vector2 position = center + move;
            //Vector2 pos = new Vector2(center.X + move.X, center.Y + move.Y);
        }
    }
}
