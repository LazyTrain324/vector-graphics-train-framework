using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorFramework.Geometry
{
    class Polyline : IDrawable
    {
        private Color _color;
        Line[] lines;
        public Polyline()
        {
            //lines = new Line[100]; hmm...
        }
        public Polyline(params Line[] lines)
        {

        }
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
        public void Draw()
        {

        }
    }
}
