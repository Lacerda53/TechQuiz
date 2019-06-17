using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quiz._Repositorys.core;
using Quiz.Models;

namespace Quiz.Controllers
{
    public class QuizController : Controller
    {
        public IQuestaoRepository QuestaoRep;
        public IAlternativaRepository AlternativaRep;
        public QuizController(IQuestaoRepository questaoRep, IAlternativaRepository alternativaRepository)
        {
            QuestaoRep = questaoRep;
            AlternativaRep = alternativaRepository;
        }

        public IActionResult Index()
        {
            var test = new Test();
            
            test.Questoes = QuestaoRep.Get().Select(x => new Questao { Enunciado = x.Enunciado, ID = x.IDQuestao }).ToList();
            var alternativas = AlternativaRep.Get().ToList();
            foreach (var questao in test.Questoes)
            {
                questao.Alternativas = alternativas.Where(x => x.IDQuestao == questao.ID)
                    .Select(x => new Alternativa { ID = x.IDAlternativa, Resposta = x.Resposta }).ToList();
            }
            return View(test);
        }
        [HttpPost]
        public IActionResult Index(Test test)
        {
            var alternativas = AlternativaRep.Get().ToList();
            foreach (var q in test.Questoes)
            {
                q.Msg = (q.Resposta == alternativas.Where(y => y.IDQuestao == q.ID).Single(y => y.Correta).Resposta) ? "Right Answer" : "Wrong Answer";
            }
            return View(test);
        }
    }
}