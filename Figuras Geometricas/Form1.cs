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
            nudTama�o.Minimum = 0;
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
                nudTama�o.Enabled = false;
                nudX2nudY2.Enabled = true;
                nudXnudY.Enabled = true;
            }
            else 
            {
                nudTama�o.Enabled = true;
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
            int tama�o = (int)nudTama�o.Value;

            if (pbColor.BackColor == Color.Transparent)
            {
                MessageBox.Show("Seleccione un color para la figura.");
                return;
            }

            if (tipo == "Rectangulo" || tipo == "Circulo")
            {
                if (tama�o <= 0)
                {
                    MessageBox.Show("El tama�o debe ser mayor que cero.");
                    return;
                }

                if (x < 0 || y < 0 || x + tama�o > pbLienzo.Width || y + tama�o > pbLienzo.Height)
                {
                    MessageBox.Show("La figura no cabe en el lienzo con las dimensiones dadas.");
                    return;
                }

                Figura f = FiguraFactory.CrearFigura(tipo, pbColor.BackColor, x, y, tama�o);
                if (f != null)
                {
                    figuras.Add(f);
                    f.Dibujar(pbLienzo.CreateGraphics());
                    txtContador.Text = figuras.Count.ToString();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de figura v�lido Rectangulo o Circulo.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            figuras.Clear();
            pbLienzo.Refresh();
            txtContador.Text = "0";
        }
    }
}