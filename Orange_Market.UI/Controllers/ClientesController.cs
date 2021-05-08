using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orange_Market.BL;
using Orange_Market.Model;

namespace Orange_Market.UI.Controllers
{
    public class ClientesController : Controller
    {

        public readonly Repositorio_Cliente Repositorio_Cliente;


        public ClientesController(Repositorio_Cliente repositorioCliente)
        {
            Repositorio_Cliente = repositorioCliente;

        }



        public ActionResult ListarClientes()
        {
            List<Clientes> laLista;
            laLista = Repositorio_Cliente.MostrarClientes();
            return View(laLista);
        }



        public ActionResult AgregarClientes()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AgregarClientes(Clientes cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Repositorio_Cliente.AñadirCliente(cliente);
                    return RedirectToAction(nameof(ListarClientes));
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
























        

       

        

       

        
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
