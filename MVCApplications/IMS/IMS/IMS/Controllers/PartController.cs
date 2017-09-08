using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMS.Models;
using IMS.Repositories;

namespace IMS.Controllers
{
    public class PartController : Controller
    {
        PartTypeRepo partTypeRepo = new PartTypeRepo();
        PartRepo partRepo = new PartRepo();
        CategoryRepo categoryRepo = new CategoryRepo();

        // GET: Part
        // List
        public ActionResult Index()
        {
            var parts = partRepo.SelectAll();
            return View(parts);
        }
        //Get
        public ActionResult Create()
        {
            ViewBag.PartTypeId = new SelectList( partTypeRepo.SelectAll(),"Id","Name");
            ViewBag.CategoryId = new SelectList(categoryRepo.SelectAll(), "Id", "Name");
            return View();
        }

        //Post
        [HttpPost]
        public ActionResult Create(Part part)
        {
            if (ModelState.IsValid)
            {
                partRepo.Insert(part);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            ViewBag.PartTypeId = new SelectList(partTypeRepo.SelectAll(), "Id", "Name");
            ViewBag.CategoryId = new SelectList(categoryRepo.SelectAll(), "Id", "Name");
            return View(partRepo.Select(id));
        }

        // POST: Price/Edit/5
        [HttpPost]
        public ActionResult Edit(Part part)
        {
            try
            {
                partRepo.Update(part);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}