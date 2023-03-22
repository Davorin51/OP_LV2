using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Poligon : GrafObj
    {

        public List<Point> points = new List<Point>();

        public void AddPoint(GrafObj grafobj, Point pol)
        {
            points.Add(pol);
        }

        public Poligon(GrafObj grafobj) : base(grafobj)
        {
            //points.Add(Koordinata);
        }
        
        public Point[] TurnToArray()
        {
            Point[] tocke = points.ToArray();
            return tocke;
        }

        public override void DrawGrafObj(Graphics g)
        {
            Point[] tocke = points.ToArray();
            Point[] x = { new Point(100, 100), new Point(200, 100), new Point(150, 50) };
            g.DrawPolygon(new Pen(this.GetColor(), 5), tocke);
        }
    }
}
