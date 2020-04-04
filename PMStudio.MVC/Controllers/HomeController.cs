using PMStudio.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMStudio.MVC.Controllers
{
    public class HomeController : Controller
    {
        private PMStudioContext db = new PMStudioContext();

        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            return View();
        }
    }
}