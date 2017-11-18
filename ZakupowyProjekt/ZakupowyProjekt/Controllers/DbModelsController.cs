using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ZakupowyProjekt.Models;

namespace ZakupowyProjekt.Controllers
{
    public class DbModelsController : Controller
    {
        private Models.AppContext db = new Models.AppContext();

        // GET: DbModels
        public ActionResult Index()
        {
            return View(db.DbModels.ToList());
        }

        // GET: DbModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DbModel dbModel = db.DbModels.Find(id);
            if (dbModel == null)
            {
                return HttpNotFound();
            }
            return View(dbModel);
        }

        // GET: DbModels/Create
        public ActionResult Create()
        {
          
            return View();
        }

        // POST: DbModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DbModel dbModel)
        {
            if (ModelState.IsValid)
            {
                dbModel.Data = DateTime.Now;
                dbModel.DateModified = DateTime.Now;
                db.DbModels.Add(dbModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dbModel);
        }

        // GET: DbModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DbModel dbModel = db.DbModels.Find(id);
            if (dbModel == null)
            {
                return HttpNotFound();
            }
            return View(dbModel);
        }

        // POST: DbModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Cena,Data")] DbModel dbModel)
        {
            if (ModelState.IsValid)
            {
                dbModel.DateModified = DateTime.Now;
                db.Entry(dbModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dbModel);
        }

        // GET: DbModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DbModel dbModel = db.DbModels.Find(id);
            if (dbModel == null)
            {
                return HttpNotFound();
            }
            return View(dbModel);
        }

        // POST: DbModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DbModel dbModel = db.DbModels.Find(id);
            db.DbModels.Remove(dbModel);
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
