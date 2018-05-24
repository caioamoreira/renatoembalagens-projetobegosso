using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatoEmbalagens.Camadas.BLL
{
   public class Produtos
    {
        public List<Model.Produtos> Select()
        {
            DAL.Produtos dalPro = new DAL.Produtos();

            //regras de negocios serao inseridas posteriormente

            return dalPro.Select();
        }

        public List<Model.Produtos> SelectById(int idProdutos)
        {
            DAL.Produtos dalPro = new DAL.Produtos();

            //regras de negocios serao inseridas posteriormente

            return dalPro.SelectById(idProdutos);
        }

        public List<Model.Produtos> SelectByDescricao(string descricao)
        {
            DAL.Produtos dalPro = new DAL.Produtos();

            //regras de negocios serao inseridas posteriormente

            return dalPro.SelectByDescricao(descricao);
        }

        public List<Model.Produtos> SelectByEstoque(string estoque)
        {
            DAL.Produtos dalPro = new DAL.Produtos();

            //regras de negocios serao inseridas posteriormente

            return dalPro.SelectByEstoque(estoque);
        }



        public void Insert(Model.Produtos produtos)
        {
            DAL.Produtos dalPro = new DAL.Produtos();
            //regras de negocio
            dalPro.Insert(produtos);
        }

        public void Update(Model.Produtos produtos)
        {
            DAL.Produtos dalPro = new DAL.Produtos();
            dalPro.Update(produtos);
        }

        public void Delete(Model.Produtos produtos)
        {
            DAL.Produtos dalPro = new DAL.Produtos();
            dalPro.Delete(produtos);
        }
    }
}
