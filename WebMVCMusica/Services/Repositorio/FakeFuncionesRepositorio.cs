using WebMVCMusica.Models;

namespace WebMVCMusica.Services.Repositorio
{
    public class FakeFuncionesRepositorio : IFuncionesRepositorio
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

        public List<Funciones> DameFunciones()
        {
            return this.listaFunciones;
        }

        public Funciones? DameUnaFuncion(int Id)
        {
            return this.listaFunciones.Find(x => x.Id==Id);
        }

        public bool BorrarFuncion(int Id)
        {
            return listaFunciones.Remove(DameUnaFuncion(Id));
        }

        public bool AgregarFuncion(Funciones funcion)
        {
            this.listaFunciones.Add(funcion);
            return true;
        }

        public void ModificarFuncion(int Id, Funciones funcion)
        {
            BorrarFuncion(Id);
            AgregarFuncion(funcion);
        }
    }
}
