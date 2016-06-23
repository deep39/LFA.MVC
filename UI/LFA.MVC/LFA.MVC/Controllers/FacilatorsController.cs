using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LFA.Data.EF_CodeFirst;

namespace LFA.MVC.Controllers
{
    public class FacilatorsController : Controller
    {
        private StudentContext db = new StudentContext();

        // GET: Facilators
        public ActionResult Index()
        {
            return View(db.Facilators.ToList());
        }

        // GET: Facilators/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facilator facilator = db.Facilators.Find(id);
            if (facilator == null)
            {
                return HttpNotFound();
            }
            return View(facilator);
        }

        // GET: Facilators/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Facilators/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FacilatorId,FirstName,LastName")] Facilator facilator)
        {
            if (ModelState.IsValid)
            {
                db.Facilators.Add(facilator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(facilator);
        }

        // GET: Facilators/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facilator facilator = db.Facilators.Find(id);
            if (facilator == null)
            {
                return HttpNotFound();
            }
            return View(facilator);
        }

        // POST: Facilators/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FacilatorId,FirstName,LastName")] Facilator facilator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facilator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(facilator);
        }

        // GET: Facilators/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facilator facilator = db.Facilators.Find(id);
            if (facilator == null)
            {
                return HttpNotFound();
            }
            return View(facilator);
        }

        // POST: Facilators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Facilator facilator = db.Facilators.Find(id);
            db.Facilators.Remove(facilator);
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
