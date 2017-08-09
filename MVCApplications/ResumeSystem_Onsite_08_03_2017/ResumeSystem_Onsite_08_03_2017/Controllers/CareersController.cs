using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeSystem_Onsite_08_03_2017.Models;
using ResumeSystem_Onsite_08_03_2017.Models.Repository;

namespace ResumeSystem_Onsite_08_03_2017.Controllers
{
    public class CareersController : Controller
    {
        ApplicantRepo repo = new ApplicantRepo();
        // GET: Careers
        public ActionResult Positions()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Applicants()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Applicants(Applicants applicants)
        {
            if (!ModelState.IsValid)
                return View();

            repo.SaveApplicantToDb(applicants);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteApplicant(int id)
        {
            repo.DeleteApplicantFromDb(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Applicants> applicants = repo.SelectAll();
            return View(applicants);
        }


    }
}