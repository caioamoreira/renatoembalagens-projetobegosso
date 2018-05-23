using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RenatoEmbalagens.Camadas.DAL
{
   public class Cliente
    {
        private string strCon = Conexao.getConexao();
        public List<Model.Cliente> Select()
        {
            List<Model.Cliente> lstClientes = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Cliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.idCliente = Convert.ToInt32(reader["idCliente"]);
                    cliente.nome = reader["Nome"].ToString();
                    cliente.endereco = reader["Endereco"].ToString();
                    cliente.telefone = reader["Telefone"].ToString();
                    cliente.celular = reader["Celular"].ToString();
                    cliente.cidade = reader["Cidade"].ToString();
                    cliente.estado = reader["Estado"].ToString();
                    lstClientes.Add(cliente);
                }
            }           
            catch
            {
                Console.WriteLine("Erro na consulta de clientes...");
            }
            finally
            {
                conexao.Close();
            }

            return lstClientes;
        }


        public List<Model.Cliente> SelectById(int idCliente)
        {
            List<Model.Cliente> lstClientes = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Cliente where idCliente=@idCliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.idCliente = Convert.ToInt32(reader["idCliente"]);
                    cliente.nome = reader["Nome"].ToString();
                    cliente.endereco = reader["Endereco"].ToString();
                    cliente.telefone = reader["Telefone"].ToString();
                    cliente.celular = reader["Celular"].ToString();
                    cliente.cidade = reader["Cidade"].ToString();
                    cliente.estado = reader["Estado"].ToString();
                    lstClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de clientes...");
            }
            finally
            {
                conexao.Close();
            }

            return lstClientes;
        }


        public List<Model.Cliente> SelectByNome(string nome)
        {
            List<Model.Cliente> lstClientes = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Cliente where(nome like @Nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Nome", nome.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.idCliente = Convert.ToInt32(reader["idCliente"]);
                    cliente.nome = reader["Nome"].ToString();
                    cliente.endereco = reader["Endereco"].ToString();
                    cliente.telefone = reader["Telefone"].ToString();
                    cliente.celular = reader["Celular"].ToString();
                    cliente.cidade = reader["Cidade"].ToString();
                    cliente.estado = reader["Estado"].ToString();
                    lstClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de clientes...");
            }
            finally
            {
                conexao.Close();
            }

            return lstClientes;
        }


        public List<Model.Cliente> SelectByCidade(string cidade)
        {
            List<Model.Cliente> lstClientes = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Cliente where(cidade like @Cidade);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Cidade", cidade.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.idCliente = Convert.ToInt32(reader["idCliente"]);
                    cliente.nome = reader["Nome"].ToString();
                    cliente.endereco = reader["Endereco"].ToString();
                    cliente.telefone = reader["Telefone"].ToString();
                    cliente.celular = reader["Celular"].ToString();
                    cliente.cidade = reader["Cidade"].ToString();
                    cliente.estado = reader["Estado"].ToString();
                    lstClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de clientes...");
            }
            finally
            {
                conexao.Close();
            }

            return lstClientes;
        }


        

        public void Insert(Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "insert into Cliente values ";
            sql = sql + " (@Nome, @Endereco, @Telefone, @Celular, @Cidade , @Estado);  ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Nome", cliente.nome);
            cmd.Parameters.AddWithValue("@Endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@Telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@Celular", cliente.celular);
            cmd.Parameters.AddWithValue("@Cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@Estado", cliente.estado);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro em inserir um  cliente");
            }
            finally
            {
                conexao.Close();
            }


        }

        public void Update(Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Cliente set nome=@Nome, endereco=@Endereco, telefone=@Telefone, celular=@Celular,cidade=@Cidade, estado=@Estado ";
            sql = sql + " where idCliente=@idCliente;  ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", cliente.idCliente);
            cmd.Parameters.AddWithValue("@Nome", cliente.nome);
            cmd.Parameters.AddWithValue("@Endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@Telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@Celular", cliente.celular);
            cmd.Parameters.AddWithValue("@Cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@Estado", cliente.estado);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro em editar um  cliente");
            }
            finally
            {
                conexao.Close();
            }


        }


        public void Delete (Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Cliente where idCliente=@idCliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", cliente.idCliente);
           
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao deletar um  cliente");
            }
            finally
            {
                conexao.Close();
            }


        }

    }
}
