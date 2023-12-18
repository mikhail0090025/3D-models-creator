using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D_models_creator
{
    public partial class Form1 : Form
    {
        public bool RightMouseButtonIsDown;
        public Form1()
        {
            InitializeComponent();
        }
        #region File Tool strip menu
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a primitive program for 3D modelling.");
        }

        private void panel_3d_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) RightMouseButtonIsDown = false;
        }

        private void panel_3d_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) RightMouseButtonIsDown = true;
        }

        private void panel_3d_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
