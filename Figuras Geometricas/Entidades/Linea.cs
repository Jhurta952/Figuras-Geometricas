using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Figuras_Geometricas.Entidades
{
    public class Linea : Figura
    {
        public int X2 { get; set; }
        public int Y2 { get; set; }

        public Linea(Color color, int x, int y, int x2, int y2)
            : base(color, x, y, 0) 
        {
            X2 = x2;
            Y2 = y2;
        }

        public override void Dibujar(Graphics g)
        {
            using (Pen pen = new Pen(Color, 2))
            {
                g.DrawLine(pen, X, Y, X2, Y2);
            }
        }
    }
}
