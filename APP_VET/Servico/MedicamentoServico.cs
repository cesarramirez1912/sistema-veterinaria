using System;
using System.Collections.Generic;
using System.Text;
using Persistencia;
using Modelo;

namespace Servico
{
   public class MedicamentoServico
    {
        private MedicamentoDAL medicamentoDAL = new MedicamentoDAL();

        public IList<Medicamento> TodosOsMedicamentos()
        {
            using (var context = new EFContext())
            {
                return medicamentoDAL.TodosOsMedicamentos();
            }
        }

        public IList<Medicamento> DescricaoMedicamentos()
        {
            return medicamentoDAL.DescricaoMedicamentos();
        }

        public void GravarMedicamento(Medicamento medicamento)
        {
            medicamentoDAL.GravarMedicamento(medicamento); 
        }

        public void ExcluirMedicamento(int id)
        {
            medicamentoDAL.ExcluirMedicamento(id);
        }

        public void EditarMedicamento(Medicamento medicamento)
        {
            medicamentoDAL.EditarMedicamento(medicamento);
        }
    }
}
