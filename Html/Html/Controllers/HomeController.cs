using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Html.Models;
namespace Html.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

      [HttpPost]
      public ActionResult Procesar()
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }else {
                Class1 data = new Class1();
                return  View(data);
            }

        }



        public ActionResult Resultado(Class1 obj)
        {
            return View(obj);

        }

        public ActionResult Bienvenido()
        {
            return View();
        }
    }
}