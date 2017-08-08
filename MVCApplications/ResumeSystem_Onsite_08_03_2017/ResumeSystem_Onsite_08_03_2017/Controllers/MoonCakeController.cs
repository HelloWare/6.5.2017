using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeSystem_Onsite_08_03_2017.Models;

namespace ResumeSystem_Onsite_08_03_2017.Controllers
{
    public class MoonCakeController : Controller
    {
        List<MoonCake> mooncakes = new List<MoonCake>();

        // GET: MoonCake
        public ActionResult Index()
        {
            return View(mooncakes);
        }

        // GET: MoonCake/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MoonCake/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MoonCake/Create
        [HttpPost]
        public ActionResult Create(MoonCake mooncake)
        {
            try
            {
                // TODO: Add insert logic here
                mooncakes.Add(mooncake);
                //return "You successfully submitted the request with values: "+mooncake.Shape+" "+mooncake.Stuffing+" "+mooncake.Flavor+" "+mooncake.Smell;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
                //return "You Failed!";
            }
        }

        // GET: MoonCake/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MoonCake/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MoonCake mooncake)
        {
            try
            {
                // TODO: Add update logic here
                for (int i = 0; i < mooncakes.Count(); i++)
                {
                    if (mooncakes[i].CakeId == id)
                    {
                        mooncakes[i] = mooncake;
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MoonCake/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MoonCake/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, MoonCake mooncake)
        {
            try
            {
                // TODO: Add delete logic here
                mooncakes.Remove(mooncake);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
