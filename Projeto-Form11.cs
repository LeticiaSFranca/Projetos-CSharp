﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abril_Fluxograma_2
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
            int idade;

            idade = int.Parse(txtIdade.Text);

            if (idade <= 17)
            {
                txtResultado.Text = "Menor de idade.";
            }

            else if (idade >= 18)
            {
                txtResultado.Text = "Maior de idade.";
            }
        }
    }
}