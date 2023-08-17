using Código___Projeto_04;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05Pag08
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Código by: Letícia França

            Form1 objTela = new Form1();
            objTela.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double moeda1cents, moeda5, moeda10, moeda25, moeda50, moeda1real, total;

            moeda1cents = double.Parse(txtmoeda1cents.Text);
            moeda5 = double.Parse(txtmoeda5.Text);
            moeda10 = double.Parse(txtmoeda10.Text);
            moeda25 = double.Parse(txtmoeda25.Text);
            moeda50 = double.Parse(txtmoeda50.Text);
            moeda1real = double.Parse(txtmoeda1real.Text);

            total = (moeda1cents * 0.01) + (moeda5 * 0.05) + (moeda10 * 0.10) + (moeda25 * 0.25) + (moeda50 * 0.50) + (moeda1real * 1);

            txtValorTotal.Text = total.ToString();
        }
    }
}