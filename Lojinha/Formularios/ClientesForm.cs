using Lojinha.BLL;
using Lojinha.DAL;
using Lojinha.Modelos;
using System;
using System.Windows.Forms;

namespace Lojinha.Formularios
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void incluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteInformation cliente = new ClienteInformation();

                cliente.Nome = nomeTextbox.Text;
                cliente.Email = emailTextbox.Text;
                cliente.Telefone = telefoneTextbox.Text;

                ClientesBLL obj = new ClientesBLL();
                obj.Incluir(cliente);

                MessageBox.Show("Cliente incluído com sucesso!");

                codigoTextbox.Text = cliente.Codigo.ToString();
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
                MessageBox.Show("Selecione um cliente para alterar.");
                return;
            }

            try
            {
                ClienteInformation cliente = new ClienteInformation();

                cliente.Codigo = Convert.ToInt32(codigoTextbox.Text);
                cliente.Nome = nomeTextbox.Text;
                cliente.Email = emailTextbox.Text;
                cliente.Telefone = telefoneTextbox.Text;

                ClientesBLL obj = new ClientesBLL();
                obj.Alterar(cliente);

                MessageBox.Show("Cliente alterado com sucesso!");
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
                MessageBox.Show("Selecione um cliente para excluir.");
                return;
            }

            try
            {
                int codigo = Convert.ToInt32(codigoTextbox.Text);

                ClientesBLL obj = new ClientesBLL();
                obj.Excluir(codigo);

                MessageBox.Show("Cliente excluído com sucesso!");

                codigoTextbox.Clear();
                nomeTextbox.Clear();
                emailTextbox.Clear();
                telefoneTextbox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }
    }
}   