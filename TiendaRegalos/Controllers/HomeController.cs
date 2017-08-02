using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TiendaRegalos.Controllers
{
    public class HomeController : Controller
    {
        private Models.TiendaRegalosEntities bd = new Models.TiendaRegalosEntities();
        
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar(string id="")
        {
            //logica de acceso a la base de datos
            var productos = bd.Producto
                .Where(x=>x.PalabraClave.Contains(id))
                .Take(16)
                .ToList();
            // lista de productos
            ViewBag.clave = id;
            return View(productos);
        }
    }
}