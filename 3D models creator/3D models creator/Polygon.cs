using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_models_creator
{
    class Polygon
    {
        public Point Point1;
        public Point Point2;
        public Point Point3;
        public Polygon(Point p1, Point p2, Point p3)
        {
            Point1 = p1;
            Point2 = p2;
            Point3 = p3;
        }
        // Empty constructor for XML-(de)serializer
        private Polygon()
        {

        }
        public Point CenterPoint()
        {
            return new Point((Point1.X + Point2.X + Point3.X) / 3f, (Point1.Y + Point2.Y + Point3.Y) / 3f, (Point1.Z + Point2.Z + Point3.Z) / 3f);
        }
    }
}
