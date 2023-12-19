using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_models_creator
{
    public class Camera
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
        public List<Point2D> GetImageOfPoints(List<Figure> figures, int ResolutionX, int ResolutionY)
        {
            var res = new List<Point2D>();
            foreach (var fig in figures)
            {
                foreach (var point in fig.Points)
                {
                    double deltaX = point.X - Point.X;
                    double deltaY = point.Y - Point.Y;
                    double deltaZ = point.Z - Point.Z;
                    double TanX = deltaX / deltaZ;
                    double TanY = deltaY / deltaZ;
                    double RadX = Math.Atan(TanX);
                    double RadY = Math.Atan(TanY);
                    bool InFieldOfView = (RadX >= 0 && RadX <= FieldOfViewX) && (RadY >= 0 && RadY <= FieldOfViewY);
                    res.Add(new Point2D(ResolutionX * (RadX / FieldOfViewX), ResolutionY * (RadY / FieldOfViewY)));
                }
            }
            return res;
        }
    }
    public struct Point2D
    {
        public double X;
        public double Y;
        public Point2D(double x, double y)
        {
            X = x; Y = y;
        }
    }
}
