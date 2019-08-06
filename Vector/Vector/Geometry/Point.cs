using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorFramework.Geometry
{
    public class Point : Entity
    {
        private ColorEntity _color;
        private Vector2 _center;

        public Point(Vector2 center)
        {
            _center = center;
        }

        public override void Move(Vector2 distance) 
        {
            _center += distance;
        }

        public override void MoveTo(Vector2 newCenter)
        {
            _center = newCenter;
        }

        public override void Draw()
        {

        }
    }
}
