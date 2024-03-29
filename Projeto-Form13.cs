﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaClasse //Código by: Letícia França - Métodos
{
    internal class Metodos
    {
        public double SOMA(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }

        public double MEDIA(double num1, double num2, double num3)
        {
            return (num1 + num2 + num3) / 3;
        }

        public double MAIOR(double num1, double num2, double num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }

            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }

            else
            {
                return num3;
            }
        }

        public double MENOR(double num1, double num2, double num3)
        {
            if (num1 < num2 && num1 < num3)
            {
                return num1;
            }

            else if (num2 < num1 && num2 < num3)
            {
                return num2;
            }

            else
            {
                return num3;
            }
        }

        public double CUBO(double num1)
        {
            return num1 * num1 * num1;
        }

        public string ParOuImpar(double num1)
        {
            if (num1 % 2 == 0)
            {
                return "Número Par";
            }

            else
            {
                return "Número Ímpar";
            }
        }

        public string PNZ(double num1)
        {
            if (num1 < 0)
            {
                return "Número Negativo";
            }

            else if (num1 > 0)
            {
                return "Número Positivo";
            }

            else
            {
                return "Zero";
            }
        }

    }
}
// ----------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaClasse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Metodos obj = new Metodos();
        //Código by: Letícia França

        public void btnSoma_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, soma;

            num1 = double.Parse(txtNumero1.Text);
            num2 = double.Parse(txtNumero2.Text);
            num3 = double.Parse(txtNumero3.Text);

            soma = obj.SOMA(num1, num2, num3);
            txtResultado.Text = soma.ToString();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, media;

            num1 = double.Parse(txtNumero1.Text);
            num2 = double.Parse(txtNumero2.Text);
            num3 = double.Parse(txtNumero3.Text);

            media = obj.MEDIA(num1, num2, num3);
            txtResultado.Text = media.ToString();
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, maior;

            num1 = double.Parse(txtNumero1.Text);
            num2 = double.Parse(txtNumero2.Text);
            num3 = double.Parse(txtNumero3.Text);

            maior = obj.MAIOR(num1, num2, num3);
            txtResultado.Text = maior.ToString();
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, menor;

            num1 = double.Parse(txtNumero1.Text);
            num2 = double.Parse(txtNumero2.Text);
            num3 = double.Parse(txtNumero3.Text);

            menor = obj.MENOR(num1, num2, num3);
            txtResultado.Text = menor.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero3.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form2 objFormulario = new Form2();
            objFormulario.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}