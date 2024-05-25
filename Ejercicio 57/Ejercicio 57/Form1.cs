using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_57
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtn.Clear();
            txtsum.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtn.Text, out int numero))
            {
                int sumaDigitos = CalcularSumaDigitos(numero);
                txtsum.Text = sumaDigitos.ToString();
            }
            else
            {
                MessageBox.Show("Ingresa un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CalcularSumaDigitos(int num)
        {
            int suma = 0;

            while (num > 0)
            {
                int digito = num % 10;
                suma += digito;
                num /= 10;
            }

            return suma;
        }
    }
}
