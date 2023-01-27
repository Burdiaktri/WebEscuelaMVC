using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebEscuelaMVC.Data;
using WebEscuelaMVC.Models;

namespace WebEscuelaMVC.Controllers
{
    public class AulaController : Controller
    {
        private readonly EscuelaDBMVCContext context;

        public AulaController(EscuelaDBMVCContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public IActionResult Index()
        {
            List<Aula> aulas = context.Aulas.ToList();
            return View(aulas);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Aula aulas = new Aula();
            return View("Register", aulas);
        }

        [HttpPost]
        public ActionResult Create(Aula aulas)
        {
            if (ModelState.IsValid)
            {
                context.Aulas.Add(aulas);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aulas);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Aula aulas = TraerUnAula(id);
            if (aulas == null)
            {
                return NotFound();
            }
            else
            {
                return View("Detalle", aulas);
            }
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            Aula aulas = TraerUnAula(id);
            if (aulas == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", aulas);
            }
        }

  
        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            Aula aulas = TraerUnAula(id);
            if (aulas == null)
            {
                return NotFound();
            }
            else
            {
                context.Aulas.Remove(aulas);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Aula aulas = TraerUnAula(id);
            if (aulas == null)
            {
                return NotFound();
            }
            else
            {
                return View("Edit", aulas);
            }
        }


        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(Aula aulas)
        {
            if (ModelState.IsValid)
            {
                context.Entry(aulas).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aulas);
        }

        private Aula TraerUnAula(int id)
        {
            return context.Aulas.Find(id);
        }
    }
}
