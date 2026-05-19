using Lojinha.BLL;
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
    public partial class BuscarProdutosForm : Form
    {
        public BuscarProdutosForm()
        {
            InitializeComponent();
        }
        public void AtualizaGrid()
        {
            //Comunicação com a camada BLL
            ProdutosBLL obj = new ProdutosBLL();
            produtosDataGridView.DataSource = obj.Listagem(filtrarTextBox.Text);

            //atualiza os objetos Textbox
            try
            {
                codigoTextBox.Text = produtosDataGridView[0, produtosDataGridView.CurrentRow.Index].Value.ToString();
                nomeTextBox.Text = produtosDataGridView[1, produtosDataGridView.CurrentRow.Index].Value.ToString();
                precoTextBox.Text = produtosDataGridView[2, produtosDataGridView.CurrentRow.Index].Value.ToString();
                estoqueTextBox.Text = produtosDataGridView[3, produtosDataGridView.CurrentRow.Index].Value.ToString();
            }
            catch (Exception)
            {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                precoTextBox.Text = "";
                estoqueTextBox.Text = "";
            }
        }

        private void BuscarProdutosForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            nomeTextBox.Focus();
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            //Comunicação com a camada BLL
            ProdutosBLL obj = new ProdutosBLL();
            produtosDataGridView.DataSource = obj.Listagem(filtrarTextBox.Text);

            //atualiza os objetos Textbox
            try
            {
                codigoTextBox.Text = produtosDataGridView[0, produtosDataGridView.CurrentRow.Index].Value.ToString();
                nomeTextBox.Text = produtosDataGridView[1, produtosDataGridView.CurrentRow.Index].Value.ToString();
                precoTextBox.Text = produtosDataGridView[2, produtosDataGridView.CurrentRow.Index].Value.ToString();
                estoqueTextBox.Text = produtosDataGridView[3, produtosDataGridView.CurrentRow.Index].Value.ToString();
            }
            catch (Exception)
            {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                precoTextBox.Text = "";
                estoqueTextBox.Text = "";
            }
        }
    }
}
