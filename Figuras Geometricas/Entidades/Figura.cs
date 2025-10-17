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
        public int x { get; set; }
        public int y { get; set; }
        public int tamano { get; set; }

        protected Figura(Color color, int x, int y, int tamano)
        {
            Color = color;
            this.x = x;
            this.y = y;
            this.tamano = tamano;
        }

        public abstract void Dibujar(Graphics g);
    }
}
