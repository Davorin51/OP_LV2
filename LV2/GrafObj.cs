using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class GrafObj
    {
        private Color boja;
        private Point koordinata;

        public GrafObj(Color b, Point k)
        {
            this.boja = b;
            this.koordinata = k;
        }

        public GrafObj(GrafObj grafobj)
        {
            this.boja = grafobj.boja;
            this.koordinata = grafobj.koordinata;
        }

        public void SetColor(Color b)
        {
            this.boja = b;
        }

        public Color GetColor() {
            return this.boja;
        }

        public virtual void DrawGrafObj(Graphics g) { }

        public Point Koordinata
        {
            get { return koordinata; }
            set { koordinata = value; }
        }
      
    }
}
