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
    public class RegistrousuariosController : Controller
    {
        private LockerContext db = new LockerContext();

        // GET: Registrousuarios
        public ActionResult Index()
        {
            return View(db.Registrousuarios.ToList());
        }

        // GET: Registrousuarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registrousuario registrousuario = db.Registrousuarios.Find(id);
            if (registrousuario == null)
            {
                return HttpNotFound();
            }
            return View(registrousuario);
        }

        // GET: Registrousuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registrousuarios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,User,Email,Password,ConfirmPassword")] Registrousuario registrousuario)
        {
            if (ModelState.IsValid)
            {
                db.Registrousuarios.Add(registrousuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(registrousuario);
        }

        // GET: Registrousuarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registrousuario registrousuario = db.Registrousuarios.Find(id);
            if (registrousuario == null)
            {
                return HttpNotFound();
            }
            return View(registrousuario);
        }

        // POST: Registrousuarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,User,Email,Password,ConfirmPassword")] Registrousuario registrousuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registrousuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registrousuario);
        }

        // GET: Registrousuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registrousuario registrousuario = db.Registrousuarios.Find(id);
            if (registrousuario == null)
            {
                return HttpNotFound();
            }
            return View(registrousuario);
        }

        // POST: Registrousuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Registrousuario registrousuario = db.Registrousuarios.Find(id);
            db.Registrousuarios.Remove(registrousuario);
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
