using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Modelo
{
    [Table("viewMedicamento")]
    public class Medicamento
    {
        [Key]
        public long MedicamentoId { get; set; }
        public string Descricao { get; set; }
        public double ValorUnitario { get; set; }
        public virtual List<ConsultaMedicamento> ConsultasMedicamentos { get; set; }
    }
}
