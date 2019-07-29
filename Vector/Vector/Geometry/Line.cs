using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorFramework.Geometry
{
    class Line : IDrawable
    {
        private Color _color;
        private Vector2 _a;
        private Vector2 _b;

        public Line(Vector2 a, Vector2 b)
        {
            _a = a;
            _b = b;
        }

        public void Draw()
        {

        }
    }
}
