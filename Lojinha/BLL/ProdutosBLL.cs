using Lojinha.DAL;
using Lojinha.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.BLL
{
    internal class ProdutosBLL
    {
        public void Incluir(ClienteInformation cliente)
        {
            //o nome 
            if(cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            //
            cliente.Email = cliente.Email.ToLower();
            //
            ClientesBLL obj = new ClientesBLL();
            obj.Incluir(cliente);
        }
        public void Alterar(ClienteInformation cliente)
        {
            //
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            //
            cliente.Email = cliente.Email.ToLower();
            //
            ClientesDAL obj = new ClientesDAL();
            obj.Alterar(cliente);
        }
        public void Excluir(int codigo)
        {
            if (codigo < 1)
            {
                throw new Exception("Selecione um cliente antes de excluir");
            }
            ClientesDAL obj = new ClientesDAL();
            obj.Excluir(codigo);
        }
        public DataTable Listagem(string filtro)
        {
            ClientesDAL obj = new ClientesDAL();
            return obj.Listagem(filtro);
        }

        internal void Incluir(ProdutosInformation produto)
        {
            throw new NotImplementedException();
        }
    }
}
