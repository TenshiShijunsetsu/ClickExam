using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClickExam.Models;

namespace ClickExam.Controllers
{
    public class HomeController : Controller
    {
        private ClikDBContext db = new ClikDBContext();

        // GET: data from db
        public ActionResult Index()
        {
            var cliks = from c in db.Cliks
                        where c.ID == 1
                        select c;
            return View(cliks.First());
        }

        
        [HttpPost]
        public ActionResult Index(Clik clk)
        {
            // update db
            if (clk.ClikCtr + 1 < 11)
            {
                var udb = db.Cliks.Find(clk.ID);
                udb.ClikCtr = clk.ClikCtr + 1;

                db.SaveChanges();
            }

            //display db data
            ModelState.Clear();
            var cliks = from c in db.Cliks
                        where c.ID == clk.ID
                        select c;
            return View(cliks.First());
        }
    }
}