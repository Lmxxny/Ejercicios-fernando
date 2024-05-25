using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt2a3b.Clear();
            txta1.Clear();
            txta2.Clear();
            txta3.Clear();
            txta4.Clear();
            txta5.Clear();
            txta6.Clear();
            txtb1.Clear();
            txtb2.Clear();
            txtb3.Clear();
            txtb4.Clear();
            txtb5.Clear();
            txtb6.Clear();
            txtc1.Clear();
            txtc2.Clear();
            txtc3.Clear();
            txtc4.Clear();
            txtc5.Clear();
            txtc6.Clear();
            txtsumab.Clear();
        }


        private void btnlimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double a1, a2, a3, a4,a5, a6;
            double b1, b2, b3, b4, b5, b6;
            double c1, c2, c3, c4, c5, c6;

            if (string.IsNullOrEmpty(txta1.Text) || string.IsNullOrEmpty(txta2.Text) || string.IsNullOrEmpty(txta3.Text) || string.IsNullOrEmpty(txta4.Text) || string.IsNullOrEmpty(txta5.Text) || string.IsNullOrEmpty(txta6.Text) || string.IsNullOrEmpty(txtb1.Text) || string.IsNullOrEmpty(txtb2.Text) || string.IsNullOrEmpty(txtb3.Text) || string.IsNullOrEmpty(txtb4.Text) || string.IsNullOrEmpty(txtb5.Text) || string.IsNullOrEmpty(txtb6.Text) || string.IsNullOrEmpty(txtc1.Text) || string.IsNullOrEmpty(txtc2.Text) || string.IsNullOrEmpty(txtc3.Text) || string.IsNullOrEmpty(txtc4.Text) || string.IsNullOrEmpty(txtc5.Text) || string.IsNullOrEmpty(txtc6.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en los campos en blanco", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                a1 = double.Parse(txta1.Text);
                a2 = double.Parse(txta2.Text);
                a3 = double.Parse(txta3.Text);
                a4 = double.Parse(txta4.Text);
                a5 = double.Parse(txta5.Text);
                a6 = double.Parse(txta6.Text);
                b1 = double.Parse(txtb1.Text);
                b2 = double.Parse(txtb2.Text);
                b3 = double.Parse(txtb3.Text);
                b4 = double.Parse(txtb4.Text);
                b5 = double.Parse(txtb5.Text);
                b6 = double.Parse(txtb6.Text);
                c1 = double.Parse(txtc1.Text);
                c2 = double.Parse(txtc2.Text);
                c3 = double.Parse(txtc3.Text);
                c4 = double.Parse(txtc4.Text);
                c5 = double.Parse(txtc5.Text);
                c6 = double.Parse(txtc6.Text);

                //suma a + b
                double[,] A = new double[,]
                {
                    { a1, a2, a3 },
                    { b1, b2, b3 },
                    { c1, c2, c3 }
                };

                double[,] B = new double[,]
                {
                    { a4, a5, a6 },
                    { b4, b5, b6 },
                    { c4, c5, c6 }
                };

                double[,] C = new double[3, 3];

                // Calcular la suma de A y B
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        C[i, j] = A[i, j] + B[i, j];
                    }
                }
            }
        }
    }
}