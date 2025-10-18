using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Figuras_Geometricas.Entidades; 

namespace Figuras_Geometricas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            nudX2nudY2.Minimum = 0;
            nudTamaño.Minimum = 1;
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

        }

    }
}
