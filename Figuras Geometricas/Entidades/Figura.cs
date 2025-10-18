using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Figuras_Geometricas.Entidades
{
    public abstract class Figura
    {
        public Color Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Tamaño { get; set; }

        protected Figura(Color color, int x, int y, int tamaño)
        {
            Color = color;
            X = x;
            Y = y;
            Tamaño = tamaño;
        }

        public abstract void Dibujar(Graphics g);
    }
}
