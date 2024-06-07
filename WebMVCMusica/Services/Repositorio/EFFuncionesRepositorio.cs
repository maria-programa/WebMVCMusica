using Microsoft.EntityFrameworkCore;
using WebMVCMusica.Models;

namespace WebMVCMusica.Services.Repositorio
{
    public class EFFuncionesRepositorio : IFuncionesRepositorio

    {
        private readonly GrupoBContext _context = new();

        public List<Funciones> DameFunciones()
        {
            return _context.Funciones.AsNoTracking().ToList();
        }

        public Funciones? DameUnaFuncion(int Id)
        {
            return _context.Funciones.Find(Id);
        }

        public bool BorrarFuncion(int Id)
        {
            if (DameUnaFuncion(Id) != null)
            {
                _context.Funciones.Remove(DameUnaFuncion(Id));
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool AgregarFuncion(Funciones funcion)
        {
            if (DameUnaFuncion(funcion.Id) != null)
            {
                return false;
            }
            else
            {
                _context.Funciones.Add(funcion);
                _context.SaveChanges();
                return true;
            }
        }

        public void ModificarFuncion(Funciones funcion)
        {
            _context.Update(funcion);
            _context.SaveChanges();
            //var recupera = DameUnaFuncion(Id);
            //if (recupera != null)
            //{
            //    BorrarFuncion(Id);
            //}

            //AgregarFuncion(funcion);
        }
    }
}