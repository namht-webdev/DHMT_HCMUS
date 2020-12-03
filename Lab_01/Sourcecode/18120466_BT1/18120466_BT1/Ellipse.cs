using System;
using SharpGL;

namespace _18120466_BT1
{
    class Ellipse : Shapes
    {
        public override void Draw(OpenGL gl)
        {
            double theta;
            int rX = Math.Abs(pStart.X - pEnd.X) / 2;
            int rY = Math.Abs(pStart.Y - pEnd.Y) / 2;
            gl.Color(border.R / 255.0, border.G / 255.0, border.B / 255.0);
            gl.PointSize(size);
            gl.Begin(OpenGL.GL_POINTS);
            for (int i = 0; i < 360; i++)
            {
                theta = i * Math.PI / 180;
                gl.Vertex(pStart.X + rX * Math.Cos(theta), gl.RenderContextProvider.Height - pStart.Y - rY * Math.Sin(theta));
            }
            gl.End();
        }
    }
}
