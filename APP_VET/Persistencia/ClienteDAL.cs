using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class ClienteDAL
    {
        private EFContext context;

        public IList<Cliente> TodosOsClientes()
        {
            using (var context = new EFContext())
            {
                return context.Clientes.ToList<Cliente>();
            }
        }

        public IList<Cliente> NomeTodosOsClientes()
        {
            using (var context = new EFContext())
            {
                return context.Clientes.ToList<Cliente>();
            }
        }

        public IList<Cliente> FiltrarPorNome(string nome)
        {
            using (var context = new EFContext())
            {
                return context.Clientes.Where(c => c.Nome.Contains(nome)).ToList(); 
            }
        }


        public long GravarCliente(Cliente cliente)
        {
            using (var context = new EFContext())
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
                return cliente.ClienteId;
            }
        }

        public void ExluirCliente(int id)
        {
            using (var context = new EFContext())
            {
                var cliente = new Cliente { ClienteId = id };
                context.Clientes.Remove(cliente);
                context.SaveChanges();
            }
        }
        public void EditarCliente(Cliente cliente)
        {
            using (var context = new EFContext())
            {
                context.Update(cliente);
                context.SaveChanges();
            }
        }

    }
}
