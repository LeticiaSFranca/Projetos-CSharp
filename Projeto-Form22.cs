﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExPag25
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

            numero = int.Parse(txtNumero.Text);

            if (numero > 0)
            {
                txtResult.Text = "Positivo";
            }

            else if (numero < 0)
            {
                txtResult.Text = "Negativo";
            }

            else
            {
                txtResult.Text = "Zero";
            }
        }
    }
}