using Business;
using Common.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IStudentBusiness buisnes = new StudentBusiness();
            var list = buisnes.GetAll();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(string id)
            
        {
            IStudentBusiness buisnes = new StudentBusiness();
            var i = buisnes.GetByID( id);
            return View(i);
        }

        [HttpPost]
        public ActionResult Create(StudnetDTO dto)
        {
            IStudentBusiness buisnes = new StudentBusiness();
            buisnes.Insert(dto);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Update(StudnetDTO dto)
        {
            IStudentBusiness buisnes = new StudentBusiness();
            buisnes.Update(dto);
            return RedirectToAction("Index");
        }
    }
}