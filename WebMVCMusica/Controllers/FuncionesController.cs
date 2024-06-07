using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMVCMusica.Models;
using WebMVCMusica.Services.Repositorio;

namespace WebMVCMusica.Controllers
{
    public class FuncionesController : Controller
    {
        private readonly IGenericRepositorio<Funciones> _repositorio;

        public FuncionesController(IGenericRepositorio<Funciones> repositorio)
        {
            _repositorio = repositorio;
        }

        // GET: Funciones
        public async Task<IActionResult> Index()
        {
            return View(_repositorio.DameTodos());
        }

        // GET: Funciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funciones = _repositorio.DameUnElemento((int)id);
            if (funciones == null)
            {
                return NotFound();
            }

            return View(funciones);
        }

        // GET: Funciones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Funciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] Funciones funciones)
        {
            if (ModelState.IsValid)
            {
                _repositorio.Agregar(funciones);
                return RedirectToAction(nameof(Index));
            }
            return View(funciones);
        }

        // GET: Funciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funciones = _repositorio.DameUnElemento((int)id);
            if (funciones == null)
            {
                return NotFound();
            }
            return View(funciones);
        }

        // POST: Funciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] Funciones funciones)
        {
            if (id != funciones.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _repositorio.Editar(funciones);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuncionesExists(funciones.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(funciones);
        }

        // GET: Funciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funciones = _repositorio.DameUnElemento((int)id);
            if (funciones == null)
            {
                return NotFound();
            }

            return View(funciones);
        }

        // POST: Funciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _repositorio.Eliminar((int)id);
            return RedirectToAction(nameof(Index));
        }

        private bool FuncionesExists(int id)
        {
            if (_repositorio.DameUnElemento((int)id) == null)
            {
                return false;
            }
            return true;
        }
    }
}
