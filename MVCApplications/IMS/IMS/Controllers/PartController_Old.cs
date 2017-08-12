using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMS.Models;
using IMS.Repositories;

namespace IMS.Controllers
{
    public class PartController_Old : Controller
    {
        PartRepo partRepo = new PartRepo();

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


    }
}