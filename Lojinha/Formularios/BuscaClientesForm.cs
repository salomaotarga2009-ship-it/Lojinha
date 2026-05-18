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
    public partial class BuscaClientesForm : Form
    {
        public BuscaClientesForm()
        {
            InitializeComponent();
        }
        public void AtualizaGrid()
        {
            //Comunicação com a camada BLL
            ClientesBLL obj = new ClientesBLL();
            ClientesDataGridView.DataSource = obj.Listagem(filtroTextbox.Text);

            //atualiza os objetos Textbox
            try
            {
                codigoTextbox.Text = ClientesDataGridView[0, ClientesDataGridView.CurrentRow.Index].Value.ToString();
                nomeTextbox.Text = ClientesDataGridView[1, ClientesDataGridView.CurrentRow.Index].Value.ToString();
                emailTextBox.Text = ClientesDataGridView[2, ClientesDataGridView.CurrentRow.Index].Value.ToString();
                telefoneTextbox.Text = ClientesDataGridView[3, ClientesDataGridView.CurrentRow.Index].Value.ToString();
            }
            catch (Exception)
            {
                codigoTextbox.Text = "";
                nomeTextbox.Text = "";
                emailTextBox.Text = "";
                telefoneTextbox.Text = ""; 
            }
        }

        private void BuscaClientesForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            nomeTextbox.Focus();
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            //Comunicação com a camada BLL
            ClientesBLL obj = new ClientesBLL();
            ClientesDataGridView.DataSource = obj.Listagem(filtroTextbox.Text);

            //atualiza os objetos Textbox
            try
            {
                codigoTextbox.Text = ClientesDataGridView[0, ClientesDataGridView.CurrentRow.Index].Value.ToString();
                nomeTextbox.Text = ClientesDataGridView[1, ClientesDataGridView.CurrentRow.Index].Value.ToString();
                emailTextBox.Text = ClientesDataGridView[2, ClientesDataGridView.CurrentRow.Index].Value.ToString();
                telefoneTextbox.Text = ClientesDataGridView[3, ClientesDataGridView.CurrentRow.Index].Value.ToString();
            }
            catch (Exception)
            {
                codigoTextbox.Text = "";
                nomeTextbox.Text = "";
                emailTextBox.Text = "";
                telefoneTextbox.Text = "";
            }
        }
    }
}
