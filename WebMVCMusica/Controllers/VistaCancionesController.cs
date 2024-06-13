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
    public class VistaCancionesController : Controller
    {
        private readonly IGenericRepositorio<VistaCanciones> _repositorio;

        public VistaCancionesController(IGenericRepositorio<VistaCanciones> repositorio)
        {
            _repositorio = repositorio;
        }

        // GET: VistaCanciones
        public async Task<IActionResult> VistaPorCanciones()
        {
            return View("Views/Canciones/VistaPorCanciones.cshtml",_repositorio.DameTodos());
        }

        // GET: VistaCanciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vistaCanciones = _repositorio.DameUnElemento((int)id);
            if (vistaCanciones == null)
            {
                return NotFound();
            }

            return View(vistaCanciones);
        }
    }
}
