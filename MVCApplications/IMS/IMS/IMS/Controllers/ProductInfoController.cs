using IMS.Models;
using IMS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMS.Controllers
{
    public class ProductInfoController : Controller
    {
        // GET: ProductInfo
        PartRepo partRepo = new PartRepo();

        public ActionResult Index()
        {
            IEnumerable<Part> parts = new List<Part>();
            parts = partRepo.SelectAll();
            return View(parts);
        }

        // GET: ProductInfo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductInfo/Create
        [HttpPost]
        public ActionResult Create(Part part)
        {
            try
            {
                partRepo.Insert(part);
                //// TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductInfo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductInfo/Edit/5
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

        // GET: ProductInfo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductInfo/Delete/5
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
