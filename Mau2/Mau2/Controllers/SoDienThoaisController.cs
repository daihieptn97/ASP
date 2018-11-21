using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mau2.Models;

namespace Mau2.Controllers
{
    public class SoDienThoaisController : Controller
    {
        private SimSoEntityFrameword db = new SimSoEntityFrameword();

        // GET: SoDienThoais
        public ActionResult Index()
        {
            return View(db.sodienthoais.ToList());
        }

        // GET: SoDienThoais/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SoDienThoai soDienThoai = db.sodienthoais.Find(id);
            if (soDienThoai == null)
            {
                return HttpNotFound();
            }
            return View(soDienThoai);
        }

        // GET: SoDienThoais/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SoDienThoais/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,so,gia,ngay")] SoDienThoai soDienThoai)
        {
            if (ModelState.IsValid)
            {
                db.sodienthoais.Add(soDienThoai);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(soDienThoai);
        }

        // GET: SoDienThoais/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SoDienThoai soDienThoai = db.sodienthoais.Find(id);
            if (soDienThoai == null)
            {
                return HttpNotFound();
            }
            return View(soDienThoai);
        }

        // POST: SoDienThoais/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,so,gia,ngay")] SoDienThoai soDienThoai)
        {
            if (ModelState.IsValid)
            {
                db.Entry(soDienThoai).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(soDienThoai);
        }

        // GET: SoDienThoais/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SoDienThoai soDienThoai = db.sodienthoais.Find(id);
            if (soDienThoai == null)
            {
                return HttpNotFound();
            }
            return View(soDienThoai);
        }

        // POST: SoDienThoais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SoDienThoai soDienThoai = db.sodienthoais.Find(id);
            db.sodienthoais.Remove(soDienThoai);
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
