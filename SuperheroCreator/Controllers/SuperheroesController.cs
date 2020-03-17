using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperheroCreator.Data;
using SuperheroCreator.Models;

namespace SuperheroCreator.Controllers
{
    public class SuperheroesController : Controller
    {
        ApplicationDbContext _context;
        
        public SuperheroesController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Superheroes
        public ActionResult Index()
        {
            var superheroes = _context.Superheroes;
            return View(superheroes);
        }

        // GET: Superheroes/Details/5
        public ActionResult Details(int id)
        {
            var superheroDetails = _context.Superheroes.Where(s => s.SuperheroId == id).FirstOrDefault();
            return View(superheroDetails);
        }

        // GET: Superheroes/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: Superheroes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero Superhero)
        {
            try
            {
                // Add insert logic
                _context.Superheroes.Add(Superhero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Edit/5
        public ActionResult Edit(int id)
        {
            var Superhero = _context.Superheroes.Where(s => s.SuperheroId == id).FirstOrDefault();
            return View(Superhero);
        }

        // POST: Superheroes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Superhero Superhero)
        {
            Superhero editedSuperhero = null;
            editedSuperhero = _context.Superheroes.Where(s => s.SuperheroId == id).FirstOrDefault();
            try
            {
                // update logic here
                editedSuperhero.Name = Superhero.Name;
                editedSuperhero.PrimarySuperAbility = Superhero.PrimarySuperAbility;
                editedSuperhero.SecondarySuperAbility = Superhero.SecondarySuperAbility;
                editedSuperhero.AlterEgo = Superhero.AlterEgo;
                editedSuperhero.Catchphrase = Superhero.Catchphrase;
                Superhero = editedSuperhero;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Delete/5
        public ActionResult Delete(int id)
        {
            var superhero = _context.Superheroes.Where(s => s.SuperheroId == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: Superheroes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Superhero superhero)
        {

            try
            {
                _context.Superheroes.Remove(superhero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}