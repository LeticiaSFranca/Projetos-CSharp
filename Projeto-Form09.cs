﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            //Código by: Letícia França
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = int.Parse(txtValor1.Text);
            valor2 = int.Parse(txtValor2.Text);

            resultado = valor1 + valor2;

            lblResultado.Text = resultado.ToString();

            txtValor1.Text = "";
            txtValor2.Text = "";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = int.Parse(txtValor1.Text);
            valor2 = int.Parse(txtValor2.Text);

            resultado = valor1 - valor2;

            lblResultado.Text = resultado.ToString();

            txtValor1.Text = "";
            txtValor2.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = int.Parse(txtValor1.Text);
            valor2 = int.Parse(txtValor2.Text);

            resultado = valor1 / valor2;

            lblResultado.Text = resultado.ToString();

            txtValor1.Text = "";
            txtValor2.Text = "";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = int.Parse(txtValor1.Text);
            valor2 = int.Parse(txtValor2.Text);

            resultado = valor1 * valor2;

            lblResultado.Text = resultado.ToString();

            txtValor1.Text = "";
            txtValor2.Text = "";
        }
    }
}