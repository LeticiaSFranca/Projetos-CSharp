using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02Pag35
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
            char classe;
            string nome, resultado;
            double salarioHora;

            classe = char.Parse(txtDigiteClasse.Text);
            nome = txtNome.Text;
            salarioHora = double.Parse(txtNumHrsTrabalhada.Text);

            switch (classe.ToString().ToUpper())
            {
                case "A": txtRespostaFinal.Text = nome + " deverá receber " + (salarioHora * 8.00); break;
                case "B": txtRespostaFinal.Text = nome + " deverá receber " + (salarioHora * 12.00); break;
                case "C": txtRespostaFinal.Text = nome + " deverá receber " + (salarioHora * 17.00); break;
                default: MessageBox.Show("Erro. Confira se todos os campos foram preenchidos de maneira correta."); break;
            }

        }
    }
}