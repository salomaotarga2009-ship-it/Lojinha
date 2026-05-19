using Lojinha.BLL;
using Lojinha.Modelos;
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

        private void incluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutosInformation produto = new ProdutosInformation();

                produto.Nome = nomeTextBox.Text;
                produto.Preco = Convert.ToDecimal(precoTextBox.Text);
                produto.Estoque = Convert.ToInt32(estoqueTextBox.Text);

                ProdutosBLL obj = new ProdutosBLL();
                obj.Incluir(produto);

                MessageBox.Show("Produto incluído com sucesso!");

                codigoTextBox.Text = produto.Codigo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir: " + ex.Message);
            }
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codigoTextBox.Text))
            {
                MessageBox.Show("Selecione um produto para alterar.");
                return;
            }

            try
            {
                ProdutosInformation produto = new ProdutosInformation();

                produto.Codigo = Convert.ToInt32(codigoTextBox.Text);
                produto.Nome = nomeTextBox.Text;
                produto.Preco = Convert.ToDecimal(precoTextBox.Text);
                produto.Estoque = Convert.ToInt32(estoqueTextBox.Text);

                ProdutosBLL obj = new ProdutosBLL();
                obj.Alterar(produto);

                MessageBox.Show("Produto alterado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar: " + ex.Message);
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codigoTextBox.Text))
            {
                MessageBox.Show("Selecione um Produto para excluir.");
                return;
            }

            try
            {
                int codigo = Convert.ToInt32(codigoTextBox.Text);

                ProdutosBLL obj = new ProdutosBLL();
                obj.Excluir(codigo);

                MessageBox.Show("Produto excluído com sucesso!");

                codigoTextBox.Clear();
                nomeTextBox.Clear();
                precoTextBox.Clear();
                estoqueTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }

        private void filtrarTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
