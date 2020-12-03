using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18120466_BT1
{
    public partial class fillColor : Form
    {
        public int size = 1;
        public fillColor()
        {
            InitializeComponent();
        }

        private void size1_Click(object sender, EventArgs e)
        {
            size = 1;
        }

        private void size2_Click(object sender, EventArgs e)
        {
            size = 2;
        }

        private void size3_Click(object sender, EventArgs e)
        {
            size = 3;
        }

        private void size4_Click(object sender, EventArgs e)
        {
            size = 4;
        }


    }
}
