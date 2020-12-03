using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;
using System.Windows.Forms;

namespace _18120466_BT1
{
    public partial class Form1 : Form
    {
        bool check, check2;// cờ vẽ các hình khác đa giác
        List<Shapes> ArrShapes; // mảng hình vẽ
        int shShape; // chọn hình vẽ
        Shapes shape; // hình vẽ được thêm vào
        Color border; // màu viền
        List<Point> points; // mảng các điểm tạm(temp) của đa giác
        List<Polygon> polygons; // mảng đa giác
        Polygon pol; // đa giác mới được thêm vào
        int size; // kích thước nét viền
        public Form1()
        {
            check = false;
            check2 = false; // cờ vẽ đa giác
            points = new List<Point>(); // cấp phát bộ nhớ cho mảng chứa các điểm của đa giác tạm
            polygons = new List<Polygon>(); // cấp phát bộ nhớ mảng đa giác
            ArrShapes = new List<Shapes>(); // cấp phát bộ nhớ cho mảng đa giác
            shShape = -1; // khởi tạo giá trị đầu chọn hình vẽ(-1: không chọn hình nào)
            border = Color.White; // màu viền khởi tạo là màu trắng
            size = 1; // độ rộng viền khởi tạo là 1
            
            InitializeComponent();
        }


        // Các hàm khởi tạo ban đầu thư viện OpenGL
        #region Initial OpenGL, Resized OpenGL
        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;
            gl.ClearColor(0, 0, 0, 0);// Vùng vẽ hình mặc định là màu đen
            gl.MatrixMode(OpenGL.GL_PROJECTION); // Khởi tạo lưới tọa độ
            gl.LoadIdentity();
        }

        private void openGLControl_Resized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Viewport(0, 0, openGLControl.Width, openGLControl.Height);
            gl.Ortho2D(0, openGLControl.Width, 0, openGLControl.Height);
        }
        #endregion

        // Hàm vẽ hình
        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs args)
        {
            OpenGL gl = openGLControl.OpenGL;
            // Xóa vùng nhớ đệm trước khi vẽ
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            // hiển thị đa giác tạm thời
            Draw(gl);
            int lenL = ArrShapes.Count;
            // vẽ các hình trong mảng hình vẽ
            for (int i = 0; i < lenL; i++)
            {
                ArrShapes[i].Draw(gl);
            }
            // vẽ các đa giác trong mảng các đa giác
            for (int i = 0; i < polygons.Count; i++)
            {
                polygons[i].Draw(gl);
            }

            gl.Flush();
        }
        // hàm lấy tọa độ các đỉnh khi click vẽ
        /*
            0: đường thẳng
            1: đường tròn
            2: hình chữ nhật
            3: ellipse
            4: tam giác đều
            5: ngũ giác đều
            6: lục giác đều
            7: đa giác bất kì
             */
        #region get Vertices coordinate
        private void openGLControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (shShape == 0)
                {
                    shape = new Line();
                    check = true;
                }

                else if (shShape == 1)
                {
                    shape = new Circle();
                    check = true;
                }

                else if (shShape == 2)
                {
                    shape = new Rectangle();
                    check = true;
                }

                else if (shShape == 3)
                {
                    shape = new Ellipse();
                    check = true;
                }

                else if (shShape == 4)
                {
                    shape = new Triangle();
                    check = true;
                }

                else if (shShape == 5)
                {
                    shape = new Pentagon();
                    check = true;
                }

                else if (shShape == 6)
                {
                    shape = new Hexagon();
                    check = true;
                }

                else if (shShape == 7)
                {
                    if (check2 == false) // khi cờ đa giác tắt thì khởi tạo đa giác mới và bật cờ để không sinh thêm đa giác mới khác
                    {
                        pol = new Polygon();
                        pol.Border = border; // lấy boder từ border size
                        pol.Size = size; // lấy size từ dialog size
                        check2 = true; // bật cờ đa giác
                    }
                    pol.points.Add(e.Location); // thêm các đỉnh vào mảng các đỉnh của đa giác mới

                    points.Add(e.Location);// thêm các đỉnh vào mảng tạm để vẽ đa giác hiện hành
                }

                #endregion
                // Kiểm tra xem có tạo hình mới không?
                // Nếu có thì thêm các giá trị và thuộc tính vào cho hình vẽ(khác đa giác)
                if (check)
                {
                    shape.Size = size;
                    shape.Border = border;
                    shape.Pstart = e.Location;
                    shape.PEnd = e.Location;
                    ArrShapes.Add(shape);
                    check = false;
                }

            }
        }


        // hàm xác định đường vẽ khi di chuyển chuột sau khi click
        private void openGLControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (shShape != -1 && shShape != 7)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    shape.PEnd = e.Location;
                }
            }

        }
        // hàm xác định đỉnh cuối của nét vẽ
        private void openGLControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (shShape != -1 & shShape != 7)
            {
                shape.PEnd = e.Location;
            }

            
            if (shShape != 7 && points.Count > 0)
            {
                points.Clear();
            }

        }


        // Chọn hình vẽ tương ứng thông qua click button ảnh tương ứng
        #region click choose shape
        private void line_Click(object sender, EventArgs e)
        {
            shShape = 0;
        }

        private void circle_Click(object sender, EventArgs e)
        {
            shShape = 1;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            shShape = 2;
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            shShape = 3;
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            shShape = 4;
        }

        private void pentagon_Click(object sender, EventArgs e)
        {
            shShape = 5;
        }

        private void hexagon_Click(object sender, EventArgs e)
        {
            shShape = 6;
        }

        private void polygo_Click(object sender, EventArgs e)
        {
            shShape = 7;
        }

        #endregion

        // hàm vẽ đa giác tạm khi chưa nhấn chuột phải
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

        private void openGLControl_MouseClick(object sender, MouseEventArgs e)
        {
            // kiểm tra khi đang vẽ đa giác thì nhấn chuột phải
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if(shShape == 7 && points.Count > 0)
                {
                    polygons.Add(pol); // Thêm đa giác mới vào lớp đa giác
                    points.Clear(); // xóa các nét vẽ tạm thời
                    check2 = false; // trả lại giá trị cũ cho cờ vẽ đa giác
                }
            }
        }

        private void SizeShapes_Click(object sender, EventArgs e)
        {
            fillColor fillDialog = new fillColor();
            fillDialog.Location = new Point(559, 79);
            if(fillDialog.ShowDialog() == DialogResult.OK)
            {
                size = fillDialog.size;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorBorder.ShowDialog() == DialogResult.OK)
            {
                border = colorBorder.Color;
            }
        }


    }
    
}

