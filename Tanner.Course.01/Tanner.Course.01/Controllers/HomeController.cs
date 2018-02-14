using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tanner.Course._01.Models;

namespace Tanner.Course._01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Content("<b>este es el inicio del curso ASP NET MVC</b>");          
           
            // return HttpStatusCodeResult(404);
        }

        public FileResult Index1()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"c:\Lifecycle.pdf");
            string fileName = "tanner.pdf";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Pdf, fileName);

            // return HttpStatusCodeResult(404);
        }



        public List<Persona> listarPersona()
        {
            List<Persona> collpersonas = new List<Persona>();

            return collpersonas;

        }
        public List<Persona> listarPersona(string rut)
        {
            List<Persona> collpersonas = new List<Persona>();

            return collpersonas;

        }


        public ContentResult Index11()
        {
            return Content("esto es un ejemplo curso Tanner");
            //   return Content("<b>esto es un ejemplo curso Tanner</b>");
        }


        /// <summary>
        /// Redirect ,RedirectoAction
        /// </summary>
        /// <returns></returns>
        /// 
        //  RedirectToRouteResult
        ///RedirectResult
        public RedirectToRouteResult Index5()
        {
            //return Redirect("www.google.cl");
           // RedirectToAction("Index", "Home");
            return RedirectToRoute("Ejemplo");
            //   return Content("<b>esto es un ejemplo curso Tanner</b>");
        }

        /// <summary>
        /// Status Code Result
        /// </summary>
        /// <returns></returns>
        public HttpStatusCodeResult Index2()
        {

            return HttpNotFound("can not find requested resource");
        }
        public JsonResult Index3()
        {
            var persona = new Persona() { nombre = "Juan luis", paterno = "Perez", materno = "Tapia", rut = "171915872" };

            //   return Json(persona);
            return Json(persona, JsonRequestBehavior.AllowGet);

        }
        public JsonResult Index4()
        {
            var persona = new Persona() { nombre = "Juan luis", paterno = "Perez", materno = "Tapia", rut = "171915872" };
            var persona1 = new Persona() { nombre = "Francisco andres", paterno = "Herrera", materno = "Herrera", rut = "171915872" };
            List<Persona> collPersonas = new List<Persona>();
            collPersonas.Add(persona);
            collPersonas.Add(persona1);
            //   return Json(persona);
            return Json(collPersonas, JsonRequestBehavior.AllowGet);

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