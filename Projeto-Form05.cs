﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex07Pag08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Códigos by: Letícia França
            int P, M, G, Resultado;

            P = int.Parse(txtCamP.Text);
            M = int.Parse(txtCamisaM.Text);
            G = int.Parse(txtCamG.Text);

            Resultado = (P * 12) + (M * 16) + (G * 22);

            txtResultado.Text = Resultado.ToString();
        }
    }
}