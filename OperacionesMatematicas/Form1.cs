using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacionesMatematicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtNumero1.Text);
            double numero2 = double.Parse(txtNumero2.Text);
            double suma = 0;

            suma = numero1 + numero2;

            lblResultado.Text = Convert.ToString(String.Format("{0:n0}", suma));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = String.Empty;
            txtNumero2.Text = String.Empty;
            lblResultado.Text = "0";

            txtNumero1.Focus();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtNumero1.Text);
            double numero2 = double.Parse(txtNumero2.Text);
            double resta = 0;

            resta = numero1 - numero2;

            lblResultado.Text = Convert.ToString(String.Format("{0:n0}", resta));
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtNumero1.Text);
            double numero2 = double.Parse(txtNumero2.Text);
            double multiplica = 0;

            multiplica = numero1 * numero2;

            lblResultado.Text = Convert.ToString(String.Format("{0:n0}", multiplica));
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtNumero1.Text);
            double numero2 = double.Parse(txtNumero2.Text);
            double divide = 0;

            divide = numero1 / numero2;

            lblResultado.Text = Convert.ToString(String.Format("{0:n0}", divide));
        }
    }
}
