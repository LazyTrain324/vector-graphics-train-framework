using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorFramework.Geometry
{
    class Line : Entity
    {
        private ColorEntity _color;
        private Vector2 _startPoint;
        private Vector2 _endPoint;
        private Vector2 _center;

        public Line(Vector2 startPoint, Vector2 endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
            _center = (startPoint + endPoint) / 2.0;
        }

        public override void Move(Vector2 distance)
        {
            _center += distance;
            _startPoint += distance;
            _endPoint += distance;
        }

        public override void MoveTo(Vector2 newCenter)
        {
            Vector2 distance = newCenter - _center;

            _center = newCenter;
            _startPoint += distance;
            _endPoint += distance;
        }

        public override void Draw()
        {

        }
    }
}
