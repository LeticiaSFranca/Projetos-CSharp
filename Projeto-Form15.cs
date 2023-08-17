using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01Pag35
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
            char codigo;
            double juros, parcela, financiamento, valorCarro;


            codigo = char.Parse(txtEscolhido.Text);
            valorCarro = double.Parse(txtValorCarro.Text);

            switch (codigo.ToString().ToUpper())
            {
                case "A": juros = valorCarro * 0.3; txtTotalJuros.Text = juros.ToString("0.00"); financiamento = juros + valorCarro; txtTotalFinanciamento.Text = financiamento.ToString("0.00"); parcela = financiamento / 24; txtTotalParcela.Text = parcela.ToString("0.00"); break;
                case "B": juros = valorCarro * 0.55; txtTotalJuros.Text = juros.ToString("0.00"); financiamento = juros + valorCarro; txtTotalFinanciamento.Text = financiamento.ToString("0.00"); parcela = financiamento / 36; txtTotalParcela.Text = parcela.ToString("0.00"); break;
                case "C": juros = valorCarro * 0.75; txtTotalJuros.Text = juros.ToString("0.00"); financiamento = juros + valorCarro; txtTotalFinanciamento.Text = financiamento.ToString("0.00"); parcela = financiamento / 48; txtTotalParcela.Text = parcela.ToString("0.00"); break;
            }

        }
    }
}