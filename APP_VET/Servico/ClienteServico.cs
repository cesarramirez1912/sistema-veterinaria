using System;
using System.Collections.Generic;
using System.Text;
using Persistencia;
using Modelo;

namespace Servico
{
    public class ClienteServico
    {
        private ClienteDAL clienteDAL = new ClienteDAL();

        public IList<Cliente> TodosOsClientes()
        {
            return clienteDAL.TodosOsClientes();
        }


        public IList<Cliente> FiltrarPorNome(string nome)
        {
            return clienteDAL.FiltrarPorNome(nome);
        }


        public long GravarCliente(Cliente cliente)
        {
           return clienteDAL.GravarCliente(cliente);
        }

        public void ExcluirCliente(string id)
        {
            clienteDAL.ExluirCliente(Convert.ToInt32(id));
        }

        public void EditarCliente(Cliente cliente){
            clienteDAL.EditarCliente(cliente);
        }

  }
}