using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationMVC.Models;

namespace ValidationMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(EmployeeViewModel employeeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(employeeViewModel);
            }
            return RedirectToAction("Index");
        }
    }
}