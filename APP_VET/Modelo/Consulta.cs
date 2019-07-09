using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Consulta
    {
        public long ConsultaId { get; set; }
        public string Observacao { get; set; }
        public virtual List<ConsultaMedicamento> ConsultasMedicamentos { get; set; }
        public long  ClienteId { get; set; }
        public long VeterinarioId { get; set; }
        public int AnimalId { get; set; }
        public DateTime DataConsulta { get; set; }
        public string EstatusConsulta { get; set; }
        public string EstatusPagamento { get; set; }
        public double ValorTotalConsulta { get; set; }
    }
}
