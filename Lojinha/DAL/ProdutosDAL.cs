using Lojinha.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.DAL
{
    public class ProdutosDAL
    {
        public void Incluir(ClienteInformation produtos)
        {
            //Conexão com o banco de dados 
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insere_produtos";
                //Parametros Da Stored Procedure
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.VarChar, 100);
                pnome.Value = produtos.Nome;
                cmd.Parameters.Add(pnome);

                SqlParameter pemail = new SqlParameter("@email", SqlDbType.VarChar, 100);
                pemail.Value = produtos.Preco;
                cmd.Parameters.Add(pnome);

                SqlParameter ptelefone = new SqlParameter("@estoque", SqlDbType.VarChar, 100);
                ptelefone.Value = produtos.Estoque;
                cmd.Parameters.Add(pnome);

                cn.Open();
                cmd.ExecuteNonQuery();

                cliente.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao acessa banco de dados. " + ex.Number);
            }
            catch
            {
                throw new Exception("Erro desconhecido ao acessar banco de dados. ");
            }
            finally
            {
                cn.Close();
            }




        }



    }
}
