using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EV01.Controllers
{
    public class INGRESOController : Controller
    {
        // GET: INGRESOController
        public ActionResult Login()
        {
            return View();
        }

        // GET: INGRESOController/Details/5
        public ActionResult Login(IFormCollection collection)
        {
            string usuario = collection["USUARIO"];
            string password = collection["PASSWORD"];

            if (usuario.Equals("admin") && password == "1234")
            {
                return RedirectToAction("IndexVentas", "VENTAS");
            }
            else
            {
                ViewBag.MENSAJE = "Su contraseña y/o nombre de usuario estan incorrectos";
                return View();
            }
        }
    }
}