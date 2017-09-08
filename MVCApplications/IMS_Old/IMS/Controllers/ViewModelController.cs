using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMS.Models.ViewModels;
using IMS.Repositories;

namespace IMS.Controllers
{
    public class ViewModelController : Controller
    {
        private PartRepo partRepo = new PartRepo();
        private CategoryRepo categoryRepo = new CategoryRepo();
        // GET: ViewModel
        public ActionResult Dashboard()
        {
            var myCategory = categoryRepo.Select(1);
            var myPart=partRepo.Select(2);


            var dashboard = new DashboardViewModel
            {
                Part=myPart,
                Category = myCategory
            };
            //-----The Same As---
            var dashboard2 = new DashboardViewModel();
            dashboard2.Part = myPart;
            dashboard2.Category = myCategory;

            return View(dashboard);
        }
    }
}