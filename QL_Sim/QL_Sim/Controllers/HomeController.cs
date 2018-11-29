using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QL_Sim.Models;
namespace QL_Sim.Controllers
{
    public class HomeController : Controller
    {
        private SimSoEntityFrameWork db = new SimSoEntityFrameWork();

        public ActionResult index(String search)
        {
            if (String.IsNullOrEmpty(search))
                return View(db.SimSo.OrderBy(t => t.id).ToList());
            else
            {
                var simso = db.SimSo.Where(s => s.so.Contains(search));

                return View("index", simso);
            }
        }

        public ActionResult add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult add(SimSo ss)
        {
            db.SimSo.Add(ss);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult edit(int id)
        {

            return View(db.SimSo.SingleOrDefault(t => t.id.Equals(id)));
        }
        [HttpPost]
        public ActionResult edit(SimSo ss)
        {

            db.Entry(ss).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("index");
        }


    }
}