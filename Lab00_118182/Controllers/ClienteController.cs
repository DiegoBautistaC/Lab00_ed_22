using Lab00_118182.Helpers;
using Lab00_118182.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab00_118182.Controllers
{
    public class ClienteController : Controller
    {
        // GET: ClienteController
        public ActionResult Index()
        {
            return View(ClienteData.Instancia.ListaCliente);
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            var modelo = ClienteData.Instancia.ListaCliente.Find(cliente => cliente.ID == id);
            return View(modelo);
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View(new ClienteModel());
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                ClienteModel.Guardar(new ClienteModel
                {
                    ID = int.Parse(collection["ID"]),
                    Nombre = collection["Nombre"],
                    Apellido = collection["Apellido"],
                    Telefono = int.Parse(collection["Telefono"]),
                    Descripcion = collection["Descripcion"]
                });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            var modelo = ClienteData.Instancia.ListaCliente.Find(cliente => cliente.ID == id);
            return View(modelo);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var validacion = ClienteModel.Editar(id, new ClienteModel
                {
                    Nombre = collection["Nombre"],
                    Apellido = collection["Apellido"],
                    Telefono = int.Parse(collection["Telefono"]),
                    Descripcion = collection["Descripcion"]
                });
                if (validacion)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            var modelo = ClienteData.Instancia.ListaCliente.Find(cliente => cliente.ID == id);
            return View(modelo);
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var validacion = ClienteModel.Borrar(id);
                if (validacion)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
