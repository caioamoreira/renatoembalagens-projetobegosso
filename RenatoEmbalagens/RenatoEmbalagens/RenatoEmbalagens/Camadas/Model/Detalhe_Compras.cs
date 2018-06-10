using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatoEmbalagens.Camadas.Model
{
   public  class Detalhe_Compras
    {
        public int id { get; set; }
        public int idCompras { get; set; }
     
        public int idProdutos { get; set; }
        public string Produtos { get; set; }
        public float Qtde { get; set; }
        public float Valor { get; set; }
        public float Total { get; set; }

    }
}
