using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mau4.Models;
namespace Mau4.Controllers
{
    public class HomeController : Controller
    {
        private HocSinhEntityFrameword db = new HocSinhEntityFrameword();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult add(sinhvien sv)
        {
            db.sinhvien.Add(sv);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult delete(int id)
        {
            sinhvien sv = db.sinhvien.SingleOrDefault(o => o.Id.Equals(id));
            db.sinhvien.Remove(sv);
            db.SaveChanges();
            return RedirectToAction("index");
        }

    }
}