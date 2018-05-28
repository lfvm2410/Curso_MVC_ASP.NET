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

        public ActionResult agregarCliente(EntidadClientes cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DALClientes oCliente = new DALClientes();
                    if (oCliente.InsertarCliente(cliente))
                    {
                        ViewBag.Mensaje = "Cliente insertado exitosamente";
                    }
                    else
                    {
                        ViewBag.Mensaje = "Ocurrió un error en la inclusi[on del cliente";
                    }
                }
               
            }catch(Exception ex)
            {
                ex = null;
            }
            return View();
        }
    }
}