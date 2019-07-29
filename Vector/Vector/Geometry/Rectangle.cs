using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorFramework.Geometry
{
    class Rectangle : IDrawable
    {
        private Color _color;
        private Vector2 _pointOne;
        private Vector2 _pointTwo;
        private Vector2 _center;

        public Rectangle(Vector2 pointOne, Vector2 pointTwo)
        {
            _pointOne = pointOne;
            _pointTwo = pointTwo;
            _center = (pointOne + pointTwo) / 2.0;

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
