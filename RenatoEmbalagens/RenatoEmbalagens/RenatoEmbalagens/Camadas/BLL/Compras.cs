using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatoEmbalagens.Camadas.BLL
{
   public class Compras
    {
        public List<Model.Compras> Select()
        {
            DAL.Compras Compras = new DAL.Compras();

            return Compras.Select();
        }

        public void Insert(Model.Compras compras)
        {
            DAL.Compras Compras = new DAL.Compras();
            //
            Compras.Insert(compras);
        }

        public void Update(Model.Compras compras)
        {
            DAL.Compras Compras = new DAL.Compras();
            Compras.Update(compras);
        }

        public void Delete(Model.Compras compras)
        {
            DAL.Compras Compras = new DAL.Compras();

            Compras.Delete(compras);
        }
    }
}

