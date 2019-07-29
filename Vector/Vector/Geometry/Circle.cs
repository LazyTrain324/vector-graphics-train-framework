using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorFramework.Geometry
{
    class Circle : IDrawable
    {
        private Vector2 _center;
        private double _radius;
        private Color _color;

        public Circle(Vector2 center, double radius)
        {
            _center = center;
            _radius = radius;
        }


        public void Draw()
        {

        }
    }
}
