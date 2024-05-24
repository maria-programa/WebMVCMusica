using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMVCMusica.Models
{
    [ModelMetadataType(typeof(GenerosMetadata))]
    public partial class Generos { }

    public class GenerosMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage =("Obligatorio"))]
        [DisplayName("Genero")]
        public string? Nombre { get; set; }
    }
}
