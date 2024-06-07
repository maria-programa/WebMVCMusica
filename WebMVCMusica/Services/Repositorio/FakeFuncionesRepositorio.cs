using System.Linq.Expressions;
using WebMVCMusica.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebMVCMusica.Services.Repositorio
{
    public class FakeFuncionesRepositorio : IGenericRepositorio<Funciones>
    {
        private List<Funciones> listaFunciones = new();

        public FakeFuncionesRepositorio()
        {
            Funciones miFuncion = new()
            {
                Id = 1,
                Nombre = "Cantante"
            };
            listaFunciones.Add(miFuncion);
            miFuncion = new()
            {
                Id = 2,
                Nombre = "Guitarra"
            };
            listaFunciones.Add(miFuncion);
            miFuncion = new()
            {
                Id = 3,
                Nombre = "Bajo"
            };
            listaFunciones.Add(miFuncion);
            miFuncion = new()
            {
                Id = 4,
                Nombre = "Batería"
            };
            listaFunciones.Add(miFuncion);
        }

        public List<Funciones> DameTodos()
        {
            return this.listaFunciones;
        }

        public Funciones DameUnElemento(int Id)
        {
            return this.listaFunciones.Find(x => x.Id == Id);
        }

        public bool Eliminar(int Id)
        {
            return listaFunciones.Remove(DameUnElemento(Id));
        }

        public bool Agregar(Funciones element)
        {
            this.listaFunciones.Add(element);
            return true;
        }

        public void Editar(Funciones element)
        {
            throw new NotImplementedException();
        }

        public List<Funciones> Filtra(Expression<Func<Funciones, bool>> predicado)
        {
            throw new NotImplementedException();
        }
    }
}
