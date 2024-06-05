
using WebMVCMusica.Models;

namespace WebMVCMusica.ViewModels
{
    public class Gira01 : IGiraSinConciertoBuilder
    {
        private readonly GrupoBContext _context;

        public Gira01(GrupoBContext context)
        {
            this._context = context;
        }
        public List<Giras> damePorGira(string nombre)
        {
            var resultado =
                from gira in this._context.Giras
                join concierto in this._context.Conciertos
                    on gira.Id equals concierto.GirasId
                where gira.Nombre == nombre
                select new Giras()
                {
                    Ciudad = concierto.Ciudades.Nombre,
                    Fecha = concierto.Fecha
                };
            return resultado.ToList();
        }
    }
}
