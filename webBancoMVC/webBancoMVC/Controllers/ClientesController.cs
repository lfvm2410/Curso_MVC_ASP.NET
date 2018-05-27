using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webBancoMVC.Controllers
{
    public class ClientesController : Controller
    {
        public ActionResult listado()
        {
            DALClientes oClientes = new DALClientes();
            //Limpiar el modelo
            ModelState.Clear();
            return View(oClientes.ListarClientes());
        }
    }
}