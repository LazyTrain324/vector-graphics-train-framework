using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorFramework
{
    public struct Color 
    {
        private byte _r;
        private byte _g;
        private byte _b;

        public Color(byte r, byte g, byte b)
        {
            _r = r;
            _g = g;
            _b = b;
        }

        #region StatiColor
        public static Color Red
        {
            get { return new Color(255, 0, 0); }
        }
        public static Color Blue
        {
            get { return new Color(0, 0, 255); }
        }
        public static Color Green
        {
            get { return new Color(0, 255, 0); }
        }
        public static Color Black
        {
            get { return new Color(0, 0, 0); }
        }
        public static Color White
        {
            get { return new Color(255, 255, 255); }
        }
        public static Color Yellow
        {
            get { return new Color(255, 255, 0); }
        }
        public static Color Aqua
        {
            get { return new Color(0, 255, 255); }
        }
        public static Color Fuchsia
        {
            get { return new Color(255, 0, 255); }
        }
        public static Color Silver
        {
            get { return new Color(192, 192, 192); }
        }
        #endregion StatiColor
    }
}
