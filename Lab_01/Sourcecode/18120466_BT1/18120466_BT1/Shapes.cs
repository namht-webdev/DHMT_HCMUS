using System;
using SharpGL;
using System.Drawing;

namespace _18120466_BT1
{
    class Shapes
    {
        public static int Count = 0;
        protected Point pStart, pEnd;
        protected Color border;
        protected int size;

        public Shapes()
        {
            Count = 0;
        }

        public Point Pstart
        {
            get { return pStart; }
            set { pStart = value; }
        }

        public Point PEnd
        {
            get { return pEnd; }
            set { pEnd = value; }
        }

        public Color Border
        {
            get { return border; }
            set { border = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public virtual void Draw(OpenGL gl) { }
        public int Distance()
        {
            return (int)Math.Sqrt(Math.Pow(pStart.X - pEnd.X, 2) + Math.Pow(pStart.Y - pEnd.Y, 2));
        }

    }
}
