using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_models_creator
{
    class Point
    {
        public double X;
        public double Y;
        public double Z;
        public Point(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }
        // Empty constructor for XML-(de)serializer
        private Point()
        {

        }
    }
}
