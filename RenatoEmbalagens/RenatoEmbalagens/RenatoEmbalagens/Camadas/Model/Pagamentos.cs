using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatoEmbalagens.Camadas.Model
{
    public class Pagamentos
    {
        public int idPagamento { get; set; }
        public int idCompras { get; set; }
        public int Parcela { get; set; }
        public DateTime Vencimento { get; set; }
        public float Valor { get; set; }
        public char Pago { get; set; }
      
    }
}
