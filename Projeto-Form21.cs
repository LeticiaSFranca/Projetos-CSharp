using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExPag24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Código by: Letícia França
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero;

            numero = int.Parse(txtNInteiro.Text);

            if (numero % 2 == 0)
            {
                txtResultado.Text = " é par. ";
            }

            else
            {
                txtResultado.Text = " é ímpar. ";
            }
        }
    }
}