using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using WebMVCMusica.Models;

namespace WebMVCMusica.Services.Repositorio
{
    public class EFGenericRepositorio<T> : IGenericRepositorio<T> where T : class
    {
        private readonly GrupoBContext _context = new();

        public List<T> DameTodos()
        {
            return _context.Set<T>().AsNoTracking().ToList();
        }

        public T DameUnElemento(int Id)
        {
            return _context.Set<T>().Find(Id);
        }

        public bool Eliminar(int Id)
        {
            if (DameUnElemento(Id) != null)
            {
                _context.Remove(DameUnElemento(Id));
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Agregar(T element)
        {
            _context.Add(element);
            _context.SaveChanges();
            return true;
        }

        public void Editar(T element)
        {
            _context.Update(element);
            _context.SaveChanges();
        }

        public List<T> Filtra(Expression<Func<T, bool>> predicado)
        {
            return _context.Set<T>().Where<T>(predicado).ToList();
        }
    }
}
