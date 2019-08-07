using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorFramework.Geometry
{
    //***** about implementation this class we need to talk. don't write anything yet
    class Polyline : Entity
    {
        private ColorEntity _color;
        private Vector2 _center;
        private List<Vector2> points;

        public Polyline()
        {
            points = new List<Vector2>();
        }

        public Polyline(Vector2[] points)
        {

        }

        public Vector2 this[int index]
        {
            get
            {
                return points[index];
            }
            set
            {
                //need to make verification on continuity of polyline ps: i`m suck in english stuff
                points[index] = value;
            }
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
