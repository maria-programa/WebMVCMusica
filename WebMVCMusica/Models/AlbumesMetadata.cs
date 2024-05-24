using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace WebMVCMusica.Models
{
    [ModelMetadataType(typeof(AlbumesMetadata))]
    public partial class Albumes { }

    public class AlbumesMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Es necesario meter el nombre del album")]
        [StringLength(200)]
        public string? Nombre { get; set; }

        [DisplayName("Genero")]
        public int? GenerosId { get; set; }

        [DisplayName("Grupo")]
        [Required(ErrorMessage = "Es necesario meter el nombre del grupo/artista")]
        public int? GruposId { get; set; }

        [DataType(DataType.Date)]
        public DateOnly? Fecha { get; set; }

        [DisplayName("Genero")]
        public virtual Generos? Generos { get; set; }

        [DisplayName("Grupo")]
        public virtual Grupos? Grupos { get; set; }
    }
}
