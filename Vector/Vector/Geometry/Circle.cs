using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorFramework.Geometry
{
    class Circle : IDrawable, IMovable
    {
        private Vector2 _center;
        private double _radius;
        private Color _color;

        public Circle(Vector2 center, double radius)
        {
            _center = center;
            _radius = radius;
        }
        
        public void Move(Vector2 distance)
        {
            _center += distance;
        }

        public void MoveTo(Vector2 newCenter)
        {
            _center = newCenter;
        }

        public void Draw()
        {

        }
    }
}
