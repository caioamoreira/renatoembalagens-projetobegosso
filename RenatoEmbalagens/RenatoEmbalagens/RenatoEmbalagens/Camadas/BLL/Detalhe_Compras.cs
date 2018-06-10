using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatoEmbalagens.Camadas.BLL
{
  public  class Detalhe_Compras
    {
        public List<Model.Detalhe_Compras> Select()
        {
            DAL.Detalhe_Compras daldetalhecompras = new DAL.Detalhe_Compras();
            //regras de negócio caso existam
            return daldetalhecompras.Select();
        }



        public void Insert(Model.Detalhe_Compras detalhecompras)
        {
            DAL.Detalhe_Compras daldetalhecompras = new DAL.Detalhe_Compras();
            //regras de negócio caso existam
            daldetalhecompras.Insert(detalhecompras);
        }

        public void Update(Model.Detalhe_Compras detalhecompras)
        {
            DAL.Detalhe_Compras daldetalhecompras = new DAL.Detalhe_Compras();
            daldetalhecompras.Update(detalhecompras);
        }

        public void Delete(Model.Detalhe_Compras detalhecompras)
        {
            DAL.Detalhe_Compras daldetalhecompras = new DAL.Detalhe_Compras();
            daldetalhecompras.Delete(detalhecompras);
        }
    }
}
