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
        public ProjectClass Project;
        public Camera Camera;
        const float point_diameter = 5f;
        const float point_radius = point_diameter / 2f;
        public Form1()
        {
            InitializeComponent();
            // New project
            Project = new ProjectClass("New project");
            // First figure
            Point p1 = new Point(-1, 0, -1);
            Point p2 = new Point(1, 0, -1);
            Point p3 = new Point(1, 0, 1);
            Point p4 = new Point(-1, 0, 1);
            var fig = new Figure();
            fig.AddPoint(p1, p2, p3, p4);
            fig.AddPolygon(p1, p2, p3);
            fig.AddPolygon(p1, p4, p3);
            Project.Figures.Add(fig);
            // Camera
            Camera = new Camera(new Point(0, -2.5f, -10), 0, 0, 0);
            panel_3d.Invalidate();
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
            if (e.Button == MouseButtons.Right)
            {
                RightMouseButtonIsDown = false;
                MessageBox.Show($"Test {Camera.RotationX}");
            }
        }

        private void panel_3d_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) RightMouseButtonIsDown = true;
        }

        private void panel_3d_MouseMove(object sender, MouseEventArgs e)
        {
            if (RightMouseButtonIsDown)
            {
                Camera.RotationX += e.X;
            }
        }
        private void panel_3d_Paint(object sender, PaintEventArgs e)
        {
            var Points = Camera.GetImageOfPoints(Project.Figures, panel_3d.Width, panel_3d.Height);
            foreach (var p in Points)
            {
                e.Graphics.DrawEllipse(new Pen(Brushes.Black), (float)p.X - point_radius, (float)p.Y - point_radius, point_diameter, point_diameter);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.R:
                    Camera.Point.Y++;
                    break;
                case Keys.F:
                    Camera.Point.Y--;
                    break;
                case Keys.D:
                    Camera.Point.X++;
                    break;
                case Keys.A:
                    Camera.Point.X--;
                    break;
                case Keys.W:
                    Camera.Point.Z++;
                    break;
                case Keys.S:
                    Camera.Point.Z--;
                    break;
                default:
                    return;
            }
            panel_3d.Invalidate();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
