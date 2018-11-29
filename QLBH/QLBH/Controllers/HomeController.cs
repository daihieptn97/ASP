using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLBH.Models;
namespace QLBH.Controllers
{
    public class HomeController : Controller
    {
        private HangHoaEntityFrameword db = new HangHoaEntityFrameword();
        public ActionResult Index()
        {
            ViewBag.data = db.hanghoa.ToList();
            return View();
        }
        [HttpGet]
        public ActionResult detail(int id)
        {
            HangHoa hang = db.hanghoa.SingleOrDefault(t => t.id.Equals(id));
            return View(hang);
        }

        public ActionResult delete(int id)
        {
            HangHoa hang = db.hanghoa.SingleOrDefault(t => t.id.Equals(id));
            db.hanghoa.Remove(hang);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult add(HangHoa hang)
        {

            if (ModelState.IsValid == true)
            {
                db.hanghoa.Add(hang);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View(hang);
            }

        }
        [HttpGet]
        public ActionResult edit(int id)
        {
            return View(db.hanghoa.SingleOrDefault(t => t.id.Equals(id)));
        }
        [HttpPost]
        public ActionResult edit(HangHoa hang)
        {

            db.Entry(hang).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index");
        }

    }
}