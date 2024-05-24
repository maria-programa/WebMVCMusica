using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebMVCMusica.Models
{
    [ModelMetadataType(typeof(PlataformasMetadata))]
    public partial class Plataformas { }

    public class PlataformasMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Es necesario introducir el nombre de la plataforma")]
        public string? Nombre { get; set; }
    }
}
