using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InternalDSL
{
    public static class SetValue
    {
        public static int frequencyValue(int value)
        {
            return value;
        }
        public static double albedoValue(double value)
        {
            return value;
        }
        public static int powerValue(int value)
        {
            return value;
        }
        public static int abatementValue(int value)
        {
            return value;
        }
        public static Point point(int x, int y)
        {
            return new Point(x, y);
        }
    }
}
