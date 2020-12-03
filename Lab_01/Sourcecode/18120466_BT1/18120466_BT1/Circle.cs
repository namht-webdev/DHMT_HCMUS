using System;
using SharpGL;

namespace _18120466_BT1
{
    class Circle: Shapes
    {
        public override void Draw(OpenGL gl)
        {
            double theta;
            int radius = Distance() / 2;
            gl.Color(border.R / 255.0, border.G / 255.0, border.B / 255.0);
            gl.PointSize(size);
            gl.Begin(OpenGL.GL_POINTS);
            for(int i = 0; i < 360; i++)
            {
                theta = i * Math.PI / 180;
                gl.Vertex(pStart.X + radius * Math.Cos(theta), gl.RenderContextProvider.Height - pStart.Y - radius*Math.Sin(theta));
            }
            gl.End();
        }
    }
}
