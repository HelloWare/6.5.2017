using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMS.Models;
using IMS.Repositories;

namespace IMS.Controllers
{
    public class PartsController : Controller
    {
        private PartRepo partRepo = new PartRepo();
        private PartTypeRepo partTypeRepo = new PartTypeRepo();
        private PriceRepo priceRepo = new PriceRepo();
        // GET: Parts
        public ActionResult Index()
        {
            return View(partRepo.SelectAll());
        }

        // GET: Parts/Details/5
        public ActionResult Details(int id)
        {
            return View(partRepo.Select(id));
        }

        // GET: Parts/Create
        public ActionResult Create()
        {
            ViewBag.PartTypeId = new SelectList(partTypeRepo.SelectAll(),"Id","Name"); 
            return View();
        }

        // POST: Parts/Create
        [HttpPost]
        public ActionResult Create(Part part)
        {
            try
            {
                // TODO: Add insert logic here
                partRepo.Insert(part);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Parts/Edit/5
        public ActionResult Edit(int id)
        {          
            return View(partRepo.Select(id));
        }

        public ActionResult GetPriceViewForPart(int id)
        {
            return View(priceRepo.SelectAllPricesForPart(id));
        }
        // POST: Parts/Edit/5
        [HttpPost]
        public ActionResult Edit(Part part)
        {
            try
            {
                // TODO: Add update logic here
                partRepo.Update(part);
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                throw e;
                return View();
            }
        }

        // GET: Parts/Delete/5
        public ActionResult Delete(int id)
        {
            return View(partRepo.Select(id));
        }

        // POST: Parts/Delete/5
        [HttpPost]
        public ActionResult DeletePost(int id)
        {
            try
            {
                // TODO: Add delete logic here
                partRepo.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Delete", id);
            }
        }
    }
}
