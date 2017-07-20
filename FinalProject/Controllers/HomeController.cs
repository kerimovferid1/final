using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using FinalProject.Models;
namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private FinalProjectEntities1 db = new FinalProjectEntities1();

        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult Cousine()
        {

            return View(db.Cus.ToList());
        }
        public ActionResult Country()
        {
            return View();
        }
        public ActionResult AboutAze()
        {
            return View();
        }

        public ActionResult ContactUS()
        {
            return View();
        }
        public ActionResult Walking()
        {
            return View();
        }
        public ActionResult Cycling()
        {
            return View();
        }
        public ActionResult Lakes()
        {
            return View();
        }
        public ActionResult Skiing()
        {
            return View();
        }
        public ActionResult whereToStay()
        {
            return View();
        }
        public ActionResult Cities()
        {
            return View();
        }
        public ActionResult Round()
        {
            return View();
        }
    }
}