using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Orange_Market.BL;
using Orange_Market.DA;
using Orange_Market.Model;

namespace Orange_Market.UI.Controllers
{
    public class UsuarioController : Controller
    {

        public readonly Repositorio_Usuario Repositorio_Usuario;


        public UsuarioController(Repositorio_Usuario repositorioUsuario)
        {
            Repositorio_Usuario = repositorioUsuario;

        }



        // GET: UsuarioController
        public ActionResult ListarUsuarios()
        {
            List<Usuario> laLista;
            laLista = Repositorio_Usuario.MostrarUsuarios();
            return View(laLista);
        }



        public ActionResult AgregarUsuario()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AgregarUsuario(Usuario Usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Repositorio_Usuario.AñadirUsuario(Usuario);
                    return RedirectToAction(nameof(ListarUsuarios));
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










        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioController/Edit/5
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

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioController/Delete/5
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
