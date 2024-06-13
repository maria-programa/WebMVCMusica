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
    public class CancionesController : Controller
    {
        private readonly IGenericRepositorio<Canciones> _repositorio;
        private readonly IGenericRepositorio<Albumes> _repositorioAlbumes;

        public CancionesController(IGenericRepositorio<Canciones> repositorio, IGenericRepositorio<Albumes> repositorioAlbumes)
        {
            _repositorio = repositorio;
            _repositorioAlbumes = repositorioAlbumes;
        }

        // GET: Canciones
        public async Task<IActionResult> Index()
        {
            //var grupoBContext = _context.Canciones.Include(c => c.Albumes);
            return View(_repositorio.DameTodos());
        }
        //public async Task<IActionResult> IndexC()
        //{
        //    //var grupoBContext = _context.Canciones.Include(c => c.Albumes);
        //    var consulta = 
        //        from canciones in _context.Canciones
        //        where canciones.Titulo.ToUpper().StartsWith("S")
        //        select canciones;

        //    return View(await consulta.ToListAsync());
        //}

        // GET: Canciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var canciones = await _context.Canciones
            //    .Include(c => c.Albumes)
            //    .FirstOrDefaultAsync(m => m.Id == id);

            var canciones = _repositorio.DameUnElemento((int)id);
            if (canciones == null)
            {
                return NotFound();
            }

            return View(canciones);
        }

        // GET: Canciones/Create
        public IActionResult Create()
        {
            ViewData["AlbumesId"] = new SelectList(_repositorioAlbumes.DameTodos(), "Id", "Nombre");
            return View();
        }

        // POST: Canciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Duracion,AlbumesId,Single")] Canciones canciones)
        {
            if (ModelState.IsValid)
            {
                _repositorio.Agregar(canciones);
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlbumesId"] = new SelectList(_repositorioAlbumes.DameTodos(), "Id", "Nombre", canciones.AlbumesId);
            return View(canciones);
        }

        // GET: Canciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canciones = _repositorio.DameUnElemento((int)id);
            if (canciones == null)
            {
                return NotFound();
            }
            ViewData["AlbumesId"] = new SelectList(_repositorioAlbumes.DameTodos(), "Id", "Nombre", canciones.AlbumesId);
            return View(canciones);
        }

        // POST: Canciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Duracion,AlbumesId,Single")] Canciones canciones)
        {
            if (id != canciones.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _repositorio.Editar(canciones);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CancionesExists(canciones.Id))
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
            ViewData["AlbumesId"] = new SelectList(_repositorioAlbumes.DameTodos(), "Id", "Nombre", canciones.AlbumesId);
            return View(canciones);
        }

        // GET: Canciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var canciones = await _context.Canciones
            //    .Include(c => c.Albumes)
            //    .FirstOrDefaultAsync(m => m.Id == id);

            var canciones = _repositorio.DameUnElemento((int)id);
            if (canciones == null)
            {
                return NotFound();
            }

            return View(canciones);
        }

        // POST: Canciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _repositorio.Eliminar((int)id);
            return RedirectToAction(nameof(Index));
        }

        private bool CancionesExists(int id)
        {
            if (_repositorio.DameUnElemento((int)id) == null)
            {
                return false;
            }
            return true;
        }
    }
}
