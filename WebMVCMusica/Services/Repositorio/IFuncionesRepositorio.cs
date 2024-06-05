using WebMVCMusica.Models;

namespace WebMVCMusica.Services.Repositorio
{
    public interface IFuncionesRepositorio
    {
        List<Funciones> DameFunciones();
        Funciones? DameUnaFuncion(int Id);
        bool BorrarFuncion(int Id);
        bool AgregarFuncion(Funciones funcion);
        void ModificarFuncion(int Id, Funciones funcion);
    }
}
