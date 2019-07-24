using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorFramework
{
    public struct Vector2
    {
        private double _x;
        private double _y;

        public double X { get { return _x; } }
        public double Y { get { return _y; } }

        public double Magnitude
        {
            //use fields
            get { return Math.Sqrt(X * X + Y * Y); }
        }

        public Vector2(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public Vector2 GetNormalized()
        {
            double x = _x / Magnitude;
            double y = _y / Magnitude;

            return new Vector2(x, y);
        }

        public void Normalize()
        {
            double magnitude = Magnitude;

            _x /= magnitude;
            _y /= magnitude;
        }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            //use constructor
            Vector2 vector = new Vector2();
            vector._x = a._x + a._x;
            vector._y = a._y + a._y;
            return vector;
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            //use constructor
            Vector2 vector = new Vector2();
            vector._x = a._x - a._x;
            vector._y = a._y - a._y;
            return vector;
        }
        public static bool operator ==(Vector2 a, Vector2 b)
        {
            if(a.X==b.X && a.Y == b.Y)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Vector2 a, Vector2 b)
        {
            if (a.X != b.X || a.Y != b.Y)
            {
                return true;
            }
            return false;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            Vector2 vector = (Vector2)obj;
            
        }
        //overload Equal(), ==, !=, +, -
    }
}
