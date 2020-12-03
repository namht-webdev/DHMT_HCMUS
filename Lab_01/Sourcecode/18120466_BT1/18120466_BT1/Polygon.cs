using System.Collections.Generic;
using System.Drawing;
using SharpGL;

namespace _18120466_BT1
{
    class Polygon : Shapes
    {
        public List<Point> points;
        public Polygon()
        {
            points = new List<Point>();
        }
        

        public void Draw(OpenGL gl)
        {
            gl.Color(border.R / 255.0, border.G / 255.0, border.B / 255.0);
            gl.LineWidth(size);
            gl.Begin(OpenGL.GL_LINE_LOOP);
            for (int i = 0; i < points.Count; i++)
            {
                gl.Vertex(points[i].X, gl.RenderContextProvider.Height - points[i].Y);
            }
            gl.End();
        }
    }
}
