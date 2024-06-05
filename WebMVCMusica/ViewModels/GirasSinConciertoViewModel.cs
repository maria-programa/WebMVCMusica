namespace WebMVCMusica.ViewModels
{
    public class GirasSinConciertoViewModel
    {
        public string NombreGira { get; set; }
        public List<Giras> conciertos {get;set;}
    }

    public class Giras
    {
        public string Ciudad { get; set; }
        public DateOnly? Fecha { get; set; }
    }
}
