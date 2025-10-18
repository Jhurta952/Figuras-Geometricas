using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Figuras_Geometricas.Entidades
{
    internal class Triangulo : Figura
    {
        public Triangulo(Color color, int x, int y, int tamaño) : base(color, x, y, tamaño) { }

        public override void Dibujar(Graphics g)
        {
            Point p1 = new Point(X, Y + Tamaño);
            Point p2 = new Point(X, Y);
            Point p3 = new Point(X + Tamaño, Y + Tamaño);
            using (SolidBrush brush = new SolidBrush(Color))
            {
                g.FillPolygon(brush, new Point[] {p1, p2, p3});
            }
        }   

    }
}
