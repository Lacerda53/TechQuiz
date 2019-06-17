using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Areas.Admin.Models
{
    public class Questao
    {
        [Key]
        public int IDQuestao { get; set; }
        [Display(Name = "Statement")]
        public string Enunciado { get; set; }
       
    }
}
