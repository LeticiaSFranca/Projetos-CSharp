﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex03Pag20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Código by: Letícia França
            int valorA, valorB, valorC;

            valorA = int.Parse(txtValorA.Text);
            valorB = int.Parse(txtValorB.Text);

            if (valorA == valorB)
            {
                valorC = valorA + valorB;
            }

            else
            {
                valorC = (valorA * valorB);
            }

            txtResultado.Text = valorC.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtValorB.Clear();
            txtValorA.Clear();
            txtResultado.Clear();
        }
    }
}