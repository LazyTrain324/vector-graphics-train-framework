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
            double magnitude = Magnitude;
            double x = _x / magnitude;
            double y = _y / magnitude;

            return new Vector2(x, y);
        }

        public void Normalize()
        {
            double magnitude = Magnitude;

            _x /= magnitude;
            _y /= magnitude;
        }
        #region OperatorOverload
        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a._x + a._x, a._y + a._y);
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a._x - a._x, a._y - a._y);
        }
        public static Vector2 operator /(Vector2 a, double b)
        {
            return new Vector2(a._x / b, a._y / b);
        }
        public static bool operator ==(Vector2 a, Vector2 b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Vector2 a, Vector2 b)
        {
            if (a.Equals(b))
            {
                return false;
            }
            return true;
        }
        #endregion OperatorOverload
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            Vector2 vector = (Vector2)obj;

            if (_x == vector._x && _y == vector._y) return true;

            return false;
        }
        //overload Equal(), ==, !=, +, -
    }
}
