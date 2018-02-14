using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tanner.Course._01.Models;

namespace Tanner.Course._01.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona

        [Route("product/{category}/{product}")]
        public JsonResult TestJsonResult()
        {

            var persona = new Persona() { nombre = "Juan luis", paterno = "Perez", materno = "Tapia", rut = "171915872" };

            //   return Json(persona);
            return Json(persona,JsonRequestBehavior.AllowGet);
           /// return Json(persona, JsonRequestBehavior.AllowGet);

        }

        /// <summary>
        /// Retonar una lista de personas dependiedo de un id
        /// </summary>
        /// <param name="id">parametro para la demostracion de error null</param>
        /// <returns></returns>
        public JsonResult TestJsonResultList(int id)
        {
            var persona = new Persona() { nombre = "Juan luis", paterno = "Perez", materno = "Tapia", rut = "171915872" };
            var persona1 = new Persona() { nombre = "Francisco andres", paterno = "Herrera", materno = "Herrera", rut = "171915872" };
            List<Persona> collPersonas = new List<Persona>();
            collPersonas.Add(persona);
            collPersonas.Add(persona1);
            //   return Json(persona);
            return Json(collPersonas, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// prueba de Action con parametro string que puede ser nulo y 
        /// JsonRequestBehavior.AllowGet
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult TestJsonResultListWithNullParameters(string id)
        {
            var persona = new Persona() { nombre = "Juan luis", paterno = "Perez", materno = "Tapia", rut = "171915872" };
            var persona1 = new Persona() { nombre = "Francisco andres", paterno = "Herrera", materno = "Herrera", rut = "171915872" };
            List<Persona> collPersonas = new List<Persona>();
            collPersonas.Add(persona);
            collPersonas.Add(persona1);
            //   return Json(persona);
            return Json(collPersonas);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpStatusCodeResult TestJsonResultCodes()
        {
            return new HttpStatusCodeResult(500, "error interno en el servidor");
           // return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
           // return new HttpStatusCodeResult(HttpStatusCode.NotFound, "No se encontro el recurso");
           // return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Bad Request");
        }
        // GET: Persona/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Persona/Create
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

        // GET: Persona/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Persona/Edit/5
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

        // GET: Persona/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Persona/Delete/5
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
