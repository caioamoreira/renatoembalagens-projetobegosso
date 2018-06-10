using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RenatoEmbalagens.Camadas.DAL
{
   public  class Pagamentos
    {
        private string strCon = Conexao.getConexao();


        public List<Model.Pagamentos> Select()
        {
            List<Model.Pagamentos> lstPagamento = new List<Model.Pagamentos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select Pagamento.idPagamento, Compras.idCompras, Pagamento.Parcela, Pagamento.DataVencimento , Pagamento.Valor , Pagamento.Pago  from Pagamento inner join Compras on Compras.idCompras=Pagamento.idCompras;"; // pode dar erro
            //string sql = "select  * from Vendas;"; // pode dar erro
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Vendas     
                    Model.Pagamentos pagamentos = new Model.Pagamentos();
                    //carregar os dado no objeto Vendas -- popular objeto
                    pagamentos.idPagamento = Convert.ToInt32(reader["idPagamento"]);
                    pagamentos.idCompras = Convert.ToInt32(reader["idCompras"]);
                    pagamentos.Parcela = Convert.ToInt32(reader["Parcela"]);
                    pagamentos.Vencimento = Convert.ToDateTime(reader["DataVencimento"].ToString());
                    pagamentos.Valor = Convert.ToSingle(reader["Valor"].ToString());
                    pagamentos.Pago = Convert.ToChar(reader["Pago"].ToString());
                    lstPagamento.Add(pagamentos);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Pagamento....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstPagamento;
        }


        public List<Model.Pagamentos> SelectById(int idPagamento)
        {
            List<Model.Pagamentos> lstPagamento = new List<Model.Pagamentos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Pagamentos where idPagamento=@idPagamento;";// pode dar erro
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idPagamento", idPagamento);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Vendas    
                    Model.Pagamentos pagamentos = new Model.Pagamentos();
                    //carregar os dado no objeto Vendas -- popular objeto
                    pagamentos.idPagamento = Convert.ToInt32(reader["idPagamento"]);
                    pagamentos.idCompras = Convert.ToInt32(reader["idCompras"]);
                    pagamentos.Parcela = Convert.ToInt32(reader["Parcela"]);
                    pagamentos.Vencimento = Convert.ToDateTime(reader["DataVencimento"].ToString());
                    pagamentos.Valor = Convert.ToSingle(reader["Valor"].ToString());
                    pagamentos.Pago = Convert.ToChar(reader["Pago"].ToString());
                    lstPagamento.Add(pagamentos);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Pagamento....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstPagamento;
        }


      

        public void Insert(Model.Pagamentos pagamento)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Pagamento values ";
            sql = sql + " (@idCompras, @Parcela , @DataVencimento , @Valor , @Pago);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCompras", pagamento.idCompras);
            cmd.Parameters.AddWithValue("@Parcela", pagamento.Parcela);
            cmd.Parameters.AddWithValue("@DataVencimento", pagamento.Vencimento);
            cmd.Parameters.AddWithValue("@Valor", pagamento.Valor);
            cmd.Parameters.AddWithValue("@Pago", pagamento.Pago);


            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de Pagamento...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.Pagamentos pagamento)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Pagamento set idCompras@idCompras, Parcela=@Parcela, DataVencimento=@DataVencimento, Valor=@Valor , Pago=@Pago ";
            sql += " where idPagamento=@idPagamento;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCompras", pagamento.idCompras);
            cmd.Parameters.AddWithValue("@Parcela", pagamento.Parcela);
            cmd.Parameters.AddWithValue("@DataVencimento", pagamento.Vencimento);
            cmd.Parameters.AddWithValue("@Valor", pagamento.Valor);
            cmd.Parameters.AddWithValue("@Pago", pagamento.Pago);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Pagamentos...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.Pagamentos pagamento)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Pagamento where idPagamento=@idPagamento; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idPagamento", pagamento.idPagamento);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro remocao de Pagamento");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

