using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace RenatoEmbalagens.Camadas.DAL
{
   public  class Detalhe_Compras
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Detalhe_Compras> Select()
        {
            List<Model.Detalhe_Compras> lstDetalhe_Compras = new List<Model.Detalhe_Compras>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT  Detalhe_Compras.id, Detalhe_Compras.idCompras,Detalhe_Compras.idProdutos, Detalhe_Compras.Qtde, Detalhe_Compras.Total,  Detalhe_Compras.ValorPago, Produtos.Descricao FROM Detalhe_Compras ";
              sql += " INNER JOIN Produtos ON Produtos.idProdutos = Detalhe_Compras.idProdutos ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto    
                    Model.Detalhe_Compras detalhecompras = new Model.Detalhe_Compras();
                    //carregar os dado no objeto Detalhe_Compras   -- popular objeto
                    detalhecompras.id = Convert.ToInt32(reader["id"].ToString());
                    detalhecompras.idCompras = Convert.ToInt32(reader["idCompras"]); 
                    detalhecompras.idProdutos = Convert.ToInt32(reader["idProdutos"]);  
                    detalhecompras.Qtde = Convert.ToSingle(reader["Qtde"].ToString());
                    detalhecompras.Valor = Convert.ToSingle(reader["ValorPago"].ToString());
                    detalhecompras.Total = Convert.ToSingle(reader["Total"].ToString());
                    detalhecompras.Produtos = reader["Descricao"].ToString();

                    lstDetalhe_Compras.Add(detalhecompras);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Detalhe Compras....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstDetalhe_Compras;
        }


      

        public void Insert(Model.Detalhe_Compras detalhecompras)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Detalhe_Compras values (@idCompras ,@idProdutos, @Qtde, @ValorPago, @Total);";
           
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCompras", detalhecompras.idCompras);
            cmd.Parameters.AddWithValue("@idProdutos", detalhecompras.idProdutos);
            cmd.Parameters.AddWithValue("@Qtde", detalhecompras.Qtde);
            cmd.Parameters.AddWithValue("@ValorPago", detalhecompras.Valor);
            cmd.Parameters.AddWithValue("@Total", detalhecompras.Total);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de Detalhe Compras...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.Detalhe_Compras detalhecompras)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Detalhe_Compras set idCompras=@idCompras, idProdutos=@idProdutos, ";
            sql += "Qtde=@Qtde, Valor=@ValorPago, Total=@Total ";
            sql += " where idCompras=@idCompras;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCompras", detalhecompras.idCompras);
            cmd.Parameters.AddWithValue("@idProdutos", detalhecompras.idProdutos);
            cmd.Parameters.AddWithValue("@Qtde", detalhecompras.Qtde);
            cmd.Parameters.AddWithValue("@ValorPago", detalhecompras.Valor);
            cmd.Parameters.AddWithValue("@Total", detalhecompras.Total);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Detalhe Compras...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.Detalhe_Compras detalhecompras)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Detalhe_Compras where id=@id; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", detalhecompras.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro remocao Detalhe Compras");
            }
            finally
            {
                conexao.Close();
            }
        }




    }
}

