using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;


namespace WebApplication4.Controllers
{
    public class areaController : Controller
    {
        // GET: area
        area_modelo tareas = new area_modelo();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListadoAreas() {

            return View();
        }


        public JsonResult lareas()
        {

            List<tarea> lareas = tareas.listaareas();
           
            return Json(lareas, JsonRequestBehavior.AllowGet);
        }
    }
}