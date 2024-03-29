﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex15Pag9
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
            double questões = Convert.ToInt32(this.txtQuantQuestoes.Text);
            double questõesCertas = Convert.ToInt32(this.txtQuantAcertos.Text);

            double questõesErradas = questões - questõesCertas;

            double porcentAcerto = questõesCertas * 100 / questões;
            double porcentErro = questõesErradas * 100 / questões;

            txtPorcentAcerto.Text = porcentAcerto.ToString();
            txtQuantErros.Text = questõesErradas.ToString();
            txtPorcentErro.Text = porcentErro.ToString();
        }
    }
}