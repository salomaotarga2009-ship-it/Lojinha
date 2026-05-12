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
        public void Incluir(ProdutosInformation produtos)
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

                SqlParameter ppreco = new SqlParameter("@preco", SqlDbType.VarChar, 100);
                ppreco.Value = produtos.Preco;
                cmd.Parameters.Add(ppreco);

                SqlParameter pestoque = new SqlParameter("@estoque", SqlDbType.VarChar, 100);
                pestoque.Value = produtos.Estoque;
                cmd.Parameters.Add(pestoque);

                cn.Open();
                cmd.ExecuteNonQuery();

                produtos.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
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
        public void Alterar(ProdutosInformation produtos)
        {
            //Conexão com o banco de dados 
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "altera_produtos";
                //Parametros Da Stored Procedure
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.VarChar, 100);
                pnome.Value = produtos.Nome;
                cmd.Parameters.Add(pnome);

                SqlParameter ppreco = new SqlParameter("@preco", SqlDbType.VarChar, 100);
                ppreco.Value = produtos.Preco;
                cmd.Parameters.Add(ppreco);

                SqlParameter pestoque = new SqlParameter("@estoque", SqlDbType.VarChar, 100);
                pestoque.Value = produtos.Estoque;
                cmd.Parameters.Add(pestoque);

                cn.Open();
                cmd.ExecuteNonQuery();

                produtos.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
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
        public void Excluir(int codigo)
        {
            //Conexão com o banco de dados 
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "exclui_produtos";
                //Parametros Da Stored Procedure
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Value = codigo;
                cmd.Parameters.Add(pcodigo);
                cn.Open();
                cmd.ExecuteNonQuery();
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
        public DataTable Listagem(string filtro)
        {
            //Conexão com o banco de dados 
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "seleciona_produtos";
                //Parametros Da Stored Procedure
                SqlParameter pfiltro = new SqlParameter("@filtro", SqlDbType.VarChar);
                pfiltro.Value = filtro;
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabela);
                return tabela;
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
