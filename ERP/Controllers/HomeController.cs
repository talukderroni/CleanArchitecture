using ERP.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP.Controllers
{
    public class HomeController : Controller
    {
      
        public ActionResult Index()
        {
            using (var db=new ApplicationDbContxt())
            {
                var data = db.HR_EmployeeInfo.Take(10).ToList();

                return View();
            }

          
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
    }
}