using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HarcamaAnaController : Controller
    {
        HarcamaContext db = new HarcamaContext();

        // GET: HarcamaAna
        public ActionResult Index()
        {
            
            return View(db.islemler.ToList());
        }

        // GET: HarcamaAna/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HarcamaAna/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HarcamaAna/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HarcamaAna/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HarcamaAna/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HarcamaAna/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HarcamaAna/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
