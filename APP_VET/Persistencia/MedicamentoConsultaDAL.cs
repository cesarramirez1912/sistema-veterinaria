using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using System.Linq;

namespace Persistencia
{
    public class MedicamentoConsultaDAL
    {
        private EFContext context;

        public IList<ConsultaMedicamento> TodasAsConsultasMedicamentosPorId(long consultaId)
        {
            using (var context = new EFContext())
            {
                return context.ConsultasMedicamentos.Where(d => d.ConsultaId == consultaId).ToList<ConsultaMedicamento>();
            }
        }
  

        public void GravarConsultaMedicamento(ConsultaMedicamento consultaMedicamento)
        {
            using (var context = new EFContext())
            {
                context.ConsultasMedicamentos.Add(consultaMedicamento);
                context.SaveChanges();
            }
        }

        public void ExcluirConsultaMedicamento(ConsultaMedicamento consultaMedicamento)
        {
            using (var context = new EFContext())
            {
                context.ConsultasMedicamentos.Remove(consultaMedicamento);
                context.SaveChanges();
            }
        }

    }
}
