using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_models_creator
{
    class Camera
    {
        public Point Point;
        public double RotationX;
        public double RotationY;
        public double RotationZ;
        public const double FieldOfViewX = Math.PI / 3f;
        public const double FieldOfViewY = Math.PI / 6f;
        public Camera(Point p, double rotx, double roty, double rotz)
        {
            Point = p;
            RotationX = rotx;
            RotationY = roty;
            RotationZ = rotz;
        }
        public List<List<bool>> GetImageOfPoints()
        {

        }
    }
}
