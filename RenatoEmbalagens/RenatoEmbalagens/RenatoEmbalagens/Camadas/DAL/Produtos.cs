using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RenatoEmbalagens.Camadas.DAL
{
   public class Produtos
    {
        private string strCon = Conexao.getConexao();
        public List<Model.Produtos> Select()
        {
            List<Model.Produtos> lstProdutos = new List<Model.Produtos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Produtos";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Produtos produtos = new Model.Produtos();
                    produtos.idProdutos = Convert.ToInt32(reader["idProdutos"]);
                    produtos.descricao = reader["Descricao"].ToString();
                    produtos.valorcompra = Convert.ToSingle(reader["ValorCompra"].ToString());
                    produtos.valorvenda = Convert.ToSingle(reader["ValorVenda"].ToString());
                    produtos.estoque = Convert.ToSingle(reader["Estoque"].ToString());

                    lstProdutos.Add(produtos);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de produtos...");
            }
            finally
            {
                conexao.Close();
            }

            return lstProdutos;
        }


        public List<Model.Produtos> SelectById(int idProdutos)
        {
            List<Model.Produtos> lstProdutos = new List<Model.Produtos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Produtos where idProdutos=@idProdutos;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idProdutos", idProdutos);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Produtos produtos = new Model.Produtos();
                    produtos.idProdutos = Convert.ToInt32(reader["idProdutos"]);
                    produtos.descricao = reader["Descricao"].ToString();
                    produtos.valorcompra = Convert.ToSingle(reader["ValorCompra"].ToString());
                    produtos.valorvenda = Convert.ToSingle(reader["ValorVenda"].ToString());
                    produtos.estoque = Convert.ToSingle(reader["Estoque"].ToString());

                    lstProdutos.Add(produtos);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de produtos...");
            }
            finally
            {
                conexao.Close();
            }

            return lstProdutos;
        }


        public List<Model.Produtos> SelectByDescricao(string descricao)
        {
            List<Model.Produtos> lstProdutos = new List<Model.Produtos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Produtos where(nome like @Descricao);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Descricao", descricao.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Produtos produtos = new Model.Produtos();
                    produtos.idProdutos = Convert.ToInt32(reader["idProdutos"]);
                    produtos.descricao = reader["Descricao"].ToString();
                    produtos.valorcompra = Convert.ToSingle(reader["ValorCompra"].ToString());
                    produtos.valorvenda = Convert.ToSingle(reader["ValorVenda"].ToString());
                    produtos.estoque = Convert.ToSingle(reader["Estoque"].ToString());

                    lstProdutos.Add(produtos);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de produtos...");
            }
            finally
            {
                conexao.Close();
            }

            return lstProdutos;
        }


        public List<Model.Produtos> SelectByEstoque(string estoque)
        {
            List<Model.Produtos> lstProdutos = new List<Model.Produtos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Produtos where(estoque like @Estoque);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Estoque", estoque.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Produtos produtos = new Model.Produtos();
                    produtos.idProdutos = Convert.ToInt32(reader["idProdutos"]);
                    produtos.descricao = reader["Descricao"].ToString();
                    produtos.valorcompra = Convert.ToSingle(reader["ValorCompra"].ToString());
                    produtos.valorvenda = Convert.ToSingle(reader["ValorVenda"].ToString());
                    produtos.estoque = Convert.ToSingle(reader["Estoque"].ToString());

                    lstProdutos.Add(produtos);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de produtos...");
            }
            finally
            {
                conexao.Close();
            }

            return lstProdutos;
        }




        public void Insert(Model.Produtos produtos)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "insert into Produtos values ";
            sql = sql + " (@Descricao, @ValorCompra, @ValorVenda, @Estoque);  ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Descricao", produtos.descricao);
            cmd.Parameters.AddWithValue("@ValorCompra", produtos.valorcompra);
            cmd.Parameters.AddWithValue("@ValorVenda", produtos.valorvenda);
            cmd.Parameters.AddWithValue("@Estoque", produtos.estoque);
           
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro em inserir um  produto");
            }
            finally
            {
                conexao.Close();
            }


        }

        public void Update(Model.Produtos produtos
            )
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Produtos set descricao=@Descricao, valorcompra=@ValorCompra, valorvenda=@ValorVenda, estoque=@Estoque ";
            sql = sql + " where idProdutos=@idProdutos;  ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idProdutos", produtos.idProdutos);
            cmd.Parameters.AddWithValue("@Descricao", produtos.descricao);
            cmd.Parameters.AddWithValue("@ValorCompra", produtos.valorcompra);
            cmd.Parameters.AddWithValue("@ValorVenda", produtos.valorvenda);
            cmd.Parameters.AddWithValue("@Estoque", produtos.estoque);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro em editar um  produtos");
            }
            finally
            {
                conexao.Close();
            }


        }


        public void Delete(Model.Produtos produtos)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Produtos where idProdutos=@idProdutos";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idProdutos", produtos.idProdutos);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao deletar um  produtos");
            }
            finally
            {
                conexao.Close();
            }


        }
    }
}
