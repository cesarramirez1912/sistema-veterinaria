using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Cliente : Pessoa
    {
        public long ClienteId { get; set; }
        public virtual List<Animal> Animais { get; set; }
        public virtual List<Consulta> Consultas { get; set; }
    }
}
