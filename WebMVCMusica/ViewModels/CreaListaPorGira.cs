
using WebMVCMusica.Models;

namespace WebMVCMusica.ViewModels
{
    public class CreaListaPorGira : ICreaListaPorGira
    {
        private readonly GrupoBContext _context;
        private readonly IGiraSinConciertoBuilder _builder;

        public CreaListaPorGira(GrupoBContext context, IGiraSinConciertoBuilder builder)
        {
            this._context = context;
            this._builder = builder;
        }

        public List<GirasSinConciertoViewModel> dameTodasGiras()
        {
            var GirasDistintas =
                from p in _context.Giras.ToList()
                group p by p.Nombre into g
                select g;
            List<GirasSinConciertoViewModel> girasADevolver = new();
            foreach (var _giraDistinta in GirasDistintas)
            {
                GirasSinConciertoViewModel elementoAPoner = new()
                {
                    NombreGira = _giraDistinta.Key,
                    conciertos = new Gira01(this._context).damePorGira(_giraDistinta.Key).ToList()
                };
                girasADevolver.Add(elementoAPoner);
            }
            return girasADevolver;
        }
    }
}
