using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace WebMVCMusica.Models
{
    [ModelMetadataType(typeof(ArtistasMetadata))]
    public partial class Artistas { }

    public class ArtistasMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Es necesario meter el nombre del artista")]
        [StringLength(200)]
        public string? Nombre { get; set; }

        [DisplayName("Genero")]
        public int? GenerosId { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Fecha de Nacimiento")]
        public DateOnly? FechaDeNacimiento { get; set; }

        [DisplayName("Ciudad")]
        public int? CiudadesId { get; set; }

        [DisplayName("Grupo")]
        public int? GruposId { get; set; }

        [DisplayName("Ciudad")]
        public virtual Ciudades? Ciudades { get; set; }

        [DisplayName("Genero")]
        public virtual Generos? Generos { get; set; }

        [DisplayName("Grupo")]
        public virtual Grupos? Grupos { get; set; }
    }
}
