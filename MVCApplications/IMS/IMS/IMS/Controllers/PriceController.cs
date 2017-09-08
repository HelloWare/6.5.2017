using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMS.Models;
using IMS.Repositories;

namespace IMS.Controllers
{
    public class PriceController : Controller
    {
        // GET: Price
        PriceRepo priceRepo = new PriceRepo();
        public ActionResult Index()
        {
            IEnumerable<Price> prices = new List<Price>();
            prices = priceRepo.SelectAll();
            return View(prices);
        }

        // GET: Price/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Price/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Price/Create
        [HttpPost]
        public ActionResult Create(Price price)
        {
            try
            {
                priceRepo.Insert(price);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Price/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Price/Edit/5
        [HttpPost]
        public ActionResult Edit(Price price)
        {
            try
            {
                // TODO: Add update logic here
                priceRepo.Update(price);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Price/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Price/Delete/5
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
