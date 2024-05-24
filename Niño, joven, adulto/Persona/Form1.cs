using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int edad;
            String persona;

            if (string.IsNullOrEmpty(txtedad.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en los campos en blanco", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                edad = Convert.ToInt32(txtedad.Text);

                if (edad < 13)
                {
                    persona = "Niño";
                    txtperso.Text = persona.ToString();
                }
                else if (edad >= 13 && edad < 25)
                {
                    persona = "Joven";
                    txtperso.Text = persona.ToString();
                }
                else if (edad >= 25)
                {
                    persona = "Adulto";
                    txtperso.Text = persona.ToString();
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtedad.Clear();
            txtperso.Clear();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
