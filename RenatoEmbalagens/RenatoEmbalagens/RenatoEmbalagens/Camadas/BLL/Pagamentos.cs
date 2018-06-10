using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatoEmbalagens.Camadas.BLL
{
   public  class Pagamentos
    {
        public List<Model.Pagamentos> Select()
        {
            DAL.Pagamentos Pagamento = new DAL.Pagamentos();

            return Pagamento.Select();
        }

        public void Insert(Model.Pagamentos pagamento)
        {
            DAL.Pagamentos Pagamento = new DAL.Pagamentos();
            //
            Pagamento.Insert(pagamento);
        }

        public void Update(Model.Pagamentos pagamento)
        {
            DAL.Pagamentos Pagamento = new DAL.Pagamentos();
            Pagamento.Update(pagamento);
        }

        public void Delete(Model.Pagamentos pagamento)
        {
            DAL.Pagamentos Pagamento = new DAL.Pagamentos();

            Pagamento.Delete(pagamento);
        }
    }
}

