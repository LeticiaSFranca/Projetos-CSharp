﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex04Pag35
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
            char codigo;
            int numeroHoras, numeroExtras;
            double salHora, salBruto, adicional, inss, salLiquido;

            codigo = char.Parse(txtHorasTrabalhadas.Text);
            numeroHoras = int.Parse(txtHorasTrabalhadas.Text);
            numeroExtras = int.Parse(txtHorasExtras.Text);

            switch (codigo)
            {
                case '1':
                    salHora = 8.00; break;
                case '2':
                    salHora = 10.00; break;
                case '3':
                    salHora = 12.00; break;
                case '4':
                    salHora = 15.00; break;
                case '5':
                    salHora = 20.00; break;
                default:
                    salHora = 0.00;
                    MessageBox.Show("Classe Inválida. Tente Novamente."); break;
            }

            salBruto = numeroHoras * salHora;
            adicional = numeroExtras * salHora * 1.5;
            inss = salBruto * 0.11;
            salLiquido = salBruto * adicional - inss;

            txtSalarioBruto.Text = salBruto.ToString("C");
            txtAdicional.Text = adicional.ToString("C");
            txtDescontoINSS.Text = inss.ToString("C");
            txtSalarioLiquido.Text = salLiquido.ToString("C");
        }
    }
}