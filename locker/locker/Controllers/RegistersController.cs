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
    public class RegistersController : Controller
    {
        private LockerContext db = new LockerContext();

        // GET: Registers
        public ActionResult Index()
        {
            return View(db.Registrer.ToList());
        }

        // GET: Registers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Register register = db.Registrer.Find(id);
            if (register == null)
            {
                return HttpNotFound();
            }
            return View(register);
        }

        // GET: Registers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registers/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Email,Password,ConfirmPassword")] Register register)
        {
            if (ModelState.IsValid)
            {
                db.Registrer.Add(register);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(register);
        }

        // GET: Registers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Register register = db.Registrer.Find(id);
            if (register == null)
            {
                return HttpNotFound();
            }
            return View(register);
        }

        // POST: Registers/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Email,Password,ConfirmPassword")] Register register)
        {
            if (ModelState.IsValid)
            {
                db.Entry(register).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(register);
        }

        // GET: Registers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Register register = db.Registrer.Find(id);
            if (register == null)
            {
                return HttpNotFound();
            }
            return View(register);
        }

        // POST: Registers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Register register = db.Registrer.Find(id);
            db.Registrer.Remove(register);
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
