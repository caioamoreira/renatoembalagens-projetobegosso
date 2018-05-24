using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatoEmbalagens.Camadas.BLL
{
   public class Fornecedor
    {
        public List<Model.Fornecedor> Select()
        {
            DAL.Fornecedor dalFor = new DAL.Fornecedor();

            //regras de negocios serao inseridas posteriormente

            return dalFor.Select();
        }

        public List<Model.Fornecedor> SelectById(int idFornecedor)
        {
            DAL.Fornecedor dalFor = new DAL.Fornecedor();

            //regras de negocios serao inseridas posteriormente

            return dalFor.SelectById(idFornecedor);
        }

        public List<Model.Fornecedor> SelectByEmpresa(string empresa)
        {
            DAL.Fornecedor dalFor = new DAL.Fornecedor();

            //regras de negocios serao inseridas posteriormente

            return dalFor.SelectByEmpresa(empresa);
        }

        public List<Model.Fornecedor> SelectByCidade(string cidade)
        {
            DAL.Fornecedor dalFor = new DAL.Fornecedor();

            //regras de negocios serao inseridas posteriormente

            return dalFor.SelectByCidade(cidade);
        }



        public void Insert(Model.Fornecedor fornecedor)
        {
            DAL.Fornecedor dalFor = new DAL.Fornecedor();
            //regras de negocio
            dalFor.Insert(fornecedor);
        }

        public void Update(Model.Fornecedor fornecedor)
        {
            DAL.Fornecedor dalFor = new DAL.Fornecedor();
            dalFor.Update(fornecedor);
        }

        public void Delete(Model.Fornecedor fornecedor)
        {
            DAL.Fornecedor dalFor = new DAL.Fornecedor();
            dalFor.Delete(fornecedor);
        }

    }
}
