using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorFramework.Geometry
{
    public class Point : IDrawable
    {
        private Color _color;
        private Vector2 _center;

        public Point(Vector2 center)
        {
            _center = center;
        }

        public void Draw()
        {

        }
    }
}
