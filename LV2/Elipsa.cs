using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3 
    {
    class Elipsa : Kruznica
    {
        public float visina;

        public Elipsa(GrafObj grafobj, Point k) : base(grafobj, k)
        {
            this.krajKoordinata = k;
            polumjer = (float)Math.Sqrt(Math.Pow(krajKoordinata.X - Koordinata.X, 2) + Math.Pow(krajKoordinata.Y - Koordinata.Y, 2));
            visina = Math.Abs(Koordinata.Y - krajKoordinata.Y);
        }

        public override void DrawGrafObj(Graphics g)
        {
            g.DrawEllipse(new Pen(GetColor()), Math.Min(Koordinata.X, krajKoordinata.X),
                            Math.Min(Koordinata.Y, krajKoordinata.Y), polumjer, visina);
        }

    }
}
