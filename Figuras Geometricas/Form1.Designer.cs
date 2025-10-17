namespace Figuras_Geometricas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbFigura = new ComboBox();
            nudXnudY = new NumericUpDown();
            nudTamaño = new NumericUpDown();
            nudX2nudY2 = new NumericUpDown();
            pbLienzo = new PictureBox();
            pbColor = new PictureBox();
            colorDialog1 = new ColorDialog();
            btnCrear = new Button();
            btnLimpiar = new Button();
            txtContador = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudXnudY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTamaño).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudX2nudY2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLienzo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbColor).BeginInit();
            SuspendLayout();
            // 
            // cmbFigura
            // 
            cmbFigura.FormattingEnabled = true;
            cmbFigura.Location = new Point(70, 58);
            cmbFigura.Name = "cmbFigura";
            cmbFigura.Size = new Size(151, 28);
            cmbFigura.TabIndex = 0;
            // 
            // nudXnudY
            // 
            nudXnudY.Location = new Point(71, 121);
            nudXnudY.Name = "nudXnudY";
            nudXnudY.Size = new Size(150, 27);
            nudXnudY.TabIndex = 1;
            // 
            // nudTamaño
            // 
            nudTamaño.Location = new Point(71, 190);
            nudTamaño.Name = "nudTamaño";
            nudTamaño.Size = new Size(150, 27);
            nudTamaño.TabIndex = 2;
            // 
            // nudX2nudY2
            // 
            nudX2nudY2.Location = new Point(71, 257);
            nudX2nudY2.Name = "nudX2nudY2";
            nudX2nudY2.Size = new Size(150, 27);
            nudX2nudY2.TabIndex = 3;
            // 
            // pbLienzo
            // 
            pbLienzo.BorderStyle = BorderStyle.Fixed3D;
            pbLienzo.Location = new Point(354, 12);
            pbLienzo.Name = "pbLienzo";
            pbLienzo.Size = new Size(400, 600);
            pbLienzo.TabIndex = 4;
            pbLienzo.TabStop = false;
            // 
            // pbColor
            // 
            pbColor.BorderStyle = BorderStyle.Fixed3D;
            pbColor.Location = new Point(760, 12);
            pbColor.Name = "pbColor";
            pbColor.Size = new Size(400, 600);
            pbColor.TabIndex = 5;
            pbColor.TabStop = false;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(12, 470);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(137, 52);
            btnCrear.TabIndex = 6;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(185, 470);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(137, 52);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtContador
            // 
            txtContador.Location = new Point(70, 320);
            txtContador.Name = "txtContador";
            txtContador.Size = new Size(125, 27);
            txtContador.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 685);
            Controls.Add(txtContador);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCrear);
            Controls.Add(pbColor);
            Controls.Add(pbLienzo);
            Controls.Add(nudX2nudY2);
            Controls.Add(nudTamaño);
            Controls.Add(nudXnudY);
            Controls.Add(cmbFigura);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudXnudY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTamaño).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudX2nudY2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLienzo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFigura;
        private NumericUpDown nudXnudY;
        private NumericUpDown nudTamaño;
        private NumericUpDown nudX2nudY2;
        private PictureBox pbLienzo;
        private PictureBox pbColor;
        private ColorDialog colorDialog1;
        private Button btnCrear;
        private Button btnLimpiar;
        private TextBox txtContador;
    }
}
