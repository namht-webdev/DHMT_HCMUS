namespace _18120466_BT1
{
    partial class fillColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fillColor));
            this.size1 = new System.Windows.Forms.Button();
            this.size4 = new System.Windows.Forms.Button();
            this.size3 = new System.Windows.Forms.Button();
            this.size2 = new System.Windows.Forms.Button();
            this.btn_Oke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // size1
            // 
            this.size1.Image = ((System.Drawing.Image)(resources.GetObject("size1.Image")));
            this.size1.Location = new System.Drawing.Point(30, 0);
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(58, 19);
            this.size1.TabIndex = 0;
            this.size1.UseVisualStyleBackColor = true;
            this.size1.Click += new System.EventHandler(this.size1_Click);
            // 
            // size4
            // 
            this.size4.Image = ((System.Drawing.Image)(resources.GetObject("size4.Image")));
            this.size4.Location = new System.Drawing.Point(30, 51);
            this.size4.Name = "size4";
            this.size4.Size = new System.Drawing.Size(58, 19);
            this.size4.TabIndex = 1;
            this.size4.UseVisualStyleBackColor = true;
            this.size4.Click += new System.EventHandler(this.size4_Click);
            // 
            // size3
            // 
            this.size3.Image = ((System.Drawing.Image)(resources.GetObject("size3.Image")));
            this.size3.Location = new System.Drawing.Point(30, 34);
            this.size3.Name = "size3";
            this.size3.Size = new System.Drawing.Size(58, 19);
            this.size3.TabIndex = 2;
            this.size3.UseVisualStyleBackColor = true;
            this.size3.Click += new System.EventHandler(this.size3_Click);
            // 
            // size2
            // 
            this.size2.Image = ((System.Drawing.Image)(resources.GetObject("size2.Image")));
            this.size2.Location = new System.Drawing.Point(30, 17);
            this.size2.Name = "size2";
            this.size2.Size = new System.Drawing.Size(58, 19);
            this.size2.TabIndex = 3;
            this.size2.UseVisualStyleBackColor = true;
            this.size2.Click += new System.EventHandler(this.size2_Click);
            // 
            // btn_Oke
            // 
            this.btn_Oke.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Oke.Location = new System.Drawing.Point(37, 76);
            this.btn_Oke.Name = "btn_Oke";
            this.btn_Oke.Size = new System.Drawing.Size(45, 22);
            this.btn_Oke.TabIndex = 4;
            this.btn_Oke.Text = "OKE";
            this.btn_Oke.UseVisualStyleBackColor = true;
            // 
            // fillColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(111, 104);
            this.Controls.Add(this.btn_Oke);
            this.Controls.Add(this.size2);
            this.Controls.Add(this.size3);
            this.Controls.Add(this.size4);
            this.Controls.Add(this.size1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(559, 79);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fillColor";
            this.Text = "fillColor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button size1;
        private System.Windows.Forms.Button size4;
        private System.Windows.Forms.Button size3;
        private System.Windows.Forms.Button size2;
        private System.Windows.Forms.Button btn_Oke;
    }
}