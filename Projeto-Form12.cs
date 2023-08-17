using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abril_Fluxograma_3
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
            string prof;
            double salario, reaj;

            prof = txtProfissao.Text;
            salario = double.Parse(txtSalario.Text);

            if (prof == "Técnico")
            {
                reaj = salario * 1.5;
            }

            else if (prof == "Gerente")
            {
                reaj = salario * 1.3;
            }

            else
            {
                reaj = salario * 1.1;
            }

            txtResposta.Text = "Salário reajustado = " + reaj;
        }
    }
}