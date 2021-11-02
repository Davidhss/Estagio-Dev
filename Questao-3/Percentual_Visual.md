using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Percentual_ModoVisual
{
    public partial class frmPer : Form
    {
        public frmPer()
        {
            InitializeComponent();
        }

        private void txtVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtTaxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtVenda.Text == "")
            {
                MessageBox.Show("Insira o valor da venda!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtVenda.Focus();
            }
            else if (txtTaxa.Text == "")
            {
                MessageBox.Show("Insira o valor da taxa!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTaxa.Focus();
            }
            else if (Convert.ToDouble(txtVenda.Text) < 0 || Convert.ToDouble(txtTaxa.Text) < 0)
            {
                MessageBox.Show("Insira valores positivos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (Convert.ToDouble(txtVenda.Text) < 0)
                {
                    txtVenda.Clear();
                    txtVenda.Focus();
                }
                else
                {
                    txtTaxa.Clear();
                    txtTaxa.Focus();
                }
            }
            else
            {
                double resultado = (100 - (Convert.ToDouble(txtVenda.Text) - Convert.ToDouble(txtTaxa.Text)) / Convert.ToDouble(txtVenda.Text) * 100);

                txtPer.Text = (resultado + "%");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVenda.Clear();
            txtTaxa.Clear();
            txtPer.Clear();
            txtVenda.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
