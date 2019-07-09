using System;
using System.Collections.Generic;
using System.Text;
using Persistencia;
using Modelo;

namespace Servico
{
    public class VeterinarioServico
    {
        private VeterinarioDAL veterinarioDal = new VeterinarioDAL();

        public IList<Veterinario> TodosOsVeterinarios()
        {
            return veterinarioDal.TodosOsVeterinarios();
        }

        //public Cliente ObterClienteId(long id)
        // {
        //     return clienteDAL.ObterPorId(id);
        // }

        public void GravarVeterinario(Veterinario veterinario)
        {
             veterinarioDal.GravarVeterinario(veterinario);
        }

        public void ExcluirVeterinario(string id)
        {
            veterinarioDal.ExluirVeterinario(Convert.ToInt32(id));
        }
        public void EditarVeterinario(Veterinario veterinario)
        {
            veterinarioDal.EditarVeterinario(veterinario);
        }

    }
}