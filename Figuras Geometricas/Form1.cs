using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Figuras_Geometricas.Entidades;
using Figuras_Geometricas.Factory;

namespace Figuras_Geometricas
{
    public partial class Form1 : Form
    {
        private List<Figura> figuras = new List<Figura>();

        public Form1()
        {
            InitializeComponent();

            nudX2nudY2.Minimum = 0;
            nudTamaño.Minimum = 0;
            nudX2nudY2.Minimum = 0;

            nudX2nudY2.Enabled = false;

            txtContador.Text = "0";

            cmbFigura.SelectedIndexChanged += cmbFigura_SelectedIndexChanged;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbFigura.SelectedItem?.ToString();

            if (tipo == "Linea")
            {
                nudTamaño.Enabled = false;
                nudX2nudY2.Enabled = true;
                nudXnudY.Enabled = true;
            }
            else 
            {
                nudTamaño.Enabled = true;
                nudX2nudY2.Enabled = false;
                nudXnudY.Enabled = true;
            }
        }


        private void pbColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pbColor.BackColor = colorDialog1.Color;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string tipo = cmbFigura.SelectedItem?.ToString();
            int x = (int)nudXnudY.Value;
            int y = (int)nudXnudY.Value;
            int tamaño = (int)nudTamaño.Value;
            int x2 = (int)nudX2nudY2.Value;
            int y2 = (int)nudX2nudY2.Value;

            if (pbColor.BackColor == Color.Transparent)
            {
                MessageBox.Show("Seleccione un color para la figura.");
                return;
            }

            Figura f = null;

            switch (tipo)
            {
                case "Rectangulo":
                case "Circulo":
                case "Triangulo":
                    if (tamaño <= 0)
                    {
                        MessageBox.Show("El tamaño debe ser mayor que cero.");
                        return;
                    }
                    if (x < 0 || y < 0 || x + tamaño > pbLienzo.Width || y + tamaño > pbLienzo.Height)
                    {
                        MessageBox.Show("La figura no cabe en el lienzo con las dimensiones dadas.");
                        return;
                    }
                    f = FiguraFactory.CrearFigura(tipo, pbColor.BackColor, x, y, tamaño);
                    break;

                case "Linea":
                    if (x < 0 || y < 0 || x > pbLienzo.Width || y > pbLienzo.Height ||
                        x2 < 0 || y2 < 0 || x2 > pbLienzo.Width || y2 > pbLienzo.Height)
                    {
                        MessageBox.Show("Los puntos de la línea deben estar dentro del lienzo.");
                        return;
                    }
                    f = FiguraFactory.CrearFigura(tipo, pbColor.BackColor, x, y, x2, y2);
                    break;

                default:
                    MessageBox.Show("Seleccione un tipo de figura válido.");
                    return;
            }

            if (f != null)
            {
                figuras.Add(f);
                f.Dibujar(pbLienzo.CreateGraphics());
                txtContador.Text = figuras.Count.ToString();
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            figuras.Clear();
            pbLienzo.Refresh();
            txtContador.Text = "0";
        }

        //Se termina la clase Form1
    }
}