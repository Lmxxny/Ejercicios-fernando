using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_50
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
            txtdiv.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(txtn.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en los campos en blanco", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(int.TryParse(txtn.Text, out int numero))
            {
                StringBuilder divisoresTexto = new StringBuilder();

                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        divisoresTexto.Append(i);
                        divisoresTexto.Append(", ");

                        if (divisoresTexto.Length >= 30) // Limitar a los primeros 10 divisores
                            break;
                    }
                }

                // Eliminar la última coma y espacio
                if (divisoresTexto.Length > 0)
                    divisoresTexto.Length -= 2;

                txtdiv.Text = divisoresTexto.ToString();
            }
        }
    }
}
