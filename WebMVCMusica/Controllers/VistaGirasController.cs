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
    public class VistaGirasController : Controller
    {
        private readonly IGenericRepositorio<VistaGiras> _repositorio;

        public VistaGirasController(IGenericRepositorio<VistaGiras> repositorio)
        {
            _repositorio = repositorio;
        }

        // GET: VistaGiras
        public async Task<IActionResult> VistaPorGira()
        {
            return View("Views/Giras/VistaPorGira.cshtml", _repositorio.DameTodos());
        }

        // GET: VistaGiras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vistaGiras = _repositorio.DameUnElemento((int)id);
            if (vistaGiras == null)
            {
                return NotFound();
            }

            return View(vistaGiras);
        }
    }
}
