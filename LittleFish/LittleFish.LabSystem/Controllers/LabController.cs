using LittleFish.LabSystem.DataModel;
using LittleFish.LabSystem.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LittleFish.LabSystem.Controllers
{
    public class LabController : Controller
    {
        # region LabList

        // GET: LabCenter
        public ActionResult LabList()
        {
            using (var db = new LabDbContext())
            {
                return View(db.Labs.ToList());
            }
        }

        [HttpPost]
        public ActionResult LabList(string keyword)
        {
            using (var db = new LabDbContext())
            {
                var list = string.IsNullOrWhiteSpace(keyword) ? db.Labs.ToList() :
                   db.Labs.Where(l => l.Name.Contains(keyword) || l.Location.Contains(keyword) || l.Notes.Contains(keyword)).ToList();
                return View(list);
            }
        }

        public ActionResult EditLab(int? id)
        {
            using (var db = new LabDbContext())
            {
                if (id != null)
                {
                    var lab = db.Labs.FirstOrDefault(l => l.Id == id.Value);
                    if (lab == null)
                        return Json(new { statusCode = "300", message = "指定实验室不存在" });
                    return View(lab);
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult SaveLab(Laboratory model)
        {
            using (var db = new LabDbContext())
            {
                if (db.Labs.Any(l=>l.Id==model.Id))
                {
                    db.Entry(model).State = EntityState.Modified;
                }
                else
                    db.Labs.Add(model);
                db.SaveChanges();
                return Json(new
                {
                    statusCode = "200",
                    message = "操作成功",
                    navTabId = "LabList",
                    callbackType = "closeCurrent"
                });
            }
        }

        public ActionResult DeleteLab(int id)
        {
            using (var db = new LabDbContext())
            {
                var lab = db.Labs.FirstOrDefault(l => l.Id == id);
                if (lab != null)
                {
                    db.Labs.Remove(lab);
                    db.SaveChanges();
                    return Json(new
                    {
                        statusCode = "200",
                        message = "操作成功",
                        callbackType = "forward",
                        forwardUrl = Url.Action("LabList")
                    });
                }
                else
                {
                    return Json(new
                    {
                        statusCode = "300",
                        message = "指定实验室不存在"
                    });
                }
            }
        }

        # endregion

        public ActionResult Regulations()
        {
            return View();
        }

        public ActionResult LabAppointment()
        {
            return View();
        }
    }
}