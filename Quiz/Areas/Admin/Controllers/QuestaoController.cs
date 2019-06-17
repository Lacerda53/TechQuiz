using Microsoft.AspNetCore.Mvc;
using Quiz._Repositorys.core;
using Quiz.Areas.Admin.Models;

namespace Quiz.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuestaoController : Controller
    {
        public IQuestaoRepository QuestaoRep;
        public QuestaoController(IQuestaoRepository questaoRep)
        {
            QuestaoRep = questaoRep;
        }
        // GET: Questao
        public IActionResult Index()
        {
            var item = QuestaoRep.Get(); //trazer tudo no index: get vazio
            return View(item);
        }

        // GET: Questao/Details/5
        public IActionResult Details(int IDQuestao)
        {
            var a = QuestaoRep.GetbyID(IDQuestao);
            return View(a);
        }

        // GET: Questao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Questao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Questao item)
        {
            if (ModelState.IsValid)
            {
                QuestaoRep.Include(item);
                return RedirectToAction("Index");
            }
            else
            {
                string errors = string.Empty;
                foreach (var erro in ModelState)
                {
                    errors += $"{erro}\n";
                }
                return View(errors);
            }
        }

        // GET: Questao/Edit/5
        public IActionResult Edit(int IDQuestao)
        {
            return View(QuestaoRep.GetbyID(IDQuestao));
        }

        // POST: Questao/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Questao item)
        {
            if (ModelState.IsValid)
            {
                QuestaoRep.Update(item);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Questao/Delete/5
        public IActionResult Delete(int IDQuestao)
        {
            return View(QuestaoRep.GetbyID(IDQuestao));
        }

        // POST: Questao/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Deletar(int IDQuestao)
        {
            if (ModelState.IsValid)
            {
                QuestaoRep.Delete(IDQuestao); //fazer "hidden" na view do delete (pq é update)
                return RedirectToAction("Index");
            }
            else
            {
                string errors = string.Empty;
                foreach (var erro in ModelState)
                {
                    errors += $"{erro}\n";
                }
                return View(errors);
            }
        }
    }
}