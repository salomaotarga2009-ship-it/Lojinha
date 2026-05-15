using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lojinha.Formularios
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesForm cliente = new ClientesForm();
            cliente.Show(this);
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutosForm cliente = new ProdutosForm();
            cliente.Show(this);
        }
    }
}
