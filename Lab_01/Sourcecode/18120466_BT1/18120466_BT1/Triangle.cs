using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpGL;

namespace _18120466_BT1
{
    class Triangle:Shapes
    {
        public override void Draw(OpenGL gl)
        {
            double theta;
            int dist = Distance()/2;
            gl.Color(border.R / 255.0, border.G / 255.0, border.B / 255.0);
            gl.LineWidth(size);
            gl.Begin(OpenGL.GL_LINE_LOOP);
            for (int i = 0; i < 3; i++)
            {
                if (120 * i <= 360)
                {
                    theta = Math.PI * i * 120 / 180;
                    // Xác định và vẽ tọa độ các đỉnh của ngũ giác đều
                    gl.Vertex(dist * Math.Cos(theta) + pStart.X, gl.RenderContextProvider.Height - dist * Math.Sin(theta) - pStart.Y);
                }
            }

            gl.End();
        }
    }
}
