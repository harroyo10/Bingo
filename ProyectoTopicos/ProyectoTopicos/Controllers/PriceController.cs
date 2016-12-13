using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Data.Entity;
using System.Web.Mvc;
using ProyectoTopicos.Models;

namespace ProyectoTopicos.Controllers
{
    public class PriceController : Controller 
    {
        private PriceDBContext db = new PriceDBContext();

        // GET: Price
        public ActionResult Index()
        {
            return View(db.Salas.ToList());
        }

        // GET: Price/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Price Price = db.Salas.Find(id);
            if (Price == null)
            {
                return HttpNotFound();
            }
            return View(Price);
        }

        // GET: Price/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Price/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PriceID,PriceName,PriceCategory,PriceDisponibility")] Price Price)
        {
            if (ModelState.IsValid)
            {
                db.Salas.Add(Price);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Price);
        }

        // GET: Price/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Price Price = db.Salas.Find(id);
            if (Price == null)
            {
                return HttpNotFound();
            }
            return View(Price);
        }

        // POST: Price/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PriceID,PriceName,PriceCategory,PriceDisponibility")] Price Price)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Price).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Price);
        }

        // GET: Price/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Price Price = db.Salas.Find(id);
            if (Price == null)
            {
                return HttpNotFound();
            }
            return View(Price);
        }

        // POST: Price/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Price Price = db.Salas.Find(id);
            db.Salas.Remove(Price);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}