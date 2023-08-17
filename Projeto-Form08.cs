using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soma2Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Código by: Letícia França
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //entrada de valores
            int valor1, valor2, resultado;

            //processamento de dados
            valor1 = int.Parse(txtValor1.Text);
            valor2 = int.Parse(txtValor2.Text);

            resultado = valor1 + valor2;

            //saída de dados
            lblResultado.Text = resultado.ToString();

            txtValor1.Text = "";
            txtValor2.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 OutroForm = new Form2();
            OutroForm.ShowDialog();
        }
    }
}