﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex03Pag27
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
            int num1, num2, soma;

            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);

            soma = num1 + num2;

            if (soma > 20)
            {
                txtResultado.Text = (soma + 8).ToString();
            }

            else if (soma <= 20)
            {
                txtResultado.Text = (soma - 5).ToString();

            }

            else
            {
                txtResultado.Text = "Esse número não existe.";

            }
        }
    }
}