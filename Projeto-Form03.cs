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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Código by: Letícia França

            double num1, num2, totalP, totalA;
            num1 = double.Parse(txtPN1.Text);
            num2 = double.Parse(txtPN2.Text);

            totalP = (num1 * 2) + (num2 * 2);
            totalA = (num1 * num2);

            txtResultP.Text = totalP.ToString();
            txtResultA.Text = totalA.ToString();
        }

        private void proximaTela_Click(object sender, EventArgs e)
        {
            Form3 objTela = new Form3();
            objTela.ShowDialog();
        }
    }
}