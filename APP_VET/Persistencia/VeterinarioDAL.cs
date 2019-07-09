using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using System.Linq;

namespace Persistencia
{
    public class VeterinarioDAL
    {
        private EFContext context;

        public IList<Veterinario> TodosOsVeterinarios()
        {
            using (var context = new EFContext())
            {
                return context.Veterinarios.ToList<Veterinario>();
            }
        }

        public void GravarVeterinario(Veterinario veterinario)
        {
            using (var context = new EFContext())
            {
                context.Veterinarios.Add(veterinario);
                context.SaveChanges();
            }
        }

        public void ExluirVeterinario(int id)
        {
            using (var context = new EFContext())
            {
                var veterinario = new Veterinario { VeterinarioId = id };
                context.Veterinarios.Remove(veterinario);
                context.SaveChanges();
            }
        }
        public void EditarVeterinario(Veterinario veterinario)
        {
            using (var context = new EFContext())
            {
                context.Update(veterinario);
                context.SaveChanges();
            }
        }

    }
}
