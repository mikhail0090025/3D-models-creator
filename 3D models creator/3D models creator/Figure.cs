using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_models_creator
{
    class Figure
    {
        public List<Point> Points { get; private set; }
        public List<Polygon> Polygons { get; private set; }
        public Figure()
        {
            Points = new List<Point>();
            Polygons = new List<Polygon>();
        }
        public void AddPoint(Point p)
        {
            Points.Add(p);
        }
        public void AddPolygon(Point p1, Point p2, Point p3)
        {
            if (!Points.Contains(p1)) throw new Exception("Point is not in the list of points of this figure!");
            else if (!Points.Contains(p2)) throw new Exception("Point is not in the list of points of this figure!");
            else if (!Points.Contains(p3)) throw new Exception("Point is not in the list of points of this figure!");
            Polygons.Add(new Polygon(p1, p2, p3));
        }
        public void DeletePolygon(Polygon p) => Polygons.Remove(p);
        public void CreateCenterPointAndDividePolygon(Polygon p)
        {
            var p1 = p.Point1;
            var p2 = p.Point2;
            var p3 = p.Point3;
            var p4 = p.CenterPoint();
            Polygons.Remove(p);
            Polygons.Add(new Polygon(p1, p2, p4));
            Polygons.Add(new Polygon(p3, p2, p4));
            Polygons.Add(new Polygon(p1, p3, p4));
        }
    }
}
