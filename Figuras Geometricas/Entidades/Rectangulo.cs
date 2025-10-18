using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figuras_Geometricas.Entidades
{
    internal class Rectangulo : Figura
    {
        public Rectangulo(Color color, int x, int y, int tamaño) : base(color, x, y, tamaño) { }

        public override void Dibujar(Graphics g)
        {
            using (Brush b = new SolidBrush(this.Color))
            {
                g.FillRectangle(b, this.X, this.Y, this.Tamaño, this.Tamaño);
            }

            using (Pen p = new Pen(Color.Black, 2))
            {
                g.DrawRectangle(p, this.X, this.Y, this.Tamaño, this.Tamaño);
            }
        }
    }
}

