using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class usuariosController : Controller
    {
        // GET: usuarios
        usuario_modelo omod = new usuario_modelo();
        area_modelo oarea = new area_modelo();
        public ActionResult Index(String id="*")
        {
            return View(omod.listausuarios(id));
        }

        public ActionResult ListaporId(String id )
        {
            return View(omod.listausuarios(id));
        }
        public ActionResult pusu()
        {
            return View();
        }

        public ActionResult nuevo() {
            return View(oarea.listaareas());
        }

        public JsonResult guardar(String nom,String car,String tipo,String id)
        {
            tusuario tusu = new tusuario();
            tusu.usu_cod = id;
            tusu.usu_nom = nom;
            tusu.usu_cargo = car;
            tusu.usu_tipo = tipo;
            String res = omod.guardarusuario(tusu);            
            return Json(new { Resultado = res});
        }



        public JsonResult eliminar(String id) {
            String res = omod.Eliminarusuario(id);
            return Json(new { Resultado = res });
        }

    }
}