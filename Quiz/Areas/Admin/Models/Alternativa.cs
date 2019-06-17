using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Areas.Admin.Models
{
    public class Alternativa
    {
        [Key]
        public int IDAlternativa { get; set; }
        [Display(Name = "Alternative")] //mostra o nome "Resposta" por "Alternative"
        public string Resposta { get; set; }
        [Display(Name = "Right Alternative")]
        public bool Correta { get; set; }
        [Display(Name = "Question")] //substitui IDQuestao por Question
        public int IDQuestao { get; set; }

    }
}
