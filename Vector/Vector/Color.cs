using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorFramework
{
    public struct ColorEntity 
    {
        private byte _r;
        private byte _g;
        private byte _b;

        public ColorEntity(byte r, byte g, byte b)
        {
            _r = r;
            _g = g;
            _b = b;
        }

        #region StatiColor
        private static readonly ColorEntity red = new ColorEntity(255, 0, 0);
        private static readonly ColorEntity blue = new ColorEntity(0, 0, 255);
        private static readonly ColorEntity green = new ColorEntity(0, 255, 0);
        private static readonly ColorEntity black = new ColorEntity(0, 0, 0);
        private static readonly ColorEntity white = new ColorEntity(255, 255, 255);
        private static readonly ColorEntity yellow = new ColorEntity(255, 255, 0);
        private static readonly ColorEntity aqua = new ColorEntity(0, 255, 255);
        private static readonly ColorEntity fuchsia = new ColorEntity(255, 0, 255);
        private static readonly ColorEntity silver = new ColorEntity(192, 192, 192);

        public static ColorEntity Red => red;
        public static ColorEntity Blue => blue;
        public static ColorEntity Green => green;
        public static ColorEntity Black => black;
        public static ColorEntity White => white;
        public static ColorEntity Yellow => yellow;
        public static ColorEntity Aqua => aqua;
        public static ColorEntity Fuchsia => fuchsia;
        public static ColorEntity Silver => silver;
        #endregion StatiColor

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            ColorEntity color = (ColorEntity)obj;

            return Equals(color);
        }

        public bool Equals(ColorEntity color)
        {
            if(_r == color._r && _g == color._g && _b == color._b) return true;

            return false;
        }

        public static bool operator ==(ColorEntity color1, ColorEntity color2)
        {
            if (color1.Equals(color2))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(ColorEntity color1, ColorEntity color2)
        {
            if (color1.Equals(color2))
            {
                return false;
            }
            return true;
        }
    }
}
