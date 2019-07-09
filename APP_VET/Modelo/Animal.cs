using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Animal
    {
        public long AnimalId { get; set; } 
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Pelagem { get; set; }
        public int Idade { get; set; }
        public long  ClienteId { get; set; }
    }
}
