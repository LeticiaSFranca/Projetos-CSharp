using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex10Pag9
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

            idade = DateTime.Now.Year - int.Parse(anoNascimento.Text);

            lblAnos.Text = "Anos: " + idade.ToString();
            lblDias.Text = "Dias: " + (idade * 365).ToString();
            lblMeses.Text = "Meses: " + (idade * 12).ToString();
            lblSemanas.Text = "Semanas: " + ((idade * 12) * 4).ToString();
        }
    }
}