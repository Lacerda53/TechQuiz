using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class Alternativa
    {
        public int ID { get; set; }
        public string Resposta { get; set; }
        public bool Correta { get; set; }
        public bool Marcada { get; set; }
    }
}
