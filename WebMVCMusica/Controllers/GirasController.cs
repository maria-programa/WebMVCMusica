using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMVCMusica.Models;
using WebMVCMusica.Services.Repositorio;
using WebMVCMusica.ViewModels;
using Giras = WebMVCMusica.Models.Giras;

namespace WebMVCMusica.Controllers
{
    public class GirasController : Controller
    {
        private readonly IGenericRepositorio<Giras> _repositorio;
        private readonly IGenericRepositorio<Grupos> _repositorioGrupos;
        private readonly ICreaListaPorGira _builderGira;

        public GirasController(IGenericRepositorio<Giras> repositorio, IGenericRepositorio<Grupos> repositorioGrupos, ICreaListaPorGira builderGira)
        {
            _repositorio = repositorio;
            _repositorioGrupos = repositorioGrupos;
            _builderGira = builderGira;
        }

        // GET: Giras
        public async Task<IActionResult> Index()
        {
            //var grupoBContext = _context.Giras.Include(g => g.Grupos);
            return View(_repositorio.DameTodos());
        }

        public async Task<IActionResult> GiraSin()
        {
            return View(this._builderGira.dameTodasGiras());
        }

        // GET: Giras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var giras = await _context.Giras
            //    .Include(g => g.Grupos)
            //    .FirstOrDefaultAsync(m => m.Id == id);
            var giras = _repositorio.DameUnElemento((int)id);
            if (giras == null)
            {
                return NotFound();
            }

            return View(giras);
        }

        // GET: Giras/Create
        public IActionResult Create()
        {
            ViewData["GruposId"] = new SelectList(_repositorioGrupos.DameTodos(), "Id", "Nombre");
            return View();
        }

        // POST: Giras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,GruposId,FechaInicio,FechaFin")] Giras giras)
        {
            if (ModelState.IsValid)
            {
                _repositorio.Agregar(giras);
                return RedirectToAction(nameof(Index));
            }
            ViewData["GruposId"] = new SelectList(_repositorioGrupos.DameTodos(), "Id", "Nombre", giras.GruposId);
            return View(giras);
        }

        // GET: Giras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var giras = _repositorio.DameUnElemento((int)id);
            if (giras == null)
            {
                return NotFound();
            }
            ViewData["GruposId"] = new SelectList(_repositorioGrupos.DameTodos(), "Id", "Nombre", giras.GruposId);
            return View(giras);
        }

        // POST: Giras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,GruposId,FechaInicio,FechaFin")] Giras giras)
        {
            if (id != giras.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _repositorio.Editar(giras);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GirasExists(giras.Id))
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
            ViewData["GruposId"] = new SelectList(_repositorioGrupos.DameTodos(), "Id", "Nombre", giras.GruposId);
            return View(giras);
        }

        // GET: Giras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var giras = await _context.Giras
            //    .Include(g => g.Grupos)
            //    .FirstOrDefaultAsync(m => m.Id == id);
            var giras = _repositorio.DameUnElemento((int)id);
            if (giras == null)
            {
                return NotFound();
            }

            return View(giras);
        }

        // POST: Giras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _repositorio.Eliminar((int)id);
            return RedirectToAction(nameof(Index));
        }

        private bool GirasExists(int id)
        {
            if (_repositorio.DameUnElemento((int)id) == null)
            {
                return false;
            }
            return true;
        }
    }
}
