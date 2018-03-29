using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AnilTuran.Models;

namespace AnilTuran.Controllers
{
    [UserAuthorize]
    public class UnvansController : Controller
    {
        private BlogDbContext db = new BlogDbContext();

        // GET: Unvans
        public ActionResult Index()
        {
            return View(db.Unvanlar.ToList());
        }

        // GET: Unvans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Unvan unvan = db.Unvanlar.Find(id);
            if (unvan == null)
            {
                return HttpNotFound();
            }
            return View(unvan);
        }

        // GET: Unvans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Unvans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UnvanID,UnvanAdi,UserInformationID")] Unvan unvan)
        {
            if (ModelState.IsValid)
            {
                db.Unvanlar.Add(unvan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(unvan);
        }

        // GET: Unvans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Unvan unvan = db.Unvanlar.Find(id);
            if (unvan == null)
            {
                return HttpNotFound();
            }
            return View(unvan);
        }

        // POST: Unvans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UnvanID,UnvanAdi,UserInformationID")] Unvan unvan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unvan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(unvan);
        }

        // GET: Unvans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Unvan unvan = db.Unvanlar.Find(id);
            if (unvan == null)
            {
                return HttpNotFound();
            }
            return View(unvan);
        }

        // POST: Unvans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Unvan unvan = db.Unvanlar.Find(id);
            db.Unvanlar.Remove(unvan);
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
