using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class VeriController : Controller
    {
        // GET: Veri

        VeriContext vt = new VeriContext();
        public ActionResult Index()
        {
            return View(vt.tables.ToList());
        }

        // GET: Veri/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Veri/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Veri/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Table tt = new Table();
                tt.Aciklama = collection["Aciklama"];
                tt.HarcamaTipi = int.Parse( collection["HarcamaTipi"]);
                tt.Tutar = int.Parse(collection["Tutar"]);
                tt.Id = 9;
                vt.tables.Add(tt);
                vt.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Veri/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Veri/Edit/5
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

        // GET: Veri/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Veri/Delete/5
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
