using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatoEmbalagens.Camadas.BLL
{
    public class Cliente
    {
        public List<Model.Cliente> Select()
        {
            DAL.Cliente dalCli = new DAL.Cliente();

            //regras de negocios serao inseridas posteriormente

            return dalCli.Select();
        }

        public List<Model.Cliente> SelectByIdCliente(int idCliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();

            //regras de negocios serao inseridas posteriormente

            return dalCli.SelectById(idCliente);
        }

        public List<Model.Cliente> SelectByNome(string nome)
        {
            DAL.Cliente dalCli = new DAL.Cliente();

            //regras de negocios serao inseridas posteriormente

            return dalCli.SelectByNome(nome);
        }

        public List<Model.Cliente> SelectByCidade(string cidade)
        {
            DAL.Cliente dalCli = new DAL.Cliente();

            //regras de negocios serao inseridas posteriormente

            return dalCli.SelectByCidade(cidade);
        }



        public void Insert (Model.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            //regras de negocio
            dalCli.Insert(cliente);
        }

        public void Update (Model.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            dalCli.Update(cliente);
        }

        public void Delete (Model.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            dalCli.Delete(cliente);
        }


    }
}
