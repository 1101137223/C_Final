using C.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace C.Controllers
{
    public class addController : Controller
    {
        //
        // GET: /add/
        private STUEntities db = new STUEntities();
        public ActionResult Index()
        {
                        return View();
        }

        [HttpPost, ActionName("Create")]
        public ActionResult Create(FormCollection form, int stuID, int subID, string arr)
        {
            
            var record = new record
            {
                record_ID = 2,
                class_ID = subID,
                stu_ID = stuID,
                arrive = arr
            };
            db.record.Add(record);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
