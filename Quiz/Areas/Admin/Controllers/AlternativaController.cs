using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Quiz._Repositorys.core;
using Quiz.Areas.Admin.Models;


namespace Quiz.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AlternativaController : Controller
    {
        IAlternativaRepository AlternativaRep;
        IQuestaoRepository Questaorep;
        public AlternativaController(IAlternativaRepository alternativaRep, IQuestaoRepository questaoRep)
        {
            AlternativaRep = alternativaRep;
            Questaorep = questaoRep;
        }
        // GET: Alternativa
        public IActionResult Index()
        {
            var item = AlternativaRep.Get(); //trazer tudo no index: get vazio
            return View(item);
        }

        // GET: Alternativa/Details/5
        public IActionResult Details(int IDAlternativa)
        {
            return View(AlternativaRep.GetbyID(IDAlternativa));
        }

        // GET: Alternativa/Create
        public IActionResult Create(int IdQuestao)
        {
            ViewBag.Questao =new SelectList(Questaorep.Get().ToList(), "IDQuestao", "Enunciado");
            return View(new Alternativa { IDQuestao = IdQuestao } );
        }

        // POST: Alternativa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Alternativa item, int IDQuestao)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Questao = Questaorep.GetbyID(IDQuestao);
                item.IDQuestao = IDQuestao;
                AlternativaRep.Include(item);
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

        // GET: Alternativa/Edit/5
        public IActionResult Edit(int IDAlternativa)
        {
            return View(AlternativaRep.GetbyID(IDAlternativa));
        }

        // POST: Alternativa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Alternativa item)
        {
            if (ModelState.IsValid)
            {
                AlternativaRep.Update(item);
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

        // GET: Alternativa/Delete/5
        public IActionResult Delete(int IDAlternativa)
        {
            return View(AlternativaRep.GetbyID(IDAlternativa));
        }

        // POST: Alternativa/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Deletar(int IDAlternativa)
        {
            if (ModelState.IsValid)
            {
                AlternativaRep.Delete(IDAlternativa);
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