using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class Questao
    {
        public int ID { get; set; }
        public string Enunciado { get; set; }
        public string Resposta { get; set; }
        public string Msg { get; set; }
        public List<Alternativa> Alternativas { get; set; }
    }
}
