using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.Entity;
using intermediary.Models;

namespace intermediary.Controllers
{
    public class BackstageController : Controller
    {
        IntermediaryEntities1 db = new IntermediaryEntities1();
        // GET: Backstage
        /// <summary>
        /// 显示全部房屋信息
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //whole，全部
            ViewBag.whole = db.Addhouse.ToList();
            return View();
        }
        //查询
        public ActionResult Select()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Select(int? size, int? monthly, string house, string style, string trimstate)
        {
            ViewBag.select = db.Addhouse.Where(p => p.size == size || p.monthly == monthly ||
              p.house == house || p.style == style || p.trimstate == trimstate).ToList();
            return View();
        }
        /// <summary>
        /// 添加房屋出租信息
        /// </summary>
        /// <returns></returns>
        public ActionResult AddHouse()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddHouse(Addhouse addhouse)
        {
            db.Addhouse.Add(addhouse);
            db.SaveChanges();
            return View();
        }
        /// <summary>
        /// 加载编辑
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            ViewBag.Edit = db.Addhouse.Find(id);
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Addhouse addhouse)
        {
            db.Entry(addhouse).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return  
        }
        public ActionResult Delect(int id)
        {
            db.Addhouse.Remove(db.Addhouse.Find(id));
            db.SaveChanges();
            return View();
        }
    }
}