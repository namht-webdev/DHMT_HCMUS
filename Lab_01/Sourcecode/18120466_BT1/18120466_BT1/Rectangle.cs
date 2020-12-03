using SharpGL;

namespace _18120466_BT1
{
    class Rectangle: Shapes
    {
        public override void Draw(OpenGL gl)
        {
            gl.Color(border.R / 255.0, border.G / 255.0, border.B / 255.0);
            gl.LineWidth(size);
            gl.Begin(OpenGL.GL_LINE_LOOP);
            gl.Vertex(pStart.X, gl.RenderContextProvider.Height - pStart.Y);
            gl.Vertex(pEnd.X, gl.RenderContextProvider.Height - pStart.Y);
            gl.Vertex(pEnd.X, gl.RenderContextProvider.Height - pEnd.Y);
            gl.Vertex(pStart.X, gl.RenderContextProvider.Height - pEnd.Y);
            gl.End();
        }
    }
}
