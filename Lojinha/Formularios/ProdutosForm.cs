using Lojinha.BLL;
using Lojinha.DAL;
using Lojinha.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lojinha.Formularios
{
    public partial class ProdutosForm : Form
    {
        public ProdutosForm()
        {
            InitializeComponent();
        }

        private void incluiButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutosInformation produto = new ProdutosInformation();

                produto.Nome = nomeTextBox.Text;
                produto.Preco = Convert.ToDecimal(precoTextbox.Text);
                produto.Estoque = Convert.ToInt32(estoqueTextbox.Text);

                ProdutosBLL obj = new ProdutosBLL();
                obj.Incluir(produto);

                MessageBox.Show("Produto incluído com sucesso!");

                codigoTextbox.Text = produto.Codigo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir: " + ex.Message);
            }
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codigoTextbox.Text))
            {
                MessageBox.Show("Selecione um produto para alterar.");
                return;
            }

            try
            {
                ProdutosInformation produto = new ProdutosInformation();

                produto.Codigo = Convert.ToInt32(codigoTextbox.Text);
                produto.Nome = nomeTextBox.Text;
                produto.Preco = Convert.ToDecimal(precoTextbox.Text);
                produto.Estoque = Convert.ToInt32(estoqueTextbox.Text);

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
            if (string.IsNullOrWhiteSpace(codigoTextbox.Text))
            {
                MessageBox.Show("Selecione um Produto para excluir.");
                return;
            }

            try
            {
                int codigo = Convert.ToInt32(codigoTextbox.Text);

                ProdutosBLL obj = new ProdutosBLL();
                obj.Excluir(codigo);

                MessageBox.Show("Produto excluído com sucesso!");

                codigoTextbox.Clear();
                nomeTextBox.Clear();
                precoTextbox.Clear();
                estoqueTextbox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }
    }
}