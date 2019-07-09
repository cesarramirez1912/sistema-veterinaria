using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using Persistencia;

namespace Servico
{
    public class AnimalServico
    {
        private AnimalDAL animalDAL = new AnimalDAL();

        public IList<Animal> TodosOsAnimais()
        {
            return animalDAL.TodosOsAnimais();
        }

        public IList<Animal> FiltrarPorNomeAnimal(string nome)
        {
            return animalDAL.FiltrarPorNomeAnimal(nome);
        }

        public IList<Animal> ObterPorId(long animalID)
        {
            return animalDAL.ObterPorId(animalID);
        }

        public void GravarAnimal(Animal animal)
        {
            animalDAL.GravarAnimal(animal);
        }

        public void ExcluirAnimal(string id)
        {
            animalDAL.ExluirAnimal(Convert.ToInt32(id));
        }

        public void EditarAnimal(Animal animal)
        {
            animalDAL.EditarAnimal(animal);
        }
    }
}
