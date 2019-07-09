
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class ConsultaMedicamento
    {
        public long ConsultaMedicamentoId { get; set; }
        public long ConsultaId { get; set; }
        public long MedicamentoId { get; set; }
        public float ValorUnitario { get; set; }
        public int Quantidade { get; set; }
    }
}
