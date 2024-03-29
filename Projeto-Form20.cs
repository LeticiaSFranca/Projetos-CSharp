﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex07Pag08_Classes
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
            Calculos objeto = new Calculos();

            int quantP, quantM, quantG;
            double ValorTotal;

            quantP = int.Parse(txtCamisaP.Text);
            quantM = int.Parse(txtCamisaM.Text);
            quantG = int.Parse(txtCamisaG.Text);

            ValorTotal = objeto.CalculaValor(quantP, 12.00) + objeto.CalculaValor(quantM, 16.00) + objeto.CalculaValor(quantG, 22.00);
            txtValorTotal.Text = ValorTotal.ToString("C");

        }

        private void LimparDados()
        {
            txtCamisaP.Text = "";
            txtCamisaM.Text = "";
            txtCamisaG.Text = "";
            txtValorTotal.Text = "Valor Total";
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            LimparDados();
        }
    }
}

// *--------------------------------------------------------------*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07Pag08_Classes
{
    internal class Calculos
    {
        public double CalculaValor(int quantidade, double preco)
        {
            return quantidade * preco;
        }
    }
}