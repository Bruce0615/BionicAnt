using System;

namespace BionicAnt
{
    public enum Orientation
    {
        N = 12,
        W = 9,
        S = 6,
        E = 3
    }

    public struct Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public static class PostageStamp
    {
        public static Point UpperRight { get; set; }
        public static Point LowerLeft { get; set; }
    }

}
