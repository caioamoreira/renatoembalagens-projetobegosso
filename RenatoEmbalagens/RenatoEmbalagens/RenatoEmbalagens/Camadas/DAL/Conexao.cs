using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatoEmbalagens.Camadas.DAL
{
   public  class Conexao
    {
      public  static string getConexao()
        {
            return @"Data Source=LAPTOP-J9GJ4JN1\SQLEXPRESS;Initial Catalog=RenatoEmbalagens;Integrated Security=True";
        }
    }
}
