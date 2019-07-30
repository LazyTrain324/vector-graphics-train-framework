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
        private Vector2 _center;

        public Line(Vector2 a, Vector2 b)
        {
            _a = a;
            _b = b;
            _center = (a + b) / 2.0;
        }

        public void Move(Vector2 distance)
        {
            _center += distance;
            _a += distance;
            _b += distance;
        }

        public void MoveTo(Vector2 newCenter)
        {
            Vector2 distance = newCenter - _center;

            _center = newCenter;
            _a += distance;
            _b += distance;
        }

        public void Draw()
        {

        }
    }
}
