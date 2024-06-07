using System.Linq.Expressions;

namespace WebMVCMusica.Services.Repositorio
{
    public interface IGenericRepositorio<T> where T: class
    {
        List<T> DameTodos();
        T DameUnElemento(int Id);
        bool Eliminar(int Id);
        bool Agregar(T element);
        void Editar (T element);
        List<T> Filtra(Expression<Func<T, bool>> predicado);
    }
}
