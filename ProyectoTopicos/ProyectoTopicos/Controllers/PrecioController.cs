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
    public class PrecioController : Controller 
    {
        private ProyectoDBContext db = new ProyectoDBContext();

        // GET: Precio
        public ActionResult Index()
        {
            return View(db.Precios.ToList());
        }

        // GET: Precio/Detalle/5
        public ActionResult Detalle(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Precio Precio = db.Precios.Find(id);
            if (Precio == null)
            {
                return HttpNotFound();
            }
            return View(Precio);
        }

        // GET: Precio/Crear
        public ActionResult Crear()
        {
            return View();
        }

        // POST: Precio/Crear
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear([Bind(Include = "PrecioID,PrecioCategoria,PrecioValor,PrecioArtefactos")] Precio Precio)
        {
            if (ModelState.IsValid)
            {
                db.Precios.Add(Precio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Precio);
        }

        // GET: Precio/Modificar/5
        public ActionResult Modificar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Precio Precio = db.Precios.Find(id);
            if (Precio == null)
            {
                return HttpNotFound();
            }
            return View(Precio);
        }

        // POST: Precio/Modificar/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Modificar([Bind(Include = "PrecioID,PrecioCategoria,PrecioValor,PrecioArtefactos")] Precio Precio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Precio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Precio);
        }

        // GET: Precio/Eliminar/5
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Precio Precio = db.Precios.Find(id);
            if (Precio == null)
            {
                return HttpNotFound();
            }
            return View(Precio);
        }

        // POST: Precio/Eliminar/5
        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmarEliminar(int id)
        {
            Precio Precio = db.Precios.Find(id);
            db.Precios.Remove(Precio);
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