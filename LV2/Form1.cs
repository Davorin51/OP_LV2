using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Point ptStart, ptEnd, ptPol;
        Boolean IsMouseDown;
        Color boja;
        GrafObj grafobj, grafPol;
        int counter = 0;
       
        Poligon poligon;
   
        Graphics graphicsHelper;
        GrafObj gObjekt;
        List<GrafObj> listhObjekt = new List<GrafObj>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphicsHelper = this.CreateGraphics();
            IsMouseDown = false;
            boja = Color.Indigo;

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
            ptPol = e.Location;
            boja = Color.Black;
            grafPol = new GrafObj(boja, ptPol);
            
            
            if (rbPoligon.Checked && counter == 0)
            {
                poligon = new Poligon(grafPol);
                poligon.AddPoint(grafPol, ptPol);
                counter++;
              
            }
            else if (rbPoligon.Checked && counter < 2)
            {
                poligon.AddPoint(grafPol, ptPol);
               
                counter++;
            }
            else if (rbPoligon.Checked && counter <= 3) {
                poligon.AddPoint(grafPol, ptPol);
                poligon.DrawGrafObj(graphicsHelper);
                listhObjekt.Add(poligon);

                Point[] dots = poligon.TurnToArray();



                richTextBox1.Text = String.Format("X = {0}, Y= {1}", dots[0].X.ToString(), dots[0].Y.ToString());
                richTextBox2.Text = String.Format("X = {0}, Y= {1}", dots[1].X.ToString(), dots[1].Y.ToString());
                richTextBox3.Text = String.Format("X = {0}, Y= {1}", dots[2].X.ToString(), dots[2].Y.ToString());

                counter = 0;
            }

            
          
            //textBox1.Text = poligon.points.ToString();
            textBox1.Text = counter.ToString();
           
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
            listhObjekt.Add(gObjekt);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            ptStart = e.Location;

            if (rbCrna.Checked)
            {
                boja = Color.Black;
            }
            else if (rbCrvena.Checked)
            {
                boja = Color.Red;
            }
            else if (rbPlava.Checked)
            {
                boja = Color.DeepSkyBlue;
            }
            /*
            ptPol = e.Location;
            boja = Color.Black;
            grafPol = new GrafObj(boja, ptPol);
         
            if (rbPoligon.Checked)
            {
                poligon = new Poligon(grafPol);
              
                ct++;
            }
            else if (rbPoligon.Checked && counter < 2)
            {
           
                ct++;
                poligon.AddPoint(grafPol);
            }
            else if (rbPoligon.Checked && counter <= 3)
            {
                poligon.AddPoint(grafPol);
                Point[] dots = poligon.TurnToArray();
                richTextBox3.Text = String.Format("X = {0}, Y= {1}", dots[2].X.ToString(), dots[2].Y.ToString());
                richTextBox2.Text = String.Format("X = {0}, Y= {1}", dots[1].X.ToString(), dots[1].Y.ToString());
                richTextBox1.Text = String.Format("X = {0}, Y= {1}", dots[0].X.ToString(), dots[0].Y.ToString());
            }
           
            */


           
            grafobj = new GrafObj(boja, ptStart);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                ptEnd = e.Location;
                this.Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            
            foreach(GrafObj item in listhObjekt)
            {
                item.DrawGrafObj(graphicsHelper);
            }
            if (IsMouseDown)
            {
                if (rbLinija.Checked)
                {
                    gObjekt = new Linija(grafobj, ptEnd);
                    gObjekt.DrawGrafObj(graphicsHelper);
                }
                else if (rbKvadrat.Checked)
                {
                    gObjekt = new Kvadrat(grafobj, ptEnd);
                    gObjekt.DrawGrafObj(graphicsHelper);
                }
                else if (rbKruznica.Checked)
                {
                    gObjekt = new Kruznica(grafobj, ptEnd);
                    gObjekt.DrawGrafObj(graphicsHelper);
                }

                else if (rbElipsa.Checked)
                {
                    gObjekt = new Elipsa(grafobj, ptEnd);
                    gObjekt.DrawGrafObj(graphicsHelper);

                }
                else if (rbPoligon.Checked)
                {/*
                    Pen p = new Pen(Color.Black, 5);
                    Point[] x = { new Point(100, 100), new Point(200, 100), new Point(150, 50)};
                    graphicsHelper.DrawPolygon(p, x);
                    graphicsHelper.Dispose();
                   */     
                        }

               
                
               
            }
        }
    }
}
