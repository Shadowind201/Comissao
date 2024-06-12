using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comissao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string input = txtVenda.Text;

            if(decimal.TryParse(input, out decimal ValorVendas))
            {
                decimal comissao;
                if (ValorVendas < 1500)
                {
                    comissao = ValorVendas * 0.20m;
                }
                else
                {
                    comissao = ValorVendas * 0.35m;
                }
                txtComissão.Text = comissao.ToString();
            }
            else
            {
                MessageBox.Show("Entrada Invalida, Digite um valor numerico!");
            }
            txtValor.Text = ValorVendas.ToString();
        }
    }
}
