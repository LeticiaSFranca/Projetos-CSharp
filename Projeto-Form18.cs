using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex03Pag35
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
            double quantidade, total = 0;
            string codigo;

            codigo = txtCodigo.Text;
            quantidade = int.Parse(txtQuantidade.Text);

            switch (total.ToString().ToUpper())
            {
                case "AUTO": total = 325.00 * quantidade; txtTotalAPagar.Text = total.ToString(); break;
                case "MOTO": total = 102.00 * quantidade; txtTotalAPagar.Text = total.ToString(); break;
                case "BIKE": total = 76.00 * quantidade; txtTotalAPagar.Text = total.ToString(); break;
                case "KLWE": total = 176.00 * quantidade; txtTotalAPagar.Text = total.ToString(); break;
                case "WPPD": total = 456.00 * quantidade; txtTotalAPagar.Text = total.ToString(); break;
                default: MessageBox.Show("Ocorreu algum erro."); break;
            }
        }
    }
}