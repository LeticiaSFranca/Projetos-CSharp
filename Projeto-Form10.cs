﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16AbrilFluxogramas
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
            int num1, num2, media;

            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);

            media = (num1 + num2) / 2;

            if (media >= 7)
            {
                txtResposta.Text = "Aprovado";
            }

            else
            {
                txtResposta.Text = "Reprovado";
            }
        }
    }
}