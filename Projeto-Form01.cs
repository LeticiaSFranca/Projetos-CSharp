using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01Pag08
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
            int valor1, valor2, valor3, total, media, soma1e3, porcentValor1, porcentValor2, porcentValor3;

            valor1 = int.Parse(txtValor1.Text);
            valor2 = int.Parse(txtValor2.Text);
            valor3 = int.Parse(txtValor3.Text);

            total = valor1 + valor2 + valor3;

            txtTotal.Text = total.ToString();

            media = (valor1 + valor2 + valor3) / 3;

            txtMedia.Text = media.ToString();

            porcentValor1 = (valor1 * 100) / total;
            porcentValor2 = (valor2 * 100) / total;
            porcentValor3 = (valor3 * 100) / total;

            soma1e3 = valor1 + valor3;

            txtSoma1e3.Text = soma1e3.ToString();

            txtPorcentValor1.Text = porcentValor1.ToString();
            txtPorcentValor2.Text = porcentValor2.ToString();
            txtPorcentValor3.Text = porcentValor3.ToString();
        }
    }
}