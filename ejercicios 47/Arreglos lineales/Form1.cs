using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos_lineales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txta1.Clear();
            txta2.Clear();
            txta3.Clear();
            txtb1.Clear();
            txtb2.Clear();
            txtb3.Clear();
            txtorto.Clear();
            txtprodpun.Clear();
            txtz.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double a1, a2, a3;
            double b1, b2, b3;

            if (string.IsNullOrEmpty(txta1.Text) || string.IsNullOrEmpty(txta2.Text) || string.IsNullOrEmpty(txta3.Text) || string.IsNullOrEmpty(txtb1.Text) || string.IsNullOrEmpty(txtb2.Text) || string.IsNullOrEmpty(txtb3.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en los campos en blanco", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                a1 = double.Parse(txta1.Text);
                a2 = double.Parse(txta2.Text);
                a3 = double.Parse(txta3.Text);
                b1 = double.Parse(txtb1.Text);
                b2 = double.Parse(txtb2.Text);
                b3 = double.Parse(txtb3.Text);

                //producto punto
                double productoPunto = a1 * b1 + a2 * b2 + a3 * b3;
                txtprodpun.Text = productoPunto.ToString();

                //ortogonalidad
                const double tolerancia = 1e-10;
                bool sonOrtogonales = Math.Abs(productoPunto) < tolerancia;
                string ortogonal;

                if (sonOrtogonales)
                {
                    ortogonal = "Son ortogonales.";
                    txtorto.Text = ortogonal;
                }
                else
                {
                    ortogonal = "No son ortogonales.";
                    txtorto.Text = ortogonal;
                }

                //Calcular Z
                double moduloA = Math.Sqrt(a1 * a1 + a2 * a2 + a3 * a3);
                double moduloB = Math.Sqrt(b1 * b1 + b2 * b2 + b3 * b3);

                double Z = productoPunto / (moduloA * moduloB);
                txtz.Text = Z.ToString();
            }
        }
    }
}
