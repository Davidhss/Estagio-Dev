using System;
using System.Linq;
using System.Windows.Forms;

namespace Inverter_ModoVisual
{
    public partial class frmInverse : Form
    {
        public frmInverse()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
            txtInverse.Clear();
            txtTexto.Focus();
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            txtInverse.Clear();

            string str, texto = txtTexto.Text;
            char[] arr;
            int i;

            str = new string(texto.ToLower().Reverse().ToArray());

            arr = str.ToCharArray(0, str.Length);

            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u')
                {
                    txtInverse.Text += arr[i] + " ";
                }
                else
                {
                    txtInverse.Text += arr[i];
                }
            }
        }
    }
}
