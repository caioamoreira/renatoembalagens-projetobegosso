using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatoEmbalagens.Camadas.DAL
{
   public class Compras
    {

        private string strCon = Conexao.getConexao();


        public List<Model.Compras> Select()
        {
            List<Model.Compras> lstCompras = new List<Model.Compras>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select Compras.idCompras, Compras.idFornecedor, Compras.DataCompra, Fornecedor.Empresa from Compras inner join Fornecedor on (Fornecedor.idFornecedor=Compras.idFornecedor);"; // pode dar erro
            //string sql = "select  * from Vendas;"; // pode dar erro
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Vendas     
                    Model.Compras compras = new Model.Compras();
                    //carregar os dado no objeto Vendas -- popular objeto
                    compras.idCompras = Convert.ToInt32(reader["idCompras"]);
                    compras.DataCompra = Convert.ToDateTime(reader["DataCompra"].ToString());
                    compras.idFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                    compras.Empresa = reader["Empresa"].ToString();
                    lstCompras.Add(compras);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Compras....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstCompras;
        }

        public List<Model.Compras> SelectById(int idCompras)
        {
            List<Model.Compras> lstCompras = new List<Model.Compras>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Compras where idCompras=@idCompras;";// pode dar erro
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCompras", idCompras);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Vendas    
                    Model.Compras compras = new Model.Compras();
                    //carregar os dado no objeto Vendas -- popular objeto
                    compras.idCompras = Convert.ToInt32(reader["idCompras"]);
                    compras.idFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                    compras.DataCompra = Convert.ToDateTime(reader["DataCompra"].ToString());
                    compras.Empresa = reader["Empresa"].ToString();
                    lstCompras.Add(compras);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Compras....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstCompras;
        }


        


        public void Insert(Model.Compras compras)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Compras values ";
            sql = sql + " (@idFornecedor, @DataCompra );";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idFornecedor", compras.idFornecedor);
            cmd.Parameters.AddWithValue("@DataCompra", compras.DataCompra);
   //         cmd.Parameters.AddWithValue("@Empresa", compras.Empresa);


            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de Compras...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.Compras compras)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Compras set idFornecedor=@idFornecedor, DataCompra=@dataCompra, Empresa=@Empresa ";
            sql += " where idCompra=@idCompra;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idFornecedor", compras.idFornecedor);
            cmd.Parameters.AddWithValue("@DataCompra", compras.DataCompra);
            cmd.Parameters.AddWithValue("@Empresa", compras.Empresa);
            cmd.Parameters.AddWithValue("@idCompras", compras.idCompras);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Vendas...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.Compras compras)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Vendas where idCompras=@idCompras; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCompras", compras.idCompras);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro remocao Vendas");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

