namespace _18120466_BT1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openGLControl = new SharpGL.OpenGLControl();
            this.Shapes = new System.Windows.Forms.ListBox();
            this.Tools = new System.Windows.Forms.ListBox();
            this.line = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.ellipse = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.pentagon = new System.Windows.Forms.Button();
            this.hexagon = new System.Windows.Forms.Button();
            this.polygo = new System.Windows.Forms.Button();
            this.colorBorder = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SizeShapes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.DrawFPS = false;
            this.openGLControl.Location = new System.Drawing.Point(0, 95);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(786, 464);
            this.openGLControl.TabIndex = 2;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseClick);
            this.openGLControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseDown);
            this.openGLControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseMove);
            this.openGLControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseUp);
            // 
            // Shapes
            // 
            this.Shapes.Enabled = false;
            this.Shapes.FormattingEnabled = true;
            this.Shapes.Location = new System.Drawing.Point(0, 0);
            this.Shapes.Name = "Shapes";
            this.Shapes.Size = new System.Drawing.Size(393, 95);
            this.Shapes.TabIndex = 4;
            // 
            // Tools
            // 
            this.Tools.Enabled = false;
            this.Tools.FormattingEnabled = true;
            this.Tools.Location = new System.Drawing.Point(393, 0);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(393, 95);
            this.Tools.TabIndex = 5;
            // 
            // line
            // 
            this.line.Image = ((System.Drawing.Image)(resources.GetObject("line.Image")));
            this.line.Location = new System.Drawing.Point(14, 29);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(40, 40);
            this.line.TabIndex = 6;
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // circle
            // 
            this.circle.Image = ((System.Drawing.Image)(resources.GetObject("circle.Image")));
            this.circle.Location = new System.Drawing.Point(60, 29);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(40, 40);
            this.circle.TabIndex = 7;
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // rectangle
            // 
            this.rectangle.Image = ((System.Drawing.Image)(resources.GetObject("rectangle.Image")));
            this.rectangle.Location = new System.Drawing.Point(106, 29);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(40, 40);
            this.rectangle.TabIndex = 8;
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // ellipse
            // 
            this.ellipse.Image = ((System.Drawing.Image)(resources.GetObject("ellipse.Image")));
            this.ellipse.Location = new System.Drawing.Point(152, 29);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(40, 40);
            this.ellipse.TabIndex = 9;
            this.ellipse.UseVisualStyleBackColor = true;
            this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // triangle
            // 
            this.triangle.Image = ((System.Drawing.Image)(resources.GetObject("triangle.Image")));
            this.triangle.Location = new System.Drawing.Point(198, 29);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(40, 40);
            this.triangle.TabIndex = 10;
            this.triangle.UseVisualStyleBackColor = true;
            this.triangle.Click += new System.EventHandler(this.triangle_Click);
            // 
            // pentagon
            // 
            this.pentagon.Image = ((System.Drawing.Image)(resources.GetObject("pentagon.Image")));
            this.pentagon.Location = new System.Drawing.Point(244, 29);
            this.pentagon.Name = "pentagon";
            this.pentagon.Size = new System.Drawing.Size(40, 40);
            this.pentagon.TabIndex = 11;
            this.pentagon.UseVisualStyleBackColor = true;
            this.pentagon.Click += new System.EventHandler(this.pentagon_Click);
            // 
            // hexagon
            // 
            this.hexagon.Image = ((System.Drawing.Image)(resources.GetObject("hexagon.Image")));
            this.hexagon.Location = new System.Drawing.Point(290, 29);
            this.hexagon.Name = "hexagon";
            this.hexagon.Size = new System.Drawing.Size(40, 40);
            this.hexagon.TabIndex = 12;
            this.hexagon.UseVisualStyleBackColor = true;
            this.hexagon.Click += new System.EventHandler(this.hexagon_Click);
            // 
            // polygo
            // 
            this.polygo.Image = ((System.Drawing.Image)(resources.GetObject("polygo.Image")));
            this.polygo.Location = new System.Drawing.Point(336, 29);
            this.polygo.Name = "polygo";
            this.polygo.Size = new System.Drawing.Size(40, 40);
            this.polygo.TabIndex = 13;
            this.polygo.UseVisualStyleBackColor = true;
            this.polygo.Click += new System.EventHandler(this.polygo_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(476, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SizeShapes
            // 
            this.SizeShapes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SizeShapes.Image = ((System.Drawing.Image)(resources.GetObject("SizeShapes.Image")));
            this.SizeShapes.Location = new System.Drawing.Point(645, 19);
            this.SizeShapes.Name = "SizeShapes";
            this.SizeShapes.Size = new System.Drawing.Size(60, 60);
            this.SizeShapes.TabIndex = 15;
            this.SizeShapes.UseVisualStyleBackColor = true;
            this.SizeShapes.Click += new System.EventHandler(this.SizeShapes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "SHAPES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "TOOLS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SizeShapes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.polygo);
            this.Controls.Add(this.hexagon);
            this.Controls.Add(this.pentagon);
            this.Controls.Add(this.triangle);
            this.Controls.Add(this.ellipse);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.line);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.Shapes);
            this.Controls.Add(this.openGLControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.ListBox Shapes;
        private System.Windows.Forms.ListBox Tools;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button ellipse;
        private System.Windows.Forms.Button triangle;
        private System.Windows.Forms.Button pentagon;
        private System.Windows.Forms.Button hexagon;
        private System.Windows.Forms.Button polygo;
        private System.Windows.Forms.ColorDialog colorBorder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SizeShapes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

