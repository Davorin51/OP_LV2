using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Kruznica : GrafObj
    {
        public Point krajKoordinata;
        public float polumjer;

        public Kruznica(GrafObj grafobj, Point k) : base(grafobj)
        {
            this.krajKoordinata = k;
            polumjer = (float)Math.Sqrt(Math.Pow(krajKoordinata.X - Koordinata.X, 2) + Math.Pow(krajKoordinata.Y - Koordinata.Y, 2));
        }
        public override void DrawGrafObj(Graphics g)
        {

            g.DrawEllipse(new Pen(GetColor()), Math.Min(Koordinata.X, krajKoordinata.X),
                            Math.Min(Koordinata.Y, krajKoordinata.Y), polumjer, polumjer);
        }
    }
}
