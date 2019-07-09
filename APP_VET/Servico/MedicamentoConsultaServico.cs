using System;
using System.Collections.Generic;
using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
   public class MedicamentoConsultaServico
    {
        private MedicamentoConsultaDAL medicamentoConsultaDal = new MedicamentoConsultaDAL();

        public IList<ConsultaMedicamento> TodasAsConsultasMedicamentosPorId(long consultaId)
        {
            return medicamentoConsultaDal.TodasAsConsultasMedicamentosPorId(consultaId);
        }


        public void GravarConsultaMedicamento(ConsultaMedicamento consultaMedicamento)
        {
            medicamentoConsultaDal.GravarConsultaMedicamento(consultaMedicamento);
        }

        public void ExcluirConsultaMedicamento(long id)
        {
            ConsultaMedicamento consultaMedicamento = new ConsultaMedicamento() { ConsultaMedicamentoId = id };
            medicamentoConsultaDal.ExcluirConsultaMedicamento(consultaMedicamento);
        }
    }
}
