using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatoEmbalagens.Camadas.Model
{
  public  class Compras
    {
        public int idCompras { get; set; }
        public int idFornecedor { get; set; }
        public string Empresa { get; set; }
        public DateTime DataCompra { get; set; }
        
    }
}
