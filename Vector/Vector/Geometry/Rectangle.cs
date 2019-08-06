using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorFramework.Geometry
{
    class Rectangle : Entity
    {
        private ColorEntity _color;
        //* better rename like lowerLeftPoint and upperRightPoint
        private Vector2 _pointOne;
        private Vector2 _pointTwo;
        private Vector2 _center;

        public Rectangle(Vector2 pointOne, Vector2 pointTwo)
        {
            _pointOne = pointOne;
            _pointTwo = pointTwo;
            _center = (pointOne + pointTwo) / 2.0;
            //* remove empty line (resolve)
        }

        public override void Move(Vector2 distance)
        {
            _center += distance;
            _pointOne += distance;
            _pointTwo += distance;
        }

        public override void MoveTo(Vector2 newCenter)
        {
            Vector2 distance = newCenter - _center;

            _center = newCenter;
            _pointOne += distance;
            _pointTwo += distance;
        }

        public override void Draw()
        {

        }
    }
}
