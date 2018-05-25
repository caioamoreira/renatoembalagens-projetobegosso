using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RenatoEmbalagens.Camadas.DAL
{
    public class Fornecedor
    {
        private string strCon = Conexao.getConexao();
        public List<Model.Fornecedor> Select()
        {
            List<Model.Fornecedor> lstFornecedores = new List<Model.Fornecedor>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Fornecedor";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Fornecedor fornecedor = new Model.Fornecedor();
                    fornecedor.idFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                    fornecedor.empresa = reader["Empresa"].ToString();
                    fornecedor.endereco = reader["Endereco"].ToString();
                    fornecedor.telefone = reader["Telefone"].ToString();
                   
                    fornecedor.cidade = reader["Cidade"].ToString();
                    fornecedor.estado = reader["Estado"].ToString();
                    lstFornecedores.Add(fornecedor);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de fornecedor...");
            }
            finally
            {
                conexao.Close();
            }

            return lstFornecedores;
        }


        public List<Model.Fornecedor> SelectById(int idFornecedor)
        {
            List<Model.Fornecedor> lstFornecedores = new List<Model.Fornecedor>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Fornecedor where idFornecedor=@idFornecedor;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idFornecedor", idFornecedor);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Fornecedor fornecedor = new Model.Fornecedor();
                    fornecedor.idFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                    fornecedor.empresa = reader["Empresa"].ToString();
                    fornecedor.endereco = reader["Endereco"].ToString();
                    fornecedor.telefone = reader["Telefone"].ToString();

                    fornecedor.cidade = reader["Cidade"].ToString();
                    fornecedor.estado = reader["Estado"].ToString();
                    lstFornecedores.Add(fornecedor);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de fornecedores...");
            }
            finally
            {
                conexao.Close();
            }

            return lstFornecedores;
        }


        public List<Model.Fornecedor> SelectByEmpresa(string empresa)
        {
            List<Model.Fornecedor> lstFornecedores = new List<Model.Fornecedor>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Fornecedor where(empresa like @Empresa);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Empresa", empresa.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Fornecedor fornecedor = new Model.Fornecedor();
                    fornecedor.idFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                    fornecedor.empresa = reader["Empresa"].ToString();
                    fornecedor.endereco = reader["Endereco"].ToString();
                    fornecedor.telefone = reader["Telefone"].ToString();

                    fornecedor.cidade = reader["Cidade"].ToString();
                    fornecedor.estado = reader["Estado"].ToString();
                    lstFornecedores.Add(fornecedor);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de fornecedores...");
            }
            finally
            {
                conexao.Close();
            }

            return lstFornecedores;
        }


        public List<Model.Fornecedor> SelectByCidade(string cidade)
        {
            List<Model.Fornecedor> lstFornecedores = new List<Model.Fornecedor>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Fornecedor where(cidade like @Cidade);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Cidade", cidade.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Fornecedor fornecedor = new Model.Fornecedor();
                    fornecedor.idFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                    fornecedor.empresa = reader["Empresa"].ToString();
                    fornecedor.endereco = reader["Endereco"].ToString();
                    fornecedor.telefone = reader["Telefone"].ToString();

                    fornecedor.cidade = reader["Cidade"].ToString();
                    fornecedor.estado = reader["Estado"].ToString();
                    lstFornecedores.Add(fornecedor);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de fornecedor...");
            }
            finally
            {
                conexao.Close();
            }

            return lstFornecedores;
        }




        public void Insert(Model.Fornecedor fornecedor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "insert into Fornecedor values ";
            sql = sql + " (@Empresa, @Endereco, @Telefone,  @Cidade , @Estado);  ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Empresa", fornecedor.empresa);
            cmd.Parameters.AddWithValue("@Endereco", fornecedor.endereco);
            cmd.Parameters.AddWithValue("@Telefone", fornecedor.telefone);
        
            cmd.Parameters.AddWithValue("@Cidade", fornecedor.cidade);
            cmd.Parameters.AddWithValue("@Estado", fornecedor.estado);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro em inserir um  fornecedor");
            }
            finally
            {
                conexao.Close();
            }


        }

        public void Update(Model.Fornecedor fornecedor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Fornecedor set Empresa=@Empresa, endereco=@Endereco, telefone=@Telefone,cidade=@Cidade, estado=@Estado ";
            sql = sql + " where idFornecedor=@idFornecedor;  ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idFornecedor", fornecedor.idFornecedor);
            cmd.Parameters.AddWithValue("@Empresa", fornecedor.empresa);
            cmd.Parameters.AddWithValue("@Endereco", fornecedor.endereco);
            cmd.Parameters.AddWithValue("@Telefone", fornecedor.telefone);
            
            cmd.Parameters.AddWithValue("@Cidade", fornecedor.cidade);
            cmd.Parameters.AddWithValue("@Estado", fornecedor.estado);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro em editar um  fornecedor");
            }
            finally
            {
                conexao.Close();
            }


        }


        public void Delete(Model.Fornecedor fornecedor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Fornecedor where idFornecedor=@idFornecedor";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idFornecedor", fornecedor.idFornecedor);

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao deletar um  fornecedor");
            }
            finally
            {
                conexao.Close();
            }


        }
    }
}
