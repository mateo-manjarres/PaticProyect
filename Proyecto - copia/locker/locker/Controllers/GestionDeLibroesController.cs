using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using locker.DAL;
using locker.Models;

namespace locker.Controllers
{
    public class GestionDeLibroesController : Controller
    {
        private LockerContext db = new LockerContext();

        // GET: GestionDeLibroes
        public ActionResult Index(locker.Models.Register userModel)
        {
            int id = Int32.Parse(Session["ID"].ToString());
            var login = db.GestionDeLibros.Where(x => x.IDusuario == userModel.ID).FirstOrDefault();
            if (login == null)
            {
                return View(db.GestionDeLibros.Where(x => x.IDusuario == id).ToList());
            }
            else
            {
                return View(db.GestionDeLibros.ToList().Where(x => x.IDusuario == id).FirstOrDefault());
            }
        }

        // GET: GestionDeLibroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GestionDeLibro gestionDeLibro = db.GestionDeLibros.Find(id);
            if (gestionDeLibro == null)
            {
                return HttpNotFound();
            }
            return View(gestionDeLibro);
        }

        // GET: GestionDeLibroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GestionDeLibroes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IDusuario,NombreLibro,Estado,Autor,Introduccion,Genero,Editorial,PaginaActual,Arboles")] GestionDeLibro gestionDeLibro)
        {
            if (ModelState.IsValid)
            {
                gestionDeLibro.IDusuario = Int32.Parse(Session["ID"].ToString());
                db.GestionDeLibros.Add(gestionDeLibro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gestionDeLibro);
        }

        // GET: GestionDeLibroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GestionDeLibro gestionDeLibro = db.GestionDeLibros.Find(id);
            if (gestionDeLibro == null)
            {
                return HttpNotFound();
            }
            return View(gestionDeLibro);
        }

        // POST: GestionDeLibroes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IDusuario,NombreLibro,Estado,Autor,Introduccion,Genero,Editorial,PaginaActual,Arboles")] GestionDeLibro gestionDeLibro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gestionDeLibro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gestionDeLibro);
        }

        // GET: GestionDeLibroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GestionDeLibro gestionDeLibro = db.GestionDeLibros.Find(id);
            if (gestionDeLibro == null)
            {
                return HttpNotFound();
            }
            return View(gestionDeLibro);
        }

        // POST: GestionDeLibroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GestionDeLibro gestionDeLibro = db.GestionDeLibros.Find(id);
            db.GestionDeLibros.Remove(gestionDeLibro);
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
