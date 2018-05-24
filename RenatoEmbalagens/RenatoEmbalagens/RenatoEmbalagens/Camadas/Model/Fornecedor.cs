using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatoEmbalagens.Camadas.Model
{
   public class Fornecedor
    {
        public int idFornecedor { get; set; }
       
        public string empresa { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }
}
