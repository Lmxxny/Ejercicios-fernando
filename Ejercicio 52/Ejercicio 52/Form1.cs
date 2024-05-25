using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            string[] numerosStr = new string[]
            {
                txt1al5.Text, txt6al10.Text, txt11al15.Text, txt16al20.Text
            };

            double[] numeros = new double[20];
            int contador = 0;

            foreach (var fila in numerosStr)
            {
                string[] numerosFila = fila.Split(',');

                foreach (var numStr in numerosFila)
                {
                    if (double.TryParse(numStr, out double num))
                    {
                        numeros[contador] = num;
                        contador++;
                    }
                    else
                    {
                        MessageBox.Show("Ingresa números válidos separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            int positivos = 0;
            int negativos = 0;
            int cero = 0;

            foreach (var num in numeros)
            {
                if (num > 0)
                    positivos++;
                else if (num < 0)
                    negativos++;
                else
                    cero++;
            }

            // Mostrar los resultados en los TextBox correspondientes
            txtposit.Text = positivos.ToString();
            txtnegat.Text = negativos.ToString();
            txtcero.Text = cero.ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txt11al15.Clear();
            txt16al20.Clear();
            txt1al5.Clear();
            txt6al10.Clear();
            txtcero.Clear();
            txtnegat.Clear();
            txtposit.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
