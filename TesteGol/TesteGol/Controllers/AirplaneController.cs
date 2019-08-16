using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteGol.Models;
using TesteGol.Contexto;

namespace TesteGol.Controllers
{
    public class AirplaneController : Controller
    {
        private ContextoDeDados db = new ContextoDeDados();

        //
        // GET: /Airplane/

        public ActionResult Index()
        {
            return View(db.Airplanes.ToList());
        }

        //
        // GET: /Airplane/Details/5

        public ActionResult Details(int id = 0)
        {
            Airplane airplane = db.Airplanes.Find(id);
            if (airplane == null)
            {
                return HttpNotFound();
            }
            return View(airplane);
        }

        //
        // GET: /Airplane/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Airplane/Create

        [HttpPost]
        public ActionResult Create(Airplane airplane)
        {
            if (ModelState.IsValid)
            {
                airplane.CreationDate = DateTime.Now;
                db.Airplanes.Add(airplane);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(airplane);
        }

        //
        // GET: /Airplane/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Airplane airplane = db.Airplanes.Find(id);
            if (airplane == null)
            {
                return HttpNotFound();
            }
            return View(airplane);
        }

        //
        // POST: /Airplane/Edit/5

        [HttpPost]
        public ActionResult Edit(Airplane airplane)
        {
            if (ModelState.IsValid)
            {
                db.Entry(airplane).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(airplane);
        }

        //
        // GET: /Airplane/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Airplane airplane = db.Airplanes.Find(id);
            if (airplane == null)
            {
                return HttpNotFound();
            }
            return View(airplane);
        }

        //
        // POST: /Airplane/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Airplane airplane = db.Airplanes.Find(id);
            db.Airplanes.Remove(airplane);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}