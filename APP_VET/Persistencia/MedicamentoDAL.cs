using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class MedicamentoDAL
    {
        private EFContext context;

        public IList<Medicamento> TodosOsMedicamentos()
        {
            using (var context = new EFContext())
            {
                return context.Medicamentos.ToList<Medicamento>();
            }
        }
        public IList<Medicamento> DescricaoMedicamentos()
        {
            using (var context = new EFContext())
            {
                return context.Medicamentos.FromSql("SELECT MedicamentoId,Descricao FROM Medicamentos").ToList();
            }
        }

        public void GravarMedicamento(Medicamento medicamento)
        {
            using (var context = new EFContext())
            {
                context.Medicamentos.Add(medicamento);
                context.SaveChanges();
            }
        }

        public void ExcluirMedicamento(int id)
        {
            using (var context = new EFContext())
            {
                var medicamento = new Medicamento { MedicamentoId = id };
                context.Medicamentos.Remove(medicamento);
                context.SaveChanges();
            }
        }
        public void EditarMedicamento(Medicamento medicamento)
        {
            using (var context = new EFContext())
            {
                context.Update(medicamento);
                context.SaveChanges();
            }
        }

    }
}
