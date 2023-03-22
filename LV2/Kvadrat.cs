using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Kvadrat : Linija
    {
        public Kvadrat(GrafObj grafobj, Point k) : base(grafobj, k)
        {
            this.krajKoordinata = k;
        }

        public override void DrawGrafObj(Graphics g)
        {
            g.DrawRectangle(new Pen(GetColor()),
                            Math.Min(Koordinata.X,krajKoordinata.X),
                            Math.Min(Koordinata.Y,krajKoordinata.Y),
                            Math.Abs(krajKoordinata.X - Koordinata.X),
                            Math.Abs(krajKoordinata.Y - Koordinata.Y));
        }

    }
}
