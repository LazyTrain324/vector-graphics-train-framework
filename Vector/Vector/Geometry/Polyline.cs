using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorFramework.Geometry
{
    //***** about implementation this class we need to talk. don't write anything yet
    class Polyline : IDrawable
    {
        private Color _color;
        private Vector2 _center;
        //* forgot modificator private
        Line[] lines;
        //* add empty line
        public Polyline()
        {
            //lines = new Line[100]; hmm...
        }
        //* add empty line
        public Polyline(params Line[] lines)
        {

        }
        //* add empty line
        public Line this[int index]
        {
            get
            {
                return lines[index];
            }
            set
            {
                //need to make verification on continuity of polyline ps: i`m suck in english stuff
                lines[index] = value;
            }
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
