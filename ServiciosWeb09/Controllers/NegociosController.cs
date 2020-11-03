using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiciosWeb09.ReferenciaNegocios;
using WCFNegocios_9;

namespace ServiciosWeb09.Controllers
{
    public class NegociosController : Controller
    {
        // GET: Negocios
        Service1Client servicio = new Service1Client();
        public ActionResult Index()
        {
            return View(servicio.clientes());
        }

        public ActionResult Create()
        {
            ViewBag.paises = new SelectList(servicio.paises(), "idpais", "nombrepais");
            return View(new Cliente());
        }
        [HttpPost]
        public ActionResult Create(Cliente reg)
        {
            ViewBag.mensaje = servicio.Agregar(reg);
            ViewBag.paises = new SelectList(
                servicio.paises(), "idpais", "nombrepais", reg.idpais);
            return View(reg);
        }
    }
}