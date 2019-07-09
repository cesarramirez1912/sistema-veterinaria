using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Veterinario : Pessoa
    {
        public long VeterinarioId { get; set; }
        public virtual List<Consulta> Consultas { get; set; }
        public float Salario { get; set; }
    }
}
