using EV01.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EV01.Controllers
{
    public class VENTASController : Controller
    {
        static List<VENTAS> Lista = new List<VENTAS>();

        // GET: VENTASController
        public ActionResult IndexVentas()
        {
            return View(Lista);
        }

        // GET: VENTASController/Details/5
        public ActionResult DetailsVentas(int id)
        {
            VENTAS buscado = Lista.Find(x => x.NroVentas == id);

            return View(buscado);
        }

        // GET: VENTASController/Create
        public ActionResult CreateVentas()
        {
            VENTAS obj = new VENTAS();
            obj.FechaVentas = DateTime.Today;
            obj.Cantidad = 1;

            return View(obj);
        }

        // POST: VENTASController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateVentas(VENTAS xVen)
        {
            Lista.Add(xVen);

            ViewBag.MENSAJE = "Nuevo producto registrado";

            return View(xVen);
        }

        // GET: VENTASController/Edit/5
        public ActionResult EditVentas(int id)
        {
            VENTAS buscado2 = Lista.Find(x2 => x2.NroVentas == id);

            return View(buscado2);
        }

        // POST: VENTASController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditVentas(int id, VENTAS actualizado)
        {
            VENTAS medicinas = Lista.Find(x3 => x3.NroVentas == id);

            medicinas.Medicamento = actualizado.Medicamento;
            medicinas.FechaVentas = actualizado.FechaVentas;
            medicinas.Precio = actualizado.Precio;
            medicinas.Cantidad = actualizado.Cantidad;

            ViewData["MENSAJE"] =
                $"Se edito el producto llamado: {actualizado.Medicamento}";

            string cad =
                $"Se actualizo los datos del N°: {actualizado.NroVentas}";

            return View(actualizado);
        }

        // GET: VENTASController/Delete/5
        public ActionResult DeleteVentas(int id)
        {
            VENTAS buscado3 = Lista.Find(y => y.NroVentas == id);

            return View(buscado3);
        }

        // POST: VENTASController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteVentas(int id, IFormCollection collection)
        {
            VENTAS objDel = Lista.Find(z => z.NroVentas == id);

            Lista.Remove(objDel);

            return View(objDel);
        }
    }
}
