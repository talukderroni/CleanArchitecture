using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP.Areas.HRM.Controllers
{
    public class HRMController : Controller
    {
        // GET: HRM/HRM
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EmployeeList()
        {
            return View("~/Areas/Views/HRM/EmployeeList.cshtml");
        }
        // GET: HRM/HRM/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HRM/HRM/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HRM/HRM/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HRM/HRM/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HRM/HRM/Edit/5
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

        // GET: HRM/HRM/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HRM/HRM/Delete/5
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
