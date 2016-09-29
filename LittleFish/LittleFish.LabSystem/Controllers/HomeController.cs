using LittleFish.LabSystem.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LittleFish.LabSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new LabDbContext())
            {
                return View(db.Resources.Include("Category").ToList());
            }
        }
    }
}