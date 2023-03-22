using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Linija : GrafObj
    {
        public Point krajKoordinata;

        public Linija(GrafObj grafobj, Point k) : base(grafobj)
        {
            this.krajKoordinata = k;
        }
        public override void DrawGrafObj(Graphics g)
        {
            g.DrawLine(new Pen(this.GetColor()), Koordinata, krajKoordinata);
        }
    }
}
