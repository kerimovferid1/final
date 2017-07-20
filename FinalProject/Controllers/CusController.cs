using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;
using System.IO;

namespace FinalProject.Controllers
{
    public class CusController : Controller
    {
        private FinalProjectEntities1 db = new FinalProjectEntities1();

        // GET: Cus
        public ActionResult Index()
        {
            return View(db.Cus.ToList());
        }

        // GET: Cus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cus cus = db.Cus.Find(id);
            if (cus == null)
            {
                return HttpNotFound();
            }
            return View(cus);
        }

        // GET: Cus/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cus/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
       
        public ActionResult Create(Cus cus)
        {
            string fileName = Path.GetFileNameWithoutExtension(cus.ImageFile.FileName);
            string extension = Path.GetExtension(cus.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            cus.imagePath = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"),fileName);
            cus.ImageFile.SaveAs(fileName);


            if (ModelState.IsValid)
            {
                db.Cus.Add(cus);
                db.SaveChanges();
    
            }
            ModelState.Clear();

            return View();
        }
        //public ActionResult View(int id)
        //{
        //    Cus cusM = new Cus();
        //    cusM = db.Cus.Where(x => x.imageID == id).FirstOrDefault();
        //    return View(cusM);
        //}
        // GET: Cus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cus cus = db.Cus.Find(id);
            if (cus == null)
            {
                return HttpNotFound();
            }
            return View(cus);
        }

        // POST: Cus/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "imageID,title,comment,imagePath")] Cus cus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cus);
        }

        // GET: Cus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cus cus = db.Cus.Find(id);
            if (cus == null)
            {
                return HttpNotFound();
            }
            return View(cus);
        }

        // POST: Cus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cus cus = db.Cus.Find(id);
            db.Cus.Remove(cus);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

