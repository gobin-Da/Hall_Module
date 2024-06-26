﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hostel;

namespace Hostel.Controllers
{
    public class ApplyController : Controller
    {
        private HostelDBContext db = new HostelDBContext();

        // GET: Apply
        public ActionResult Index()
        {
            return View(db.Applies.ToList());
        }

        // GET: Apply/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apply apply = db.Applies.Find(id);
            if (apply == null)
            {
                return HttpNotFound();
            }
            return View(apply);
        }

        // GET: Apply/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Apply/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentId,StudentName,StudentRegistration,Email,Phone,City,Area,Road")] Apply apply)
        {
            if (ModelState.IsValid)
            {
                db.Applies.Add(apply);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(apply);
        }

        // GET: Apply/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apply apply = db.Applies.Find(id);
            if (apply == null)
            {
                return HttpNotFound();
            }
            return View(apply);
        }

        // POST: Apply/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,StudentName,StudentRegistration,Email,Phone,City,Area,Road")] Apply apply)
        {
            if (ModelState.IsValid)
            {
                db.Entry(apply).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(apply);
        }

        // GET: Apply/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apply apply = db.Applies.Find(id);
            if (apply == null)
            {
                return HttpNotFound();
            }
            return View(apply);
        }

        // POST: Apply/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Apply apply = db.Applies.Find(id);
            db.Applies.Remove(apply);
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

        public ActionResult ManagerView()
        {
            if ((string)Session["type"] == "Manager")
            {
                return View(db.Applies.ToList());

            }
            else
            {
                return Redirect("/User/Error");
            }
        }
    }
}
