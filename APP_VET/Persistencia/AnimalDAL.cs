using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Modelo;

namespace Persistencia
{
    public class AnimalDAL
    {
        private EFContext context;
        
        public IList<Animal> TodosOsAnimais()
        {
            using (var context = new EFContext())
            {
                return context.Animais.ToList<Animal>();
            }
        }

        public IList<Animal> FiltrarPorNomeAnimal(string nome)
        {
            using (var context = new EFContext())
            {
                return context.Animais.Where(a => a.Nome.Contains(nome)).ToList();
            }
        }

        public IList<Animal> ObterPorId(long animalID)
        {
            using (var context = new EFContext())
            {
                return context.Animais.Where(d => d.ClienteId == animalID).ToList();
            }
        }


            public void GravarAnimal(Animal Animal)
        {
            using (var context = new EFContext())
            {
                context.Animais.Add(Animal);
                context.SaveChanges();
            }
        }

        public void ExluirAnimal(int id)
        {
            using (var context = new EFContext())
            {
                var Animal = new Animal { AnimalId = id };
                context.Animais.Remove(Animal);
                context.SaveChanges();
            }
        }

        public void EditarAnimal(Animal Animal)
        {
            using (var context = new EFContext())
            {
                context.Animais.Update(Animal);
                context.SaveChanges();
            }
        }
    }
    
}
