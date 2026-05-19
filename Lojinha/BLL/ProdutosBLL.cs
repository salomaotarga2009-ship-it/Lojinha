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
        public void Incluir(ProdutosInformation produto)
        {
            //o nome 
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }
            //
            produto.Nome = produto.Nome.Trim();
            //
            ProdutosDAL obj = new ProdutosDAL();
            obj.Incluir(produto);
        }
        public void Alterar(ProdutosInformation produto)
        {
            //
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }
            //
            produto.Preco = produto.Preco;
            //
            ProdutosDAL obj = new ProdutosDAL();
            obj.Alterar(produto);
        }
        public void Excluir(int codigo)
        {
            if (codigo < 1)
            {
                throw new Exception("Selecione um cliente antes de excluir");
            }
            ProdutosDAL obj = new ProdutosDAL();
            obj.Excluir(codigo);
        }
        public DataTable Listagem(string filtro)
        {
            ProdutosDAL obj = new ProdutosDAL();
            return obj.Listagem(filtro);
        }
     }
}


