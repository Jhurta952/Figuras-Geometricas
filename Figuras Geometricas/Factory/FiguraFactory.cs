using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Figuras_Geometricas.Entidades;


namespace Figuras_Geometricas.Factory
{
    internal class FiguraFactory
    {
        public static Figura CrearFigura(string  tipo, Color color, int x, int y, int tamaño, int x2 = 0, int y2= 0)
        {
            switch (tipo)
            {
                case "Rectangulo":
                    return new Rectangulo(color, x, y, tamaño);
                case "Circulo":
                    return new Circulo(color, x, y, tamaño);
                case "Triangulo":
                    return new Triangulo(color, x, y, tamaño);
                case "Linea":
                    return new Linea(color, x, y, x2, y2);
                default:
                    return null;
            }
        }
    }
}
